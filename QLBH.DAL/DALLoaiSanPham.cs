using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace QLBH.DAL
{
    public class DALLoaiSanPham : DBConnection
    {
        public DataTable loadLoaiSanPham()
        {
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * FROM LoaiSanPham", conn);
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                /*throw new Exception("Lỗi khi tải dữ liệu loại sản phẩm: " + ex.Message);*/
                return null;
            }
            finally 
            { 
                conn.Close(); 
            }

        }

        public DataTable loadSanPham()
        {
            throw new NotImplementedException();
        }
    }
}
