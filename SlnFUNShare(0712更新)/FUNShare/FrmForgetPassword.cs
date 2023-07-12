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
    public partial class FrmForgetPassword : Form
    {
        public FrmForgetPassword()
        {
            InitializeComponent();
            UpdateValidationCode();//驗證碼預設跟重製共用
        }
        CValidateCode validateCode = new CValidateCode();
        private string validationCode; // 驗證碼
        private void button1_Click(object sender, EventArgs e)
        {
            UpdateValidationCode();//共用    
        }
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

        private void button2_Click(object sender, EventArgs e)//確認
        {
            if (txtCheck.Text == validationCode.ToUpper())
            {
                FUNShareEntities funshare = new FUNShareEntities();//連機DB
                var customerforgetid = (from c in funshare.Customer_Infomation
                                        where c.Email == txtEmail.Text
                                        select c.Member_ID);
                if (customerforgetid.Any())
                {
                    MessageBox.Show("找到帳號已記驗證密碼至註冊信箱");
                }
                else
                {
                    MessageBox.Show("查無此帳號");
                }                
            }
            else
            {
                MessageBox.Show("驗證碼不一致");
                UpdateValidationCode();
            }
        }
    }
}
