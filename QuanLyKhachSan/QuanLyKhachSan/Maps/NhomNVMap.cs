using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using QuanLyKhachSan.Models;
namespace QuanLyKhachSan.Maps
{
    public class NhomNVMap : EntityTypeConfiguration<NhomNV>
    {
        public NhomNVMap()
        {
            Property(p => p.TenNhom)
               .HasMaxLength(100)
               .IsRequired()
               .IsUnicode(true);
            //modelBuilder.Entity<NhomNV>()

            HasOptional(n => n.nhanVien)
                .WithRequired(s => s.NhomNV);

            //1-n
            HasMany(pt => pt.nhanViens)
                .WithOptional(p => p.NhomNV)
                .HasForeignKey(p => p.NhomNVId)
                .WillCascadeOnDelete(false);
            //1-1
            //HasRequired(p => p.nhanVien)
            //    .WithMany()
            //    .HasForeignKey(p => p.TrNhomId);
            //
            HasOptional(p => p.nhanVien)
                .WithMany()
                .HasForeignKey(p => p.TrNhomId);

        }
    }
}
