namespace QLBH.GUI
{
    partial class frmHoaDon
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing) components?.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            layout = new TableLayoutPanel();
            danhSach = new TableLayoutPanel();
            lblDanhSachHoaDon = new Label();
            cboDanhSachHoaDon = new ComboBox();
            lblTieuDe = new Label();
            grpThongTin = new GroupBox();
            thongTin = new TableLayoutPanel();
            lblMaHD = new Label();
            txtMaHD = new TextBox();
            lblNgayHD = new Label();
            dtpNgayHD = new DateTimePicker();
            lblKhachHang = new Label();
            cboKhachHang = new ComboBox();
            lblNhanVien = new Label();
            cboNhanVien = new ComboBox();
            grpSanPham = new GroupBox();
            sanPham = new TableLayoutPanel();
            lblSanPham = new Label();
            cboSanPham = new ComboBox();
            lblSoLuong = new Label();
            nudSoLuong = new NumericUpDown();
            lblGiaBan = new Label();
            txtGiaBan = new TextBox();
            btnThemDong = new Button();
            btnXoaDong = new Button();
            dgvChiTiet = new DataGridView();
            colMaSP = new DataGridViewTextBoxColumn();
            colTenSP = new DataGridViewTextBoxColumn();
            colDVTinh = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            colGiaBan = new DataGridViewTextBoxColumn();
            colThanhTien = new DataGridViewTextBoxColumn();
            footer = new TableLayoutPanel();
            lblTongTien = new Label();
            btnLuu = new Button();
            btnLamTrong = new Button();
            btnCapNhat = new Button();
            btnXoaHoaDon = new Button();
            layout.SuspendLayout();
            danhSach.SuspendLayout();
            grpThongTin.SuspendLayout();
            thongTin.SuspendLayout();
            grpSanPham.SuspendLayout();
            sanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            footer.SuspendLayout();
            SuspendLayout();
            // 
            // layout
            // 
            layout.ColumnCount = 1;
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layout.Controls.Add(danhSach, 0, 0);
            layout.Controls.Add(lblTieuDe, 0, 1);
            layout.Controls.Add(grpThongTin, 0, 2);
            layout.Controls.Add(grpSanPham, 0, 3);
            layout.Controls.Add(dgvChiTiet, 0, 4);
            layout.Controls.Add(footer, 0, 5);
            layout.Dock = DockStyle.Fill;
            layout.Location = new Point(0, 0);
            layout.Name = "layout";
            layout.Padding = new Padding(12);
            layout.RowCount = 6;
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 108F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 140F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 144F));
            layout.Size = new Size(827, 636);
            layout.TabIndex = 0;
            // 
            // danhSach
            // 
            danhSach.ColumnCount = 2;
            danhSach.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 155F));
            danhSach.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            danhSach.Controls.Add(lblDanhSachHoaDon, 0, 0);
            danhSach.Controls.Add(cboDanhSachHoaDon, 1, 0);
            danhSach.Dock = DockStyle.Fill;
            danhSach.Location = new Point(12, 12);
            danhSach.Margin = new Padding(0);
            danhSach.Name = "danhSach";
            danhSach.RowCount = 1;
            danhSach.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            danhSach.Size = new Size(803, 34);
            danhSach.TabIndex = 0;
            // 
            // lblDanhSachHoaDon
            // 
            lblDanhSachHoaDon.Dock = DockStyle.Fill;
            lblDanhSachHoaDon.Location = new Point(3, 0);
            lblDanhSachHoaDon.Name = "lblDanhSachHoaDon";
            lblDanhSachHoaDon.Size = new Size(149, 34);
            lblDanhSachHoaDon.TabIndex = 0;
            lblDanhSachHoaDon.Text = "Danh sách hóa đơn";
            lblDanhSachHoaDon.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboDanhSachHoaDon
            // 
            cboDanhSachHoaDon.Dock = DockStyle.Fill;
            cboDanhSachHoaDon.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDanhSachHoaDon.Location = new Point(158, 3);
            cboDanhSachHoaDon.Name = "cboDanhSachHoaDon";
            cboDanhSachHoaDon.Size = new Size(642, 31);
            cboDanhSachHoaDon.TabIndex = 1;
            cboDanhSachHoaDon.SelectionChangeCommitted += cboDanhSachHoaDon_SelectionChangeCommitted;
            // 
            // lblTieuDe
            // 
            lblTieuDe.Dock = DockStyle.Fill;
            lblTieuDe.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(31, 41, 55);
            lblTieuDe.Location = new Point(15, 46);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(797, 36);
            lblTieuDe.TabIndex = 1;
            lblTieuDe.Text = "LẬP HÓA ĐƠN";
            lblTieuDe.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(thongTin);
            grpThongTin.Dock = DockStyle.Fill;
            grpThongTin.Location = new Point(15, 85);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(797, 102);
            grpThongTin.TabIndex = 2;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin hóa đơn";
            // 
            // thongTin
            // 
            thongTin.ColumnCount = 4;
            thongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
            thongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            thongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
            thongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            thongTin.Controls.Add(lblMaHD, 0, 0);
            thongTin.Controls.Add(txtMaHD, 1, 0);
            thongTin.Controls.Add(lblNgayHD, 2, 0);
            thongTin.Controls.Add(dtpNgayHD, 3, 0);
            thongTin.Controls.Add(lblKhachHang, 0, 1);
            thongTin.Controls.Add(cboKhachHang, 1, 1);
            thongTin.Controls.Add(lblNhanVien, 2, 1);
            thongTin.Controls.Add(cboNhanVien, 3, 1);
            thongTin.Dock = DockStyle.Fill;
            thongTin.Location = new Point(3, 26);
            thongTin.Name = "thongTin";
            thongTin.Padding = new Padding(6);
            thongTin.RowCount = 2;
            thongTin.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            thongTin.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            thongTin.Size = new Size(791, 73);
            thongTin.TabIndex = 0;
            // 
            // lblMaHD
            // 
            lblMaHD.Dock = DockStyle.Fill;
            lblMaHD.Location = new Point(9, 6);
            lblMaHD.Name = "lblMaHD";
            lblMaHD.Size = new Size(99, 30);
            lblMaHD.TabIndex = 0;
            lblMaHD.Text = "Mã hóa đơn";
            lblMaHD.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtMaHD
            // 
            txtMaHD.Dock = DockStyle.Fill;
            txtMaHD.Location = new Point(114, 9);
            txtMaHD.MaxLength = 10;
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(278, 30);
            txtMaHD.TabIndex = 0;
            // 
            // lblNgayHD
            // 
            lblNgayHD.Dock = DockStyle.Fill;
            lblNgayHD.Location = new Point(398, 6);
            lblNgayHD.Name = "lblNgayHD";
            lblNgayHD.Size = new Size(99, 30);
            lblNgayHD.TabIndex = 1;
            lblNgayHD.Text = "Ngày hóa đơn";
            lblNgayHD.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpNgayHD
            // 
            dtpNgayHD.CustomFormat = "dd/MM/yyyy";
            dtpNgayHD.Dock = DockStyle.Fill;
            dtpNgayHD.Format = DateTimePickerFormat.Custom;
            dtpNgayHD.Location = new Point(503, 9);
            dtpNgayHD.Name = "dtpNgayHD";
            dtpNgayHD.Size = new Size(279, 30);
            dtpNgayHD.TabIndex = 1;
            // 
            // lblKhachHang
            // 
            lblKhachHang.Dock = DockStyle.Fill;
            lblKhachHang.Location = new Point(9, 36);
            lblKhachHang.Name = "lblKhachHang";
            lblKhachHang.Size = new Size(99, 31);
            lblKhachHang.TabIndex = 2;
            lblKhachHang.Text = "Khách hàng";
            lblKhachHang.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboKhachHang
            // 
            cboKhachHang.Dock = DockStyle.Fill;
            cboKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhachHang.DropDownWidth = 350;
            cboKhachHang.Location = new Point(114, 39);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(278, 31);
            cboKhachHang.TabIndex = 2;
            // 
            // lblNhanVien
            // 
            lblNhanVien.Dock = DockStyle.Fill;
            lblNhanVien.Location = new Point(398, 36);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(99, 31);
            lblNhanVien.TabIndex = 3;
            lblNhanVien.Text = "Nhân viên";
            lblNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboNhanVien
            // 
            cboNhanVien.Dock = DockStyle.Fill;
            cboNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhanVien.DropDownWidth = 300;
            cboNhanVien.Location = new Point(503, 39);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(279, 31);
            cboNhanVien.TabIndex = 3;
            // 
            // grpSanPham
            // 
            grpSanPham.Controls.Add(sanPham);
            grpSanPham.Dock = DockStyle.Fill;
            grpSanPham.Location = new Point(15, 193);
            grpSanPham.Name = "grpSanPham";
            grpSanPham.Size = new Size(797, 134);
            grpSanPham.TabIndex = 3;
            grpSanPham.TabStop = false;
            grpSanPham.Text = "Thêm sản phẩm vào hóa đơn";
            // 
            // sanPham
            // 
            sanPham.ColumnCount = 4;
            sanPham.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
            sanPham.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            sanPham.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
            sanPham.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            sanPham.Controls.Add(lblSanPham, 0, 0);
            sanPham.Controls.Add(cboSanPham, 1, 0);
            sanPham.Controls.Add(lblSoLuong, 0, 1);
            sanPham.Controls.Add(nudSoLuong, 1, 1);
            sanPham.Controls.Add(lblGiaBan, 2, 1);
            sanPham.Controls.Add(txtGiaBan, 3, 1);
            sanPham.Controls.Add(btnThemDong, 1, 2);
            sanPham.Controls.Add(btnXoaDong, 3, 2);
            sanPham.Dock = DockStyle.Fill;
            sanPham.Location = new Point(3, 26);
            sanPham.Name = "sanPham";
            sanPham.Padding = new Padding(6);
            sanPham.RowCount = 3;
            sanPham.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            sanPham.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            sanPham.RowStyles.Add(new RowStyle(SizeType.Percent, 33.34F));
            sanPham.Size = new Size(791, 105);
            sanPham.TabIndex = 0;
            // 
            // lblSanPham
            // 
            lblSanPham.Dock = DockStyle.Fill;
            lblSanPham.Location = new Point(9, 6);
            lblSanPham.Name = "lblSanPham";
            lblSanPham.Size = new Size(99, 30);
            lblSanPham.TabIndex = 0;
            lblSanPham.Text = "Sản phẩm";
            lblSanPham.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboSanPham
            // 
            sanPham.SetColumnSpan(cboSanPham, 3);
            cboSanPham.Dock = DockStyle.Fill;
            cboSanPham.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSanPham.Location = new Point(114, 9);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(668, 31);
            cboSanPham.TabIndex = 0;
            cboSanPham.SelectedIndexChanged += cboSanPham_SelectedIndexChanged;
            // 
            // lblSoLuong
            // 
            lblSoLuong.Dock = DockStyle.Fill;
            lblSoLuong.Location = new Point(9, 36);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(99, 30);
            lblSoLuong.TabIndex = 1;
            lblSoLuong.Text = "Số lượng";
            lblSoLuong.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nudSoLuong
            // 
            nudSoLuong.Dock = DockStyle.Fill;
            nudSoLuong.Location = new Point(114, 39);
            nudSoLuong.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(278, 30);
            nudSoLuong.TabIndex = 1;
            nudSoLuong.ThousandsSeparator = true;
            nudSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblGiaBan
            // 
            lblGiaBan.Dock = DockStyle.Fill;
            lblGiaBan.Location = new Point(398, 36);
            lblGiaBan.Name = "lblGiaBan";
            lblGiaBan.Size = new Size(99, 30);
            lblGiaBan.TabIndex = 2;
            lblGiaBan.Text = "Giá bán (đ)";
            lblGiaBan.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Dock = DockStyle.Fill;
            txtGiaBan.Location = new Point(503, 39);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.ReadOnly = true;
            txtGiaBan.Size = new Size(279, 30);
            txtGiaBan.TabIndex = 3;
            txtGiaBan.TabStop = false;
            txtGiaBan.TextAlign = HorizontalAlignment.Right;
            // 
            // btnThemDong
            // 
            btnThemDong.Dock = DockStyle.Fill;
            btnThemDong.Location = new Point(114, 69);
            btnThemDong.Name = "btnThemDong";
            btnThemDong.Size = new Size(278, 27);
            btnThemDong.TabIndex = 2;
            btnThemDong.Text = "Thêm dòng";
            btnThemDong.Click += btnThemDong_Click;
            // 
            // btnXoaDong
            // 
            btnXoaDong.Dock = DockStyle.Fill;
            btnXoaDong.Location = new Point(503, 69);
            btnXoaDong.Name = "btnXoaDong";
            btnXoaDong.Size = new Size(279, 27);
            btnXoaDong.TabIndex = 3;
            btnXoaDong.Text = "Xóa dòng";
            btnXoaDong.Click += btnXoaDong_Click;
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.AllowUserToAddRows = false;
            dgvChiTiet.AllowUserToDeleteRows = false;
            dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTiet.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvChiTiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvChiTiet.ColumnHeadersHeight = 29;
            dgvChiTiet.Columns.AddRange(new DataGridViewColumn[] { colMaSP, colTenSP, colDVTinh, colSoLuong, colGiaBan, colThanhTien });
            dgvChiTiet.Dock = DockStyle.Fill;
            dgvChiTiet.Location = new Point(15, 333);
            dgvChiTiet.MultiSelect = false;
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.RowHeadersVisible = false;
            dgvChiTiet.RowHeadersWidth = 51;
            dgvChiTiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTiet.Size = new Size(797, 144);
            dgvChiTiet.TabIndex = 4;
            dgvChiTiet.CellEndEdit += dgvChiTiet_CellEndEdit;
            dgvChiTiet.CellValidating += dgvChiTiet_CellValidating;
            // 
            // colMaSP
            // 
            colMaSP.DataPropertyName = "MaSP";
            colMaSP.FillWeight = 65F;
            colMaSP.HeaderText = "Mã SP";
            colMaSP.MinimumWidth = 6;
            colMaSP.Name = "colMaSP";
            colMaSP.ReadOnly = true;
            // 
            // colTenSP
            // 
            colTenSP.DataPropertyName = "TenSP";
            colTenSP.FillWeight = 180F;
            colTenSP.HeaderText = "Tên sản phẩm";
            colTenSP.MinimumWidth = 6;
            colTenSP.Name = "colTenSP";
            colTenSP.ReadOnly = true;
            // 
            // colDVTinh
            // 
            colDVTinh.DataPropertyName = "DVTinh";
            colDVTinh.FillWeight = 70F;
            colDVTinh.HeaderText = "Đơn vị tính";
            colDVTinh.MinimumWidth = 6;
            colDVTinh.Name = "colDVTinh";
            colDVTinh.ReadOnly = true;
            // 
            // colSoLuong
            // 
            colSoLuong.DataPropertyName = "SoLuong";
            colSoLuong.FillWeight = 65F;
            colSoLuong.HeaderText = "Số lượng";
            colSoLuong.MinimumWidth = 6;
            colSoLuong.Name = "colSoLuong";
            // 
            // colGiaBan
            // 
            colGiaBan.DataPropertyName = "GiaBan";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            colGiaBan.DefaultCellStyle = dataGridViewCellStyle2;
            colGiaBan.HeaderText = "Giá bán";
            colGiaBan.MinimumWidth = 6;
            colGiaBan.Name = "colGiaBan";
            colGiaBan.ReadOnly = true;
            // 
            // colThanhTien
            // 
            colThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            colThanhTien.DefaultCellStyle = dataGridViewCellStyle3;
            colThanhTien.HeaderText = "Thành tiền";
            colThanhTien.MinimumWidth = 6;
            colThanhTien.Name = "colThanhTien";
            colThanhTien.ReadOnly = true;
            // 
            // footer
            // 
            footer.ColumnCount = 2;
            footer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            footer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            footer.Controls.Add(lblTongTien, 0, 0);
            footer.Controls.Add(btnLuu, 1, 0);
            footer.Controls.Add(btnLamTrong, 1, 1);
            footer.Controls.Add(btnCapNhat, 1, 2);
            footer.Controls.Add(btnXoaHoaDon, 1, 3);
            footer.Dock = DockStyle.Fill;
            footer.Location = new Point(15, 483);
            footer.Name = "footer";
            footer.RowCount = 4;
            footer.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            footer.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            footer.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            footer.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            footer.Size = new Size(797, 138);
            footer.TabIndex = 5;
            // 
            // lblTongTien
            // 
            lblTongTien.Dock = DockStyle.Fill;
            lblTongTien.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTongTien.Location = new Point(3, 0);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Padding = new Padding(0, 10, 0, 0);
            footer.SetRowSpan(lblTongTien, 4);
            lblTongTien.Size = new Size(631, 138);
            lblTongTien.TabIndex = 0;
            lblTongTien.Text = "Tổng tiền: 0 đồng";
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(31, 41, 55);
            btnLuu.Dock = DockStyle.Fill;
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(640, 3);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(154, 28);
            btnLuu.TabIndex = 1;
            btnLuu.Text = "Lưu hóa đơn";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnLamTrong
            // 
            btnLamTrong.CausesValidation = false;
            btnLamTrong.Dock = DockStyle.Fill;
            btnLamTrong.Location = new Point(640, 37);
            btnLamTrong.Name = "btnLamTrong";
            btnLamTrong.Size = new Size(154, 28);
            btnLamTrong.TabIndex = 2;
            btnLamTrong.Text = "Làm trống";
            btnLamTrong.Click += btnLamTrong_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Dock = DockStyle.Fill;
            btnCapNhat.Enabled = false;
            btnCapNhat.Location = new Point(640, 71);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(154, 28);
            btnCapNhat.TabIndex = 3;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnXoaHoaDon
            // 
            btnXoaHoaDon.CausesValidation = false;
            btnXoaHoaDon.Dock = DockStyle.Fill;
            btnXoaHoaDon.Enabled = false;
            btnXoaHoaDon.Location = new Point(640, 105);
            btnXoaHoaDon.Name = "btnXoaHoaDon";
            btnXoaHoaDon.Size = new Size(154, 30);
            btnXoaHoaDon.TabIndex = 4;
            btnXoaHoaDon.Text = "Xóa";
            btnXoaHoaDon.Click += btnXoaHoaDon_Click;
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(243, 244, 246);
            ClientSize = new Size(827, 636);
            Controls.Add(layout);
            Font = new Font("Segoe UI", 10F);
            Name = "frmHoaDon";
            Text = "Hóa đơn";
            Load += frmHoaDon_Load;
            layout.ResumeLayout(false);
            danhSach.ResumeLayout(false);
            grpThongTin.ResumeLayout(false);
            thongTin.ResumeLayout(false);
            thongTin.PerformLayout();
            grpSanPham.ResumeLayout(false);
            sanPham.ResumeLayout(false);
            sanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            footer.ResumeLayout(false);
            ResumeLayout(false);
        }

        private TableLayoutPanel layout, thongTin, sanPham, footer, danhSach;
        private Label lblDanhSachHoaDon;
        private ComboBox cboDanhSachHoaDon;
        private GroupBox grpThongTin, grpSanPham;
        private Label lblTieuDe, lblMaHD, lblNgayHD, lblKhachHang, lblNhanVien;
        private Label lblSanPham, lblSoLuong, lblGiaBan, lblTongTien;
        private TextBox txtMaHD, txtGiaBan;
        private ComboBox cboKhachHang, cboNhanVien, cboSanPham;
        private DateTimePicker dtpNgayHD;
        private NumericUpDown nudSoLuong;
        private Button btnThemDong, btnXoaDong, btnLuu, btnLamTrong, btnCapNhat, btnXoaHoaDon;
        private DataGridView dgvChiTiet;
        private DataGridViewTextBoxColumn colMaSP, colTenSP, colDVTinh, colSoLuong, colGiaBan, colThanhTien;
    }
}
