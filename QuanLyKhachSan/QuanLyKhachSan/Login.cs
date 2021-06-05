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

namespace QuanLyKhachSan
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((this.txtUser.Text == "tandeptrai") && (this.txtPass.Text == "123"))
            {               
                this.Close();
            }    
                
            else
            {
                MessageBox.Show("Không đúng tên người dùng / mật khẩu!!!", "Thông báo");              
                this.txtUser.Text = "";
                this.txtPass.Text = "";
                this.txtUser.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnLogin.Focus();
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtPass.Focus();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}