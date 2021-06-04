using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Models
{
    public class ThongTinDV
    {
        public virtual DichVu dichVu { get; set; }
        public int DichVuId { get; set; }
        public virtual CongViec congViec { get; set; }
        public int CongViecId { get; set; }
    }
}
