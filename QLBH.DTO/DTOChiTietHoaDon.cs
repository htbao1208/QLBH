namespace QLBH.DTO
{
    public class DTOChiTietHoaDon
    {
        public string MaSP { get; set; } = string.Empty;
        public string TenSP { get; set; } = string.Empty;
        public string DVTinh { get; set; } = string.Empty;
        public int SoLuong { get; set; }
        public int GiaBan { get; set; }
        public decimal ThanhTien => (decimal)SoLuong * GiaBan;
    }
}
