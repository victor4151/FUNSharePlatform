using FUNShare;
using FUNShare.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FUNShare
{
    public partial class FrmCustomerDetail : Form
    {
        public FrmCustomerDetail()
        {
            InitializeComponent();

            Required();
            CManager.LoadcomboBoxDistrict(comboBoxDistrict);

            this.pictureBox1.AllowDrop = true;
            this.pictureBox1.DragEnter += PictureBox1_DragEnter;
            this.pictureBox1.DragDrop += PictureBox1_DragDrop;
        }

        //呼叫明細時傳入的會員ID&父母ID
        public int MemberID { get; set; }
        public int ParentID { get; set; }

        FUNShareEntities FunShareDB = new FUNShareEntities();
        CCustomerManager CManager = new CCustomerManager();

        //必填欄位的Label加上*
        private void Required()
        {
            //必填Required：姓名、身份證字號、性別、Email、生日、過敏

            //姓名
            labName.Text = CManager.AddRequired(labName.Text);
            //身份證字號
            labIDNumber.Text = CManager.AddRequired(labIDNumber.Text);
            //性別
            labGender.Text = CManager.AddRequired(labGender.Text);
            //Email
            labEmail.Text = CManager.AddRequired(labEmail.Text);
            //生日
            labBirth.Text = CManager.AddRequired(labBirth.Text);
            //過敏
            labAllergy.Text = CManager.AddRequired(labAllergy.Text);
        }

        //開啟表單時導入會員資料
        private void FrmCustomerDetail_Load(object sender, EventArgs e)
        {
            LoadCustomerDetail();
        }

        //導入會員資料
        private void LoadCustomerDetail()
        {
            var q = (from customer in FunShareDB.Customer_Infomation
                     where customer.Member_ID == MemberID
                     select customer).ToList();
            //姓名
            txtName.Text = q[0].Name;
            //身分證字號
            txtIDNumber.Text = q[0].Resident_ID;
            //Email
            txtEmail.Text = q[0].Email;
            //電話
            txtPhone.Text = q[0].Phone_Number;
            //性別
            if (q[0].Gender == "M")
                RadiobtnMale.Checked = true;
            else if (q[0].Gender == "F")
                RadiobtnFemale.Checked = true;
            else
                RadiobtnSecret.Checked = true;
            //生日
            dateTimePickerBirth.Value = q[0].Birth_Date;
            //暱稱
            txtNickName.Text = q[0].Nickname;
            //行政區
            if (int.TryParse(q[0].Disctrict_ID.ToString(), out int DisctrictID))
            {
                comboBoxDistrict.SelectedIndex = DisctrictID;
            }
            else
                comboBoxDistrict.SelectedIndex = 0;
            //地址
            txtAddress.Text = q[0].Address;
            //過敏
            if (q[0].IsAllergy_)
            {
                RadiobtnAllergyYes.Checked = true;
                RichtxtAllergyHistory.Text = q[0].AllergyDescription;
            }
            else
                RadiobtnAllergyNo.Checked = true;
            //照片
            if (q[0].Photo != null)
            {
                byte[] bytes = q[0].Photo;
                System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                pictureBox1.Image = Image.FromStream(ms);
            }

            CManager.LoadRelatives(this.treeView1,MemberID,ParentID);
            CheckIsSuspension();
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

        //修改並儲存會員按鈕
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckInfomation())
            {
                SaveCustomerDetail();
                MessageBox.Show("已儲存");
            }
            else
                MessageBox.Show("請確認輸入資料是否有誤");
        }

        //確認欲修改的會員資料是否正確填寫(符合格式)
        private bool CheckInfomation()
        {
            if(labNameError.Text != string.Empty)
                return false;
            if (labIDNumberError.Text != string.Empty)
                return false;
            if(labEmailError.Text != string.Empty) 
                return false;
            //生日一定有資料(dateTimePickerBirth)，不特別判斷

            //過敏為單選，Load時就有資料了，不特別判斷
            //else if (RadiobtnAllergyYes.Checked == false && RadiobtnAllergyNo.Checked == false)
            //    MessageBox.Show("請勾選是否過敏");

            return true;
        }

        //修改會員資料到資料庫並儲存
        private void SaveCustomerDetail()
        {
            var q = (from customer in FunShareDB.Customer_Infomation
                     where customer.Member_ID == MemberID
                     select customer).ToList();
            //姓名
            q[0].Name = txtName.Text;
            //身分證字號
            q[0].Resident_ID = txtIDNumber.Text;
            //Email
            q[0].Email = txtEmail.Text;
            //電話
            if (txtPhone.Text != "")
                q[0].Phone_Number = txtPhone.Text;
            else
                q[0].Phone_Number = null;
            //性別
            if (RadiobtnMale.Checked == true)
                q[0].Gender = "M";
            else if (RadiobtnFemale.Checked == true)
                q[0].Gender = "F";
            else
                q[0].Gender = "S";
            //生日
            q[0].Birth_Date = dateTimePickerBirth.Value;
            //暱稱
            if (txtNickName.Text != "")
                q[0].Nickname = txtNickName.Text;
            else
                q[0].Nickname = null;
            //行政區
            if (comboBoxDistrict.SelectedIndex != 0)
                q[0].Disctrict_ID = comboBoxDistrict.SelectedIndex;
            else
                q[0].Disctrict_ID = null;
            //地址
            if(txtAddress.Text != "")
                q[0].Address = txtAddress.Text;
            else
                q[0].Address = null;
            //過敏
            if (RadiobtnAllergyYes.Checked == true)
            {
                q[0].IsAllergy_ = true;
                if(RichtxtAllergyHistory.Text != "")
                    q[0].AllergyDescription = RichtxtAllergyHistory.Text;
                else
                    q[0].AllergyDescription = null;
            }
            else
            {
                q[0].IsAllergy_ = false;
                q[0].AllergyDescription = null;
            }
            //照片
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] bytes = new byte[ms.Length];
            bytes = ms.GetBuffer();
            q[0].Photo = bytes;

            this.FunShareDB.SaveChanges();
        }

        //確認是否過敏(是=>顯示過敏史)
        private void RadiobtnAllergyYes_CheckedChanged(object sender, EventArgs e)
        {
            if(RadiobtnAllergyYes.Checked == true)
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

        private void btnSuspension_Click(object sender, EventArgs e)
        {
            var q = (from customer in FunShareDB.Customer_Infomation
                     where customer.Member_ID == MemberID
                     select customer).ToList();

            if (q[0].Status_ID == 1)
            {
                q[0].Status_ID = 3;
                MessageBox.Show("此會員帳號已停權");
            }
            //else if(q[0].Status_ID == 2)
            //    MessageBox.Show("此會員尚未註冊，無法停權");
            else
            {
                q[0].Status_ID = 1;
                MessageBox.Show("此會員帳號已復原");
            }
            this.FunShareDB.SaveChanges();

            CheckIsSuspension();
        }
        private void CheckIsSuspension()
        {
            var q = (from customer in FunShareDB.Customer_Infomation
                     where customer.Member_ID == MemberID
                     select customer).ToList();

            if (q[0].Status_ID == 1)
            {
                btnSuspension.Enabled = true;
                btnSuspension.Text = "停權此會員帳戶";
            }
            else if (q[0].Status_ID == 2)
            {
                btnSuspension.Enabled = false;
                btnSuspension.Text = "此用戶尚未註冊";
            }
            else
            {
                btnSuspension.Enabled = true;
                btnSuspension.Text = "復原此會員帳戶";
            }
        }
    }
}
