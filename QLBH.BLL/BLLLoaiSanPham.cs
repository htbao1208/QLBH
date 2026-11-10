using QLBH.DAL;
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
    }
}
