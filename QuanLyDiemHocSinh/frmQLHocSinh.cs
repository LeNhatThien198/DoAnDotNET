using QuanLyDiemHocSinh.Class;
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
    public partial class frmQLHocSinh : Form
    {
        DataTable tblHocSinh;
        public frmQLHocSinh()
        {
            InitializeComponent();
            txtMaHocSinh.KeyDown += EnterEvent.Control_KeyDown;
            txtTenHocSinh.KeyDown += EnterEvent.Control_KeyDown;
            dtpNgaySinh.KeyDown += EnterEvent.Control_KeyDown;
            chkGioiTinh.KeyDown += EnterEvent.Control_KeyDown;
            txtDiaChi.KeyDown += EnterEvent.Control_KeyDown;        
        }

        private void frmQLHocSinh_Load(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT MaLop, TenLop FROM tblLop";
            txtMaHocSinh.Enabled = false;
            btnLuu.Enabled = false;
            LoadDataGridView();
            Functions.FillCombo(sql, cboLop, "MaLop", "TenLop");
            cboLop.SelectedIndex = -1; //Đặt ComboBox về trạng thái không chọn giá trị nào
            cboLop.SelectedIndexChanged += cboLop_SelectedIndexChanged; // Gắn sự kiện thay đổi cboLop
            ResetValues();
        }
        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM tblHocSinh";
            tblHocSinh = Functions.GetDataToTable(sql); //lấy dữ liệu
            dgvHocSinh.DataSource = tblHocSinh;
            dgvHocSinh.Columns[0].HeaderText = "Mã học sinh";
            dgvHocSinh.Columns[1].HeaderText = "Tên học sinh";
            dgvHocSinh.Columns[2].HeaderText = "Ngày sinh";
            dgvHocSinh.Columns[3].HeaderText = "Giới tính";
            dgvHocSinh.Columns[4].HeaderText = "Địa chỉ";
            dgvHocSinh.Columns[5].HeaderText = "Mã lớp";
            dgvHocSinh.Columns[0].Width = 150;
            dgvHocSinh.Columns[1].Width = 150;
            dgvHocSinh.Columns[2].Width = 150;
            dgvHocSinh.Columns[3].Width = 100;
            dgvHocSinh.Columns[4].Width = 200;
            dgvHocSinh.Columns[5].Width = 100;
            dgvHocSinh.AllowUserToAddRows = false;
            dgvHocSinh.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvHocSinh.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
        private void ResetValues()
        {
            txtMaHocSinh.Text = "";
            txtTenHocSinh.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            chkGioiTinh.Checked = false;
            txtDiaChi.Text = "";
            cboLop.Text = "";
        }

        private void dgvHocSinh_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHocSinh.Focus();
                return;
            }
            if (tblHocSinh.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaHocSinh.Text = dgvHocSinh.CurrentRow.Cells["MaHocSinh"].Value.ToString();
            txtTenHocSinh.Text = dgvHocSinh.CurrentRow.Cells["TenHocSinh"].Value.ToString();
            dtpNgaySinh.Value = (DateTime)dgvHocSinh.CurrentRow.Cells["NgaySinh"].Value;
            string gioiTinh = dgvHocSinh.CurrentRow.Cells["GioiTinh"].Value.ToString().Trim();
            if (gioiTinh.Equals("Nam", StringComparison.OrdinalIgnoreCase))
                chkGioiTinh.Checked = true;
            else
                chkGioiTinh.Checked = false;
            txtDiaChi.Text = dgvHocSinh.CurrentRow.Cells["DiaChi"].Value.ToString();
            cboLop.SelectedValue = dgvHocSinh.CurrentRow.Cells["MaLop"].Value.ToString();
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
            txtMaHocSinh.Enabled = true;
            txtMaHocSinh.Focus();

            // Kiểm tra xem lớp đã được chọn chưa
            if (cboLop.SelectedValue != null)
            {
                string maLop = cboLop.SelectedValue.ToString();
                txtMaHocSinh.Text = CreateKey.CreateMaHocSinh(maLop);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lớp trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLop.Focus();
            }

            txtMaHocSinh.Focus();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (txtMaHocSinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã học sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHocSinh.Focus();
                return;
            }
            if (txtTenHocSinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên học sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenHocSinh.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            if (chkGioiTinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            sql = "SELECT MaHocSinh FROM tblHocSinh WHERE MaHocSinh=N'" + txtMaHocSinh.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã học sinh này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHocSinh.Focus();
                txtMaHocSinh.Text = "";
                return;
            }
            if (cboLop.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboLop.Focus();
                return;
            }
            sql = "INSERT INTO tblHocSinh VALUES (N'" + txtMaHocSinh.Text.Trim() + "',N'" + txtTenHocSinh.Text.Trim() + "','" + dtpNgaySinh.Value + "',N'" + gt + "',N'" + txtDiaChi.Text.Trim() + "',N'" + cboLop.SelectedValue.ToString() + "')";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaHocSinh.Enabled = false;
        }
        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false && cboLop.SelectedValue != null)
            {
                string maLop = cboLop.SelectedValue.ToString().Trim();

                // Gọi phương thức CreateMaHocSinh để tạo mã học sinh
                txtMaHocSinh.Text = CreateKey.CreateMaHocSinh(maLop);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (tblHocSinh.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaHocSinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenHocSinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên học sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenHocSinh.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            if (chkGioiTinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            string maLopCu = dgvHocSinh.CurrentRow.Cells["MaLop"].Value.ToString().Trim();
            string maLopMoi = cboLop.SelectedValue.ToString().Trim();

            // Nếu lớp không thay đổi, chỉ cập nhật thông tin
            if (maLopCu == maLopMoi)
            {
                sql = "UPDATE tblHocSinh SET  TenHocSinh=N'" + txtTenHocSinh.Text.Trim() +
                        "',NgaySinh='" + dtpNgaySinh.Value + "',GioiTinh=N'" + gt +
                        "',DiaChi=N'" + txtDiaChi.Text.Trim() +
                        "',MaLop=N'" + maLopMoi +
                        "' WHERE MaHocSinh=N'" + txtMaHocSinh.Text + "'";
                Functions.RunSQL(sql);
            }
            else
            {
                // Nếu lớp thay đổi, cập nhật lớp mới và tạo mã học sinh mới
                string maHocSinhMoi = CreateKey.CreateMaHocSinh(maLopMoi);
                sql = "UPDATE tblHocSinh SET  MaHocSinh=N'" + maHocSinhMoi +
                        "',TenHocSinh=N'" + txtTenHocSinh.Text.Trim() +
                        "',NgaySinh='" + dtpNgaySinh.Value + "',GioiTinh=N'" + gt +
                        "',DiaChi=N'" + txtDiaChi.Text.Trim() +
                        "',MaLop=N'" + maLopMoi +
                        "' WHERE MaHocSinh=N'" + txtMaHocSinh.Text + "'";
                Functions.RunSQL(sql);

                // Sắp xếp lại mã học sinh trong lớp cũ
                UpdateMaHocSinhTrongLop(maLopCu);
            }

            LoadDataGridView();
            ResetValues();
        }
        private void UpdateMaHocSinhTrongLop(string maLop)
        {
            // Lấy danh sách học sinh theo thứ tự thời gian thêm (hoặc tên nếu cần)
            string sql = $"SELECT MaHocSinh FROM tblHocSinh WHERE MaLop = '{maLop}' ORDER BY MaHocSinh";
            DataTable dt = Functions.GetDataToTable(sql);

            int thuTu = 1; // Thứ tự mới bắt đầu từ 1
            foreach (DataRow row in dt.Rows)
            {
                string maHocSinhCu = row["MaHocSinh"].ToString();
                string maHocSinhMoi = $"HS{maLop}{thuTu:D2}";

                // Cập nhật lại mã học sinh
                string updateSql = $"UPDATE tblHocSinh SET MaHocSinh = '{maHocSinhMoi}' WHERE MaHocSinh = '{maHocSinhCu}'";
                Functions.RunSQL(updateSql);

                thuTu++;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblHocSinh.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaHocSinh.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblHocSinh WHERE MaHocSinh=N'" + txtMaHocSinh.Text + "'";
                Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValues();
            }
        }
    }
}
    public static class CreateKey
    {
        // Lưu trữ số lượng học sinh theo mã lớp
        private static Dictionary<string, int> demHocSinh = new Dictionary<string, int>();

        public static string CreateMaHocSinh(string maLop)
        {
            if (string.IsNullOrEmpty(maLop))
                return null;

            // Lấy số lượng học sinh hiện tại trong lớp từ cơ sở dữ liệu
            string sql = $"SELECT COUNT(*) FROM tblHocSinh WHERE MaLop = '{maLop}'";
            int soLuongHocSinh = Functions.GetCount(sql);

            // Tạo mã học sinh theo định dạng "HS{maLop}{soLuongHocSinh + 1:D2}"
            return $"HS{maLop}{(soLuongHocSinh + 1):D2}";
        }

    }
