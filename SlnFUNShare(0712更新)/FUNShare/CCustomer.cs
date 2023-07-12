using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNShare.Models
{
    internal class CCustomer
    {
        public int 會員編號 { get; set; }
        public string 身分證字號 { get; set; }
        public int? 家長會員編號 { get; set; }
        public string 會員姓名 { get; set; }
        public string 性別 { get; set; }
        public string 手機號碼 { get; set; }
        public string 電子信箱 { get; set; }
        public int? 行政區編號 { get; set; }
        public string 住址 { get; set; }
        public DateTime 生日 { get; set; }
        public string 暱稱 { get; set; }
        public string 密碼 { get; set; }
        public bool 是否過敏 { get; set; }
        public string 過敏病徵描述 { get; set; }
        public string 備註 { get; set; }
        public int 狀態編號{ get; set; }
        public byte[] 會員照片 { get; set; }
    }
}
