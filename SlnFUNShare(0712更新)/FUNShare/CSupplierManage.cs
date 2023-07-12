using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace FUNShare.Models
{
    internal class CSupplierManage
    {
        FUNShareEntities dbcontext = new FUNShareEntities();//連機DB
        //FUNShareEntities1 dbcontext = new FUNShareEntities1();//本地DB
        internal void Loadcitydata(ComboBox cmb)//載入城市資料
        {
            var q = from c in dbcontext.Cities
                    select c;
            foreach (var cit in q)
            {
                cmb.Items.Add(cit.City_Name);
            }
            
        }
        public string MyGroup(Product item)//產品分群
        {
            if (item.UnitPrice > 5000)
                return "高價商品";
           else if (item.UnitPrice < 5000 && item.UnitPrice > 1000)
                return "中價商品";
            else return "低價商品";
        }

    }
}
