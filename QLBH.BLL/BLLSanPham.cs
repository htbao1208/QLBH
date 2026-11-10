using QLBH.DAL;
using QLBH.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLBH.BLL
{
    public class BLLSanPham
    {
        DALSanPham dAL = new DALSanPham();
        public DataTable loadSanPham()
        {
            return dAL.loadSanPham();

        }
        public bool InsertSanPham(DTOSanPham sp)
        {
            return dAL.InsertSanPham(sp);
        }
        public bool UpdateSanPham(DTOSanPham sp)
        {
            return dAL.UpdateSanPham(sp);
        }
        public bool DeleteSanPham(string masp)
        {
            return dAL.DeleteSanPham(masp);
        }
        public DataTable SearchSanPham(string tuKhoa)
        {
            return dAL.SearchSanPham(tuKhoa);
        }

    }
}
