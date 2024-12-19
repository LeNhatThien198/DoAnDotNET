using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDiemHocSinh.Class;
namespace QuanLyDiemHocSinh
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            tabControl1.Visible = false;
            UpdateStatusStrip(); // Cập nhật thông tin người dùng khi form chính được khởi tạo
            this.IsMdiContainer = true; // Thiết lập frmMain là MDI container
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", @"D:\QuanLyDiemHocSinh\QuanLyDiemHocSinh");
            Functions.Connect(); //Mở kết nối
            UpdateStatusStrip();
        }
        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Functions.Disconnect(); //Đóng kết nối
            Application.Exit(); //Thoát
        }

        private void menuItem_Click(object sender, EventArgs e)
        {
            // Hiển thị TabControl và ẩn hình nền
            tabControl1.Visible = true;
            this.BackgroundImage = null;

            // Lấy tên của menu item đã click
            ToolStripMenuItem clickedMenuItem = sender as ToolStripMenuItem;
            if (clickedMenuItem != null)
            {
                string formName = clickedMenuItem.Name.Replace("mnu", "frm"); // Chuyển đổi tên menu item thành tên form

                // Gọi hàm ShowForm với tên form tương ứng
                Showfrm.ShowForm(tabControl1, formName);
            }
        }

        // Phương thức để cập nhật thông tin người dùng vào StatusStrip
        public void UpdateStatusStrip()
        {
            if (string.IsNullOrEmpty(UserSession.CurrentUser))
            {
                toolStripStatusLabelUser.Text = "Chưa đăng nhập";  // Nếu chưa đăng nhập
            }
            else
            {
                toolStripStatusLabelUser.Text = "Chào mừng: " + UserSession.CurrentUser;  // Hiển thị tên người dùng
            }
        }
    }
}
