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
            // TODO: This line of code loads data into the 'qLKhachSanDataSet.ThongTinDVs' table. You can move, or remove it, as needed.
            this.thongTinDVsTableAdapter.Fill(this.qLKhachSanDataSet.ThongTinDVs);
            thongTinDVsBindingSource.DataSource = qLKhachSanDataSet;
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
            thongTinDVsTableAdapter.Insert(
                int.Parse(cmbDichVuId.SelectedValue.ToString()),
                int.Parse(cmbCongViecId.SelectedValue.ToString()));
            //ThongTinDV ttdv = new ThongTinDV();
            //ttdv.CongViecId = int.Parse(cmbCongViecId.SelectedValue.ToString());
            //ttdv.DichVuId = int.Parse(cmbDichVuId.SelectedValue.ToString());
            //new ThongTinDichVuModel().insert(ttdv);
            MessageBox.Show("Thành công!");
            ThongTinDichVuForm_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            thongTinDVsTableAdapter.Delete(
                int.Parse(cmbDichVuId.SelectedValue.ToString()),
                int.Parse(cmbCongViecId.SelectedValue.ToString()));
            //ThongTinDV ttdv = new ThongTinDV();
            //ttdv.CongViecId = int.Parse(cmbCongViecId.SelectedValue.ToString());
            //ttdv.DichVuId = int.Parse(cmbDichVuId.SelectedValue.ToString());
            //new ThongTinDichVuModel().delete(ttdv);
            MessageBox.Show("Thành công!");
            ThongTinDichVuForm_Load(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ThongTinDichVuForm_Load(sender, e);
        }

        private void cmbDichVuId_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbDichVuId.SelectedValue != null)
            {   // Lọc nhưng Công việc chưa có trong dịch vụ
                congViecBindingSource.DataSource =
                    new Context().congViecs.SqlQuery(
                        "SELECT * " +
                        "FROM CongViecs " +
                        "WHERE (CongViecId NOT IN (SELECT CongViecId " +
                                                  "FROM ThongTinDVs " +
                                                  "WHERE DichVuId = @p0))",
                        cmbDichVuId.SelectedValue.ToString()
                        ).ToList();
            }
        }

        private void cmbCongViecId_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  btnDelete.Enabled = false;
        }
    }
}