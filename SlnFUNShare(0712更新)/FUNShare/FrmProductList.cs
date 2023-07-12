using FUNShare.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUNShare
{
    public partial class FrmProductList : Form
    {
        FUNShareEntities dbContext = new FUNShareEntities();
        CProductManager P = new CProductManager();
        public FrmProductList()
        {
            InitializeComponent();
            
            P.LoadDataToCmbBoxAge(cmbBoxAge);
            P.LoadDataToCmbBoxCategory(cmbBoxCategories);
            P.LoadDataToCmbBoxStatus(cmbBoxStatus);
            P.LoadDataToCmbBoxSupplier(cmbBoxSupplier);
            LoadDataToTimePicker();
            LoadDataToDataGridView();

            cmbBoxAge.SelectedIndex = 0;
            cmbBoxCategories.SelectedIndex = 0;
            cmbBoxStatus.SelectedIndex = 0;
            cmbBoxSubCategories.Enabled = false;
            cmbBoxSupplier.SelectedIndex = 0;

            //LoadMaxPriceToTrackBar
            trackBarPrice.Maximum = (int)dbContext.Products.Select(x=>x.UnitPrice.Value).Max();
        }

        private void trackBarPrice_Scroll(object sender, EventArgs e)
        {
            labPriceShow.Text = trackBarPrice.Value.ToString();
        }

        private void LoadDataToTimePicker()
        {
            if (dbContext.Product_Detail.Any(x => x.Begin_Time.HasValue))
            {
                DateTime oldestDay = dbContext.Product_Detail.Select(x => x.Begin_Time.Value).Min();
                dateTimePickerBegin.Value = oldestDay;
                dateTimePickerEnd.Value = dbContext.Product_Detail.Select(x => x.End_Time.Value).Max();

                dateTimePickerBegin.MinDate = oldestDay;
                dateTimePickerEnd.MinDate = oldestDay;
            }
        }

        internal void LoadDataToDataGridView()
        {
            //更新資料
            dbContext = new FUNShareEntities();

            var q = from p in dbContext.Products.AsEnumerable()
                    let c = dbContext.ProductCategories.Where(x => x.Product_ID == p.Product_ID).Select(x => x.SubCategory.SubCategory_Name).ToList()
                    select new Models.CProduct
                    {
                        ProductID = p.Product_ID,
                        產品名稱 = p.Product_Name,
                        產品介紹 = p.Product_Intro,
                        供應商 = p.Supplier.Supplier_Name,
                        次類別 = c.Count>0? c.Aggregate((x, y) => x + ", " + y):null,
                        分齡 = p.Age_ID != null ? p.Age.Grade : null,
                        難易度 = p.Level,
                        類型 = p.IsClass_ ? "課程" : "活動",
                        堂數 = p.Times,
                        上課頻率 = p.Interval,
                        _單價 = p.UnitPrice,
                        名額 = p.Stock,
                        報名截止日期 = p.Deadline,
                        上架日期 = p.ReleasedTime,
                        傭金 = p.Commision,
                        備註 = p.Note,
                        狀態 = dbContext.Status.Where(x => x.Status_ID == p.Status_ID).Select(x => x.Description).FirstOrDefault(),
                        圖片 = dbContext.Image_List.Where(x=>x.Product_ID==p.Product_ID).Select(x=>x.Images).FirstOrDefault(),
                    };

            dataGridViewProduct.DataSource = q.ToList();
            DataGridViewImageColumn imageColumn = dataGridViewProduct.Columns["圖片"] as DataGridViewImageColumn;
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void cmbBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxCategories.SelectedItem.ToString() == "請選擇")
            {
                cmbBoxSubCategories.Text = "";
                cmbBoxSubCategories.Enabled = false;
            }
            else
            {
                cmbBoxSubCategories.Enabled = true;
            }
            P.LoadDataToCmbBoxSubCategory(cmbBoxCategories, cmbBoxSubCategories);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //todo 搜尋條件改寫為方法
            string productName = txtProductName.Text;
            string age ="";
            if (cmbBoxAge.SelectedIndex != 0)
            {
                age = cmbBoxAge.SelectedItem.ToString();
            }
            string subCategory =null;
            if (cmbBoxSubCategories.Items.Count > 0)
            {
                subCategory = cmbBoxSubCategories.SelectedItem.ToString();
            }
            DateTime beginTime = dateTimePickerBegin.Value;
            DateTime endTime = dateTimePickerEnd.Value;
            int price = trackBarPrice.Value;
            string status = cmbBoxStatus.SelectedItem.ToString();

            var q = from p in dbContext.Products.AsEnumerable()
                    let productSubIDs = dbContext.ProductCategories.Where(x => x.Product_ID == p.Product_ID).Select(x => x.SubCategory_ID).ToArray()
                    let selectedSubID = dbContext.SubCategories.Where(x => x.SubCategory_Name == subCategory).Select(x => x.SubCategory_ID).FirstOrDefault()
                    let productSubNames = dbContext.ProductCategories.Where(x => x.Product_ID == p.Product_ID).Select(x => x.SubCategory.SubCategory_Name).ToList()
                    let classBeginTimes = dbContext.Product_Detail.Where(x => x.Product_ID == p.Product_ID).Select(x => x.Begin_Time)
                    let classEndTimes = dbContext.Product_Detail.Where(x => x.Product_ID == p.Product_ID).Select(x => x.End_Time)
                    where p.Product_Name.Contains(productName)
                                    && (cmbBoxSupplier.SelectedIndex == 0? true : p.Supplier.Supplier_Name == cmbBoxSupplier.SelectedItem.ToString())
                                    && ((p.Age_ID == null || cmbBoxAge.SelectedIndex == 0) ? true : (p.Age.Grade == age))
                                    && ((p.ProductCategories.Count == 0 || cmbBoxCategories.SelectedIndex == 0) ? true : productSubIDs.Contains(selectedSubID))
                                    && (p.UnitPrice.GetValueOrDefault(0) >= price)
                                    && (((checkBoxClass.Checked && checkBoxEvent.Checked) || (!checkBoxClass.Checked && !checkBoxEvent.Checked)) ? true : (checkBoxClass.Checked ? (p.IsClass_ == true) : (p.IsClass_ == false)))
                                    && (cmbBoxStatus.SelectedIndex == 0 ? true : (p.Status_ID == dbContext.Status.Where(x => x.Description == status).Select(x => x.Status_ID).FirstOrDefault()))
                                    && classBeginTimes.Any(x=> x >= beginTime) //不會顯示空值資料
                                    && classEndTimes.Any(x=>x <= endTime)
                    select new Models.CProduct
                    {
                        ProductID = p.Product_ID,
                        產品名稱 = p.Product_Name,
                        產品介紹 = p.Product_Intro,
                        供應商 = p.Supplier.Supplier_Name,
                        次類別 = productSubNames.Count>0?productSubNames.Aggregate((x, y) => x + ", " + y):null,
                        分齡 = p.Age_ID != null ? p.Age.Grade : null,
                        難易度 = p.Level,
                        類型 = p.IsClass_ ? "課程" : "活動",
                        堂數 = p.Times,
                        上課頻率 = p.Interval,
                        _單價 = p.UnitPrice,
                        名額 = p.Stock,
                        報名截止日期 = p.Deadline,
                        上架日期 = p.ReleasedTime,
                        備註 = p.Note,
                        狀態 = dbContext.Status.Where(x => x.Status_ID == p.Status_ID).Select(x => x.Description).FirstOrDefault(),
                        圖片 = dbContext.Image_List.Where(x => x.Product_ID == p.Product_ID).Select(x => x.Images).FirstOrDefault(),
                    };

            dataGridViewProduct.DataSource = q.ToList();
            DataGridViewImageColumn imageColumn = dataGridViewProduct.Columns["圖片"] as DataGridViewImageColumn;
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void btnAllData_Click(object sender, EventArgs e)
        {
            txtProductName.Text = "";
            cmbBoxAge.SelectedIndex = 0;
            cmbBoxCategories.SelectedIndex = 0;
            cmbBoxStatus.SelectedIndex = 0;
            cmbBoxSubCategories.Enabled = false;
            trackBarPrice.Value= 0;
            labPriceShow.Text = "0";
            checkBoxClass.Checked = false;
            checkBoxEvent.Checked = false;

            LoadDataToTimePicker();
            LoadDataToDataGridView();
        }

        private void dataGridViewProduct_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int productID = (int)dataGridViewProduct.Rows[e.RowIndex].Cells["ProductID"].Value;
                FrmProductDetail f = new FrmProductDetail(productID);
                f.ProductID = productID;

                if (f.ShowDialog() == DialogResult.Cancel)
                {
                    LoadDataToDataGridView();
                    if (Application.OpenForms["FrmProductDetail"] !=null)
                        Application.OpenForms["FrmProductDetail"].Activate();
                }
            }
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerEnd.Value.Date < dateTimePickerBegin.Value.Date)
            {
                MessageBox.Show("時間範圍不可小於起始時間，請重新選擇");
                dateTimePickerEnd.Focus();
            }
        }

        private void dateTimePickerBegin_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerEnd.Value.Date < dateTimePickerBegin.Value.Date)
            {
                MessageBox.Show("時間範圍不可大於結束時間，請重新選擇");
                dateTimePickerBegin.Focus();
            }
        }
    }
}
