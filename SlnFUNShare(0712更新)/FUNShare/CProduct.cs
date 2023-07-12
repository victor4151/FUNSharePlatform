using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNShare.Models
{
    internal class CProduct
    {
        public int ProductID { get; set; }
        public string 產品名稱 { get; set; }
        public string 產品介紹 { get; set; }
        public string 供應商 { get;set; }
        public string 次類別 { get; set; }
        public string 分齡 { get; set; }
        public int? 難易度 { get; set; }
        public string 類型 { get; set; }
        public int? 堂數 { get; set; }
        public string 上課頻率 { get; set; }

        public decimal? _單價;

        public string 單價
        {
            get
            {
                return $"{_單價:c0}";
            }
            set
            {
                value = _單價.ToString();
            }
        }
        public int? 名額 { get; set; }
        public DateTime? 報名截止日期 { get; set; }
        public DateTime? 上架日期 { get; set; }
        public double? 傭金 { get; set; }
        public string 狀態 { get; set; }
        public string 備註 { get; set; }
        public byte[] 圖片 { get; set; }
    }
}
