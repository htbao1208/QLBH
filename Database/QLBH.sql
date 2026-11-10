USE [QLBH]
GO
/****** Object:  Database [QLBH]    Script Date: 11/24/2023 8:53:47 PM ******/

CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaHD] [varchar](10) NOT NULL,
	[MaSP] [varchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[GiaBan] [int] NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 11/24/2023 8:53:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [varchar](10) NOT NULL,
	[MaKH] [varchar](10) NOT NULL,
	[MaNV] [varchar](10) NOT NULL,
	[NgayHD] [datetime] NULL,
	[NgayNhan] [datetime] NULL,
	[ThanhTien] [int] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 11/24/2023 8:53:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [varchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [varchar](15) NULL,
	[Phai] [varchar](1) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 11/24/2023 8:53:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[MaLoai] [varchar](10) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiSanPham] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/24/2023 8:53:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [varchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[GioiTinh] [bit] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [varchar](15) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 11/24/2023 8:53:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [varchar](10) NOT NULL,
	[TenSP] [nvarchar](50) NOT NULL,
	[DVTinh] [nvarchar](50) NULL,
	[DonGia] [int] NULL,
	[MaLoai] [varchar](10) NOT NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (N'HD00001', N'SP001', 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (N'HD00001', N'SP002', 2, 65000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (N'HD00002', N'SP001', 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (N'HD00002', N'SP007', 10, 55000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (N'HD00002', N'SP009', 5, 4500000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (N'HD00003', N'SP012', 2, 7000000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (N'HD00004', N'SP012', 1, 7000000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (N'HD00005', N'SP011', 2, 12000000)
GO
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [MaNV], [NgayHD], [NgayNhan], [ThanhTien]) VALUES (N'HD00001', N'KH00001', N'NV003', CAST(N'2023-10-12T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [MaNV], [NgayHD], [NgayNhan], [ThanhTien]) VALUES (N'HD00002', N'KH00001', N'NV002', CAST(N'2023-10-15T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [MaNV], [NgayHD], [NgayNhan], [ThanhTien]) VALUES (N'HD00003', N'KH00002', N'NV002', CAST(N'2023-11-01T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [MaNV], [NgayHD], [NgayNhan], [ThanhTien]) VALUES (N'HD00004', N'KH00001', N'NV005', CAST(N'2023-11-14T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [MaNV], [NgayHD], [NgayNhan], [ThanhTien]) VALUES (N'HD00005', N'KH00003', N'NV005', CAST(N'2023-11-20T00:00:00.000' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [Phai]) VALUES (N'KH00001', N'Le Huu Thanh Tung', N'HCM', N'0909111334', N'M')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [Phai]) VALUES (N'KH00002', N'Nguyen Nhu Quynh', N'Binh Dinh', N'0909888777', N'F')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [Phai]) VALUES (N'KH00003', N'Vo Nguyen Hoai Linh', N'Binh Dinh', N'0878456876', N'M')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [Phai]) VALUES (N'KH00004', N'Nguyen Do Ai Linh', N'Binh Dinh', N'0989076567', N'F')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [Phai]) VALUES (N'KH00005', N'Nguyen Tan Hao', N'Quang Nam', N'0123546789', N'M')
GO
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai]) VALUES (N'L001', N'Thời trang')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai]) VALUES (N'L002', N'Báo')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai]) VALUES (N'L003', N'Sách')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai]) VALUES (N'L004', N'Đồ công nghệ')
GO
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [DiaChi], [DienThoai]) VALUES (N'NV001', N'Phung', 0, N'HCM', N'8888')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [DiaChi], [DienThoai]) VALUES (N'NV002', N'Tram', 0, N'Binh Dinh', N'9999')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [DiaChi], [DienThoai]) VALUES (N'NV003', N'Trung', 1, N'Bac Ninh', N'7777')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [DiaChi], [DienThoai]) VALUES (N'NV004', N'Trinh', 0, N'Binh Dinh', N'6666')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [DiaChi], [DienThoai]) VALUES (N'NV005', N'Thuy', 0, N'Quang Nam', N'1234')
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVTinh], [DonGia], [MaLoai]) VALUES (N'SP001', N'Giáo trình Tin học đại cương', N'quyển', 45000, N'L003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVTinh], [DonGia], [MaLoai]) VALUES (N'SP002', N'Giáo trình C# toàn tập', N'quyển', 70000, N'L003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVTinh], [DonGia], [MaLoai]) VALUES (N'SP003', N'Thiết kế Web chuyên nghiệp', N'quyển', 30000, N'L003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVTinh], [DonGia], [MaLoai]) VALUES (N'SP004', N'Áo thun 3 lỗ', N'cái', 50000, N'L001')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVTinh], [DonGia], [MaLoai]) VALUES (N'SP005', N'Quần Jean', N'cái', 200000, N'L001')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVTinh], [DonGia], [MaLoai]) VALUES (N'SP006', N'Giáo trình OOP1', N'quyển', 40000, N'L003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVTinh], [DonGia], [MaLoai]) VALUES (N'SP007', N'Giáo trình OOP2', N'quyển', 50000, N'L003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVTinh], [DonGia], [MaLoai]) VALUES (N'SP008', N'Giáo trình Kế toán', N'quyển', 45000, N'L003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVTinh], [DonGia], [MaLoai]) VALUES (N'SP009', N'Iphone 4s', N'cái', 4500000, N'L004')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVTinh], [DonGia], [MaLoai]) VALUES (N'SP010', N'Iphone 5', N'cái', 8000000, N'L004')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVTinh], [DonGia], [MaLoai]) VALUES (N'SP011', N'Iphone 5s', N'cái', 11000000, N'L004')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVTinh], [DonGia], [MaLoai]) VALUES (N'SP012', N'Máy tính bảng S', N'cái', 7000000, N'L004')
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_SanPham]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_LoaiSanPham] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiSanPham] ([MaLoai])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_LoaiSanPham]
GO
USE [master]
GO
ALTER DATABASE [QLBH] SET  READ_WRITE 
GO