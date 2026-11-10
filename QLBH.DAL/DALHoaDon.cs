using System.Data;
using Microsoft.Data.SqlClient;
using QLBH.DTO;

namespace QLBH.DAL
{
    public class DALHoaDon : DBConnection
    {
        private DataTable DocDanhSach(string sql)
        {
            using var connection = new SqlConnection(conn.ConnectionString);
            using var adapter = new SqlDataAdapter(sql, connection);
            var table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable LoadKhachHang() => DocDanhSach(
            "SELECT MaKH, MaKH + N' - ' + ISNULL(TenKH, N'') AS HienThi FROM dbo.KhachHang ORDER BY MaKH");

        public DataTable LoadNhanVien() => DocDanhSach(
            "SELECT MaNV, MaNV + N' - ' + TenNV AS HienThi FROM dbo.NhanVien ORDER BY MaNV");

        public DataTable LoadSanPham() => DocDanhSach(
            "SELECT MaSP, TenSP, DVTinh, DonGia, MaSP + N' - ' + TenSP AS HienThi FROM dbo.SanPham ORDER BY MaSP");

        public void LuuHoaDon(DTOHoaDon hoaDon)
        {
            using var connection = new SqlConnection(conn.ConnectionString);
            connection.Open();
            using var transaction = connection.BeginTransaction();
            try
            {
                using (var command = new SqlCommand(@"
                    INSERT INTO dbo.HoaDon (MaHD, MaKH, MaNV, NgayHD, NgayNhan, ThanhTien)
                    VALUES (@MaHD, @MaKH, @MaNV, @NgayHD, NULL, @ThanhTien)", connection, transaction))
                {
                    command.Parameters.Add("@MaHD", SqlDbType.VarChar, 10).Value = hoaDon.MaHD;
                    command.Parameters.Add("@MaKH", SqlDbType.VarChar, 10).Value = hoaDon.MaKH;
                    command.Parameters.Add("@MaNV", SqlDbType.VarChar, 10).Value = hoaDon.MaNV;
                    command.Parameters.Add("@NgayHD", SqlDbType.DateTime).Value = hoaDon.NgayHD;
                    command.Parameters.Add("@ThanhTien", SqlDbType.Int).Value = hoaDon.ThanhTien;
                    command.ExecuteNonQuery();
                }

                using (var command = new SqlCommand(@"
                    INSERT INTO dbo.ChiTietHoaDon (MaHD, MaSP, SoLuong, GiaBan)
                    VALUES (@MaHD, @MaSP, @SoLuong, @GiaBan)", connection, transaction))
                {
                    command.Parameters.Add("@MaHD", SqlDbType.VarChar, 10).Value = hoaDon.MaHD;
                    command.Parameters.Add("@MaSP", SqlDbType.VarChar, 10);
                    command.Parameters.Add("@SoLuong", SqlDbType.Int);
                    command.Parameters.Add("@GiaBan", SqlDbType.Int);
                    foreach (var dong in hoaDon.ChiTiet)
                    {
                        command.Parameters["@MaSP"].Value = dong.MaSP;
                        command.Parameters["@SoLuong"].Value = dong.SoLuong;
                        command.Parameters["@GiaBan"].Value = dong.GiaBan;
                        command.ExecuteNonQuery();
                    }
                }

                transaction.Commit();
            }
            catch (Exception loiLuu)
            {
                try
                {
                    transaction.Rollback();
                }
                catch (Exception loiRollback)
                {
                    throw new AggregateException("Không thể lưu hóa đơn; cần kiểm tra lại kết nối cơ sở dữ liệu.", loiLuu, loiRollback);
                }

                if (loiLuu is SqlException sqlException)
                {
                    if (sqlException.Number == 2601 || sqlException.Number == 2627)
                        throw new InvalidOperationException("Mã hóa đơn đã tồn tại hoặc chi tiết bị trùng. Vui lòng kiểm tra lại.", loiLuu);
                    if (sqlException.Number == 547)
                        throw new InvalidOperationException("Khách hàng, nhân viên hoặc sản phẩm không còn tồn tại. Vui lòng mở lại form để tải dữ liệu mới.", loiLuu);
                }
                throw;
            }
        }
    }
}
