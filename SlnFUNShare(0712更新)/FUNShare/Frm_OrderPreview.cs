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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using FUNShare.Models;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms.VisualStyles;

namespace FUNShare
{
    public partial class Frm_OrderPreview : Form
    {

        public Frm_OrderPreview()
        {
            InitializeComponent();
            loadStatus();
            dtEnd.Value = DateTime.Now;
            DateTime oldest = new DateTime(2000, 1, 31);
            dtBegin.Value = oldest;

        }
        FUNShareEntities dbContext = new FUNShareEntities();

        private void loadStatus()
        {
            try
            {                
                // 將產品名稱和售價放進"訂購商品"內
                var q0 = from s in dbContext.Status.AsEnumerable()
                         where s.Status_Type == "Order_Detail"
                         select s.Description;
                List<string> statusList = q0.ToList();
                statusList.Insert(0, "");
                cbStatus.DataSource = statusList;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }      

        private void toolStripButton1_Click(object sender, EventArgs e)
        {                               

            try
            {
                //int order = Convert.ToInt32(tbOrder.Text);
                var q1 = from o in dbContext.Order_Detail.AsEnumerable()
                         where SearchCheck(o)
                         select (new COrder
                         {
                             訂單編號 = o.Order_ID,
                             訂購時間 = o.Order.Order_Time,
                             身分證字號 = o.Customer_Infomation.Resident_ID,
                             訂購人姓名 = o.Customer_Infomation.Name,
                             商品名稱 = o.Product_Detail.Product.Product_Name,
                             供應商 = o.Product_Detail.Product.Supplier.Supplier_Name,
                             訂單狀態 = o.Status.Description,
                         });

                this.dataGridView1.DataSource = q1.ToList();


                //var q1 = this.dbContext.Order_Detail.Select(o => new COrder
                //{
                //    OrderID = o.Order_ID,
                //    OrderDate = o.Order.Order_Time,
                //    ID = o.Customer_Infomation.Resident_ID,
                //    Name = o.Customer_Infomation.Name,
                //    ProductName = o.Product_Detail.Product.Product_Name,
                //    Supplier = o.Product_Detail.Product.Supplier.Supplier_Name,
                //    Status = o.Status.Description,                    
                //});

                //this.dataGridView1.DataSource = q1.ToList();


                ////string category = tbCategory.Text;

                //if (tbOrder.Text != "")
                //{
                //    // 判斷訂單編號
                //    int order = Convert.ToInt32(tbOrder.Text);
                //    var q2 = from o in dbContext.Order_Detail
                //             where o.Order_ID == order
                //             select (new COrder
                //             {
                //                 OrderID = o.Order_ID,
                //                 OrderDate = o.Order.Order_Time,
                //                 ID = o.Customer_Infomation.Resident_ID,
                //                 Name = o.Customer_Infomation.Name,
                //                 ProductName = o.Product_Detail.Product.Product_Name,
                //                 Supplier = o.Product_Detail.Product.Supplier.Supplier_Name,
                //                 Status = o.Status.Description,
                //             });
                //    this.dataGridView1.DataSource = q2.ToList();
                //}
                //if (tbID.Text != "")
                //{
                //    // 判斷身分證字號
                //    string ID = Convert.ToString(tbID.Text);
                //    var q2 = from o in dbContext.Order_Detail
                //             where o.Customer_Infomation.Resident_ID == ID
                //             select (new COrder
                //             {
                //                 OrderID = o.Order_ID,
                //                 OrderDate = o.Order.Order_Time,
                //                 ID = o.Customer_Infomation.Resident_ID,
                //                 Name = o.Customer_Infomation.Name,
                //                 ProductName = o.Product_Detail.Product.Product_Name,
                //                 Supplier = o.Product_Detail.Product.Supplier.Supplier_Name,
                //                 Status = o.Status.Description,
                //             });
                //    this.dataGridView1.DataSource = q2.ToList();
                //}
                //if (tbSupplier.Text != "")
                //{
                //    // 判斷供應商
                //    string supplier = tbSupplier.Text;
                //    var q2 = from o in dbContext.Order_Detail
                //             where o.Product_Detail.Product.Supplier.Supplier_Name.Contains(supplier)
                //             select (new COrder
                //             {
                //                 OrderID = o.Order_ID,
                //                 OrderDate = o.Order.Order_Time,
                //                 ID = o.Customer_Infomation.Resident_ID,
                //                 Name = o.Customer_Infomation.Name,
                //                 ProductName = o.Product_Detail.Product.Product_Name,
                //                 Supplier = o.Product_Detail.Product.Supplier.Supplier_Name,
                //                 Status = o.Status.Description,
                //             });
                //    this.dataGridView1.DataSource = q2.ToList();
                //}
                //if (tbContact.Text != "")
                //{
                //    // 判斷訂購人姓名
                //    string ContactPerson = tbContact.Text;
                //    var q2 = from o in dbContext.Order_Detail
                //             where o.Customer_Infomation.Name.Contains(ContactPerson)
                //             select (new COrder
                //             {
                //                 OrderID = o.Order_ID,
                //                 OrderDate = o.Order.Order_Time,
                //                 ID = o.Customer_Infomation.Resident_ID,
                //                 Name = o.Customer_Infomation.Name,
                //                 ProductName = o.Product_Detail.Product.Product_Name,
                //                 Supplier = o.Product_Detail.Product.Supplier.Supplier_Name,
                //                 Status = o.Status.Description,
                //             });
                //    this.dataGridView1.DataSource = q2.ToList();
                //}
                //if (cbStatus.Text != "")                
                //{
                //    // 判斷訂單狀態
                //    string s = cbStatus.Text;
                //    var q2 = from o in dbContext.Order_Detail
                //             where o.Status.Description == s
                //             select (new COrder
                //             {
                //                 OrderID = o.Order_ID,
                //                 OrderDate = o.Order.Order_Time,
                //                 ID = o.Customer_Infomation.Resident_ID,
                //                 Name = o.Customer_Infomation.Name,
                //                 ProductName = o.Product_Detail.Product.Product_Name,
                //                 Supplier = o.Product_Detail.Product.Supplier.Supplier_Name,
                //                 Status = o.Status.Description,
                //             });

                //    this.dataGridView1.DataSource = q2.ToList();
                //}
                //if (!string.IsNullOrEmpty(dtBegin.Text) || !string.IsNullOrEmpty(dtEnd.Text))
                //{
                //    // 判斷訂購日期
                //    DateTime dateBegin = dtBegin.Value.Date;
                //    DateTime dateEnd = dtEnd.Value.Date.AddDays(1).AddSeconds(-1);

                //    if (!string.IsNullOrEmpty(dtBegin.Text) && string.IsNullOrEmpty(dtEnd.Text))
                //    {

                //        var q2 = from o in dbContext.Order_Detail
                //                  where o.Order.Order_Time >= dateBegin
                //                  select (new COrder
                //                  {
                //                      OrderID = o.Order_ID,
                //                      OrderDate = o.Order.Order_Time,
                //                      ID = o.Customer_Infomation.Resident_ID,
                //                      Name = o.Customer_Infomation.Name,
                //                      ProductName = o.Product_Detail.Product.Product_Name,
                //                      Supplier = o.Product_Detail.Product.Supplier.Supplier_Name,
                //                      Status = o.Status.Description,
                //                  });

                //        this.dataGridView1.DataSource = q2.ToList();
                //    }
                //    if (string.IsNullOrEmpty(dtBegin.Text) && !string.IsNullOrEmpty(dtEnd.Text))
                //    {
                //        var q2 = from o in dbContext.Order_Detail
                //                  where o.Order.Order_Time <= dateEnd
                //                  select (new COrder
                //                  {
                //                      OrderID = o.Order_ID,
                //                      OrderDate = o.Order.Order_Time,
                //                      ID = o.Customer_Infomation.Resident_ID,
                //                      Name = o.Customer_Infomation.Name,
                //                      ProductName = o.Product_Detail.Product.Product_Name,
                //                      Supplier = o.Product_Detail.Product.Supplier.Supplier_Name,
                //                      Status = o.Status.Description,
                //                  });

                //        this.dataGridView1.DataSource = q2.ToList();
                //    }
                //    if (!string.IsNullOrEmpty(dtBegin.Text) && string.IsNullOrEmpty(dtEnd.Text))
                //    {
                //        var q2 = from o in dbContext.Order_Detail
                //                  where o.Order.Order_Time >= dateBegin
                //                  where o.Order.Order_Time <= dateEnd
                //                  select (new COrder
                //                  {
                //                      OrderID = o.Order_ID,
                //                      OrderDate = o.Order.Order_Time,
                //                      ID = o.Customer_Infomation.Resident_ID,
                //                      Name = o.Customer_Infomation.Name,
                //                      ProductName = o.Product_Detail.Product.Product_Name,
                //                      Supplier = o.Product_Detail.Product.Supplier.Supplier_Name,
                //                      Status = o.Status.Description,
                //                  });

                //        this.dataGridView1.DataSource = q2.ToList();
                ////    }

                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        public bool SearchCheck(Order_Detail order)
        {
            // 訂單篩選
            if (int.TryParse(tbOrder.Text, out int ord) || tbOrder.Text != "")
            {
                if (order.Order_ID != ord)
                    return false;
            }

            // 身分證篩選
            if (tbID.Text != "" && order.Customer_Infomation.Resident_ID != tbID.Text) 
                return false;
            // 供應商篩選
            if (!(order.Product_Detail.Product.Supplier.Supplier_Name.Contains(tbSupplier.Text)) && tbSupplier.Text != "")
                return false;
            // 聯絡人篩選
            if (!(order.Customer_Infomation.Name.Contains(tbContact.Text)) && tbContact.Text != "")
                return false;
            // 狀態篩選
            if (!(order.Status.Description == cbStatus.Text) && cbStatus.Text != "")
                return false;
            // 出發日期篩選
            if (!(order.Order.Order_Time >= dtBegin.Value))
                // if (!string.IsNullOrEmpty(dtBegin.Text) && string.IsNullOrEmpty(dtEnd.Text) || (!string.IsNullOrEmpty(dtBegin.Text) && string.IsNullOrEmpty(dtEnd.Text)))  
                return false;
            if (!(order.Order.Order_Time <= dtEnd.Value))
                return false;
            //if (!(order.Order.Order_Time >= dtBegin.Value) && !(order.Order.Order_Time <= dtEnd.Value))
            return true;
        }



        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Frm_Order frmOrder = new Frm_Order((int)this.dataGridView1.CurrentRow.Cells[0].Value);
            frmOrder.Order_ID = (int)this.dataGridView1.CurrentRow.Cells[0].Value;
            frmOrder.Product_Name = (string)this.dataGridView1.CurrentRow.Cells[4].Value;

            frmOrder.ShowDialog();

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Frm_Order frmOrder = new Frm_Order();
            // 新增訂單           
            frmOrder.Show();
        }


    }

    
}
