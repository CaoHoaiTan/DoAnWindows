using DevExpress.XtraBars;
using System;
using System.Windows.Forms;
using QuanLyKhachSan.Forms;
namespace QuanLyKhachSan
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            new NhanVienForm().ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            new NhomNVForm().ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            new Login().ShowDialog();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            new CongViecForm().ShowDialog();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            new DichVuForm().ShowDialog();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            new PhoneForm().ShowDialog();
        }
    }
}