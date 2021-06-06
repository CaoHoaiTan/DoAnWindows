using DevExpress.XtraEditors;
using QuanLyKhachSan.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.Form
{
    public partial class ThongTinDichVuForm : DevExpress.XtraEditors.XtraForm
    {
        public ThongTinDichVuForm()
        {
            InitializeComponent();
        }

        private void ThongTinDichVuForm_Load(object sender, EventArgs e)
        {
            thongTinDVBindingSource.DataSource = new ThongTinDichVuModel().FindAll();
            congViecBindingSource.DataSource = new CongViecModel().FindAll();
            dichVuBindingSource.DataSource = new DichVuModel().FindAll();
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
            thongTinDVBindingSource.Add(new ThongTinDV());
            thongTinDVBindingSource.MoveLast();
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
            ThongTinDV ttdv = new ThongTinDV();
            ttdv.CongViecId = int.Parse(cmbCongViecId.SelectedValue.ToString());
            ttdv.DichVuId = int.Parse(cmbDichVuId.SelectedValue.ToString());
            new ThongTinDichVuModel().insert(ttdv);
            MessageBox.Show("Thành công!");
            ThongTinDichVuForm_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ThongTinDV ttdv = new ThongTinDV();
            ttdv.CongViecId = int.Parse(cmbCongViecId.SelectedValue.ToString());
            ttdv.DichVuId = int.Parse(cmbDichVuId.SelectedValue.ToString());
            new ThongTinDichVuModel().delete(ttdv);
            MessageBox.Show("Thành công!");
            ThongTinDichVuForm_Load(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ThongTinDichVuForm_Load(sender, e);
        }

        private void cmbDichVuId_SelectedValueChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
        }

        private void cmbCongViecId_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
        }
    }
}