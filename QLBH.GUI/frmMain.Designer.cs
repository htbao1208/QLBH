namespace QLBH.GUI
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
            pnlHeader = new Panel();
            lblNguoiDung = new Label();
            lblTenCuaHang = new Label();
            pnlMenu = new Panel();
            btnDangXuat = new Button();
            btnHoaDon = new Button();
            btnKhachHang = new Button();
            btnLoaiSanPham = new Button();
            btnSanPham = new Button();
            button1 = new Button();
            pnlContent = new Panel();
            pictureBox1 = new PictureBox();
            pnlHeader.SuspendLayout();
            pnlMenu.SuspendLayout();
            pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblNguoiDung);
            pnlHeader.Controls.Add(lblTenCuaHang);
            pnlHeader.ForeColor = SystemColors.ButtonHighlight;
            pnlHeader.Location = new Point(1, 2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1021, 58);
            pnlHeader.TabIndex = 0;
            // 
            // lblNguoiDung
            // 
            lblNguoiDung.AutoSize = true;
            lblNguoiDung.ForeColor = Color.Black;
            lblNguoiDung.Location = new Point(895, 20);
            lblNguoiDung.Name = "lblNguoiDung";
            lblNguoiDung.Size = new Size(116, 19);
            lblNguoiDung.TabIndex = 4;
            lblNguoiDung.Text = "Xin chào: ----";
            // 
            // lblTenCuaHang
            // 
            lblTenCuaHang.AutoSize = true;
            lblTenCuaHang.Font = new Font("SF Pro Display Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenCuaHang.ForeColor = Color.FromArgb(31, 41, 55);
            lblTenCuaHang.ImageAlign = ContentAlignment.MiddleLeft;
            lblTenCuaHang.Location = new Point(11, 14);
            lblTenCuaHang.Name = "lblTenCuaHang";
            lblTenCuaHang.Size = new Size(326, 27);
            lblTenCuaHang.TabIndex = 3;
            lblTenCuaHang.Text = "QUẢN LÝ CỬA HÀNG ĐỒ CHƠI";
            lblTenCuaHang.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(31, 41, 55);
            pnlMenu.Controls.Add(btnDangXuat);
            pnlMenu.Controls.Add(btnHoaDon);
            pnlMenu.Controls.Add(btnKhachHang);
            pnlMenu.Controls.Add(btnLoaiSanPham);
            pnlMenu.Controls.Add(btnSanPham);
            pnlMenu.Controls.Add(button1);
            pnlMenu.Location = new Point(1, 61);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(188, 636);
            pnlMenu.TabIndex = 1;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.Firebrick;
            btnDangXuat.FlatStyle = FlatStyle.Popup;
            btnDangXuat.ForeColor = SystemColors.ButtonHighlight;
            btnDangXuat.Location = new Point(-2, 595);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(191, 38);
            btnDangXuat.TabIndex = 5;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.FlatStyle = FlatStyle.Popup;
            btnHoaDon.Font = new Font("SF Pro Text", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHoaDon.ForeColor = Color.White;
            btnHoaDon.Image = (Image)resources.GetObject("btnHoaDon.Image");
            btnHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnHoaDon.Location = new Point(1, 230);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(188, 61);
            btnHoaDon.TabIndex = 4;
            btnHoaDon.Text = "Hóa Đơn";
            btnHoaDon.TextAlign = ContentAlignment.MiddleLeft;
            btnHoaDon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHoaDon.UseVisualStyleBackColor = true;
            btnHoaDon.Click += btnHoaDon_Click_1;
            // 
            // btnKhachHang
            // 
            btnKhachHang.FlatStyle = FlatStyle.Popup;
            btnKhachHang.Font = new Font("SF Pro Text", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKhachHang.ForeColor = Color.White;
            btnKhachHang.Image = (Image)resources.GetObject("btnKhachHang.Image");
            btnKhachHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.Location = new Point(-3, 172);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(191, 61);
            btnKhachHang.TabIndex = 3;
            btnKhachHang.Text = "Khách Hàng";
            btnKhachHang.TextAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKhachHang.UseVisualStyleBackColor = true;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // btnLoaiSanPham
            // 
            btnLoaiSanPham.FlatStyle = FlatStyle.Popup;
            btnLoaiSanPham.Font = new Font("SF Pro Text", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoaiSanPham.ForeColor = Color.White;
            btnLoaiSanPham.Image = (Image)resources.GetObject("btnLoaiSanPham.Image");
            btnLoaiSanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btnLoaiSanPham.Location = new Point(0, 115);
            btnLoaiSanPham.Name = "btnLoaiSanPham";
            btnLoaiSanPham.Size = new Size(188, 61);
            btnLoaiSanPham.TabIndex = 2;
            btnLoaiSanPham.Text = "Loại Sản Phẩm";
            btnLoaiSanPham.TextAlign = ContentAlignment.MiddleLeft;
            btnLoaiSanPham.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLoaiSanPham.UseVisualStyleBackColor = true;
            btnLoaiSanPham.Click += btnLoaiSanPham_Click;
            // 
            // btnSanPham
            // 
            btnSanPham.FlatStyle = FlatStyle.Popup;
            btnSanPham.Font = new Font("SF Pro Text", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSanPham.ForeColor = SystemColors.ControlLightLight;
            btnSanPham.Image = (Image)resources.GetObject("btnSanPham.Image");
            btnSanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btnSanPham.Location = new Point(0, 57);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Size = new Size(188, 61);
            btnSanPham.TabIndex = 1;
            btnSanPham.Text = "Sản Phẩm";
            btnSanPham.TextAlign = ContentAlignment.MiddleLeft;
            btnSanPham.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSanPham.UseVisualStyleBackColor = true;
            btnSanPham.Click += btnSanPham_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(31, 41, 55);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("SF Pro Text", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(188, 59);
            button1.TabIndex = 0;
            button1.Text = "Tổng quan";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnDashboard_Click;
            // 
            // pnlContent
            // 
            pnlContent.AllowDrop = true;
            pnlContent.BackColor = Color.FromArgb(243, 244, 246);
            pnlContent.Controls.Add(pictureBox1);
            pnlContent.ForeColor = SystemColors.ControlText;
            pnlContent.Location = new Point(195, 61);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(827, 636);
            pnlContent.TabIndex = 2;
            pnlContent.Paint += pnlContent_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-38, -15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(900, 687);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 694);
            Controls.Add(pnlContent);
            Controls.Add(pnlMenu);
            Controls.Add(pnlHeader);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlMenu.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Panel pnlMenu;
        private Label lblNguoiDung;
        private Button button1;
        private Button btnLoaiSanPham;
        private Button btnSanPham;
        private Button btnKhachHang;
        private Button btnDangXuat;
        private Button btnHoaDon;
        private Label lblTenCuaHang;
        private Panel pnlContent;
        private PictureBox pictureBox1;
    }
}