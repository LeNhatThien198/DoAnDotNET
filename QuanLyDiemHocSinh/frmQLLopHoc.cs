using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyDiemHocSinh.Class;

namespace QuanLyDiemHocSinh
{
    public partial class frmQLLopHoc : Form
    {
        DataTable tblLop;
        public frmQLLopHoc()
        {
            InitializeComponent();
            txtMaLop.KeyDown += EnterEvent.Control_KeyDown;
            txtTenLop.KeyDown += EnterEvent.Control_KeyDown;
            cboGiaoVien.KeyDown += EnterEvent.Control_KeyDown;
        }

        private void frmQLLopHoc_Load(object sender, EventArgs e)
        {
            txtMaLop.Enabled = false;
            btnLuu.Enabled = false;
            LoadDataGridView();
            Functions.FillCombo("SELECT MaGiaoVien,TenGiaoVien FROM tblGiaoVien", cboGiaoVien, "MaGiaoVien", "TenGiaoVien");
            cboGiaoVien.SelectedIndex = -1; //Đặt ComboBox về trạng thái không chọn giá trị nào.
            Functions.FillCombo("SELECT MaNienKhoa,TenNienKhoa FROM tblNienKhoa", cboNienKhoa, "MaNienKhoa", "TenNienKhoa");
            cboNienKhoa.SelectedIndex = -1;
            ResetValues();

        }
        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaLop,TenLop,MaGiaoVien,MaNienKhoa FROM tblLop";
            tblLop = Functions.GetDataToTable(sql); //lấy dữ liệu
            dgvLopHoc.DataSource = tblLop;
            dgvLopHoc.Columns[0].HeaderText = "Mã lớp";
            dgvLopHoc.Columns[1].HeaderText = "Tên lớp";
            dgvLopHoc.Columns[2].HeaderText = "Mã giáo viên";
            dgvLopHoc.Columns[3].HeaderText = "Mã niên khóa";
            dgvLopHoc.Columns[0].Width = 150;
            dgvLopHoc.Columns[1].Width = 150;
            dgvLopHoc.Columns[2].Width = 200;
            dgvLopHoc.Columns[3].Width = 150;
            dgvLopHoc.AllowUserToAddRows = false;
            dgvLopHoc.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValues()
        {
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            cboGiaoVien.Text = "";
            cboNienKhoa.Text = "";
        }

        private void dgvLopHoc_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaLop.Focus();
                return;
            }
            if (tblLop.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaLop.Text = dgvLopHoc.CurrentRow.Cells["MaLop"].Value.ToString();
            txtTenLop.Text = dgvLopHoc.CurrentRow.Cells["TenLop"].Value.ToString();
            cboGiaoVien.SelectedValue = dgvLopHoc.CurrentRow.Cells["MaGiaoVien"].Value.ToString();
            cboNienKhoa.SelectedValue = dgvLopHoc.CurrentRow.Cells["MaNienKhoa"].Value.ToString();
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
            txtMaLop.Enabled = true; //cho phép nhập mới
            txtMaLop.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaLop.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLop.Focus();
                return;
            }
            if (txtTenLop.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLop.Focus();
                return;
            }
            if (cboGiaoVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn giáo viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboGiaoVien.Focus();
                return;
            }
            if (cboNienKhoa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn niên khóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboNienKhoa.Focus();
                return;
            }
            sql = "Select MaLop From tblLop where MaLop=N'" + txtMaLop.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã lớp này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLop.Focus();
                return;
            }
            sql = "INSERT INTO tblLop(MaLop,TenLop,MaGiaoVien,MaNienKhoa) VALUES(N'" +
                txtMaLop.Text + "',N'" + txtTenLop.Text + "',N'" + cboGiaoVien.SelectedValue.ToString() + "',N'" + cboNienKhoa.SelectedValue.ToString() + "')";
            Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaLop.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblLop.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaLop.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenLop.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLop.Focus();
                return;
            }
            if (cboGiaoVien.SelectedValue == null || cboGiaoVien.SelectedValue.ToString().Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn giáo viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboGiaoVien.Focus();
                return;
            }
            if (cboNienKhoa.SelectedValue == null || cboNienKhoa.SelectedValue.ToString().Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn niên khóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboNienKhoa.Focus();
                return;
            }
            sql = "UPDATE tblLop SET TenLop=N'" + txtTenLop.Text.Trim().ToString() +
                    "',MaGiaoVien=N'" + cboGiaoVien.SelectedValue.ToString() + "',MaNienKhoa=N'" + cboNienKhoa.SelectedValue.ToString() +
                    "' WHERE MaLop=N'" + txtMaLop.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblLop.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaLop.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblLop WHERE MaLop=N'" + txtMaLop.Text + "'";
                Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValues();
            }
        }
    }
}
