using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.Models;
namespace QuanLyKhachSan
{
    public class DichVuModel
    {
        Context db = new Context();

        public List<DichVu> FindAll()
        {
            return db.dichVus.ToList();
        }
        // hàm xóa
        public void delete(DichVu dv)
        {
            DichVu ph = db.dichVus.Find(dv.DichVuId);
            db.dichVus.Remove(ph);
            db.SaveChanges();
        }
        //hàm thêm
        public void insert(DichVu dv)
        {
            DichVu p = new DichVu();
            p.TenDV = dv.TenDV;
            p.GiaTien = dv.GiaTien;
            db.dichVus.Add(p);
            db.SaveChanges();
        }
        //ham sửa
        public void Update(DichVu dv)
        {
            DichVu p = db.dichVus.SingleOrDefault(x => x.DichVuId == dv.DichVuId);
            p.DichVuId = dv.DichVuId;
            p.TenDV = dv.TenDV;
            p.GiaTien = dv.GiaTien;
            db.SaveChanges();
        }
    }
}
