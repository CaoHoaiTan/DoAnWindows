using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.Form;
using QuanLyKhachSan.Models;
namespace QuanLyKhachSan
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Database.SetInitializer(new Initializer());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new NhanVienForm());
            Application.Run(new DichVuForm());
            Application.Run(new ThongTinDichVuForm());
            //Application.Run(new MainForm());

        }
    }
}
