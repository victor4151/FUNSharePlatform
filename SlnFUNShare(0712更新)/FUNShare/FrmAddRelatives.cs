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
    public partial class FrmAddRelatives : Form
    {
        public FrmAddRelatives()
        {
            InitializeComponent();

            Required();

            this.pictureBox1.AllowDrop = true;
            this.pictureBox1.DragEnter += PictureBox1_DragEnter;
            this.pictureBox1.DragDrop += PictureBox1_DragDrop;
        }
        FUNShareEntities FunShareDB = new FUNShareEntities();
        CCustomerManager CManager = new CCustomerManager();

        //呼叫新增親屬關係的會員ID
        public int OldMemberID { get; set; }

        //必填欄位的Label加上*
        private void Required()
        {
            //必填Required：姓名、身份證字號、性別、生日、過敏

            //姓名
            labName.Text = CManager.AddRequired(labName.Text);
            //身份證字號
            labIDNumber.Text = CManager.AddRequired(labIDNumber.Text);
            //性別
            labGender.Text = CManager.AddRequired(labGender.Text);
            //生日
            labBirth.Text = CManager.AddRequired(labBirth.Text);
            //過敏
            labAllergy.Text = CManager.AddRequired(labAllergy.Text);
        }

        //PictureBox1拖入的圖片轉資料流顯示
        private void PictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            //MessageBox.Show("DragDrop");

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            this.pictureBox1.Image = Image.FromFile(files[0]);

        }

        //PictureBox1可拖入圖片
        private void PictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        //新增親屬按鈕
        private void btnAddRelatives_Click(object sender, EventArgs e)
        {
                if (CheckInfomation())
                {
                    AddRelatives();
                    this.Close();
                }
                else
                MessageBox.Show("資料輸入有誤，無法新增");
        }

        //確認欲新增的親屬資料是否正確填寫(符合格式)
        private bool CheckInfomation()
        {
            if (labNameError.Text != string.Empty)
                return false;
            if (labIDNumberError.Text != string.Empty)
                return false;
            //生日一定有資料(dateTimePickerBirth)，不特別判斷

            //過敏為單選，預設否，不特別判斷
            return true;
        }

        //新增親屬到資料庫並儲存
        private void AddRelatives()
        {
            //尋找開啟表單的會員
            var OldMember = (from customerMember in FunShareDB.Customer_Infomation
                    where customerMember.Member_ID == OldMemberID
                    select customerMember).ToList();

            //親屬註冊狀態判斷
            var NewMember = (from customerMember in FunShareDB.Customer_Infomation
                             where customerMember.Resident_ID == txtIDNumber.Text
                             select customerMember).ToList();

            Customer_Infomation customer = new Customer_Infomation();

            //是否已有該親屬(會員資料)
            bool Memberflag;
            if (NewMember.Count != 0)
            {
                if (NewMember[0].Status_ID == 2)
                    customer = SaveInfomation(NewMember[0]);
                else
                {
                    customer = NewMember[0];
                    MessageBox.Show("該人員已註冊為會員，無法修改其會員資料");
                }
                Memberflag = true;
            }
            else
            {
                customer.Status_ID = 2;
                customer = SaveInfomation(customer);
                Memberflag = false;
            }

            //親屬註冊狀態
            if (!Memberflag)
            {
                this.FunShareDB.Customer_Infomation.Add(customer);
                this.FunShareDB.SaveChanges();
            }

            //親屬關係
            if (RadiobtnParent.Checked == true)
            {
                if(OldMember[0].ParentID == null)
                {
                    OldMember[0].ParentID = customer.Member_ID;
                    MessageBox.Show("已更新親屬關聯");
                }
                else
                {
                    if (OldMember[0].ParentID == customer.Member_ID)
                        MessageBox.Show("您曾綁定過該成員為您的父母，已取消新增親屬關聯");
                    else
                    {
                        DialogResult = MessageBox.Show("您先前綁定過其他會員為您的父母，請問是否需做變更", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if(DialogResult == DialogResult.OK)
                        {
                            OldMember[0].ParentID = customer.Member_ID;
                            MessageBox.Show("已更新親屬關聯");
                        }
                        else
                            MessageBox.Show("已取消新增親屬關聯");
                    }
                }
            }
            else
            {
                if (customer.ParentID == null)
                {
                    customer.ParentID = OldMember[0].Member_ID; 
                    MessageBox.Show("已更新親屬關聯");
                }

                else
                {
                    if (customer.ParentID == OldMember[0].Member_ID)
                        MessageBox.Show("您曾綁定過該會員為您的小孩，已取消新增親屬關聯");
                    else
                    {
                        MessageBox.Show("該會員先前綁定過其他會員為父母，無法變更", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        MessageBox.Show("已取消新增親屬關聯");
                    }
                }
            }


            this.FunShareDB.SaveChanges();
        }

        private Customer_Infomation SaveInfomation(Customer_Infomation customer)
        {
            //姓名
            customer.Name = txtName.Text;
            //身分證字號
            customer.Resident_ID = txtIDNumber.Text;
            //Email
            customer.Email = "None";
            //密碼
            customer.Password = "None";
            //性別
            if (RadiobtnMale.Checked == true)
                customer.Gender = "M";
            else if (RadiobtnFemale.Checked == true)
                customer.Gender = "F";
            else
                customer.Gender = "S";
            //生日
            customer.Birth_Date = dateTimePickerBirth.Value;
            //過敏
            if (RadiobtnAllergyYes.Checked == true)
            {
                customer.IsAllergy_ = true;
                if (RichtxtAllergyHistory.Text != "")
                    customer.AllergyDescription = RichtxtAllergyHistory.Text;
                else
                    customer.AllergyDescription = null;
            }
            else
            {
                customer.IsAllergy_ = false;
                customer.AllergyDescription = null;
            }
            //照片
            if (pictureBox1.Image != null)
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] bytes = new byte[ms.Length];
                bytes = ms.GetBuffer();
                customer.Photo = bytes;
            }
            return customer;
        }

        //確認是否過敏(是=>顯示過敏史)
        private void RadiobtnAllergyYes_CheckedChanged(object sender, EventArgs e)
        {
            if (RadiobtnAllergyYes.Checked == true)
            {
                labAllergyHistory.Visible = true;
                RichtxtAllergyHistory.Visible = true;
            }
        }

        //確認是否過敏(否=>不顯示過敏史)
        private void RadiobtnAllergyNo_CheckedChanged(object sender, EventArgs e)
        {
            if (RadiobtnAllergyNo.Checked == true)
            {
                labAllergyHistory.Visible = false;
                RichtxtAllergyHistory.Visible = false;
                RichtxtAllergyHistory.Text = string.Empty;
            }
        }

        //使用openFileDialog新增圖片
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        //姓名是否有輸入
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text == "")
                labNameError.Text = "請輸入姓名";
            else
                labNameError.Text = string.Empty;
        }

        //身分證字號是否有輸入
        private void txtIDNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtIDNumber.Text == "")
                labIDNumberError.Text = "請輸入身分證字號";
            else
                labIDNumberError.Text = string.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
