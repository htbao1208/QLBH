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

                btnThemDong.Enabled = true;
                btnLuu.Enabled = true;
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

        private void btnLuu_Click(object? sender, EventArgs e)
        {
            var hoaDon = new DTOHoaDon
            {
                MaHD = txtMaHD.Text.Trim(),
                MaKH = cboKhachHang.SelectedValue?.ToString() ?? string.Empty,
                MaNV = cboNhanVien.SelectedValue?.ToString() ?? string.Empty,
                NgayHD = dtpNgayHD.Value.Date,
                ChiTiet = chiTiet.ToList()
            };
            btnLuu.Enabled = false;
            try
            {
                bllHoaDon.LuuHoaDon(hoaDon);
                MessageBox.Show($"Đã lưu hóa đơn {hoaDon.MaHD} và {hoaDon.ChiTiet.Count} dòng chi tiết.",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Chỉ làm trống sau khi transaction đã commit thành công.
                chiTiet.Clear();
                txtMaHD.Clear();
                cboKhachHang.SelectedIndex = -1;
                cboNhanVien.SelectedIndex = -1;
                cboSanPham.SelectedIndex = -1;
                nudSoLuong.Value = 1;
                dtpNgayHD.Value = DateTime.Today;
                HienThiTongTien(0);
                txtMaHD.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể lưu hóa đơn: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnLuu.Enabled = true;
            }
        }
    }
}
