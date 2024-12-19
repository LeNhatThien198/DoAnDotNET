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
    public partial class frmQLNienKhoa : Form
    {
        DataTable tblNienKhoa;
        public frmQLNienKhoa()
        {
            InitializeComponent();
            txtMaNienKhoa.KeyDown += EnterEvent.Control_KeyDown;
        }

        private void frmQLNienKhoa_Load(object sender, EventArgs e)
        {
            txtMaNienKhoa.Enabled = false;
            btnLuu.Enabled = false;
            LoadDataGridView();
        }
        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaNienKhoa, TenNienKhoa FROM tblNienKhoa";
            tblNienKhoa = Functions.GetDataToTable(sql); //lấy dữ liệu
            dgvNienKhoa.DataSource = tblNienKhoa;
            dgvNienKhoa.Columns[0].HeaderText = "Mã niên khóa";
            dgvNienKhoa.Columns[1].HeaderText = "Tên niên khóa";
            dgvNienKhoa.Columns[0].Width = 150;
            dgvNienKhoa.Columns[1].Width = 200;
            dgvNienKhoa.AllowUserToAddRows = false;
            dgvNienKhoa.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void dgvNienKhoa_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNienKhoa.Focus();
                return;
            }
            if (tblNienKhoa.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaNienKhoa.Text = dgvNienKhoa.CurrentRow.Cells["MaNienKhoa"].Value.ToString();
            txtTenNienKhoa.Text = dgvNienKhoa.CurrentRow.Cells["TenNienKhoa"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }
        private void ResetValues()
        {
            txtMaNienKhoa.Text = "";
            txtTenNienKhoa.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues(); //Xoá trắng các textbox
            txtMaNienKhoa.Enabled = true; //cho phép nhập mới
            txtMaNienKhoa.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMaNienKhoa.Text.Trim().Length == 0) //Nếu chưa nhập mã niên khóa
            {
                MessageBox.Show("Bạn phải nhập mã niên khóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNienKhoa.Focus();
                return;
            }
            if (txtTenNienKhoa.Text.Trim().Length == 0) //Nếu chưa nhập tên niên khóa
            {
                MessageBox.Show("Bạn phải nhập tên niên khóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNienKhoa.Focus();
                return;
            }
            sql = "Select MaNienKhoa From tblNienKhoa where MaNienKhoa=N'" + txtMaNienKhoa.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã niên khóa này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNienKhoa.Focus();
                return;
            }

            sql = "INSERT INTO tblNienKhoa VALUES(N'" +
                txtMaNienKhoa.Text + "',N'" + txtTenNienKhoa.Text + "')";
            Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaNienKhoa.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblNienKhoa.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNienKhoa.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenNienKhoa.Text.Trim().Length == 0) //nếu chưa nhập tên niên khóa
            {
                MessageBox.Show("Bạn chưa nhập tên niên khóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE tblNienKhoa SET TenNienKhoa=N'" +
                txtTenNienKhoa.Text.ToString() +
                "' WHERE MaNienKhoa=N'" + txtMaNienKhoa.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNienKhoa.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNienKhoa.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblNienKhoa WHERE MaNienKhoa=N'" + txtMaNienKhoa.Text + "'";
                Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValues();
            }
        }
    }
}
