namespace QLBH.DTO
{
    public class DTOHoaDon
    {
        public string MaHD { get; set; } = string.Empty;
        public string MaKH { get; set; } = string.Empty;
        public string MaNV { get; set; } = string.Empty;
        public DateTime NgayHD { get; set; } = DateTime.Today;
        public int ThanhTien { get; set; }
        public List<DTOChiTietHoaDon> ChiTiet { get; set; } = new();
    }
}
