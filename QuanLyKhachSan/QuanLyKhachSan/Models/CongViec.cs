using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Models
{
    public class CongViec
    {
        public int CongViecId { get; set; }
        public string TenCV { get; set; }
        public ICollection<DichVu> dichVus { get; set; }
        public ICollection<NhomNV> NhomNVs { get; set; }
    }
}
