using DevExpress.XtraEditors;
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
    public partial class NhomNVForm : DevExpress.XtraEditors.XtraForm
    {
        Context db = new Context();
        public NhomNVForm()
        {
            InitializeComponent();
        }
        private new void DataBindings()
        {
            grcNhomNV.DataSource = new NhomNVModel().FindAll();
            //
            this.cmbCVId.DataSource = db.congViecs.ToList();
            this.cmbCVId.DisplayMember = "TenCV";
            this.cmbCVId.ValueMember = "CongViecId";

            //combo box trNhomid
            this.cmbTrNhomId.DataSource = db.nhanViens.ToList();
            this.cmbTrNhomId.DisplayMember = "TenNV";
            this.cmbTrNhomId.ValueMember = "NhanVienId";
            //

            
            this.btnInsert.Enabled = true;
            this.btnSave.Enabled = false;
        }

        private void NhomNVForm_Load(object sender, EventArgs e)
        {
            //DataBindings();
            nhomNVBindingSource.DataSource = new NhomNVModel().FindAll();
            congViecBindingSource.DataSource = new CongViecModel().FindAll();
            nhanVienBindingSource.DataSource = new NhanVienModel().FindAll();
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            // Delete
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //khởi tạo đối tượng nhân viên
                NhomNV nv = new NhomNV();
                //lấy mã nhân viên từ gridView1 của devexpress, lưu ý các bạn nhớ viết name của trường cần lấy phải đúng như
                //trong csdl nhé
                nv.NhomNVId =
                int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NhomNVId").ToString());
                //thực hienj hàm xóa
                new NhomNVModel().delete(nv);
                MessageBox.Show("Thành Công");
                grcNhomNV.RefreshDataSource();
                DataBindings();
            }
        }

        private void repositoryItemButtonEdit2_Click(object sender, EventArgs e)
        {
            //Update
            NhomNV nv = new NhomNV();
            nv.NhomNVId = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NhomNVId").ToString());
            nv.TenNhom = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenNhom").ToString();
            nv.TrNhomId = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TrNhomId").ToString());
            nv.CongViecId = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CongViecId").ToString());
            //
            new NhomNVModel().Update(nv);
            MessageBox.Show("Thành Công");
            grcNhomNV.RefreshDataSource();
            DataBindings();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //
            txtNhomNVId.Enabled = false;
            txtTenNhom.Text = "";
           
            //cmbNhomNVId.Text = "";
            //
            txtTenNhom.Focus();
            this.btnInsert.Enabled = false;
            this.btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NhomNV nv = new NhomNV();
            nv.TenNhom = txtTenNhom.Text;
            nv.TrNhomId = int.Parse(cmbTrNhomId.SelectedValue.ToString());
            nv.CongViecId = int.Parse(cmbCVId.SelectedValue.ToString());
    
            new NhomNVModel().insert(nv);
            MessageBox.Show("Thành Công");
            grcNhomNV.RefreshDataSource();
            DataBindings();
        }
    }
}