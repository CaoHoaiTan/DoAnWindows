using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using QuanLyKhachSan.Models;
namespace QuanLyKhachSan.Maps
{
    public class NhanVienMap : EntityTypeConfiguration<NhanVien>
    {
        public NhanVienMap()
        {
            Property(p => p.TenNV)
                .HasMaxLength(50)
                .IsRequired()
                .IsUnicode(true);
            Property(p => p.DiaChi)
                .HasMaxLength(100)
                .IsUnicode(true);
            Property(p => p.NgaySinh)
                .HasPrecision(10);
            HasMany(p => p.Phones)
                .WithRequired()
                .HasForeignKey(ph => ph.NhanVienId);

        }
    }
}
