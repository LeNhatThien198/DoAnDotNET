namespace QuanLyDiemHocSinh
{
    partial class frmQLHocKy
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
            this.dgvHocKy = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTenHocKy = new System.Windows.Forms.TextBox();
            this.txtMaHocKy = new System.Windows.Forms.TextBox();
            this.lblTenHocKy = new System.Windows.Forms.Label();
            this.lblMaHocKy = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocKy)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHocKy
            // 
            this.dgvHocKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHocKy.Location = new System.Drawing.Point(0, 130);
            this.dgvHocKy.Name = "dgvHocKy";
            this.dgvHocKy.Size = new System.Drawing.Size(1370, 320);
            this.dgvHocKy.TabIndex = 1;
            this.dgvHocKy.Click += new System.EventHandler(this.dgvHocKy_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTenHocKy);
            this.panel2.Controls.Add(this.txtMaHocKy);
            this.panel2.Controls.Add(this.lblTenHocKy);
            this.panel2.Controls.Add(this.lblMaHocKy);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 130);
            this.panel2.TabIndex = 6;
            // 
            // txtTenHocKy
            // 
            this.txtTenHocKy.Location = new System.Drawing.Point(145, 69);
            this.txtTenHocKy.Multiline = true;
            this.txtTenHocKy.Name = "txtTenHocKy";
            this.txtTenHocKy.Size = new System.Drawing.Size(213, 21);
            this.txtTenHocKy.TabIndex = 1;
            // 
            // txtMaHocKy
            // 
            this.txtMaHocKy.Location = new System.Drawing.Point(145, 41);
            this.txtMaHocKy.Multiline = true;
            this.txtMaHocKy.Name = "txtMaHocKy";
            this.txtMaHocKy.Size = new System.Drawing.Size(213, 21);
            this.txtMaHocKy.TabIndex = 0;
            // 
            // lblTenHocKy
            // 
            this.lblTenHocKy.AutoSize = true;
            this.lblTenHocKy.Location = new System.Drawing.Point(49, 73);
            this.lblTenHocKy.Name = "lblTenHocKy";
            this.lblTenHocKy.Size = new System.Drawing.Size(64, 13);
            this.lblTenHocKy.TabIndex = 3;
            this.lblTenHocKy.Text = "Tên học kỳ:";
            // 
            // lblMaHocKy
            // 
            this.lblMaHocKy.AutoSize = true;
            this.lblMaHocKy.Location = new System.Drawing.Point(49, 45);
            this.lblMaHocKy.Name = "lblMaHocKy";
            this.lblMaHocKy.Size = new System.Drawing.Size(60, 13);
            this.lblMaHocKy.TabIndex = 2;
            this.lblMaHocKy.Text = "Mã học kỳ:";
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
            // frmQLHocKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 450);
            this.Controls.Add(this.dgvHocKy);
            this.Controls.Add(this.panel2);
            this.Name = "frmQLHocKy";
            this.Text = "Học Kỳ";
            this.Load += new System.EventHandler(this.frmQLHocKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocKy)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvHocKy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTenHocKy;
        private System.Windows.Forms.TextBox txtMaHocKy;
        private System.Windows.Forms.Label lblTenHocKy;
        private System.Windows.Forms.Label lblMaHocKy;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
    }
}