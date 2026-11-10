namespace QLBH.DTO
{
    public class DTOLoaiSanPham
    {
        private string maLoai;

        public string MaLoai
        {
            get { return maLoai; }
            set { maLoai = value; }
        }
        public string TenLoai { get; set; } = "";
        
        public DTOLoaiSanPham()
        {
        }
        public DTOLoaiSanPham(string maLoai, string tenLoai)
        {
            if (string.IsNullOrEmpty(maLoai))
            {
                throw new ArgumentException("Mã loại sản phẩm không được để trống.", nameof(maLoai));
            }
            this.maLoai = maLoai;
            this.TenLoai = tenLoai;
        }
    }
}
