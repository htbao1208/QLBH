namespace QLBH.GUI
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
            lbTaikhoan = new Label();
            lbMatkhau = new Label();
            txtTaikhoan = new TextBox();
            txtMatkhau = new TextBox();
            btnDangnhap = new Button();
            btnThoat = new Button();
            ckbHienThiMatKhau = new CheckBox();
            SuspendLayout();
            // 
            // lbTaikhoan
            // 
            lbTaikhoan.AutoSize = true;
            lbTaikhoan.Location = new Point(76, 41);
            lbTaikhoan.Name = "lbTaikhoan";
            lbTaikhoan.Size = new Size(71, 20);
            lbTaikhoan.TabIndex = 0;
            lbTaikhoan.Text = "Tài khoản";
            lbTaikhoan.Click += label1_Click;
            // 
            // lbMatkhau
            // 
            lbMatkhau.AutoSize = true;
            lbMatkhau.Location = new Point(76, 124);
            lbMatkhau.Name = "lbMatkhau";
            lbMatkhau.Size = new Size(70, 20);
            lbMatkhau.TabIndex = 1;
            lbMatkhau.Text = "Mật khẩu";
            // 
            // txtTaikhoan
            // 
            txtTaikhoan.Location = new Point(194, 34);
            txtTaikhoan.Name = "txtTaikhoan";
            txtTaikhoan.Size = new Size(182, 27);
            txtTaikhoan.TabIndex = 2;
            // 
            // txtMatkhau
            // 
            txtMatkhau.Location = new Point(194, 124);
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.PasswordChar = '*';
            txtMatkhau.Size = new Size(182, 27);
            txtMatkhau.TabIndex = 3;
            // 
            // btnDangnhap
            // 
            btnDangnhap.Location = new Point(76, 234);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(94, 29);
            btnDangnhap.TabIndex = 4;
            btnDangnhap.Text = "Đăng nhập";
            btnDangnhap.UseVisualStyleBackColor = true;
            btnDangnhap.Click += btnDangnhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(331, 234);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // ckbHienThiMatKhau
            // 
            ckbHienThiMatKhau.AutoSize = true;
            ckbHienThiMatKhau.Location = new Point(194, 171);
            ckbHienThiMatKhau.Name = "ckbHienThiMatKhau";
            ckbHienThiMatKhau.Size = new Size(153, 24);
            ckbHienThiMatKhau.TabIndex = 6;
            ckbHienThiMatKhau.Text = "Hiển Thị Mật Khẩu";
            ckbHienThiMatKhau.UseVisualStyleBackColor = true;
            ckbHienThiMatKhau.CheckedChanged += ckbHienThiMatKhau_CheckedChanged;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 310);
            Controls.Add(ckbHienThiMatKhau);
            Controls.Add(btnThoat);
            Controls.Add(btnDangnhap);
            Controls.Add(txtMatkhau);
            Controls.Add(txtTaikhoan);
            Controls.Add(lbMatkhau);
            Controls.Add(lbTaikhoan);
            Name = "frmDangNhap";
            Text = "frmDangNhap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTaikhoan;
        private Label lbMatkhau;
        private TextBox txtTaikhoan;
        private TextBox txtMatkhau;
        private Button btnDangnhap;
        private Button btnThoat;
        private CheckBox ckbHienThiMatKhau;
    }
}