using QuanLyDiemHocSinh.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDiemHocSinh.Class;

namespace QuanLyDiemHocSinh
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            txtTenDangNhap.KeyDown += EnterEvent.Control_KeyDown;
            txtMatKhau.KeyDown += EnterEvent.Control_KeyDown;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ TextBox
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            // Kiểm tra thông tin đăng nhập
            if (tenDangNhap == "" || matKhau == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên đăng nhập và Mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Truy vấn kiểm tra tài khoản
            string sql = "SELECT COUNT(*) FROM tblNguoiDung WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";
            SqlParameter[] parameters = {
                new SqlParameter("@TenDangNhap", tenDangNhap),
                new SqlParameter("@MatKhau", matKhau)
            };

            try
            {
                object result = Functions.ExecuteScalar(sql, parameters);
                if (result != null && Convert.ToInt32(result) > 0) // Kiểm tra có dữ liệu hay không
                {
                    // Lưu thông tin người dùng vào UserSession
                    UserSession.CurrentUser = tenDangNhap;

                    // Cập nhật thông tin người dùng trên StatusStrip (frmMain)
                    frmMain mainForm = Application.OpenForms["frmMain"] as frmMain;
                    mainForm?.UpdateStatusStrip();  // Cập nhật lại StatusStrip sau khi đăng nhập thành công
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK; // Trả về kết quả OK
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Thoát chương trình
        }

    }
}
