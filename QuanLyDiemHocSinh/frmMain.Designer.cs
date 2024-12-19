namespace QuanLyDiemHocSinh
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuStripMenu = new System.Windows.Forms.ToolStrip();
            this.mmuQuanLy = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuQLLopHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuQLHocKy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLNienKhoa = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuQLMonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuQLHocLuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLHanhKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuQLHocSinh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLGiaoVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKe = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuKQHocKy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKQMHHK = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKQHKChung = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKQCaNam = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKQCNMonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKQCNChung = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCaiDat = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuQLNguoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.sfsfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sfsfToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sfsfToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuStripMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStripMenu
            // 
            this.mnuStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmuQuanLy,
            this.mnuThongKe,
            this.mnuCaiDat});
            this.mnuStripMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuStripMenu.Name = "mnuStripMenu";
            this.mnuStripMenu.Size = new System.Drawing.Size(683, 25);
            this.mnuStripMenu.TabIndex = 0;
            this.mnuStripMenu.Text = " ";
            // 
            // mmuQuanLy
            // 
            this.mmuQuanLy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mmuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQLLopHoc,
            this.toolStripSeparator1,
            this.mnuQLHocKy,
            this.mnuQLNienKhoa,
            this.toolStripSeparator3,
            this.mnuQLMonHoc,
            this.mnuQLDiem,
            this.toolStripMenuItem3,
            this.mnuQLHocLuc,
            this.mnuQLHanhKiem,
            this.toolStripSeparator4,
            this.mnuQLHocSinh,
            this.mnuQLGiaoVien});
            this.mmuQuanLy.Image = ((System.Drawing.Image)(resources.GetObject("mmuQuanLy.Image")));
            this.mmuQuanLy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mmuQuanLy.Name = "mmuQuanLy";
            this.mmuQuanLy.Size = new System.Drawing.Size(61, 22);
            this.mmuQuanLy.Text = "&Quản lý";
            // 
            // mnuQLLopHoc
            // 
            this.mnuQLLopHoc.Name = "mnuQLLopHoc";
            this.mnuQLLopHoc.Size = new System.Drawing.Size(180, 22);
            this.mnuQLLopHoc.Text = "&Lớp học";
            this.mnuQLLopHoc.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuQLHocKy
            // 
            this.mnuQLHocKy.Name = "mnuQLHocKy";
            this.mnuQLHocKy.Size = new System.Drawing.Size(180, 22);
            this.mnuQLHocKy.Text = "&Học kỳ";
            this.mnuQLHocKy.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // mnuQLNienKhoa
            // 
            this.mnuQLNienKhoa.Name = "mnuQLNienKhoa";
            this.mnuQLNienKhoa.Size = new System.Drawing.Size(180, 22);
            this.mnuQLNienKhoa.Text = "&Niên khóa";
            this.mnuQLNienKhoa.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuQLMonHoc
            // 
            this.mnuQLMonHoc.Name = "mnuQLMonHoc";
            this.mnuQLMonHoc.Size = new System.Drawing.Size(180, 22);
            this.mnuQLMonHoc.Text = "&Môn học";
            this.mnuQLMonHoc.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // mnuQLDiem
            // 
            this.mnuQLDiem.Name = "mnuQLDiem";
            this.mnuQLDiem.Size = new System.Drawing.Size(180, 22);
            this.mnuQLDiem.Text = "&Điểm";
            this.mnuQLDiem.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuQLHocLuc
            // 
            this.mnuQLHocLuc.Name = "mnuQLHocLuc";
            this.mnuQLHocLuc.Size = new System.Drawing.Size(180, 22);
            this.mnuQLHocLuc.Text = "&Học lực";
            this.mnuQLHocLuc.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // mnuQLHanhKiem
            // 
            this.mnuQLHanhKiem.Name = "mnuQLHanhKiem";
            this.mnuQLHanhKiem.Size = new System.Drawing.Size(180, 22);
            this.mnuQLHanhKiem.Text = "&Hạnh kiểm";
            this.mnuQLHanhKiem.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuQLHocSinh
            // 
            this.mnuQLHocSinh.Name = "mnuQLHocSinh";
            this.mnuQLHocSinh.Size = new System.Drawing.Size(180, 22);
            this.mnuQLHocSinh.Text = "&Học sinh";
            this.mnuQLHocSinh.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // mnuQLGiaoVien
            // 
            this.mnuQLGiaoVien.Name = "mnuQLGiaoVien";
            this.mnuQLGiaoVien.Size = new System.Drawing.Size(180, 22);
            this.mnuQLGiaoVien.Text = "&Giáo viên";
            this.mnuQLGiaoVien.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // mnuThongKe
            // 
            this.mnuThongKe.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKQHocKy,
            this.mnuKQCaNam});
            this.mnuThongKe.Image = ((System.Drawing.Image)(resources.GetObject("mnuThongKe.Image")));
            this.mnuThongKe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuThongKe.Name = "mnuThongKe";
            this.mnuThongKe.Size = new System.Drawing.Size(69, 22);
            this.mnuThongKe.Text = "&Thống kê";
            // 
            // mnuKQHocKy
            // 
            this.mnuKQHocKy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKQMHHK,
            this.mnuKQHKChung});
            this.mnuKQHocKy.Name = "mnuKQHocKy";
            this.mnuKQHocKy.Size = new System.Drawing.Size(180, 22);
            this.mnuKQHocKy.Text = "&Kết quả môn học";
            // 
            // mnuKQMHHK
            // 
            this.mnuKQMHHK.Name = "mnuKQMHHK";
            this.mnuKQMHHK.Size = new System.Drawing.Size(180, 22);
            this.mnuKQMHHK.Text = "&Học kỳ";
            this.mnuKQMHHK.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // mnuKQHKChung
            // 
            this.mnuKQHKChung.Name = "mnuKQHKChung";
            this.mnuKQHKChung.Size = new System.Drawing.Size(180, 22);
            this.mnuKQHKChung.Text = "&Cả năm";
            // 
            // mnuKQCaNam
            // 
            this.mnuKQCaNam.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKQCNMonHoc,
            this.mnuKQCNChung});
            this.mnuKQCaNam.Name = "mnuKQCaNam";
            this.mnuKQCaNam.Size = new System.Drawing.Size(180, 22);
            this.mnuKQCaNam.Text = "&Kết quả chung";
            // 
            // mnuKQCNMonHoc
            // 
            this.mnuKQCNMonHoc.Name = "mnuKQCNMonHoc";
            this.mnuKQCNMonHoc.Size = new System.Drawing.Size(115, 22);
            this.mnuKQCNMonHoc.Text = "&Học kỳ";
            // 
            // mnuKQCNChung
            // 
            this.mnuKQCNChung.Name = "mnuKQCNChung";
            this.mnuKQCNChung.Size = new System.Drawing.Size(115, 22);
            this.mnuKQCNChung.Text = "&Cả năm";
            // 
            // mnuCaiDat
            // 
            this.mnuCaiDat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuCaiDat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQLNguoiDung,
            this.mnuThoat});
            this.mnuCaiDat.Image = ((System.Drawing.Image)(resources.GetObject("mnuCaiDat.Image")));
            this.mnuCaiDat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuCaiDat.Name = "mnuCaiDat";
            this.mnuCaiDat.Size = new System.Drawing.Size(57, 22);
            this.mnuCaiDat.Text = "&Cài đặt";
            this.mnuCaiDat.ToolTipText = "Cài đặt";
            // 
            // mnuQLNguoiDung
            // 
            this.mnuQLNguoiDung.Name = "mnuQLNguoiDung";
            this.mnuQLNguoiDung.Size = new System.Drawing.Size(146, 22);
            this.mnuQLNguoiDung.Text = "&Người dùng";
            this.mnuQLNguoiDung.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuThoat.Size = new System.Drawing.Size(146, 22);
            this.mnuThoat.Text = "&Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sfsfToolStripMenuItem,
            this.sfsfToolStripMenuItem1,
            this.sfsfToolStripMenuItem2});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.ShowDropDownArrow = false;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(23, 23);
            this.toolStripDropDownButton1.Text = "&Quản lý";
            // 
            // sfsfToolStripMenuItem
            // 
            this.sfsfToolStripMenuItem.Name = "sfsfToolStripMenuItem";
            this.sfsfToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.sfsfToolStripMenuItem.Text = "sfsf";
            // 
            // sfsfToolStripMenuItem1
            // 
            this.sfsfToolStripMenuItem1.Name = "sfsfToolStripMenuItem1";
            this.sfsfToolStripMenuItem1.Size = new System.Drawing.Size(92, 22);
            this.sfsfToolStripMenuItem1.Text = "sfsf";
            // 
            // sfsfToolStripMenuItem2
            // 
            this.sfsfToolStripMenuItem2.Name = "sfsfToolStripMenuItem2";
            this.sfsfToolStripMenuItem2.Size = new System.Drawing.Size(92, 22);
            this.sfsfToolStripMenuItem2.Text = "sfsf";
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(683, 425);
            this.tabControl1.TabIndex = 12;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(683, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelUser
            // 
            this.toolStripStatusLabelUser.Name = "toolStripStatusLabelUser";
            this.toolStripStatusLabelUser.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabelUser.Text = "toolStripStatusLabel1";
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::QuanLyDiemHocSinh.Properties.Resources.quan_ly_diem_so;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(683, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.mnuStripMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Điểm Học Sinh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuStripMenu.ResumeLayout(false);
            this.mnuStripMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem sfsfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sfsfToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sfsfToolStripMenuItem2;
        private System.Windows.Forms.ToolStrip mnuStripMenu;
        private System.Windows.Forms.ToolStripDropDownButton mmuQuanLy;
        private System.Windows.Forms.ToolStripDropDownButton mnuThongKe;
        private System.Windows.Forms.ToolStripMenuItem mnuQLMonHoc;
        private System.Windows.Forms.ToolStripMenuItem mnuQLDiem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuQLHanhKiem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mnuQLHocSinh;
        private System.Windows.Forms.ToolStripMenuItem mnuQLGiaoVien;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mnuKQHocKy;
        private System.Windows.Forms.ToolStripMenuItem mnuKQMHHK;
        private System.Windows.Forms.ToolStripMenuItem mnuKQHKChung;
        private System.Windows.Forms.ToolStripMenuItem mnuKQCaNam;
        private System.Windows.Forms.ToolStripMenuItem mnuKQCNMonHoc;
        private System.Windows.Forms.ToolStripMenuItem mnuKQCNChung;
        private System.Windows.Forms.ToolStripMenuItem mnuQLLopHoc;
        private System.Windows.Forms.ToolStripDropDownButton mnuCaiDat;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripMenuItem mnuQLHocKy;
        private System.Windows.Forms.ToolStripMenuItem mnuQLNienKhoa;
        private System.Windows.Forms.ToolStripMenuItem mnuQLHocLuc;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUser;
        private System.Windows.Forms.ToolStripMenuItem mnuQLNguoiDung;
    }
}

