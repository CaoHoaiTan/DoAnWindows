using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Models
{
    public class ThongTinDichVuModel
    {
        Context db = new Context();
        public List<ThongTinDV> FindAll()
        {
            return db.ttDVs.ToList();
        }
        public void delete(ThongTinDV ttdv)
        {
            db.ttDVs.Remove(ttdv);
            db.SaveChanges();
        }
        public void insert(ThongTinDV ttdv)
        {           
            db.ttDVs.Add(ttdv);
            db.SaveChanges();
        }
    }
}
