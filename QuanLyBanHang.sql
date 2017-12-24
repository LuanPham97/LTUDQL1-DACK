-- MSSV:
-- 1560320
-- 1560351
-- 1560359
-- 1560378


create database QuanLyBanHang_DoAn
go
use QuanLyBanHang_DoAn
go

-- TAB DANH MỤC
create table DONVITINH(
	MaDVTinh varchar(10) Primary key,
	TenDVTinh nvarchar(50),
	GhiChu nvarchar(50),
	ConQuanLy bit
)

create table NHOMHANG(
	MaNhomHang varchar(10) primary key,
	TenNhomHang nvarchar(50),
	GhiChu nvarchar(50),
	ConQuanLy bit
)

create table TYGIA(
	MaTyGia varchar(10) primary key,
	TenTyGia nvarchar(50),
	TyGiaQuyDoi int,
	ConQuanLy bit
)

create table KHOHANG(
	MaKho varchar(10) primary key,
	KyHieu varchar(10),
	TenKho nvarchar(50),
	NguoiQuanLy varchar(10), --fk nhan vien 
	NguoiLienHe nvarchar(50),
	DiaChi nvarchar(50),
	DienThoai varchar(15),
	Fax varchar(15),
	Email  nvarchar(50),
	DienGiai nvarchar(50),
	ConQuanLy bit
)

create table BOPHAN(
	MaBoPhan varchar(10) primary key,
	TenBoPhan nvarchar(50),
	GhiChu nvarchar(50),
	ConQuanLy bit
)

create table NHANVIEN(
	MaNhanVien varchar(10) primary key,
	TenNhanVien nvarchar(50),
	ChucVu nvarchar(50),
	DiaChi nvarchar(50),
	Email nvarchar(50),
	DienThoai varchar(15),
	BoPhan varchar(10), --fk bo phan
	NguoiQuanLy varchar(10), --fk nhan vien
	ConQuanLy bit
)

create table KHUVUC(
	MaKhuVuc varchar(10) primary key,
	TenKhuVuc nvarchar(50),
	GhiChu nvarchar(50),
	ConQuanLy bit
)

create table NHACUNGCAP(
	MaNCC varchar(10) primary key,
	KhuVuc varchar(10),  --fk khu vuc
	TenNCC nvarchar(50),
	DiaChi nvarchar(50),
	MaSoThue varchar(50),
	Fax varchar(50),
	DienThoai varchar(50),
	Mobile varchar(50),
	Email varchar(50),
	Website varchar(50),
	TaiKhoan varchar(50),
	NganHang nvarchar(50),
	GioiHanNo int,
	NoHienTai int,
	ChietKhau int,
	NguoiLienHe nvarchar(50),
	ChucVu nvarchar(50),
	ConQuanLy bit
)

create table HANGHOA(
	MaHangHoa varchar(10) primary key,
	LoaiHangHoa nvarchar(50),
	KhoMacDinh varchar(10), --fk kho hang
	PhanLoai varchar(10), --fk nhom hang
	MaVachNSX varchar(10),
	TenHang nvarchar(50),
	DonVi varchar (10), --fk don vi tinh
	XuatXu nvarchar(50),
	TonKhoToiThieu int,
	TonHienTai int,
	NhaCungCap varchar(10), --fk nha cc
	GiaMua int,
	GiaBanLe int,
	GiaBanSi int,
	ConQuanLy bit
)

create table KHACH_HANG
(
	MaKH varchar(10) primary key,
	LaKhachLe bit, --là khách lẻ hay đại lý
	MaKhuVuc varchar(10), -- fk ma khu vuc, khu vuc
	TenKH nvarchar(50),
	DiaChi nvarchar(100),
	MaSoThue varchar(50),
	Fax nvarchar(50),
	DienThoai varchar(13),
	Mobile varchar(13),
	Email varchar(50),
	Website varchar(50),
	TaiKhoan varchar(50),
	NganHang nvarchar(50),
	GioiHanNo int default (0),
	NoHienTai int default (0),
	ChietKhau int default (0),
	AccYahoo varchar(50),
	AccSkype varchar(50),
	NguoiLienHe nvarchar(50),

	ConQuanLy bit
)

go

alter table KHOHANG add constraint FK_KHOHANG_NHANVIEN foreign key (NguoiQuanLy) references NhanVien(MaNhanVien)
alter table NHANVIEN add constraint FK_NHANVIEN_BOPHAN foreign key (BoPhan) references BoPhan(MaBoPhan)
alter table NHANVIEN add constraint FK_NHANVIEN_NHANVIEN foreign key (NguoiQuanLy) references NhanVien(MaNhanVien)
alter table NHACUNGCAP add constraint FK_NHACC_KHUVUC foreign key (KhuVuc) references KhuVuc(MaKhuVuc)
alter table HANGHOA add constraint FK_HANGHOA_KHOHANG foreign key (KhoMacDinh) references KhoHang(MaKho)
alter table HANGHOA add constraint FK_HANGHOA_NHOMHANG foreign key (PhanLoai) references NhomHang(MaNhomHang)
alter table HANGHOA add constraint FK_HANGHOA_DONVI foreign key (DonVi) references DonViTinh(MaDVTinh)
alter table HANGHOA add constraint FK_HANGHOA_NHACC foreign key (NhaCungCap) references NhaCungCap(MaNCC)
alter table KHACH_HANG add constraint FK_KHACHHANG_KHUVUC foreign key (MaKhuVuc) references KhuVuc(MaKhuVuc)


---------------- THEM DU LIEU -------------
---- thêm hàng hóa
--insert into HANGHOA(MaHangHoa, TenHang, ConQuanLy) values('001', N'OMO', 1)
--insert into HANGHOA(MaHangHoa, TenHang, ConQuanLy) values('002', N'Dây đeo', 0)
--insert into HANGHOA(MaHangHoa, TenHang, ConQuanLy) values('003', N'iPhone', 1)

---- thêm kho hàng
--insert into KHOHANG(MaKho, TenKho, ConQuanLy) values('001', N'Kho Công Ty', 1)
--insert into KHOHANG(MaKho, TenKho, ConQuanLy) values('002', N'Kho Hà Nội', 1)
--insert into KHOHANG(MaKho, TenKho, ConQuanLy) values('003', N'Kho TPHCM', 1)

---- thêm nhóm hàng
--insert into NHOMHANG(MaNhomHang, TenNhomHang, ConQuanLy) values('001', N'An ninh siêu thị', 1)
--insert into NHOMHANG(MaNhomHang, TenNhomHang, ConQuanLy) values('002', N'Camera quan sát', 1)
--insert into NHOMHANG(MaNhomHang, TenNhomHang, ConQuanLy) values('003', N'Dây cáp', 1)

---- thêm khu vực
--insert into KHUVUC(MaKhuVuc, TenKhuVuc, ConQuanLy) values('001', N'Miền Bắc', 1)
--insert into KHUVUC(MaKhuVuc, TenKhuVuc, ConQuanLy) values('002', N'Miền Trung', 1)
--insert into KHUVUC(MaKhuVuc, TenKhuVuc, ConQuanLy) values('003', N'Miền Nam', 1)

---- thêm nhà cung cấp
--insert into NHACUNGCAP(MaNCC, TenNCC, KhuVuc, ConQuanLy) values('001', N'Công ty Minh An', '001', 1)
--insert into NHACUNGCAP(MaNCC, TenNCC, KhuVuc, ConQuanLy) values('002', N'Công ty Microsoft', '002', 1)
--insert into NHACUNGCAP(MaNCC, TenNCC, KhuVuc, ConQuanLy) values('003', N'Công ty Facebook', '003', 1)

---- thêm đơn vị tính
--insert into DONVITINH(MaDVTinh, TenDVTinh, ConQuanLy) values('001', N'chai', 1)
--insert into DONVITINH(MaDVTinh, TenDVTinh, ConQuanLy) values('002', N'cái', 1)
--insert into DONVITINH(MaDVTinh, TenDVTinh, ConQuanLy) values('003', N'kg', 1)

---- thêm bộ phận
--insert into BOPHAN(MaBoPhan, TenBoPhan, ConQuanLy) values('KD', N'Phòng Kinh Doanh', 1)
--insert into BOPHAN(MaBoPhan, TenBoPhan, ConQuanLy) values('GD', N'Giám Đốc', 1)
--insert into BOPHAN(MaBoPhan, TenBoPhan, ConQuanLy) values('KT', N'Phòng Kỹ Thuật', 1)

---- thêm nhân viên
--insert into NHANVIEN(MaNhanVien, TenNhanVien, Email, DienThoai, BoPhan) values('001', N'Phạm Đình Luân', 'luanpham.997@gmail.com', '0972129697', 'GD')
--insert into NHANVIEN(MaNhanVien, TenNhanVien, Email, BoPhan) values('002', N'Phan Quang Thông', 'quangthong@hptvn.com','KD')
--insert into NHANVIEN(MaNhanVien, TenNhanVien, Email, BoPhan) values('003', N'Nguyễn Thị Minh Huệ', 'huenguyen@hptvn.com','KD')

---- thêm khách hàng
--insert into KHACH_HANG(MaKH, LaKhachLe, TenKH, DienThoai, Email) values('001', 1, N'Phạm Đình Luân', '0972129697', 'luanpham.997@gmail.com')
--insert into KHACH_HANG(MaKH, LaKhachLe, TenKH, DienThoai, Email) values('002', 1, N'Khách hàng VIP', '0999999999', 'luanpham2.997@gmail.com')


--------- THÊM STORE PROCEDURES ----------
-- Lấy mã hàng hóa tiếp theo
go
create proc sp_LayMaHangHoa
	@kq varchar(10) output
as
begin
	declare @ma int
	set @ma = 1

	declare cur Cursor
	for select MaHangHoa
	from HANGHOA

	open cur
	declare @mahh varchar(10)
	fetch next from cur into @mahh
	while @@FETCH_STATUS = 0 
	begin
		if @ma != cast(@mahh as int)
			break

		set @ma += 1
		fetch next from cur into @mahh
	end
	close cur
	deallocate cur

	declare @len int, @j int--, @kq varchar(10)
	set @kq = ''
	set @len = 3 - len(cast(@ma as varchar(10)))

	set @j = 0
	while(@j < @len)
	begin
		set @kq += '0'

		set @j += 1
	end
	set @kq += CAST(@ma as varchar(3))
end
go



--------- TAB HỆ THỐNG ----------
-- PHÂN QUYỀN
create table VAITRO
(
	MaVaiTro varchar(10) primary key,
	TenVaiTro nvarchar(50),
	DienGiai nvarchar(50),
	KichHoat bit
)

go
create table NGUOIDUNG
(
	ID int identity(1,1) primary key,
	TenDangNhap varchar(20),
	Password varchar(20),
	MaVaiTro varchar(10), -- fk ma vai tro
	MaNV varchar(10), --fk ma nv
	DienGiai nvarchar(50),
	ConQuanLy bit
)

go
create table CHUCNANG
(
	MaChucNang int primary key,
	TenChucNang nvarchar(50),
	TatCa bit default(1),
	TruyCap bit default(1),
	Them bit default(1),
	Xoa bit default(1),
	Sua bit default(1),
	InAn bit default(1),
	Nhap bit default(1),
	Xuat bit default(1),
	TenTrongHeThong varchar(50),
	
	MaCha int -- fk ma chuc nang
)

go
create table VAITRO_CHUCNANG
(
	MaVaiTro varchar(10), -- fk ma vai tro
	MaChucNang int, -- fk ma chuc nang
	TatCa bit,
	TruyCap bit,
	Them bit,
	Xoa bit,
	Sua bit,
	InAn bit,
	Nhap bit,
	Xuat bit,

	Primary Key(MaVaiTro, MaChucNang)
)

go
alter table NGUOIDUNG add constraint FK_NGUOIDUNG_VAITRO foreign key (MaVaiTro) references VAITRO(MaVaiTro)
alter table NGUOIDUNG add constraint FK_NGUOIDUNG_NHANVIEN foreign key (MANV) references NHANVIEN(MaNhanVien)
alter table CHUCNANG add constraint FK_CHUCNANG_CHUCNANG foreign key (MaCha) references CHUCNANG(MaChucNang)
alter table VAITRO_CHUCNANG add constraint FK_VTCN_VAITRO foreign key (MaVaiTro) references VAITRO(MaVaiTro)
alter table VAITRO_CHUCNANG add constraint FK_VTCN_CHUCNANG foreign key (MaChucNang) references CHUCNANG(MaChucNang)


------- THÊM DỮ LIỆU
---- thêm vai trò
--insert into VAITRO(MaVaiTro, TenVaiTro, DienGiai, KichHoat) values('001', 'ADMIN', N'Admin hệ thống', 1)
--insert into VAITRO(MaVaiTro, TenVaiTro, DienGiai, KichHoat) values('002', 'Bán Hàng', N'Nhân viên bán hàng', 1)

---- thêm người dùng
--insert into NGUOIDUNG(MaNV, TenDangNhap, Password, MaVaiTro) values('001', 'admin', '', '001')


---- thêm chức năng (quan trọng)
---- hệ thống
--insert into CHUCNANG(MaChucNang, TenChucNang, TenTrongHeThong) values(1, N'Hệ Thống', 'rbpHeThong')
----	insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(4, N'Hệ Thống', 1)
----		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(7, N'Đơn Vị', 4)

--	insert into CHUCNANG(MaChucNang, TenChucNang, MaCha, TenTrongHeThong) values(5, N'Bảo Mật', 1, 'rpgBaoMat')
----		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha, TenTrongHeThong) values(8, N'Quản Lý Phân Quyền', 5, 'btnPhanQuyen')
----			insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(11, N'Quản Lý Người Dùng', 8)
----			insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(12, N'Vai Trò & Quyền Hạn', 8)

----		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(9, N'Đổi Mật Khẩu', 5)
----		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(10, N'Nhật Ký Hệ Thống', 5)

----	insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(6, N'Dữ Liệu', 1)
----		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(13, N'Sao Lưu', 6)
----		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(14, N'Phục Hồi', 6)
----		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(15, N'Sửa Chữa', 6)
----		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(16, N'Kết Chuyển', 6)

------ danh mục
--insert into CHUCNANG(MaChucNang, TenChucNang, TenTrongHeThong) values(2, N'Danh Mục', 'rbpDanhMuc')
----	insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(17, N'Đối Tác', 2)
----		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(20, N'Khu Vực', 17)
----		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(21, N'Khách Hàng', 17)
----		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(22, N'Nhà Phân Phối', 17)

--	insert into CHUCNANG(MaChucNang, TenChucNang, MaCha, TenTrongHeThong) values(18, N'Kho Hàng', 2, 'rpgKhoHang')
----		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(23, N'Kho', 18)
----		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(24, N'Đơn Vị', 18)
----		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(25, N'Nhóm Hàng', 18)
--		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha, TenTrongHeThong) values(26, N'Hàng Hóa', 18, 'btnHangHoa')
----		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(27, N'In Mã Vạch', 18)
----		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(28, N'Tỷ Giá', 18)
----		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(29, N'Quy Đổi Đơn Vị', 18)

----	insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(19, N'Bộ Phận', 2)
----		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(30, N'Bộ Phận', 19)
----		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(31, N'Nhân Viên', 19)

------ chức năng
----insert into CHUCNANG(MaChucNang, TenChucNang, TenTrongHeThong) values(3, N'Chức Năng', 'rbpChucNang')
----	insert into CHUCNANG(MaChucNang, TenChucNang, MaCha, TenTrongHeThong) values(32, N'Nhập Xuất', 3, 'rpgNhapXuat')
----		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(39, N'Mua Hàng', 32)
----		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha, TenTrongHeThong) values(40, N'Bán Hàng', 32, 'btnBanHang')
----		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(41, N'Xuất Trả Hàng', 32)
----		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(42, N'Nhập Trả Hàng', 32)

----	insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(33, N'Công Nợ', 3)
----		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(43, N'Thu Tiền', 33)
----		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(44, N'Trả Tiền', 33)

----	insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(34, N'Kho Hàng', 3)
----		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(45, N'Nhập Kho', 34)
----		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(46, N'Xuất Kho', 34)
----		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(47, N'Tồn Kho', 34)

----	insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(35, N'Tiện Ích', 3)
----		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(48, N'Đóng Gói', 35)
----		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(49, N'Kiểm Kê', 35)
----		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(50, N'Chuyển Kho', 35)
----		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(51, N'Tổng hợp Tồn Kho', 35)

----	insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(36, N'Hóa Đơn', 3)
----		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(52, N'Hóa Đơn', 36)
----		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(53, N'Quản Lý Chứng Từ', 36)

----	insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(37, N'Báo Cáo', 3)
----		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(54, N'Báo cáo Kho', 37)
----		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(55, N'Doanh thu Bán Hàng', 37)
----		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(56, N'Hạn sử dụng', 37)

----	insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(38, N'Công Cụ', 3)
----		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(57, N'Đặt Hàng', 38)
----		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(58, N'Nhập Số Dư Ban Đầu', 38)
----		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(59, N'Lịch Sử Hàng Hóa', 38)

		

--------- THÊM STORE PROCEDURES TAB PHAN QUYEN ----------
-- Lấy mã vai trò tiếp theo
go
create proc sp_LayMaVaiTro
	@kq varchar(10) output
as
begin
	declare @ma int
	set @ma = 1

	declare cur Cursor
	for select MaVaiTro
	from VAITRO

	open cur
	declare @mavt varchar(10)
	fetch next from cur into @mavt
	while @@FETCH_STATUS = 0 
	begin
		if @ma != cast(@mavt as int)
			break

		set @ma += 1
		fetch next from cur into @mavt
	end
	close cur
	deallocate cur

	declare @len int, @j int--, @kq varchar(10)
	set @kq = ''
	set @len = 3 - len(cast(@ma as varchar(10)))

	set @j = 0
	while(@j < @len)
	begin
		set @kq += '0'

		set @j += 1
	end
	set @kq += CAST(@ma as varchar(3))
end
go

-- Fill bang phan quyen
create proc FillBPQ
	@mavt varchar(10)
as
begin
	select vtcn.*, cn.MaCha
	from VAITRO_CHUCNANG vtcn, CHUCNANG cn
	where vtcn.MaChucNang = cn.MaChucNang and vtcn.MaVaiTro = @mavt
end
go


-- lay ma vai tro trong bang nguoi dung
create proc sp_GetMaVaiTroND
	@tendangnhap varchar(20),
	@mavt varchar(10) output
as
begin
	select @mavt = MaVaiTro
	from NGUOIDUNG
	where TenDangNhap = @tendangnhap
end
go



-------- TAB CHỨC NĂNG ------------
-- BÁN HÀNG

-- Phiếu xuất hàng
create table PHIEU_XUAT(
	MaPhieu varchar(10) primary key,
	MaKH varchar(10), --fk ma khach hang, khach hang
	NgayLap datetime,
	GhiChu nvarchar(200),
	SoHoaDonVAT varchar(50),
	MaNVLap varchar(10), --fk ma nv, nhan vien
	SoPhieuNhapTay varchar(50),
	MaKhoXuat varchar(10), -- fk ma kho, kho hang
	DieuKhoanThanhToan nvarchar(50),
	HinhThucThanhToan nvarchar(50),
	HanThanhToan datetime,
	NgayGiao datetime,
)
go

-- Chi tiết phiếu xuất
create table CT_PHIEU_XUAT
(
	MaPhieuXuat varchar(10), --fk ma phieu, phieu xuat
	ID int identity(1,1),
	MaHang varchar(10),
	SoLuong int default(0),
	DonGia int default(0),
	ChietKhau int default(0), -- tính theo %
	ThanhToan int default(0),

	primary key(ID, MaPhieuXuat)
)
go
--khóa ngoại
alter table PHIEU_XUAT add constraint FK_PHIEUXUAT_KH foreign key (MaKH) references KHACH_HANG(MaKH)
alter table PHIEU_XUAT add constraint FK_PHIEUXUAT_NV foreign key (MaNVLap) references NHANVIEN(MaNhanVien)
alter table PHIEU_XUAT add constraint FK_PHIEUXUAT_KHOHANG foreign key (MaKhoXuat) references KHOHANG(MaKho)

alter table CT_PHIEU_XUAT add constraint FK_CTPHIEUXUAT_PHIEUXUAT foreign key (MaPhieuXuat) references PHIEU_XUAT(MaPhieu)


-- proc
go
-- lấy mã phiếu xuất tiếp theo
create proc sp_LayMaPhieuXuat
	@kq varchar(10) output
as
begin
	declare @ma int
	set @ma = 1

	declare cur Cursor
	for select MaPhieu
	from PHIEU_XUAT

	open cur
	declare @mahh varchar(10)
	fetch next from cur into @mahh
	while @@FETCH_STATUS = 0 
	begin
		if @ma != cast(@mahh as int)
			break

		set @ma += 1
		fetch next from cur into @mahh
	end
	close cur
	deallocate cur

	declare @len int, @j int--, @kq varchar(10)
	set @kq = ''
	set @len = 3 - len(cast(@ma as varchar(10)))

	set @j = 0
	while(@j < @len)
	begin
		set @kq += '0'

		set @j += 1
	end
	set @kq += CAST(@ma as varchar(3))
end
go

-- lấy thông tin khách hàng
create proc sp_LayThongTinKhachHang
	@diachi nvarchar(100) output,
	@dt varchar(13) output,
	@makh varchar(10)
as
begin
	select @diachi=DiaChi, @dt=DienThoai
	from KHACH_HANG
	where MaKH = @makh
end
go

-- lấy tên đơn vị và đơn giá dựa vào mã hàng hóa
create proc sp_LayThongTinHangHoa
	@mahh varchar(10),
	@tendv nvarchar(50) output,
	@dongia int out,
	@slTon int out
as
begin
	set @tendv = ''
	set @dongia = 0
	select @tendv = dv.TenDVTinh, @dongia = hh.GiaBanLe, @slton = hh.TonHienTai
	from HANGHOA hh, DONVITINH dv
	where hh.DonVi=dv.MaDVTinh and hh.MaHangHoa=@mahh
end
go
--

-- lấy mã khách hàng tiếp theo
create proc sp_LayMaKHTiepTheo
	@kq varchar(10) output
as
begin
	declare @ma int
	set @ma = 1

	declare cur Cursor
	for select MaKH
	from KHACH_HANG

	open cur
	declare @mahh varchar(10)
	fetch next from cur into @mahh
	while @@FETCH_STATUS = 0 
	begin
		if @ma != cast(@mahh as int)
			break

		set @ma += 1
		fetch next from cur into @mahh
	end
	close cur
	deallocate cur

	declare @len int, @j int--, @kq varchar(10)
	set @kq = ''
	set @len = 3 - len(cast(@ma as varchar(10)))

	set @j = 0
	while(@j < @len)
	begin
		set @kq += '0'

		set @j += 1
	end
	set @kq += CAST(@ma as varchar(3))
end
go