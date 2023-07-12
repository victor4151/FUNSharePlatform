using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FUNShare.Models;

namespace FUNShare
{
    public partial class Frm_Order : Form
    {        
        public Frm_Order()
        {
            InitializeComponent();
            loadProductInfo();            
            dtOrderDate.Enabled = false;
            cbOrderStatus.Enabled = false;
            cbPayStatus.Enabled = false;
            tbOrder.Enabled = false;            
            tbAmount.Text = "";

        }

        public Frm_Order(int orderID)
        {
            InitializeComponent();
            loadProductInfo();
            dtOrderDate.Enabled = false;
            cbOrderStatus.Enabled = false;
            cbPayStatus.Enabled = false;
            tbOrder.Enabled = false;
            tbAmount.Text = "";

            try
            {
                // FrmOrderPreview的指定訂單資料
                var q1 = (from o in dbContext.Order_Detail.AsEnumerable()
                          where o.Order_ID == orderID
                          select o).ToList();

                var q2 = (from o in dbContext.Orders.AsEnumerable()
                          where o.Order_ID == orderID
                          select o).ToList();

                var q3 = from o in dbContext.Order_Detail.AsEnumerable()
                         where o.Order_ID == orderID
                         select (new
                         {
                             商品名稱 = o.Product_Detail.Product.Product_Name,
                             售價 = o.Product_Detail.Product.UnitPrice,
                             數量 = 1,
                         });

                // OrderID           
                tbOrder.Text = Convert.ToString(q1[0].Order_ID);

                // 訂購時間
                this.dtOrderDate.Text = Convert.ToString(q1[0].Order.Order_Time);

                // 訂單狀態
                this.cbOrderStatus.Items.Add(Convert.ToString(q1[0].Status.Description));
                cbOrderStatus.SelectedIndex = 0;

                // 會員編號 
                this.tbCustomer.Text = Convert.ToString(q1[0].Customer_Infomation.Resident_ID);

                // 會員姓名 
                this.tbCustomerName.Text = Convert.ToString(q1[0].Customer_Infomation.Name);

                // 統編 
                this.tbTaxID.Text = Convert.ToString(q1[0].Order.Tax_ID);

                // 訂單金額 
                this.tbAmount.Text = Convert.ToString(q1[0].Product_Detail.Product.UnitPrice);

                // 付款狀態  
                this.cbPayStatus.Items.Add(Convert.ToString(q2[0].Status.Description));
                cbPayStatus.SelectedIndex = 0;

                // 下方商品資訊
                this.lbOrderContent.DataSource = q3.ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        FUNShareEntities dbContext = new FUNShareEntities();
        

        public void loadProductInfo()
        {
            try
            {
                // 將產品名稱和售價放進"訂購商品"內
                var q0 = from p in dbContext.Products.AsEnumerable()
                         where p.Status_ID == 12
                         select p;

                foreach (var p in q0)
                {
                    cbProduct.Items.Add(p.Product_Name);
                    ProductID.Text = p.Product_ID.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void cbProduct_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string selectProduct = cbProduct.Text;
                var q0 = from p in dbContext.Products.AsEnumerable()
                         where p. Product_Name == selectProduct 
                         select p;

                foreach (var p in q0)
                {
                    tbAmount.Text = p.UnitPrice.ToString();
                    ProductID.Text = p.Product_ID.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        

        public int Order_ID { get; set; } // 讀取Order_ID
        public string Product_Name { get; set; } // 讀取Product_Name   

        private void Frm_Order_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    // FrmOrderPreview的指定訂單資料
            //    var q1 = (from o in dbContext.Order_Detail.AsEnumerable()
            //              where o.Order_ID == Order_ID
            //              select o).ToList();

            //    var q2 = (from o in dbContext.Orders.AsEnumerable()
            //              where o.Order_ID == Order_ID
            //              select o).ToList();
                
            //    var q3 = from o in dbContext.Order_Detail.AsEnumerable()
            //             where o.Order_ID == Order_ID
            //                 select (new
            //                 {
            //                     商品名稱 = o.Product_Detail.Product.Product_Name,
            //                     售價 = o.Product_Detail.Product.UnitPrice,
            //                     數量 = 1,
            //                 });               

            //    // OrderID           
            //    tbOrder.Text = Convert.ToString(q1[0].Order_ID);

            //    // 訂購時間
            //    this.dtOrderDate.Text = Convert.ToString(q1[0].Order.Order_Time);

            //    // 訂單狀態
            //    this.cbOrderStatus.Items.Add(Convert.ToString(q1[0].Status.Description));
            //    cbOrderStatus.SelectedIndex = 0;

            //    // 會員編號 
            //    this.tbCustomer.Text = Convert.ToString(q1[0].Customer_Infomation.Resident_ID);

            //    // 會員姓名 
            //    this.tbCustomerName.Text = Convert.ToString(q1[0].Customer_Infomation.Name);

            //    // 統編 
            //    this.tbTaxID.Text = Convert.ToString(q1[0].Order.Tax_ID);

            //    // 訂單金額 
            //    this.tbAmount.Text = Convert.ToString(q1[0].Product_Detail.Product.UnitPrice);

            //    // 付款狀態  
            //    this.cbPayStatus.Items.Add(Convert.ToString(q2[0].Status.Description));
            //    cbPayStatus.SelectedIndex = 0;

            //    // 下方商品資訊
            //    this.lbOrderContent.DataSource = q3.ToList();
                
            //}
            //catch (Exception ex) 
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            // 清空所有資料準備新增
            tbOrder.Text = "";
            dtOrderDate.Value = DateTime.Now;
            cbOrderStatus.Text = "";
            tbCustomer.Text = "";
            tbCustomerName.Text = "";
            tbTaxID.Text = "";
            tbTitle.Text = "";
            tbAmount.Text = "";
            cbPayStatus.Text = "";
            lbOrderContent.Text = null;
        }        

        private void CreateNewOrd()
        {
            Order order = new Order();
            Order_Detail orderDetail = new Order_Detail();
            Customer_Infomation cusInfo = new Customer_Infomation();

            try
            {                
                cbOrderStatus.Enabled = false;
                cbPayStatus.Enabled = false;
                tbOrder.Enabled = false;
                string customerID = tbCustomer.Text;
                var q4 = (from o in dbContext.Customer_Infomation.AsEnumerable()
                          where o.Resident_ID == customerID
                          select o).ToList();
                bool IDexists = dbContext.Customer_Infomation.AsEnumerable().Any(x => x.Resident_ID == customerID);

                // 檢查必填欄位是否和資料庫資料符合

                if (!IDexists)
                {
                    MessageBox.Show("未查詢到會員，請確認會員身分證字號或註冊新會員");
                    label3.ForeColor = Color.Red;

                }
                if (!string.IsNullOrEmpty(tbOrder.Text)) 
                {
                    MessageBox.Show("已有訂單編號的修改請點選【儲存】");

                }
                else
                {

                    // 訂購時間
                    DateTime now = DateTime.Now;
                    order.Order_Time = now;

                    // 付款狀態 狀態：未付款
                    order.Status_ID = 5;

                    // 會員編號
                    var q5 = (from c in dbContext.Customer_Infomation.AsEnumerable()
                              where c.Resident_ID == customerID
                              select c.Member_ID);

                    var q6 = from p in dbContext.Products.AsEnumerable()
                             where p.Product_ID == cbProduct.SelectedIndex
                             select p.UnitPrice;
                    int findMember = dbContext.Customer_Infomation.AsEnumerable().Where(x => x.Resident_ID == customerID).Select(x => x.Member_ID).First();
                    order.Member_ID = findMember;
                    orderDetail.Member_ID = findMember;

                    //// 會員姓名             

                    // 統編 
                    order.Tax_ID = this.tbTaxID.Text;

                    // 訂單金額                   
                    //tbAmount.Text = q6.ToString();

                    // 訂單狀態  狀態：報名成功
                    orderDetail.Status_ID = 8;

                    // 產品細節
                    orderDetail.Product_Detail_ID = dbContext.Product_Detail.AsEnumerable().Where(x => x.Product_ID == Convert.ToUInt32(ProductID.Text)).Select(x => x.Product_Detail_ID).First();


                    dbContext.Orders.Add(order);

                    //// 新訂單資料新增  
                    orderDetail.Order_ID = order.Order_ID;

                    dbContext.Order_Detail.Add(orderDetail);
                    dbContext.SaveChanges();
                    cbOrderStatus.Enabled = true;
                    cbPayStatus.Enabled = true;
                    MessageBox.Show("新增訂單成功");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void toolStripNewSave_Click(object sender, EventArgs e)
        {
            CreateNewOrd();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {            
            bool isReserved = dbContext.Order_Detail.AsEnumerable().Any(x => x.Status_ID == 8);
            bool isRefundable = dbContext.Order_Detail.AsEnumerable().Any(x => x.Status_ID == 4);

            if (!isReserved || !isRefundable)
            {
                MessageBox.Show("取消或退款訂單需訂單狀態為已付款和報名成功");

            }
            else 
            {
                var q9 = (from o in dbContext.Orders.AsEnumerable()
                          where o.Order_ID == this.Order_ID
                          select o).ToList();

                var q10 = (from od in dbContext.Order_Detail.AsEnumerable()
                          where od.Order_ID == this.Order_ID
                          select od).ToList();

                // 修改付款狀態 訂單狀態：取消
                q9[0].Status_ID = 6;

                // 修改訂單狀態 訂單狀態：候補中
                q10[0].Status_ID = 7;

                MessageBox.Show("已取消訂單，請重新讀取訂單，並且確認實際為客人退款");

            }
            dbContext.SaveChanges();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            // 儲存訂單(修改)
            try
            {
                string customerID = tbCustomer.Text;
                var q7 = (from o in dbContext.Customer_Infomation.AsEnumerable()
                          where o.Resident_ID == customerID
                          select o).ToList();
                bool NOTexists = (q7[0].Resident_ID != customerID);

                //判斷身分證字號是否和資料庫相同

                if (NOTexists)
                {
                    MessageBox.Show("未查詢到會員，請確認會員身分證字號或註冊新會員");
                }
                else
                {
                    SaveInfo();
                    MessageBox.Show($"已儲存訂單");                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void SaveInfo() 
        {
            try
            {
                
                StringBuilder errorMessage = new StringBuilder();
                var q7 = (from o in dbContext.Orders.AsEnumerable()
                         where o.Order_ID == this.Order_ID
                         select o).ToList();

                var q8 = (from od in dbContext.Order_Detail.AsEnumerable()
                         where od.Order_ID == this.Order_ID
                         select od).ToList();

                //var q9 = (from ci in dbContext.Customer_Infomation.AsEnumerable()
                //          where ci.Resident_ID == order.ID
                //          select ci).ToList();

                if (string.IsNullOrEmpty(tbOrder.Text))
                {
                    errorMessage.AppendLine("新增訂單請點選【新增儲存】");
                }
                if (string.IsNullOrEmpty(tbCustomer.Text))
                {
                    errorMessage.AppendLine("請輸入身分證字號");
                }
                if (string.IsNullOrEmpty(tbCustomerName.Text))
                {
                    errorMessage.AppendLine("請輸入訂購人姓名");
                }
                else 
                {
                    // 修改付款狀態(Orders)
                    string orderStatus = this.cbOrderStatus.SelectedItem.ToString();
                    q7[0].Status_ID = dbContext.Status.Where(x => x.Description == orderStatus).Select(x => x.Status_ID).First();

                    //// 修改姓名
                    //q9[0].Name = this.tbCustomerName.Text;

                    // 修改統編               
                    q7[0].Tax_ID = this.tbTaxID.Text;

                    // 修改報名狀態(Order_Detail)
                    string payStatus = this.cbPayStatus.SelectedItem.ToString();
                    q8[0].Status_ID = dbContext.Status.Where(x => x.Description == payStatus).Select(x => x.Status_ID).First();

                    // 修改產品
                    string productDetail = this.cbProduct.SelectedItem.ToString();
                    q8[0].Product_Detail_ID = dbContext.Product_Detail.AsEnumerable().Where(x => x.Product_ID == Convert.ToUInt32(ProductID.Text)).Select(x => x.Product_Detail_ID).First();
                }
                dbContext.SaveChanges();

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);

            }

        }
                
    }
    
}
