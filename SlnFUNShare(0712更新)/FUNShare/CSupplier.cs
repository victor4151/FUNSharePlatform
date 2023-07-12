using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNShare.Models
{
    internal class CSupplier
    {
        public int Supplier_ID { get; set; }
        public string 統一編號 { get; set; }
        public string 供應商名稱 { get; set; }
        public int 連絡電話 { get; set; }
        public string Email { get; set; }
        public string 城市名稱 { get; set; }
        public Image 產品圖片 { get; set; }
        public string 傳真 { get; set; }
        public string 密碼 { get; set; }
        public string 聯絡人 { get; set; }
        public Image 供應商Logo { get; set; }
        public string 備註 { get; set; }
        public string 狀態 { get; set; }
        public string 供應商地址{ get; set; }

    }
}
