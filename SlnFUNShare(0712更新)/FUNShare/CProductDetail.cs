using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUNShare.Models
{
    internal class CProductDetail
    {
        FUNShareEntities dbContext = new FUNShareEntities();
        public int? ProductDetail_ID;
        public DateTime? 課程開始時間 { get; set; }
        public DateTime? 課程結束時間 { get; set; }
        public string 行政區 { get; set; }
        public string 地址 { get; set; }

        public string _開課狀態;

        public string 開課狀態
        {
            get
            {
                return _開課狀態;
            }
            set
            {
                if(dbContext.Status.Where(x => x.Status_Type=="Product_Detail").Any(x =>x.Description == _開課狀態))
                {
                    _開課狀態 = value;
                }
                else
                {
                    MessageBox.Show("查無此開課狀態，請重新輸入");
                }
            }
        }
    }
}
