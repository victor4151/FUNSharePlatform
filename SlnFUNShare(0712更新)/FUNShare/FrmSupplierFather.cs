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
    public partial class FrmSupplierFather : Form
    {
        public FrmSupplierFather()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)//新增圖片
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picLogo.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        protected virtual void btnSave_Click(object sender, EventArgs e)
        {

        }
        // 將 txtTaxID 控制項的訪問修飾詞改為 protected 或 protected internal，這裡以 protected 為例
        //protected TextBox txtTaxID
        //{
        //    get { return txtTaxID; }
        //    set { txtTaxID = value; }
        //}
    }
}
