using FUNShare.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUNShare
{
    public partial class FrmProductDetail : Form
    {
        FUNShareEntities dbContext = new FUNShareEntities();
        CProductManager P = new CProductManager();
        public int ProductID { get; set; }
        List<CProductDetail> listProductDetail;
        List<string> listDeletedImage = new List<string>();

        public FrmProductDetail()
        {
            InitializeComponent();

            P.LoadDataToCmbBoxCategory(cmbBoxCategory);
            cmbBoxCategory.SelectedIndex = 0;
            P.LoadDataToCmbBoxAge(cmbBoxAge);
            cmbBoxAge.SelectedIndex = 0;
            P.LoadDataToCmbBoxStatus(toolStripComboBoxStatus);
            toolStripComboBoxStatus.SelectedIndex = 2;
            P.LoadDataToCmbBoxLevel(cmbBoxLevel);

            LoadDataToDataGridViewProductDeatils();

            // 長度限制
            txtProductName.MaxLength = 30;

            // 新增產品有時間起始限制
            dateTimePickerDeadline.MinDate = DateTime.Now;
            dateTimePickerReleasedTime.MinDate = DateTime.Now;

            //預設圖片設定
            pictureBoxDefault.MouseHover += Pic_MouseHover;
            pictureBoxDefault.MouseLeave += Pic_MouseLeave;
            pictureBoxDefault.Click += Pic_Click;
            pictureBoxDefault.ContextMenuStrip = contextMenuStrip1;
        }

        public FrmProductDetail(int productID)
        {
            InitializeComponent();

            P.LoadDataToCmbBoxCategory(cmbBoxCategory);
            P.LoadDataToCmbBoxAge(cmbBoxAge);
            P.LoadDataToCmbBoxStatus(toolStripComboBoxStatus);
            P.LoadDataToCmbBoxLevel(cmbBoxLevel);

            // 修改資料時無法刪除排課資料
            dataGridViewProductDetails.ContextMenuStrip = null;

            this.ProductID = productID;
            
            var q = from p in dbContext.Products.AsEnumerable()
                    let c = dbContext.ProductCategories.Where(x => x.Product_ID == p.Product_ID).Select(x => x.SubCategory.SubCategory_Name).ToList()
                    where p.Product_ID == productID
                    select new
                    {
                        ProductID = p.Product_ID,
                        產品名稱 = p.Product_Name,
                        產品介紹 = p.Product_Intro,
                        供應商 = p.Supplier.Supplier_Name,
                        c,
                        類別 = c.Count>0? c.Aggregate((x, y) => x + ", " + y):null,
                        分齡 = p.Age_ID != null ? p.Age.Grade : null,
                        難易度 = p.Level,
                        單價 = p.UnitPrice,
                        名額 = p.Stock,
                        報名截止日 = p.Deadline,
                        上架日期 = p.ReleasedTime,
                        堂數 = p.Times,
                        上課頻率 = p.Interval,
                        備註 = p.Note,
                        狀態 = dbContext.Status.Where(x => x.Status_ID == p.Status_ID).Select(x => x.Description).FirstOrDefault(),
                        類型 = p.IsClass_ ? "課程" : "活動",
                        p,
                    };

            foreach (var i in q)
            {
                txtSupplierName.Text = i.供應商;
                txtProductName.Text = i.產品名稱;
                richTxtProductIntro.Text = i.產品介紹;
                txtPrice.Text = $"{i.單價:0}";
                txtStock.Text = i.名額.ToString();
                richTxtNote.Text = i.備註;
                checkBoxIsClass.Checked = i.p.IsClass_;
                toolStripTxtCommision.Text = i.p.Commision.ToString();
                
                if (i.分齡 != null)
                {
                    foreach( var item in cmbBoxAge.Items )
                    {
                        if( item.ToString()== i.分齡)
                        {
                            cmbBoxAge.SelectedItem = item;
                        }
                    }
                }

                // 讀取分類
                if (i.c.Count == 1)
                {
                    string category = dbContext.SubCategories.AsEnumerable().Where(x => x.SubCategory_Name == i.c[0]).Select(x => x.Category.Category_Name).First();
                    foreach (var item in cmbBoxCategory.Items)
                    {
                        if (item.ToString() == category)
                        {
                            cmbBoxCategory.SelectedItem = item;
                        }
                    }
                    foreach (var item in cmbBoxSubCategory.Items)
                    {
                        if (item.ToString() == i.c[0])
                        {
                            cmbBoxSubCategory.SelectedItem = item;
                        }
                    }
                }
                else if (i.c.Count == 2)
                {
                    string category = dbContext.SubCategories.AsEnumerable().Where(x => x.SubCategory_Name == i.c[0]).Select(x => x.Category.Category_Name).First();
                    string category2 = dbContext.SubCategories.AsEnumerable().Where(x => x.SubCategory_Name == i.c[1]).Select(x => x.Category.Category_Name).First();
                    foreach (var item in cmbBoxCategory.Items)
                    {
                        if (item.ToString() == category)
                        {
                            cmbBoxCategory.SelectedItem = item;
                        }
                    }
                    foreach (var item in cmbBoxSubCategory.Items)
                    {
                        if (item.ToString() == i.c[0])
                        {
                            cmbBoxSubCategory.SelectedItem = item;
                        }
                    }
                    P.LoadDataToCmbBoxCategory(cmbBoxCategory2);
                    foreach (var item in cmbBoxCategory2.Items)
                    {
                        if (item.ToString() == category2)
                        {
                            cmbBoxCategory2.SelectedItem = item;
                        }
                    }
                    foreach (var item in cmbBoxSubCategory2.Items)
                    {
                        if (item.ToString() == i.c[1])
                        {
                            cmbBoxSubCategory2.SelectedItem = item;
                        }
                    }

                    cmbBoxCategory2.Visible = true;
                    cmbBoxSubCategory2.Visible = true;
                    //控制項位置
                    labLevel.Location = new Point(labLevel.Location.X, labLevel.Location.Y + 30);
                    cmbBoxLevel.Location = new Point(cmbBoxLevel.Location.X, cmbBoxLevel.Location.Y +30);
                    labIntro.Location = new Point(labIntro.Location.X, labIntro.Location.Y + 30);
                    richTxtProductIntro.Location = new Point(richTxtProductIntro.Location.X, richTxtProductIntro.Location.Y + 30);
                    btnAddCategory.Text = "-";
                    IsAddClick = true;
                }

                //讀取難易度
                if (i.難易度.HasValue)
                {
                    foreach (var item in cmbBoxLevel.Items)
                    {
                        if (item.ToString() == i.難易度.ToString())
                        {
                            cmbBoxLevel.SelectedItem = item;
                        }
                    }
                }

                // 讀取日期
                if (i.報名截止日.HasValue)
                {
                    dateTimePickerDeadline.Value = i.報名截止日.Value;
                }
                if (i.上架日期.HasValue)
                {
                    dateTimePickerReleasedTime.Value = i.上架日期.Value;
                }

                //讀取堂數
                if (i.堂數.HasValue)
                {
                    txtTimes.Text = i.堂數.ToString();
                }

                //讀取頻率
                if(i.上課頻率 != null)
                {
                    txtInterval.Text = i.上課頻率;
                }

                // 讀取狀態
                foreach (var item in toolStripComboBoxStatus.Items)
                {
                    if (item.ToString() == i.狀態)
                    {
                        toolStripComboBoxStatus.SelectedItem = item;
                    }
                }
            }

            // 修改產品無法修改供應商
            txtSupplierName.Enabled = false;

            // 載入課程明細
            LoadDataToDataGridViewProductDeatils();

            // 載入圖片
            pictureBoxDefault.Dispose();
            LoadPhotoToFlowLayoutPanel(flowLayoutPanelPhoto);
        }
        private void LoadDataToDataGridViewProductDeatils()
        {
            // 清除暫存的排課資料
            if (listProductDetail != null)
            {
                listProductDetail.Clear();
            }

            dbContext = new FUNShareEntities();
            var q = from pd in dbContext.Product_Detail.AsEnumerable()
                    where pd.Product_ID == this.ProductID
                    select new CProductDetail
                    {
                        ProductDetail_ID = pd.Product_Detail_ID,
                        課程開始時間 = pd.Begin_Time,
                        課程結束時間 = pd.End_Time,
                        行政區 = pd.District_ID == null ? "" : pd.District.District_Name,
                        地址 = pd.Address,
                        _開課狀態 =pd.Status.Description
                    };

            listProductDetail = q.ToList();
            dataGridViewProductDetails.DataSource = listProductDetail;
        }
        private void LoadPhotoToFlowLayoutPanel(FlowLayoutPanel panel)
        {
            var q = from i in dbContext.Image_List
                                    where i.Product_ID == this.ProductID
                                    select i;

            foreach (var i in q)
            {
                PictureBox pic = new PictureBox();
                System.IO.MemoryStream ms = new System.IO.MemoryStream(i.Images);
                pic.Image = Image.FromStream(ms);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Width = 200; pic.Height = 150;
                pic.Padding = new System.Windows.Forms.Padding(5);
                pic.Tag = i.Image_ID;

                pic.MouseHover += Pic_MouseHover;
                pic.MouseLeave += Pic_MouseLeave;
                pic.Click += Pic_Click;
                pic.ContextMenuStrip = contextMenuStrip1;

                panel.Controls.Add(pic);
            }
        }

        private void checkBoxIsClass_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxIsClass.Checked)
            {
                txtTimes.Enabled = false;
                txtInterval.Enabled = false;
                labTimesError.Text = "";
            }
            else
            {
                txtTimes.Enabled = true;
                txtInterval.Enabled = true;
            }
        }

        private void 新增NToolStripButton_Click(object sender, EventArgs e)
        {
            FrmProductDetail f = new FrmProductDetail();
            f.Show();
            this.Close();
        }

        private void 儲存SToolStripButton_Click(object sender, EventArgs e)
        {
            if (ProductID != 0)
            {
                // Update 產品
                var product = dbContext.Products.Where(x => x.Product_ID == this.ProductID).FirstOrDefault();
                if (product == null) 
                {
                    MessageBox.Show("儲存失敗，查無此產品");
                    return; 
                }

                //格式檢查
                if (labPriceError.Text != "" || labStockError.Text != "")
                {
                    MessageBox.Show("儲存失敗，請確認課程明細資料是否填妥");
                    return;
                }
                //必填項目檢查
                if (txtProductName.Text == "")
                {
                    MessageBox.Show("產品名稱為必填欄位，請輸入資料");
                    txtProductName.Focus();
                    return;
                }
                if (txtPrice.Text == "")
                {
                    MessageBox.Show("產品單價為必填欄位，請輸入資料");
                    txtPrice.Focus();
                    return;
                }
                else
                {
                    product.UnitPrice = decimal.Parse(txtPrice.Text);
                }
                if (txtStock.Text == "")
                {
                    MessageBox.Show("人數限額為必填欄位，請輸入資料");
                    txtStock.Focus();
                    return;
                }
                else
                {
                    product.Stock = int.Parse(txtStock.Text);
                }
                if (toolStripTxtCommision.Text == "")
                {
                    MessageBox.Show("傭金為必填欄位，請輸入資料");
                    toolStripTxtCommision.Focus();
                    return;
                }
                else
                {
                    if (double.TryParse(toolStripTxtCommision.Text, out double commision))
                    {
                        product.Commision = commision;
                    }
                    else
                    {
                        MessageBox.Show("儲存失敗，請輸入正確的傭金");
                        toolStripTxtCommision.Focus();
                        return;
                    }
                }

                product.Product_Name = txtProductName.Text;
                product.Product_Intro = richTxtProductIntro.Text;
                product.Note = richTxtNote.Text;
                product.IsClass_ = checkBoxIsClass.Checked;
                product.Status_ID = dbContext.Status.Where(x => x.Description == toolStripComboBoxStatus.SelectedItem.ToString()).Select(x => x.Status_ID).First();
                product.Age_ID = dbContext.Ages.Where(x => x.Grade == cmbBoxAge.SelectedItem.ToString()).Select(x => x.Age_ID).FirstOrDefault();
                product.Deadline = dateTimePickerDeadline.Value;
                product.ReleasedTime = dateTimePickerReleasedTime.Value;

                //可允許空值的項目
                if (cmbBoxLevel.SelectedIndex != -1)
                {
                    product.Level = cmbBoxLevel.SelectedIndex+1;
                }
                if (checkBoxIsClass.Checked == true)
                {
                    if(labTimesError.Text != "")
                    {
                        MessageBox.Show("儲存失敗，請輸入正確的堂數");
                        txtTimes.Focus();
                        return;
                    }
                    else if (txtTimes.Text != product.Times.ToString() && labTimesError.Text == "")
                    {
                        product.Times = int.Parse(txtTimes.Text);
                    }
                    product.Interval = txtInterval.Text;
                }

                // Update 產品分類
                var pCategories = dbContext.ProductCategories.Where(x => x.Product_ID == this.ProductID).Select(x => x);
                if (pCategories.Count() > 0 && cmbBoxSubCategory.Items.Count > 0)
                {
                    pCategories.AsEnumerable().ElementAt(0).SubCategory_ID = dbContext.SubCategories.Where(x => x.SubCategory_Name == cmbBoxSubCategory.SelectedItem.ToString()).Select(x => x.SubCategory_ID).First();
                }
                else if (cmbBoxSubCategory.Items.Count > 0)
                {
                    ProductCategory pc = new ProductCategory
                    {
                        Product_ID = this.ProductID,
                        SubCategory_ID = dbContext.SubCategories.Where(x => x.SubCategory_Name == cmbBoxSubCategory.SelectedItem.ToString()).Select(x => x.SubCategory_ID).First(),
                    };

                    dbContext.ProductCategories.Add(pc);
                }
                // Update 產品分類2
                if (pCategories.Count() > 1 && cmbBoxSubCategory2.Items.Count > 0 && IsAddClick == true)
                {
                    pCategories.AsEnumerable().ElementAt(1).SubCategory_ID = dbContext.SubCategories.Where(x => x.SubCategory_Name == cmbBoxSubCategory2.SelectedItem.ToString()).Select(x => x.SubCategory_ID).First();
                }
                else if (pCategories.Count() > 1 && IsAddClick == false)
                {
                    dbContext.ProductCategories.Remove(pCategories.AsEnumerable().ElementAt(1));
                }
                else if (cmbBoxSubCategory2.Items.Count > 0)
                {
                    ProductCategory pc = new ProductCategory
                    {
                        Product_ID = this.ProductID,
                        SubCategory_ID = dbContext.SubCategories.Where(x => x.SubCategory_Name == cmbBoxSubCategory2.SelectedItem.ToString()).Select(x => x.SubCategory_ID).First(),
                    };

                    dbContext.ProductCategories.Add(pc);
                }

                //圖片為必填
                if(flowLayoutPanelPhoto.Controls.Count == 0)
                {
                    MessageBox.Show("儲存失敗，請至少上傳一張課程圖片");
                    return;
                }
                //Update 圖片
                var qProductImage = from pImage in this.dbContext.Image_List
                                     where pImage.Product_ID == this.ProductID
                                     select pImage;

                if (qProductImage.Count() > 0)
                {
                    foreach (var image in qProductImage)
                    {
                        // 圖片全部刪除
                        if (flowLayoutPanelPhoto.Controls.Count == 0)
                        {
                            dbContext.Image_List.Remove(image);
                        }
                        
                        foreach (PictureBox pic in flowLayoutPanelPhoto.Controls)
                        {
                            // id不為空，且與資料庫相同=>更新資料
                            if (pic.Tag != null && (int)pic.Tag == image.Image_ID)
                            {
                                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                                pic.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                                byte[] bytes = ms.GetBuffer();

                                image.Images = bytes;
                            }
                        }
                        //id為空=>新增資料
                        foreach (PictureBox pic in flowLayoutPanelPhoto.Controls)
                        {
                            if (pic.Tag == null)
                            {
                                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                                pic.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                                byte[] bytes = ms.GetBuffer();

                                Image_List imageAdd = new Image_List
                                {
                                    Product_ID = this.ProductID,
                                    Images = bytes,
                                };

                                dbContext.Image_List.Add(imageAdd);
                            }
                        }

                        //刪除圖片
                        foreach(string tagID in listDeletedImage)
                        {
                            if (tagID == image.Image_ID.ToString())
                            {
                                dbContext.Image_List.Remove(image);
                            }
                        }
                    }
                }
                else //DB中無資料，單純新增
                {
                    for (int i = 0; i < flowLayoutPanelPhoto.Controls.Count; i++)
                    {
                        PictureBox pic = flowLayoutPanelPhoto.Controls[i] as PictureBox;
                        if (pic != null)
                        {
                            System.IO.MemoryStream ms = new System.IO.MemoryStream();
                            pic.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            byte[] bytes = ms.GetBuffer();

                            Image_List image = new Image_List
                            {
                                Product_ID = this.ProductID,
                                Images = bytes,
                            };

                            dbContext.Image_List.Add(image);
                        }
                    }
                }

                // 排課
                if (IsBeginTimeError || IsEndTimeError || IsDistrictError || IsStatusError)
                {
                    MessageBox.Show("儲存失敗，請確認排課資料是否填妥");
                    return;
                }

                //Update 排課
                var qProductDetail = from pd in this.dbContext.Product_Detail.AsEnumerable()
                                     where pd.Product_ID == this.ProductID
                                     select pd;

                if (qProductDetail.Count() > 0)
                {
                    //todo 待優化
                    for (int i = 0; i < listProductDetail.Count(); i++)
                    {
                        if (qProductDetail.Count() == listProductDetail.Count())
                        {
                            if (listProductDetail[i].ProductDetail_ID == qProductDetail.ElementAt(i).Product_Detail_ID)
                            {
                                qProductDetail.ElementAt(i).Begin_Time = listProductDetail[i].課程開始時間;
                                qProductDetail.ElementAt(i).End_Time = listProductDetail[i].課程結束時間;
                                qProductDetail.ElementAt(i).Status_ID = dbContext.Status.AsEnumerable().Where(x => x.Description == listProductDetail[i].開課狀態).Select(x => x.Status_ID).First();
                                qProductDetail.ElementAt(i).Address = listProductDetail[i].地址;

                                if (listProductDetail[i].行政區 != "")
                                {
                                    qProductDetail.ElementAt(i).District_ID = dbContext.Districts.AsEnumerable().Where(x => x.District_Name == listProductDetail[i].行政區).Select(x => x.District_ID).First();
                                }
                            }
                        }
                        else
                        {
                            if (qProductDetail.Where(x=>x.Product_Detail_ID== listProductDetail[i].ProductDetail_ID).Count()>0)
                            {
                                qProductDetail.ElementAt(i).Begin_Time = listProductDetail[i].課程開始時間;
                                qProductDetail.ElementAt(i).End_Time = listProductDetail[i].課程結束時間;
                                qProductDetail.ElementAt(i).Status_ID = dbContext.Status.AsEnumerable().Where(x => x.Description == listProductDetail[i].開課狀態).Select(x => x.Status_ID).First();
                                qProductDetail.ElementAt(i).Address = listProductDetail[i].地址;

                                if (listProductDetail[i].行政區 != "")
                                {
                                    qProductDetail.ElementAt(i).District_ID = dbContext.Districts.AsEnumerable().Where(x => x.District_Name == listProductDetail[i].行政區).Select(x => x.District_ID).First();
                                }
                            }
                            else
                            {
                                // Add 目前排課
                                Product_Detail pdAdd = new Product_Detail
                                {
                                    Product_ID = this.ProductID,
                                    Begin_Time = listProductDetail[i].課程開始時間,
                                    End_Time = listProductDetail[i].課程結束時間,
                                    Status_ID = dbContext.Status.AsEnumerable().Where(x => x.Description == listProductDetail[i].開課狀態).Select(x => x.Status_ID).First(),
                                    Address = listProductDetail[i].地址,
                                };

                                if (listProductDetail[i].行政區 != "")
                                {
                                    pdAdd.District_ID = dbContext.Districts.AsEnumerable().Where(x => x.District_Name == listProductDetail[i].行政區).Select(x => x.District_ID).First();
                                }
                                dbContext.Product_Detail.Add(pdAdd);
                            }
                        }
                    }
                }
                else
                {
                    foreach (var pdRow in listProductDetail)
                    {
                        Product_Detail pdAdd = new Product_Detail
                        {
                            Product_ID = this.ProductID,
                            Begin_Time = pdRow.課程開始時間,
                            End_Time = pdRow.課程結束時間,
                            Status_ID = dbContext.Status.Where(x => x.Description == pdRow.開課狀態).Select(x => x.Status_ID).First(),
                            Address = pdRow.地址,
                        };

                        if (pdRow.行政區 != "")
                        {
                            pdAdd.District_ID = dbContext.Districts.Where(x => x.District_Name == pdRow.行政區).Select(x => x.District_ID).First();
                        }

                        dbContext.Product_Detail.Add(pdAdd);
                    }
                }

                // 存至DB
                try
                {
                    dbContext.SaveChanges();
                    MessageBox.Show($"資料更新成功！\nProduct ID: {this.ProductID}");
                    // 清空陣列
                    listProductDetail.Clear();
                    LoadDataToDataGridViewProductDeatils();

                    if (MessageBox.Show("是否關閉此頁面", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                //Add 產品
                if (labPriceError.Text != "" || labStockError.Text != ""|| labSupplierError.Text !="")
                {
                    MessageBox.Show("儲存失敗，請確認課程資料是否填妥");
                    return;
                }

                //必填項目檢查
                if (txtSupplierName.Text == "")
                {
                    MessageBox.Show("廠商名稱為必填欄位，請輸入資料");
                    txtSupplierName.Focus();
                    return;
                }
                if (txtProductName.Text == "")
                {
                    MessageBox.Show("產品名稱為必填欄位，請輸入資料");
                    txtProductName.Focus();
                    return;
                }

                Product product = new Product
                {
                    Product_Name = txtProductName.Text,
                    Age_ID = dbContext.Ages.Where(x => x.Grade == cmbBoxAge.SelectedItem.ToString()).Select(x => x.Age_ID).FirstOrDefault(),
                    Product_Intro = richTxtProductIntro.Text,
                    Supplier_ID = dbContext.Suppliers.Where(x => x.Supplier_Name == txtSupplierName.Text).Select(x => x.Supplier_ID).FirstOrDefault(),
                    Note = richTxtNote.Text,
                    IsClass_ = checkBoxIsClass.Checked,
                    Status_ID = dbContext.Status.Where(x => x.Description == toolStripComboBoxStatus.SelectedItem.ToString()).Select(x => x.Status_ID).FirstOrDefault(),
                    Deadline = dateTimePickerDeadline.Value,
                    ReleasedTime = dateTimePickerReleasedTime.Value
                };

                if (txtPrice.Text == "")
                {
                    MessageBox.Show("產品單價為必填欄位，請輸入資料");
                    txtPrice.Focus();
                    return;
                }
                else
                {
                    product.UnitPrice = decimal.Parse(txtPrice.Text);
                }
                if (txtStock.Text == "")
                {
                    MessageBox.Show("人數限額為必填欄位，請輸入資料");
                    txtStock.Focus();
                    return;
                }
                else
                {
                    product.Stock = int.Parse(txtStock.Text);
                }
                if (toolStripTxtCommision.Text == "")
                {
                    MessageBox.Show("傭金為必填欄位，請輸入資料");
                    toolStripTxtCommision.Focus();
                    return;
                }
                else
                {
                    if (double.TryParse(toolStripTxtCommision.Text, out double commision))
                    {
                        product.Commision = commision;
                    }
                    else
                    {
                        MessageBox.Show("儲存失敗，請輸入正確的傭金");
                        toolStripTxtCommision.Focus();
                        return;
                    }
                }

                //可允許空值的項目
                if (cmbBoxLevel.SelectedIndex != -1)
                {
                    product.Level = cmbBoxLevel.SelectedIndex+1;
                }
                if (checkBoxIsClass.Checked == true)
                {
                    if (labTimesError.Text != "")
                    {
                        MessageBox.Show("儲存失敗，請輸入正確的堂數");
                        txtTimes.Focus();
                        return;
                    }
                    else if (txtTimes.Text != "" && labTimesError.Text == "")
                    {
                        product.Times = int.Parse(txtTimes.Text);
                    }
                    product.Interval = txtInterval.Text;
                }

                dbContext.Products.Add(product);

                // Add 產品分類1
                ProductCategory pc = new ProductCategory
                {
                    Product_ID = product.Product_ID,
                    SubCategory_ID = dbContext.SubCategories.Where(x => x.SubCategory_Name == cmbBoxSubCategory.SelectedItem.ToString()).Select(x => x.SubCategory_ID).First(),
                };

                dbContext.ProductCategories.Add(pc);

                // Add 產品分類2
                if (cmbBoxCategory2.Items.Count > 0)
                {
                    ProductCategory pc2 = new ProductCategory
                    {
                        Product_ID = product.Product_ID,
                        SubCategory_ID = dbContext.SubCategories.Where(x => x.SubCategory_Name == cmbBoxSubCategory2.SelectedItem.ToString()).Select(x => x.SubCategory_ID).First(),
                    };

                    dbContext.ProductCategories.Add(pc2);
                }

                //圖片為必填
                if (flowLayoutPanelPhoto.Controls.Count == 0)
                {
                    MessageBox.Show("儲存失敗，請至少上傳一張課程圖片");
                    return;
                }
                // Add 產品圖片
                for (int i = 0; i < flowLayoutPanelPhoto.Controls.Count; i++)
                {
                    PictureBox pic = flowLayoutPanelPhoto.Controls[i] as PictureBox;
                    if (pic != null)
                    {
                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        pic.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] bytes = ms.GetBuffer();

                        Image_List image = new Image_List
                        {
                            Product_ID = product.Product_ID,
                            Images = bytes,
                        };

                        dbContext.Image_List.Add(image);
                    }
                }

                //Add 產品明細
                if (IsBeginTimeError || IsEndTimeError || IsDistrictError || IsStatusError)
                {
                    MessageBox.Show("儲存失敗，請確認排課資料是否填妥");
                    return;
                }
                foreach (var pdRow in listProductDetail)
                {
                    Product_Detail pd = new Product_Detail
                    {
                        Product_ID = product.Product_ID,
                        Begin_Time = pdRow.課程開始時間,
                        End_Time = pdRow.課程結束時間,
                        Status_ID = dbContext.Status.Where(x => x.Description == pdRow.開課狀態).Select(x => x.Status_ID).First(),
                        Address = pdRow.地址
                    };

                    if(pdRow.行政區 != "")
                    {
                        pd.District_ID = dbContext.Districts.Where(x => x.District_Name == pdRow.行政區).Select(x => x.District_ID).First();
                    }

                    dbContext.Product_Detail.Add(pd);
                }

                // 存至DB
                try
                {
                    dbContext.SaveChanges();
                    MessageBox.Show($"資料新增成功！\nProduct ID: {product.Product_ID}");
                    // 清空陣列
                    listProductDetail.Clear();
                    LoadDataToDataGridViewProductDeatils();

                    if (MessageBox.Show("是否關閉此頁面", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cmbBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            P.LoadDataToCmbBoxSubCategory(cmbBoxCategory, cmbBoxSubCategory);
        }
        private void cmbBoxCategory2_SelectedIndexChanged(object sender, EventArgs e)
        {
            P.LoadDataToCmbBoxSubCategory(cmbBoxCategory2, cmbBoxSubCategory2);
        }

        private void txtSupplierName_TextChanged(object sender, EventArgs e)
        {
            if (dbContext.Suppliers.Any(x => x.Supplier_Name == txtSupplierName.Text))
            {
                labSupplierError.Text="";
            }
            else
            {
                labSupplierError.Text = "查無廠商名稱，請重新輸入";
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if(decimal.TryParse(txtPrice.Text, out decimal price))
            {
                labPriceError.Text = "";
            }
            else
            {
                labPriceError.Text = "請輸入正確數值";
            }
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtStock.Text, out int stock))
            {
                labStockError.Text = "";
            }
            else
            {
                labStockError.Text = "請輸入正確數值";
            }
        }

        private void txtTimes_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtTimes.Text, out int times))
            {
                labTimesError.Text = "";
            }
            else
            {
                labTimesError.Text = "請輸入正確數值";
            }
        }
        private void flowLayoutPanelPhoto_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            for (int i = 0; i < files.Length; i++)
            {
                PictureBox pic = new PictureBox();
                pic.Image = Image.FromFile(files[i]);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Width = 200; pic.Height = 150;
                pic.Padding = new System.Windows.Forms.Padding(5);

                pic.MouseHover += Pic_MouseHover;
                pic.MouseLeave += Pic_MouseLeave;
                pic.Click += Pic_Click;
                pic.ContextMenuStrip = contextMenuStrip1;

                flowLayoutPanelPhoto.Controls.Add(pic);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Title = "開啟圖片";
            openFileDialog1.Filter = "影像檔(*.jpg,*.png,*.bmp)| *.jpg; *.png; *.bmp|所有檔案 (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] files = openFileDialog1.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    PictureBox pic = new PictureBox();
                    pic.Image = Image.FromFile(files[i]);
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Width = 200; pic.Height = 150;
                    pic.Padding = new System.Windows.Forms.Padding(5);

                    pic.MouseHover += Pic_MouseHover;
                    pic.MouseLeave += Pic_MouseLeave;
                    pic.Click += Pic_Click;
                    pic.ContextMenuStrip = contextMenuStrip1;

                    flowLayoutPanelPhoto.Controls.Add(pic);
                }
            }
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            if (MessageBox.Show("是否變更這張圖片？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                openFileDialogForChange.FileName = "";
                openFileDialogForChange.Title = "開啟圖片";
                openFileDialogForChange.Filter = "影像檔(*.jpg,*.png,*.bmp)| *.jpg; *.png; *.bmp|所有檔案 (*.*)|*.*";

                if (openFileDialogForChange.ShowDialog()== DialogResult.OK)
                {
                    string file = openFileDialogForChange.FileName;
                    pic.Image = Image.FromFile(file);
                }
            }
        }

        private void Pic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            pic.BackColor = Color.Transparent;
        }

        private void Pic_MouseHover(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            pic.BackColor = Color.Black;
        }

        private void flowLayoutPanelPhoto_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        bool IsAddClick = false;
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (IsAddClick)
            {
                btnAddCategory.Text = "+";
               cmbBoxCategory2.Visible = false;
               cmbBoxSubCategory2.Visible = false;
                //控制項位置
                labLevel.Location = new Point(labLevel.Location.X, labLevel.Location.Y - 30);
                cmbBoxLevel.Location = new Point(cmbBoxLevel.Location.X, cmbBoxLevel.Location.Y - 30);
                labIntro.Location = new Point(labIntro.Location.X, labIntro.Location.Y - 30);
                richTxtProductIntro.Location = new Point(richTxtProductIntro.Location.X, richTxtProductIntro.Location.Y - 30);
                cmbBoxCategory2.Items.Clear();
                cmbBoxCategory2.SelectedItem = null;
                cmbBoxSubCategory2.Items.Clear();
                cmbBoxSubCategory2.SelectedItem = null;
            }
            else
            {   
                btnAddCategory.Text = "-";
                cmbBoxCategory2.Visible = true;
                cmbBoxSubCategory2.Visible = true;
                //控制項位置
                labLevel.Location = new Point(labLevel.Location.X, labLevel.Location.Y + 30);
                cmbBoxLevel.Location = new Point(cmbBoxLevel.Location.X, cmbBoxLevel.Location.Y + 30);
                labIntro.Location = new Point(labIntro.Location.X, labIntro.Location.Y + 30);
                richTxtProductIntro.Location = new Point(richTxtProductIntro.Location.X, richTxtProductIntro.Location.Y + 30);
                cmbBoxCategory2.Items.Clear();
                P.LoadDataToCmbBoxCategory(cmbBoxCategory2);
            }
            IsAddClick = !IsAddClick;
        }

        private void btnAddLesson_Click(object sender, EventArgs e)
        {            
            listProductDetail.Add(new CProductDetail
            {
                課程開始時間 = DateTime.Now,
                課程結束時間 = DateTime.Now,
                行政區 = "大安區",
                地址 = "",
                _開課狀態 = "準時開課"
            });

            // refresh
            RefreshProductDetailsToDataGridView();
        }

        void RefreshProductDetailsToDataGridView()
        {
            dataGridViewProductDetails.DataSource = null;
            dataGridViewProductDetails.DataSource = listProductDetail.ToList();
        }

        bool IsBeginTimeError = false;
        bool IsEndTimeError = false;
        bool IsDistrictError = false;
        bool IsStatusError = false;
        private void dataGridViewProductDetails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // 課程開始時間
            if (e.ColumnIndex == 0)
            {
                if (dataGridViewProductDetails.Rows[e.RowIndex].Cells["課程開始時間"].Value != null)
                {
                    DateTime cell = (DateTime)dataGridViewProductDetails.Rows[e.RowIndex].Cells["課程開始時間"].Value;
                    if (cell < dateTimePickerReleasedTime.Value)
                    {
                        MessageBox.Show("課程開始時間不應早於上架日期，請確認。");
                        dataGridViewProductDetails.Rows[e.RowIndex].Cells["課程開始時間"].Style.ForeColor = Color.Red;
                        IsBeginTimeError = true;
                    }
                    else
                    {
                        dataGridViewProductDetails.Rows[e.RowIndex].Cells["課程開始時間"].Style.ForeColor = Color.Black;
                        IsBeginTimeError = false;
                    }
                }
                else
                {
                    MessageBox.Show("課程開始時間為必填資料，請輸入資料");
                    IsBeginTimeError = true;
                }
            }

            // 課程結束時間
            if (e.ColumnIndex == 1)
            {
                if(dataGridViewProductDetails.Rows[e.RowIndex].Cells["課程結束時間"].Value != null)
                {
                DateTime cellBegin = (DateTime)dataGridViewProductDetails.Rows[e.RowIndex].Cells["課程開始時間"].Value;
                DateTime cellEnd = (DateTime)dataGridViewProductDetails.Rows[e.RowIndex].Cells["課程結束時間"].Value;
                if (cellEnd < cellBegin)
                {
                    MessageBox.Show("課程結束時間不應早於開始時間，請確認。");
                    dataGridViewProductDetails.Rows[e.RowIndex].Cells["課程結束時間"].Style.ForeColor = Color.Red;
                    IsEndTimeError = true;
                }
                else
                {
                    dataGridViewProductDetails.Rows[e.RowIndex].Cells["課程結束時間"].Style.ForeColor = Color.Black;
                    IsEndTimeError = false;
                }
                }
                else
                {
                    MessageBox.Show("課程結束時間為必填資料，請輸入資料");
                    IsEndTimeError = true;
                }

            }

            // 行政區
            if (e.ColumnIndex == 2)
            {
                if (dataGridViewProductDetails.Rows[e.RowIndex].Cells["行政區"].Value == null)
                    return;
                string cell = dataGridViewProductDetails.Rows[e.RowIndex].Cells["行政區"].Value.ToString();
                if (!dbContext.Districts.Any(x => x.District_Name == cell))
                {
                    MessageBox.Show("查無此行政區，請輸入正確的內容。");
                    dataGridViewProductDetails.Rows[e.RowIndex].Cells["行政區"].Style.ForeColor = Color.Red;
                    IsDistrictError = true;
                }
                else
                {
                    dataGridViewProductDetails.Rows[e.RowIndex].Cells["行政區"].Style.ForeColor = Color.Black;
                    IsDistrictError = false;
                }
            }

            // 開課狀態
            if (e.ColumnIndex == 4)
            {
                if (dataGridViewProductDetails.Rows[e.RowIndex].Cells["開課狀態"].Value != null)
                {
                    string cell = dataGridViewProductDetails.Rows[e.RowIndex].Cells["開課狀態"].Value.ToString();
                    if (!dbContext.Status.Where(x => x.Status_Type == "Product_Detail").Any(x => x.Description == cell))
                    {
                        MessageBox.Show("此開課狀態不存在，請輸入正確的內容");
                        dataGridViewProductDetails.Rows[e.RowIndex].Cells["開課狀態"].Style.ForeColor = Color.Red;
                        IsStatusError = true;
                    }
                    else
                    {
                        dataGridViewProductDetails.Rows[e.RowIndex].Cells["開課狀態"].Style.ForeColor = Color.Black;
                        IsStatusError = false;
                    }
                }
                else
                {
                    MessageBox.Show("開課狀態為必填資料，請輸入資料");
                    IsStatusError = true;
                }

            }
        }


        int selectedRowIndex = -1;
        private void dataGridViewProductDetails_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            selectedRowIndex= e.RowIndex;
        }

        private void 刪除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0)
            {
                if (MessageBox.Show("是否刪除此排課？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    listProductDetail.Remove(listProductDetail[selectedRowIndex]);
                    RefreshProductDetailsToDataGridView();
                }
            }

            PictureBox pic = contextMenuStrip1.SourceControl as PictureBox;
            if (pic != null)
            {
                if (MessageBox.Show("是否刪除這張圖片？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if(pic.Tag != null)
                    {
                        // 存放被刪除的圖片id
                        listDeletedImage.Add(pic.Tag.ToString());
                    }
                    
                    flowLayoutPanelPhoto.Controls.Remove(pic);
                    pic.Dispose();
                }
            }
        }

        private void dataGridViewProductDetails_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("資料格式錯誤，請重新輸入");
        }

        private void FrmProductDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["FrmProductList"] != null)
            {
                Application.OpenForms["FrmProductList"].Activate();
                FrmProductList f = Application.OpenForms["FrmProductList"] as FrmProductList;
                f.LoadDataToDataGridView();
            }
        }




    }
}
