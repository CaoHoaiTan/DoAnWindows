using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data.ODataLinq.Helpers;
using DevExpress.Data.WcfLinq.Helpers;
using QuanLyKhachSan.Models;
namespace QuanLyKhachSan
{
    public class NhanVienModel
    {
        Context db = new Context();
        
        public List<NhanVien> FindAll()
        {
            return db.nhanViens.ToList();
        }
        public List<NhanVien> FindTV(int IdNhom) // Lọc thành viên nhóm
        {
            return db.nhanViens.Where(x => x.NhomNVId == IdNhom).ToList();
        }
        // hàm xóa
        public void delete(NhanVien nv)
        {
            NhanVien ph = db.nhanViens.Find(nv.NhanVienId);
            ph.Phones.ToList().ForEach(phone => db.Phones.Remove(phone));
            db.nhanViens.Remove(ph);
            db.SaveChanges();
        }
        //hàm thêm
        public void insert(NhanVien nv)
        {
            NhanVien p = new NhanVien();
            p.TenNV = nv.TenNV;
            p.DiaChi = nv.DiaChi;
            p.IsActive = nv.IsActive;
            p.NhomNVId = nv.NhomNVId;
            p.NgaySinh = nv.NgaySinh;
            db.nhanViens.Add(p);
            db.SaveChanges();
        }
        //ham sửa
        public void Update(NhanVien nv)
        {
            NhanVien p = db.nhanViens.SingleOrDefault(x => x.NhanVienId == nv.NhanVienId);
            p.NhanVienId = nv.NhanVienId;
            p.TenNV = nv.TenNV;
            p.DiaChi = nv.DiaChi;
            p.NgaySinh = nv.NgaySinh;
            p.IsActive = nv.IsActive;
            p.NhomNVId = nv.NhomNVId;
            db.SaveChanges();
        }


    }
}
