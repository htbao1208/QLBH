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

        public DataTable LoadDanhSachHoaDon() => DocDanhSach(@"
            SELECT hd.MaHD, hd.MaHD + N' - ' + ISNULL(kh.TenKH, N'') AS HienThi
            FROM dbo.HoaDon hd JOIN dbo.KhachHang kh ON hd.MaKH = kh.MaKH
            ORDER BY hd.NgayHD DESC, hd.MaHD DESC");

        public DTOHoaDon? LayHoaDon(string maHD)
        {
            using var connection = new SqlConnection(conn.ConnectionString);
            connection.Open();
            // Giữ thông tin đầu đơn nhất quán với các dòng chi tiết đang đọc.
            using var transaction = connection.BeginTransaction(IsolationLevel.RepeatableRead);
            DTOHoaDon? hoaDon = null;
            using (var command = new SqlCommand(@"
                SELECT MaHD, MaKH, MaNV, NgayHD FROM dbo.HoaDon WHERE MaHD = @MaHD;
                SELECT ct.MaSP, sp.TenSP, sp.DVTinh, ct.SoLuong, ct.GiaBan
                FROM dbo.ChiTietHoaDon ct JOIN dbo.SanPham sp ON ct.MaSP = sp.MaSP
                WHERE ct.MaHD = @MaHD ORDER BY ct.MaSP", connection, transaction))
            {
                command.Parameters.Add("@MaHD", SqlDbType.VarChar, 10).Value = maHD;
                using var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    hoaDon = new DTOHoaDon
                    {
                        MaHD = reader.GetString(0),
                        MaKH = reader.GetString(1),
                        MaNV = reader.GetString(2),
                        NgayHD = reader.IsDBNull(3) ? DateTime.Today : reader.GetDateTime(3)
                    };
                }
                reader.NextResult();
                while (hoaDon != null && reader.Read())
                {
                    hoaDon.ChiTiet.Add(new DTOChiTietHoaDon
                    {
                        MaSP = reader.GetString(0),
                        TenSP = reader.GetString(1),
                        DVTinh = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        SoLuong = reader.IsDBNull(3) ? 0 : reader.GetInt32(3),
                        GiaBan = reader.IsDBNull(4) ? 0 : reader.GetInt32(4)
                    });
                }
            }
            transaction.Commit();
            return hoaDon;
        }

        public void LuuHoaDon(DTOHoaDon hoaDon) => GhiHoaDon(hoaDon, false);
        public void CapNhatHoaDon(DTOHoaDon hoaDon) => GhiHoaDon(hoaDon, true);

        private void GhiHoaDon(DTOHoaDon hoaDon, bool capNhat)
        {
            TrongTransaction((connection, transaction) =>
            {
                string sql = capNhat
                    ? @"UPDATE dbo.HoaDon SET MaKH = @MaKH, MaNV = @MaNV,
                        NgayHD = @NgayHD, ThanhTien = @ThanhTien WHERE MaHD = @MaHD"
                    : @"INSERT INTO dbo.HoaDon (MaHD, MaKH, MaNV, NgayHD, NgayNhan, ThanhTien)
                        VALUES (@MaHD, @MaKH, @MaNV, @NgayHD, NULL, @ThanhTien)";
                using (var command = new SqlCommand(sql, connection, transaction))
                {
                    command.Parameters.Add("@MaHD", SqlDbType.VarChar, 10).Value = hoaDon.MaHD;
                    command.Parameters.Add("@MaKH", SqlDbType.VarChar, 10).Value = hoaDon.MaKH;
                    command.Parameters.Add("@MaNV", SqlDbType.VarChar, 10).Value = hoaDon.MaNV;
                    command.Parameters.Add("@NgayHD", SqlDbType.DateTime).Value = hoaDon.NgayHD;
                    command.Parameters.Add("@ThanhTien", SqlDbType.Int).Value = hoaDon.ThanhTien;
                    if (command.ExecuteNonQuery() == 0)
                        throw new InvalidOperationException("Hóa đơn không còn tồn tại. Vui lòng chọn lại hóa đơn.");
                }

                if (capNhat)
                    XoaChiTiet(connection, transaction, hoaDon.MaHD);

                using var detailCommand = new SqlCommand(@"
                    INSERT INTO dbo.ChiTietHoaDon (MaHD, MaSP, SoLuong, GiaBan)
                    VALUES (@MaHD, @MaSP, @SoLuong, @GiaBan)", connection, transaction);
                detailCommand.Parameters.Add("@MaHD", SqlDbType.VarChar, 10).Value = hoaDon.MaHD;
                detailCommand.Parameters.Add("@MaSP", SqlDbType.VarChar, 10);
                detailCommand.Parameters.Add("@SoLuong", SqlDbType.Int);
                detailCommand.Parameters.Add("@GiaBan", SqlDbType.Int);
                foreach (var dong in hoaDon.ChiTiet)
                {
                    detailCommand.Parameters["@MaSP"].Value = dong.MaSP;
                    detailCommand.Parameters["@SoLuong"].Value = dong.SoLuong;
                    detailCommand.Parameters["@GiaBan"].Value = dong.GiaBan;
                    detailCommand.ExecuteNonQuery();
                }
            });
        }

        private static void XoaChiTiet(SqlConnection connection, SqlTransaction transaction, string maHD)
        {
            using var command = new SqlCommand("DELETE FROM dbo.ChiTietHoaDon WHERE MaHD = @MaHD", connection, transaction);
            command.Parameters.Add("@MaHD", SqlDbType.VarChar, 10).Value = maHD;
            command.ExecuteNonQuery();
        }

        public void XoaHoaDon(string maHD)
        {
            TrongTransaction((connection, transaction) =>
            {
                // Xóa bảng con trước để giữ đúng khóa ngoại của SQL mẫu.
                XoaChiTiet(connection, transaction, maHD);
                using var command = new SqlCommand("DELETE FROM dbo.HoaDon WHERE MaHD = @MaHD", connection, transaction);
                command.Parameters.Add("@MaHD", SqlDbType.VarChar, 10).Value = maHD;
                if (command.ExecuteNonQuery() == 0)
                    throw new InvalidOperationException("Hóa đơn không còn tồn tại. Vui lòng chọn lại hóa đơn.");
            });
        }

        private void TrongTransaction(Action<SqlConnection, SqlTransaction> thucHien)
        {
            using var connection = new SqlConnection(conn.ConnectionString);
            connection.Open();
            using var transaction = connection.BeginTransaction();
            try
            {
                thucHien(connection, transaction);
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
                    throw new AggregateException("Không thể xử lý hóa đơn; cần kiểm tra lại kết nối cơ sở dữ liệu.", loiLuu, loiRollback);
                }
                if (loiLuu is SqlException sqlException)
                {
                    if (sqlException.Number == 2601 || sqlException.Number == 2627)
                        throw new InvalidOperationException("Mã hóa đơn đã tồn tại hoặc chi tiết bị trùng. Vui lòng kiểm tra lại.", loiLuu);
                    if (sqlException.Number == 547)
                        throw new InvalidOperationException("Dữ liệu đang được tham chiếu hoặc khách hàng, nhân viên, sản phẩm không còn tồn tại. Vui lòng tải lại dữ liệu.", loiLuu);
                }
                throw;
            }
        }
    }
}
