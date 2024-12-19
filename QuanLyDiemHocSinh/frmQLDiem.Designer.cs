namespace QuanLyDiemHocSinh
{
    partial class frmQLDiem
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
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.lblTenHocSinh = new System.Windows.Forms.Label();
            this.txtTenHocSinh = new System.Windows.Forms.TextBox();
            this.txtDiemThi = new System.Windows.Forms.TextBox();
            this.txtDiem1Tiet = new System.Windows.Forms.TextBox();
            this.txtDiem15Phut = new System.Windows.Forms.TextBox();
            this.txtDiemMieng = new System.Windows.Forms.TextBox();
            this.lblDiemThi = new System.Windows.Forms.Label();
            this.lblDiem1Tiet = new System.Windows.Forms.Label();
            this.lblDiem15Phut = new System.Windows.Forms.Label();
            this.lblDiemMieng = new System.Windows.Forms.Label();
            this.cboMaHocSinh = new System.Windows.Forms.ComboBox();
            this.cboHocKy = new System.Windows.Forms.ComboBox();
            this.cboNienKhoa = new System.Windows.Forms.ComboBox();
            this.lblNienKhoa = new System.Windows.Forms.Label();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.lblMaHocSinh = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDiem
            // 
            this.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiem.Location = new System.Drawing.Point(0, 165);
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.Size = new System.Drawing.Size(1370, 285);
            this.dgvDiem.TabIndex = 1;
            this.dgvDiem.Click += new System.EventHandler(this.dgvDiem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboTrangThai);
            this.panel2.Controls.Add(this.cboMonHoc);
            this.panel2.Controls.Add(this.lblMonHoc);
            this.panel2.Controls.Add(this.lblTenHocSinh);
            this.panel2.Controls.Add(this.txtTenHocSinh);
            this.panel2.Controls.Add(this.txtDiemThi);
            this.panel2.Controls.Add(this.txtDiem1Tiet);
            this.panel2.Controls.Add(this.txtDiem15Phut);
            this.panel2.Controls.Add(this.txtDiemMieng);
            this.panel2.Controls.Add(this.lblDiemThi);
            this.panel2.Controls.Add(this.lblDiem1Tiet);
            this.panel2.Controls.Add(this.lblDiem15Phut);
            this.panel2.Controls.Add(this.lblDiemMieng);
            this.panel2.Controls.Add(this.cboMaHocSinh);
            this.panel2.Controls.Add(this.cboHocKy);
            this.panel2.Controls.Add(this.cboNienKhoa);
            this.panel2.Controls.Add(this.lblNienKhoa);
            this.panel2.Controls.Add(this.lblHocKy);
            this.panel2.Controls.Add(this.lblMaHocSinh);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 165);
            this.panel2.TabIndex = 30;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Đạt",
            "Chưa đạt"});
            this.cboTrangThai.Location = new System.Drawing.Point(123, 123);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(121, 21);
            this.cboTrangThai.TabIndex = 52;
            this.cboTrangThai.Visible = false;
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.FormattingEnabled = true;
            this.cboMonHoc.Location = new System.Drawing.Point(520, 15);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(203, 21);
            this.cboMonHoc.TabIndex = 50;
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.AutoSize = true;
            this.lblMonHoc.Location = new System.Drawing.Point(446, 19);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(52, 13);
            this.lblMonHoc.TabIndex = 51;
            this.lblMonHoc.Text = "Môn học:";
            // 
            // lblTenHocSinh
            // 
            this.lblTenHocSinh.AutoSize = true;
            this.lblTenHocSinh.Location = new System.Drawing.Point(49, 44);
            this.lblTenHocSinh.Name = "lblTenHocSinh";
            this.lblTenHocSinh.Size = new System.Drawing.Size(72, 13);
            this.lblTenHocSinh.TabIndex = 49;
            this.lblTenHocSinh.Text = "Tên học sinh:";
            // 
            // txtTenHocSinh
            // 
            this.txtTenHocSinh.Location = new System.Drawing.Point(123, 41);
            this.txtTenHocSinh.Multiline = true;
            this.txtTenHocSinh.Name = "txtTenHocSinh";
            this.txtTenHocSinh.Size = new System.Drawing.Size(240, 21);
            this.txtTenHocSinh.TabIndex = 48;
            // 
            // txtDiemThi
            // 
            this.txtDiemThi.Location = new System.Drawing.Point(520, 120);
            this.txtDiemThi.Name = "txtDiemThi";
            this.txtDiemThi.Size = new System.Drawing.Size(159, 20);
            this.txtDiemThi.TabIndex = 43;
            // 
            // txtDiem1Tiet
            // 
            this.txtDiem1Tiet.Location = new System.Drawing.Point(520, 94);
            this.txtDiem1Tiet.Name = "txtDiem1Tiet";
            this.txtDiem1Tiet.Size = new System.Drawing.Size(159, 20);
            this.txtDiem1Tiet.TabIndex = 42;
            // 
            // txtDiem15Phut
            // 
            this.txtDiem15Phut.Location = new System.Drawing.Point(520, 68);
            this.txtDiem15Phut.Name = "txtDiem15Phut";
            this.txtDiem15Phut.Size = new System.Drawing.Size(159, 20);
            this.txtDiem15Phut.TabIndex = 41;
            // 
            // txtDiemMieng
            // 
            this.txtDiemMieng.Location = new System.Drawing.Point(520, 41);
            this.txtDiemMieng.Name = "txtDiemMieng";
            this.txtDiemMieng.Size = new System.Drawing.Size(159, 20);
            this.txtDiemMieng.TabIndex = 40;
            // 
            // lblDiemThi
            // 
            this.lblDiemThi.AutoSize = true;
            this.lblDiemThi.Location = new System.Drawing.Point(446, 123);
            this.lblDiemThi.Name = "lblDiemThi";
            this.lblDiemThi.Size = new System.Drawing.Size(48, 13);
            this.lblDiemThi.TabIndex = 46;
            this.lblDiemThi.Text = "Điểm thi:";
            // 
            // lblDiem1Tiet
            // 
            this.lblDiem1Tiet.AutoSize = true;
            this.lblDiem1Tiet.Location = new System.Drawing.Point(446, 97);
            this.lblDiem1Tiet.Name = "lblDiem1Tiet";
            this.lblDiem1Tiet.Size = new System.Drawing.Size(60, 13);
            this.lblDiem1Tiet.TabIndex = 47;
            this.lblDiem1Tiet.Text = "Điểm 1 tiết:";
            // 
            // lblDiem15Phut
            // 
            this.lblDiem15Phut.AutoSize = true;
            this.lblDiem15Phut.Location = new System.Drawing.Point(446, 71);
            this.lblDiem15Phut.Name = "lblDiem15Phut";
            this.lblDiem15Phut.Size = new System.Drawing.Size(73, 13);
            this.lblDiem15Phut.TabIndex = 45;
            this.lblDiem15Phut.Text = "Điểm 15 phút:";
            // 
            // lblDiemMieng
            // 
            this.lblDiemMieng.AutoSize = true;
            this.lblDiemMieng.Location = new System.Drawing.Point(446, 44);
            this.lblDiemMieng.Name = "lblDiemMieng";
            this.lblDiemMieng.Size = new System.Drawing.Size(65, 13);
            this.lblDiemMieng.TabIndex = 44;
            this.lblDiemMieng.Text = "Điểm miệng:";
            // 
            // cboMaHocSinh
            // 
            this.cboMaHocSinh.FormattingEnabled = true;
            this.cboMaHocSinh.Location = new System.Drawing.Point(123, 15);
            this.cboMaHocSinh.Name = "cboMaHocSinh";
            this.cboMaHocSinh.Size = new System.Drawing.Size(240, 21);
            this.cboMaHocSinh.TabIndex = 32;
            this.cboMaHocSinh.SelectedIndexChanged += new System.EventHandler(this.cboMaHocSinh_SelectedIndexChanged);
            // 
            // cboHocKy
            // 
            this.cboHocKy.FormattingEnabled = true;
            this.cboHocKy.Location = new System.Drawing.Point(123, 94);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(159, 21);
            this.cboHocKy.TabIndex = 34;
            // 
            // cboNienKhoa
            // 
            this.cboNienKhoa.FormattingEnabled = true;
            this.cboNienKhoa.Location = new System.Drawing.Point(123, 68);
            this.cboNienKhoa.Name = "cboNienKhoa";
            this.cboNienKhoa.Size = new System.Drawing.Size(159, 21);
            this.cboNienKhoa.TabIndex = 36;
            // 
            // lblNienKhoa
            // 
            this.lblNienKhoa.AutoSize = true;
            this.lblNienKhoa.Location = new System.Drawing.Point(49, 71);
            this.lblNienKhoa.Name = "lblNienKhoa";
            this.lblNienKhoa.Size = new System.Drawing.Size(59, 13);
            this.lblNienKhoa.TabIndex = 38;
            this.lblNienKhoa.Text = "Niên khóa:";
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Location = new System.Drawing.Point(49, 97);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(44, 13);
            this.lblHocKy.TabIndex = 39;
            this.lblHocKy.Text = "Học kỳ:";
            // 
            // lblMaHocSinh
            // 
            this.lblMaHocSinh.AutoSize = true;
            this.lblMaHocSinh.Location = new System.Drawing.Point(49, 19);
            this.lblMaHocSinh.Name = "lblMaHocSinh";
            this.lblMaHocSinh.Size = new System.Drawing.Size(68, 13);
            this.lblMaHocSinh.TabIndex = 35;
            this.lblMaHocSinh.Text = "Mã học sinh:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(742, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 165);
            this.panel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btnXoa, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnThem, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSua, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnLuu, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(63, 68);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(502, 39);
            this.tableLayoutPanel2.TabIndex = 32;
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLyDiemHocSinh.Properties.Resources.Hopstarter_Sleek_Xp_Basic_Close_2_16;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(128, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(119, 32);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem.Image = global::QuanLyDiemHocSinh.Properties.Resources.Awicons_Vista_Artistic_Add_16;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(119, 33);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QuanLyDiemHocSinh.Properties.Resources.Papirus_Team_Papirus_Apps_System_software_update_16;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(253, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(119, 32);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::QuanLyDiemHocSinh.Properties.Resources.Hopstarter_Soft_Scraps_Save_16;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(378, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(119, 32);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmQLDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 450);
            this.Controls.Add(this.dgvDiem);
            this.Controls.Add(this.panel2);
            this.Name = "frmQLDiem";
            this.Text = "Điểm";
            this.Load += new System.EventHandler(this.frmQLDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtDiemThi;
        private System.Windows.Forms.TextBox txtDiem1Tiet;
        private System.Windows.Forms.TextBox txtDiem15Phut;
        private System.Windows.Forms.TextBox txtDiemMieng;
        private System.Windows.Forms.Label lblDiemThi;
        private System.Windows.Forms.Label lblDiem1Tiet;
        private System.Windows.Forms.Label lblDiem15Phut;
        private System.Windows.Forms.Label lblDiemMieng;
        private System.Windows.Forms.ComboBox cboMaHocSinh;
        private System.Windows.Forms.ComboBox cboHocKy;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.Label lblMaHocSinh;
        private System.Windows.Forms.Label lblTenHocSinh;
        private System.Windows.Forms.TextBox txtTenHocSinh;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.Label lblMonHoc;
        private System.Windows.Forms.ComboBox cboNienKhoa;
        private System.Windows.Forms.Label lblNienKhoa;
        private System.Windows.Forms.ComboBox cboTrangThai;
    }
}