using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace QuanLyDiemHocSinh.Class
{
    internal class Showfrm
    {
        public static void ShowForm(TabControl tabControl, string formName)
        {
            // Kiểm tra nếu tab đã tồn tại, nếu có thì chỉ cần chọn tab đó
            TabPage existingTab = tabControl.TabPages.Cast<TabPage>().FirstOrDefault(tab => tab.Tag != null && tab.Tag.ToString() == formName);

            if (existingTab != null)
            {
                // Chuyển đến tab đã có
                tabControl.SelectedTab = existingTab;
            }
            else
            {
                // Tạo tab mới và thêm form vào
                Form form = CreateForm(formName);

                if (form != null)
                {
                    TabPage newTab = new TabPage(form.Text);
                    newTab.Tag = formName;
                    newTab.Text = form.Text + "    ";

                    form.TopLevel = false;
                    form.FormBorderStyle = FormBorderStyle.None;
                    form.Dock = DockStyle.Fill;
                    newTab.Controls.Add(form);
                    tabControl.TabPages.Add(newTab);
                    form.Show();

                    // Chuyển đến tab mới

                    tabControl.SelectedTab = newTab;

                    // Cập nhật thông tin người dùng trong frmMain
                    frmMain mainForm = Application.OpenForms["frmMain"] as frmMain;
                    if (mainForm != null)
                    {
                        mainForm.UpdateStatusStrip(); // Cập nhật StatusStrip trong frmMain
                    }
                }
            }
            // Kích hoạt chế độ OwnerDraw để vẽ tab
            tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl.DrawItem -= TabControl_DrawItem; // Đảm bảo không bị trùng sự kiện
            tabControl.DrawItem += TabControl_DrawItem;
            tabControl.MouseClick -= TabControl_MouseClick;
            tabControl.MouseClick += TabControl_MouseClick;
        }

        // Hàm vẽ nút đóng trên tab
        private static void TabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tabControl = sender as TabControl;
            Rectangle tabRect = tabControl.GetTabRect(e.Index);

            // Vẽ tên tab
            string text = tabControl.TabPages[e.Index].Text;
            e.Graphics.DrawString(text, SystemFonts.DefaultFont, Brushes.Black, tabRect.X + 2, tabRect.Y + 1);

            // Vẽ nút "X" chỉ là chữ "X" ở góc phải
            Rectangle closeRect = new Rectangle(tabRect.Right - 18, tabRect.Top + 4, 12, 12); // Điều chỉnh vị trí và kích thước của nút "X"
            e.Graphics.DrawString("X", SystemFonts.DefaultFont, Brushes.Black, closeRect.X + 2, closeRect.Y - 2); // Vẽ chữ "X"
        }

        // Sự kiện click để đóng tab
        private static void TabControl_MouseClick(object sender, MouseEventArgs e)
        {
            TabControl tabControl = sender as TabControl;

            for (int i = 0; i < tabControl.TabPages.Count; i++)
            {
                Rectangle tabRect = tabControl.GetTabRect(i);
                Rectangle closeRect = new Rectangle(tabRect.Right - 18, tabRect.Top + 4, 12, 12); // Điều chỉnh lại kích thước của nút "X"

                if (closeRect.Contains(e.Location))
                {
                    // Đóng tab khi click vào nút X
                    tabControl.TabPages.RemoveAt(i);
                    break;
                }
            }
        }
        private static Form CreateForm(string formName)
        {
            // Dựa trên tên form, tạo và trả về form tương ứng
            switch (formName)
            {
                case "frmQLLopHoc":
                    return new frmQLLopHoc();
                case "frmQLHocKy":
                    return new frmQLHocKy();
                case "frmQLNienKhoa":
                    return new frmQLNienKhoa();
                case "frmQLMonHoc":
                    return new frmQLMonHoc();
                case "frmQLDiem":
                    return new frmQLDiem();
                case "frmQLHocLuc":
                    return new frmQLHocLuc();
                case "frmQLHanhKiem":
                    return new frmQLHanhKiem();
                case "frmQLHocSinh":
                    return new frmQLHocSinh();
                case "frmQLGiaoVien":
                    return new frmQLGiaoVien();
                case "frmQLNguoiDung":
                    return new frmQLNguoiDung();
                case "frmKQMHHK":
                    return new frmKQMHHK();
                // Thêm các form khác nếu cần
                default:
                    return null;
            }
        }
    }
}
