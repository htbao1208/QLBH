using QLBH.DAL;
using QLBH.DTO;
using System.Data;

namespace QLBH.BLL
{
    public class BLLKhachHang
    {
        private DALKhachHang dalKhachHang = new DALKhachHang();

        public DataTable loadKhachHang()
        {
            return dalKhachHang.loadKhachHang();
        }

        public DataTable SearchKhachHang(string tuKhoa)
        {
            return dalKhachHang.SearchKhachHang(tuKhoa.Trim());
        }

        private void KiemTraDuLieu(DTOKhachHang kh)
        {
            kh.MaKH = kh.MaKH.Trim();
            kh.TenKH = kh.TenKH.Trim();
            kh.DiaChi = kh.DiaChi.Trim();
            kh.DienThoai = kh.DienThoai.Trim();

            if (kh.MaKH == "")
                throw new ArgumentException("Vui lòng nhập mã khách hàng.");
            if (kh.MaKH.Length > 10)
                throw new ArgumentException("Mã khách hàng tối đa 10 ký tự.");
            if (kh.TenKH == "")
                throw new ArgumentException("Vui lòng nhập tên khách hàng.");
            if (kh.TenKH.Length > 50)
                throw new ArgumentException("Tên khách hàng tối đa 50 ký tự.");
            if (kh.DiaChi.Length > 50)
                throw new ArgumentException("Địa chỉ tối đa 50 ký tự.");
            if (kh.DienThoai.Length > 15)
                throw new ArgumentException("Số điện thoại tối đa 15 ký tự.");
            if (kh.DienThoai != "")
            {
                foreach (char kyTu in kh.DienThoai)
                {
                    if (kyTu < '0' || kyTu > '9')
                        throw new ArgumentException("Số điện thoại chỉ được nhập chữ số.");
                }
            }
            if (kh.Phai != "M" && kh.Phai != "F")
                throw new ArgumentException("Vui lòng chọn phái.");
        }

        public bool InsertKhachHang(DTOKhachHang kh)
        {
            KiemTraDuLieu(kh);
            if (dalKhachHang.KiemTraTonTai(kh.MaKH))
                throw new InvalidOperationException("Mã khách hàng đã tồn tại.");
            return dalKhachHang.InsertKhachHang(kh);
        }

        public bool UpdateKhachHang(DTOKhachHang kh)
        {
            KiemTraDuLieu(kh);
            if (!dalKhachHang.KiemTraTonTai(kh.MaKH))
                throw new InvalidOperationException("Không tìm thấy khách hàng cần sửa.");
            return dalKhachHang.UpdateKhachHang(kh);
        }

        public int DemHoaDonTheoKhachHang(string maKH)
        {
            return dalKhachHang.DemHoaDonTheoKhachHang(maKH);
        }

        public bool DeleteKhachHang(string maKH)
        {
            if (maKH.Trim() == "")
                throw new ArgumentException("Vui lòng chọn khách hàng cần xóa.");
            if (dalKhachHang.DemHoaDonTheoKhachHang(maKH) > 0)
                throw new InvalidOperationException("Không thể xóa khách hàng đã có hóa đơn.");
            return dalKhachHang.DeleteKhachHang(maKH);
        }
    }
}
