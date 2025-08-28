/*Quản Lý Cửa Hàng Bán Giày*/
CREATE DATABASE QLCHBanGiay;

USE QLCHBanGiay;

--Tao bảng 
CREATE TABLE USERS(
	TenDangNhap NVARCHAR(20) NOT NULL,
	MatKhau NVARCHAR(50) NOT NULL,
	CONSTRAINT PK_USERS PRIMARY KEY (TenDangNhap)
);

-- Tạo bảng Nhân viên
CREATE TABLE NhanVien (
    MaNhanVien CHAR (20) NOT NULL,
    TenNhanVien NVARCHAR(50) NOT NULL,
	GioiTinh NVARCHAR(50),
	DiaChi NVARCHAR(255) NULL,
	DienThoai NVARCHAR(20),	
	Email NVARCHAR (200) NOT NULL,
	NgaySinh DATE,
	CONSTRAINT PK_NhanVien PRIMARY KEY (MaNhanVien)
);

-- Tạo bảng nhà phân phối
CREATE TABLE NhaPhanPhoi (
    MaNPP CHAR (20) NOT NULL,
    TenNhaPhanPhoi NVARCHAR(100) NOT NULL,
    DienThoai NVARCHAR (20),
	DiaChi NVARCHAR(50),
	CONSTRAINT PK_NhaPhanPhoi PRIMARY KEY (MaNPP)
);

--Tạo bảng Kho
CREATE TABLE Kho (
    MaKho CHAR (20) NOT NULL,
    TenKho NVARCHAR(100) NOT NULL,
	DiaChiKho NVARCHAR(100),
	CONSTRAINT PK_Kho PRIMARY KEY (MaKho)
);

-- Tạo bảng Danh mục
CREATE TABLE DanhMucSP (
    MaDanhMuc CHAR (20) NOT NULL,
    TenDanhMuc NVARCHAR(50) NOT NULL,
	CONSTRAINT PK_DanhMuc PRIMARY KEY (MaDanhMuc)
);

--Tạo bảng Phiếu Nhập
CREATE TABLE PhieuNhap (
    MaPhieuNhap CHAR (20) NOT NULL,
	MaNhanVien CHAR (20) NOT NULL,
	MaNPP CHAR (20) NOT NULL,
	NgayNhap DATE,
	TongTien DECIMAL(10, 2) NOT NULL,
	CONSTRAINT PK_PhieuNhap PRIMARY KEY (MaPhieuNhap)
);

ALTER TABLE PhieuNhap
	ADD CONSTRAINT FK_PhieuNhap_NhanVien FOREIGN KEY (MaNhanVien) REFERENCES NhanVien (MaNhanVien);
ALTER TABLE PhieuNhap
	ADD CONSTRAINT FK_PhieuNhap_NhaPhanPhoi FOREIGN KEY (MaNPP) REFERENCES NhaPhanPhoi (MaNPP);

-- Tạo bảng Sản phẩm
CREATE TABLE SanPham (
    MaSanPham CHAR(20) NOT NULL,
    TenSanPham NVARCHAR(100) NOT NULL,
    MaDanhMuc CHAR (20) NOT NULL,
	MaNPP CHAR (20) NOT NULL,
	DonGiaNhap DECIMAL(10, 2) NOT NULL,
	DonGiaBan DECIMAL(10, 2) NOT NULL,
    SoLuong NVARCHAR (50) NOT NULL,
	GhiChu NVARCHAR (200) NULL,
	CONSTRAINT PK_SanPham PRIMARY KEY (MaSanPham)
);
ALTER TABLE SanPham
	ADD CONSTRAINT FK_SanPham_DanhMucSP FOREIGN KEY (MaDanhMuc) REFERENCES DanhMucSP (MaDanhMuc);
ALTER TABLE SanPham
	ADD CONSTRAINT FK_SanPham_NhaPhanPhoi FOREIGN KEY (MaNPP) REFERENCES NhaPhanPhoi (MaNPP);

CREATE TABLE ChiTietPhieuNhap (
    MaPhieuNhap CHAR (20) NOT NULL,
	MaSanPham CHAR(20) NOT NULL,
	SoLuong NVARCHAR (50),
    DonGia DECIMAL(10, 2) NOT NULL,
	ThanhTien FLOAT NOT NULL,
	CONSTRAINT PK_ChiTietPhieuPhap PRIMARY KEY (MaPhieuNhap, MaSanPham)
);
ALTER TABLE ChiTietPhieuNhap
	ADD CONSTRAINT FK_ChiTietPhieuNhap_PhieuNhap FOREIGN KEY (MaPhieuNhap) REFERENCES PhieuNhap (MaPhieuNhap);
ALTER TABLE ChiTietPhieuNhap
	ADD CONSTRAINT FK_ChiTietPhieuNhap_SanPham FOREIGN KEY (MaSanPham) REFERENCES SanPham (MaSanPham);

-- Tạo bảng Khách hàng
CREATE TABLE KhachHang (
    MaKhachHang CHAR(20) NOT NULL,
    TenKhachHang NVARCHAR(40) NOT NULL,
    DiaChi NVARCHAR(255) NULL,
	DienThoai NVARCHAR (20),
	CONSTRAINT PK_KhachHang PRIMARY KEY (MaKhachHang)
);

-- Tạo bảng Hóa đơn
CREATE TABLE HoaDon (
    MaHoaDon CHAR (50) NOT NULL,
    MaKhachHang CHAR (20) NOT NULL,
    MaNhanVien CHAR (20) NOT NULL,
    NgayHoaDon DATE,
    TongTien DECIMAL(10, 2) NOT NULL,
	CONSTRAINT PK_HoaDon PRIMARY KEY (MaHoaDon)
);

ALTER TABLE HoaDon
	ADD CONSTRAINT FK_HoaDon_KhachHang FOREIGN KEY (MaKhachHang) REFERENCES KhachHang (MaKhachHang);
ALTER TABLE HoaDon
	ADD CONSTRAINT FK_HoaDon_NhanVien FOREIGN KEY (MaNhanVien) REFERENCES NhanVien (MaNhanVien);

-- Tạo bảng Chi tiết hóa đơn
CREATE TABLE ChiTietHoaDon (
    MaHoaDon CHAR (50) NOT NULL,
    MaSanPham CHAR (20) NOT NULL,
    SoLuong NVARCHAR (50),
    DonGia DECIMAL(10, 2) NOT NULL,

	ThanhTien FLOAT NOT NULL,
	CONSTRAINT PK_ChiTietHoaDon PRIMARY KEY (MaHoaDon, MaSanPham)
);
ALTER TABLE ChiTietHoaDon
	ADD CONSTRAINT FK_ChiTietHoaDon_SanPham FOREIGN KEY (MaSanPham) REFERENCES SanPham (MaSanPham);
ALTER TABLE ChiTietHoaDon
	ADD CONSTRAINT FK_ChiTietHoaDon_HoaDon FOREIGN KEY (MaHoaDon) REFERENCES HoaDon (MaHoaDon);
--/////////////////////////////////////////////////////////////////////////////////////////////////--