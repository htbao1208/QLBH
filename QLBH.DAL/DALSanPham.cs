using Microsoft.Data.SqlClient;
using QLBH.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLBH.DAL
{
    public class DALSanPham : DBConnection
    {
        public DataTable loadSanPham()
        {
           try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from SanPham", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public bool InsertSanPham(DTOSanPham sp)
        {
            const string sql = @"INSERT INTO SanPham (MaSP, TenSP, DVTinh, DonGia, MaLoai) VALUES (@MaSP, @TenSP, @DVTinh, @DonGia, @MaLoai)";
            using SqlConnection connection = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=QLBH;Integrated Security=True;Trust Server Certificate=True");
            using SqlCommand command = new SqlCommand(sql, connection);
            
            command.Parameters.AddWithValue("@MaSP", sp.MaSP);
            command.Parameters.AddWithValue("@TenSP", sp.TenSP);
            command.Parameters.AddWithValue("@DVTinh", sp.DVTinh);
            command.Parameters.AddWithValue("@DonGia", sp.DonGia);
            command.Parameters.AddWithValue("@MaLoai", sp.MaLoai);
            connection.Open();
            return command.ExecuteNonQuery() > 0;
        }
        public bool UpdateSanPham(DTOSanPham sp)
        {
            const string sql = @"UPDATE SanPham SET TenSP = @TenSP, DVTinh = @DVTinh, DonGia = @DonGia, MaLoai = @MaLoai WHERE MaSP = @MaSP";
            using SqlConnection connection = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=QLBH;Integrated Security=True;Trust Server Certificate=True");
            using SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@MaSP", sp.MaSP);
            command.Parameters.AddWithValue("@TenSP", sp.TenSP);
            command.Parameters.AddWithValue("@DVTinh", sp.DVTinh);
            command.Parameters.AddWithValue("@DonGia", sp.DonGia);
            command.Parameters.AddWithValue("@MaLoai", sp.MaLoai);
            connection.Open();
            return command.ExecuteNonQuery() > 0;
        }
        public bool DeleteSanPham(string maSP)
        {
            const string sql = @"DELETE FROM SanPham WHERE MaSP = @MaSP";
            using SqlConnection connection = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=QLBH;Integrated Security=True;Trust Server Certificate=True");
            using SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@MaSP", maSP);
            connection.Open();
            return command.ExecuteNonQuery() > 0;
        }
        public DataTable SearchSanPham(string tuKhoa)
        {
            const string sql = @"SELECT MaSP, TenSP, DVTinh, DonGia, MaLoai 
                                FROM SanPham WHERE MaSP LIKE @TuKhoa 
                                OR TenSP LIKE @TuKhoa 
                                OR DVTinh LIKE @TuKhoa 
                                OR MaLoai LIKE @TuKhoa
                                ORDER BY MaSP";
            DataTable dataTable = new DataTable();
            using SqlConnection connection = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=QLBH;Integrated Security=True;Trust Server Certificate=True");
            using SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@TuKhoa", "%" + tuKhoa + "%");
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
