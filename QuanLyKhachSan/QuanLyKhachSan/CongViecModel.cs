using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.Models;
namespace QuanLyKhachSan
{
    public class CongViecModel
    {
        Context db = new Context();

        public List<CongViec> FindAll()
        {
            return db.congViecs.ToList();
        }
        // hàm xóa
        public void delete(CongViec cv)
        {
            CongViec ph = db.congViecs.Find(cv.CongViecId);
            db.congViecs.Remove(ph);
            db.SaveChanges();
        }
        //hàm thêm
        public void insert(CongViec cv)
        {
            CongViec p = new CongViec();
            p.TenCV = cv.TenCV;
            db.congViecs.Add(p);
            db.SaveChanges();
        }
        //ham sửa
        public void Update(CongViec cv)
        {
            CongViec p = db.congViecs.SingleOrDefault(x => x.CongViecId == cv.CongViecId);
            p.CongViecId = cv.CongViecId;
            p.TenCV = cv.TenCV;
            db.SaveChanges();
        }
    }
}
