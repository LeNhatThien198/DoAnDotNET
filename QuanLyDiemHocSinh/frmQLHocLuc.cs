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
    public partial class frmQLHocLuc : Form
    {
        DataTable tblHocLuc;
        public frmQLHocLuc()
        {
            InitializeComponent();
            txtMaHocLuc.KeyDown += EnterEvent.Control_KeyDown;
            txtLoaiHocLuc.KeyDown += EnterEvent.Control_KeyDown;
            txtDiemCanTren.KeyDown += EnterEvent.Control_KeyDown;
        }

        private void frmQLHocLuc_Load(object sender, EventArgs e)
        {
            txtMaHocLuc.Enabled = false;
            btnLuu.Enabled = false;
            LoadDataGridView();
        }
        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM tblHocLuc";
            tblHocLuc = Functions.GetDataToTable(sql); //lấy dữ liệu
            dgvHocLuc.DataSource = tblHocLuc;
            dgvHocLuc.Columns[0].HeaderText = "Mã học lực";
            dgvHocLuc.Columns[1].HeaderText = "Loại học lực";
            dgvHocLuc.Columns[2].HeaderText = "Điểm cận trên";
            dgvHocLuc.Columns[3].HeaderText = "Điểm cận dưới";
            dgvHocLuc.Columns[0].Width = 150;
            dgvHocLuc.Columns[1].Width = 200;
            dgvHocLuc.Columns[2].Width = 150;
            dgvHocLuc.Columns[3].Width = 150;
            dgvHocLuc.AllowUserToAddRows = false;
            dgvHocLuc.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvHocLuc_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHocLuc.Focus();
                return;
            }
            if (tblHocLuc.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaHocLuc.Text = dgvHocLuc.CurrentRow.Cells["MaHocLuc"].Value.ToString();
            txtLoaiHocLuc.Text = dgvHocLuc.CurrentRow.Cells["LoaiHocLuc"].Value.ToString();
            txtDiemCanTren.Text = dgvHocLuc.CurrentRow.Cells["DiemCanTren"].Value.ToString();
            txtDiemCanDuoi.Text = dgvHocLuc.CurrentRow.Cells["DiemCanDuoi"].Value.ToString();
            // Kiểm tra giá trị NULL trước khi gán
            txtDiemCanTren.Text = dgvHocLuc.CurrentRow.Cells["DiemCanTren"].Value == DBNull.Value
                ? "" : dgvHocLuc.CurrentRow.Cells["DiemCanTren"].Value.ToString();
            txtDiemCanDuoi.Text = dgvHocLuc.CurrentRow.Cells["DiemCanDuoi"].Value == DBNull.Value
                ? "" : dgvHocLuc.CurrentRow.Cells["DiemCanDuoi"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void ResetValues()
        {
            txtMaHocLuc.Text = "";
            txtLoaiHocLuc.Text = "";
            txtDiemCanTren.Text = "";
            txtDiemCanDuoi.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues(); //Xoá trắng các textbox
            txtMaHocLuc.Enabled = true; //cho phép nhập mới
            txtMaHocLuc.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMaHocLuc.Text.Trim().Length == 0) //Nếu chưa nhập mã học lực
            {
                MessageBox.Show("Bạn phải nhập mã học lực", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHocLuc.Focus();
                return;
            }
            if (txtLoaiHocLuc.Text.Trim().Length == 0) //Nếu chưa nhập Loại học lực
            {
                MessageBox.Show("Bạn phải nhập Loại học lực", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLoaiHocLuc.Focus();
                return;
            }
            sql = "Select MaHocLuc From tblHocLuc where MaHocLuc=N'" + txtMaHocLuc.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã học lực này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHocLuc.Focus();
                return;
            }
            // Kiểm tra giá trị cho DiemCanTren và DiemCanDuoi
            string diemCanTren = string.IsNullOrEmpty(txtDiemCanTren.Text) ? "NULL" : txtDiemCanTren.Text;
            string diemCanDuoi = string.IsNullOrEmpty(txtDiemCanDuoi.Text) ? "NULL" : txtDiemCanDuoi.Text;

            sql = "INSERT INTO tblHocLuc VALUES(N'" +
                txtMaHocLuc.Text + "',N'" + txtLoaiHocLuc.Text + "'," + diemCanTren + "," + diemCanDuoi + ")";
            Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaHocLuc.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblHocLuc.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaHocLuc.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtLoaiHocLuc.Text.Trim().Length == 0) //nếu chưa nhập Loại học lực
            {
                MessageBox.Show("Bạn chưa nhập Loại học lực", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Kiểm tra giá trị cho DiemCanTren và DiemCanDuoi
            string diemCanTren = string.IsNullOrEmpty(txtDiemCanTren.Text) ? "NULL" : txtDiemCanTren.Text;
            string diemCanDuoi = string.IsNullOrEmpty(txtDiemCanDuoi.Text) ? "NULL" : txtDiemCanDuoi.Text;

            sql = "UPDATE tblHocLuc SET LoaiHocLuc=N'" +
                txtLoaiHocLuc.Text.ToString() + "',DiemCanTren=" + diemCanTren + ",DiemCanDuoi=" + diemCanDuoi +
                "' WHERE MaHocLuc=N'" + txtMaHocLuc.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblHocLuc.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaHocLuc.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblHocLuc WHERE MaHocLuc=N'" + txtMaHocLuc.Text + "'";
                Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValues();
            }
        }
    }
}
