using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Sử dụng thư viện để làm việc SQL server
using QuanLyDiemHocSinh.Class; //Sử dụng class


namespace QuanLyDiemHocSinh
{
    public partial class frmQLNguoiDung : Form
    {
        DataTable tblNguoiDung;
        public frmQLNguoiDung()
        {
            InitializeComponent();
            txtMaNguoiDung.KeyDown += EnterEvent.Control_KeyDown;
            txtTenNguoiDung.KeyDown += EnterEvent.Control_KeyDown;
            txtTenDangNhap.KeyDown += EnterEvent.Control_KeyDown;
        }

        private void frmQLNguoiDung_Load(object sender, EventArgs e)
        {
            txtMaNguoiDung.Enabled = false;
            btnLuu.Enabled = false;
            LoadDataGridView();
        }
        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM tblNguoiDung";
            tblNguoiDung = Functions.GetDataToTable(sql); //lấy dữ liệu
            dgvNguoiDung.DataSource = tblNguoiDung;
            dgvNguoiDung.Columns[0].HeaderText = "Mã người dùng";
            dgvNguoiDung.Columns[1].HeaderText = "Tên người dùng";
            dgvNguoiDung.Columns[2].HeaderText = "Tên đăng nhập";
            dgvNguoiDung.Columns[3].HeaderText = "Mật khẩu";
            dgvNguoiDung.Columns[0].Width = 200;
            dgvNguoiDung.Columns[1].Width = 200;
            dgvNguoiDung.Columns[2].Width = 200;
            dgvNguoiDung.Columns[3].Width = 200;
            dgvNguoiDung.AllowUserToAddRows = false;
            dgvNguoiDung.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvNguoiDung_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNguoiDung.Focus();
                return;
            }
            if (tblNguoiDung.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaNguoiDung.Text = dgvNguoiDung.CurrentRow.Cells["MaNguoiDung"].Value.ToString();
            txtTenNguoiDung.Text = dgvNguoiDung.CurrentRow.Cells["TenNguoiDung"].Value.ToString();
            txtTenDangNhap.Text = dgvNguoiDung.CurrentRow.Cells["TenDangNhap"].Value.ToString();
            txtMatKhau.Text = dgvNguoiDung.CurrentRow.Cells["MatKhau"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues(); //Xoá trắng các textbox
            txtMaNguoiDung.Enabled = true; //cho phép nhập mới
            txtMaNguoiDung.Focus();
        }
        private void ResetValues()
        {
            txtMaNguoiDung.Text = "";
            txtTenNguoiDung.Text = "";
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMaNguoiDung.Text.Trim().Length == 0) //Nếu chưa nhập mã người dùng
            {
                MessageBox.Show("Bạn phải nhập mã người dùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNguoiDung.Focus();
                return;
            }
            if (txtTenNguoiDung.Text.Trim().Length == 0) //Nếu chưa nhập tên người dùng
            {
                MessageBox.Show("Bạn phải nhập tên người dùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNguoiDung.Focus();
                return;
            }
            if (txtTenDangNhap.Text.Trim().Length == 0) //Nếu chưa nhập tên đăng nhập
            {
                MessageBox.Show("Bạn phải nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenDangNhap.Focus();
                return;
            }
            if (txtMatKhau.Text.Trim().Length == 0) //Nếu chưa nhập mật khẩu
            {
                MessageBox.Show("Bạn phải nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatKhau.Focus();
                return;
            }
            sql = "Select MaNguoiDung From tblNguoiDung where MaNguoiDung=N'" + txtMaNguoiDung.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã người dùng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNguoiDung.Focus();
                return;
            }
            sql = "Select TenDangNhap From tblNguoiDung where TenDangNhap='" + txtTenDangNhap.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Tên đăng nhập này đã có, bạn phải nhập tên đăng nhập khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Focus();
                return;
            }

            sql = "INSERT INTO tblNguoiDung VALUES(N'" +
                txtMaNguoiDung.Text + "',N'" + txtTenNguoiDung.Text + "','" + txtTenDangNhap.Text + "','" + txtMatKhau.Text + "')";
            Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaNguoiDung.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblNguoiDung.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNguoiDung.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenNguoiDung.Text.Trim().Length == 0) //nếu chưa nhập tên người dùng
            {
                MessageBox.Show("Bạn chưa nhập tên người dùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenDangNhap.Text.Trim().Length == 0) //nếu chưa nhập tên đăng nhập
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMatKhau.Text.Trim().Length == 0) //nếu chưa nhập mật khẩu
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE tblNguoiDung SET TenNguoiDung=N'" +
                txtTenNguoiDung.Text.ToString() + "', TenDangNhap='" + txtTenDangNhap.Text.ToString() + "',MatKhau='" + txtMatKhau.Text.ToString() +
                "' WHERE MaNguoiDung=N'" + txtMaNguoiDung.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNguoiDung.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNguoiDung.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblNguoiDung WHERE MaNguoiDung=N'" + txtMaNguoiDung.Text + "'";
                Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValues();
            }
        }
    }
}
