using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using FUNShare;
using FUNShare.Models;

namespace  FUNShare
{
    public partial class FrmSupplierList : Form
    {
        FUNShareEntities dbcontext = new FUNShareEntities();//連DB
        //FUNShareEntities1 dbcontext = new FUNShareEntities1();//本地DB
        private CSupplierManage supplierManager; // 建立 CSupplierManage 物件
        public FrmSupplierList()
        {
            InitializeComponent();
          //  Loadcitydata();
            manage.Loadcitydata(comboBoxCity);//manageloadcitydata
            Loadsupplierdata();
            dataGridView1.CellClick += DataGridView1_CellClick; ;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count - 1)
            {
                int supplierID = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["供應商編號"].Value);
                FrmSupplierDetail frmSD = new FrmSupplierDetail();
                frmSD.Supplier_ID = supplierID;
                frmSD.ShowDialog();
            }
        }

        private void Loadsupplierdata()//載入供應商資料
        {
            var q = from supplier in dbcontext.Suppliers
                    select new {
                        供應商編號 = supplier.Supplier_ID,
                        供應商統一編號 = supplier.Tax_ID,
                        供應商名稱 = supplier.Supplier_Name,
                        連絡電話 = supplier.Supplier_Phone,
                        聯絡人 = supplier.Contact_Person,
                        電子郵件 = supplier.Email,
                        供應商所在城市 = supplier.City.City_Name,
                        供應商Logo = supplier.Logo_Image,
                        傳真 = supplier.Fax,
                        供應商地址 = supplier.Address,
                        狀態 = supplier.Status.Description,
                        備註 = supplier.Description
                    };
            dataGridView1.DataSource = q.ToList();       
        }

        private void Loadcitydata()//載入城市資料
        {
            var q = from c in dbcontext.Cities

                    select c;
            comboBoxCity.DataSource = q.ToList();
            comboBoxCity.DisplayMember = "City_Name"; // 設定要顯示的文字欄位名稱
                                                      // comboBoxCity.ValueMember = "City_ID"; // 設定對應的值欄位名稱
            comboBoxCity.SelectedIndex = -1;
        }
        CSupplierManage  manage = new CSupplierManage();//manageloadcitydata

        private void btnSearchCustomer_Click(object sender, EventArgs e)//查詢
        {
            
            //載入supplier的資料
            string s = null;
            var query = from supplier in dbcontext.Suppliers
                        select supplier;
            //複合查詢開始
            if (txtName.Text != "")//查詢廠商名稱
            {
                query = query.Where(supplier => supplier.Supplier_Name.Contains(txtName.Text));
            }

            if (txtIDNumber.Text != "")//查詢統一編號
            {
                query = query.Where(supplier => supplier.Tax_ID.Contains(txtIDNumber.Text));
            }

            if (txtEmail.Text != "")//查詢廠商E-mail
            {
                query = query.Where(supplier => supplier.Email.Contains(txtEmail.Text));
            }
            if (txtPhone.Text != "")//查詢廠商電話
            {
                query = query.Where(supplier => supplier.Supplier_Phone.Contains(txtPhone.Text));
            }
            if (comboBoxStatus.Text != "")//查詢廠商狀態
            {
                s = comboBoxStatus.Text;
                switch (s)
                {
                    case "審核通過":
                        s = 14.ToString();
                        break;
                    case "審核未通過":
                        s = 15.ToString();
                        break;
                    default:
                        s = 16.ToString();
                        break;
                }        
                    query = query.Where(supplier => supplier.Status_ID.ToString() == s);              
            }
            if (comboBoxCity.Text != "")//查詢城市資料
            {
                query = query.Where(supplier => supplier.City.City_Name == comboBoxCity.Text);
                //query = query.Where(supplier => supplier.Products.First().Product_Detail.First().District.City.City_Name == comboBoxCity.Text);
            }
            //=============
            //只顯示需要資訊//內容放在CSupplier
            var result = query.Select(supplier => new
            {
                供應商編號=supplier.Supplier_ID,
                供應商統一編號=supplier.Tax_ID,
                供應商名稱=supplier.Supplier_Name,
                連絡電話=supplier.Supplier_Phone,
                電子郵件=supplier.Email,
                聯絡人=supplier.Contact_Person,
                供應商所在城市=supplier.City.City_Name,
                供應商Logo=supplier.Logo_Image,
                傳真=supplier.Fax,
                供應商地址=supplier.Address,
                狀態=supplier.Status.Description,
                備註=supplier.Description
            }).ToList();
            //=============
            dataGridView1.DataSource = result.ToList();
                     
        }

        private void ClearSearchtext()//查詢完畢後清除欄位
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtIDNumber.Text = "";
            comboBoxStatus.Text = "";
            comboBoxCity.DataSource = null;
            comboBoxCity.Items.Clear();
        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)//對應修改報表的資訊
        {

        }

        private void comboBoxCity_DropDown(object sender, EventArgs e)//重新將city資料載入
        {
           // Loadcitydata();
           manage.Loadcitydata(comboBoxCity);//manageloadcitydata
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            FrmSupplierAddSupplierInformation frmSAI = new FrmSupplierAddSupplierInformation();
            frmSAI.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearSearchtext();
        }
    }
}
