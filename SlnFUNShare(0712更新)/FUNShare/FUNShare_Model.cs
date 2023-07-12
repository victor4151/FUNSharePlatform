using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNShare.Models
{
    internal class COrder
    {
        //public int OrderID { get; set; }
        //public DateTime OrderDate { get; set; }
        //public string ID { get; set; }
        //public string Name { get; set; }
        //public string ProductName { get; set; }
        //public string Supplier { get; set; }
        //public string Status { get; set; }
        //public int Counts { get; set; }
        public int 訂單編號 { get; set; }  
        public DateTime 訂購時間 { get; set; }
        public string 身分證字號 { get; set; }
        public string 訂購人姓名 { get; set; }
        public string 商品名稱 { get; set; }
        public string 供應商 { get; set; }
        public string 訂單狀態 { get; set; }                            
    }

    internal class ProductList
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal? Price { get; set; }
    }
}
