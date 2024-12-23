use master;
GO
Create database HeThongBaoCom;
GO
use HeThongBaoCom;
-- Table: ChucVu
CREATE TABLE ChucVu (
    Id int PRIMARY KEY,
    ChucVu nvarchar(20) NOT NULL,
    LaHocVien bit NOT NULL,
    CoQuyenBaoCom bit NOT NULL
);
-- Table: ThongTinNguoiDung
CREATE TABLE ThongTinNguoiDung (
    Id int PRIMARY KEY,
    HoTen nvarchar(255),
	MaNguoiDung nvarchar(255),
	Lop nvarchar(255) ,
    Phong nvarchar(255) ,
	Khoa nvarchar(255) ,
    DonVi nvarchar(255) ,
    ChucVuId int NOT NULL,
    SDT nvarchar(255),
    SoTaiKhoan nvarchar(255) ,
    NganHang nvarchar(255) ,
    Email nvarchar(255) ,
    MatKhau nvarchar(255) NOT NULL,
    TrangThai bit NOT NULL,
    CONSTRAINT ThongTinNguoiDung_VaiTro FOREIGN KEY (ChucVuId) REFERENCES ChucVu (Id)
);


-- Table: LichSuLuuTru
CREATE TABLE LichSuLuuTru (
    Id int PRIMARY KEY,
    NguoiDungId int NOT NULL,
    NgayLuuTru datetime NOT NULL,
	ThoiDiem int NOT NULL,
    SoTienTuongUng decimal(10,2) NOT NULL,
    CONSTRAINT LichSuLuuTru_ThongTinNguoiDung FOREIGN KEY (NguoiDungId) REFERENCES ThongTinNguoiDung (Id)
);

-- Table: YeuCauDangKy
CREATE TABLE YeuCauDangKy (
    Id int NOT NULL PRIMARY KEY,
    NguoiDungId int NOT NULL,
    NgayDangKy datetime NOT NULL,
	ThoiDiem int NOT NULL,
    CONSTRAINT YeuCauDangKy_ThongTinNguoiDung FOREIGN KEY (NguoiDungId) REFERENCES ThongTinNguoiDung (Id)
);
-- Table: ThongTinHeThong
CREATE TABLE ThongTinHeThong (
	Id int NOT NULL PRIMARY KEY,
    HanBaoSang time NOT NULL,
	HanBaoTruaToi time NOT NULL,
    GiaTienHocVienSang decimal(10,2) NOT NULL,
	GiaTienHocVienTrua decimal(10,2) NOT NULL,
	GiaTienHocVienToi decimal(10,2) NOT NULL,
    GiaTienCanBoSang decimal(10,2) NOT NULL,
	GiaTienCanBoTrua decimal(10,2) NOT NULL,
	GiaTienCanBoToi decimal(10,2) NOT NULL
);

CREATE TABLE YKienDongGop (
    Id int PRIMARY KEY,
	NoiDung nvarchar(MAX) NOT NULL,
	NoiDungPhanHoi nvarchar(MAX),
	NguoiGui int NOT NULL,
	NguoiPhanHoi int,
	NgayGui datetime,
	NgayPhanHoi datetime,
	AnhGui VARBINARY(MAX),
	CONSTRAINT ThongTinGui_ThongTinNguoiDung FOREIGN KEY (NguoiGui) REFERENCES ThongTinNguoiDung (Id),
	CONSTRAINT ThongTinNhan_ThongTinNguoiDung FOREIGN KEY (NguoiPhanHoi) REFERENCES ThongTinNguoiDung (Id),
);

INSERT INTO ThongTinHeThong (
   Id, HanBaoSang, HanBaoTruaToi,
    GiaTienHocVienSang, GiaTienHocVienTrua, GiaTienHocVienToi, 
    GiaTienCanBoSang, GiaTienCanBoTrua, GiaTienCanBoToi
)
VALUES
    (1,'10:00:00', '07:00:00', 
     15000, 27500, 27500, 
     15000, 27500, 27500);
	 

INSERT INTO ChucVu (Id, ChucVu, LaHocVien, CoQuyenBaoCom)
VALUES
    (1, N'Quản trị hệ thống', 0, 0),
    (2, N'Cán bộ nhà ăn', 0, 0),
    (3, N'Cán bộ - Giáo viên', 0, 1),
    (4, N'Học viên', 1, 0),
    (5, N'Lớp phó hậu cần', 1, 1);

-- mk: 12345678: mã hóa là "25D55AD283AA400AF464C76D713C07AD"
INSERT INTO ThongTinNguoiDung (
    Id, HoTen, MaNguoiDung, Lop, Phong, Khoa, DonVi, ChucVuId, SDT, SoTaiKhoan, NganHang, Email, MatKhau, TrangThai
)
VALUES
    (1, N'Trần Minh Khoa', '001-B2D11', 'B2D11', '', '', 'T07', 5, 0987654321, 123456789012, 'VCB', 'khoa.tran@example.com', '25D55AD283AA400AF464C76D713C07AD', 1),
    (2, N'Lê Thị Thu', '002-B2D11', 'B2D11', '', '', 'T07', 4, 0978123456, 987654321098, 'BIDV', 'thu.le@example.com', '25D55AD283AA400AF464C76D713C07AD', 1),
    (3, N'Nguyễn Hồng Sơn', '003-B2D11', 'B2D11', '', '', 'T07', 4, 0912345678, 111122223333, 'ACB', 'son.nguyen@example.com', '25D55AD283AA400AF464C76D713C07AD', 1),
    (4, N'Phạm Thị Lan', '004-B2D11', 'B2D11', '', '', 'T07', 4, 0909876543, 444455556666, 'Techcombank', 'lan.pham@example.com', '25D55AD283AA400AF464C76D713C07AD', 1),
    (5, N'Hoàng Minh Đức', '005-B2D11', 'B2D11', '', '', 'T07', 4, 0934567890, 777788889999, 'Agribank', 'duc.hoang@example.com', '25D55AD283AA400AF464C76D713C07AD', 1),
    (6, N'Trần Thị Mai', '006-B2D11', 'B2D11', '', '', 'T07', 4, 0976543210, 222233334444, 'MB Bank', 'mai.tran@example.com', '25D55AD283AA400AF464C76D713C07AD', 1),
    (7, N'Nguyễn Văn Nam', '007-B2D11', 'B2D11', '', '', 'T07', 4, 0961234567, 555566667777, 'Vietinbank', 'nam.nguyen@example.com', '25D55AD283AA400AF464C76D713C07AD', 1),
    (8, N'Phạm Bảo Anh', '008-B2D11', 'B2D11', '', '', 'T07', 4, 0981122334, 888899990000, 'TP Bank', 'anh.pham@example.com', '25D55AD283AA400AF464C76D713C07AD', 1),
    (9, N'Lê Văn Minh', '009-B2D11', 'B2D11', '', '', 'T07', 4, 0923456789, 123443211234, 'Sacombank', 'minh.le@example.com', '25D55AD283AA400AF464C76D713C07AD', 1),
    (10, N'Trần Bảo Lâm', '010-B2D11', 'B2D11', '', '', 'T07', 4, 0956781234, 987676543210, 'Eximbank', 'lam.tran@example.com', '25D55AD283AA400AF464C76D713C07AD', 1),
    (11, N'Nguyễn Hoàng Hải', '011-B2D11', 'B2D11', '', '', 'T07', 4, 0945678901, 111155559999, 'VIB', 'hai.nguyen@example.com', '25D55AD283AA400AF464C76D713C07AD', 1),
    (12, N'Phạm Thị Vân', '012-B2D11', 'B2D11', '', '', 'T07', 4, 0932112233, 666677778888, 'HDBank', 'van.pham@example.com', '25D55AD283AA400AF464C76D713C07AD', 1),
    (13, N'Lê Anh Tuấn', '013-B2D11', 'B2D11', '', '', 'T07', 4, 0933456789, 123123123123, 'MB Bank', 'tuan.le@example.com', '25D55AD283AA400AF464C76D713C07AD', 1),
    (14, N'Trần Thị Hoa', '014-B2D11', 'B2D11', '', '', 'T07', 4, 0924567890, 321321321321, 'Techcombank', 'hoa.tran@example.com', '25D55AD283AA400AF464C76D713C07AD', 1),
    (15, N'Nguyễn Văn Hoàng', '015-B2D11', 'B2D11', '', '', 'T07', 4, 0945671234, 444455551111, 'BIDV', 'hoang.nguyen@example.com', '25D55AD283AA400AF464C76D713C07AD', 1),
    (16, N'Phan Minh Phương', '016-B2D11', 'B2D11', '', '', 'T07', 4, 0912349876, 222299998888, 'Vietinbank', 'phuong.phan@example.com', '25D55AD283AA400AF464C76D713C07AD', 1),
    (17, N'Vũ Thị Hương', '017-B2D11', 'B2D11', '', '', 'T07', 4, 0978456123, 555577778888, 'Sacombank', 'huong.vu@example.com', '25D55AD283AA400AF464C76D713C07AD', 1),
    (18, N'Bùi Quốc Tiến', '018-B2D11', 'B2D11', '', '', 'T07', 4, 0967123456, 888899990000, 'ACB', 'tien.bui@example.com', '25D55AD283AA400AF464C76D713C07AD', 1),
    (19, N'Đỗ Hải Yến', '019-B2D11', 'B2D11', '', '', 'T07', 4, 0901122334, 777788880000, 'Agribank', 'yen.do@example.com', '25D55AD283AA400AF464C76D713C07AD', 1),
    (20, N'Ngô Bảo Châu', '020-B2D11', 'B2D11', '', '', 'T07', 4, 0987654001, 111122227777, 'Eximbank', 'chau.ngo@example.com', '25D55AD283AA400AF464C76D713C07AD', 1),
    
	(21, N'Hoàng Thị Kim', '021-B2D11', '', 'P1', '', 'T07', 3, 0923456781, 999911112222, 'HDBank', 'kim.hoang@example.com', '25D55AD283AA400AF464C76D713C07AD', 1),
    (22, N'Nguyễn Hải Long', '022-B2D11', '', '', 'K1', 'T07', 3, 0911001123, 123456123456, 'MB Bank', 'long.nguyen@example.com', '25D55AD283AA400AF464C76D713C07AD', 1),
    (23, N'Phạm Quỳnh Như', '023-B2D11', '', 'P1', '', 'T07', 3, 0945678902, 987654321321, 'VIB', 'nhu.pham@example.com', '25D55AD283AA400AF464C76D713C07AD', 1),
    (24, N'Trần Hữu Đạt', '024-B2D11', '', 'P1', '', 'T07', 3, 0956789123, 111122223333, 'Vietcombank', 'dat.tran@example.com', '25D55AD283AA400AF464C76D713C07AD', 1),
    
	(25, N'Cán bộ nhà ăn', 'nhaan', '', '', '', 'T07', 2, 0911111111, 555555555555, 'Agribank', 'nhan.bo@example.com', '25D55AD283AA400AF464C76D713C07AD', 1),
    (26, N'Quản trị hệ thống', 'admin', '', '', '', 'T07', 1, 0900000000, 999999999999, 'Vietcombank', 'admin@system.com', '25D55AD283AA400AF464C76D713C07AD', 1);


-- Insert vào bảng LichSuLuuTru
INSERT INTO LichSuLuuTru (Id, NguoiDungId, NgayLuuTru, ThoiDiem, SoTienTuongUng)
VALUES 
    (1, 21, '2024-12-17 10:30:00', 1, 15000),
	(2, 21, '2024-12-17 10:30:00', 2, 27500),
    (3, 2, '2024-12-17 10:30:00', 2, 27500),
	(4, 2, '2024-12-17 10:30:00', 3, 27500),
	(5, 2, '2024-12-16 10:30:00', 1, 15000),
	(6, 2, '2024-12-16 10:30:00', 2, 27500),
	(7, 2, '2024-12-16 10:30:00', 3, 27500);

--SELECT * FROM LichSuLuuTru where NgayLuuTru between '2024-12-17' and '2024-12-18' AND NguoiDungId = 21;
-- Insert vào bảng YeuCauDangKy
INSERT INTO YeuCauDangKy (Id, NguoiDungId, NgayDangKy, ThoiDiem)
VALUES 
    (1, 21, '2024-12-18 10:30:00', 1),
    (2, 21, '2024-12-18 10:30:00', 2),
	(3, 21, '2024-12-18 10:30:00', 3),
	(4, 21, '2024-12-19 23:59:00', 2),
	(5, 21, '2024-12-20 10:30:00', 1),
	(6, 21, '2024-12-20 10:30:00', 3),
	(7, 21, '2024-12-22 10:30:00', 1),
	(8, 21, '2024-12-22 10:30:00', 2),
	(9, 21, '2024-12-22 10:30:00', 3),
	(10, 2, '2024-12-18 10:30:00', 1),
	(12, 2, '2024-12-18 10:30:00', 3),
	(13, 2, '2024-12-19 23:59:00', 2),
	(14, 2, '2024-12-20 10:30:00', 2),
	(15, 2, '2024-12-20 10:30:00', 3),
	(16, 2, '2024-12-22 10:30:00', 1),
	(17, 2, '2024-12-22 10:30:00', 2),
	(18, 2, '2024-12-22 10:30:00', 3);

INSERT INTO YKienDongGop (Id, NoiDung, NoiDungPhanHoi, NguoiGui, NguoiPhanHoi, NgayGui, NgayPhanHoi, AnhGui)
VALUES 
(1, N'Em muốn hỏi là về mã học viên', NULL, 1, NULL, GETDATE(), NULL, NULL);



	