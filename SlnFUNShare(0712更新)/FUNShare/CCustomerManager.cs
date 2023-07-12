using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FUNShare.Models
{
    public class CCustomerManager
    {
        FUNShareEntities FunShareDB = new FUNShareEntities();

        //comboBoxDistrict導入所有行政區
        public void LoadcomboBoxDistrict(ComboBox comboBoxDistrict)
        {
            comboBoxDistrict.Items.Clear();
            comboBoxDistrict.Items.Add("");
            foreach (var District in FunShareDB.Districts)
            {
                comboBoxDistrict.Items.Add(District.District_Name);
            }
            comboBoxDistrict.SelectedIndex = 0;
        }

        //comboBoxDistrict導入所有行政區
        public void LoadcomboBoxCity(ComboBox comboBoxCity)
        {
            comboBoxCity.Items.Clear();
            comboBoxCity.Items.Add("全縣市");
            foreach (var City in FunShareDB.Cities)
            {
                comboBoxCity.Items.Add(City.City_Name);
            }
            comboBoxCity.SelectedIndex = 0;
        }

        //年齡區間變數
        public int AgeFrom;
        public int AgeTo;
        //確認欲查詢的年齡區間
        public bool CheckAgeRange(string From, string To)
        {
            if (From != "" || To != "")
            {
                if ((!int.TryParse(From, out AgeFrom)) || !int.TryParse(To, out AgeTo))
                {
                    MessageBox.Show("請輸入正確年齡區間");
                    return false;
                }
            }
            else
            {
                AgeFrom = -1;
                AgeTo = 100;
            }
            return true;
        }

        //將欄位加上必填
        public string AddRequired(string RequiredText)
        {
            return "*" + RequiredText;
        }

        //導入會員的親屬關係
        public void LoadRelatives(TreeView treeView, int memberID, int parentID)
        {
            treeView.Nodes.Clear();
            CreateParentNode(treeView, memberID, parentID);
            treeView.ExpandAll();
        }
        //遞迴增加小孩節點
        private void CreateChildNode(TreeView AllNode, int NowMemberID, string NowParentName)
        {
            var ChildList = (from child in FunShareDB.Customer_Infomation.AsEnumerable()
                             where child.ParentID == NowMemberID
                             select child).ToList();
            if (ChildList.Count == 0)
                return;
            else
            {
                foreach (var child in ChildList)
                {
                    //找父母節點的位置
                    TreeNode[] nodes = AllNode.Nodes.Find(NowParentName, true);
                    //在該節點位置加入新節點
                    nodes[0].Nodes.Add(child.Name, child.Name);

                    CreateChildNode(AllNode, child.Member_ID, child.Name);
                }
            }
        }

        //找最上層的父母節點
        private void CreateParentNode(TreeView AllNode, int NowMemberID, int NowParentID)
        {
            var Parent = (from parent in FunShareDB.Customer_Infomation
                          where parent.Member_ID == NowParentID
                          select parent).ToList();
            var My = (from customer in FunShareDB.Customer_Infomation
                      where customer.Member_ID == NowMemberID
                      select customer).ToList();
            string MyName = My[0].Name;
            //找到最上層的家長
            if (Parent.Count == 0)
            {
                AllNode.Nodes.Add(MyName, MyName);

                CreateChildNode(AllNode, NowMemberID, MyName);
                return;
            }
            else
            {
                NowMemberID = NowParentID;

                if (Parent[0].ParentID != null)
                    NowParentID = Parent[0].ParentID.Value;
                else
                    NowParentID = 0;
                CreateParentNode(AllNode, NowMemberID, NowParentID);
            }

        }
    }
}
