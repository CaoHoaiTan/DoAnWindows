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

        private void NhomNVForm_Load(object sender, EventArgs e)
        {
            // grcNhomNV.DataSource = new NhomNVModel().FindAll();
            nhomNVBindingSource.DataSource = new NhomNVModel().FindAll();
            congViecBindingSource.DataSource = new CongViecModel().FindAll();
            nhanVienBindingSource.DataSource = new NhanVienModel().FindAll();

            txtNhomNVId.Enabled = false;
            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            //
            btnCancel.Enabled = false;
            btnSave.Enabled = false;

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
          
            nhomNVBindingSource.Add(new NhomNV());
            nhomNVBindingSource.MoveLast();           
            txtTenNhom.Focus();
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            //
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NhomNV nv = new NhomNV();
            nv.TenNhom = txtTenNhom.Text;
            if (cmbTrNhomId.SelectedValue != null)
                nv.TrNhomId = int.Parse(cmbTrNhomId.SelectedValue.ToString());
            if (cmbCVId.SelectedValue != null)
                nv.CongViecId = int.Parse(cmbCVId.SelectedValue.ToString());
    
            new NhomNVModel().insert(nv);
            MessageBox.Show("Thành Công");
            //grcNhomNV.RefreshDataSource();
            NhomNVForm_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Delete
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //khởi tạo đối tượng nhân viên
                NhomNV nv = new NhomNV();
                //lấy mã nhân viên từ gridView1 của devexpress, lưu ý các bạn nhớ viết name của trường cần lấy phải đúng như
                //trong csdl nhé
                nv.NhomNVId = int.Parse(txtNhomNVId.Text);             
                //thực hienj hàm xóa
                new NhomNVModel().delete(nv);
                MessageBox.Show("Thành Công");
                //grcNhomNV.RefreshDataSource();
                NhomNVForm_Load(sender, e);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Update
            NhomNV nv = new NhomNV();
            nv.NhomNVId = int.Parse(txtNhomNVId.Text);
            nv.TenNhom = txtTenNhom.Text;
            if (cmbTrNhomId.SelectedValue != null)
                nv.TrNhomId = int.Parse(cmbTrNhomId.SelectedValue.ToString());
            if (cmbCVId.SelectedValue != null)
                nv.CongViecId = int.Parse(cmbCVId.SelectedValue.ToString());
            //
            new NhomNVModel().Update(nv);
            MessageBox.Show("Thành Công");
            // grcNhomNV.RefreshDataSource();
            NhomNVForm_Load(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            NhomNVForm_Load(sender, e);
        }
    }
}