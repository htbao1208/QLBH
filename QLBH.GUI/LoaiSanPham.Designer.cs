namespace QLBH.GUI
{
    partial class frmLoaiSanPham
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            lblThongTin = new Label();
            btnSearch = new Button();
            txtTimKiem = new TextBox();
            lbTimKiem = new Label();
            btnLoad = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            btnReset = new Button();
            txtTenLoai = new TextBox();
            lbTenLoai = new Label();
            txtMaLoai = new TextBox();
            lbMaLoai = new Label();
            dgvLoaiSanPham = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiSanPham).BeginInit();
            SuspendLayout();
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Text Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(210, 22);
            label1.Name = "label1";
            label1.Size = new Size(380, 33);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ LOẠI SẢN PHẨM";
            //
            // groupBox1
            //
            groupBox1.Controls.Add(lblThongTin);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(lbTimKiem);
            groupBox1.Controls.Add(btnLoad);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnInsert);
            groupBox1.Controls.Add(btnReset);
            groupBox1.Controls.Add(txtTenLoai);
            groupBox1.Controls.Add(lbTenLoai);
            groupBox1.Controls.Add(txtMaLoai);
            groupBox1.Controls.Add(lbMaLoai);
            groupBox1.Location = new Point(12, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 206);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Group Loại sản phẩm";
            //
            // lblThongTin
            //
            lblThongTin.AutoSize = true;
            lblThongTin.ForeColor = Color.DimGray;
            lblThongTin.Location = new Point(15, 172);
            lblThongTin.Name = "lblThongTin";
            lblThongTin.Size = new Size(0, 19);
            lblThongTin.TabIndex = 12;
            //
            // btnSearch
            //
            btnSearch.Location = new Point(689, 122);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(78, 30);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            //
            // txtTimKiem
            //
            txtTimKiem.Location = new Point(100, 124);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(580, 27);
            txtTimKiem.TabIndex = 10;
            //
            // lbTimKiem
            //
            lbTimKiem.AutoSize = true;
            lbTimKiem.Location = new Point(15, 128);
            lbTimKiem.Name = "lbTimKiem";
            lbTimKiem.Size = new Size(76, 19);
            lbTimKiem.TabIndex = 9;
            lbTimKiem.Text = "Tìm kiếm";
            //
            // btnLoad
            //
            btnLoad.Location = new Point(436, 72);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(78, 30);
            btnLoad.TabIndex = 8;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            //
            // btnDelete
            //
            btnDelete.Location = new Point(352, 72);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(78, 30);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            //
            // btnUpdate
            //
            btnUpdate.Location = new Point(268, 72);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(78, 30);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            //
            // btnInsert
            //
            btnInsert.Location = new Point(184, 72);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(78, 30);
            btnInsert.TabIndex = 5;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            //
            // btnReset
            //
            btnReset.Location = new Point(100, 72);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(78, 30);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            //
            // txtTenLoai
            //
            txtTenLoai.Location = new Point(412, 26);
            txtTenLoai.MaxLength = 50;
            txtTenLoai.Name = "txtTenLoai";
            txtTenLoai.Size = new Size(355, 27);
            txtTenLoai.TabIndex = 3;
            //
            // lbTenLoai
            //
            lbTenLoai.AutoSize = true;
            lbTenLoai.Location = new Point(330, 31);
            lbTenLoai.Name = "lbTenLoai";
            lbTenLoai.Size = new Size(71, 19);
            lbTenLoai.TabIndex = 2;
            lbTenLoai.Text = "Tên Loại";
            //
            // txtMaLoai
            //
            txtMaLoai.Location = new Point(100, 26);
            txtMaLoai.MaxLength = 10;
            txtMaLoai.Name = "txtMaLoai";
            txtMaLoai.Size = new Size(200, 27);
            txtMaLoai.TabIndex = 1;
            //
            // lbMaLoai
            //
            lbMaLoai.AutoSize = true;
            lbMaLoai.Location = new Point(15, 31);
            lbMaLoai.Name = "lbMaLoai";
            lbMaLoai.Size = new Size(68, 19);
            lbMaLoai.TabIndex = 0;
            lbMaLoai.Text = "Mã Loại";
            //
            // dgvLoaiSanPham
            //
            dgvLoaiSanPham.AllowUserToAddRows = false;
            dgvLoaiSanPham.AllowUserToDeleteRows = false;
            dgvLoaiSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoaiSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiSanPham.Location = new Point(12, 279);
            dgvLoaiSanPham.MultiSelect = false;
            dgvLoaiSanPham.Name = "dgvLoaiSanPham";
            dgvLoaiSanPham.ReadOnly = true;
            dgvLoaiSanPham.RowHeadersWidth = 51;
            dgvLoaiSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLoaiSanPham.Size = new Size(776, 338);
            dgvLoaiSanPham.TabIndex = 2;
            //
            // frmLoaiSanPham
            //
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 629);
            Controls.Add(dgvLoaiSanPham);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmLoaiSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loại Sản Phẩm";
            Load += frmLoaiSanPham_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiSanPham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label lblThongTin;
        private Button btnSearch;
        private TextBox txtTimKiem;
        private Label lbTimKiem;
        private Button btnLoad;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private Button btnReset;
        private TextBox txtTenLoai;
        private Label lbTenLoai;
        private TextBox txtMaLoai;
        private Label lbMaLoai;
        private DataGridView dgvLoaiSanPham;
    }
}
