namespace QuanLyDiemHocSinh
{
    partial class frmQLHocLuc
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
            this.dgvHocLuc = new System.Windows.Forms.DataGridView();
            this.txtDiemCanTren = new System.Windows.Forms.TextBox();
            this.lblDiemCanTren = new System.Windows.Forms.Label();
            this.lblMaHocLuc = new System.Windows.Forms.Label();
            this.txtMaHocLuc = new System.Windows.Forms.TextBox();
            this.txtLoaiHocLuc = new System.Windows.Forms.TextBox();
            this.lblLoaiHocLuc = new System.Windows.Forms.Label();
            this.lblDiemCanDuoi = new System.Windows.Forms.Label();
            this.txtDiemCanDuoi = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocLuc)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHocLuc
            // 
            this.dgvHocLuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocLuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHocLuc.Location = new System.Drawing.Point(0, 130);
            this.dgvHocLuc.Name = "dgvHocLuc";
            this.dgvHocLuc.Size = new System.Drawing.Size(1370, 320);
            this.dgvHocLuc.TabIndex = 4;
            this.dgvHocLuc.Click += new System.EventHandler(this.dgvHocLuc_Click);
            // 
            // txtDiemCanTren
            // 
            this.txtDiemCanTren.Location = new System.Drawing.Point(501, 40);
            this.txtDiemCanTren.Multiline = true;
            this.txtDiemCanTren.Name = "txtDiemCanTren";
            this.txtDiemCanTren.Size = new System.Drawing.Size(159, 21);
            this.txtDiemCanTren.TabIndex = 34;
            // 
            // lblDiemCanTren
            // 
            this.lblDiemCanTren.AutoSize = true;
            this.lblDiemCanTren.Location = new System.Drawing.Point(405, 44);
            this.lblDiemCanTren.Name = "lblDiemCanTren";
            this.lblDiemCanTren.Size = new System.Drawing.Size(76, 13);
            this.lblDiemCanTren.TabIndex = 35;
            this.lblDiemCanTren.Text = "Điểm cận trên:";
            // 
            // lblMaHocLuc
            // 
            this.lblMaHocLuc.AutoSize = true;
            this.lblMaHocLuc.Location = new System.Drawing.Point(49, 44);
            this.lblMaHocLuc.Name = "lblMaHocLuc";
            this.lblMaHocLuc.Size = new System.Drawing.Size(63, 13);
            this.lblMaHocLuc.TabIndex = 23;
            this.lblMaHocLuc.Text = "Mã học lực:";
            // 
            // txtMaHocLuc
            // 
            this.txtMaHocLuc.Location = new System.Drawing.Point(145, 40);
            this.txtMaHocLuc.Multiline = true;
            this.txtMaHocLuc.Name = "txtMaHocLuc";
            this.txtMaHocLuc.Size = new System.Drawing.Size(213, 21);
            this.txtMaHocLuc.TabIndex = 1;
            // 
            // txtLoaiHocLuc
            // 
            this.txtLoaiHocLuc.Location = new System.Drawing.Point(145, 69);
            this.txtLoaiHocLuc.Multiline = true;
            this.txtLoaiHocLuc.Name = "txtLoaiHocLuc";
            this.txtLoaiHocLuc.Size = new System.Drawing.Size(213, 21);
            this.txtLoaiHocLuc.TabIndex = 2;
            // 
            // lblLoaiHocLuc
            // 
            this.lblLoaiHocLuc.AutoSize = true;
            this.lblLoaiHocLuc.Location = new System.Drawing.Point(49, 73);
            this.lblLoaiHocLuc.Name = "lblLoaiHocLuc";
            this.lblLoaiHocLuc.Size = new System.Drawing.Size(68, 13);
            this.lblLoaiHocLuc.TabIndex = 25;
            this.lblLoaiHocLuc.Text = "Loại học lực:";
            // 
            // lblDiemCanDuoi
            // 
            this.lblDiemCanDuoi.AutoSize = true;
            this.lblDiemCanDuoi.Location = new System.Drawing.Point(405, 73);
            this.lblDiemCanDuoi.Name = "lblDiemCanDuoi";
            this.lblDiemCanDuoi.Size = new System.Drawing.Size(78, 13);
            this.lblDiemCanDuoi.TabIndex = 30;
            this.lblDiemCanDuoi.Text = "Điểm cận dưới:";
            // 
            // txtDiemCanDuoi
            // 
            this.txtDiemCanDuoi.Location = new System.Drawing.Point(501, 69);
            this.txtDiemCanDuoi.Multiline = true;
            this.txtDiemCanDuoi.Name = "txtDiemCanDuoi";
            this.txtDiemCanDuoi.Size = new System.Drawing.Size(159, 21);
            this.txtDiemCanDuoi.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Location = new System.Drawing.Point(742, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(628, 130);
            this.panel3.TabIndex = 33;
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
            this.btnXoa.TabIndex = 2;
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
            this.btnSua.TabIndex = 5;
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
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtDiemCanDuoi);
            this.panel2.Controls.Add(this.lblDiemCanDuoi);
            this.panel2.Controls.Add(this.lblLoaiHocLuc);
            this.panel2.Controls.Add(this.txtLoaiHocLuc);
            this.panel2.Controls.Add(this.txtMaHocLuc);
            this.panel2.Controls.Add(this.lblMaHocLuc);
            this.panel2.Controls.Add(this.lblDiemCanTren);
            this.panel2.Controls.Add(this.txtDiemCanTren);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 130);
            this.panel2.TabIndex = 21;
            // 
            // frmQLHocLuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 450);
            this.Controls.Add(this.dgvHocLuc);
            this.Controls.Add(this.panel2);
            this.Name = "frmQLHocLuc";
            this.Text = "Học Lực";
            this.Load += new System.EventHandler(this.frmQLHocLuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocLuc)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvHocLuc;
        private System.Windows.Forms.TextBox txtDiemCanTren;
        private System.Windows.Forms.Label lblDiemCanTren;
        private System.Windows.Forms.Label lblMaHocLuc;
        private System.Windows.Forms.TextBox txtMaHocLuc;
        private System.Windows.Forms.TextBox txtLoaiHocLuc;
        private System.Windows.Forms.Label lblLoaiHocLuc;
        private System.Windows.Forms.Label lblDiemCanDuoi;
        private System.Windows.Forms.TextBox txtDiemCanDuoi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Panel panel2;
    }
}