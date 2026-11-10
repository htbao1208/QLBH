using Microsoft.Data.SqlClient;
using QLBH.DTO;
using System;
using System.Collections.Generic;
using System.Data;
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
                SqlDataAdapter da = new SqlDataAdapter("SELECT MaLoai, TenLoai FROM LoaiSanPham ORDER BY MaLoai", conn);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tải dữ liệu loại sản phẩm: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable SearchLoaiSanPham(string tuKhoa)
        {
            const string sql = @"SELECT MaLoai, TenLoai FROM LoaiSanPham
                                 WHERE MaLoai LIKE @TuKhoa OR TenLoai LIKE @TuKhoa
                                 ORDER BY MaLoai";
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.Add("@TuKhoa", SqlDbType.NVarChar, 60).Value = "%" + tuKhoa + "%";
                da.Fill(dt);
                return dt;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool KiemTraTonTai(string maLoai)
        {
            const string sql = "SELECT COUNT(*) FROM LoaiSanPham WHERE MaLoai = @MaLoai";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@MaLoai", SqlDbType.VarChar, 10).Value = maLoai;
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
            finally
            {
                conn.Close();
            }
        }

        public int DemSanPhamTheoLoai(string maLoai)
        {
            const string sql = "SELECT COUNT(*) FROM SanPham WHERE MaLoai = @MaLoai";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@MaLoai", SqlDbType.VarChar, 10).Value = maLoai;
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            finally
            {
                conn.Close();
            }
        }

        public bool InsertLoaiSanPham(DTOLoaiSanPham loai)
        {
            const string sql = "INSERT INTO LoaiSanPham (MaLoai, TenLoai) VALUES (@MaLoai, @TenLoai)";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@MaLoai", SqlDbType.VarChar, 10).Value = loai.MaLoai;
                cmd.Parameters.Add("@TenLoai", SqlDbType.NVarChar, 50).Value = loai.TenLoai;
                return cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool UpdateLoaiSanPham(DTOLoaiSanPham loai)
        {
            const string sql = "UPDATE LoaiSanPham SET TenLoai = @TenLoai WHERE MaLoai = @MaLoai";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@MaLoai", SqlDbType.VarChar, 10).Value = loai.MaLoai;
                cmd.Parameters.Add("@TenLoai", SqlDbType.NVarChar, 50).Value = loai.TenLoai;
                return cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool DeleteLoaiSanPham(string maLoai)
        {
            const string sql = "DELETE FROM LoaiSanPham WHERE MaLoai = @MaLoai";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@MaLoai", SqlDbType.VarChar, 10).Value = maLoai;
                return cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
