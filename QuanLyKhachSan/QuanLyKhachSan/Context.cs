using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using QuanLyKhachSan.Models;
using QuanLyKhachSan.Maps;
namespace QuanLyKhachSan
{
    public class Context : DbContext
    {
        public Context()
            : base("name=QLKhachSan")
        {

        }
        public DbSet<NhanVien> nhanViens { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<NhomNV> NhomNVs { get; set; }
        public DbSet<CongViec> congViecs { get; set; }
        public DbSet<DichVu> dichVus { get; set; }
        public DbSet<ThongTinDV> ttDVs { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Quan he n-n
            modelBuilder.Entity<DichVu>()
                        .HasMany<CongViec>(s => s.congViecs)
                        .WithMany(c => c.dichVus)
                        .Map(cs =>
                        {
                            cs.MapLeftKey("DichVuId");
                            cs.MapRightKey("CongViecId");
                            cs.ToTable("ThongTinDV");
                        });
            modelBuilder.Configurations.Add(new ThongTinDVMap());
            modelBuilder.Configurations.Add(new NhanVienMap());
            modelBuilder.Configurations.Add(new NhomNVMap());
            modelBuilder.Configurations.Add(new CongViecMap());
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }

    }
}
