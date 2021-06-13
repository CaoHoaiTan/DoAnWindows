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
            //DichVu
            var dv1 = context.dichVus.Add(new DichVu { TenDV = "Don dep phong", GiaTien ="50000" });
            var dv2 = context.dichVus.Add(new DichVu { TenDV = "Xe dua don", GiaTien = "150000" });
            var dv3 = context.dichVus.Add(new DichVu { TenDV = "Nha hang", GiaTien = "500000" });
            var dv4 = context.dichVus.Add(new DichVu { TenDV = "Spa", GiaTien = "250000" });
            var dv5 = context.dichVus.Add(new DichVu { TenDV = "Fitness center", GiaTien = "100000" });
            //Cong Viec
            var work1 = context.congViecs.Add(new CongViec { TenCV = "Nau An" });
            var work2 = context.congViecs.Add(new CongViec { TenCV = "Tiep don" });
            var work3 = context.congViecs.Add(new CongViec { TenCV = "Bao Ve" });
            var work4 = context.congViecs.Add(new CongViec { TenCV = "Ve sinh" });
            var work5 = context.congViecs.Add(new CongViec { TenCV = "Sua chua" });
            var work6 = context.congViecs.Add(new CongViec { TenCV = "Thu ngan" });
            // NhomNV
            var group1 = context.NhomNVs.Add(new NhomNV { TenNhom = "Le Tan", congViec =work2 });
            var group2 = context.NhomNVs.Add(new NhomNV { TenNhom = "An ninh", congViec = work3 });
            var group3 = context.NhomNVs.Add(new NhomNV { TenNhom = "Cham soc",  congViec = work4 });
            var group4 = context.NhomNVs.Add(new NhomNV { TenNhom = "Dau bep",  congViec = work1 });
            var group5 = context.NhomNVs.Add(new NhomNV { TenNhom = "Ki thuat", congViec = work5 });
            var group6 = context.NhomNVs.Add(new NhomNV { TenNhom = "Ke toan", congViec = work6 });
            //NhanVien
            var nv1 = new NhanVien
            {
                TenNV = "Cao Hoai Tan",
                NgaySinh = new DateTime(2001, 9, 2),
                IsActive = true,
                DiaChi = "Quan 9",
                NhomNV = group1
            };
            context.nhanViens.Add(nv1);
            nv1.Phones.Add(new Phone { PhoneNumber = "0789456123" });
            nv1.Phones.Add(new Phone { PhoneNumber = "0784512369" });

            //
            var nv2 = new NhanVien
            {
                TenNV = "Thai Thanh Nam",
                NgaySinh = new DateTime(2001, 5, 28),
                IsActive = true,
                DiaChi = "Thu Duc",
                NhomNV = group1
            };
            context.nhanViens.Add(nv2);
            nv2.Phones.Add(new Phone { PhoneNumber = "0457213988" });
            nv2.Phones.Add(new Phone { PhoneNumber = "0124785639" });
         

            var nv3 = new NhanVien
            {
                TenNV = "Nguyen Ngoc Trung",
                NgaySinh = new DateTime(2001, 10, 23),
                IsActive = true,
                DiaChi = "Thu Duc",
                NhomNV = group2

            };
            context.nhanViens.Add(nv3);
            nv3.Phones.Add(new Phone { PhoneNumber = "0417852369" });
            nv3.Phones.Add(new Phone { PhoneNumber = "0423156789" });
            var nv4 = new NhanVien
            {
                TenNV = "Trinh Xuan Phuong",
                NgaySinh = new DateTime(2001, 12, 5),
                IsActive = true,
                DiaChi = "Thu Duc",
                NhomNV = group3

            };
            context.nhanViens.Add(nv4);
            nv4.Phones.Add(new Phone { PhoneNumber = "0123457896" });
            nv4.Phones.Add(new Phone { PhoneNumber = "0451257789" });
            var nv5 = new NhanVien
            {
                TenNV = "Truong Ngoc Phuong",
                NgaySinh = new DateTime(2001, 12, 27),
                IsActive = true,
                DiaChi = "An Giang",
                NhomNV = group3

            };
            context.nhanViens.Add(nv5);
            nv5.Phones.Add(new Phone { PhoneNumber = "0141523896" });
            nv5.Phones.Add(new Phone { PhoneNumber = "0412543789" });
            var nv6 = new NhanVien
            {
                TenNV = "Tran Luu The Anh",
                NgaySinh = new DateTime(2001, 9, 5),
                IsActive = true,
                DiaChi = "Quang Nam",
                NhomNV = group4

            };
            context.nhanViens.Add(nv6);
            nv6.Phones.Add(new Phone { PhoneNumber = "0124157896" });
            nv6.Phones.Add(new Phone { PhoneNumber = "0441526789" });
            var nv7 = new NhanVien
            {
                TenNV = "Phan Nguyen Chu Kiet",
                NgaySinh = new DateTime(2001, 12, 27),
                IsActive = true,
                DiaChi = "Quang Nam",
                NhomNV = group4

            };
            context.nhanViens.Add(nv7);
            nv7.Phones.Add(new Phone { PhoneNumber = "0147485361" });
            nv7.Phones.Add(new Phone { PhoneNumber = "0414523689" });
            //
            var nv8 = new NhanVien
            {
                TenNV = "Nguyen Thi Nhung",
                NgaySinh = new DateTime(2001, 10, 23),
                IsActive = true,
                DiaChi = "Thanh Hoa",
                NhomNV = group5

            };
            context.nhanViens.Add(nv8);
            nv8.Phones.Add(new Phone { PhoneNumber = "0145232369" });
            nv8.Phones.Add(new Phone { PhoneNumber = "0475136789" });
            var nv9 = new NhanVien
            {
                TenNV = "Tran Thi My Huyen",
                NgaySinh = new DateTime(2001, 4, 5),
                IsActive = true,
                DiaChi = "Gia Lai",
                NhomNV = group5

            };
            context.nhanViens.Add(nv9);
            nv9.Phones.Add(new Phone { PhoneNumber = "0745269896" });
            nv9.Phones.Add(new Phone { PhoneNumber = "0142367789" });
            var nv10 = new NhanVien
            {
                TenNV = "Le Hieu",
                NgaySinh = new DateTime(2001, 7, 7),
                IsActive = true,
                DiaChi = "Binh Dinh",
                NhomNV = group6

            };
            context.nhanViens.Add(nv10);
            nv10.Phones.Add(new Phone { PhoneNumber = "0412536946" });
            nv10.Phones.Add(new Phone { PhoneNumber = "0745896389" });
            var nv11 = new NhanVien
            {
                TenNV = "Le Vuong",
                NgaySinh = new DateTime(2001, 5, 5),
                IsActive = true,
                DiaChi = "Binh Dinh",
                NhomNV = group6

            };
            context.nhanViens.Add(nv6);
            nv11.Phones.Add(new Phone { PhoneNumber = "0124152896" });
            nv11.Phones.Add(new Phone { PhoneNumber = "0444566789" });
            var nv12 = new NhanVien
            {
                TenNV = "Tran Trung",
                NgaySinh = new DateTime(2001, 12, 12),
                IsActive = true,
                DiaChi = "Phu Yen",
                NhomNV = group2

            };
            context.nhanViens.Add(nv12);
            nv12.Phones.Add(new Phone { PhoneNumber = "0141285361" });
            nv12.Phones.Add(new Phone { PhoneNumber = "0315423689" });
            context.SaveChanges();
        }
    }
}
