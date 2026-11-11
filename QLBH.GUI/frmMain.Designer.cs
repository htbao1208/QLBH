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
            pnlHeader.SuspendLayout();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblNguoiDung);
            pnlHeader.Controls.Add(lblTenCuaHang);
            pnlHeader.ForeColor = SystemColors.ButtonHighlight;
            pnlHeader.Location = new Point(1, 2);
            pnlHeader.Margin = new Padding(2, 3, 2, 3);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(817, 61);
            pnlHeader.TabIndex = 0;
            // 
            // lblNguoiDung
            // 
            lblNguoiDung.AutoSize = true;
            lblNguoiDung.ForeColor = Color.Black;
            lblNguoiDung.Location = new Point(710, 22);
            lblNguoiDung.Margin = new Padding(2, 0, 2, 0);
            lblNguoiDung.Name = "lblNguoiDung";
            lblNguoiDung.Size = new Size(97, 20);
            lblNguoiDung.TabIndex = 4;
            lblNguoiDung.Text = "Xin chào: ----";
            // 
            // lblTenCuaHang
            // 
            lblTenCuaHang.AutoSize = true;
            lblTenCuaHang.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenCuaHang.ForeColor = Color.FromArgb(31, 41, 55);
            lblTenCuaHang.ImageAlign = ContentAlignment.MiddleLeft;
            lblTenCuaHang.Location = new Point(9, 15);
            lblTenCuaHang.Margin = new Padding(2, 0, 2, 0);
            lblTenCuaHang.Name = "lblTenCuaHang";
            lblTenCuaHang.Size = new Size(377, 29);
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
            pnlMenu.Location = new Point(1, 64);
            pnlMenu.Margin = new Padding(2, 3, 2, 3);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(150, 669);
            pnlMenu.TabIndex = 1;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.Firebrick;
            btnDangXuat.FlatStyle = FlatStyle.Popup;
            btnDangXuat.ForeColor = SystemColors.ButtonHighlight;
            btnDangXuat.Location = new Point(-2, 626);
            btnDangXuat.Margin = new Padding(2, 3, 2, 3);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(153, 40);
            btnDangXuat.TabIndex = 5;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.FlatStyle = FlatStyle.Popup;
            btnHoaDon.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHoaDon.ForeColor = Color.White;
            btnHoaDon.Image = (Image)resources.GetObject("btnHoaDon.Image");
            btnHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnHoaDon.Location = new Point(1, 242);
            btnHoaDon.Margin = new Padding(2, 3, 2, 3);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(150, 64);
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
            btnKhachHang.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKhachHang.ForeColor = Color.White;
            btnKhachHang.Image = (Image)resources.GetObject("btnKhachHang.Image");
            btnKhachHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.Location = new Point(-2, 181);
            btnKhachHang.Margin = new Padding(2, 3, 2, 3);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(153, 64);
            btnKhachHang.TabIndex = 3;
            btnKhachHang.Text = "Khách Hàng";
            btnKhachHang.TextAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKhachHang.UseVisualStyleBackColor = true;
            // 
            // btnLoaiSanPham
            // 
            btnLoaiSanPham.FlatStyle = FlatStyle.Popup;
            btnLoaiSanPham.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoaiSanPham.ForeColor = Color.White;
            btnLoaiSanPham.Image = (Image)resources.GetObject("btnLoaiSanPham.Image");
            btnLoaiSanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btnLoaiSanPham.Location = new Point(0, 121);
            btnLoaiSanPham.Margin = new Padding(2, 3, 2, 3);
            btnLoaiSanPham.Name = "btnLoaiSanPham";
            btnLoaiSanPham.Size = new Size(150, 64);
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
            btnSanPham.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSanPham.ForeColor = SystemColors.ControlLightLight;
            btnSanPham.Image = (Image)resources.GetObject("btnSanPham.Image");
            btnSanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btnSanPham.Location = new Point(0, 60);
            btnSanPham.Margin = new Padding(2, 3, 2, 3);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Size = new Size(150, 64);
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
            button1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(150, 62);
            button1.TabIndex = 0;
            button1.Text = "Dashboard";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // pnlContent
            // 
            pnlContent.AllowDrop = true;
            pnlContent.BackColor = Color.FromArgb(243, 244, 246);
            pnlContent.ForeColor = SystemColors.ControlText;
            pnlContent.Location = new Point(156, 64);
            pnlContent.Margin = new Padding(2, 3, 2, 3);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(662, 669);
            pnlContent.TabIndex = 2;
            pnlContent.Paint += pnlContent_Paint;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 731);
            Controls.Add(pnlContent);
            Controls.Add(pnlMenu);
            Controls.Add(pnlHeader);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Panel pnlMenu;
        private Label lblNguoiDung;
        private Panel pnlContent;
        private Button button1;
        private Button btnLoaiSanPham;
        private Button btnSanPham;
        private Button btnKhachHang;
        private Button btnDangXuat;
        private Button btnHoaDon;
        private Label lblTenCuaHang;
    }
}