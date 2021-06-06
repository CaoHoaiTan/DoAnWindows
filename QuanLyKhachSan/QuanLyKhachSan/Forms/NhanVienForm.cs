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
    public partial class NhanVienForm : DevExpress.XtraEditors.XtraForm
    {
        Context db = new Context();
        public NhanVienForm()
        {
            InitializeComponent();
        }
        private void NhanVienForm_Load(object sender, EventArgs e)
        {
            nhanVienBindingSource.DataSource = new NhanVienModel().FindAll();
            nhomNVBindingSource.DataSource = new NhomNVModel().FindAll();
            //
            this.txtNhanVienId.Enabled = false;
            // Không cho thao tác nút Lưu
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            // Cho thao tác nút Thêm, Xóa, Cập nhật
            this.btnUpdate.Enabled = true;
            this.btnInsert.Enabled = true;
            this.btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Xóa
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //Khởi tạo đối tượng nhân viên
                NhanVien nv = new NhanVien();
                //lấy mã nhân viên từ gridView1 của devexpress, lưu ý các bạn nhớ viết name của trường cần lấy phải đúng như
                //trong csdl nhé
                nv.NhanVienId = int.Parse(txtNhanVienId.Text);
                //thực hiện hàm xóa
                new NhanVienModel().delete(nv);
                MessageBox.Show("Thành Công");
                //grcNhanVien.RefreshDataSource();
                NhanVienForm_Load(sender, e);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.TenNV = txtTenNV.Text;
            nv.DiaChi = txtDiaChi.Text;
            if (cmbNhomNVId.SelectedValue != null) 
                nv.NhomNVId = int.Parse(cmbNhomNVId.SelectedValue.ToString());
            nv.NgaySinh = DateTime.Parse(TimeNgaySinh.Text);
            // IsActive
            nv.IsActive = true;
            new NhanVienModel().insert(nv);
            MessageBox.Show("Thành Công");
            NhanVienForm_Load(sender, e);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng lưu thay đổi
            NhanVien nv = new NhanVien();
            nv.NhanVienId = int.Parse(txtNhanVienId.Text);
            nv.TenNV = txtTenNV.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.NgaySinh = TimeNgaySinh.Value;
            nv.IsActive = chkActive.Checked;
            if (cmbNhomNVId.SelectedValue != null)
                nv.NhomNVId = int.Parse(cmbNhomNVId.SelectedValue.ToString());
            // Update
            new NhanVienModel().Update(nv);
            MessageBox.Show("Thành Công");
            NhanVienForm_Load(sender, e);
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            nhanVienBindingSource.Add(new NhanVien());  // Tạo đối tượng nhân viên mới
            nhanVienBindingSource.MoveLast();           // Chuyển đối tượng đến cuối
            txtTenNV.Focus();                           // Chuyển con trỏ đến tên đối tượng mới tạo
            // Cho thao tác nút Lưu
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            // Không cho thao tác nút Thêm, Cập nhật, Xóa
            this.btnInsert.Enabled = false;
            this.btnUpdate.Enabled = false;
            this.btnDelete.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            NhanVienForm_Load(sender, e);
        }
    }
}