using FUNShare.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUNShare
{
    public partial class FrmSupplierAddSupplierInformation : Form
    {
        public FrmSupplierAddSupplierInformation()
        {
            InitializeComponent();
           // Loadcitydata();
            manage.Loadcitydata(comCity_ID);
        }
          CSupplierManage manage = new CSupplierManage();
        private void Loadcitydata()//載入城市資料
        {
            var q = from c in dbcontext.Cities
                    select c;
            comCity_ID.DataSource = q.ToList();
            comCity_ID.DisplayMember = "City_Name";
        }
        FUNShareEntities dbcontext = new FUNShareEntities();//連機DB
       // FUNShareEntities1 dbcontext = new FUNShareEntities1();//本地DB
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //各種條件判斷是否有資訊未填寫
                StringBuilder errorMessage = new StringBuilder();//使用 StringBuilder 來管理錯誤訊息，並一次顯示所有錯誤訊息。

                if (string.IsNullOrEmpty(txtTaxID.Text))
                {
                    errorMessage.AppendLine("請輸入統一編號");
                }
                if (string.IsNullOrEmpty(txtTaxID.Text) || txtTaxID.Text.Length != 8 )
                {
                    errorMessage.AppendLine("統一編號必須是8碼");
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

                if (string.IsNullOrEmpty(txtPassword1.Text))
                {
                    errorMessage.AppendLine("請輸入密碼");
                }

                if (string.IsNullOrEmpty(txtPassword2.Text))
                {
                    errorMessage.AppendLine("請輸入確認密碼");
                }
                if (string.IsNullOrEmpty(txtPassword1.Text) || txtPassword1.Text.Length < 8 || txtPassword1.Text.Length > 12)
                {
                    errorMessage.AppendLine("密碼長度請介於8~12位數");
                }
                if (txtPassword1.Text != txtPassword2.Text)
                {
                    errorMessage.AppendLine("密碼不一致請重新輸入");
                }
                //將錯誤訊息一次顯示
                if (errorMessage.Length > 0)
                {
                    MessageBox.Show(errorMessage.ToString());
                    return;
                }
                else
                {
                    // 檢查資料庫中是否已存在相同的統一編號
                    string taxID = txtTaxID.Text;
                    bool exists = dbcontext.Suppliers.Any(supplier => supplier.Tax_ID == taxID);
                    if (exists)
                    {
                        MessageBox.Show("統一編號已存在請再確認");
                    }
                    else//將資訊寫入資料庫
                    {
                        Supplier supplier = new Supplier();//開資料庫連接
                        //統一編號
                        supplier.Tax_ID = txtTaxID.Text;
                        //廠商名稱
                        supplier.Supplier_Name = txtSuppierName.Text;
                        //城市
                  
                        if (comCity_ID.SelectedItem != null)
                        {
                            supplier.City_ID = (comCity_ID.SelectedIndex)+1;
                            //City selectedCity = (City)comCity_ID.SelectedItem;
                            //supplier.City_ID = selectedCity.City_ID;
                        }
                        else
                            supplier.City_ID = null;
                        //e - mail
                        supplier.Email = txtEmail.Text;
                        //狀態預設為未審核
                        //---------------------
                        //聯絡人
                        supplier.Contact_Person = txtContactPerson.Text;
                        //聯繫電話
                        if (txtSuppierPhone.Text != "")
                            supplier.Supplier_Phone = txtSuppierPhone.Text;
                        else
                            supplier.Supplier_Phone = null;
                        //密碼
                        supplier.Password = txtPassword1.Text;
                        //傳真
                        if (txtFax.Text != "")
                            supplier.Fax = txtFax.Text;
                        else
                            supplier.Fax = null;
                        //地址
                        if (txtAddress.Text != "")
                            supplier.Address = txtAddress.Text;
                        else
                            supplier.Address = null;
                        //備註
                        if (richDescription.Text != "")
                            supplier.Description = richDescription.Text;
                        else
                            supplier.Description = null;
                        //照片
                        if (picLogo.Image != null)
                        {
                            System.IO.MemoryStream ms = new System.IO.MemoryStream();
                            picLogo.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            byte[] bytes = new byte[ms.Length];
                            bytes = ms.GetBuffer();
                            supplier.Logo_Image = bytes;
                        }
                        //狀態為待審核
                        supplier.Status_ID = 16;
                        dbcontext.Suppliers.Add(supplier);//新增
                        dbcontext.SaveChanges();//存入資料庫
                        MessageBox.Show("新增資料成功");
                    }
                }
            }
            catch (DbUpdateException ex)
            {
                // 取得內部例外狀況的詳細資訊
                var innerException = ex.InnerException;
                MessageBox.Show($"更新實體時發生錯誤：{innerException.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)//新增照片
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picLogo.Image = Image.FromFile(openFileDialog1.FileName);
            }

        }
    }
}
