namespace QuanLyDiemHocSinh
{
    partial class frmDangNhap
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
            this.grpDangNhap = new System.Windows.Forms.GroupBox();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.lblQLDHS = new System.Windows.Forms.Label();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.grpDangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDangNhap
            // 
            this.grpDangNhap.Controls.Add(this.picUser);
            this.grpDangNhap.Controls.Add(this.btnHuyBo);
            this.grpDangNhap.Controls.Add(this.btnDangNhap);
            this.grpDangNhap.Controls.Add(this.txtMatKhau);
            this.grpDangNhap.Controls.Add(this.txtTenDangNhap);
            this.grpDangNhap.Controls.Add(this.lblMatKhau);
            this.grpDangNhap.Controls.Add(this.lblTenDangNhap);
            this.grpDangNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDangNhap.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.grpDangNhap.Location = new System.Drawing.Point(12, 83);
            this.grpDangNhap.Name = "grpDangNhap";
            this.grpDangNhap.Size = new System.Drawing.Size(603, 218);
            this.grpDangNhap.TabIndex = 0;
            this.grpDangNhap.TabStop = false;
            this.grpDangNhap.Text = "Thông tin đăng nhập";
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHuyBo.Location = new System.Drawing.Point(471, 160);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(103, 37);
            this.btnHuyBo.TabIndex = 5;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDangNhap.Location = new System.Drawing.Point(354, 160);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(103, 37);
            this.btnDangNhap.TabIndex = 4;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(354, 106);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(220, 29);
            this.txtMatKhau.TabIndex = 3;
            this.txtMatKhau.Text = "Mật khẩu";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(354, 55);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(220, 29);
            this.txtTenDangNhap.TabIndex = 2;
            this.txtTenDangNhap.Text = "Tên đăng nhập";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(262, 110);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(86, 21);
            this.lblMatKhau.TabIndex = 1;
            this.lblMatKhau.Text = "Mật khẩu:";
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Location = new System.Drawing.Point(221, 59);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(127, 21);
            this.lblTenDangNhap.TabIndex = 0;
            this.lblTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // lblQLDHS
            // 
            this.lblQLDHS.AutoSize = true;
            this.lblQLDHS.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLDHS.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblQLDHS.Location = new System.Drawing.Point(147, 35);
            this.lblQLDHS.Name = "lblQLDHS";
            this.lblQLDHS.Size = new System.Drawing.Size(332, 30);
            this.lblQLDHS.TabIndex = 1;
            this.lblQLDHS.Text = "QUẢN LÝ ĐIỂM HỌC SINH THPT";
            // 
            // picUser
            // 
            this.picUser.Image = global::QuanLyDiemHocSinh.Properties.Resources.vectorstock_42797441;
            this.picUser.Location = new System.Drawing.Point(6, 37);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(166, 160);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser.TabIndex = 6;
            this.picUser.TabStop = false;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(627, 313);
            this.Controls.Add(this.lblQLDHS);
            this.Controls.Add(this.grpDangNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            this.grpDangNhap.ResumeLayout(false);
            this.grpDangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDangNhap;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label lblQLDHS;
        private System.Windows.Forms.PictureBox picUser;
    }
}