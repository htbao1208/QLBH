namespace QLBH.GUI
{
    partial class frmSanPham
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboMaLoaiSP = new ComboBox();
            lbMaLoai = new Label();
            lbMaSP = new Label();
            lbTenSP = new Label();
            txtMaSP = new TextBox();
            txtTenSP = new TextBox();
            lbDVT = new Label();
            txtDVTinh = new TextBox();
            lbDonGia = new Label();
            nudDonGia = new NumericUpDown();
            groupBox1 = new GroupBox();
            btnLoad = new Button();
            btnSearch = new Button();
            txtTimKiem = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            btnReset = new Button();
            dgvSanPham = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudDonGia).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            SuspendLayout();
            // 
            // cboMaLoaiSP
            // 
            cboMaLoaiSP.FormattingEnabled = true;
            cboMaLoaiSP.Location = new Point(611, 70);
            cboMaLoaiSP.Name = "cboMaLoaiSP";
            cboMaLoaiSP.Size = new Size(154, 27);
            cboMaLoaiSP.TabIndex = 0;
            // 
            // lbMaLoai
            // 
            lbMaLoai.AutoSize = true;
            lbMaLoai.Location = new Point(537, 78);
            lbMaLoai.Name = "lbMaLoai";
            lbMaLoai.Size = new Size(68, 19);
            lbMaLoai.TabIndex = 1;
            lbMaLoai.Text = "Mã Loại";
            // 
            // lbMaSP
            // 
            lbMaSP.AutoSize = true;
            lbMaSP.Location = new Point(15, 31);
            lbMaSP.Name = "lbMaSP";
            lbMaSP.Size = new Size(57, 19);
            lbMaSP.TabIndex = 2;
            lbMaSP.Text = "Mã SP";
            // 
            // lbTenSP
            // 
            lbTenSP.AutoSize = true;
            lbTenSP.Location = new Point(312, 31);
            lbTenSP.Name = "lbTenSP";
            lbTenSP.Size = new Size(61, 19);
            lbTenSP.TabIndex = 3;
            lbTenSP.Text = "Tên SP";
            lbTenSP.Click += lbTenSP_Click;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(87, 26);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(198, 27);
            txtMaSP.TabIndex = 4;
            txtMaSP.TextChanged += txtMaSP_TextChanged;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(379, 26);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(386, 27);
            txtTenSP.TabIndex = 5;
            // 
            // lbDVT
            // 
            lbDVT.AutoSize = true;
            lbDVT.Location = new Point(15, 73);
            lbDVT.Name = "lbDVT";
            lbDVT.Size = new Size(42, 19);
            lbDVT.TabIndex = 6;
            lbDVT.Text = "ĐVT";
            // 
            // txtDVTinh
            // 
            txtDVTinh.Location = new Point(87, 70);
            txtDVTinh.Name = "txtDVTinh";
            txtDVTinh.Size = new Size(149, 27);
            txtDVTinh.TabIndex = 7;
            // 
            // lbDonGia
            // 
            lbDonGia.AutoSize = true;
            lbDonGia.Location = new Point(251, 78);
            lbDonGia.Name = "lbDonGia";
            lbDonGia.Size = new Size(69, 19);
            lbDonGia.TabIndex = 8;
            lbDonGia.Text = "Đơn Giá";
            // 
            // nudDonGia
            // 
            nudDonGia.Location = new Point(326, 70);
            nudDonGia.Name = "nudDonGia";
            nudDonGia.Size = new Size(193, 27);
            nudDonGia.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLoad);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnInsert);
            groupBox1.Controls.Add(cboMaLoaiSP);
            groupBox1.Controls.Add(lbMaLoai);
            groupBox1.Controls.Add(nudDonGia);
            groupBox1.Controls.Add(btnReset);
            groupBox1.Controls.Add(lbDonGia);
            groupBox1.Controls.Add(lbMaSP);
            groupBox1.Controls.Add(txtDVTinh);
            groupBox1.Controls.Add(txtMaSP);
            groupBox1.Controls.Add(lbDVT);
            groupBox1.Controls.Add(lbTenSP);
            groupBox1.Controls.Add(txtTenSP);
            groupBox1.Location = new Point(12, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 206);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Group Sản phẩm";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(419, 120);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(78, 27);
            btnLoad.TabIndex = 15;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(693, 163);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(78, 27);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(15, 163);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(672, 27);
            txtTimKiem.TabIndex = 13;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(335, 120);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(78, 27);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(251, 120);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(78, 27);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(171, 120);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(78, 27);
            btnInsert.TabIndex = 10;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(87, 120);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(78, 27);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // dgvSanPham
            // 
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Location = new Point(12, 279);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.Size = new Size(776, 338);
            dgvSanPham.TabIndex = 11;
            dgvSanPham.CellClick += dgvSanPham_CellClick_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Text Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(246, 22);
            label1.Name = "label1";
            label1.Size = new Size(297, 33);
            label1.TabIndex = 12;
            label1.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 629);
            Controls.Add(label1);
            Controls.Add(dgvSanPham);
            Controls.Add(groupBox1);
            Name = "frmSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sản Phẩm";
            Load += frmSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)nudDonGia).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        /*private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }*/

        #endregion

        private ComboBox cboMaLoaiSP;
        private Label lbMaLoai;
        private Label lbMaSP;
        private Label lbTenSP;
        private TextBox txtMaSP;
        private TextBox txtTenSP;
        private Label lbDVT;
        private TextBox txtDVTinh;
        private Label lbDonGia;
        private NumericUpDown nudDonGia;
        private GroupBox groupBox1;
        private Button btnReset;
        private Button btnSearch;
        private TextBox txtTimKiem;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private DataGridView dgvSanPham;
        private Button btnLoad;
        private Label label1;
    }
}
