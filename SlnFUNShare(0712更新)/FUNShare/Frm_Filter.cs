using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FUNShare
{
    public partial class Frm_Filter : Form
    {
        FUNShareEntities funshare = new FUNShareEntities();
        public delegate void ValueSelectedHandler(CProduct selectedValue);
        public event ValueSelectedHandler ValueSelected;
        public delegate void Close();
        public event Close exit;

        //public object getdata { get; private set; }

        public Frm_Filter()
        {
            InitializeComponent();
            this.comboBoxCities.Items.Add("全部");
            loadData();
            

        }

        private void loadData()
        {
            
            var q =from n in this.funshare.Cities
                    select n.City_Name;
            foreach (var item in q)
            {
                this.comboBoxCities.Items.Add(item);
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)//Todo...如果是空白值的查詢
        {
            CProduct p = new CProduct();


            if (comboBoxCities.SelectedItem != null)
            {
                p.cityName = this.comboBoxCities.SelectedItem.ToString();
                p.Name = this.txtName.Text;
                p.price = this.trackBarPrice.Value;
                p.start = this.dateTimePickerStart.Value;
                p.end = this.dateTimePickerEnd.Value;
                ValueSelected.Invoke(p);
            }
            else
            p.Name = this.txtName.Text;
            p.price = this.trackBarPrice.Value;
            p.start = this.dateTimePickerStart.Value;
            p.end = this.dateTimePickerEnd.Value;
            ValueSelected.Invoke(p);


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            comboBoxCities.Text = string.Empty;
            comboBoxCities.Items.Clear();
            trackBarPrice.Value = 0;

        }

        private void trackBarPrice_Scroll(object sender, EventArgs e)
        {
            labNT.Text =$"{ trackBarPrice.Value:c}";
        }

        private void Frm_Filter_Load(object sender, EventArgs e)
        {

        }

        private void Frm_Filter_FormClosed(object sender, FormClosedEventArgs e)
        {
            exit();
        }
    }
}

public class CProduct
{
    public string cityName { get; set; }
    public string Name { get; set; }

    public decimal price { get; set; }

    public DateTime start { get; set; }
    public DateTime end { get; set; }
}
    


