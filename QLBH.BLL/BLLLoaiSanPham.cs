using QLBH.DAL;
using QLBH.DTO;
using System.Data;

namespace QLBH.BLL
{
    public class BLLLoaiSanPham
    {
        DALLoaiSanPham dalLoaiSanPham = new DALLoaiSanPham();

        public DataTable loadLoaiSanPham()
        {
            return dalLoaiSanPham.loadLoaiSanPham();
        }

        public DataTable SearchLoaiSanPham(string tuKhoa)
        {
            return dalLoaiSanPham.SearchLoaiSanPham(tuKhoa.Trim());
        }

        private void KiemTraDuLieu(DTOLoaiSanPham loai)
        {
            if (string.IsNullOrWhiteSpace(loai.MaLoai))
                throw new ArgumentException("Mã loại không được để trống.");
            if (loai.MaLoai.Trim().Length > 10)
                throw new ArgumentException("Mã loại tối đa 10 ký tự.");
            if (string.IsNullOrWhiteSpace(loai.TenLoai))
                throw new ArgumentException("Tên loại không được để trống.");
            if (loai.TenLoai.Trim().Length > 50)
                throw new ArgumentException("Tên loại tối đa 50 ký tự.");

            loai.MaLoai = loai.MaLoai.Trim();
            loai.TenLoai = loai.TenLoai.Trim();
        }

        public bool InsertLoaiSanPham(DTOLoaiSanPham loai)
        {
            KiemTraDuLieu(loai);
            if (dalLoaiSanPham.KiemTraTonTai(loai.MaLoai))
                throw new InvalidOperationException($"Mã loại '{loai.MaLoai}' đã tồn tại.");
            return dalLoaiSanPham.InsertLoaiSanPham(loai);
        }

        public bool UpdateLoaiSanPham(DTOLoaiSanPham loai)
        {
            KiemTraDuLieu(loai);
            if (!dalLoaiSanPham.KiemTraTonTai(loai.MaLoai))
                throw new InvalidOperationException($"Không tìm thấy loại sản phẩm có mã '{loai.MaLoai}'.");
            return dalLoaiSanPham.UpdateLoaiSanPham(loai);
        }

        public int DemSanPhamTheoLoai(string maLoai)
        {
            return dalLoaiSanPham.DemSanPhamTheoLoai(maLoai);
        }

        public bool DeleteLoaiSanPham(string maLoai)
        {
            if (string.IsNullOrWhiteSpace(maLoai))
                throw new ArgumentException("Vui lòng chọn loại sản phẩm cần xóa.");

            int soSanPham = dalLoaiSanPham.DemSanPhamTheoLoai(maLoai);
            if (soSanPham > 0)
                throw new InvalidOperationException($"Không thể xóa: loại '{maLoai}' đang được {soSanPham} sản phẩm sử dụng.");

            return dalLoaiSanPham.DeleteLoaiSanPham(maLoai);
        }
    }
}
