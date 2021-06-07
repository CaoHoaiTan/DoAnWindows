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

namespace QuanLyKhachSan.Forms
{
    public partial class PhoneForm : DevExpress.XtraEditors.XtraForm
    {
        public PhoneForm()
        {
            InitializeComponent();
        }

        private void PhoneForm_Load(object sender, EventArgs e)
        {
            phoneBindingSource.DataSource = new PhoneModel().FindAll();
            nhanVienBindingSource.DataSource = new NhanVienModel().FindAll();
            txtPhoneId.Enabled = false;
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
            txtPhoneId.Enabled = false;
            phoneBindingSource.Add(new Phone());
            phoneBindingSource.MoveLast();
            txtSDT.Focus();
            //
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            //
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Phone p = new Phone();
            p.PhoneNumber = txtSDT.Text;
            if(cmbNhanVienId.SelectedValue != null)
                p.NhanVienId = int.Parse(cmbNhanVienId.SelectedValue.ToString());
            new PhoneModel().Insert(p);
            MessageBox.Show("Thành Công");
            PhoneForm_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Xóa
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //Khởi tạo đối tượng phone
                Phone p = new Phone();             
                p.PhoneId = int.Parse(txtPhoneId.Text);
                //thực hiện hàm xóa
                new PhoneModel().Delete(p);
                MessageBox.Show("Thành Công");
              
                PhoneForm_Load(sender, e);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng lưu thay đổi
            Phone p = new Phone();
            p.PhoneId = int.Parse(txtPhoneId.Text);
            p.PhoneNumber = txtSDT.Text;
            if (cmbNhanVienId.SelectedValue != null)
                p.NhanVienId = int.Parse(cmbNhanVienId.SelectedValue.ToString());
            // Update
            new PhoneModel().Update(p);
            MessageBox.Show("Thành Công");
            PhoneForm_Load(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            PhoneForm_Load(sender, e);
        }
    }
}