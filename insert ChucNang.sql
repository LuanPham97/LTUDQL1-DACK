
-- thêm chức năng (quan trọng)
---- hệ thống
--insert into CHUCNANG(MaChucNang, TenChucNang, TenTrongHeThong) values(1, N'Hệ Thống', 'rbpHeThong')
--	insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(4, N'Hệ Thống', 1)
--		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(7, N'Đơn Vị', 4)

--	insert into CHUCNANG(MaChucNang, TenChucNang, MaCha, TenTrongHeThong) values(5, N'Bảo Mật', 1, 'rpgBaoMat')
--		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha, TenTrongHeThong) values(8, N'Quản Lý Phân Quyền', 5, 'btnPhanQuyen')
--			insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(11, N'Quản Lý Người Dùng', 8)
--			insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(12, N'Vai Trò & Quyền Hạn', 8)

--		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(9, N'Đổi Mật Khẩu', 5)
--		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(10, N'Nhật Ký Hệ Thống', 5)

--	insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(6, N'Dữ Liệu', 1)
--		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(13, N'Sao Lưu', 6)
--		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(14, N'Phục Hồi', 6)
--		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(15, N'Sửa Chữa', 6)
--		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(16, N'Kết Chuyển', 6)

---- danh mục
--insert into CHUCNANG(MaChucNang, TenChucNang, TenTrongHeThong) values(2, N'Danh Mục', 'rbpDanhMuc')
	insert into CHUCNANG(MaChucNang, TenChucNang, MaCha, TenTrongHeThong) values(17, N'Đối Tác', 2, 'rpgDoiTac')
--		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(20, N'Khu Vực', 17)
		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha, TenTrongHeThong) values(21, N'Khách Hàng', 17, 'btnKhachHang')
--		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(22, N'Nhà Phân Phối', 17)

--	insert into CHUCNANG(MaChucNang, TenChucNang, MaCha, TenTrongHeThong) values(18, N'Kho Hàng', 2, 'rpgKhoHang')
		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha, TenTrongHeThong) values(23, N'Kho', 18, 'btnKhoHang')
--		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(24, N'Đơn Vị', 18)
--		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(25, N'Nhóm Hàng', 18)
--		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha, TenTrongHeThong) values(26, N'Hàng Hóa', 18, 'btnHangHoa')
--		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(27, N'In Mã Vạch', 18)
--		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(28, N'Tỷ Giá', 18)
--		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(29, N'Quy Đổi Đơn Vị', 18)

--	insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(19, N'Bộ Phận', 2)
--		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(30, N'Bộ Phận', 19)
--		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(31, N'Nhân Viên', 19)

---- chức năng
--insert into CHUCNANG(MaChucNang, TenChucNang, TenTrongHeThong) values(3, N'Chức Năng', 'rbpChucNang')
--	insert into CHUCNANG(MaChucNang, TenChucNang, MaCha, TenTrongHeThong) values(32, N'Nhập Xuất', 3, 'rpgNhapXuat')
		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha, TenTrongHeThong) values(39, N'Mua Hàng', 32, 'btnMuaHang')
--		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha, TenTrongHeThong) values(40, N'Bán Hàng', 32, 'btnBanHang')
--		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(41, N'Xuất Trả Hàng', 32)
--		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(42, N'Nhập Trả Hàng', 32)

--	insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(33, N'Công Nợ', 3)
--		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(43, N'Thu Tiền', 33)
--		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(44, N'Trả Tiền', 33)

--	insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(34, N'Kho Hàng', 3)
--		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(45, N'Nhập Kho', 34)
--		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(46, N'Xuất Kho', 34)
--		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(47, N'Tồn Kho', 34)

--	insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(35, N'Tiện Ích', 3)
--		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(48, N'Đóng Gói', 35)
--		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(49, N'Kiểm Kê', 35)
--		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(50, N'Chuyển Kho', 35)
--		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(51, N'Tổng hợp Tồn Kho', 35)

--	insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(36, N'Hóa Đơn', 3)
--		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(52, N'Hóa Đơn', 36)
--		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(53, N'Quản Lý Chứng Từ', 36)

--	insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(37, N'Báo Cáo', 3)
--		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(54, N'Báo cáo Kho', 37)
--		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(55, N'Doanh thu Bán Hàng', 37)
--		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(56, N'Hạn sử dụng', 37)

--	insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(38, N'Công Cụ', 3)
--		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(57, N'Đặt Hàng', 38)
--		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(58, N'Nhập Số Dư Ban Đầu', 38)
--		insert into CHUCNANG(MaChucNang, TenChucNang, MaCha) values(59, N'Lịch Sử Hàng Hóa', 38)