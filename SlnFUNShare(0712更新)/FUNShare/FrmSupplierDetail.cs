using FUNShare.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FUNShare
{
    public partial class FrmSupplierDetail : Form
    {
        public FrmSupplierDetail()
        {
            InitializeComponent();
            //Loadcitydata();
            manage.Loadcitydata(comCity_ID);
        }
        FUNShareEntities dbcontext = new FUNShareEntities();//連機DB
        //FUNShareEntities1 dbcontext = new FUNShareEntities1();//本地DB
        public int Supplier_ID { get; set; }//取得點選Supplier_ID的資訊並存入
        private void FrmSupplierDetail_Load(object sender, EventArgs e)
        {
            try
            {

                // 設定統一編號為唯讀
                txtTaxID.ReadOnly = true;
                //導入廠商資料
                var q = (from i in dbcontext.Suppliers.AsEnumerable()
                         where i.Supplier_ID == Supplier_ID
                         select i).ToList();
                //統編
                txtTaxID.Text = q[0].Tax_ID;
                //廠商名稱
                txtSuppierName.Text = q[0].Supplier_Name;
                //城市名稱
                if (q[0].City_ID != null)
                    comCity_ID.Text = q[0].City.City_Name;
                else comCity_ID.Text = "";
                //e-mail
                txtEmail.Text = q[0].Email;
                //狀態
                comboBoxStatus.Text = q[0].Status.Description.ToString();
                //聯絡人
                txtContactPerson.Text = q[0].Contact_Person;
                //電話
                txtSuppierPhone.Text = q[0].Supplier_Phone;
                //傳真
                txtFax.Text = q[0].Fax;
                //地址
                txtAddress.Text = q[0].Address;
                //備註
                richDescription.Text = q[0].Description;
                //廠商logo
                if (q[0].Logo_Image != null)
                {
                    byte[] bytes = q[0].Logo_Image;
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                    picLogo.Image = Image.FromStream(ms);
                }
            }
            catch (Exception ex){
                MessageBox.Show(ex.ToString());
            }
       }
        private void Loadcitydata()//載入城市資料
        {
            var q = from c in dbcontext.Cities
                    select c;
            comCity_ID.DataSource = q.ToList();
            comCity_ID.DisplayMember = "City_Name";
        }
        CSupplierManage manage = new CSupplierManage();

        private void btnModify_Click(object sender, EventArgs e)//修改並儲存
        {
            SaveModifyData();
        }

        private void SaveModifyData()//載入修改資料
        {
            try { 
            var q =(from supplier in dbcontext.Suppliers
                   where supplier.Supplier_ID==Supplier_ID
                   select supplier).ToList();
            //防空值
            //使用 StringBuilder 來管理錯誤訊息，並一次顯示所有錯誤訊息。
            StringBuilder errorMessage = new StringBuilder();

            if (string.IsNullOrEmpty(txtTaxID.Text))
            {
                errorMessage.AppendLine("請輸入統一編號");
            }
            if (string.IsNullOrEmpty(txtSuppierName.Text))
            {
                errorMessage.AppendLine("請輸入供應商名稱");
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errorMessage.AppendLine("請輸入E-mail");
            }
            if (string.IsNullOrEmpty(txtContactPerson.Text))
            {
                errorMessage.AppendLine("請輸入聯繫人資訊");
            }          

            if (errorMessage.Length > 0)
            {
                MessageBox.Show(errorMessage.ToString());
                return;
            }
            else
            {
                //  統一編號
                q[0].Tax_ID = txtTaxID.Text;
                //廠商名稱
                q[0].Supplier_Name = txtSuppierName.Text;
                //城市名稱
                q[0].City_ID = (comCity_ID.SelectedIndex)+1;
                //e-mail
                q[0].Email = txtEmail.Text;
                //狀態
                q[0].Status_ID = (comboBoxStatus.SelectedIndex)+14;
                //聯絡人
                q[0].Contact_Person = txtContactPerson.Text;
                //電話
                q[0].Supplier_Phone = txtSuppierPhone.Text;
                //傳真
                q[0].Fax = txtFax.Text;
                //地址
                q[0].Address = txtAddress.Text;
                //備註
                q[0].Description = richDescription.Text;
                //照片
                if (picLogo.Image != null)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    picLogo.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] bytes = new byte[ms.Length];
                    bytes = ms.GetBuffer();
                    q[0].Logo_Image = bytes;
                }
                dbcontext.SaveChanges();
                MessageBox.Show("修改成功");
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }    
        private void btnBrowse_Click(object sender, EventArgs e)//新增圖片
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picLogo.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }


    }
}
