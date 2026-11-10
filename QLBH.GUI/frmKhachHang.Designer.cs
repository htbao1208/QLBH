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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblTieuDe.Location = new Point(73, 12);
            lblTieuDe.Margin = new Padding(4, 0, 4, 0);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(700, 53);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "QUẢN LÝ KHÁCH HÀNG";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(lblMaKH);
            grpThongTin.Controls.Add(lblTenKH);
            grpThongTin.Controls.Add(lblDiaChi);
            grpThongTin.Controls.Add(lblDienThoai);
            grpThongTin.Controls.Add(lblPhai);
            grpThongTin.Controls.Add(txtMaKH);
            grpThongTin.Controls.Add(txtTenKH);
            grpThongTin.Controls.Add(btnLoad);
            grpThongTin.Controls.Add(txtDiaChi);
            grpThongTin.Controls.Add(txtDienThoai);
            grpThongTin.Controls.Add(rdoNam);
            grpThongTin.Controls.Add(rdoNu);
            grpThongTin.Controls.Add(btnInsert);
            grpThongTin.Controls.Add(btnUpdate);
            grpThongTin.Controls.Add(btnDelete);
            grpThongTin.Controls.Add(btnReset);
            grpThongTin.Location = new Point(17, 73);
            grpThongTin.Margin = new Padding(4);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Padding = new Padding(4);
            grpThongTin.Size = new Size(800, 224);
            grpThongTin.TabIndex = 1;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin khách hàng";
            // 
            // lblMaKH
            // 
            lblMaKH.AutoSize = true;
            lblMaKH.Location = new Point(9, 36);
            lblMaKH.Margin = new Padding(4, 0, 4, 0);
            lblMaKH.Name = "lblMaKH";
            lblMaKH.Size = new Size(60, 19);
            lblMaKH.TabIndex = 0;
            lblMaKH.Text = "Mã KH";
            // 
            // lblTenKH
            // 
            lblTenKH.AutoSize = true;
            lblTenKH.Location = new Point(373, 36);
            lblTenKH.Margin = new Padding(4, 0, 4, 0);
            lblTenKH.Name = "lblTenKH";
            lblTenKH.Size = new Size(64, 19);
            lblTenKH.TabIndex = 1;
            lblTenKH.Text = "Tên KH";
            lblTenKH.Click += lblTenKH_Click;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new Point(8, 81);
            lblDiaChi.Margin = new Padding(4, 0, 4, 0);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(61, 19);
            lblDiaChi.TabIndex = 2;
            lblDiaChi.Text = "Địa chỉ";
            // 
            // lblDienThoai
            // 
            lblDienThoai.AutoSize = true;
            lblDienThoai.Location = new Point(359, 83);
            lblDienThoai.Margin = new Padding(4, 0, 4, 0);
            lblDienThoai.Name = "lblDienThoai";
            lblDienThoai.Size = new Size(85, 19);
            lblDienThoai.TabIndex = 3;
            lblDienThoai.Text = "Điện thoại";
            // 
            // lblPhai
            // 
            lblPhai.AutoSize = true;
            lblPhai.Location = new Point(28, 125);
            lblPhai.Margin = new Padding(4, 0, 4, 0);
            lblPhai.Name = "lblPhai";
            lblPhai.Size = new Size(41, 19);
            lblPhai.TabIndex = 4;
            lblPhai.Text = "Phái";
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(76, 33);
            txtMaKH.Margin = new Padding(4);
            txtMaKH.MaxLength = 10;
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(265, 27);
            txtMaKH.TabIndex = 5;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(453, 33);
            txtTenKH.Margin = new Padding(4);
            txtTenKH.MaxLength = 50;
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(325, 27);
            txtTenKH.TabIndex = 6;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(76, 75);
            txtDiaChi.Margin = new Padding(4);
            txtDiaChi.MaxLength = 50;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(265, 27);
            txtDiaChi.TabIndex = 7;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(453, 78);
            txtDienThoai.Margin = new Padding(4);
            txtDienThoai.MaxLength = 15;
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(325, 27);
            txtDienThoai.TabIndex = 8;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(80, 125);
            rdoNam.Margin = new Padding(4);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(65, 23);
            rdoNam.TabIndex = 9;
            rdoNam.Text = "Nam";
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(153, 125);
            rdoNu.Margin = new Padding(4);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(52, 23);
            rdoNu.TabIndex = 10;
            rdoNu.Text = "Nữ";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(304, 156);
            btnInsert.Margin = new Padding(4);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(91, 43);
            btnInsert.TabIndex = 11;
            btnInsert.Text = "Thêm";
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(403, 156);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(89, 43);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Sửa";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(500, 156);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(78, 43);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(586, 156);
            btnReset.Margin = new Padding(4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(93, 43);
            btnReset.TabIndex = 14;
            btnReset.Text = "Làm mới";
            btnReset.Click += btnReset_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(687, 156);
            btnLoad.Margin = new Padding(4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(91, 43);
            btnLoad.TabIndex = 15;
            btnLoad.Text = "Tải lại";
            btnLoad.Click += btnLoad_Click;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new Point(17, 308);
            lblTimKiem.Margin = new Padding(4, 0, 4, 0);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(122, 19);
            lblTimKiem.TabIndex = 2;
            lblTimKiem.Text = "Tìm mã/tên KH";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(147, 305);
            txtTimKiem.Margin = new Padding(4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(501, 27);
            txtTimKiem.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(656, 305);
            btnSearch.Margin = new Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(161, 27);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Tìm";
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.AllowUserToDeleteRows = false;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvKhachHang.ColumnHeadersHeight = 29;
            dgvKhachHang.Location = new Point(17, 340);
            dgvKhachHang.Margin = new Padding(4);
            dgvKhachHang.MultiSelect = false;
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.ReadOnly = true;
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.Size = new Size(800, 283);
            dgvKhachHang.TabIndex = 5;
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;
            // 
            // lblThongTin
            // 
            lblThongTin.ForeColor = Color.Maroon;
            lblThongTin.Location = new Point(23, 750);
            lblThongTin.Margin = new Padding(4, 0, 4, 0);
            lblThongTin.Name = "lblThongTin";
            lblThongTin.Size = new Size(1123, 32);
            lblThongTin.TabIndex = 6;
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            ClientSize = new Size(827, 636);
            Controls.Add(lblTieuDe);
            Controls.Add(grpThongTin);
            Controls.Add(lblTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(btnSearch);
            Controls.Add(dgvKhachHang);
            Controls.Add(lblThongTin);
            Margin = new Padding(4);
            Name = "frmKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý khách hàng";
            Load += frmKhachHang_Load;
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
