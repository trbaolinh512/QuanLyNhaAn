USE [master]
GO
DROP DATABASE [HeThongBaoCom]
GO
/****** Object:  Database [HeThongBaoCom]    Script Date: 1/2/2025 2:54:37 PM ******/
CREATE DATABASE [HeThongBaoCom]
GO
ALTER DATABASE [HeThongBaoCom] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HeThongBaoCom] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HeThongBaoCom] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HeThongBaoCom] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HeThongBaoCom] SET ARITHABORT OFF 
GO
ALTER DATABASE [HeThongBaoCom] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HeThongBaoCom] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HeThongBaoCom] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HeThongBaoCom] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HeThongBaoCom] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HeThongBaoCom] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HeThongBaoCom] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HeThongBaoCom] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HeThongBaoCom] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HeThongBaoCom] SET  ENABLE_BROKER 
GO
ALTER DATABASE [HeThongBaoCom] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HeThongBaoCom] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HeThongBaoCom] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HeThongBaoCom] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HeThongBaoCom] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HeThongBaoCom] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HeThongBaoCom] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HeThongBaoCom] SET RECOVERY FULL 
GO
ALTER DATABASE [HeThongBaoCom] SET  MULTI_USER 
GO
ALTER DATABASE [HeThongBaoCom] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HeThongBaoCom] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HeThongBaoCom] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HeThongBaoCom] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HeThongBaoCom] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HeThongBaoCom] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'HeThongBaoCom', N'ON'
GO
ALTER DATABASE [HeThongBaoCom] SET QUERY_STORE = ON
GO
ALTER DATABASE [HeThongBaoCom] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [HeThongBaoCom]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 1/2/2025 2:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[Id] [int] NOT NULL,
	[ChucVu] [nvarchar](20) NOT NULL,
	[LaHocVien] [bit] NOT NULL,
	[CoQuyenBaoCom] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichSuLuuTru]    Script Date: 1/2/2025 2:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichSuLuuTru](
	[Id] [int] NOT NULL,
	[NguoiDungId] [int] NOT NULL,
	[NgayLuuTru] [datetime] NOT NULL,
	[ThoiDiem] [int] NOT NULL,
	[SoTienTuongUng] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThongTinHeThong]    Script Date: 1/2/2025 2:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTinHeThong](
	[Id] [int] NOT NULL,
	[HanBaoSang] [time](7) NOT NULL,
	[HanBaoTruaToi] [time](7) NOT NULL,
	[GiaTienHocVienSang] [decimal](10, 2) NOT NULL,
	[GiaTienHocVienTrua] [decimal](10, 2) NOT NULL,
	[GiaTienHocVienToi] [decimal](10, 2) NOT NULL,
	[GiaTienCanBoSang] [decimal](10, 2) NOT NULL,
	[GiaTienCanBoTrua] [decimal](10, 2) NOT NULL,
	[GiaTienCanBoToi] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThongTinNguoiDung]    Script Date: 1/2/2025 2:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTinNguoiDung](
	[Id] [int] NOT NULL,
	[HoTen] [nvarchar](255) NULL,
	[MaNguoiDung] [nvarchar](255) NULL,
	[Lop] [nvarchar](255) NULL,
	[Phong] [nvarchar](255) NULL,
	[Khoa] [nvarchar](255) NULL,
	[DonVi] [nvarchar](255) NULL,
	[ChucVuId] [int] NOT NULL,
	[SDT] [nvarchar](255) NULL,
	[SoTaiKhoan] [nvarchar](255) NULL,
	[NganHang] [nvarchar](255) NULL,
	[Email] [nvarchar](255) NULL,
	[MatKhau] [nvarchar](255) NOT NULL,
	[TrangThai] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[YeuCauDangKy]    Script Date: 1/2/2025 2:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[YeuCauDangKy](
	[Id] [int] NOT NULL,
	[NguoiDungId] [int] NOT NULL,
	[NgayDangKy] [datetime] NOT NULL,
	[ThoiDiem] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[YKienDongGop]    Script Date: 1/2/2025 2:54:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[YKienDongGop](
	[Id] [int] NOT NULL,
	[NoiDung] [nvarchar](max) NOT NULL,
	[NoiDungPhanHoi] [nvarchar](max) NULL,
	[NguoiGui] [int] NOT NULL,
	[NguoiPhanHoi] [int] NULL,
	[NgayGui] [datetime] NULL,
	[NgayPhanHoi] [datetime] NULL,
	[AnhGui] [varbinary](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[ChucVu] ([Id], [ChucVu], [LaHocVien], [CoQuyenBaoCom]) VALUES (1, N'Quản trị hệ thống', 0, 0)
INSERT [dbo].[ChucVu] ([Id], [ChucVu], [LaHocVien], [CoQuyenBaoCom]) VALUES (2, N'Cán bộ nhà ăn', 0, 0)
INSERT [dbo].[ChucVu] ([Id], [ChucVu], [LaHocVien], [CoQuyenBaoCom]) VALUES (3, N'Cán bộ - Giáo viên', 0, 1)
INSERT [dbo].[ChucVu] ([Id], [ChucVu], [LaHocVien], [CoQuyenBaoCom]) VALUES (4, N'Học viên', 1, 0)
INSERT [dbo].[ChucVu] ([Id], [ChucVu], [LaHocVien], [CoQuyenBaoCom]) VALUES (5, N'Lớp phó hậu cần', 1, 1)
GO
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (1, 21, CAST(N'2024-12-17T10:30:00.000' AS DateTime), 1, CAST(15000.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (2, 21, CAST(N'2024-12-17T10:30:00.000' AS DateTime), 2, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (3, 2, CAST(N'2024-12-17T10:30:00.000' AS DateTime), 2, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (4, 2, CAST(N'2024-12-17T10:30:00.000' AS DateTime), 3, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (5, 2, CAST(N'2024-12-16T10:30:00.000' AS DateTime), 1, CAST(15000.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (6, 2, CAST(N'2024-12-16T10:30:00.000' AS DateTime), 2, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (7, 2, CAST(N'2024-12-16T10:30:00.000' AS DateTime), 3, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (8, 21, CAST(N'2024-12-18T10:30:00.000' AS DateTime), 1, CAST(15000.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (9, 21, CAST(N'2024-12-18T10:30:00.000' AS DateTime), 2, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (10, 21, CAST(N'2024-12-18T10:30:00.000' AS DateTime), 3, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (11, 21, CAST(N'2024-12-19T23:59:00.000' AS DateTime), 2, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (12, 21, CAST(N'2024-12-20T10:30:00.000' AS DateTime), 1, CAST(15000.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (13, 21, CAST(N'2024-12-20T10:30:00.000' AS DateTime), 3, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (14, 21, CAST(N'2024-12-22T10:30:00.000' AS DateTime), 1, CAST(15000.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (15, 21, CAST(N'2024-12-22T10:30:00.000' AS DateTime), 2, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (16, 21, CAST(N'2024-12-22T10:30:00.000' AS DateTime), 3, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (17, 2, CAST(N'2024-12-18T10:30:00.000' AS DateTime), 1, CAST(15000.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (18, 2, CAST(N'2024-12-18T10:30:00.000' AS DateTime), 3, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (19, 2, CAST(N'2024-12-19T23:59:00.000' AS DateTime), 2, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (20, 2, CAST(N'2024-12-20T10:30:00.000' AS DateTime), 2, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (21, 2, CAST(N'2024-12-20T10:30:00.000' AS DateTime), 3, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (22, 2, CAST(N'2024-12-22T10:30:00.000' AS DateTime), 1, CAST(15000.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (23, 2, CAST(N'2024-12-22T10:30:00.000' AS DateTime), 2, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (24, 2, CAST(N'2024-12-22T10:30:00.000' AS DateTime), 3, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (25, 2, CAST(N'2024-12-23T00:00:00.000' AS DateTime), 1, CAST(15000.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (26, 3, CAST(N'2024-12-23T00:00:00.000' AS DateTime), 1, CAST(15000.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (27, 6, CAST(N'2024-12-23T00:00:00.000' AS DateTime), 1, CAST(15000.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (28, 9, CAST(N'2024-12-23T00:00:00.000' AS DateTime), 1, CAST(15000.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (29, 4, CAST(N'2024-12-23T00:00:00.000' AS DateTime), 1, CAST(15000.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (30, 5, CAST(N'2024-12-23T00:00:00.000' AS DateTime), 1, CAST(15000.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (31, 21, CAST(N'2024-12-23T07:00:00.000' AS DateTime), 2, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (32, 21, CAST(N'2024-12-23T07:00:00.000' AS DateTime), 3, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (33, 4, CAST(N'2024-12-23T07:00:00.000' AS DateTime), 2, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (34, 4, CAST(N'2024-12-23T07:00:00.000' AS DateTime), 3, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (35, 5, CAST(N'2024-12-23T07:00:00.000' AS DateTime), 2, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (36, 5, CAST(N'2024-12-23T07:00:00.000' AS DateTime), 3, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (37, 21, CAST(N'2024-12-24T00:00:00.000' AS DateTime), 1, CAST(15000.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (38, 21, CAST(N'2024-12-24T07:00:00.000' AS DateTime), 2, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (39, 21, CAST(N'2024-12-24T07:00:00.000' AS DateTime), 3, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (40, 21, CAST(N'2024-12-25T00:00:00.000' AS DateTime), 1, CAST(15000.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (41, 9, CAST(N'2024-12-24T00:00:00.000' AS DateTime), 1, CAST(15000.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (42, 9, CAST(N'2024-12-24T07:00:00.000' AS DateTime), 2, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (43, 9, CAST(N'2024-12-24T07:00:00.000' AS DateTime), 3, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (44, 9, CAST(N'2024-12-25T00:00:00.000' AS DateTime), 1, CAST(15000.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (45, 12, CAST(N'2024-12-25T00:00:00.000' AS DateTime), 1, CAST(15000.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (46, 13, CAST(N'2024-12-24T00:00:00.000' AS DateTime), 1, CAST(15000.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (47, 13, CAST(N'2024-12-24T07:00:00.000' AS DateTime), 2, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (48, 13, CAST(N'2024-12-24T07:00:00.000' AS DateTime), 3, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (49, 14, CAST(N'2024-12-25T00:00:00.000' AS DateTime), 1, CAST(15000.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (50, 16, CAST(N'2024-12-24T00:00:00.000' AS DateTime), 1, CAST(15000.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (51, 16, CAST(N'2024-12-24T07:00:00.000' AS DateTime), 2, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (52, 16, CAST(N'2024-12-24T07:00:00.000' AS DateTime), 3, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (53, 17, CAST(N'2024-12-24T00:00:00.000' AS DateTime), 1, CAST(15000.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (54, 17, CAST(N'2024-12-24T07:00:00.000' AS DateTime), 2, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (55, 17, CAST(N'2024-12-24T07:00:00.000' AS DateTime), 3, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (56, 19, CAST(N'2024-12-25T00:00:00.000' AS DateTime), 1, CAST(15000.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (57, 21, CAST(N'2024-12-25T07:00:00.000' AS DateTime), 3, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (58, 21, CAST(N'2024-12-26T07:00:00.000' AS DateTime), 2, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (59, 21, CAST(N'2024-12-27T00:00:00.000' AS DateTime), 1, CAST(15000.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (60, 21, CAST(N'2024-12-25T07:00:00.000' AS DateTime), 2, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (61, 21, CAST(N'2024-12-26T00:00:00.000' AS DateTime), 1, CAST(15000.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (62, 21, CAST(N'2024-12-26T07:00:00.000' AS DateTime), 3, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (63, 21, CAST(N'2024-12-27T07:00:00.000' AS DateTime), 2, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (64, 21, CAST(N'2024-12-27T07:00:00.000' AS DateTime), 3, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (65, 6, CAST(N'2024-12-26T00:00:00.000' AS DateTime), 1, CAST(15000.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (66, 6, CAST(N'2024-12-26T07:00:00.000' AS DateTime), 2, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (67, 6, CAST(N'2024-12-26T07:00:00.000' AS DateTime), 3, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (68, 8, CAST(N'2024-12-27T00:00:00.000' AS DateTime), 1, CAST(15000.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (69, 8, CAST(N'2024-12-27T07:00:00.000' AS DateTime), 2, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (70, 8, CAST(N'2024-12-27T07:00:00.000' AS DateTime), 3, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (71, 9, CAST(N'2024-12-25T07:00:00.000' AS DateTime), 2, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (72, 9, CAST(N'2024-12-25T07:00:00.000' AS DateTime), 3, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (73, 12, CAST(N'2024-12-25T07:00:00.000' AS DateTime), 2, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (74, 12, CAST(N'2024-12-25T07:00:00.000' AS DateTime), 3, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (75, 12, CAST(N'2024-12-26T00:00:00.000' AS DateTime), 1, CAST(15000.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (76, 12, CAST(N'2024-12-26T07:00:00.000' AS DateTime), 2, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (77, 12, CAST(N'2024-12-26T07:00:00.000' AS DateTime), 3, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (78, 14, CAST(N'2024-12-25T07:00:00.000' AS DateTime), 2, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (79, 14, CAST(N'2024-12-25T07:00:00.000' AS DateTime), 3, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (80, 14, CAST(N'2024-12-26T00:00:00.000' AS DateTime), 1, CAST(15000.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (81, 14, CAST(N'2024-12-26T07:00:00.000' AS DateTime), 2, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (82, 14, CAST(N'2024-12-26T07:00:00.000' AS DateTime), 3, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (83, 17, CAST(N'2024-12-27T00:00:00.000' AS DateTime), 1, CAST(15000.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (84, 17, CAST(N'2024-12-27T07:00:00.000' AS DateTime), 2, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (85, 17, CAST(N'2024-12-27T07:00:00.000' AS DateTime), 3, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (86, 19, CAST(N'2024-12-25T07:00:00.000' AS DateTime), 2, CAST(27500.00 AS Decimal(10, 2)))
INSERT [dbo].[LichSuLuuTru] ([Id], [NguoiDungId], [NgayLuuTru], [ThoiDiem], [SoTienTuongUng]) VALUES (87, 19, CAST(N'2024-12-25T07:00:00.000' AS DateTime), 3, CAST(27500.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[ThongTinHeThong] ([Id], [HanBaoSang], [HanBaoTruaToi], [GiaTienHocVienSang], [GiaTienHocVienTrua], [GiaTienHocVienToi], [GiaTienCanBoSang], [GiaTienCanBoTrua], [GiaTienCanBoToi]) VALUES (1, CAST(N'10:00:00' AS Time), CAST(N'07:00:00' AS Time), CAST(15000.00 AS Decimal(10, 2)), CAST(27500.00 AS Decimal(10, 2)), CAST(27500.00 AS Decimal(10, 2)), CAST(15000.00 AS Decimal(10, 2)), CAST(27500.00 AS Decimal(10, 2)), CAST(27500.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[ThongTinNguoiDung] ([Id], [HoTen], [MaNguoiDung], [Lop], [Phong], [Khoa], [DonVi], [ChucVuId], [SDT], [SoTaiKhoan], [NganHang], [Email], [MatKhau], [TrangThai]) VALUES (1, N'Trần Minh Khoa', N'001-B2D11', N'B2D11', N'', N'', N'T07', 5, N'987654321', N'123456789012', N'VCB', N'khoa.tran@example.com', N'25D55AD283AA400AF464C76D713C07AD', 1)
INSERT [dbo].[ThongTinNguoiDung] ([Id], [HoTen], [MaNguoiDung], [Lop], [Phong], [Khoa], [DonVi], [ChucVuId], [SDT], [SoTaiKhoan], [NganHang], [Email], [MatKhau], [TrangThai]) VALUES (2, N'Lê Thị Thu', N'002-B2D11', N'B2D11', N'', N'', N'T07', 4, N'978123456', N'987654321098', N'BIDV', N'thu.le@example.com', N'25D55AD283AA400AF464C76D713C07AD', 1)
INSERT [dbo].[ThongTinNguoiDung] ([Id], [HoTen], [MaNguoiDung], [Lop], [Phong], [Khoa], [DonVi], [ChucVuId], [SDT], [SoTaiKhoan], [NganHang], [Email], [MatKhau], [TrangThai]) VALUES (3, N'Nguyễn Hồng Sơn', N'003-B2D11', N'B2D11', N'', N'', N'T07', 4, N'912345678', N'111122223333', N'ACB', N'son.nguyen@example.com', N'25D55AD283AA400AF464C76D713C07AD', 1)
INSERT [dbo].[ThongTinNguoiDung] ([Id], [HoTen], [MaNguoiDung], [Lop], [Phong], [Khoa], [DonVi], [ChucVuId], [SDT], [SoTaiKhoan], [NganHang], [Email], [MatKhau], [TrangThai]) VALUES (4, N'Phạm Thị Lan', N'004-B2D11', N'B2D11', N'', N'', N'T07', 4, N'909876543', N'444455556666', N'Techcombank', N'lan.pham@example.com', N'25D55AD283AA400AF464C76D713C07AD', 1)
INSERT [dbo].[ThongTinNguoiDung] ([Id], [HoTen], [MaNguoiDung], [Lop], [Phong], [Khoa], [DonVi], [ChucVuId], [SDT], [SoTaiKhoan], [NganHang], [Email], [MatKhau], [TrangThai]) VALUES (5, N'Hoàng Minh Đức', N'005-B2D11', N'B2D11', N'', N'', N'T07', 4, N'934567890', N'777788889999', N'Agribank', N'duc.hoang@example.com', N'25D55AD283AA400AF464C76D713C07AD', 1)
INSERT [dbo].[ThongTinNguoiDung] ([Id], [HoTen], [MaNguoiDung], [Lop], [Phong], [Khoa], [DonVi], [ChucVuId], [SDT], [SoTaiKhoan], [NganHang], [Email], [MatKhau], [TrangThai]) VALUES (6, N'Trần Thị Mai', N'006-B2D11', N'B2D11', N'', N'', N'T07', 4, N'976543210', N'222233334444', N'MB Bank', N'mai.tran@example.com', N'25D55AD283AA400AF464C76D713C07AD', 1)
INSERT [dbo].[ThongTinNguoiDung] ([Id], [HoTen], [MaNguoiDung], [Lop], [Phong], [Khoa], [DonVi], [ChucVuId], [SDT], [SoTaiKhoan], [NganHang], [Email], [MatKhau], [TrangThai]) VALUES (7, N'Nguyễn Văn Nam', N'007-B2D11', N'B2D11', N'', N'', N'T07', 4, N'961234567', N'555566667777', N'Vietinbank', N'nam.nguyen@example.com', N'25D55AD283AA400AF464C76D713C07AD', 1)
INSERT [dbo].[ThongTinNguoiDung] ([Id], [HoTen], [MaNguoiDung], [Lop], [Phong], [Khoa], [DonVi], [ChucVuId], [SDT], [SoTaiKhoan], [NganHang], [Email], [MatKhau], [TrangThai]) VALUES (8, N'Phạm Bảo Anh', N'008-B2D11', N'B2D11', N'', N'', N'T07', 4, N'981122334', N'888899990000', N'TP Bank', N'anh.pham@example.com', N'25D55AD283AA400AF464C76D713C07AD', 1)
INSERT [dbo].[ThongTinNguoiDung] ([Id], [HoTen], [MaNguoiDung], [Lop], [Phong], [Khoa], [DonVi], [ChucVuId], [SDT], [SoTaiKhoan], [NganHang], [Email], [MatKhau], [TrangThai]) VALUES (9, N'Lê Văn Minh', N'009-B2D11', N'B2D11', N'', N'', N'T07', 4, N'923456789', N'123443211234', N'Sacombank', N'minh.le@example.com', N'25D55AD283AA400AF464C76D713C07AD', 1)
INSERT [dbo].[ThongTinNguoiDung] ([Id], [HoTen], [MaNguoiDung], [Lop], [Phong], [Khoa], [DonVi], [ChucVuId], [SDT], [SoTaiKhoan], [NganHang], [Email], [MatKhau], [TrangThai]) VALUES (10, N'Trần Bảo Lâm', N'010-B2D11', N'B2D11', N'', N'', N'T07', 4, N'956781234', N'987676543210', N'Eximbank', N'lam.tran@example.com', N'25D55AD283AA400AF464C76D713C07AD', 1)
INSERT [dbo].[ThongTinNguoiDung] ([Id], [HoTen], [MaNguoiDung], [Lop], [Phong], [Khoa], [DonVi], [ChucVuId], [SDT], [SoTaiKhoan], [NganHang], [Email], [MatKhau], [TrangThai]) VALUES (11, N'Nguyễn Hoàng Hải', N'011-B2D11', N'B2D11', N'', N'', N'T07', 4, N'945678901', N'111155559999', N'VIB', N'hai.nguyen@example.com', N'25D55AD283AA400AF464C76D713C07AD', 1)
INSERT [dbo].[ThongTinNguoiDung] ([Id], [HoTen], [MaNguoiDung], [Lop], [Phong], [Khoa], [DonVi], [ChucVuId], [SDT], [SoTaiKhoan], [NganHang], [Email], [MatKhau], [TrangThai]) VALUES (12, N'Phạm Thị Vân', N'012-B2D11', N'B2D11', N'', N'', N'T07', 4, N'932112233', N'666677778888', N'HDBank', N'van.pham@example.com', N'25D55AD283AA400AF464C76D713C07AD', 1)
INSERT [dbo].[ThongTinNguoiDung] ([Id], [HoTen], [MaNguoiDung], [Lop], [Phong], [Khoa], [DonVi], [ChucVuId], [SDT], [SoTaiKhoan], [NganHang], [Email], [MatKhau], [TrangThai]) VALUES (13, N'Lê Anh Tuấn', N'013-B2D11', N'B2D11', N'', N'', N'T07', 4, N'933456789', N'123123123123', N'MB Bank', N'tuan.le@example.com', N'25D55AD283AA400AF464C76D713C07AD', 1)
INSERT [dbo].[ThongTinNguoiDung] ([Id], [HoTen], [MaNguoiDung], [Lop], [Phong], [Khoa], [DonVi], [ChucVuId], [SDT], [SoTaiKhoan], [NganHang], [Email], [MatKhau], [TrangThai]) VALUES (14, N'Trần Thị Hoa', N'014-B2D11', N'B2D11', N'', N'', N'T07', 4, N'924567890', N'321321321321', N'Techcombank', N'hoa.tran@example.com', N'25D55AD283AA400AF464C76D713C07AD', 1)
INSERT [dbo].[ThongTinNguoiDung] ([Id], [HoTen], [MaNguoiDung], [Lop], [Phong], [Khoa], [DonVi], [ChucVuId], [SDT], [SoTaiKhoan], [NganHang], [Email], [MatKhau], [TrangThai]) VALUES (15, N'Nguyễn Văn Hoàng', N'015-B2D11', N'B2D11', N'', N'', N'T07', 4, N'945671234', N'444455551111', N'BIDV', N'hoang.nguyen@example.com', N'25D55AD283AA400AF464C76D713C07AD', 1)
INSERT [dbo].[ThongTinNguoiDung] ([Id], [HoTen], [MaNguoiDung], [Lop], [Phong], [Khoa], [DonVi], [ChucVuId], [SDT], [SoTaiKhoan], [NganHang], [Email], [MatKhau], [TrangThai]) VALUES (16, N'Phan Minh Phương', N'016-B2D11', N'B2D11', N'', N'', N'T07', 4, N'912349876', N'222299998888', N'Vietinbank', N'phuong.phan@example.com', N'25D55AD283AA400AF464C76D713C07AD', 1)
INSERT [dbo].[ThongTinNguoiDung] ([Id], [HoTen], [MaNguoiDung], [Lop], [Phong], [Khoa], [DonVi], [ChucVuId], [SDT], [SoTaiKhoan], [NganHang], [Email], [MatKhau], [TrangThai]) VALUES (17, N'Vũ Thị Hương', N'017-B2D11', N'B2D11', N'', N'', N'T07', 4, N'978456123', N'555577778888', N'Sacombank', N'huong.vu@example.com', N'25D55AD283AA400AF464C76D713C07AD', 1)
INSERT [dbo].[ThongTinNguoiDung] ([Id], [HoTen], [MaNguoiDung], [Lop], [Phong], [Khoa], [DonVi], [ChucVuId], [SDT], [SoTaiKhoan], [NganHang], [Email], [MatKhau], [TrangThai]) VALUES (18, N'Bùi Quốc Tiến', N'018-B2D11', N'B2D11', N'', N'', N'T07', 4, N'967123456', N'888899990000', N'ACB', N'tien.bui@example.com', N'25D55AD283AA400AF464C76D713C07AD', 1)
INSERT [dbo].[ThongTinNguoiDung] ([Id], [HoTen], [MaNguoiDung], [Lop], [Phong], [Khoa], [DonVi], [ChucVuId], [SDT], [SoTaiKhoan], [NganHang], [Email], [MatKhau], [TrangThai]) VALUES (19, N'Đỗ Hải Yến', N'019-B2D11', N'B2D11', N'', N'', N'T07', 4, N'901122334', N'777788880000', N'Agribank', N'yen.do@example.com', N'25D55AD283AA400AF464C76D713C07AD', 1)
INSERT [dbo].[ThongTinNguoiDung] ([Id], [HoTen], [MaNguoiDung], [Lop], [Phong], [Khoa], [DonVi], [ChucVuId], [SDT], [SoTaiKhoan], [NganHang], [Email], [MatKhau], [TrangThai]) VALUES (20, N'Ngô Bảo Châu', N'020-B2D11', N'B2D11', N'', N'', N'T07', 4, N'987654001', N'111122227777', N'Eximbank', N'chau.ngo@example.com', N'25D55AD283AA400AF464C76D713C07AD', 1)
INSERT [dbo].[ThongTinNguoiDung] ([Id], [HoTen], [MaNguoiDung], [Lop], [Phong], [Khoa], [DonVi], [ChucVuId], [SDT], [SoTaiKhoan], [NganHang], [Email], [MatKhau], [TrangThai]) VALUES (21, N'Hoàng Thị Kim', N'021-B2D11', N'', N'P1', N'', N'T07', 3, N'923456781', N'999911112222', N'HDBank', N'kim.hoang@example.com', N'25D55AD283AA400AF464C76D713C07AD', 1)
INSERT [dbo].[ThongTinNguoiDung] ([Id], [HoTen], [MaNguoiDung], [Lop], [Phong], [Khoa], [DonVi], [ChucVuId], [SDT], [SoTaiKhoan], [NganHang], [Email], [MatKhau], [TrangThai]) VALUES (22, N'Nguyễn Hải Long', N'022-B2D11', N'', N'', N'K1', N'T07', 3, N'911001123', N'123456123456', N'MB Bank', N'long.nguyen@example.com', N'25D55AD283AA400AF464C76D713C07AD', 1)
INSERT [dbo].[ThongTinNguoiDung] ([Id], [HoTen], [MaNguoiDung], [Lop], [Phong], [Khoa], [DonVi], [ChucVuId], [SDT], [SoTaiKhoan], [NganHang], [Email], [MatKhau], [TrangThai]) VALUES (23, N'Phạm Quỳnh Như', N'023-B2D11', N'', N'P1', N'', N'T07', 3, N'945678902', N'987654321321', N'VIB', N'nhu.pham@example.com', N'25D55AD283AA400AF464C76D713C07AD', 1)
INSERT [dbo].[ThongTinNguoiDung] ([Id], [HoTen], [MaNguoiDung], [Lop], [Phong], [Khoa], [DonVi], [ChucVuId], [SDT], [SoTaiKhoan], [NganHang], [Email], [MatKhau], [TrangThai]) VALUES (24, N'Trần Hữu Đạt', N'024-B2D11', N'', N'P1', N'', N'T07', 3, N'956789123', N'111122223333', N'Vietcombank', N'dat.tran@example.com', N'25D55AD283AA400AF464C76D713C07AD', 1)
INSERT [dbo].[ThongTinNguoiDung] ([Id], [HoTen], [MaNguoiDung], [Lop], [Phong], [Khoa], [DonVi], [ChucVuId], [SDT], [SoTaiKhoan], [NganHang], [Email], [MatKhau], [TrangThai]) VALUES (25, N'Cán bộ nhà ăn', N'nhaan', N'', N'', N'', N'T07', 2, N'911111111', N'555555555555', N'Agribank', N'nhan.bo@example.com', N'25D55AD283AA400AF464C76D713C07AD', 1)
INSERT [dbo].[ThongTinNguoiDung] ([Id], [HoTen], [MaNguoiDung], [Lop], [Phong], [Khoa], [DonVi], [ChucVuId], [SDT], [SoTaiKhoan], [NganHang], [Email], [MatKhau], [TrangThai]) VALUES (26, N'Quản trị hệ thống', N'admin', N'', N'', N'', N'T07', 1, N'900000000', N'999999999999', N'Vietcombank', N'admin@system.com', N'25D55AD283AA400AF464C76D713C07AD', 1)
GO
INSERT [dbo].[YeuCauDangKy] ([Id], [NguoiDungId], [NgayDangKy], [ThoiDiem]) VALUES (1, 1, CAST(N'2025-01-09T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[YeuCauDangKy] ([Id], [NguoiDungId], [NgayDangKy], [ThoiDiem]) VALUES (2, 1, CAST(N'2025-01-09T07:00:00.000' AS DateTime), 2)
INSERT [dbo].[YeuCauDangKy] ([Id], [NguoiDungId], [NgayDangKy], [ThoiDiem]) VALUES (3, 1, CAST(N'2025-01-09T07:00:00.000' AS DateTime), 3)
INSERT [dbo].[YeuCauDangKy] ([Id], [NguoiDungId], [NgayDangKy], [ThoiDiem]) VALUES (4, 1, CAST(N'2025-01-10T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[YeuCauDangKy] ([Id], [NguoiDungId], [NgayDangKy], [ThoiDiem]) VALUES (5, 1, CAST(N'2025-01-10T07:00:00.000' AS DateTime), 2)
INSERT [dbo].[YeuCauDangKy] ([Id], [NguoiDungId], [NgayDangKy], [ThoiDiem]) VALUES (6, 1, CAST(N'2025-01-10T07:00:00.000' AS DateTime), 3)
GO
INSERT [dbo].[YKienDongGop] ([Id], [NoiDung], [NoiDungPhanHoi], [NguoiGui], [NguoiPhanHoi], [NgayGui], [NgayPhanHoi], [AnhGui]) VALUES (1, N'Em muốn hỏi là về mã học viên', N'chào b', 1, 26, CAST(N'2024-12-23T01:20:37.803' AS DateTime), CAST(N'2024-12-23T04:48:43.307' AS DateTime), 0x)
INSERT [dbo].[YKienDongGop] ([Id], [NoiDung], [NoiDungPhanHoi], [NguoiGui], [NguoiPhanHoi], [NgayGui], [NgayPhanHoi], [AnhGui]) VALUES (2, N'a', NULL, 2, NULL, CAST(N'2024-12-23T03:48:17.330' AS DateTime), NULL, 0xFFD8FFE000104A46494600010101004800480000FFED00B650686F746F73686F7020332E30003842494D04040000000000271C015A00031B25471C0200000200021C023C00063136343633361C023700083230323230393137003842494D0425000000000010057F9FD3EAFBE66A6D38C03D3AF351273842494D040400000000002E1C015A00031B25471C0200000200021C023C000B3136343633362D303530301C0237000A323032322D30392D31373842494D04250000000000100CFDE9F9F341B9C11B27521DEF223D77FFDB00430006040506050406060506070706080A100A0A09090A140E0F0C1017141818171416161A1D251F1A1B231C1616202C20232627292A29191F2D302D283025282928FFDB0043010707070A080A130A0A13281A161A2828282828282828282828282828282828282828282828282828282828282828282828282828282828282828282828282828FFC200110800CD00D103012200021101031101FFC4001A000100030101010000000000000000000000010205040306FFC4001501010100000000000000000000000000000001FFDA000C03010002100310000001FB0B160000000000000000000000000000000000000000000000000000000000000000000003DBB7BCCCB68A5C8E5FA1F2B309EDE200000000000000EBE4D93A44A001E387F458B67380000000000001BF81F42489400197A99A99E28000000000001BB85A26889400193A9829514000000000000B546EFAE0EA47505299C384B000000000000003D7DCE3778E3B750E18EF1C0EEF2399300000000000E829A7D16805000000A67E98F9D6B64D800000005F738BBA2CA96502CA8B2A2CA8B2A266A2D9DDF0602F4B0000017366F598944165459516409545959255164419FC5A59B400003D3CEE6CA11281281281281281281281281CD9BA39D4001FFFC400251000020005050002030100000000000000010200030420401112143032212210133170FFDA000801010001050250147F962CB66814E638D0D218411A6349936BA06131361C3A74DCD74D4DEB874E34977CF1A4CC25F37D57AC21FCBEAFFB8528EA97D49FBE152B5E4E818EAD84A76996E1D6DA899AE2A31429395BF2CC1626CED7203111FB1F19519A053B4718C718C718C718C718C718C71CC192E208D3BD10B9492ABD6CA1A2648D3B654BDE400076CE95BBAD177328DA3BEA53AA997E300FC871B5BA1068B83523ED7A7AC2A9F37CBF78551E2F4F78551E2CFFC40014110100000000000000000000000000000070FFDA0008010301013F0136FFC4001511010100000000000000000000000000006001FFDA0008010201013F0115567FFFC400251000010303030305000000000000000000010021401130320210122031514161707181FFDA0008010100063F02034B01F16B04E56499D3C6AEAE978B53E92C5830C5812F4C312F8F5D5130EA157AB888B50BC1DDCAA6990C5646330DB2592C964B2592EFB3DF65E4DB70ABA6EFB2A0BD51DEDD15040E42D72844590210360431634FDC3FDB0247FFC400271000010205040104030000000000000000010011213031406141517191201081A1B170C1F0FFDA0008010100013F21094006007E2DDBCDCAD1211FE02D1884260636C000473B78B183DD1DB34D0DA6D2798051AE88C0D9F2A8C8E5D1B31606240C5C59D091F62CDCF890F376167049723CC472A04731AD9943502000F7F278EC35B649593C9EA09C4133A237B8AB0112550493536B541115202C0E96074B03A581D2C0E960748E98AD31F84426069EDC086EA304724B00CF23EA46C8C2B30D8F54DA184E00D1FBA218B1ACA20810C3A161FB694D1954C2C40101A158524E08164D6E048071E6CC236647C259D390F9B67439F1FFDA000C030100020003000000100820820820820820820810820820820820820820810820820820820820820810820820810B50820820810820824000004420820810820824400004C20820810820821400001C208208108208208700A88208208108208218EF4E38A082081082093000000002B820810823CCF0C30C32C78A0810822C73CF0CF2CF1C2081086FF7FF00FF00FF00FF00FF00EA081FFFC4001A110003010101010000000000000000000000011130205021FFDA0008010301013F10F3E1099AE1E4B8792E1E69EB087D21319AAF1E1FFFC4001B11010003010101010000000000000000000100113020102150FFDA0008010201013F10FCF5972F37836193C19A7959DCB2592C978AF5706FA703E6E6C7BFFFC4002810000300010205040203010000000000000001112131412030405161107181A191B170C1F0D1FFDA0008010100013F104F12228925B7F16E621EC10D2C87854C18B7FEF710371764F23FB28D9F4BAE05A54CA7D10924A251703124DEDB91A966CF717489722E6F77C6E3AC556F223627AAC7468726737214825160E8D2A3645C89F70CBF1D1BD62ECB90F87B2FE9D1A775797227AE9F774756D95C663150DB35126BD1B268CA301CECECF85E827305792DDF4AB8D9DD6CD0A12576B04269AAB4F4800F9791ECB68BDCFA8FAF66248C2F71ED737E7A5CB3CBBEC7FDAB16E27E5C42108424964FC414D53F90C8C32D9F3FDF48DA212A80DF4122C72A7C2791036C32DF511B3491AD53E65C3AB5029A48E73CAA1F80E722261A7CA40F96F3E10BEA24FC94A52FA5294A5294A528991CED5FBE5254361EC5294A5294A5294A5294A282A869FB0F63BBEB9095710849D8294A5294A5294A5294A52935DE4FE39164D1AAFB2E0ACA5294A5294A5294A529453DC28FAE47FB1DCA5294A5294A5294A5294A51FF0013F4F90F1FE3FB2FA5F4BC34A5E1BE8F83C7FBE1FFD9)
GO
ALTER TABLE [dbo].[LichSuLuuTru]  WITH CHECK ADD  CONSTRAINT [LichSuLuuTru_ThongTinNguoiDung] FOREIGN KEY([NguoiDungId])
REFERENCES [dbo].[ThongTinNguoiDung] ([Id])
GO
ALTER TABLE [dbo].[LichSuLuuTru] CHECK CONSTRAINT [LichSuLuuTru_ThongTinNguoiDung]
GO
ALTER TABLE [dbo].[ThongTinNguoiDung]  WITH CHECK ADD  CONSTRAINT [ThongTinNguoiDung_VaiTro] FOREIGN KEY([ChucVuId])
REFERENCES [dbo].[ChucVu] ([Id])
GO
ALTER TABLE [dbo].[ThongTinNguoiDung] CHECK CONSTRAINT [ThongTinNguoiDung_VaiTro]
GO
ALTER TABLE [dbo].[YeuCauDangKy]  WITH CHECK ADD  CONSTRAINT [YeuCauDangKy_ThongTinNguoiDung] FOREIGN KEY([NguoiDungId])
REFERENCES [dbo].[ThongTinNguoiDung] ([Id])
GO
ALTER TABLE [dbo].[YeuCauDangKy] CHECK CONSTRAINT [YeuCauDangKy_ThongTinNguoiDung]
GO
ALTER TABLE [dbo].[YKienDongGop]  WITH CHECK ADD  CONSTRAINT [ThongTinGui_ThongTinNguoiDung] FOREIGN KEY([NguoiGui])
REFERENCES [dbo].[ThongTinNguoiDung] ([Id])
GO
ALTER TABLE [dbo].[YKienDongGop] CHECK CONSTRAINT [ThongTinGui_ThongTinNguoiDung]
GO
ALTER TABLE [dbo].[YKienDongGop]  WITH CHECK ADD  CONSTRAINT [ThongTinNhan_ThongTinNguoiDung] FOREIGN KEY([NguoiPhanHoi])
REFERENCES [dbo].[ThongTinNguoiDung] ([Id])
GO
ALTER TABLE [dbo].[YKienDongGop] CHECK CONSTRAINT [ThongTinNhan_ThongTinNguoiDung]
GO
USE [master]
GO
ALTER DATABASE [HeThongBaoCom] SET  READ_WRITE 
GO
