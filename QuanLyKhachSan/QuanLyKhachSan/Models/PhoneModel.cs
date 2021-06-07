using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data.ODataLinq.Helpers;
using DevExpress.Data.WcfLinq.Helpers;
using QuanLyKhachSan.Models;
namespace QuanLyKhachSan.Models
{
    public class PhoneModel
    {
        Context db = new Context();
        public List<Phone> FindAll()
        {
            return db.Phones.ToList();

        }
        //Ham xoa
        public void Delete(Phone p)
        {
            Phone ph = db.Phones.Find(p.PhoneId);
            db.Phones.Remove(ph);
            db.SaveChanges();
        }
        //Ham them
        public void Insert(Phone p)
        {
            db.Phones.Add(p);
            db.SaveChanges();
        }
        //Ham Update
        public void Update(Phone p)
        {
            Phone ph = db.Phones.SingleOrDefault(x => x.PhoneId == p.PhoneId);
            ph.PhoneId = p.PhoneId;
            ph.PhoneNumber = p.PhoneNumber;
            ph.NhanVienId = p.NhanVienId;
            db.SaveChanges();
        }

    }
}
