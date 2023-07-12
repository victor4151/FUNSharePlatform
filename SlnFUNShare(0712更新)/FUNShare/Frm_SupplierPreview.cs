using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Entity;

namespace FUNShare
{
    public partial class Frm_SupplierPreview : Form
    {
        public Frm_SupplierPreview()
        {
            InitializeComponent();
            loadData();
            
        }
        FUNShareEntities dbContext = new FUNShareEntities();
        private void loadData()
        {
            //SqlConnection conn = null;
            //try
            //{
            //    conn = new SqlConnection("Data Source=192.168.31.93;Initial Catalog=親子平台;Persist Security Info=True;User ID=FUNShareDB;Password=987654321");

            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand("select * from Supplier", conn);
            //    SqlDataReader datareader = cmd.ExecuteReader();

            //    this.dataGridView1.DataSource = datareader;

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            var q = from n in dbContext.Suppliers
                    select n;
            this.dataGridView1.DataSource = q.ToList();
        }
    }
}
