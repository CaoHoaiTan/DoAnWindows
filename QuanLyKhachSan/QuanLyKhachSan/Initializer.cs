using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using QuanLyKhachSan.Models;
using QuanLyKhachSan.Maps;

namespace QuanLyKhachSan
{
    public class Initializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            //Cong Viec
            var work1 = context.congViecs.Add(new CongViec { TenCV = "Nau An" });
            var work2 = context.congViecs.Add(new CongViec { TenCV = "Tiep don" });
            var work3 = context.congViecs.Add(new CongViec { TenCV = "Bao Ve" });
            // NhomNV
            var group1 = context.NhomNVs.Add(new NhomNV { TenNhom = "Le Tan", congViec =work2 });
            var group2 = context.NhomNVs.Add(new NhomNV { TenNhom = "Ve Sinh", congViec = work2 });
            var group3 = context.NhomNVs.Add(new NhomNV { TenNhom = "Cham soc",  congViec = work3 });
            var group4 = context.NhomNVs.Add(new NhomNV { TenNhom = "Dau bep",  congViec = work1 });
            var group5 = context.NhomNVs.Add(new NhomNV { TenNhom = "Phu Vu", congViec = work1 });
            //NhanVien
            var nv1 = new NhanVien
            {
                TenNV = "Tan dep Trai",
                NgaySinh = new DateTime(2001, 9, 2),
                IsActive = true,
                DiaChi = "Quan 9",
                NhomNV = group1
            };
            context.nhanViens.Add(nv1);
            nv1.Phones.Add(new Phone { PhoneNumber = "0789456123" });
            nv1.Phones.Add(new Phone { PhoneNumber = "0784512369" });

            //
            var nv2 = context.nhanViens.Add(new NhanVien
            {
                TenNV = "Nam",
                NgaySinh = new DateTime(2001, 5, 28),
                IsActive = true,
                DiaChi = "Thu Duc",
                NhomNV = group1
            });
            context.nhanViens.Add(nv2);
            nv2.Phones.Add(new Phone { PhoneNumber = "0457213988" });
            nv2.Phones.Add(new Phone { PhoneNumber = "0124785639" });
         

            var nv3 = context.nhanViens.Add(new NhanVien
            {
                TenNV = "Trung",
                NgaySinh = new DateTime(2001, 10, 23),
                IsActive = true,
                DiaChi = "Thu Duc",
                NhomNV = group2

            });
            context.nhanViens.Add(nv3);
            nv3.Phones.Add(new Phone { PhoneNumber = "0417852369" });
            nv3.Phones.Add(new Phone { PhoneNumber = "0423156789" });
            var nv4 = context.nhanViens.Add(new NhanVien
            {
                TenNV = "Tan Dep Trai",
                NgaySinh = new DateTime(2001, 12, 5),
                IsActive = true,
                DiaChi = "Thu Duc",
                NhomNV = group2

            });
            context.nhanViens.Add(nv4);
            nv3.Phones.Add(new Phone { PhoneNumber = "0123457896" });
            nv3.Phones.Add(new Phone { PhoneNumber = "0423156789" });

            context.SaveChanges();
        }
    }
}
