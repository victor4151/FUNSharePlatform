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
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
            //this.WindowState= FormWindowState.Maximized;
        }

        private void 檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            FrmCustomerList f = new FrmCustomerList();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            FrmSupplierList F = new FrmSupplierList();
            F.MdiParent = this;
            F.WindowState = FormWindowState.Maximized;
            F.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            FrmProductList f = new FrmProductList();
            f.MdiParent= this;
            f.WindowState= FormWindowState.Maximized;
            f.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Frm_OrderPreview f = new Frm_OrderPreview();
            f.MdiParent = this;
            f.WindowState=FormWindowState.Maximized;
            f.Show();
        }

        private void brnReport_Click(object sender, EventArgs e)
        {
            Frmsomethinchart f = new Frmsomethinchart();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
