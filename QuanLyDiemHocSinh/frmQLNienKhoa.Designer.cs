namespace QuanLyDiemHocSinh
{
    partial class frmQLNienKhoa
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
            this.dgvNienKhoa = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.lblMaNienKhoa = new System.Windows.Forms.Label();
            this.lblTenNienKhoa = new System.Windows.Forms.Label();
            this.txtMaNienKhoa = new System.Windows.Forms.TextBox();
            this.txtTenNienKhoa = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNienKhoa)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNienKhoa
            // 
            this.dgvNienKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNienKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNienKhoa.Location = new System.Drawing.Point(0, 130);
            this.dgvNienKhoa.Name = "dgvNienKhoa";
            this.dgvNienKhoa.Size = new System.Drawing.Size(1370, 320);
            this.dgvNienKhoa.TabIndex = 1;
            this.dgvNienKhoa.Click += new System.EventHandler(this.dgvNienKhoa_Click);
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
            // lblMaNienKhoa
            // 
            this.lblMaNienKhoa.AutoSize = true;
            this.lblMaNienKhoa.Location = new System.Drawing.Point(49, 45);
            this.lblMaNienKhoa.Name = "lblMaNienKhoa";
            this.lblMaNienKhoa.Size = new System.Drawing.Size(75, 13);
            this.lblMaNienKhoa.TabIndex = 2;
            this.lblMaNienKhoa.Text = "Mã niên khóa:";
            // 
            // lblTenNienKhoa
            // 
            this.lblTenNienKhoa.AutoSize = true;
            this.lblTenNienKhoa.Location = new System.Drawing.Point(49, 73);
            this.lblTenNienKhoa.Name = "lblTenNienKhoa";
            this.lblTenNienKhoa.Size = new System.Drawing.Size(79, 13);
            this.lblTenNienKhoa.TabIndex = 3;
            this.lblTenNienKhoa.Text = "Tên niên khóa:";
            // 
            // txtMaNienKhoa
            // 
            this.txtMaNienKhoa.Location = new System.Drawing.Point(145, 41);
            this.txtMaNienKhoa.Multiline = true;
            this.txtMaNienKhoa.Name = "txtMaNienKhoa";
            this.txtMaNienKhoa.Size = new System.Drawing.Size(213, 21);
            this.txtMaNienKhoa.TabIndex = 0;
            // 
            // txtTenNienKhoa
            // 
            this.txtTenNienKhoa.Location = new System.Drawing.Point(145, 69);
            this.txtTenNienKhoa.Multiline = true;
            this.txtTenNienKhoa.Name = "txtTenNienKhoa";
            this.txtTenNienKhoa.Size = new System.Drawing.Size(213, 21);
            this.txtTenNienKhoa.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTenNienKhoa);
            this.panel2.Controls.Add(this.txtMaNienKhoa);
            this.panel2.Controls.Add(this.lblTenNienKhoa);
            this.panel2.Controls.Add(this.lblMaNienKhoa);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 130);
            this.panel2.TabIndex = 7;
            // 
            // frmQLNienKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 450);
            this.Controls.Add(this.dgvNienKhoa);
            this.Controls.Add(this.panel2);
            this.Name = "frmQLNienKhoa";
            this.Text = "Niên Khóa";
            this.Load += new System.EventHandler(this.frmQLNienKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNienKhoa)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvNienKhoa;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label lblMaNienKhoa;
        private System.Windows.Forms.Label lblTenNienKhoa;
        private System.Windows.Forms.TextBox txtMaNienKhoa;
        private System.Windows.Forms.TextBox txtTenNienKhoa;
        private System.Windows.Forms.Panel panel2;
    }
}