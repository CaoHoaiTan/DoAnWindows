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
        private new void DataBindings()
        {
            grcCongViec.DataSource = new CongViecModel().FindAll();
            
           
            this.btnInsert.Enabled = true;
            this.btnSave.Enabled = false;
        }

        private void repositoryDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //khởi tạo đối tượng nhân viên
                CongViec cv = new CongViec();
                //lấy mã nhân viên từ gridView1 của devexpress, lưu ý các bạn nhớ viết name của trường cần lấy phải đúng như
                //trong csdl nhé
                cv.CongViecId =
                int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CongViecId").ToString());
                //thực hienj hàm xóa
                new CongViecModel().delete(cv);
                MessageBox.Show("Thành Công");
                grcCongViec.RefreshDataSource();
                DataBindings();
            }
            }

        private void repositoryUpdate_Click(object sender, EventArgs e)
        {
            //Update
            CongViec cv = new CongViec();
            // nv.NhanVienId = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NhanVienId").ToString());
            cv.TenCV = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenCV").ToString();
           //
            new CongViecModel().Update(cv);
            MessageBox.Show("Thành Công");
            grcCongViec.RefreshDataSource();
            DataBindings();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //
            txtCVId.Enabled = false;
            txtTenCV.Text = "";
            //cmbNhomNVId.Text = "";
            //
            txtTenCV.Focus();
            this.btnInsert.Enabled = false;
            this.btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CongViec cv = new CongViec();
            cv.TenCV = txtTenCV.Text;
            new CongViecModel().insert(cv);
            MessageBox.Show("Thành Công");
            grcCongViec.RefreshDataSource();
            DataBindings();
        }

        private void CongViecForm_Load(object sender, EventArgs e)
        {
            DataBindings();
        }
    }
}