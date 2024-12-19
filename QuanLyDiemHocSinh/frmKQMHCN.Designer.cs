namespace QuanLyDiemHocSinh
{
    partial class frmKQMHCN
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
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.cboNienKhoa = new System.Windows.Forms.ComboBox();
            this.lblNienKhoa = new System.Windows.Forms.Label();
            this.dgvKQMHCN = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKQMHCN)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboMonHoc);
            this.panel1.Controls.Add(this.cboLop);
            this.panel1.Controls.Add(this.lblMonHoc);
            this.panel1.Controls.Add(this.lblLop);
            this.panel1.Controls.Add(this.btnXem);
            this.panel1.Controls.Add(this.cboNienKhoa);
            this.panel1.Controls.Add(this.lblNienKhoa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.FormattingEnabled = true;
            this.cboMonHoc.Location = new System.Drawing.Point(430, 41);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(121, 21);
            this.cboMonHoc.TabIndex = 2;
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(255, 41);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(99, 21);
            this.cboLop.TabIndex = 1;
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.AutoSize = true;
            this.lblMonHoc.Location = new System.Drawing.Point(372, 45);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(52, 13);
            this.lblMonHoc.TabIndex = 10;
            this.lblMonHoc.Text = "Môn học:";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(221, 45);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(28, 13);
            this.lblLop.TabIndex = 9;
            this.lblLop.Text = "Lớp:";
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(611, 39);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 3;
            this.btnXem.Text = "XEM";
            this.btnXem.UseVisualStyleBackColor = true;
            // 
            // cboNienKhoa
            // 
            this.cboNienKhoa.FormattingEnabled = true;
            this.cboNienKhoa.Location = new System.Drawing.Point(77, 40);
            this.cboNienKhoa.Name = "cboNienKhoa";
            this.cboNienKhoa.Size = new System.Drawing.Size(106, 21);
            this.cboNienKhoa.TabIndex = 0;
            // 
            // lblNienKhoa
            // 
            this.lblNienKhoa.AutoSize = true;
            this.lblNienKhoa.Location = new System.Drawing.Point(12, 44);
            this.lblNienKhoa.Name = "lblNienKhoa";
            this.lblNienKhoa.Size = new System.Drawing.Size(59, 13);
            this.lblNienKhoa.TabIndex = 0;
            this.lblNienKhoa.Text = "Niên khóa:";
            // 
            // dgvKQMHCN
            // 
            this.dgvKQMHCN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKQMHCN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKQMHCN.Location = new System.Drawing.Point(0, 100);
            this.dgvKQMHCN.Name = "dgvKQMHCN";
            this.dgvKQMHCN.Size = new System.Drawing.Size(800, 350);
            this.dgvKQMHCN.TabIndex = 1;
            // 
            // frmKQMHCN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvKQMHCN);
            this.Controls.Add(this.panel1);
            this.Name = "frmKQMHCN";
            this.Text = "Kết Quả Môn Học Cả Năm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKQMHCN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.ComboBox cboNienKhoa;
        private System.Windows.Forms.Label lblNienKhoa;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label lblMonHoc;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.DataGridView dgvKQMHCN;
    }
}