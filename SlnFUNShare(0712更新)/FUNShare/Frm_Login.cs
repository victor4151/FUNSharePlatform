using FUNShare;
using FUNShare.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUNShare
{
    public partial class Frm_Login : Form
    {
        FUNShareEntities funshare = new FUNShareEntities();
        public delegate void ValueSelectedHandler(string m,string p);
        public event ValueSelectedHandler loginmood;
        public event ValueSelectedHandler example;

        public delegate void Close();
        public event Close exit;
        
        public Frm_Login()
        {
            InitializeComponent();
            UpdateValidationCode();//驗證碼預設跟重製共用
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string ID = txtAccount.Text;
            string password = txtPassword.Text;
            string loin =txtCheck.Text;
            if (string.IsNullOrEmpty(ID) )
            {
                MessageBox.Show("請輸入您的帳號(Email)");
            }
            else if (string.IsNullOrEmpty(password) )
            {
                MessageBox.Show("請輸入您的密碼");
            }
            else if (string.IsNullOrEmpty(loin))
            {
                MessageBox.Show("請輸入您的驗證碼");
            }
            else
            {
                var q = (from n in funshare.Customer_Infomation
                        where n.Email == ID  
                        select new
                        {
                            account = n.Email,
                            password = n.Password,
                            Name = n.Name,
                        }).ToList();

                if (q[0].account.ToString() == ID && q[0].password.ToString() == password && txtCheck.Text == validationCode.ToUpper())
                {
                    loginmood(ID,password);
                    //MessageBox.Show("登入成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("帳號或密碼錯誤");
                    UpdateValidationCode();
                }
            }
        }

        private void labForget_Click(object sender, EventArgs e)
        {
            (new FrmForgetPassword()).ShowDialog();
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            UpdateValidationCode();//共用
            
        }
        CValidateCode validateCode = new CValidateCode();
        private string validationCode; // 驗證碼
        private void UpdateValidationCode()
        {
            int w = 63; // 預設寬度
            int h = 30; // 預設高度
            validationCode = validateCode.GenerateCheckCode(); // 更新類級別的 validationCode 成員
            Bitmap image = validateCode.CreateCheckCodeImage(validationCode, w, h); // 建立驗證碼圖片

            // 顯示圖片在 PictureBox 控制元件上
            pictureBox1.Image = image;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            FrmAddCustomer frmAddCustomer = new FrmAddCustomer();
            frmAddCustomer.Show();
        }

        private void Frm_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            exit();
        }
    }
}
