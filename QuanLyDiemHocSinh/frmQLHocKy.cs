using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDiemHocSinh.Class;
using System.Data.SqlClient; //Sử dụng thư viện để làm việc SQL server
using QuanLyDiemHocSinh.Class; //Sử dụng class

namespace QuanLyDiemHocSinh
{
    public partial class frmQLHocKy : Form
    {
        DataTable tblHocKy;
        public frmQLHocKy()
        {
            InitializeComponent();
            txtMaHocKy.KeyDown += EnterEvent.Control_KeyDown;
        }

        private void frmQLHocKy_Load(object sender, EventArgs e)
        {
            txtMaHocKy.Enabled = false;
            btnLuu.Enabled = false;
            LoadDataGridView();
        }
        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaHocKy, TenHocKy FROM tblHocKy";
            tblHocKy = Functions.GetDataToTable(sql); //lấy dữ liệu
            dgvHocKy.DataSource = tblHocKy;
            dgvHocKy.Columns[0].HeaderText = "Mã học kỳ";
            dgvHocKy.Columns[1].HeaderText = "Tên học kỳ";
            dgvHocKy.Columns[0].Width = 150;
            dgvHocKy.Columns[1].Width = 200;
            dgvHocKy.AllowUserToAddRows = false;
            dgvHocKy.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvHocKy_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHocKy.Focus();
                return;
            }
            if (tblHocKy.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaHocKy.Text = dgvHocKy.CurrentRow.Cells["MaHocKy"].Value.ToString();
            txtTenHocKy.Text = dgvHocKy.CurrentRow.Cells["TenHocKy"].Value.ToString();
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
            txtMaHocKy.Enabled = true; //cho phép nhập mới
            txtMaHocKy.Focus();
        }
        private void ResetValues()
        {
            txtMaHocKy.Text = "";
            txtTenHocKy.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMaHocKy.Text.Trim().Length == 0) //Nếu chưa nhập mã học kỳ
            {
                MessageBox.Show("Bạn phải nhập mã học kỳ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHocKy.Focus();
                return;
            }
            if (txtTenHocKy.Text.Trim().Length == 0) //Nếu chưa nhập tên học kỳ
            {
                MessageBox.Show("Bạn phải nhập tên học kỳ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenHocKy.Focus();
                return;
            }
            sql = "Select MaHocKy From tblHocKy where MaHocKy=N'" + txtMaHocKy.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã học kỳ này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHocKy.Focus();
                return;
            }

            sql = "INSERT INTO tblHocKy VALUES(N'" +
                txtMaHocKy.Text + "',N'" + txtTenHocKy.Text + "')";
            Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaHocKy.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblHocKy.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaHocKy.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenHocKy.Text.Trim().Length == 0) //nếu chưa nhập tên học kỳ
            {
                MessageBox.Show("Bạn chưa nhập tên học kỳ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE tblHocKy SET TenHocKy=N'" +
                txtTenHocKy.Text.ToString() +
                "' WHERE MaHocKy=N'" + txtMaHocKy.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblHocKy.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaHocKy.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblHocKy WHERE MaHocKy=N'" + txtMaHocKy.Text + "'";
                Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValues();
            }
        }
    }
}
