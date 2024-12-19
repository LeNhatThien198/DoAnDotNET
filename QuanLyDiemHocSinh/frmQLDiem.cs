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
    public partial class frmQLDiem : Form
    {
        DataTable tblDiem;
        public frmQLDiem()
        {
            InitializeComponent();
            cboMaHocSinh.KeyDown += EnterEvent.Control_KeyDown;
            cboNienKhoa.KeyDown += EnterEvent.Control_KeyDown;
            cboHocKy.KeyDown += EnterEvent.Control_KeyDown;
            cboMonHoc.KeyDown += EnterEvent.Control_KeyDown;
            txtDiemMieng.KeyDown += EnterEvent.Control_KeyDown;
            txtDiem15Phut.KeyDown += EnterEvent.Control_KeyDown;
            txtDiem1Tiet.KeyDown += EnterEvent.Control_KeyDown;
        }
        private void frmQLDiem_Load(object sender, EventArgs e)
        {
            txtTenHocSinh.ReadOnly = true;
            btnLuu.Enabled = false;
            LoadDataGridView();
            Functions.FillCombo("SELECT MaHocSinh,TenHocSinh FROM tblHocSinh", cboMaHocSinh, "MaHocSinh", "MaHocSinh");
            cboMaHocSinh.SelectedIndex = -1; //Đặt ComboBox về trạng thái không chọn giá trị nào.
            Functions.FillCombo("SELECT MaNienKhoa,TenNienKhoa FROM tblNienKhoa", cboNienKhoa, "MaNienKhoa", "TenNienKhoa");
            cboNienKhoa.SelectedIndex = -1;
            Functions.FillCombo("SELECT MaHocKy,TenHocKy FROM tblHocKy", cboHocKy, "MaHocKy", "TenHocKy");
            cboHocKy.SelectedIndex = -1;
            Functions.FillCombo("SELECT MaMonHoc,TenMonHoc FROM tblMonHoc", cboMonHoc, "MaMonHoc", "TenMonHoc");
            cboMonHoc.SelectedIndex = -1;
            ResetValues();
        }
        private void ResetValues()
        {
            cboMaHocSinh.Text = "";
            cboNienKhoa.Text = "";
            cboHocKy.Text = "";
            cboMonHoc.Text = "";
            txtDiemMieng.Text = "0";
            txtDiem15Phut.Text = "0";
            txtDiem1Tiet.Text = "0";   
            txtDiemThi.Text = "0";
        }

        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM tblDiem";
            tblDiem = Functions.GetDataToTable(sql); //lấy dữ liệu
            dgvDiem.DataSource = tblDiem;
            dgvDiem.Columns[0].HeaderText = "Mã học sinh";
            dgvDiem.Columns[1].HeaderText = "Mã niên khóa";
            dgvDiem.Columns[2].HeaderText = "Mã học kỳ";
            dgvDiem.Columns[3].HeaderText = "Mã môn học";
            dgvDiem.Columns[4].HeaderText = "Điểm miệng";
            dgvDiem.Columns[5].HeaderText = "Điểm 15 phút";
            dgvDiem.Columns[6].HeaderText = "Điểm 1 tiết";
            dgvDiem.Columns[7].HeaderText = "Điểm thi";
            dgvDiem.Columns[0].Width = 200;
            dgvDiem.Columns[1].Width = 150;
            dgvDiem.Columns[2].Width = 150;
            dgvDiem.Columns[3].Width = 200;
            dgvDiem.Columns[4].Width = 150;
            dgvDiem.Columns[5].Width = 150;
            dgvDiem.Columns[6].Width = 150;
            dgvDiem.Columns[7].Width = 200;
            dgvDiem.AllowUserToAddRows = false;
            dgvDiem.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvDiem_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaHocSinh.Focus();
                return;
            }
            if (tblDiem.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            cboMaHocSinh.SelectedValue = dgvDiem.CurrentRow.Cells["MaHocSinh"].Value.ToString();
            cboNienKhoa.SelectedValue = dgvDiem.CurrentRow.Cells["MaNienKhoa"].Value.ToString();
            cboHocKy.SelectedValue = dgvDiem.CurrentRow.Cells["MaHocKy"].Value.ToString();
            cboMonHoc.SelectedValue = dgvDiem.CurrentRow.Cells["MaMonHoc"].Value.ToString();
            txtDiemMieng.Text = dgvDiem.CurrentRow.Cells["DiemMieng"].Value.ToString();
            txtDiem15Phut.Text = dgvDiem.CurrentRow.Cells["Diem15Phut"].Value.ToString();
            txtDiem1Tiet.Text = dgvDiem.CurrentRow.Cells["Diem1Tiet"].Value.ToString();
            txtDiemThi.Text = dgvDiem.CurrentRow.Cells["DiemThi"].Value.ToString();
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
            cboMaHocSinh.Focus();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (cboMaHocSinh.SelectedValue == null || cboMaHocSinh.SelectedValue.ToString().Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã học sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaHocSinh.Focus();
                return;
            }
            if (cboNienKhoa.SelectedValue == null || cboNienKhoa.SelectedValue.ToString().Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn niên khóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboNienKhoa.Focus();
                return;
            }
            if (cboHocKy.SelectedValue == null || cboHocKy.SelectedValue.ToString().Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn học kỳ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboHocKy.Focus();
                return;
            }
            if (cboMonHoc.SelectedValue == null || cboMonHoc.SelectedValue.ToString().Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMonHoc.Focus();
                return;
            }

            
           
                // Thực hiện câu lệnh INSERT để lưu dữ liệu
                sql = $"INSERT INTO tblDiem(MaHocSinh, MaNienKhoa, MaHocKy, MaMonHoc, DiemMieng, Diem15Phut, Diem1Tiet, DiemThi) " +
                  $"VALUES ('{cboMaHocSinh.SelectedValue}', '{cboNienKhoa.SelectedValue}', " +
                  $"'{cboHocKy.SelectedValue}', '{cboMonHoc.SelectedValue}', " +
                  $"{txtDiemMieng.Text}, {txtDiem15Phut.Text}, {txtDiem1Tiet.Text}, {txtDiemThi.Text})";

            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;

            // Kiểm tra dữ liệu
            if (tblDiem.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cboMaHocSinh.SelectedValue == null || cboMaHocSinh.SelectedValue.ToString().Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào cả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaHocSinh.Focus();
                return;
            }

            // Lấy giá trị ban đầu của khóa chính từ dòng được chọn trong DataGridView
            string oldMaHocSinh = dgvDiem.CurrentRow.Cells["MaHocSinh"].Value.ToString();
            string oldMaNienKhoa = dgvDiem.CurrentRow.Cells["MaNienKhoa"].Value.ToString();
            string oldMaHocKy = dgvDiem.CurrentRow.Cells["MaHocKy"].Value.ToString();
            string oldMaMonHoc = dgvDiem.CurrentRow.Cells["MaMonHoc"].Value.ToString();

            // Nếu các khóa chính không thay đổi, chỉ cập nhật các cột điểm
            if (oldMaHocSinh == cboMaHocSinh.SelectedValue.ToString() &&
                oldMaNienKhoa == cboNienKhoa.SelectedValue.ToString() &&
                oldMaHocKy == cboHocKy.SelectedValue.ToString() &&
                oldMaMonHoc == cboMonHoc.SelectedValue.ToString())
            {
                sql = "UPDATE tblDiem SET DiemMieng = " + txtDiemMieng.Text.Trim() +
                      ", Diem15Phut = " + txtDiem15Phut.Text.Trim() +
                      ", Diem1Tiet = " + txtDiem1Tiet.Text.Trim() +
                      ", DiemThi = " + txtDiemThi.Text.Trim() +
                      " WHERE MaHocSinh = N'" + oldMaHocSinh +
                      "' AND MaNienKhoa = N'" + oldMaNienKhoa +
                      "' AND MaHocKy = N'" + oldMaHocKy +
                      "' AND MaMonHoc = N'" + oldMaMonHoc + "'";
            }
            else
            {
                // Nếu các khóa chính thay đổi, xóa bản ghi cũ và thêm bản ghi mới
                sql = "DELETE FROM tblDiem WHERE MaHocSinh = N'" + oldMaHocSinh +
                      "' AND MaNienKhoa = N'" + oldMaNienKhoa +
                      "' AND MaHocKy = N'" + oldMaHocKy +
                      "' AND MaMonHoc = N'" + oldMaMonHoc + "'";
                Functions.RunSQL(sql);

                sql = $"INSERT INTO tblDiem(MaHocSinh, MaNienKhoa, MaHocKy, MaMonHoc, DiemMieng, Diem15Phut, Diem1Tiet, DiemThi) " +
                      $"VALUES ('{cboMaHocSinh.SelectedValue}', '{cboNienKhoa.SelectedValue}', " +
                      $"'{cboHocKy.SelectedValue}', '{cboMonHoc.SelectedValue}', " +
                      $"{txtDiemMieng.Text}, {txtDiem15Phut.Text}, {txtDiem1Tiet.Text}, {txtDiemThi.Text})";
            }

            // Thực thi câu lệnh SQL
            Functions.RunSQL(sql);

            // Cập nhật DataGridView
            LoadDataGridView();
            ResetValues();
            MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblDiem.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cboMaHocSinh.SelectedValue == null || cboMaHocSinh.SelectedValue.ToString().Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào cả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaHocSinh.Focus();
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string maHocSinh = dgvDiem.CurrentRow.Cells["MaHocSinh"].Value.ToString();
                string maNienKhoa = dgvDiem.CurrentRow.Cells["MaNienKhoa"].Value.ToString();
                string maHocKy = dgvDiem.CurrentRow.Cells["MaHocKy"].Value.ToString();
                string maMonHoc = dgvDiem.CurrentRow.Cells["MaMonHoc"].Value.ToString();

                sql = "DELETE FROM tblDiem WHERE MaHocSinh = N'" + maHocSinh +
             "' AND MaNienKhoa = N'" + maNienKhoa +
             "' AND MaHocKy = N'" + maHocKy +
             "' AND MaMonHoc = N'" + maMonHoc + "'";

                // Thực thi câu lệnh SQL
                Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void cboMaHocSinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaHocSinh.SelectedValue != null)
            {
                // Gán tên học sinh trực tiếp từ ComboBox DataSource
                txtTenHocSinh.Text = ((DataRowView)cboMaHocSinh.SelectedItem)["TenHocSinh"].ToString();
            }
            else
            {
                txtTenHocSinh.Text = ""; // Xóa ô TextBox khi không có lựa chọn
            }
        }
    }
}
