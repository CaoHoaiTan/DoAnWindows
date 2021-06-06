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
    public partial class CongViecForm : DevExpress.XtraEditors.XtraForm
    {
        Context db = new Context();
        public CongViecForm()
        {
            InitializeComponent();
        }
   
        private void btnInsert_Click(object sender, EventArgs e)
        {
            congViecBindingSource.Add(new CongViec());
            congViecBindingSource.MoveLast();
           //
            txtTenCV.Focus();
            // Cho thao tác nút Lưu
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            // Không cho thao tác nút Thêm, Cập nhật, Xóa
            this.btnInsert.Enabled = false;
            this.btnUpdate.Enabled = false;
            this.btnDelete.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CongViec cv = new CongViec();
            cv.TenCV = txtTenCV.Text;
            new CongViecModel().insert(cv);
            MessageBox.Show("Thành Công");
            // grcCongViec.RefreshDataSource();
            //
            CongViecForm_Load(sender, e);
        }

        private void CongViecForm_Load(object sender, EventArgs e)
        {
            congViecBindingSource.DataSource = new CongViecModel().FindAll();
            //
            txtCVId.Enabled = false;
            //
            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            //
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //khởi tạo đối tượng nhân viên
                CongViec cv = new CongViec();
                //lấy mã nhân viên từ gridView1 của devexpress, lưu ý các bạn nhớ viết name của trường cần lấy phải đúng như
                //trong csdl nhé
                cv.CongViecId = int.Parse(txtCVId.Text);
               //thực hienj hàm xóa
                new CongViecModel().delete(cv);
                MessageBox.Show("Thành Công");
                // grcCongViec.RefreshDataSource();
                CongViecForm_Load(sender, e);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Update
            CongViec cv = new CongViec();
            cv.CongViecId = int.Parse(txtCVId.Text);
            cv.TenCV = txtTenCV.Text;
            //
            new CongViecModel().Update(cv);
            MessageBox.Show("Thành Công");
            // grcCongViec.RefreshDataSource();
            CongViecForm_Load(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CongViecForm_Load(sender, e);
        }
    }
}