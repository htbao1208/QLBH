using System.ComponentModel;
using System.Data;
using System.Globalization;
using QLBH.BLL;
using QLBH.DTO;

namespace QLBH.GUI
{
    public partial class frmHoaDon : Form
    {
        private readonly BLLHoaDon bllHoaDon = new();
        private readonly BindingList<DTOChiTietHoaDon> chiTiet = new();
        private string maHDDangChon = string.Empty;
        private bool duLieuDaSanSang;

        public frmHoaDon()
        {
            InitializeComponent();
            dgvChiTiet.AutoGenerateColumns = false;
            dgvChiTiet.DataSource = chiTiet;
        }

        private void frmHoaDon_Load(object? sender, EventArgs e)
        {
            btnThemDong.Enabled = false;
            btnLuu.Enabled = false;
            try
            {
                // Lấy trực tiếp danh sách từ các bảng có sẵn, không phụ thuộc form khách hàng.
                var khachHang = bllHoaDon.LoadKhachHang();
                var nhanVien = bllHoaDon.LoadNhanVien();
                var sanPham = bllHoaDon.LoadSanPham();

                cboKhachHang.DisplayMember = "HienThi";
                cboKhachHang.ValueMember = "MaKH";
                cboKhachHang.DataSource = khachHang;
                cboKhachHang.SelectedIndex = -1;

                cboNhanVien.DisplayMember = "HienThi";
                cboNhanVien.ValueMember = "MaNV";
                cboNhanVien.DataSource = nhanVien;
                cboNhanVien.SelectedIndex = -1;

                cboSanPham.DisplayMember = "HienThi";
                cboSanPham.ValueMember = "MaSP";
                cboSanPham.DataSource = sanPham;
                cboSanPham.SelectedIndex = -1;

                TaiDanhSachHoaDon();
                duLieuDaSanSang = true;
                LamTrongForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải dữ liệu hóa đơn: " + ex.Message
                    + "\nVui lòng kiểm tra kết nối và mở lại form.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboSanPham_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cboSanPham.SelectedItem is DataRowView row && row["DonGia"] != DBNull.Value)
                txtGiaBan.Text = Convert.ToInt32(row["DonGia"]).ToString("N0");
            else
                txtGiaBan.Clear();
        }

        private void btnThemDong_Click(object? sender, EventArgs e)
        {
            if (cboSanPham.SelectedItem is not DataRowView row)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm.", "Thông báo");
                cboSanPham.Focus();
                return;
            }
            if (!int.TryParse(nudSoLuong.Text, NumberStyles.Integer | NumberStyles.AllowThousands,
                CultureInfo.CurrentCulture, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên lớn hơn 0.", "Thông báo");
                nudSoLuong.Focus();
                return;
            }
            if (row["DonGia"] == DBNull.Value)
            {
                MessageBox.Show("Sản phẩm chưa có đơn giá, không thể thêm vào hóa đơn.", "Thông báo");
                return;
            }

            try
            {
                var dong = new DTOChiTietHoaDon
                {
                    MaSP = Convert.ToString(row["MaSP"]) ?? string.Empty,
                    TenSP = Convert.ToString(row["TenSP"]) ?? string.Empty,
                    DVTinh = Convert.ToString(row["DVTinh"]) ?? string.Empty,
                    SoLuong = soLuong,
                    GiaBan = Convert.ToInt32(row["DonGia"])
                };
                // Kiểm tra trùng dòng và giới hạn tiền trước khi thay đổi bảng chi tiết.
                int tongTien = BLLHoaDon.TinhTongTien(chiTiet.Append(dong));
                chiTiet.Add(dong);
                HienThiTongTien(tongTien);
                nudSoLuong.Value = 1;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaDong_Click(object? sender, EventArgs e)
        {
            if (dgvChiTiet.CurrentRow?.DataBoundItem is not DTOChiTietHoaDon dong)
            {
                MessageBox.Show("Vui lòng chọn dòng sản phẩm cần xóa.", "Thông báo");
                return;
            }
            chiTiet.Remove(dong);
            HienThiTongTien(BLLHoaDon.TinhTongTien(chiTiet));
        }

        private void HienThiTongTien(int tongTien)
        {
            lblTongTien.Text = $"Tổng tiền: {tongTien:N0} đồng";
        }

        private void TaiDanhSachHoaDon()
        {
            var danhSach = bllHoaDon.LoadDanhSachHoaDon();
            cboDanhSachHoaDon.DisplayMember = "HienThi";
            cboDanhSachHoaDon.ValueMember = "MaHD";
            cboDanhSachHoaDon.DataSource = danhSach;
            cboDanhSachHoaDon.SelectedIndex = -1;
        }

        private void cboDanhSachHoaDon_SelectionChangeCommitted(object? sender, EventArgs e)
        {
            string maHD = cboDanhSachHoaDon.SelectedValue?.ToString() ?? string.Empty;
            if (maHD.Length == 0) return;
            try
            {
                HienThiHoaDon(maHD);
            }
            catch (Exception ex)
            {
                LamTrongForm();
                MessageBox.Show("Không thể tải hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HienThiHoaDon(string maHD)
        {
            // Đọc xong và kiểm tra trước khi thay đổi dữ liệu đang hiển thị.
            var hoaDon = bllHoaDon.LayHoaDon(maHD);
            dgvChiTiet.CancelEdit();
            maHDDangChon = hoaDon.MaHD;
            txtMaHD.Text = hoaDon.MaHD;
            cboKhachHang.SelectedValue = hoaDon.MaKH;
            cboNhanVien.SelectedValue = hoaDon.MaNV;
            dtpNgayHD.Value = hoaDon.NgayHD.Date;
            cboSanPham.SelectedIndex = -1;
            txtGiaBan.Clear();
            nudSoLuong.Value = 0;
            chiTiet.Clear();
            foreach (var dong in hoaDon.ChiTiet) chiTiet.Add(dong);
            HienThiTongTien(hoaDon.ThanhTien);
            CapNhatTrangThaiNut();
        }

        private void CapNhatTrangThaiNut()
        {
            bool dangSua = maHDDangChon.Length > 0;
            txtMaHD.ReadOnly = dangSua;
            btnLuu.Enabled = duLieuDaSanSang && !dangSua;
            btnCapNhat.Enabled = duLieuDaSanSang && dangSua;
            btnXoaHoaDon.Enabled = duLieuDaSanSang && dangSua;
            btnThemDong.Enabled = duLieuDaSanSang;
        }

        private void LamTrongForm()
        {
            dgvChiTiet.CancelEdit();
            maHDDangChon = string.Empty;
            cboDanhSachHoaDon.SelectedIndex = -1;
            chiTiet.Clear();
            txtMaHD.Clear();
            cboKhachHang.SelectedIndex = -1;
            cboNhanVien.SelectedIndex = -1;
            cboSanPham.SelectedIndex = -1;
            txtGiaBan.Clear();
            nudSoLuong.Value = 0;
            dtpNgayHD.Value = DateTime.Today;
            HienThiTongTien(0);
            CapNhatTrangThaiNut();
            txtMaHD.Focus();
        }

        private void btnLamTrong_Click(object? sender, EventArgs e) => LamTrongForm();

        private DTOHoaDon LayDuLieuTuForm() => new()
        {
            MaHD = txtMaHD.Text.Trim(),
            MaKH = cboKhachHang.SelectedValue?.ToString() ?? string.Empty,
            MaNV = cboNhanVien.SelectedValue?.ToString() ?? string.Empty,
            NgayHD = dtpNgayHD.Value.Date,
            ChiTiet = chiTiet.ToList()
        };

        private void LamMoiDanhSachSauThaoTac(string? maHD = null)
        {
            try
            {
                TaiDanhSachHoaDon();
                if (maHD != null)
                {
                    cboDanhSachHoaDon.SelectedValue = maHD;
                    HienThiHoaDon(maHD);
                }
            }
            catch (Exception ex)
            {
                // Lệnh ghi đã commit; lỗi tải lại không phải là lỗi lưu/cập nhật/xóa.
                MessageBox.Show("Đã xử lý hóa đơn thành công, nhưng chưa tải lại được danh sách: " + ex.Message,
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLuu_Click(object? sender, EventArgs e)
        {
            if (maHDDangChon.Length > 0 || !ValidateChildren() || !dgvChiTiet.EndEdit()) return;
            var hoaDon = LayDuLieuTuForm();
            btnLuu.Enabled = false;
            try
            {
                bllHoaDon.LuuHoaDon(hoaDon);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể lưu hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                CapNhatTrangThaiNut();
            }
            MessageBox.Show($"Đã lưu hóa đơn {hoaDon.MaHD} và {hoaDon.ChiTiet.Count} dòng chi tiết.",
                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LamTrongForm();
            LamMoiDanhSachSauThaoTac();
        }

        private void btnCapNhat_Click(object? sender, EventArgs e)
        {
            if (maHDDangChon.Length == 0 || !ValidateChildren() || !dgvChiTiet.EndEdit()) return;
            var hoaDon = LayDuLieuTuForm();
            hoaDon.MaHD = maHDDangChon;
            btnCapNhat.Enabled = false;
            try
            {
                bllHoaDon.CapNhatHoaDon(hoaDon);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể cập nhật hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                CapNhatTrangThaiNut();
            }
            MessageBox.Show("Đã cập nhật hóa đơn " + hoaDon.MaHD + ".", "Thành công");
            LamMoiDanhSachSauThaoTac(hoaDon.MaHD);
        }

        private void btnXoaHoaDon_Click(object? sender, EventArgs e)
        {
            if (maHDDangChon.Length == 0) return;
            if (MessageBox.Show($"Bạn có chắc muốn xóa hóa đơn {maHDDangChon} và toàn bộ chi tiết?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            btnXoaHoaDon.Enabled = false;
            try
            {
                bllHoaDon.XoaHoaDon(maHDDangChon);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                CapNhatTrangThaiNut();
            }
            MessageBox.Show("Đã xóa hóa đơn.", "Thành công");
            LamTrongForm();
            LamMoiDanhSachSauThaoTac();
        }

        private void dgvChiTiet_CellValidating(object? sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colSoLuong.Index) return;
            try
            {
                if (!int.TryParse(Convert.ToString(e.FormattedValue), NumberStyles.Integer | NumberStyles.AllowThousands,
                    CultureInfo.CurrentCulture, out int soLuong) || soLuong <= 0)
                    throw new ArgumentException("Số lượng phải là số nguyên lớn hơn 0.");
                if (dgvChiTiet.Rows[e.RowIndex].DataBoundItem is not DTOChiTietHoaDon dongDangSua) return;
                BLLHoaDon.TinhTongTien(chiTiet.Select(dong => new DTOChiTietHoaDon
                {
                    MaSP = dong.MaSP,
                    SoLuong = ReferenceEquals(dong, dongDangSua) ? soLuong : dong.SoLuong,
                    GiaBan = dong.GiaBan
                }));
                dgvChiTiet.Rows[e.RowIndex].ErrorText = string.Empty;
            }
            catch (ArgumentException ex)
            {
                e.Cancel = true;
                dgvChiTiet.Rows[e.RowIndex].ErrorText = ex.Message;
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvChiTiet_CellEndEdit(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            dgvChiTiet.Rows[e.RowIndex].ErrorText = string.Empty;
            // Thành tiền là thuộc tính tính toán từ số lượng và giá bán.
            dgvChiTiet.InvalidateRow(e.RowIndex);
            HienThiTongTien(BLLHoaDon.TinhTongTien(chiTiet));
        }
    }
}
