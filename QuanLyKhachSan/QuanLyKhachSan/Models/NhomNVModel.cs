using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.Models;
namespace QuanLyKhachSan
{
    public class NhomNVModel
    {
        Context db = new Context();
        
        public List<NhomNV> FindAll()
        {
            return db.NhomNVs.ToList();
        }
        // hàm xóa
        public void delete(NhomNV nhom)
        {
            NhomNV ph = db.NhomNVs.Find(nhom.NhomNVId);
        //    ph.Phones.ToList().ForEach(phone => db.Phones.Remove(phone));
            db.NhomNVs.Remove(ph);
            db.SaveChanges();
        }
        //hàm thêm
        public void insert(NhomNV nhom)
        {
            NhomNV ph = new NhomNV();
            ph.TenNhom = nhom.TenNhom;
            ph.CongViecId = nhom.CongViecId;
            ph.TrNhomId = nhom.TrNhomId;
            db.NhomNVs.Add(ph);
            db.SaveChanges();
        }
        //ham sửa
        public void Update(NhomNV nhom)
        {
            NhomNV ph = db.NhomNVs.SingleOrDefault(x => x.NhomNVId == nhom.NhomNVId);
            ph.TenNhom = nhom.TenNhom;
            ph.CongViecId = nhom.CongViecId;
            ph.TrNhomId = nhom.TrNhomId;
            db.SaveChanges();
        }
    }
}
