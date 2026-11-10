namespace QLBH.GUI
{
    partial class frmKhachHang
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTieuDe;
        private GroupBox grpThongTin;
        private Label lblMaKH;
        private Label lblTenKH;
        private Label lblDiaChi;
        private Label lblDienThoai;
        private Label lblPhai;
        private TextBox txtMaKH;
        private TextBox txtTenKH;
        private TextBox txtDiaChi;
        private TextBox txtDienThoai;
        private RadioButton rdoNam;
        private RadioButton rdoNu;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnReset;
        private Button btnLoad;
        private Label lblTimKiem;
        private TextBox txtTimKiem;
        private Button btnSearch;
        private DataGridView dgvKhachHang;
        private Label lblThongTin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            grpThongTin = new GroupBox();
            lblMaKH = new Label();
            lblTenKH = new Label();
            lblDiaChi = new Label();
            lblDienThoai = new Label();
            lblPhai = new Label();
            txtMaKH = new TextBox();
            txtTenKH = new TextBox();
            txtDiaChi = new TextBox();
            txtDienThoai = new TextBox();
            rdoNam = new RadioButton();
            rdoNu = new RadioButton();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnReset = new Button();
            btnLoad = new Button();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            btnSearch = new Button();
            dgvKhachHang = new DataGridView();
            lblThongTin = new Label();
            grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();

            lblTieuDe.Text = "QUẢN LÝ KHÁCH HÀNG";
            lblTieuDe.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            lblTieuDe.Location = new Point(160, 12);
            lblTieuDe.Size = new Size(490, 42);
            lblTieuDe.Name = "lblTieuDe";

            grpThongTin.Text = "Thông tin khách hàng";
            grpThongTin.Location = new Point(12, 58);
            grpThongTin.Size = new Size(790, 225);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Controls.AddRange(new Control[] {
                lblMaKH, lblTenKH, lblDiaChi, lblDienThoai, lblPhai,
                txtMaKH, txtTenKH, txtDiaChi, txtDienThoai, rdoNam, rdoNu,
                btnInsert, btnUpdate, btnDelete, btnReset, btnLoad
            });

            lblMaKH.Text = "Mã KH";
            lblMaKH.Location = new Point(18, 32);
            lblMaKH.AutoSize = true;
            lblMaKH.Name = "lblMaKH";
            txtMaKH.Location = new Point(109, 28);
            txtMaKH.Size = new Size(248, 27);
            txtMaKH.MaxLength = 10;
            txtMaKH.Name = "txtMaKH";

            lblTenKH.Text = "Tên KH";
            lblTenKH.Location = new Point(383, 32);
            lblTenKH.AutoSize = true;
            lblTenKH.Name = "lblTenKH";
            txtTenKH.Location = new Point(471, 28);
            txtTenKH.Size = new Size(287, 27);
            txtTenKH.MaxLength = 50;
            txtTenKH.Name = "txtTenKH";

            lblDiaChi.Text = "Địa chỉ";
            lblDiaChi.Location = new Point(18, 75);
            lblDiaChi.AutoSize = true;
            lblDiaChi.Name = "lblDiaChi";
            txtDiaChi.Location = new Point(109, 71);
            txtDiaChi.Size = new Size(248, 27);
            txtDiaChi.MaxLength = 50;
            txtDiaChi.Name = "txtDiaChi";

            lblDienThoai.Text = "Điện thoại";
            lblDienThoai.Location = new Point(383, 75);
            lblDienThoai.AutoSize = true;
            lblDienThoai.Name = "lblDienThoai";
            txtDienThoai.Location = new Point(471, 71);
            txtDienThoai.Size = new Size(287, 27);
            txtDienThoai.MaxLength = 15;
            txtDienThoai.Name = "txtDienThoai";

            lblPhai.Text = "Phái";
            lblPhai.Location = new Point(18, 116);
            lblPhai.AutoSize = true;
            lblPhai.Name = "lblPhai";
            rdoNam.Text = "Nam";
            rdoNam.Location = new Point(111, 112);
            rdoNam.Name = "rdoNam";
            rdoNam.AutoSize = true;
            rdoNu.Text = "Nữ";
            rdoNu.Location = new Point(195, 112);
            rdoNu.Name = "rdoNu";
            rdoNu.AutoSize = true;

            btnInsert.Text = "Thêm";
            btnInsert.Location = new Point(56, 155);
            btnInsert.Size = new Size(116, 34);
            btnInsert.Name = "btnInsert";
            btnInsert.Click += btnInsert_Click;

            btnUpdate.Text = "Sửa";
            btnUpdate.Location = new Point(190, 155);
            btnUpdate.Size = new Size(116, 34);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Click += btnUpdate_Click;

            btnDelete.Text = "Xóa";
            btnDelete.Location = new Point(324, 155);
            btnDelete.Size = new Size(116, 34);
            btnDelete.Name = "btnDelete";
            btnDelete.Click += btnDelete_Click;

            btnReset.Text = "Làm mới";
            btnReset.Location = new Point(458, 155);
            btnReset.Size = new Size(116, 34);
            btnReset.Name = "btnReset";
            btnReset.Click += btnReset_Click;

            btnLoad.Text = "Tải lại";
            btnLoad.Location = new Point(592, 155);
            btnLoad.Size = new Size(116, 34);
            btnLoad.Name = "btnLoad";
            btnLoad.Click += btnLoad_Click;

            lblTimKiem.Text = "Tìm mã/tên KH";
            lblTimKiem.Location = new Point(16, 301);
            lblTimKiem.AutoSize = true;
            lblTimKiem.Name = "lblTimKiem";
            txtTimKiem.Location = new Point(148, 297);
            txtTimKiem.Size = new Size(525, 27);
            txtTimKiem.Name = "txtTimKiem";
            btnSearch.Text = "Tìm";
            btnSearch.Location = new Point(689, 295);
            btnSearch.Size = new Size(113, 31);
            btnSearch.Name = "btnSearch";
            btnSearch.Click += btnSearch_Click;

            dgvKhachHang.Location = new Point(12, 340);
            dgvKhachHang.Size = new Size(790, 244);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.AllowUserToDeleteRows = false;
            dgvKhachHang.ReadOnly = true;
            dgvKhachHang.MultiSelect = false;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;

            lblThongTin.Location = new Point(16, 592);
            lblThongTin.Size = new Size(786, 25);
            lblThongTin.ForeColor = Color.Maroon;
            lblThongTin.Name = "lblThongTin";

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            ClientSize = new Size(814, 623);
            Controls.Add(lblTieuDe);
            Controls.Add(grpThongTin);
            Controls.Add(lblTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(btnSearch);
            Controls.Add(dgvKhachHang);
            Controls.Add(lblThongTin);
            Name = "frmKhachHang";
            Text = "Quản lý khách hàng";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmKhachHang_Load;
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
