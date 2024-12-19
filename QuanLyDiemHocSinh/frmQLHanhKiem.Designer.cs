namespace QuanLyDiemHocSinh
{
    partial class frmQLHanhKiem
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
            this.dgvHanhKiem = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtLoaiHanhKiem = new System.Windows.Forms.TextBox();
            this.txtMaHanhKiem = new System.Windows.Forms.TextBox();
            this.lblLoaiHanhKiem = new System.Windows.Forms.Label();
            this.lblMaHanhKiem = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanhKiem)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHanhKiem
            // 
            this.dgvHanhKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHanhKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHanhKiem.Location = new System.Drawing.Point(0, 130);
            this.dgvHanhKiem.Name = "dgvHanhKiem";
            this.dgvHanhKiem.Size = new System.Drawing.Size(1370, 320);
            this.dgvHanhKiem.TabIndex = 4;
            this.dgvHanhKiem.Click += new System.EventHandler(this.dgvHanhKiem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtLoaiHanhKiem);
            this.panel2.Controls.Add(this.txtMaHanhKiem);
            this.panel2.Controls.Add(this.lblLoaiHanhKiem);
            this.panel2.Controls.Add(this.lblMaHanhKiem);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 130);
            this.panel2.TabIndex = 5;
            // 
            // txtLoaiHanhKiem
            // 
            this.txtLoaiHanhKiem.Location = new System.Drawing.Point(145, 69);
            this.txtLoaiHanhKiem.Multiline = true;
            this.txtLoaiHanhKiem.Name = "txtLoaiHanhKiem";
            this.txtLoaiHanhKiem.Size = new System.Drawing.Size(213, 21);
            this.txtLoaiHanhKiem.TabIndex = 1;
            // 
            // txtMaHanhKiem
            // 
            this.txtMaHanhKiem.Location = new System.Drawing.Point(145, 41);
            this.txtMaHanhKiem.Multiline = true;
            this.txtMaHanhKiem.Name = "txtMaHanhKiem";
            this.txtMaHanhKiem.Size = new System.Drawing.Size(213, 21);
            this.txtMaHanhKiem.TabIndex = 0;
            // 
            // lblLoaiHanhKiem
            // 
            this.lblLoaiHanhKiem.AutoSize = true;
            this.lblLoaiHanhKiem.Location = new System.Drawing.Point(49, 73);
            this.lblLoaiHanhKiem.Name = "lblLoaiHanhKiem";
            this.lblLoaiHanhKiem.Size = new System.Drawing.Size(82, 13);
            this.lblLoaiHanhKiem.TabIndex = 3;
            this.lblLoaiHanhKiem.Text = "Loại hạnh kiểm:";
            // 
            // lblMaHanhKiem
            // 
            this.lblMaHanhKiem.AutoSize = true;
            this.lblMaHanhKiem.Location = new System.Drawing.Point(49, 45);
            this.lblMaHanhKiem.Name = "lblMaHanhKiem";
            this.lblMaHanhKiem.Size = new System.Drawing.Size(77, 13);
            this.lblMaHanhKiem.TabIndex = 2;
            this.lblMaHanhKiem.Text = "Mã hạnh kiểm:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(742, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(628, 130);
            this.panel3.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnXoa, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLuu, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnThem, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSua, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(63, 68);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(502, 39);
            this.tableLayoutPanel1.TabIndex = 32;
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
            // frmQLHanhKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 450);
            this.Controls.Add(this.dgvHanhKiem);
            this.Controls.Add(this.panel2);
            this.Name = "frmQLHanhKiem";
            this.Text = "Hạnh Kiểm";
            this.Load += new System.EventHandler(this.frmQLHanhKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanhKiem)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHanhKiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtLoaiHanhKiem;
        private System.Windows.Forms.TextBox txtMaHanhKiem;
        private System.Windows.Forms.Label lblLoaiHanhKiem;
        private System.Windows.Forms.Label lblMaHanhKiem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
    }
}