using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemHocSinh
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmDangNhap frmDangNhap = new frmDangNhap();
            if (frmDangNhap.ShowDialog() == DialogResult.OK)  // Nếu đăng nhập thành công
            {
                Application.Run(new frmMain()); // Mở frmMain sau khi đăng nhập thành công
            }
            else
            {
                Application.Exit(); // Nếu đăng nhập không thành công, thoát ứng dụng
            }
        }
    }
}
