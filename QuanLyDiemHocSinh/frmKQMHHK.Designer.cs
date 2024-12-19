namespace QuanLyDiemHocSinh
{
    partial class frmKQMHHK
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.cboHocKy = new System.Windows.Forms.ComboBox();
            this.cboMaNienKhoa = new System.Windows.Forms.ComboBox();
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.lblNienKhoa = new System.Windows.Forms.Label();
            this.dgvKQMHHK = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKQMHHK)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXemBaoCao);
            this.panel1.Controls.Add(this.cboMonHoc);
            this.panel1.Controls.Add(this.cboLop);
            this.panel1.Controls.Add(this.cboHocKy);
            this.panel1.Controls.Add(this.cboMaNienKhoa);
            this.panel1.Controls.Add(this.lblMonHoc);
            this.panel1.Controls.Add(this.lblLop);
            this.panel1.Controls.Add(this.lblHocKy);
            this.panel1.Controls.Add(this.lblNienKhoa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.Location = new System.Drawing.Point(713, 39);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(75, 23);
            this.btnXemBaoCao.TabIndex = 4;
            this.btnXemBaoCao.Text = "XEM";
            this.btnXemBaoCao.UseVisualStyleBackColor = true;
            this.btnXemBaoCao.Click += new System.EventHandler(this.btnXemBaoCao_Click);
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.FormattingEnabled = true;
            this.cboMonHoc.Location = new System.Drawing.Point(574, 40);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(121, 21);
            this.cboMonHoc.TabIndex = 3;
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(399, 40);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(99, 21);
            this.cboLop.TabIndex = 2;
            // 
            // cboHocKy
            // 
            this.cboHocKy.FormattingEnabled = true;
            this.cboHocKy.Location = new System.Drawing.Point(256, 40);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(82, 21);
            this.cboHocKy.TabIndex = 1;
            // 
            // cboMaNienKhoa
            // 
            this.cboMaNienKhoa.FormattingEnabled = true;
            this.cboMaNienKhoa.Location = new System.Drawing.Point(77, 40);
            this.cboMaNienKhoa.Name = "cboMaNienKhoa";
            this.cboMaNienKhoa.Size = new System.Drawing.Size(106, 21);
            this.cboMaNienKhoa.TabIndex = 0;
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.AutoSize = true;
            this.lblMonHoc.Location = new System.Drawing.Point(516, 44);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(52, 13);
            this.lblMonHoc.TabIndex = 3;
            this.lblMonHoc.Text = "Môn học:";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(365, 44);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(28, 13);
            this.lblLop.TabIndex = 2;
            this.lblLop.Text = "Lớp:";
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Location = new System.Drawing.Point(203, 44);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(44, 13);
            this.lblHocKy.TabIndex = 1;
            this.lblHocKy.Text = "Học kỳ:";
            // 
            // lblNienKhoa
            // 
            this.lblNienKhoa.AutoSize = true;
            this.lblNienKhoa.Location = new System.Drawing.Point(12, 44);
            this.lblNienKhoa.Name = "lblNienKhoa";
            this.lblNienKhoa.Size = new System.Drawing.Size(59, 13);
            this.lblNienKhoa.TabIndex = 5;
            this.lblNienKhoa.Text = "Niên khóa:";
            // 
            // dgvKQMHHK
            // 
            this.dgvKQMHHK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKQMHHK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKQMHHK.Location = new System.Drawing.Point(0, 100);
            this.dgvKQMHHK.Name = "dgvKQMHHK";
            this.dgvKQMHHK.Size = new System.Drawing.Size(800, 350);
            this.dgvKQMHHK.TabIndex = 1;
            // 
            // frmKQMHHK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvKQMHHK);
            this.Controls.Add(this.panel1);
            this.Name = "frmKQMHHK";
            this.Text = "Kết Quả Môn Học Theo Học Kỳ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKQMHHK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMonHoc;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.Label lblNienKhoa;
        private System.Windows.Forms.DataGridView dgvKQMHHK;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.ComboBox cboHocKy;
        private System.Windows.Forms.ComboBox cboMaNienKhoa;
        private System.Windows.Forms.Button btnXemBaoCao;
    }
}