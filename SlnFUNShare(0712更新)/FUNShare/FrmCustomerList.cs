using FUNShare;
using FUNShare.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUNShare
{
    public partial class FrmCustomerList : Form
    {
        public FrmCustomerList()
        {
            InitializeComponent();

            CManager.LoadcomboBoxCity(comboBoxCity);
        }
        FUNShareEntities FunShareDB = new FUNShareEntities();
        CCustomerManager CManager = new CCustomerManager();

        //搜尋會員
        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            //確保連線是最新的DB資料內容
            FunShareDB = new FUNShareEntities();

            if (CheckSearchCondition())
            {
                var q = from Customer in FunShareDB.Customer_Infomation.AsEnumerable()
                        where SearchCustomer(Customer)
                        select new CCustomer
                        {
                            會員編號 = Customer.Member_ID,
                            身分證字號 = Customer.Resident_ID,
                            家長會員編號 = Customer.ParentID,
                            會員姓名 = Customer.Name,
                            性別 = Customer.Gender,
                            手機號碼 = Customer.Phone_Number,
                            電子信箱 = Customer.Email,
                            行政區編號 = Customer.Disctrict_ID,
                            住址 = Customer.Address,
                            生日 = Customer.Birth_Date,
                            暱稱 = Customer.Nickname,
                            密碼 = Customer.Password,
                            是否過敏 = Customer.IsAllergy_,
                            過敏病徵描述 = Customer.AllergyDescription,
                            備註 = Customer.Note,
                            狀態編號 = Customer.Status_ID,
                            會員照片 = Customer.Photo,
                        };
                this.bindingSource1.DataSource = q.ToList();
                this.dataGridView1.DataSource = bindingSource1;
                //MessageBox.Show("已搜尋");
            }
        }

        //確認欲搜尋的會員資料是否正確填寫(符合格式)
        private bool CheckSearchCondition()
        {
            if(!CManager.CheckAgeRange(txtAgeFrom.Text, txtAgeTo.Text))
                return false;
            if (CustomerGender == "Error")
            {
                MessageBox.Show("請勾選查詢性別");
                return false;
            }
            if (CustomerStatus[0] == 0)
            {
                MessageBox.Show("請勾選查詢狀態");
                return false;
            }
            return true;
        }

        //會員篩選
        private bool SearchCustomer(Customer_Infomation customer)
        {
            //string Name, string IDNumber, string Email, string Phone, int DisctrictID, int StatusID, string Gender, int Age
            //姓名
            if (!(customer.Name.Contains(txtName.Text)) && txtName.Text != "")
                return false;
            //身分證字號
            if (txtIDNumber.Text != customer.Resident_ID && txtIDNumber.Text != "")
                return false;
            //Email
            if (txtEmail.Text != customer.Email && txtEmail.Text != "")
                return false;
            //電話
            if (txtPhone.Text != customer.Phone_Number && txtPhone.Text != "")
                return false;
            //城市
            if (comboBoxCity.Text != "全縣市")
            {
                if (customer.District != null)
                {
                     if(customer.District.City.City_Name != comboBoxCity.Text)
                        return false;
                }
                else
                    return false;
            }
            //狀態
            bool flag = false;
            for (int i = 1; i <= 3; i ++)
            {
                if (CustomerStatus[i] == 1 && i == customer.Status_ID)
                    flag = true;
            }
            if (flag == false)
                return false;
            //性別
            if(customer.Gender != "S")
            {
                if ((CustomerGender != customer.Gender && CustomerGender != ""))
                    return false;
            }
            //年齡區間
            if ((DateTime.Now.Year - customer.Birth_Date.Year) <= CManager.AgeFrom || (DateTime.Now.Year - customer.Birth_Date.Year) >= CManager.AgeTo)
                return false;
            return true;
        }

        //變數(欲搜尋的會員性別)
        string CustomerGender = "";

        //確認欲搜尋的會員性別
        private void CheckCustomerGender(object sender, EventArgs e)
        {
            if (checkBoxMale.Checked == true && checkBoxFemale.Checked == true)
                CustomerGender = "";
            else if (checkBoxMale.Checked == true)
                CustomerGender = "M";
            else if(checkBoxFemale.Checked == true)
                CustomerGender = "F";
            else
                CustomerGender = "Error";
        }

        //變數(欲搜尋的會員狀態)
        int[] CustomerStatus = { 1, 1, 1, 1 };

        //確認欲搜尋的會員狀態
        private void CheckCustomerStatus(object sender, EventArgs e)
        {
            //已註冊
            if (checkBoxRegistered.Checked == true)
                CustomerStatus[1] = 1;
            else
                CustomerStatus[1] = 0;
            //未註冊
            if(checkBoxUnregistered.Checked == true)
                    CustomerStatus[2] = 1;
            else
                CustomerStatus[2] = 0;
            //停權中
            if (checkBoxSuspension.Checked == true)
                CustomerStatus[3] = 1;
            else
                CustomerStatus[3] = 0;

            CustomerStatus[0] = 0;
            foreach (int Status in CustomerStatus)
            {
                if(Status == 1)
                    CustomerStatus[0] = 1;
            }
        }

        //清除所有篩選條件
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtIDNumber.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            //城市
            comboBoxCity.SelectedIndex = 0;
            //性別
            checkBoxMale.Checked = true;
            checkBoxFemale.Checked = true;
            //狀態
            checkBoxRegistered.Checked = true;
            checkBoxUnregistered.Checked = true;
            checkBoxSuspension.Checked = true;
            //年齡區間
            txtAgeFrom.Text = string.Empty;
            txtAgeTo.Text = string.Empty;
        }

        //點擊dataGridView並打開會員明細表單
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmCustomerDetail frmCustomerDetail = new FrmCustomerDetail();
            if ((int.TryParse(dataGridView1.CurrentRow.Cells["會員編號"].Value.ToString(), out int memberID)))
                frmCustomerDetail.MemberID = memberID;
            if (dataGridView1.CurrentRow.Cells["家長會員編號"].Value != null)
            {
                if ((int.TryParse(dataGridView1.CurrentRow.Cells["家長會員編號"].Value.ToString(), out int parentID)))
                    frmCustomerDetail.ParentID = parentID;
            }
            if (memberID != 0)
                frmCustomerDetail.ShowDialog();

            //立即更新查詢結果
            btnSearchCustomer_Click(sender, e);
        }
    }
}
