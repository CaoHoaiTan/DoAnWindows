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
    public partial class DichVuForm : DevExpress.XtraEditors.XtraForm
    {
        Context db = new Context();
        public DichVuForm()
        {
            InitializeComponent();
        }

        private void DichVuForm_Load(object sender, EventArgs e)
        {
            dichVuBindingSource.DataSource = new DichVuModel().FindAll();
            txtDvId.Enabled = false;
            //
            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            //
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            txtDvId.Enabled = false;
            dichVuBindingSource.Add(new DichVu());
            dichVuBindingSource.MoveLast();
            txtTenDV.Focus();

            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            //
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DichVu dv = new DichVu();
            dv.TenDV = txtTenDV.Text;
            dv.GiaTien = txtGiaTien.Text;
            new DichVuModel().insert(dv);
            MessageBox.Show("Thành Công");
            //grcDichVu.RefreshDataSource();
            DichVuForm_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //khởi tạo đối tượng nhân viên
                DichVu dv = new DichVu();
                //lấy mã nhân viên từ gridView1 của devexpress, lưu ý các bạn nhớ viết name của trường cần lấy phải đúng như
                //trong csdl nhé
                dv.DichVuId = int.Parse(txtDvId.Text);
                //thực hienj hàm xóa
                new DichVuModel().delete(dv);
                MessageBox.Show("Thành Công");
                //grcDichVu.RefreshDataSource();
                DichVuForm_Load(sender, e);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DichVu dv = new DichVu();
            dv.DichVuId = int.Parse(txtDvId.Text);
            dv.TenDV = txtTenDV.Text;
            dv.GiaTien = txtGiaTien.Text;

            //
            new DichVuModel().Update(dv);
            MessageBox.Show("Thành Công");
            // grcDichVu.RefreshDataSource();
            DichVuForm_Load(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DichVuForm_Load(sender, e);
        }
    }
}