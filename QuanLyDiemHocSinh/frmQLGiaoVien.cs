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
    public partial class frmQLGiaoVien : Form
    {
        DataTable tblGiaoVien;
        public frmQLGiaoVien()
        {
            InitializeComponent();
            txtMaGiaoVien.KeyDown += EnterEvent.Control_KeyDown;
            txtTenGiaoVien.KeyDown += EnterEvent.Control_KeyDown;
            mtbDienThoai.KeyDown += EnterEvent.Control_KeyDown;
            chkGioiTinh.KeyDown += EnterEvent.Control_KeyDown;
            txtDiaChi.KeyDown += EnterEvent.Control_KeyDown;
        }

        private void frmQLGiaoVien_Load(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT * FROM tblMonHoc";
            txtMaGiaoVien.Enabled = false;
            btnLuu.Enabled = false;
            LoadDataGridView();
            Functions.FillCombo(sql, cboChuyenMon, "MaMonHoc", "TenMonHoc");
            cboChuyenMon.SelectedIndex = -1; //Đặt ComboBox về trạng thái không chọn giá trị nào.
            ResetValues();
        }
        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM tblGiaoVien";
            tblGiaoVien = Functions.GetDataToTable(sql); //lấy dữ liệu
            dgvGiaoVien.DataSource = tblGiaoVien;
            dgvGiaoVien.Columns[0].HeaderText = "Mã giáo viên";
            dgvGiaoVien.Columns[1].HeaderText = "Tên giáo viên";
            dgvGiaoVien.Columns[2].HeaderText = "Điện thoại";
            dgvGiaoVien.Columns[3].HeaderText = "Giới tính";
            dgvGiaoVien.Columns[4].HeaderText = "Địa chỉ";
            dgvGiaoVien.Columns[5].HeaderText = "Mã môn học";
            dgvGiaoVien.Columns[0].Width = 150;
            dgvGiaoVien.Columns[1].Width = 150;
            dgvGiaoVien.Columns[2].Width = 150;
            dgvGiaoVien.Columns[3].Width = 100;
            dgvGiaoVien.Columns[4].Width = 200;
            dgvGiaoVien.Columns[5].Width = 100;
            dgvGiaoVien.AllowUserToAddRows = false;
            dgvGiaoVien.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValues()
        {
            txtMaGiaoVien.Text = "";
            txtTenGiaoVien.Text = "";
            mtbDienThoai.Text = "";
            chkGioiTinh.Checked = false;
            txtDiaChi.Text = "";
            cboChuyenMon.Text = "";
        }
        private void dgvGiaoVien_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaGiaoVien.Focus();
                return;
            }
            if (tblGiaoVien.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaGiaoVien.Text = dgvGiaoVien.CurrentRow.Cells["MaGiaoVien"].Value.ToString();
            txtTenGiaoVien.Text = dgvGiaoVien.CurrentRow.Cells["TenGiaoVien"].Value.ToString();
            string gioiTinh = dgvGiaoVien.CurrentRow.Cells["GioiTinh"].Value.ToString().Trim();
            if (gioiTinh.Equals("Nam", StringComparison.OrdinalIgnoreCase))
                chkGioiTinh.Checked = true;
            else
                chkGioiTinh.Checked = false;
            txtDiaChi.Text = dgvGiaoVien.CurrentRow.Cells["DiaChi"].Value.ToString();
            mtbDienThoai.Text = dgvGiaoVien.CurrentRow.Cells["DienThoai"].Value.ToString();
            cboChuyenMon.SelectedValue = dgvGiaoVien.CurrentRow.Cells["MaMonHoc"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaGiaoVien.Enabled = true;
            txtMaGiaoVien.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (txtMaGiaoVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã giáo viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaGiaoVien.Focus();
                return;
            }
            if (txtTenGiaoVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên giáo viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenGiaoVien.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            if (mtbDienThoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbDienThoai.Focus();
                return;
            }
            if (chkGioiTinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            sql = "SELECT MaGiaoVien FROM tblGiaoVien WHERE MaGiaoVien=N'" + txtMaGiaoVien.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã giáo viên này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaGiaoVien.Focus();
                txtMaGiaoVien.Text = "";
                return;
            }
            if (cboChuyenMon.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn chuyên môn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboChuyenMon.Focus();
                return;
            }
                sql = "INSERT INTO tblGiaoVien(MaGiaoVien,TenGiaoVien, DienThoai, GioiTinh, DiaChi, MaMonHoc) VALUES (N'" + txtMaGiaoVien.Text.Trim() + "',N'" + txtTenGiaoVien.Text.Trim() + "','" + mtbDienThoai.Text + "',N'" + gt + "',N'" + txtDiaChi.Text.Trim() + "',N'" + cboChuyenMon.SelectedValue.ToString() + "')";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaGiaoVien.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (tblGiaoVien.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaGiaoVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenGiaoVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên giáo viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenGiaoVien.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            if (mtbDienThoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbDienThoai.Focus();
                return;
            }
            if (chkGioiTinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";

            if (cboChuyenMon.SelectedValue == null || cboChuyenMon.SelectedValue.ToString().Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chuyên môn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboChuyenMon.Focus();
                return;
            }
            sql = "UPDATE tblGiaoVien SET  TenGiaoVien=N'" + txtTenGiaoVien.Text.Trim().ToString() +                  
                    "',DienThoai='" + mtbDienThoai.Text.ToString() + "',GioiTinh=N'" + gt +
                    "',DiaChi=N'" + txtDiaChi.Text.Trim().ToString() +
                    "',MaMonHoc=N'" + cboChuyenMon.SelectedValue.ToString() +
                    "' WHERE MaGiaoVien=N'" + txtMaGiaoVien.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblGiaoVien.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaGiaoVien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblGiaoVien WHERE MaGiaoVien=N'" + txtMaGiaoVien.Text + "'";
                Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValues();
            }
        }
    }
}
