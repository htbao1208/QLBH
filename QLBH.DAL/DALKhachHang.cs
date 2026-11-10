using Microsoft.Data.SqlClient;
using QLBH.DTO;
using System.Data;

namespace QLBH.DAL
{
    public class DALKhachHang : DBConnection
    {
        public DataTable loadKhachHang()
        {
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT MaKH, TenKH, DiaChi, DienThoai, Phai FROM KhachHang ORDER BY MaKH", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable SearchKhachHang(string tuKhoa)
        {
            const string sql = @"SELECT MaKH, TenKH, DiaChi, DienThoai, Phai
                                 FROM KhachHang
                                 WHERE MaKH LIKE @TuKhoa OR TenKH LIKE @TuKhoa
                                 ORDER BY MaKH";
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.Add("@TuKhoa", SqlDbType.NVarChar, 100).Value = "%" + tuKhoa + "%";
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool KiemTraTonTai(string maKH)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM KhachHang WHERE MaKH = @MaKH", conn);
                cmd.Parameters.Add("@MaKH", SqlDbType.VarChar, 10).Value = maKH;
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
            finally
            {
                conn.Close();
            }
        }

        public int DemHoaDonTheoKhachHang(string maKH)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM HoaDon WHERE MaKH = @MaKH", conn);
                cmd.Parameters.Add("@MaKH", SqlDbType.VarChar, 10).Value = maKH;
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            finally
            {
                conn.Close();
            }
        }

        public bool InsertKhachHang(DTOKhachHang kh)
        {
            const string sql = @"INSERT INTO KhachHang (MaKH, TenKH, DiaChi, DienThoai, Phai)
                                 VALUES (@MaKH, @TenKH, @DiaChi, @DienThoai, @Phai)";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                GanThamSo(cmd, kh);
                return cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool UpdateKhachHang(DTOKhachHang kh)
        {
            const string sql = @"UPDATE KhachHang SET TenKH = @TenKH, DiaChi = @DiaChi,
                                 DienThoai = @DienThoai, Phai = @Phai WHERE MaKH = @MaKH";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                GanThamSo(cmd, kh);
                return cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool DeleteKhachHang(string maKH)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM KhachHang WHERE MaKH = @MaKH", conn);
                cmd.Parameters.Add("@MaKH", SqlDbType.VarChar, 10).Value = maKH;
                return cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                conn.Close();
            }
        }

        private void GanThamSo(SqlCommand cmd, DTOKhachHang kh)
        {
            cmd.Parameters.Add("@MaKH", SqlDbType.VarChar, 10).Value = kh.MaKH;
            cmd.Parameters.Add("@TenKH", SqlDbType.NVarChar, 50).Value = kh.TenKH;
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 50).Value = kh.DiaChi;
            cmd.Parameters.Add("@DienThoai", SqlDbType.VarChar, 15).Value = kh.DienThoai;
            cmd.Parameters.Add("@Phai", SqlDbType.VarChar, 1).Value = kh.Phai;
        }
    }
}
