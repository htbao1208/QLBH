using System;
using System.Collections.Generic;
using System.Text;

namespace QLBH.DTO
{
    public class DTOSanPham
    {
        public string MaSP { get; set; } = string.Empty;
        public string TenSP { get; set; } = string.Empty;
        public string DVTinh { get; set; } = string.Empty;
        public string LoaiSP { get; set; } = string.Empty;
        public int DonGia { get; set; } = 0;
        public string MaLoai { get; set; } = string.Empty;

        public DTOSanPham()
        {

        }
        public DTOSanPham(string maSP, string tenSP, string dVTinh, string maLoai, int donGia)
        {
            if (string.IsNullOrEmpty(maSP))
            {
                throw new ArgumentException("Mã sản phẩm không được để trống.", nameof(maSP));
            }
            MaSP = maSP;
            TenSP = tenSP;
            DVTinh = dVTinh;
            DonGia = donGia;
            MaLoai = maLoai;
        }
    }
}
