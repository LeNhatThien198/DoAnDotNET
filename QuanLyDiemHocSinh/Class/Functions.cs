                                                                                                                                                                                    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Drawing;

namespace QuanLyDiemHocSinh.Class
{
    internal class Functions
    {
        public static SqlConnection con;
        public static void Connect()
        {
            con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.QLDiemHocSinhConnectionString;
            if (con.State != ConnectionState.Open)
            {
                con.Open();
                MessageBox.Show("Kết nối thành công!");
            }
            else
                MessageBox.Show("Kết nối không thành công!");
        }

        public static void Disconnect()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();   	//Đóng kết nối
                con.Dispose(); 	//Giải phóng tài nguyên
                con = null;
            }
        }
        
        //Lấy dữ liệu vào bảng
        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(); //Định nghĩa đối tượng thuộc lớp SqlDataAdapter
            //Tạo đối tượng thuộc lớp SqlCommand
            dap.SelectCommand = new SqlCommand();
            dap.SelectCommand.Connection = Functions.con; //Kết nối cơ sở dữ liệu
            dap.SelectCommand.CommandText = sql; //Lệnh SQL
            //Khai báo đối tượng table thuộc lớp DataTable
            DataTable table = new DataTable();
            dap.Fill(table);
            return table;
        }
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            dap.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma; //Trường giá trị
            cbo.DisplayMember = ten; //Trường hiển thị
        }
        //Hàm thực hiện câu lệnh SQL
        public static void RunSQL(string sql)
        {
            SqlCommand cmd; //Đối tượng thuộc lớp SqlCommand
            cmd = new SqlCommand();
            cmd.Connection = con; //Gán kết nối
            cmd.CommandText = sql; //Gán lệnh SQL
            try
            {
                cmd.ExecuteNonQuery(); //Thực hiện câu lệnh SQL
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();//Giải phóng bộ nhớ
            cmd = null;
        }
        //Hàm kiểm tra khoá trùng
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            dap.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }
        //Hàm hỗ trợ lấy số lượng học sinh từ cơ sở dữ liệu
        public static int GetCount(string sql)
        {
            int count = 0;
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.QLDiemHocSinhConnectionString)) // Sửa lại sử dụng đúng ConnectionString
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                count = (int)cmd.ExecuteScalar(); // Trả về số lượng dòng
            }
            return count;
        }
        public static int ExecuteScalar(string sql, SqlParameter[] parameters)
        {
            // Kiểm tra xem kết nối đã được khởi tạo chưa
            if (con == null)
            {
                con = new SqlConnection(Properties.Settings.Default.QLDiemHocSinhConnectionString);
            }

            // Kiểm tra xem kết nối có mở chưa
            if (con.State != ConnectionState.Open)
            {
                con.Open();  // Mở kết nối nếu chưa mở
            }

            SqlCommand cmd = new SqlCommand(sql, con);  // Khởi tạo SqlCommand với kết nối
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);  // Thêm các tham số vào câu lệnh SQL
            }

            try
            {
                // Thực thi câu lệnh SQL và trả về giá trị đầu tiên
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực thi câu lệnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                cmd.Dispose();  // Giải phóng tài nguyên
            }
        }
    }
}
