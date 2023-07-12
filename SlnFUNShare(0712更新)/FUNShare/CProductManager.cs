using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUNShare.Models
{
    public class CProductManager
    {
        FUNShareEntities dbContext = new FUNShareEntities();
        public void LoadDataToCmbBoxAge(ComboBox cmb)
        {
            var q = from a in dbContext.Ages
                    select a;

            foreach (var a in q)
            {
                cmb.Items.Add(a.Grade);
            }
        }

        public void LoadDataToCmbBoxCategory(ComboBox cmb)
        {
            var q = from c in dbContext.Categories
                    select c;

            foreach (var c in q)
            {
                cmb.Items.Add(c.Category_Name);
            }
        }

        public void LoadDataToCmbBoxSubCategory(ComboBox cmb, ComboBox cmbSub)
        {
            cmbSub.Items.Clear();
            var q = from sub in dbContext.SubCategories
                    where sub.Category.Category_Name == cmb.SelectedItem.ToString()
                    select sub;

            foreach (var sub in q)
            {
                cmbSub.Items.Add(sub.SubCategory_Name);
            }
            if (cmbSub.Items.Count > 0)
            {
                cmbSub.SelectedIndex = 0;
            }
            else
            {
                cmbSub.Items.Clear();
            }
        }
        public void LoadDataToCmbBoxStatus(ComboBox cmb)
        {
            var q = from s in dbContext.Status
                    where s.Status_Type == "Product"
                    select s;

            foreach (var s in q)
            {
                cmb.Items.Add(s.Description);
            }
        }
        public void LoadDataToCmbBoxStatus(ToolStripComboBox cmb)
        {
            var q = from s in dbContext.Status
                    where s.Status_Type == "Product"
                    select s;

            foreach (var s in q)
            {
                cmb.Items.Add(s.Description);
            }
        }

        public void LoadDataToCmbBoxLevel(ComboBox cmb)
        {
            for (int i =1; i<6; i++)
            {
                cmb.Items.Add(i.ToString());
            }
        }

        public void LoadDataToCmbBoxSupplier(ComboBox cmb)
        {
            var q = (from s in dbContext.Suppliers
                    select s.Supplier_Name).Distinct();

            foreach (var s in q)
            {
                cmb.Items.Add(s);
            }
        }
    }
}
