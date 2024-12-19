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
    public partial class frmQLHanhKiem : Form
    {
        DataTable tblHanhKiem;
        public frmQLHanhKiem()
        {
            InitializeComponent();
            txtMaHanhKiem.KeyDown += EnterEvent.Control_KeyDown;
        }

        private void frmQLHanhKiem_Load(object sender, EventArgs e)
        {
            txtMaHanhKiem.Enabled = false;
            btnLuu.Enabled = false;
            LoadDataGridView();
        }
        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaHanhKiem, LoaiHanhKiem FROM tblHanhKiem";
            tblHanhKiem = Functions.GetDataToTable(sql); //lấy dữ liệu
            dgvHanhKiem.DataSource = tblHanhKiem;
            dgvHanhKiem.Columns[0].HeaderText = "Mã hạnh kiểm";
            dgvHanhKiem.Columns[1].HeaderText = "Loại hạnh kiểm";
            dgvHanhKiem.Columns[0].Width = 150;
            dgvHanhKiem.Columns[1].Width = 200;
            dgvHanhKiem.AllowUserToAddRows = false;
            dgvHanhKiem.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvHanhKiem_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHanhKiem.Focus();
                return;
            }
            if (tblHanhKiem.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaHanhKiem.Text = dgvHanhKiem.CurrentRow.Cells["MaHanhKiem"].Value.ToString();
            txtLoaiHanhKiem.Text = dgvHanhKiem.CurrentRow.Cells["LoaiHanhKiem"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }
        private void ResetValues()
        {
            txtMaHanhKiem.Text = "";
            txtLoaiHanhKiem.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues(); //Xoá trắng các textbox
            txtMaHanhKiem.Enabled = true; //cho phép nhập mới
            txtMaHanhKiem.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMaHanhKiem.Text.Trim().Length == 0) //Nếu chưa nhập mã hạnh kiểm
            {
                MessageBox.Show("Bạn phải nhập mã hạnh kiểm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHanhKiem.Focus();
                return;
            }
            if (txtLoaiHanhKiem.Text.Trim().Length == 0) //Nếu chưa nhập Loại hạnh kiểm
            {
                MessageBox.Show("Bạn phải nhập Loại hạnh kiểm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLoaiHanhKiem.Focus();
                return;
            }
            sql = "Select MaHanhKiem From tblHanhKiem where MaHanhKiem=N'" + txtMaHanhKiem.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã hạnh kiểm này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHanhKiem.Focus();
                return;
            }

            sql = "INSERT INTO tblHanhKiem VALUES(N'" +
                txtMaHanhKiem.Text + "',N'" + txtLoaiHanhKiem.Text + "')";
            Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaHanhKiem.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblHanhKiem.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaHanhKiem.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtLoaiHanhKiem.Text.Trim().Length == 0) //nếu chưa nhập Loại hạnh kiểm
            {
                MessageBox.Show("Bạn chưa nhập Loại hạnh kiểm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE tblHanhKiem SET LoaiHanhKiem=N'" +
                txtLoaiHanhKiem.Text.ToString() +
                "' WHERE MaHanhKiem=N'" + txtMaHanhKiem.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblHanhKiem.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaHanhKiem.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblHanhKiem WHERE MaHanhKiem=N'" + txtMaHanhKiem.Text + "'";
                Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValues();
            }
        }
    }
}
