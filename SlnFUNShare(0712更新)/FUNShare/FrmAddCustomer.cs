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
    public partial class FrmAddCustomer : Form
    {
        public FrmAddCustomer()
        {
            InitializeComponent();

            Required();
            CManager.LoadcomboBoxDistrict(comboBoxDistrict);

            this.pictureBox1.AllowDrop = true;
            this.pictureBox1.DragEnter += PictureBox1_DragEnter;
            this.pictureBox1.DragDrop += PictureBox1_DragDrop;
        }
        FUNShareEntities FunShareDB = new FUNShareEntities();
        CCustomerManager CManager = new CCustomerManager();
        //必填欄位的Label加上*
        private void Required()
        {
            //必填Required：姓名、身份證字號、性別、Email、生日、過敏
            //必填Required：密碼、確認密碼 一致

            //姓名
            labName.Text = CManager.AddRequired(labName.Text);
            //身份證字號
            labIDNumber.Text = CManager.AddRequired(labIDNumber.Text);
            //性別
            labGender.Text = CManager.AddRequired(labGender.Text);
            //Email
            labEmail.Text = CManager.AddRequired(labEmail.Text);
            //密碼
            labPassword.Text = CManager.AddRequired(labPassword.Text);
            //確認密碼
            labSurePassword.Text = CManager.AddRequired(labSurePassword.Text);
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

        //新增會員按鈕
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckInfomation())
            {
                int memberID;
                memberID = AddCustomer();
                //MessageBox.Show("已註冊\n請重新登入");
                //改成新增親屬關係
                DialogResult = MessageBox.Show("已註冊\n是否立即新增親屬(父母or孩子)", "註冊成功", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                while (DialogResult == DialogResult.OK)
                {
                    FrmAddRelatives frmAddRelatives = new FrmAddRelatives();
                    frmAddRelatives.OldMemberID = memberID;
                    frmAddRelatives.ShowDialog();
                    if (frmAddRelatives.DialogResult == DialogResult.OK)
                        DialogResult = MessageBox.Show("是否繼續新增親屬(父母or孩子)", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                MessageBox.Show("請重新登入");
                this.Close();
            }
            else
                MessageBox.Show("請確認輸入資料是否有誤");
        }

        //確認欲新增的會員資料是否正確填寫(符合格式)
        private bool CheckInfomation()
        {
            if (labNameError.Text != string.Empty)
                return false;
            if (labIDNumberError.Text != string.Empty)
                return false;
            if (labEmailError.Text != string.Empty)
                return false;
            if (labPasswordError.Text != string.Empty)
                return false;
            if (labSurePasswordError.Text != string.Empty)
                return false;
            //生日一定有資料(dateTimePickerBirth)，不特別判斷

            //過敏為單選，預設否，不特別判斷

            return true;
        }

        //新增會員到資料庫並儲存
        private int AddCustomer()
        {
            //會員註冊狀態判斷
            var NewMember = (from customerMember in FunShareDB.Customer_Infomation
                             where customerMember.Resident_ID == txtIDNumber.Text
                             select customerMember).ToList();

            Customer_Infomation customer = new Customer_Infomation();

            //是否已有該會員
            bool Memberflag;
            if (NewMember.Count != 0)
            {
                customer = SaveInfomation(NewMember[0]);
                Memberflag = true;
            }
            else
            {
                customer = SaveInfomation(customer);
                Memberflag = false;
            }

            customer.Status_ID = 1;
            //會員註冊狀態
            if (!Memberflag)
            {
                this.FunShareDB.Customer_Infomation.Add(customer);
                this.FunShareDB.SaveChanges();
            }

            this.FunShareDB.SaveChanges();

            return customer.Member_ID;
        }

        private Customer_Infomation SaveInfomation(Customer_Infomation customer)
        {
            //姓名
            customer.Name = txtName.Text;
            //身分證字號
            customer.Resident_ID = txtIDNumber.Text;
            //Email
            customer.Email = txtEmail.Text;
            //密碼
            customer.Password = txtPassword.Text;
            //電話
            if (txtPhone.Text != "")
                customer.Phone_Number = txtPhone.Text;
            else
                customer.Phone_Number = null;
            //性別
            if (RadiobtnMale.Checked == true)
                customer.Gender = "M";
            else if (RadiobtnFemale.Checked == true)
                customer.Gender = "F";
            else
                customer.Gender = "S";
            //生日
            customer.Birth_Date = dateTimePickerBirth.Value;
            //暱稱
            if (txtNickName.Text != "")
                customer.Nickname = txtNickName.Text;
            else
                customer.Nickname = null;
            //行政區
            if (comboBoxDistrict.SelectedIndex != 0)
                customer.Disctrict_ID = comboBoxDistrict.SelectedIndex;
            else
                customer.Disctrict_ID = null;
            //地址
            if (txtAddress.Text != "")
                customer.Address = txtAddress.Text;
            else
                customer.Address = null;
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

        //Email是否有輸入
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
                labEmailError.Text = "請輸入Email";
            else
                labEmailError.Text = string.Empty;
        }

        //密碼是否有輸入&長度是否正確
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
                labPasswordError.Text = "請輸入密碼";
            else if(txtPassword.Text.Length < 8 || txtPassword.Text.Length > 12)
                labPasswordError.Text = "密碼長度需介於8 - 12個字元";
            else
                labPasswordError.Text = string.Empty;
        }

        //確認密碼是否有輸入&與密碼是否相符
        private void txtSurePassword_TextChanged(object sender, EventArgs e)
        {
            if (txtSurePassword.Text == "")
                labSurePasswordError.Text = "請輸入確認密碼";
            else if(txtPassword.Text != txtSurePassword.Text)
                labSurePasswordError.Text = "密碼與確認密碼不符，請重新輸入";
            else
                labSurePasswordError.Text = string.Empty;
        }
    }
}
