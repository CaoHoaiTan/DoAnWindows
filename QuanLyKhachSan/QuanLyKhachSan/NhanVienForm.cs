﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan
{
    public partial class NhanVienForm : DevExpress.XtraEditors.XtraForm
    {
        Context db = new Context();
        public NhanVienForm()
        {
            InitializeComponent();
        }
        private new void DataBindings()
        {
            gridControl1.DataSource = new NhanVienModel().FindAll();
            //
            txtNhanVienId.DataBindings.Add("Text", db.nhanViens.ToList(), "NhanVienId");
            txtTenNV.DataBindings.Add("Text", db.nhanViens.ToList(), "TenNV");
            txtDiaChi.DataBindings.Add("Text", db.nhanViens.ToList(), "DiaChi");
            TimeNgaySinh.DataBindings.Add("Text", db.nhanViens.ToList(), "NgaySinh");
            checkBox1.DataBindings.Add("Text", db.nhanViens.ToList(), "IsActive");
            txtNhomNVId.DataBindings.Add("Text", db.nhanViens.ToList(), "NhomNVId");
        }
        private void NhanVienForm_Load(object sender, EventArgs e)
        {
            DataBindings();
            //gridControl1.DataSource = new NhanVienModel().FindAll();
            ////
            //txtNhanVienId.DataBindings.Add("Text",db.nhanViens.ToList(),"NhanVienId");
            //txtTenNV.DataBindings.Add("Text", db.nhanViens.ToList(), "TenNV");
            //txtDiaChi.DataBindings.Add("Text", db.nhanViens.ToList(), "DiaChi");
            //TimeNgaySinh.DataBindings.Add("Text", db.nhanViens.ToList(), "NgaySinh");
            //checkBox1.DataBindings.Add("Text", db.nhanViens.ToList(), "IsActive");
            //txtNhomNVId.DataBindings.Add("Text", db.nhanViens.ToList(), "NhomNVId");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //
            txtNhanVienId.Enabled = false;
            txtTenNV.Text = "";
            txtDiaChi.Text = "";
            txtNhomNVId.Text = "";
            //
            txtTenNV.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.TenNV = txtTenNV.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.NhomNVId = int.Parse(txtNhomNVId.Text);
            nv.NgaySinh = DateTime.Parse(TimeNgaySinh.Text);
            // IsActive
            nv.IsActive = true;
            new NhanVienModel().insert(nv);
            MessageBox.Show("Thành Công");
            gridControl1.RefreshDataSource();
            NhanVienForm_Load(sender, e);
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            //Xoa
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //khởi tạo đối tượng nhân viên
                NhanVien nv = new NhanVien();
                //lấy mã nhân viên từ gridView1 của devexpress, lưu ý các bạn nhớ viết name của trường cần lấy phải đúng như
                //trong csdl nhé
                nv.NhanVienId =
                int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NhanVienId").ToString());
                //thực hienj hàm xóa
                new NhanVienModel().delete(nv);
                MessageBox.Show("Thành Công");
                gridControl1.RefreshDataSource();
                NhanVienForm_Load(sender, e);
            }
        }

        private void repositoryItemButtonEdit2_Click(object sender, EventArgs e)
        {
            //Update
            NhanVien nv = new NhanVien();
            nv.NhanVienId = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NhanVienId").ToString());
            nv.TenNV = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenNV").ToString();
            nv.DiaChi = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DiaChi").ToString();
            nv.NgaySinh = DateTime.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NgaySinh").ToString());
            nv.IsActive = bool.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "IsActive").ToString());
            nv.NhomNVId = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NhomNVId").ToString());
            //
            new NhanVienModel().Update(nv);
            MessageBox.Show("Thành Công");
            gridControl1.RefreshDataSource();
            NhanVienForm_Load(sender, e);
        }
    }
}