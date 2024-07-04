create database QLTUYENDUNG
GO
--drop database QLTUYENDUNG
use QLTUYENDUNG
GO


create table DOANHNGHIEP (
	IDDoanhNghiep varchar(5),
	Ten nvarchar(255), 
	Email nvarchar(255), 
	DiaChi nvarchar(255), 
	TaxID varchar(9),
	primary key (IDDoanhNghiep)
)

create table NHANVIEN (
	IDNV varchar(5),
	Ten nvarchar(255),
	NgaySinh date,
	DT varchar(10), 
	DiaChi nvarchar(255),
	ChucDanh nvarchar(255), 
	PhongBan nvarchar(255),
	Luong int, 
	GioiTinh nvarchar(3) check (GioiTinh in ('Nam', N'Nữ')),
	primary key (IDNV)
)

create table THONGTINDANGTUYEN (
	IDTTDT varchar(5),
	ThoiGianDT datetime,
	HinhThucDT nvarchar(255),
	NgayHetHan date, 
	TinhTrang nvarchar(255),
	GhiChu ntext, 
	IDDoanhNghiep varchar(5),
	NhanVienDuyet varchar(5), 
	primary key (IDTTDT)
)

create table UUDAI (
	IDUuDai varchar(5), 
	Mota ntext, 
	Ten nvarchar(255),
	primary key (IDUuDai)
)

create table CTUUDAI (
	IDTTDT varchar(5),
	IDUuDai varchar(5),
	primary key (IDTTDT, IDUuDai)
)

create table CTTTDANGTUYEN (
	IDTTDT varchar(5),
	IDCTTTDT varchar(5), 
	ViTri nvarchar(255),
	SoLuong int,
	YeuCauUngVien ntext,
	primary key (IDTTDT, IDCTTTDT)
)

create table HOADON (
	IDHoaDon varchar(5),
	PhuongThucTT nvarchar(100), 
	TrangThaiTT nvarchar(100), 
	NgayTT date, 
	TongTien money, 
	IDTTDT varchar(5),
	primary key (IDHoaDon)
)

create table HOADONTHEODOT (
	IDHoaDon varchar(5), 
	Dot int,
	PhuongThucTT nvarchar(100), 
	TrangThaiTT nvarchar(100),
	NgayTT date, 
	Tien money,
	primary key (IDHoaDon, Dot)
)

create table PHIEUQUANGCAO (
	ID varchar(5),
	ThoiGianThue datetime, 
	ThongTinThue ntext,
	ThongTinQuangCao ntext, 
	IDTTDT varchar(5), 
	primary key (ID)
)


create table PHIEUDANGKYUNGTUYEN (
	IDHoSo varchar(5), 
	IDTTDT varchar(5), 
	IDCTTTDT varchar(5), 
	NhanVienDuyet varchar(5),
	TinhTrang varchar(100), 
	primary key (IDHoSo, IDTTDT, IDCTTTDT)
)

create table UNGVIEN (
	IDUngVien varchar(5), 
	Ten nvarchar(255), 
	Email nvarchar(255), 
	DT varchar(10), 
	CCCD varchar(12), 
	DiaChi nvarchar(255),
	GioiTinh nvarchar(3) check (GioiTinh in ('Nam', N'Nữ')),
	primary key (IDUngVien)
)

create table HOSOUNGVIEN (
	IDHoSo varchar(5), 
	HocVan ntext,
	KinhNghiem ntext, 
	KiNang ntext, 
	Anh nvarchar(100), 
	IDUngVien varchar(5),
	primary key (IDHoSo) 
)

create table BANGCAP (
	ID varchar(5),
	Ten nvarchar(100),
	NgayHetHan date,
	NgayNop date,
	IDHoSo varchar(5),
	primary key (ID)
)

create table ACCOUNT (
	username varchar(255),
	psw varchar(255),
	accountType nvarchar(100), 
	IDNV varchar(5),
	PRIMARY KEY (username)
)

-- Foreign key 

alter table THONGTINDANGTUYEN 
add constraint fk_TTDT_DN
foreign key (IDDoanhNghiep) references DOANHNGHIEP(IDDoanhNghiep)

alter table THONGTINDANGTUYEN
add constraint fk_TTDT_NV
foreign key (NhanVienDuyet) references NHANVIEN(IDNV)

alter table CTUUDAI 
add constraint fk_CTUUDAI_TTDT
foreign key (IDTTDT) references THONGTINDANGTUYEN(IDTTDT)

alter table CTUUDAI 
add constraint fk_CTUUDAI_UUDAI
foreign key (IDUuDai) references UUDAI(IDUuDai)

alter table CTTTDANGTUYEN
add constraint fk_CTTTDT_TTDT
foreign key (IDTTDT) references THONGTINDANGTUYEN(IDTTDT)

alter table HOADON
add constraint fk_HOADON_TTDT
foreign key (IDTTDT) references THONGTINDANGTUYEN(IDTTDT)

alter table HOADONTHEODOT
add constraint fk_HOADONTHEODOT_HOADON
foreign key (IDHoaDon) references HOADON(IDHoaDon)

alter table PHIEUQUANGCAO
add constraint fk_PHIEUQC_TTDT
foreign key (IDTTDT) references THONGTINDANGTUYEN(IDTTDT)

alter table PHIEUDANGKYUNGTUYEN
add constraint fk_PHIEUDK_CTTTDT
foreign key (IDTTDT, IDCTTTDT) references CTTTDANGTUYEN(IDTTDT, IDCTTTDT)

alter table PHIEUDANGKYUNGTUYEN
add constraint fk_PHIEUDK_HOSOUNGVIEN
foreign key (IDHoSo) references HOSOUNGVIEN(IDHoSo)

alter table PHIEUDANGKYUNGTUYEN
add constraint fk_PHIEUDK_NHANVIEN
foreign key (NhanVienDuyet) references NHANVIEN(IDNV)

alter table HOSOUNGVIEN
add constraint fk_HOSOUNGVIEN_UNGVIEN
foreign key (IDUngVien) references UNGVIEN(IDUngVien)

alter table BANGCAP
add constraint fk_BANGCAP_HOSOUNGVIEN
foreign key (IDHoSo) references HOSOUNGVIEN(IDHoSo)

alter table ACCOUNT
add constraint fk_ACCOUNT_NV
foreign key (IDNV) references NHANVIEN(IDNV)

---INSERT DATA
-- Insert data into DOANHNGHIEP
INSERT INTO DOANHNGHIEP (IDDoanhNghiep, Ten, Email, DiaChi, TaxID) VALUES
('DN001', N'Công ty ABC', 'abc@example.com', N'Hà Nội', '123456789'),
('DN002', N'Công ty XYZ', 'xyz@example.com', N'TP. Hồ Chí Minh', '987654321'),
('DN003', N'Công ty 123', '123@example.com', N'Đà Nẵng', '111222333'),
('DN004', N'Công ty 456', '456@example.com', N'Hải Phòng', '444555666'),
('DN005', N'Công ty 789', '789@example.com', N'Cần Thơ', '777888999'),
('DN006', N'Công ty QWE', 'qwe@example.com', N'Quảng Ninh', '000111222'),
('DN007', N'Công ty RTY', 'rty@example.com', N'Bình Dương', '333444555'),
('DN008', N'Công ty UIO', 'uio@example.com', N'Vũng Tàu', '666777888'),
('DN009', N'Công ty PAS', 'pas@example.com', N'Kiên Giang', '999000111'),
('DN010', N'Công ty DFG', 'dfg@example.com', N'Lào Cai', '222333444');

-- Insert dữ liệu vào bảng NHANVIEN
INSERT INTO NHANVIEN (IDNV, Ten, NgaySinh, DT, DiaChi, ChucDanh, PhongBan, Luong, GioiTinh)
VALUES
    ('NV001', N'Nguyễn Văn A', '1990-05-15', '0901234567', N'123 Đường ABC, Quận 1, TP.HCM', N'Nhân viên đăng tuyển', N'Phòng Nhân sự', 15000000, N'Nam'),
    ('NV002', N'Trần Thị B', '1992-08-20', '0902345678', N'456 Đường XYZ, Quận 2, TP.HCM', N'Nhân viên tiếp tân', N'Phòng Tiếp tân', 12000000, N'Nữ'),
    ('NV003', N'Phạm Văn C', '1985-03-10', '0903456789', N'789 Đường KLM, Quận 3, TP.HCM', N'Nhân viên tuyển dụng', N'Phòng Nhân sự', 16000000, N'Nam'),
    ('NV004', N'Huỳnh Thị D', '1993-12-25', '0904567890', N'234 Đường PQR, Quận 4, TP.HCM', N'Nhân viên phòng pháp lý', N'Phòng Pháp lý', 18000000, N'Nữ'),
    ('NV005', N'Lê Văn E', '1988-07-03', '0905678901', N'567 Đường UVW, Quận 5, TP.HCM', N'Nhân viên đăng tuyển', N'Phòng Nhân sự', 14000000, N'Nam'),
    ('NV006', N'Nguyễn Thị F', '1991-09-18', '0906789012', N'890 Đường HIJ, Quận 6, TP.HCM', N'Nhân viên tiếp tân', N'Phòng Tiếp tân', 13000000, N'Nữ'),
    ('NV007', N'Trần Văn G', '1987-04-05', '0907890123', N'123 Đường LMN, Quận 7, TP.HCM', N'Nhân viên tuyển dụng', N'Phòng Nhân sự', 17000000, N'Nam'),
    ('NV008', N'Phan Thị H', '1994-11-12', '0908901234', N'456 Đường QRS, Quận 8, TP.HCM', N'Nhân viên phòng pháp lý', N'Phòng Pháp lý', 19000000, N'Nữ'),
    ('NV009', N'Võ Văn I', '1986-06-30', '0909012345', N'789 Đường TUV, Quận 9, TP.HCM', N'Nhân viên đăng tuyển', N'Phòng Nhân sự', 13500000, N'Nam'),
    ('NV010', N'Dương Thị K', '1990-02-17', '0900123456', N'234 Đường WXY, Quận 10, TP.HCM', N'Nhân viên tiếp tân', N'Phòng Tiếp tân', 12500000, N'Nữ');


-- Insert data into THONGTINDANGTUYEN
INSERT INTO THONGTINDANGTUYEN (IDTTDT, ThoiGianDT, HinhThucDT, NgayHetHan, TinhTrang, GhiChu, IDDoanhNghiep, NhanVienDuyet) VALUES
('TT001', '2024-01-15 09:00:00', N'Trực tiếp', '2024-02-15', N'Đang tuyển', N'', 'DN001', 'NV001'),
('TT002', '2024-02-20 10:00:00', N'Trực tiếp', '2024-03-20', N'Đang tuyển', N'', 'DN002', 'NV002'),
('TT003', '2024-03-25 11:00:00', N'Trực tiếp', '2024-04-25', N'Đang tuyển', N'', 'DN003', 'NV003'),
('TT004', '2024-04-30 12:00:00', N'Trực tiếp', '2024-05-30', N'Đang tuyển', N'', 'DN004', 'NV004'),
('TT005', '2024-05-05 13:00:00', N'Trực tiếp', '2024-06-05', N'Đang tuyển', N'', 'DN005', 'NV005'),
('TT006', '2024-06-10 14:00:00', N'Trực tiếp', '2024-07-10', N'Đang tuyển', N'', 'DN006', 'NV006'),
('TT007', '2024-07-15 15:00:00', N'Trực tiếp', '2024-08-15', N'Đang tuyển', N'', 'DN007', 'NV007'),
('TT008', '2024-08-20 16:00:00', N'Trực tiếp', '2024-09-20', N'Đang tuyển', N'', 'DN008', 'NV008'),
('TT009', '2024-09-25 17:00:00', N'Trực tiếp', '2024-10-25', N'Đang tuyển', N'', 'DN009', 'NV009'),
('TT010', '2024-10-30 18:00:00', N'Trực tiếp', '2024-11-30', N'Đang tuyển', N'', 'DN010', 'NV010');

-- Insert data into UUDAI
INSERT INTO UUDAI (IDUuDai, Mota, Ten) VALUES
('UD001', N'Giảm giá 10%', N'Giảm giá đầu năm'),
('UD002', N'Tặng quà', N'Quà tặng đặc biệt'),
('UD003', N'Miễn phí vận chuyển', N'Giao hàng miễn phí'),
('UD004', N'Giảm giá 20%', N'Giảm giá mùa hè'),
('UD005', N'Tặng voucher', N'Voucher mua hàng'),
('UD006', N'Giảm giá 15%', N'Giảm giá cuối năm'),
('UD007', N'Tặng phiếu mua hàng', N'Phiếu mua hàng miễn phí'),
('UD008', N'Miễn phí dịch vụ', N'Dịch vụ miễn phí'),
('UD009', N'Giảm giá 25%', N'Giảm giá đặc biệt'),
('UD010', N'Tặng coupon', N'Coupon giảm giá');

-- Insert data into CTUUDAI
INSERT INTO CTUUDAI (IDTTDT, IDUuDai) VALUES
('TT001', 'UD001'),
('TT002', 'UD002'),
('TT003', 'UD003'),
('TT004', 'UD004'),
('TT005', 'UD005'),
('TT006', 'UD006'),
('TT007', 'UD007'),
('TT008', 'UD008'),
('TT009', 'UD009'),
('TT010', 'UD010');

-- Insert data into CTTTDANGTUYEN
INSERT INTO CTTTDANGTUYEN (IDTTDT, IDCTTTDT, ViTri, SoLuong, YeuCauUngVien) VALUES
('TT001', 'CT001', N'Kế toán', 2, N'Tốt nghiệp đại học, có kinh nghiệm 2 năm'),
('TT002', 'CT002', N'Nhân viên kinh doanh', 3, N'Tốt nghiệp cao đẳng, có kinh nghiệm 1 năm'),
('TT003', 'CT003', N'Marketing', 1, N'Tốt nghiệp đại học, có kỹ năng thiết kế đồ họa'),
('TT004', 'CT004', N'Nhân sự', 2, N'Tốt nghiệp cao đẳng, có kỹ năng quản lý'),
('TT005', 'CT005', N'Kỹ thuật', 4, N'Tốt nghiệp đại học, có kinh nghiệm làm việc với máy móc'),
('TT006', 'CT006', N'Tài chính', 1, N'Tốt nghiệp đại học, có kinh nghiệm kế toán'),
('TT007', 'CT007', N'IT', 3, N'Tốt nghiệp đại học, có kinh nghiệm lập trình'),
('TT008', 'CT008', N'Trưởng phòng kinh doanh', 1, N'Tốt nghiệp đại học, có kỹ năng quản lý đội nhóm'),
('TT009', 'CT009', N'Nhân viên kho', 2, N'Tốt nghiệp trung cấp, có sức khỏe tốt'),
('TT010', 'CT010', N'Chăm sóc khách hàng', 3, N'Tốt nghiệp cao đẳng, có kỹ năng giao tiếp tốt');

-- Insert data into HOADON
INSERT INTO HOADON (IDHoaDon, PhuongThucTT, TrangThaiTT, NgayTT, TongTien, IDTTDT) VALUES
('HD001', N'Trực tiếp', N'Đã thanh toán', '2024-01-05', 1500000, 'TT001'),
('HD002', N'Bằng thẻ thanh toán', N'Chưa thanh toán', '2024-02-10', 2500000, 'TT002'),
('HD003', N'Trực tiếp', N'Đã thanh toán', '2024-03-15', 2000000, 'TT003'),
('HD004', N'Bằng thẻ thanh toán', N'Chưa thanh toán', '2024-04-20', 3000000, 'TT004'),
('HD005', N'Trực tiếp', N'Đã thanh toán', '2024-05-25', 3500000, 'TT005'),
('HD006', N'Bằng thẻ thanh toán', N'Chưa thanh toán', '2024-06-30', 4000000, 'TT006'),
('HD007', N'Trực tiếp', N'Đã thanh toán', '2024-07-05', 4500000, 'TT007'),
('HD008', N'Bằng thẻ thanh toán', N'Chưa thanh toán', '2024-08-10', 5000000, 'TT008'),
('HD009', N'Trực tiếp', N'Đã thanh toán', '2024-09-15', 5500000, 'TT009'),
('HD010', N'Bằng thẻ thanh toán', N'Chưa thanh toán', '2024-10-20', 6000000, 'TT010');

-- Insert data into HOADONTHEODOT
INSERT INTO HOADONTHEODOT (IDHoaDon, Dot, PhuongThucTT, TrangThaiTT, NgayTT, Tien) VALUES
('HD001', 1, N'Trực tiếp', N'Đã thanh toán', '2024-01-05', 1000000),
('HD001', 2, N'Bằng thẻ thanh toán', N'Chưa thanh toán', '2024-02-10', 500000),
('HD002', 1, N'Trực tiếp', N'Đã thanh toán', '2024-03-15', 2000000),
('HD002', 2, N'Bằng thẻ thanh toán', N'Chưa thanh toán', '2024-04-20', 1000000),
('HD003', 1, N'Trực tiếp', N'Đã thanh toán', '2024-05-25', 1500000),
('HD003', 2, N'Bằng thẻ thanh toán', N'Chưa thanh toán', '2024-06-30', 750000),
('HD004', 1, N'Trực tiếp', N'Đã thanh toán', '2024-07-05', 3000000),
('HD004', 2, N'Bằng thẻ thanh toán', N'Chưa thanh toán', '2024-08-10', 1500000),
('HD005', 1, N'Trực tiếp', N'Đã thanh toán', '2024-09-15', 2500000),
('HD005', 2, N'Bằng thẻ thanh toán', N'Chưa thanh toán', '2024-10-20', 1250000);

-- Insert data into PHIEUQUANGCAO
INSERT INTO PHIEUQUANGCAO (ID, ThoiGianThue, ThongTinThue, ThongTinQuangCao, IDTTDT) VALUES
('PQ001', '2024-01-10 10:00:00', N'Tháng 1', N'Quảng cáo trên website', 'TT001'),
('PQ002', '2024-02-15 11:00:00', N'Tháng 2', N'Quảng cáo trên mạng xã hội', 'TT002'),
('PQ003', '2024-03-20 12:00:00', N'Tháng 3', N'Quảng cáo trên báo', 'TT003'),
('PQ004', '2024-04-25 13:00:00', N'Tháng 4', N'Quảng cáo trên TV', 'TT004'),
('PQ005', '2024-05-30 14:00:00', N'Tháng 5', N'Quảng cáo trên radio', 'TT005'),
('PQ006', '2024-06-05 15:00:00', N'Tháng 6', N'Quảng cáo ngoài trời', 'TT006'),
('PQ007', '2024-07-10 16:00:00', N'Tháng 7', N'Quảng cáo trên xe bus', 'TT007'),
('PQ008', '2024-08-15 17:00:00', N'Tháng 8', N'Quảng cáo trên tạp chí', 'TT008'),
('PQ009', '2024-09-20 18:00:00', N'Tháng 9', N'Quảng cáo trên YouTube', 'TT009'),
('PQ010', '2024-10-25 19:00:00', N'Tháng 10', N'Quảng cáo trên blog', 'TT010');

-- Insert data into UNGVIEN
INSERT INTO UNGVIEN (IDUngVien, Ten, Email, DT, CCCD, DiaChi, GioiTinh) VALUES
('UV001', N'Nguyễn Văn L', 'nguyenvanl@example.com', '0912345671', '012345678901', N'Hà Nội', N'Nam'),
('UV002', N'Trần Thị M', 'tranthim@example.com', '0923456782', '123456789012', N'TP. Hồ Chí Minh', N'Nữ'),
('UV003', N'Lê Văn N', 'levann@example.com', '0934567893', '234567890123', N'Đà Nẵng', N'Nam'),
('UV004', N'Phạm Thị O', 'phamthio@example.com', '0945678904', '345678901234', N'Hải Phòng', N'Nữ'),
('UV005', N'Hoàng Văn P', 'hoangvanp@example.com', '0956789015', '456789012345', N'Cần Thơ', N'Nam'),
('UV006', N'Nguyễn Thị Q', 'nguyenthq@example.com', '0967890126', '567890123456', N'Quảng Ninh', N'Nữ'),
('UV007', N'Phạm Văn R', 'phamvanr@example.com', '0978901237', '678901234567', N'Bình Dương', N'Nam'),
('UV008', N'Lê Thị S', 'lethis@example.com', '0989012348', '789012345678', N'Vũng Tàu', N'Nữ'),
('UV009', N'Trần Văn T', 'tranvant@example.com', '0990123459', '890123456789', N'Kiên Giang', N'Nam'),
('UV010', N'Hoàng Thị U', 'hoangthiu@example.com', '0911123450', '901234567890', N'Lào Cai', N'Nữ');

-- Insert data into HOSOUNGVIEN
INSERT INTO HOSOUNGVIEN (IDHoSo, HocVan, KinhNghiem, KiNang, Anh, IDUngVien) VALUES
('HS001', N'Đại học', N'3 năm', N'Giao tiếp, Quản lý thời gian', 'CV001.jpg', 'UV001'),
('HS002', N'Cao đẳng', N'2 năm', N'Làm việc nhóm, Giải quyết vấn đề', 'CV002.png', 'UV002'),
('HS003', N'Trung cấp', N'1 năm', N'Kỹ năng bán hàng, Thuyết trình', 'CV003.jpg', 'UV003'),
('HS004', N'Đại học', N'4 năm', N'Kỹ năng lập trình, Thiết kế đồ họa', 'CV004.png', 'UV004'),
('HS005', N'Cao đẳng', N'2 năm', N'Quản lý dự án, Kỹ năng lãnh đạo', 'CV005.jpg', 'UV005'),
('HS006', N'Trung cấp', N'3 năm', N'Kỹ năng văn phòng, Xử lý tình huống', 'CV006.png', 'UV006'),
('HS007', N'Đại học', N'1 năm', N'Thuyết trình, Tư duy sáng tạo', 'CV007.jpg', 'UV007'),
('HS008', N'Cao đẳng', N'4 năm', N'Làm việc độc lập, Quản lý dự án', 'CV008.png', 'UV008'),
('HS009', N'Trung cấp', N'2 năm', N'Giao tiếp, Quản lý thời gian', 'CV009.jpg', 'UV009'),
('HS010', N'Đại học', N'3 năm', N'Làm việc nhóm, Giải quyết vấn đề', 'CV010.png', 'UV010');

-- Insert data into PHIEUDANGKYUNGTUYEN
INSERT INTO PHIEUDANGKYUNGTUYEN (IDHoSo, IDTTDT, IDCTTTDT, NhanVienDuyet, TinhTrang) VALUES
('HS001', 'TT001', 'CT001', 'NV001', N'Chưa duyệt'),
('HS002', 'TT002', 'CT002', 'NV002', N'Đã duyệt'),
('HS003', 'TT003', 'CT003', 'NV003', N'Chưa duyệt'),
('HS004', 'TT004', 'CT004', 'NV004', N'Đã duyệt'),
('HS005', 'TT005', 'CT005', 'NV005', N'Chưa duyệt'),
('HS006', 'TT006', 'CT006', 'NV006', N'Đã duyệt'),
('HS007', 'TT007', 'CT007', 'NV007', N'Chưa duyệt'),
('HS008', 'TT008', 'CT008', 'NV008', N'Đã duyệt'),
('HS009', 'TT009', 'CT009', 'NV009', N'Chưa duyệt'),
('HS010', 'TT010', 'CT010', 'NV010', N'Đã duyệt');

-- Insert data into BANGCAP
INSERT INTO BANGCAP (ID, Ten, NgayHetHan, NgayNop, IDHoSo) VALUES
('BC001', N'Bằng cử nhân Tiếng Anh', '2024-12-31', '2023-10-01', 'HS001'),
('BC002', N'Chứng chỉ TOEIC', '2024-06-30', '2024-04-01', 'HS001'),

('BC003', N'Chứng chỉ TOEFL', '2024-12-31', '2023-10-01', 'HS002'),
('BC004', N'Bằng cao đẳng Tiếng Nhật', '2024-06-30', '2024-04-01', 'HS002'),

('BC005', N'Bằng chứng chỉ Quản lý dự án', '2023-12-31', '2023-10-01', 'HS003'),
('BC006', N'Chứng chỉ Kế toán trưởng', '2026-06-30', '2024-04-01', 'HS003'),

('BC007', N'Bằng Thạc sĩ Quản trị kinh doanh', '2026-12-31', '2023-10-01', 'HS004'),
('BC008', N'Chứng chỉ Marketing số', '2026-06-30', '2024-04-01', 'HS004'),

('BC009', N'Chứng chỉ An toàn lao động', '2027-12-31', '2023-10-01', 'HS005'),
('BC010', N'Bằng kỹ sư Cơ khí', '2024-06-30', '2024-04-01', 'HS005'),

('BC011', N'Chứng chỉ Hướng dẫn viên du lịch', '2024-12-31', '2023-10-01', 'HS006'),
('BC012', N'Bằng Thạc sĩ Quản lý nhân sự', '2026-06-30', '2024-04-01', 'HS006'),

('BC013', N'Bằng kỹ sư Điện tử viễn thông', '2024-12-31', '2023-10-01', 'HS007'),
('BC014', N'Chứng chỉ Photoshop', '2024-06-30', '2024-04-01', 'HS007'),

('BC015', N'Chứng chỉ Unity Developer', '2026-12-31', '2023-10-01', 'HS008'),
('BC016', N'Bằng Cử nhân Khoa học máy tính', '2026-06-30', '2024-04-01', 'HS008'),

('BC017', N'Bằng Thạc sĩ Quản lý dự án', '2024-12-31', '2023-10-01', 'HS009'),
('BC018', N'Chứng chỉ Digital Marketing', '2024-06-30', '2024-04-01', 'HS009'),

('BC019', N'Chứng chỉ Java Programmer', '2027-12-31', '2023-10-01', 'HS010'),
('BC020', N'Bằng Cử nhân Khoa học dữ liệu', '2024-06-30', '2024-04-01', 'HS010');

UPDATE NHANVIEN
SET ChucDanh = N'Ban lãnh đạo', PhongBan = N'Phòng Pháp lý'
Where IDNV = 'NV010'

INSERT INTO  ACCOUNT VALUES 
('NV001', '4dab19231c64f7180c4f8fb8a24c9d7283c998e0395f8c6834c23c1ed681430a', 'NVDT', 'NV001'),
('NV002', '5cb8fdd01f211cdb84b01d60148a376aeba1112d1293c7dc612963ae71c463d8', 'NVTT', 'NV002'),
('NV003', '25a08623a845e0d1c380aad134c38ea938506eb12a0d4ccf73fcc6d5441a0b4f', 'NVTD', 'NV003'),
('NV004', '63442ac56bfa295e8d6d7206541fead1c30ec2b7375a3b779bf353ac6e913987', 'NVPL', 'NV004'),
('NV005', 'a67e954de3f5a9685853b7bfb63ca1a0e711b368e9a1b53bcac98622a69386dc', 'NVDT', 'NV005'),
('NV006', '652ef3a11639185e5978fe41826c32a5785d8b762c763ac25d3294610d289230', 'NVTT', 'NV006'),
('NV007', 'ec36072bac03affc621b3ca6b2f66209bb18025114402b36f55420718e7daae0', 'NVTD', 'NV007'),
('NV008', '6298ac27f4e351433d6af1a819594de60542f81aa52f44b67978464440fef7cc', 'NVPL', 'NV008'),
('NV009', 'a1cca23e33984d7f316da9b418c70e94c2c2135d0b6623e79c9e984a2dd1128c', 'NVDT', 'NV009'),
('NV010', '4428654896bc9024ac4cc79c1880eed6ca62598f5e65b60a8da8d39dc438bbd8', 'BLD', 'NV010')