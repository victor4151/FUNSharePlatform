using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUNShare
{
    public partial class Frm_LandingPage : Form
    {
        int bannerSpeed = 30;
        FUNShareEntities funshare = new FUNShareEntities();
        bool loginIndex=true;
        bool filterindex = true;
  
        public Frm_LandingPage()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            allProduct();
            this.fLPProducts.AutoScroll = true;
        }

        private void loadData(int x)
        {

            this.splitContainer1.Panel2.Controls.RemoveByKey("oneproduct");
            this.splitContainer1.Panel2.Controls.RemoveByKey("123");
            this.fLPProducts.Visible = true;
            this.panelBanner.Visible = true;
            this.panel2.Visible = true;
            this.timerBanner.Start();
            this.fLPProducts.Controls.Clear();
            try
            {
                var q = (from n in this.funshare.Products.AsEnumerable()
                         where n.Status_ID == 12 && n.ProductCategories.First().SubCategory.Category.Category_ID == x
                         select new
                         {
                             n.UnitPrice,
                             n.Product_Name,
                             n.Image_List.First().Images,
                             n.Product_ID

                         }).ToList();

                for (int i = 0; i <= q.Count() - 1; i++)
                {

                    TableLayoutPanel pro = new TableLayoutPanel();
                    pro.Width = 250;
                    pro.Height = 260;
                    

                    PictureBox proPic = new PictureBox();
                    proPic.Width = 240;
                    proPic.Height = 210;
                    proPic.SizeMode = PictureBoxSizeMode.StretchImage;
                   

                    byte[] bytes = q[i].Images.ToArray();
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                    proPic.Image = Image.FromStream(ms);
                    proPic.Tag = q[i].Product_ID;  //存入ID 作為Tag
                    proPic.Click += X_Click;
                    proPic.MouseHover += ProPic_MouseHover;
                    void ProPic_MouseHover(object sender, EventArgs e)
                    {
                        pro.Width = 300;
                        pro.Height = 350;
                        proPic.Width = 300;
                        proPic.Height = 270;

                    }
                    proPic.MouseLeave += proPic_MouseLeave;
                    void proPic_MouseLeave(object sender, EventArgs e)
                    {
                        pro.Width = 240;
                        pro.Height = 300;
                        proPic.Width = 230;
                        proPic.Height = 210;
                    }

                    Label proName = new Label();
                    Label proPrice = new Label();
                    proName.Text = q[i].Product_Name;
                    proName.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(136))); ;
                    proPrice.Text = $"{q[i].UnitPrice:c2}";
                    proPrice.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(136))); ;
                    pro.Controls.Add(proName);
                    pro.Controls.Add(proPic);
                    pro.Controls.Add(proPrice);


                    this.fLPProducts.Controls.Add(pro);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        
        private void allProduct()
        {

            this.splitContainer1.Panel2.Controls.RemoveByKey("oneproduct");
            this.splitContainer1.Panel2.Controls.RemoveByKey("123");
            this.fLPProducts.Visible = true;
            this.panelBanner.Visible = true;
            this.panel2.Visible = true;
            this.timerBanner.Start();
            this.fLPProducts.Controls.Clear();
            try
            {
                var q = (from n in this.funshare.Products.AsEnumerable()
                         where n.Status_ID == 12 && n.ProductCategories.First().SubCategory_ID!=0
                         select new
                         {
                             n.UnitPrice,
                             n.Product_Name,
                             n.Image_List.First().Images,
                             n.Product_ID

                         }).ToList();

                for (int i =0; i <= q.Count()-1; i++) 
            {
                //tablelayoutpanel 容器
                TableLayoutPanel pro = new TableLayoutPanel();
                pro.Width = 240;
                pro.Height = 300;
                pro.Location = new System.Drawing.Point(20, 20);
              

                    //picturebox 
                    PictureBox proPic = new PictureBox();
                proPic.Width = 230;
                proPic.Height = 210;
                proPic.SizeMode = PictureBoxSizeMode.StretchImage;
                byte[] bytes = q[i].Images.ToArray();
                System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                 proPic.Image = Image.FromStream(ms);
                 proPic.Tag = q[i].Product_ID;  //存入ID 作為Tag
                proPic.Click += X_Click;
                    proPic.MouseHover += ProPic_MouseHover;
                    void ProPic_MouseHover(object sender, EventArgs e)
                    {
                        pro.Width = 300;
                        pro.Height = 350;
                        proPic.Width = 300;
                        proPic.Height = 270;

                    }
                    proPic.MouseLeave += proPic_MouseLeave;
                    void proPic_MouseLeave(object sender, EventArgs e)
                    {
                        pro.Width = 240;
                        pro.Height = 300;
                        proPic.Width = 230;
                        proPic.Height = 210;
                    }

                    //容器
                    Label proName = new Label();
                Label proPrice = new Label();
                proName.Text = q[i].Product_Name;
                proName.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(136))); ;
                proPrice.Text = $"{q[i].UnitPrice:c2}";
                proPrice.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(136))); ;

                pro.Controls.Add(proName);
                pro.Controls.Add(proPic);
                pro.Controls.Add(proPrice);

                this.fLPProducts.Controls.Add(pro);
                
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void X_Click(object sender, EventArgs e)
        {
            
            PictureBox pic = (PictureBox)sender;
            Pro_Click((int)pic.Tag);
            
        }

        private void Pro_Click(int x)
        {

            //this.splitContainer1.Panel2.Controls.Clear();
            this.fLPProducts.Visible = false;
            this.panelBanner.Visible = false;
            this.panel2.Visible = false;
            this.timerBanner.Stop();

            var q = (from n in this.funshare.Products.AsEnumerable()
                     where n.Status_ID == 12 && n.Product_ID == x
                     select new
                     { 
                         n.Product_Name,
                         n.UnitPrice,
                        cat =n.ProductCategories.First().SubCategory.SubCategory_Name,
                        intro = n.Product_Intro,
                        level = n.Level,
                         n.Image_List.First().Images

                     }).ToList();
            //tablelayoutpanel 容器
            TableLayoutPanel pan = new TableLayoutPanel();
            pan.Width = 500;
            pan.Height = 700;
            pan.Location = new Point(40, 40);
            pan.Anchor = AnchorStyles.Left|AnchorStyles.Top|AnchorStyles.Right;

            //picturebox 
            PictureBox proPic = new PictureBox();
            proPic.Width = 400;
            proPic.Height = 400;
            proPic.SizeMode = PictureBoxSizeMode.StretchImage;
            proPic.Location = new Point(300,300);
            byte[] bytes = q[0].Images.ToArray();
            System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
            proPic.Image = Image.FromStream(ms);
            

            //Label
            Label proName = new Label();
            Label proPrice = new Label();
            Label proIntro = new Label();
            proName.Text = $"【{q[0].Product_Name}】   ";
            proName.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(136))); ;
            proName.AutoSize = true;
            proIntro.Text = $"\n\n產品簡介: {q[0].intro}\n產品類型: 【{q[0].cat:c2}】";
            proIntro.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(136))); ;
            proIntro.AutoSize = true;
            proPrice.Text = $"價格: {q[0].UnitPrice:c2}";
            proPrice.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(136))); ;
            proPrice.AutoSize = true;

            //Button
            Button apply = new Button();
            apply.Text = "現在就報名";
            apply.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(136))); ;
            apply.Size = new Size(150,50);
            apply.Location = new Point(Right);


            pan.Controls.Add(proName);
            pan.Controls.Add(proPic);
            pan.Controls.Add(proIntro);
            pan.Controls.Add(proPrice);
            pan.Controls.Add(apply);

            pan.Name = "oneproduct";
            this.splitContainer1.Panel2.Controls.Add(pan);
          
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)  //登入 註冊
        {
            Frm_Login login = new Frm_Login();
            if (loginIndex ==true)
            {
                
                login.Show();
                login.loginmood += Login_loginmood; //委派觸發事件
                login.exit += Form_exit;
            }
            loginIndex = false;
            
        }

        private void Form_exit()
        {
            loginIndex = true;
            filterindex = true;
        }

        int tempmemberID;
        private void Login_loginmood(string mail, string password)
        {
            pictureBox2.Visible = false;
            pictureBox2.Enabled = false;

            var q = (from n in funshare.Customer_Infomation
                     where n.Email == mail &&n.Password == password
                    select n
                    ).ToList();

            
            tempmemberID = q[0].Member_ID;

            byte[] bytes = q[0].Photo.ToArray();
            System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
            

            MenuStrip profile = new MenuStrip();
            ToolStripMenuItem loginPerson = new ToolStripMenuItem();
            ToolStripMenuItem personalPage = new ToolStripMenuItem();
            ToolStripMenuItem myOrder = new ToolStripMenuItem();
            ToolStripMenuItem myPockList = new ToolStripMenuItem();

            splitContainer2.Panel1.Controls.Add(profile);
            profile.Dock = DockStyle.Right;
            profile.BackgroundImage = Image.FromStream(ms);
            profile.BackgroundImageLayout = ImageLayout.Stretch;
            profile.Items.AddRange(new ToolStripItem[]
            {
                loginPerson
            });

                loginPerson.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                personalPage,
                myOrder,
                myPockList

            });
            loginPerson.Text = q[0].Name;
            personalPage.Text = "個人資料";
            personalPage.Click += PersonalPage_Click;
            myOrder.Text = "訂單資料";
            myPockList.Text = "我的收藏";
            loginPerson.Size = new Size(30, 30);

        }//登入後 PROFILE設定

        private void PersonalPage_Click(object sender, EventArgs e)
        {
            FrmCustomerDetail frmCustomerDetail = new FrmCustomerDetail();
            frmCustomerDetail.MemberID = tempmemberID;
            //if ((int.TryParse(dataGridView1.CurrentRow.Cells["會員編號"].Value.ToString(), out int memberID)))
            //    frmCustomerDetail.MemberID = memberID;
            //if (dataGridView1.CurrentRow.Cells["家長會員編號"].Value != null)
            //{
            //    if ((int.TryParse(dataGridView1.CurrentRow.Cells["家長會員編號"].Value.ToString(), out int parentID)))
            //        frmCustomerDetail.ParentID = parentID;
            //}
            //frmCustomerDetail.ShowDialog();
            this.fLPProducts.Visible = false;
            this.panelBanner.Visible = false;
            this.panel2.Visible = false;
            this.timerBanner.Stop();
            frmCustomerDetail.TopLevel = false;
            this.splitContainer1.Panel2.Controls.Add(frmCustomerDetail);
            frmCustomerDetail.Dock = DockStyle.Fill;
            frmCustomerDetail.Show();
            frmCustomerDetail.Name = "123";
        }
        private void timerBanner_Tick(object sender, EventArgs e)
        {
            banner1.Left += bannerSpeed;
            banner2.Left += bannerSpeed;
            banner3.Left += bannerSpeed;
            banner4.Left += bannerSpeed;

            if (banner2.Left > 2067)
            {
                banner2.Left = -689;
            }
            if (banner1.Left > 2067)
            {
                banner1.Left = -689;
            }
            if (banner3.Left > 2067)
            {
                banner3.Left = -689;
            }
            if (banner4.Left > 2067)
            {
                banner4.Left = -689;
            }

        }//Banner的輪轉

        private void PanelBanner_MouseHover(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Frm_LandingPage_Load(object sender, EventArgs e) 
        {
            timerBanner.Start();
        }

        private void panelAll_Click(object sender, EventArgs e)
        {
            allProduct();
        }

        private void panelCamp_Click(object sender, EventArgs e)
        {
           
            loadData(1);
        }

        private void panelExperience_Click(object sender, EventArgs e)
        {
            loadData(2);
        }

        private void panelTalent_Click(object sender, EventArgs e)
        {
            loadData(3);
        }

        private void panelScience_Click(object sender, EventArgs e)
        {
            loadData(4);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (filterindex)
            {
                Frm_Filter filter = new Frm_Filter();
                filter.Text = "篩選器";
                filter.ValueSelected += filter_data;
                filter.Show();
                filter.exit += Form_exit;
            }
            filterindex = false;
      

        }
        private void filter_data(CProduct selectedValue)
        {
            // 在這裡處理從子表單中返回的值
            //MessageBox.Show("選擇的值是：" + selectedValue);
            this.splitContainer1.Panel2.Controls.RemoveByKey("oneproduct");
            this.fLPProducts.Visible = true;
            this.panelBanner.Visible = true;
            this.panel2.Visible = true;
            this.timerBanner.Start();
            this.fLPProducts.Controls.Clear();

            if (selectedValue.cityName == null ||selectedValue.cityName =="全部")
            {
                try
                {
                    var q = (from n in this.funshare.Products.AsEnumerable()
                             where n.Status_ID == 12
                             && n.Product_Detail.First().District_ID.HasValue == true
                             &&n.Product_Name.Contains(selectedValue.Name)
                                          && n.UnitPrice <= selectedValue.price
                                          &&n.Product_Detail.First().Begin_Time>=selectedValue.start && n.Product_Detail.First().End_Time<=selectedValue.end
                             select new
                             {
                                 n.UnitPrice,
                                 n.Product_Name,
                                 n.Image_List.First().Images,
                                 n.Product_ID

                             }).ToList();

                    for (int i = 0; i <= q.Count() - 1; i++)
                    {

                        TableLayoutPanel pro = new TableLayoutPanel();
                        pro.Width = 250;
                        pro.Height = 260;
                        pro.Location = new System.Drawing.Point(20, 20);

                        PictureBox proPic = new PictureBox();
                        proPic.Width = 240;
                        proPic.Height = 210;
                        proPic.SizeMode = PictureBoxSizeMode.StretchImage;
                        byte[] bytes = q[i].Images.ToArray();
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                        proPic.Image = Image.FromStream(ms);
                        proPic.Tag = q[i].Product_ID;  //存入ID 作為Tag
                        proPic.Click += X_Click;
                        proPic.MouseHover += ProPic_MouseHover;
                        void ProPic_MouseHover(object sender, EventArgs e)
                        {
                            pro.Width = 300;
                            pro.Height = 350;
                            proPic.Width = 300;
                            proPic.Height = 270;

                        }
                        proPic.MouseLeave += proPic_MouseLeave;
                        void proPic_MouseLeave(object sender, EventArgs e)
                        {
                            pro.Width = 240;
                            pro.Height = 300;
                            proPic.Width = 230;
                            proPic.Height = 210;
                        }

                        Label proName = new Label();
                        Label proPrice = new Label();
                        proName.Text = q[i].Product_Name;
                        proName.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(136))); ;
                        proPrice.Text = $"{q[i].UnitPrice:c2}";
                        proPrice.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(136))); ;
                        pro.Controls.Add(proName);
                        pro.Controls.Add(proPic);
                        pro.Controls.Add(proPrice);


                        this.fLPProducts.Controls.Add(pro);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (selectedValue.cityName != null)
            {
                try
                {
                    var q = (from n in this.funshare.Products.AsEnumerable()
                             where n.Status_ID == 12
                             && n.Product_Detail.First().District_ID.HasValue == true
                             && n.Product_Detail.First().District.City.City_Name == selectedValue.cityName
                             && n.Product_Name.Contains(selectedValue.Name)
                             && n.UnitPrice <= selectedValue.price
                             && n.Product_Detail.First().Begin_Time >= selectedValue.start && n.Product_Detail.First().End_Time <= selectedValue.end
                             select new
                             {
                                 n.UnitPrice,
                                 n.Product_Name,
                                 n.Image_List.First().Images,
                                  n.Product_ID

                             }).ToList();

                    for (int i = 0; i <= q.Count() - 1; i++)
                    {

                        TableLayoutPanel pro = new TableLayoutPanel();
                        pro.Width = 250;
                        pro.Height = 260;
                        pro.Location = new System.Drawing.Point(20, 20);
                        PictureBox proPic = new PictureBox();
                        proPic.Width = 240;
                        proPic.Height = 210;
                        proPic.SizeMode = PictureBoxSizeMode.StretchImage;
                       

                        byte[] bytes = q[i].Images.ToArray();
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                        proPic.Image = Image.FromStream(ms);
                        proPic.Tag = q[i].Product_ID;  //存入ID 作為Tag
                        proPic.Click += X_Click;
                        proPic.MouseHover += ProPic_MouseHover;
                        void ProPic_MouseHover(object sender, EventArgs e)
                        {
                            pro.Width = 300;
                            pro.Height = 350;
                            proPic.Width = 300;
                            proPic.Height = 270;

                        }
                        proPic.MouseLeave += proPic_MouseLeave;
                        void proPic_MouseLeave(object sender, EventArgs e)
                        {
                            pro.Width = 240;
                            pro.Height = 300;
                            proPic.Width = 230;
                            proPic.Height = 210;
                        }

                        Label proName = new Label();
                        Label proPrice = new Label();
                        proName.Text = q[i].Product_Name;
                        proName.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(136))); ;
                        proPrice.Text = $"{q[i].UnitPrice:c2}";
                        proPrice.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(136))); ;
                        pro.Controls.Add(proName);
                        pro.Controls.Add(proPic);
                        pro.Controls.Add(proPrice);


                        this.fLPProducts.Controls.Add(pro);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            allProduct();
        }

        private void pictureBoxFilter_Click(object sender, EventArgs e)
        {
            if (filterindex)
            {
                Frm_Filter filter = new Frm_Filter();
                filter.Text = "篩選器";
                filter.ValueSelected += filter_data;
                filter.Show();
                filter.exit += Form_exit;
            }
            filterindex = false;

        }

    }
}
