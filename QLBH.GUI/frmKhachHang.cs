using QLBH.BLL;
using QLBH.DTO;
using System.Data;

namespace QLBH.GUI
{
    public partial class frmKhachHang : Form
    {
        private BLLKhachHang bllKhachHang = new BLLKhachHang();
        private bool dangSua = false;

        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadDanhSachKhachHang();
            LamMoi();
        }

        private void HienThiDanhSach(DataTable dt)
        {
            dgvKhachHang.DataSource = dt;
            if (dgvKhachHang.Columns.Contains("MaKH"))
                dgvKhachHang.Columns["MaKH"]!.HeaderText = "Mã khách hàng";
            if (dgvKhachHang.Columns.Contains("TenKH"))
                dgvKhachHang.Columns["TenKH"]!.HeaderText = "Tên khách hàng";
            if (dgvKhachHang.Columns.Contains("DiaChi"))
                dgvKhachHang.Columns["DiaChi"]!.HeaderText = "Địa chỉ";
            if (dgvKhachHang.Columns.Contains("DienThoai"))
                dgvKhachHang.Columns["DienThoai"]!.HeaderText = "Điện thoại";
            if (dgvKhachHang.Columns.Contains("Phai"))
                dgvKhachHang.Columns["Phai"]!.HeaderText = "Phái";
            dgvKhachHang.ClearSelection();
        }

        private void LoadDanhSachKhachHang()
        {
            try
            {
                HienThiDanhSach(bllKhachHang.loadKhachHang());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải danh sách khách hàng: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DTOKhachHang LayDuLieuTuForm()
        {
            return new DTOKhachHang
            {
                MaKH = txtMaKH.Text.Trim(),
                TenKH = txtTenKH.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim(),
                DienThoai = txtDienThoai.Text.Trim(),
                Phai = rdoNam.Checked ? "M" : rdoNu.Checked ? "F" : ""
            };
        }

        private void LamMoi()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtDiaChi.Clear();
            txtDienThoai.Clear();
            rdoNam.Checked = false;
            rdoNu.Checked = false;
            txtMaKH.ReadOnly = false;
            dangSua = false;
            lblThongTin.Text = "";
            dgvKhachHang.ClearSelection();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
            txtMaKH.Text = row.Cells["MaKH"].Value?.ToString() ?? "";
            txtTenKH.Text = row.Cells["TenKH"].Value?.ToString() ?? "";
            txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString() ?? "";
            txtDienThoai.Text = row.Cells["DienThoai"].Value?.ToString() ?? "";
            string phai = row.Cells["Phai"].Value?.ToString() ?? "";
            rdoNam.Checked = phai == "M";
            rdoNu.Checked = phai == "F";
            txtMaKH.ReadOnly = true;
            dangSua = true;

            try
            {
                int soHoaDon = bllKhachHang.DemHoaDonTheoKhachHang(txtMaKH.Text);
                lblThongTin.Text = soHoaDon > 0
                    ? "Khách hàng có " + soHoaDon + " hóa đơn, không thể xóa."
                    : "";
            }
            catch (Exception ex)
            {
                lblThongTin.Text = "Lỗi: " + ex.Message;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (dangSua)
            {
                MessageBox.Show("Bấm Làm mới trước khi thêm khách hàng.");
                return;
            }
            try
            {
                if (bllKhachHang.InsertKhachHang(LayDuLieuTuForm()))
                {
                    MessageBox.Show("Thêm khách hàng thành công.");
                    LoadDanhSachKhachHang();
                    LamMoi();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!dangSua)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa.");
                return;
            }
            if (MessageBox.Show("Bạn muốn lưu thông tin khách hàng này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                if (bllKhachHang.UpdateKhachHang(LayDuLieuTuForm()))
                {
                    MessageBox.Show("Sửa khách hàng thành công.");
                    LoadDanhSachKhachHang();
                    LamMoi();
                }
                else
                    MessageBox.Show("Không tìm thấy khách hàng để sửa.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!dangSua)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa.");
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                if (bllKhachHang.DeleteKhachHang(txtMaKH.Text.Trim()))
                {
                    MessageBox.Show("Xóa khách hàng thành công.");
                    LoadDanhSachKhachHang();
                    LamMoi();
                }
                else
                    MessageBox.Show("Không tìm thấy khách hàng để xóa.");
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            LoadDanhSachKhachHang();
            LamMoi();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                HienThiDanhSach(bllKhachHang.SearchKhachHang(txtTimKiem.Text));
                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
