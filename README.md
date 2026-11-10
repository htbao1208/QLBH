# Project Quản Lý Bán Hàng (QLBH)

Ứng dụng WinForms (C#) quản lý bán hàng, xây dựng theo mô hình nhiều lớp.

## 1. Cấu trúc solution

```
QuanLyBanHang/
├── GUI/        # Giao diện WinForms (các Form)
├── BLL/        # Business Logic Layer - xử lý nghiệp vụ, kiểm tra dữ liệu
├── DAL/        # Data Access Layer - truy cập SQL Server
├── DTO/        # Data Transfer Object - các lớp dữ liệu
├── Database/
│   └── QLBH.sql   # Script tạo CSDL + dữ liệu mẫu
├── .gitignore
└── README.md
```

Luồng gọi: **GUI → BLL → DAL → SQL Server** (DTO dùng chung cho các lớp).

Tham chiếu giữa project: GUI → BLL, DTO | BLL → DAL, DTO | DAL → DTO.

## 2. Hướng dẫn chạy

1. Cài **Visual Studio** (workload *.NET desktop development*) và **SQL Server**.
2. Mở SQL Server Management Studio, chạy file `Database/QLBH.sql` để tạo CSDL `QLBH`.
3. Mở file `.slnx` bằng Visual Studio.
4. Sửa chuỗi kết nối (Server name) trong lớp DAL cho đúng máy của bạn.
5. Build solution (`Ctrl + Shift + B`) rồi chạy (`F5`).


## 3. Quy ước nhóm

### Đặt tên Form (bắt buộc, để dễ gom bài)
`frmDangNhap`, `frmMain`, `frmLoaiSanPham`, `frmSanPham`, `frmKhachHang`, `frmHoaDon`

### Đặt tên DTO / BLL / DAL
Ví dụ: `DTOLoaiSanPham`, `BLLLoaiSanPham`, `DALLoaiSanPham`.

### Tên cột dùng thống nhất
- Sản phẩm: `MaSP, TenSP, DVTinh, DonGia, MaLoai`
- Loại sản phẩm: `MaLoai, TenLoai`

### Cơ sở dữ liệu
- **Giữ đúng cấu trúc file SQL mẫu**, không tự sửa bảng/cột.
- Sửa cấu trúc có thể làm các bảng khác lỗi hoặc không truy vấn được.
