using QuanLyKhachSan.Models;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;

namespace QuanLyKhachSan.Maps
{
    public class ThongTinDVMap : EntityTypeConfiguration<ThongTinDV>
    {
        public ThongTinDVMap()
        {
            HasKey(tt => new { tt.DichVuId, tt.CongViecId });
            HasRequired(tt => tt.congViec)
                .WithMany(cv => (ICollection<ThongTinDV>)cv.dichVus)
                .HasForeignKey(tt => tt.CongViecId);
            HasRequired(tt => tt.dichVu)
                .WithMany(dv => (ICollection<ThongTinDV>)dv.congViecs)
                .HasForeignKey(tt => tt.DichVuId);
        }
    }
}
