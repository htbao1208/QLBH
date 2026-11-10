using QLBH.BLL;
using QLBH.DTO;
using System.Data;

namespace QLBH.GUI
{
    public partial class frmLoaiSanPham : Form
    {
        private BLLLoaiSanPham bllLoaiSanPham = new BLLLoaiSanPham();
        private bool dangSua = false;

        public frmLoaiSanPham()
        {
            InitializeComponent();

            btnInsert.Click += btnInsert_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnReset.Click += btnReset_Click;
            btnLoad.Click += btnLoad_Click;
            btnSearch.Click += btnSearch_Click;
            txtTimKiem.KeyDown += txtTimKiem_KeyDown;
            dgvLoaiSanPham.CellClick += dgvLoaiSanPham_CellClick;
        }

        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            LoadDanhSachLoai();
            LamTrongForm();
        }

        private void HienThiLenLuoi(DataTable dt)
        {
            dgvLoaiSanPham.DataSource = dt;
            if (dgvLoaiSanPham.Columns.Contains("MaLoai"))
            {
                dgvLoaiSanPham.Columns["MaLoai"]!.HeaderText = "Mã loại";
            }
            if (dgvLoaiSanPham.Columns.Contains("TenLoai"))
            {
                dgvLoaiSanPham.Columns["TenLoai"]!.HeaderText = "Tên loại";
                dgvLoaiSanPham.Columns["TenLoai"]!.FillWeight = 300;
            }
            dgvLoaiSanPham.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLoaiSanPham.ClearSelection();
        }

        private void LoadDanhSachLoai()
        {
            try
            {
                HienThiLenLuoi(bllLoaiSanPham.loadLoaiSanPham());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LamTrongForm()
        {
            txtMaLoai.Clear();
            txtTenLoai.Clear();
            txtMaLoai.ReadOnly = false;
            dangSua = false;
            lblThongTin.Text = "";
            dgvLoaiSanPham.ClearSelection();
            txtMaLoai.Focus();
        }

        private DTOLoaiSanPham LayDuLieuTuForm()
        {
            return new DTOLoaiSanPham
            {
                MaLoai = txtMaLoai.Text.Trim(),
                TenLoai = txtTenLoai.Text.Trim()
            };
        }

        private void dgvLoaiSanPham_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow row = dgvLoaiSanPham.Rows[e.RowIndex];
            txtMaLoai.Text = row.Cells["MaLoai"].Value?.ToString() ?? string.Empty;
            txtTenLoai.Text = row.Cells["TenLoai"].Value?.ToString() ?? string.Empty;
            txtMaLoai.ReadOnly = true;
            dangSua = true;

            try
            {
                int soSanPham = bllLoaiSanPham.DemSanPhamTheoLoai(txtMaLoai.Text);
                lblThongTin.Text = soSanPham > 0
                    ? $"Loại này đang có {soSanPham} sản phẩm (không thể xóa)."
                    : "Loại này chưa có sản phẩm nào.";
            }
            catch (Exception ex)
            {
                lblThongTin.Text = "Lỗi: " + ex.Message;
            }
        }

        private void btnInsert_Click(object? sender, EventArgs e)
        {
            if (dangSua)
            {
                MessageBox.Show("Bạn đang ở chế độ sửa.\nBấm Reset để làm trống form trước khi thêm loại mới.",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (bllLoaiSanPham.InsertLoaiSanPham(LayDuLieuTuForm()))
                {
                    MessageBox.Show("Thêm loại sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachLoai();
                    LamTrongForm();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLoai.Focus();
                txtMaLoai.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object? sender, EventArgs e)
        {
            if (!dangSua)
            {
                MessageBox.Show("Vui lòng chọn loại sản phẩm cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult xacNhan = MessageBox.Show($"Lưu thay đổi cho loại '{txtMaLoai.Text}'?", "Xác nhận sửa",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (xacNhan != DialogResult.Yes)
            {
                return;
            }
            try
            {
                if (bllLoaiSanPham.UpdateLoaiSanPham(LayDuLieuTuForm()))
                {
                    MessageBox.Show("Cập nhật loại sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachLoai();
                    LamTrongForm();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (!dangSua)
            {
                MessageBox.Show("Vui lòng chọn loại sản phẩm cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string maLoai = txtMaLoai.Text.Trim();
            DialogResult xacNhan = MessageBox.Show($"Bạn có chắc chắn muốn xóa loại sản phẩm có mã '{maLoai}' không?",
                                                   "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (xacNhan != DialogResult.Yes)
            {
                return;
            }
            try
            {
                if (bllLoaiSanPham.DeleteLoaiSanPham(maLoai))
                {
                    MessageBox.Show("Xóa loại sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachLoai();
                    LamTrongForm();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy loại sản phẩm để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object? sender, EventArgs e)
        {
            txtTimKiem.Clear();
            LamTrongForm();
        }

        private void btnLoad_Click(object? sender, EventArgs e)
        {
            txtTimKiem.Clear();
            LoadDanhSachLoai();
            LamTrongForm();
        }

        private void btnSearch_Click(object? sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                LoadDanhSachLoai();
                return;
            }
            try
            {
                DataTable ketQua = bllLoaiSanPham.SearchLoaiSanPham(tuKhoa);
                HienThiLenLuoi(ketQua);
                lblThongTin.Text = $"Tìm thấy {ketQua.Rows.Count} loại sản phẩm.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiem_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnSearch_Click(sender, e);
            }
        }
    }
}
