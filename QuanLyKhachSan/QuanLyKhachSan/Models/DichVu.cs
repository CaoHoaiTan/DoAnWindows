using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Models
{
    public class DichVu
    {
        public int DichVuId { get; set; }
        public string TenDV { get; set; }
        public string GiaTien { get; set; }
        public ICollection<CongViec> congViecs { get; set; }
    }
}
