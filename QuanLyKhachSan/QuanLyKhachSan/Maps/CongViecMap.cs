using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using QuanLyKhachSan.Models;
namespace QuanLyKhachSan.Maps
{
    public class CongViecMap: EntityTypeConfiguration<CongViec>
    {
        public CongViecMap()
        {
            Property(p => p.TenCV)
               .HasMaxLength(100)
               .IsRequired()
               .IsUnicode(true);

            HasMany(pt => pt.NhomNVs)
                .WithOptional(p => p.congViec)
                .HasForeignKey(p => p.CongViecId)
                .WillCascadeOnDelete(false);
        }
    }
}
