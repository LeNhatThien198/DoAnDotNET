using QuanLyDiemHocSinh.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDiemHocSinh.Class;

namespace QuanLyDiemHocSinh
{
    public partial class frmKQMHHK : Form
    {
        DataTable tblKQMonHocHocKy;
        public frmKQMHHK()
        {
            InitializeComponent();
        }
        private void frmKQMHHK_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            Functions.FillCombo("SELECT MaNienKhoa,TenNienKhoa FROM tblNienKhoa", cboMaNienKhoa, "MaNienKhoa", "NienKhoa");
            cboMaNienKhoa.SelectedIndex = -1;
            Functions.FillCombo("SELECT MaHocKy,TenHocKy FROM tblHocKy", cboHocKy, "MaHocKy", "TenHocKy");
            cboHocKy.SelectedIndex = -1;
            Functions.FillCombo("SELECT MaLopHoc,TenLopHoc FROM tblLop", cboLop, "MaLopHoc", "TenLopHoc");
            cboLop.SelectedIndex = -1; //Đặt ComboBox về trạng thái không chọn giá trị nào.
            Functions.FillCombo("SELECT MaMonHoc,TenMonHoc FROM tblMonHoc", cboMonHoc, "MaMonHoc", "TenMonHoc");
            cboMonHoc.SelectedIndex = -1;
        }

        private void LoadDataGridView()
        {
            // Xây dựng câu lệnh SQL với điều kiện lọc
            string sql = @"
        SELECT 
            kq.MaHocSinh, 
            h.TenHocSinh, 
            kq.DTBMieng, 
            kq.DTB15Phut, 
            kq.DTB1Tiet, 
            kq.DiemThi, 
            kq.DTBMHocKy
        FROM 
            tblKQMonHocHocKy kq
        JOIN 
            tblHocSinh h ON kq.MaHocSinh = h.MaHocSinh
        WHERE 
            kq.MaNienKhoa = '" + cboMaNienKhoa.SelectedValue + @"' 
            AND kq.MaHocKy = '" + cboHocKy.SelectedValue + @"' 
            AND kq.MaLop = '" + cboLop.SelectedValue + @"' 
            AND kq.MaMonHoc = '" + cboMonHoc.SelectedValue + @"'";

            // Sử dụng GetDataToTable để lấy dữ liệu
            tblKQMonHocHocKy = Functions.GetDataToTable(sql);

            // Tính điểm trung bình cho mỗi học sinh và thêm vào DataTable
            foreach (DataRow row in tblKQMonHocHocKy.Rows)
            {
                // Lấy các điểm từ bảng (Nếu có giá trị NULL thì thay bằng 0)
                decimal dtbMieng = row["DTBMieng"] == DBNull.Value ? 0 : Convert.ToDecimal(row["DTBMieng"]);
                decimal dtb15Phut = row["DTB15Phut"] == DBNull.Value ? 0 : Convert.ToDecimal(row["DTB15Phut"]);
                decimal dtb1Tiet = row["DTB1Tiet"] == DBNull.Value ? 0 : Convert.ToDecimal(row["DTB1Tiet"]);
                decimal diemThi = row["DiemThi"] == DBNull.Value ? 0 : Convert.ToDecimal(row["DiemThi"]);

                // Tính điểm trung bình không hệ số
                decimal dtbMonHocKy = (dtbMieng + dtb15Phut + dtb1Tiet + diemThi) / 4;

                // Thêm giá trị điểm trung bình vào cột mới
                row["DTBMHocKy"] = dtbMonHocKy;
            }

            dgvKQMHHK.DataSource = tblKQMonHocHocKy;

            // Cài đặt tiêu đề cột
            dgvKQMHHK.Columns[0].HeaderText = "Mã học sinh";
            dgvKQMHHK.Columns[1].HeaderText = "Tên học sinh";
            dgvKQMHHK.Columns[2].HeaderText = "ĐTB Miệng";
            dgvKQMHHK.Columns[3].HeaderText = "ĐTB 15 phút";
            dgvKQMHHK.Columns[4].HeaderText = "ĐTB 1 tiết";
            dgvKQMHHK.Columns[5].HeaderText = "Điểm thi";
            dgvKQMHHK.Columns[6].HeaderText = "ĐTB Môn học kỳ";

            // Cài đặt chiều rộng cột
            dgvKQMHHK.Columns[0].Width = 200;
            dgvKQMHHK.Columns[1].Width = 150;
            dgvKQMHHK.Columns[2].Width = 150;
            dgvKQMHHK.Columns[3].Width = 200;
            dgvKQMHHK.Columns[4].Width = 150;
            dgvKQMHHK.Columns[5].Width = 150;
            dgvKQMHHK.Columns[6].Width = 150;

            // Không cho phép người dùng thêm dòng mới
            dgvKQMHHK.AllowUserToAddRows = false;
            dgvKQMHHK.EditMode = DataGridViewEditMode.EditProgrammatically;
        }


        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu người dùng chưa chọn đầy đủ thông tin
            if (cboMaNienKhoa.SelectedIndex == -1 || cboHocKy.SelectedIndex == -1 || cboLop.SelectedIndex == -1 || cboMonHoc.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ các thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy các giá trị từ ComboBox
            string maNienKhoa = cboMaNienKhoa.SelectedValue.ToString();
            string maHocKy = cboHocKy.SelectedValue.ToString();
            string maLop = cboLop.SelectedValue.ToString();
            string maMonHoc = cboMonHoc.SelectedValue.ToString();

            // Gọi hàm LoadDataGridView để truy vấn và hiển thị kết quả
            LoadDataGridView();
        }

        private void frmKQMHHK_Load_1(object sender, EventArgs e)
        {

        }
    }
}
       