using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Models
{
    public class NhomNV
    {
        public int NhomNVId { get; set; }
        public virtual NhanVien nhanVien { get; set; }
        public string TenNhom { get; set; }
        public int? TrNhomId { get; set; }
        public virtual CongViec congViec { get; set; }
        public int? CongViecId { get; set; }
        public ICollection<NhanVien> nhanViens { get; set; }
    }
}
