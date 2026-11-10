using QLBH.BLL;
using QLBH.DTO;

namespace QLBH.GUI
{
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();

            btnInsert.Click += btnInsert_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnReset.Click += btnReset_Click;
            btnSearch.Click += btnSearch_Click;
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            try
            {
                BLLLoaiSanPham bLLLoaiSanPham = new BLLLoaiSanPham();
                cboMaLoaiSP.DataSource = bLLLoaiSanPham.loadLoaiSanPham();
                cboMaLoaiSP.DisplayMember = "TenLoai";
                cboMaLoaiSP.ValueMember = "MaLoai";

                cboMaLoaiSP.SelectedIndex = -1;
                
                nudDonGia.Minimum = 0;
                nudDonGia.Maximum = 1_000_000_000;
                nudDonGia.ThousandsSeparator = true;
                nudDonGia.Value = 0;

                
                LoadDanhSachSanPham();
               /* LamTrongForm();*/
            }
            catch(Exception ex)
            {
                MessageBox.Show("Không thể tải dữ liệu khi mở Form: " + ex.Message);
            }
        }
        private BLLSanPham bllSanPham = new BLLSanPham();
        private bool dangSua = false;
        private bool KiemTraDuLieu()
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                MessageBox.Show("Mã sản phẩm không được để trống.");
                txtMaSP.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                MessageBox.Show("Tên sản phẩm không được để trống.");
                txtTenSP.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDVTinh.Text))
            {
                MessageBox.Show("Đơn vị tính không được để trống.");
                txtDVTinh.Focus();
                return false;
            }
            if (nudDonGia.Value <= 0)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 0.");
                nudDonGia.Focus();
                return false;
            }
            if (cboMaLoaiSP.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại sản phẩm.");
                cboMaLoaiSP.Focus();
                return false;
            }
            return true;
        }
        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {

        }
        private DTOSanPham LayDuLieuTuForm()
        {

            return new DTOSanPham
            {
                MaSP = txtMaSP.Text.Trim(),
                TenSP = txtTenSP.Text.Trim(),
                DVTinh = txtDVTinh.Text.Trim(),
                DonGia = Convert.ToInt32(nudDonGia.Value),
                MaLoai = cboMaLoaiSP.SelectedValue?.ToString() ?? string.Empty
            };
        }
        private void lbTenSP_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void LoadDanhSachSanPham()
        {
            try
            {
                BLLSanPham bLLSanPham = new BLLSanPham();
                dgvSanPham.DataSource = bLLSanPham.loadSanPham();
                dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvSanPham.MultiSelect = false;
                dgvSanPham.ReadOnly = true;
                dgvSanPham.AllowUserToAddRows = false;
                if (dgvSanPham.Columns.Contains("MaSP"))
                {
                    dgvSanPham.Columns["MaSP"].HeaderText = "Mã sản phẩm";
                }
                if (dgvSanPham.Columns.Contains("TenSP"))
                {
                    dgvSanPham.Columns["TenSP"].HeaderText = "Tên sản phẩm";
                }
                if (dgvSanPham.Columns.Contains("DVTinh"))
                {
                    dgvSanPham.Columns["DVTinh"].HeaderText = "Đơn vị tính";
                }
                if (dgvSanPham.Columns.Contains("DonGia"))
                {
                    dgvSanPham.Columns["DonGia"].HeaderText = "Đơn giá";
                }
                if (dgvSanPham.Columns.Contains("MaLoai"))
                {
                    dgvSanPham.Columns["MaLoai"].HeaderText = "Mã loại";
                }
                dgvSanPham.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            BLLSanPham bLLSanPham = new BLLSanPham();
            dgvSanPham.DataSource = bLLSanPham.loadSanPham();
        }



        private void dgvSanPham_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            /*txtMaSP.Text = dgvSanPham.CurrentRow.Cells[0].Value.ToString();
            txtTenSP.Text = dgvSanPham.CurrentRow.Cells[1].Value.ToString();
            txtDVTinh.Text = dgvSanPham.CurrentRow.Cells["DVTinh"].Value.ToString();
            nudDonGia.Text = dgvSanPham.CurrentRow.Cells["DonGia"].Value.ToString();
            cboMaLoaiSP.SelectedValue = dgvSanPham.CurrentRow.Cells["MaLoai"].Value.ToString();*/
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];
            
            txtMaSP.Text = row.Cells["MaSP"].Value?.ToString() ?? string.Empty;
            txtTenSP.Text = row.Cells["TenSP"].Value?.ToString() ?? string.Empty;
            txtDVTinh.Text = row.Cells["DVTinh"].Value?.ToString() ?? string.Empty;
            if (int.TryParse(row.Cells["DonGia"].Value?.ToString(), out int donGia))
            {
                nudDonGia.Value = Math.Min(Math.Max(donGia,Convert.ToInt32(nudDonGia.Minimum)), Convert.ToInt32(nudDonGia.Maximum));
            }
            string maLoai = row.Cells["MaLoai"].Value?.ToString() ?? string.Empty;
            cboMaLoaiSP.SelectedValue = maLoai;
            dangSua = true;
            txtMaSP.ReadOnly = true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (dangSua)
            {
                MessageBox.Show("Bạn đang ở chế độ sửa.\n"
                    + "Vui lòng hoàn thành việc sửa trước khi thêm sản phẩm mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!KiemTraDuLieu())
            {
                return;
            }
            try
            {
                DTOSanPham sp = LayDuLieuTuForm();
                bool ketQua = bllSanPham.InsertSanPham(sp);
                if (ketQua)
                {
                    MessageBox.Show("Thêm sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoadDanhSachSanPham();
                LamTrongForm();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!dangSua)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!KiemTraDuLieu())
            {
                return;
            }
            try
            {
                DTOSanPham sp = LayDuLieuTuForm();
                bool ketQua = bllSanPham.UpdateSanPham(sp);
                if (ketQua)
                {
                    MessageBox.Show("Cập nhật sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoadDanhSachSanPham();
                LamTrongForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!dangSua)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string maSP = dgvSanPham.CurrentRow.Cells["MaSP"].Value?.ToString() ?? string.Empty;
            if (string.IsNullOrEmpty(maSP))
            {
                MessageBox.Show("Không tìm thấy sản phẩm để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult ketQua = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm có mã '{maSP}' không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ketQua != DialogResult.Yes)
            {
                return;
            }
            try
            {
                bool daXoa = bllSanPham.DeleteSanPham(maSP);
                if (daXoa)
                {
                    MessageBox.Show("Xóa sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachSanPham();
                    LamTrongForm();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LamTrongForm();
        }
        private void LamTrongForm()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtDVTinh.Clear();
            txtTimKiem.Clear();
            
            nudDonGia.Value = nudDonGia.Minimum;
            cboMaLoaiSP.SelectedIndex = -1;
            txtMaSP.ReadOnly = false;
            dangSua = false;
            dgvSanPham.ClearSelection();
            txtMaSP.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                LoadDanhSachSanPham();
                return;
            }
            try
            {
                dgvSanPham.DataSource = bllSanPham.SearchSanPham(tuKhoa);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
