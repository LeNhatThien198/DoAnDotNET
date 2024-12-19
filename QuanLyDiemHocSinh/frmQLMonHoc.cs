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
    public partial class frmQLMonHoc : Form
    {
        DataTable tblMonHoc;
        public frmQLMonHoc()
        {
            InitializeComponent();
            txtMaMonHoc.KeyDown += EnterEvent.Control_KeyDown;
        }

        private void frmQLMonHoc_Load(object sender, EventArgs e)
        {
            txtMaMonHoc.Enabled = false;
            btnLuu.Enabled = false;
            LoadDataGridView();
        }
        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaMonHoc, TenMonHoc FROM tblMonHoc";
            tblMonHoc = Functions.GetDataToTable(sql); //lấy dữ liệu
            dgvMonHoc.DataSource = tblMonHoc;
            dgvMonHoc.Columns[0].HeaderText = "Mã môn học";
            dgvMonHoc.Columns[1].HeaderText = "Tên môn học";
            dgvMonHoc.Columns[0].Width = 150;
            dgvMonHoc.Columns[1].Width = 200;
            dgvMonHoc.AllowUserToAddRows = false;
            dgvMonHoc.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvMonHoc_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaMonHoc.Focus();
                return;
            }
            if (tblMonHoc.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaMonHoc.Text = dgvMonHoc.CurrentRow.Cells["MaMonHoc"].Value.ToString();
            txtTenMonHoc.Text = dgvMonHoc.CurrentRow.Cells["TenMonHoc"].Value.ToString();
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
            txtMaMonHoc.Enabled = true; //cho phép nhập mới
            txtMaMonHoc.Focus();
        }

        private void ResetValues()
        {
            txtMaMonHoc .Text = "";
            txtTenMonHoc.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMaMonHoc.Text.Trim().Length == 0) //Nếu chưa nhập mã môn học
            {
                MessageBox.Show("Bạn phải nhập mã môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaMonHoc.Focus();
                return;
            }
            if (txtTenMonHoc.Text.Trim().Length == 0) //Nếu chưa nhập tên môn học
            {
                MessageBox.Show("Bạn phải nhập tên môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenMonHoc.Focus();
                return;
            }
            sql = "Select MaMonHoc From tblMonHoc where MaMonHoc=N'" + txtMaMonHoc.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã môn học này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaMonHoc.Focus();
                return;
            }

            sql = "INSERT INTO tblMonHoc VALUES(N'" +
                txtMaMonHoc.Text + "',N'" + txtTenMonHoc.Text + "')";
            Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaMonHoc.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblMonHoc.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaMonHoc.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenMonHoc.Text.Trim().Length == 0) //nếu chưa nhập tên môn học
            {
                MessageBox.Show("Bạn chưa nhập tên môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE tblMonHoc SET TenMonHoc=N'" +
                txtTenMonHoc.Text.ToString() +
                "' WHERE MaMonHoc=N'" + txtMaMonHoc.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblMonHoc.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaMonHoc.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblMonHoc WHERE MaMonHoc=N'" + txtMaMonHoc.Text + "'";
                Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValues();
            }
        }
    }
}

