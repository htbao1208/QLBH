using System.Data;
using QLBH.DAL;
using QLBH.DTO;

namespace QLBH.BLL
{
    public class BLLHoaDon
    {
        private readonly DALHoaDon dal = new();

        public DataTable LoadKhachHang() => dal.LoadKhachHang();
        public DataTable LoadNhanVien() => dal.LoadNhanVien();
        public DataTable LoadSanPham() => dal.LoadSanPham();
        public DataTable LoadDanhSachHoaDon() => dal.LoadDanhSachHoaDon();

        private static string KiemTraMaHoaDon(string maHD)
        {
            maHD = maHD.Trim();
            if (maHD.Length == 0 || maHD.Length > 10)
                throw new ArgumentException("Vui lòng chọn hóa đơn hợp lệ.");
            return maHD;
        }

        public DTOHoaDon LayHoaDon(string maHD)
        {
            var hoaDon = dal.LayHoaDon(KiemTraMaHoaDon(maHD))
                ?? throw new InvalidOperationException("Hóa đơn không còn tồn tại. Vui lòng tải lại danh sách.");
            hoaDon.ThanhTien = TinhTongTien(hoaDon.ChiTiet);
            return hoaDon;
        }

        public void XoaHoaDon(string maHD) => dal.XoaHoaDon(KiemTraMaHoaDon(maHD));

        // SQL mẫu lưu ThanhTien bằng int, nên kiểm tra trước khi lưu.
        public static int TinhTongTien(IEnumerable<DTOChiTietHoaDon> chiTiet)
        {
            decimal tong = 0;
            var maSanPham = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (var dong in chiTiet)
            {
                if (string.IsNullOrWhiteSpace(dong.MaSP) || dong.MaSP.Length > 10)
                    throw new ArgumentException("Mã sản phẩm không hợp lệ.");
                if (!maSanPham.Add(dong.MaSP.Trim()))
                    throw new ArgumentException("Sản phẩm đã có trong hóa đơn, không được thêm trùng dòng.");
                if (dong.SoLuong <= 0)
                    throw new ArgumentException("Số lượng phải lớn hơn 0.");
                if (dong.GiaBan < 0)
                    throw new ArgumentException("Giá bán không được âm.");
                tong += dong.ThanhTien;
                if (tong > int.MaxValue)
                    throw new ArgumentException("Tổng tiền vượt giới hạn 2.147.483.647 đồng của cơ sở dữ liệu.");
            }
            return (int)tong;
        }

        public void LuuHoaDon(DTOHoaDon hoaDon)
        {
            KiemTraHoaDon(hoaDon);
            dal.LuuHoaDon(hoaDon);
        }

        public void CapNhatHoaDon(DTOHoaDon hoaDon)
        {
            KiemTraHoaDon(hoaDon);
            dal.CapNhatHoaDon(hoaDon);
        }

        private static void KiemTraHoaDon(DTOHoaDon hoaDon)
        {
            hoaDon.MaHD = hoaDon.MaHD.Trim();
            hoaDon.MaKH = hoaDon.MaKH.Trim();
            hoaDon.MaNV = hoaDon.MaNV.Trim();
            if (hoaDon.MaHD.Length == 0 || hoaDon.MaHD.Length > 10)
                throw new ArgumentException("Mã hóa đơn phải có từ 1 đến 10 ký tự.");
            if (hoaDon.MaKH.Length == 0 || hoaDon.MaKH.Length > 10)
                throw new ArgumentException("Vui lòng chọn khách hàng.");
            if (hoaDon.MaNV.Length == 0 || hoaDon.MaNV.Length > 10)
                throw new ArgumentException("Vui lòng chọn nhân viên lập hóa đơn.");
            if (hoaDon.NgayHD < new DateTime(1753, 1, 1))
                throw new ArgumentException("Ngày hóa đơn không hợp lệ.");
            if (hoaDon.ChiTiet.Count == 0)
                throw new ArgumentException("Hóa đơn phải có ít nhất một dòng sản phẩm.");

            hoaDon.ThanhTien = TinhTongTien(hoaDon.ChiTiet);
        }
    }
}
