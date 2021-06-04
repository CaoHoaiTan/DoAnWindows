using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Models
{
    public class NhanVien
    {
        public NhanVien()
        {
            Phones = new HashSet<Phone>();
            //Companies = new HashSet<Company>();
        }

        public int NhanVienId { get; set; }
        public virtual NhomNV NhomNV { get; set; }
        public string TenNV { get; set; }
        public string DiaChi { get; set; }
        public DateTime? NgaySinh { get; set; }
        public bool IsActive { get; set; }
        public int? NhomNVId { get; set; }
        public virtual ICollection<Phone> Phones { get; set; }
        //public virtual ICollection<Company> Companies { get; set; }

    }
}

