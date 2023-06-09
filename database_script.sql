USE [master]
GO
/****** Object:  Database [DangTinThueTro]    Script Date: 7/8/2022 4:56:14 PM ******/
CREATE DATABASE [DangTinThueTro]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DangTinThueTro', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DangTinThueTro.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DangTinThueTro_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DangTinThueTro_log.ldf' , SIZE = 9216KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DangTinThueTro] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DangTinThueTro].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DangTinThueTro] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DangTinThueTro] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DangTinThueTro] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DangTinThueTro] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DangTinThueTro] SET ARITHABORT OFF 
GO
ALTER DATABASE [DangTinThueTro] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DangTinThueTro] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DangTinThueTro] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DangTinThueTro] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DangTinThueTro] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DangTinThueTro] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DangTinThueTro] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DangTinThueTro] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DangTinThueTro] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DangTinThueTro] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DangTinThueTro] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DangTinThueTro] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DangTinThueTro] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DangTinThueTro] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DangTinThueTro] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DangTinThueTro] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DangTinThueTro] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DangTinThueTro] SET RECOVERY FULL 
GO
ALTER DATABASE [DangTinThueTro] SET  MULTI_USER 
GO
ALTER DATABASE [DangTinThueTro] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DangTinThueTro] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DangTinThueTro] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DangTinThueTro] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DangTinThueTro] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'DangTinThueTro', N'ON'
GO
USE [DangTinThueTro]
GO
/****** Object:  Table [dbo].[DatLichHen]    Script Date: 7/8/2022 4:56:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatLichHen](
	[MaNguoiDung] [int] NOT NULL,
	[MaPhongTro] [nvarchar](128) NOT NULL,
	[NgayHen] [date] NOT NULL,
	[GioHen] [time](7) NOT NULL,
	[GhiChu] [nvarchar](128) NOT NULL,
	[NgayLap] [date] NOT NULL,
	[TrangThai] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_DatLichHen] PRIMARY KEY CLUSTERED 
(
	[MaNguoiDung] ASC,
	[MaPhongTro] ASC,
	[NgayHen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GoiQuangCao]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GoiQuangCao](
	[MaGoiQC] [nvarchar](20) NOT NULL,
	[SoNgay] [int] NOT NULL,
	[Gia] [int] NOT NULL,
 CONSTRAINT [PK__GoiQuang__6EC05E71B998B935] PRIMARY KEY CLUSTERED 
(
	[MaGoiQC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HinhThamKhao]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HinhThamKhao](
	[Hinh] [nvarchar](128) NOT NULL,
	[MaPhongTro] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK__HinhTham__5BCF5E2CE6ED06D3] PRIMARY KEY CLUSTERED 
(
	[Hinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[MaNguoiDung] [int] IDENTITY(1,1) NOT NULL,
	[SDT] [nvarchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[TaiKhoan] [nvarchar](20) NOT NULL,
	[MaQTVDuyet] [int] NULL,
 CONSTRAINT [PK__NguoiDun__C539D7626BC311B2] PRIMARY KEY CLUSTERED 
(
	[MaNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaTro]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaTro](
	[MaNhaTro] [int] IDENTITY(1,1) NOT NULL,
	[GiaDien] [int] NOT NULL,
	[GiaNuoc] [int] NOT NULL,
	[SoNha] [nvarchar](128) NOT NULL,
	[MaX_P_TT] [nvarchar](6) NOT NULL,
	[MaNguoiDung] [int] NOT NULL,
	[DaAn] [bit] NULL CONSTRAINT [DF_NhaTro_DaAn]  DEFAULT ((0)),
 CONSTRAINT [PK_NhaTro] PRIMARY KEY CLUSTERED 
(
	[MaNhaTro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhongTro]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongTro](
	[MaPhongTro] [nvarchar](128) NOT NULL,
	[ChieuDai] [float] NOT NULL,
	[ChieuRong] [float] NOT NULL,
	[SoPhongTrong] [int] NOT NULL,
	[GiaPhong] [int] NOT NULL,
	[HinhDaiDien] [nvarchar](128) NOT NULL,
	[DaAn] [bit] NULL CONSTRAINT [DF_PhongTro_DaXoa]  DEFAULT ((0)),
	[MaNhaTro] [int] NOT NULL,
 CONSTRAINT [PK__PhongTro__CEEDF1E1F9FEF800] PRIMARY KEY CLUSTERED 
(
	[MaPhongTro] DESC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Quan_Huyen_ThiXa]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Quan_Huyen_ThiXa](
	[MaQ_H_TX] [nvarchar](6) NOT NULL,
	[TenQ_H_TX] [nvarchar](30) NOT NULL,
	[MaT_TP] [nvarchar](6) NOT NULL,
 CONSTRAINT [PK__Quan_Huy__3449996FCE735745] PRIMARY KEY CLUSTERED 
(
	[MaQ_H_TX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QuangCao]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuangCao](
	[MaTin] [nvarchar](128) NOT NULL,
	[MaGoiQC] [nvarchar](20) NOT NULL,
	[NgayHieuLuc] [date] NOT NULL,
	[NgayKetThuc] [date] NOT NULL,
 CONSTRAINT [PK__QuangCao__3149033595D5A219] PRIMARY KEY CLUSTERED 
(
	[MaTin] ASC,
	[MaGoiQC] ASC,
	[NgayHieuLuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QuanTriVien]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuanTriVien](
	[MaQTV] [int] NOT NULL,
	[CMND] [nvarchar](13) NOT NULL,
	[SDT] [nvarchar](10) NOT NULL,
	[Ho] [nvarchar](40) NOT NULL,
	[Ten] [nvarchar](10) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[DiaChi] [nvarchar](128) NOT NULL,
	[ConHoatDong] [bit] NULL CONSTRAINT [DF_QuanTriVien_ConHoatDong]  DEFAULT ((1)),
	[TaiKhoan] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK__QuanTriV__396E99967124DF1B] PRIMARY KEY CLUSTERED 
(
	[MaQTV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThongTinDangNhap]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTinDangNhap](
	[TaiKhoan] [nvarchar](20) NOT NULL,
	[MatKhau] [nvarchar](20) NOT NULL,
	[LoaiTaiKhoan] [nvarchar](5) NOT NULL,
 CONSTRAINT [PK_ThongTinDangNhap] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TinDang]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TinDang](
	[MaTinDang] [nvarchar](128) NOT NULL,
	[NgayDang] [date] NOT NULL,
	[TieuDe] [nvarchar](128) NOT NULL,
	[MoTa] [ntext] NOT NULL,
	[MaQTVDuyet] [int] NULL,
	[DaAn] [bit] NULL CONSTRAINT [DF_TinDang_DaXoa]  DEFAULT ((0)),
 CONSTRAINT [PK__TinDang__314903357A0FA9AF] PRIMARY KEY CLUSTERED 
(
	[MaTinDang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tinh_ThanhPho]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tinh_ThanhPho](
	[MaT_TP] [nvarchar](6) NOT NULL,
	[TenT_TP] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK__Tinh_Tha__9AF2F46967AC49F8] PRIMARY KEY CLUSTERED 
(
	[MaT_TP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Xa_Phuong_ThiTran]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Xa_Phuong_ThiTran](
	[MaX_P_TT] [nvarchar](6) NOT NULL,
	[TenX_P_TT] [nvarchar](30) NOT NULL,
	[MaQ_H_TX] [nvarchar](6) NOT NULL,
 CONSTRAINT [PK__Xa_Phuon__B3BAC60155756802] PRIMARY KEY CLUSTERED 
(
	[MaX_P_TT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[YeuThich]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[YeuThich](
	[MaNguoiDung] [int] NOT NULL,
	[MaTinDang] [nvarchar](128) NOT NULL,
	[NgayGioThem] [datetime] NOT NULL,
 CONSTRAINT [PK_YeuThich] PRIMARY KEY CLUSTERED 
(
	[MaNguoiDung] ASC,
	[MaTinDang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[VIEW_THONGTIN_PHONGTRO]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VIEW_THONGTIN_PHONGTRO] AS
	SELECT MaPhongTro, ChieuDai, ChieuRong, SoPhongTrong, GiaPhong, HinhDaiDien, GiaDien, GiaNuoc, SoNha, MaX_P_TT
	FROM PhongTro
	INNER JOIN NhaTro
	ON PhongTro.MaNhaTro = NhaTro.MaNhaTro
	WHERE PhongTro.DaAn = 'FALSE'

GO
INSERT [dbo].[DatLichHen] ([MaNguoiDung], [MaPhongTro], [NgayHen], [GioHen], [GhiChu], [NgayLap], [TrangThai]) VALUES (1, N'6_23042022_233227', CAST(N'2022-05-05' AS Date), CAST(N'05:40:00' AS Time), N'Tôi muốn tham quan phòng trọ của bạn', CAST(N'2022-05-04' AS Date), N'DPH')
INSERT [dbo].[DatLichHen] ([MaNguoiDung], [MaPhongTro], [NgayHen], [GioHen], [GhiChu], [NgayLap], [TrangThai]) VALUES (1, N'6_24042022_105327', CAST(N'2022-05-16' AS Date), CAST(N'07:35:00' AS Time), N'Đặt lịch hẹn', CAST(N'2022-05-15' AS Date), N'DPH')
INSERT [dbo].[DatLichHen] ([MaNguoiDung], [MaPhongTro], [NgayHen], [GioHen], [GhiChu], [NgayLap], [TrangThai]) VALUES (2, N'6_23042022_233227', CAST(N'2022-04-30' AS Date), CAST(N'07:21:00' AS Time), N'', CAST(N'2022-04-29' AS Date), N'H')
INSERT [dbo].[DatLichHen] ([MaNguoiDung], [MaPhongTro], [NgayHen], [GioHen], [GhiChu], [NgayLap], [TrangThai]) VALUES (2, N'7_24042022_093853', CAST(N'2022-04-29' AS Date), CAST(N'05:00:00' AS Time), N'Đặt lịch hẹn', CAST(N'2022-04-29' AS Date), N'H')
INSERT [dbo].[GoiQuangCao] ([MaGoiQC], [SoNgay], [Gia]) VALUES (N'QC15', 15, 150000)
INSERT [dbo].[GoiQuangCao] ([MaGoiQC], [SoNgay], [Gia]) VALUES (N'QC30', 30, 250000)
INSERT [dbo].[GoiQuangCao] ([MaGoiQC], [SoNgay], [Gia]) VALUES (N'QC90', 90, 700000)
INSERT [dbo].[HinhThamKhao] ([Hinh], [MaPhongTro]) VALUES (N'07062022_213527sky-minimalist-03.jpg', N'1010_07062022_213527')
INSERT [dbo].[HinhThamKhao] ([Hinh], [MaPhongTro]) VALUES (N'07062022_214200iridescence-macos-big-sur-macbook-pro-multicolor-dark-1920x1080-4036.jpg', N'1010_07062022_214200')
INSERT [dbo].[HinhThamKhao] ([Hinh], [MaPhongTro]) VALUES (N'11052022_221948pexels-matheus-bertelli-573241.png', N'8_11052022_221948')
INSERT [dbo].[HinhThamKhao] ([Hinh], [MaPhongTro]) VALUES (N'11052022_221948wallpapersden.com_abstract-wave-hd-digital-art-2021_3440x1440.jpg', N'8_11052022_221948')
INSERT [dbo].[HinhThamKhao] ([Hinh], [MaPhongTro]) VALUES (N'23042022_232416braden-jarvis-prSogOoFmkw-unsplash.jpg', N'6_23042022_232416')
INSERT [dbo].[HinhThamKhao] ([Hinh], [MaPhongTro]) VALUES (N'23042022_232955168b5988577975e17b1d74f9a3fa00ee.jpg', N'6_23042022_232955')
INSERT [dbo].[HinhThamKhao] ([Hinh], [MaPhongTro]) VALUES (N'23042022_233227among_trees___small_cliff_by_dadaws_dep4k84.jpg', N'6_23042022_233227')
INSERT [dbo].[HinhThamKhao] ([Hinh], [MaPhongTro]) VALUES (N'24042022_093853among_trees___small_cliff_by_dadaws_dep4k84.jpg', N'7_24042022_093853')
INSERT [dbo].[HinhThamKhao] ([Hinh], [MaPhongTro]) VALUES (N'24042022_105327wallpapersden.com_abstract-wave-hd-digital-art-2021_3440x1440.jpg', N'6_24042022_105327')
INSERT [dbo].[HinhThamKhao] ([Hinh], [MaPhongTro]) VALUES (N'24042022_205207st7se5vl3pm71.png', N'6_24042022_205207')
INSERT [dbo].[HinhThamKhao] ([Hinh], [MaPhongTro]) VALUES (N'24042022_205207sunny.png', N'6_24042022_205207')
SET IDENTITY_INSERT [dbo].[NguoiDung] ON 

INSERT [dbo].[NguoiDung] ([MaNguoiDung], [SDT], [HoTen], [TaiKhoan], [MaQTVDuyet]) VALUES (1, N'0123456789', N'Tân pro max', N'thanhtan3', 1)
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [SDT], [HoTen], [TaiKhoan], [MaQTVDuyet]) VALUES (2, N'999', N'Nguyễn Tân', N'thanhtan', 1)
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [SDT], [HoTen], [TaiKhoan], [MaQTVDuyet]) VALUES (3, N'111', N'Only Tan', N'tan', 1)
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [SDT], [HoTen], [TaiKhoan], [MaQTVDuyet]) VALUES (4, N'123', N'Chủ trọ', N'chutro', 1)
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [SDT], [HoTen], [TaiKhoan], [MaQTVDuyet]) VALUES (1004, N'222', N'timtro', N'timtro', NULL)
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [SDT], [HoTen], [TaiKhoan], [MaQTVDuyet]) VALUES (1005, N'123456', N'abc', N'abc', NULL)
SET IDENTITY_INSERT [dbo].[NguoiDung] OFF
SET IDENTITY_INSERT [dbo].[NhaTro] ON 

INSERT [dbo].[NhaTro] ([MaNhaTro], [GiaDien], [GiaNuoc], [SoNha], [MaX_P_TT], [MaNguoiDung], [DaAn]) VALUES (5, 5000, 20000, N'KTX khu B', N'021816', 2, 0)
INSERT [dbo].[NhaTro] ([MaNhaTro], [GiaDien], [GiaNuoc], [SoNha], [MaX_P_TT], [MaNguoiDung], [DaAn]) VALUES (6, 3000, 15000, N'Man Thiện', N'021827', 2, 0)
INSERT [dbo].[NhaTro] ([MaNhaTro], [GiaDien], [GiaNuoc], [SoNha], [MaX_P_TT], [MaNguoiDung], [DaAn]) VALUES (7, 4000, 20000, N'KTX khu B', N'021816', 2, 0)
INSERT [dbo].[NhaTro] ([MaNhaTro], [GiaDien], [GiaNuoc], [SoNha], [MaX_P_TT], [MaNguoiDung], [DaAn]) VALUES (8, 4000, 20000, N'No name', N'440402', 4, 1)
INSERT [dbo].[NhaTro] ([MaNhaTro], [GiaDien], [GiaNuoc], [SoNha], [MaX_P_TT], [MaNguoiDung], [DaAn]) VALUES (1008, 4500, 20000, N'ABC đường DEF', N'440401', 2, 0)
INSERT [dbo].[NhaTro] ([MaNhaTro], [GiaDien], [GiaNuoc], [SoNha], [MaX_P_TT], [MaNguoiDung], [DaAn]) VALUES (1009, 4500, 15000, N'AAA', N'021816', 2, 0)
INSERT [dbo].[NhaTro] ([MaNhaTro], [GiaDien], [GiaNuoc], [SoNha], [MaX_P_TT], [MaNguoiDung], [DaAn]) VALUES (1010, 6000, 20000, N'123 Man Thiện', N'021816', 2, 0)
SET IDENTITY_INSERT [dbo].[NhaTro] OFF
INSERT [dbo].[PhongTro] ([MaPhongTro], [ChieuDai], [ChieuRong], [SoPhongTrong], [GiaPhong], [HinhDaiDien], [DaAn], [MaNhaTro]) VALUES (N'8_11052022_221948', 10, 20, 1, 5000000, N'11052022_221948pexels-matheus-bertelli-573241.png', 1, 8)
INSERT [dbo].[PhongTro] ([MaPhongTro], [ChieuDai], [ChieuRong], [SoPhongTrong], [GiaPhong], [HinhDaiDien], [DaAn], [MaNhaTro]) VALUES (N'7_24042022_093853', 5, 10, 1, 7700000, N'24042022_093853among_trees___small_cliff_by_dadaws_dep4k84.jpg', 0, 7)
INSERT [dbo].[PhongTro] ([MaPhongTro], [ChieuDai], [ChieuRong], [SoPhongTrong], [GiaPhong], [HinhDaiDien], [DaAn], [MaNhaTro]) VALUES (N'6_24042022_205207', 10, 10, 1, 20000000, N'24042022_205207st7se5vl3pm71.png', 0, 6)
INSERT [dbo].[PhongTro] ([MaPhongTro], [ChieuDai], [ChieuRong], [SoPhongTrong], [GiaPhong], [HinhDaiDien], [DaAn], [MaNhaTro]) VALUES (N'6_24042022_105327', 10, 10, 3, 10000000, N'24042022_105327wallpapersden.com_abstract-wave-hd-digital-art-2021_3440x1440.jpg', 0, 6)
INSERT [dbo].[PhongTro] ([MaPhongTro], [ChieuDai], [ChieuRong], [SoPhongTrong], [GiaPhong], [HinhDaiDien], [DaAn], [MaNhaTro]) VALUES (N'6_23042022_233227', 3, 3, 5, 1000000, N'23042022_233227among_trees___small_cliff_by_dadaws_dep4k84.jpg', 0, 6)
INSERT [dbo].[PhongTro] ([MaPhongTro], [ChieuDai], [ChieuRong], [SoPhongTrong], [GiaPhong], [HinhDaiDien], [DaAn], [MaNhaTro]) VALUES (N'6_23042022_232955', 10, 5, 2, 5000000, N'23042022_232955168b5988577975e17b1d74f9a3fa00ee.jpg', 0, 6)
INSERT [dbo].[PhongTro] ([MaPhongTro], [ChieuDai], [ChieuRong], [SoPhongTrong], [GiaPhong], [HinhDaiDien], [DaAn], [MaNhaTro]) VALUES (N'6_23042022_232416', 5, 5, 1, 10000000, N'23042022_232416braden-jarvis-prSogOoFmkw-unsplash.jpg', 0, 6)
INSERT [dbo].[PhongTro] ([MaPhongTro], [ChieuDai], [ChieuRong], [SoPhongTrong], [GiaPhong], [HinhDaiDien], [DaAn], [MaNhaTro]) VALUES (N'1010_07062022_214200', 10, 15, 0, 10000000, N'07062022_214200iridescence-macos-big-sur-macbook-pro-multicolor-dark-1920x1080-4036.jpg', 0, 1010)
INSERT [dbo].[PhongTro] ([MaPhongTro], [ChieuDai], [ChieuRong], [SoPhongTrong], [GiaPhong], [HinhDaiDien], [DaAn], [MaNhaTro]) VALUES (N'1010_07062022_213527', 10, 10, 0, 6000000, N'07062022_213527sky-minimalist-03.jpg', 0, 1010)
INSERT [dbo].[Quan_Huyen_ThiXa] ([MaQ_H_TX], [TenQ_H_TX], [MaT_TP]) VALUES (N'0218', N'TP Thủ Đức', N'02')
INSERT [dbo].[Quan_Huyen_ThiXa] ([MaQ_H_TX], [TenQ_H_TX], [MaT_TP]) VALUES (N'4404', N'TP Thuận An', N'44')
INSERT [dbo].[QuangCao] ([MaTin], [MaGoiQC], [NgayHieuLuc], [NgayKetThuc]) VALUES (N'6_23042022_232955', N'QC15', CAST(N'2022-05-17' AS Date), CAST(N'2022-06-01' AS Date))
INSERT [dbo].[QuanTriVien] ([MaQTV], [CMND], [SDT], [Ho], [Ten], [NgaySinh], [DiaChi], [ConHoatDong], [TaiKhoan]) VALUES (0, N'000000000', N'0000000000', N' ', N'Chờ duyệt', CAST(N'2001-01-01' AS Date), N'Bình Dương', 0, N'choduyet')
INSERT [dbo].[QuanTriVien] ([MaQTV], [CMND], [SDT], [Ho], [Ten], [NgaySinh], [DiaChi], [ConHoatDong], [TaiKhoan]) VALUES (1, N'123456789', N'0101', N'Nguyễn Thành', N'Tân', CAST(N'2001-01-01' AS Date), N'Bình Dương', 1, N'admin')
INSERT [dbo].[ThongTinDangNhap] ([TaiKhoan], [MatKhau], [LoaiTaiKhoan]) VALUES (N'abc', N'123456', N'user')
INSERT [dbo].[ThongTinDangNhap] ([TaiKhoan], [MatKhau], [LoaiTaiKhoan]) VALUES (N'admin', N'123456', N'admin')
INSERT [dbo].[ThongTinDangNhap] ([TaiKhoan], [MatKhau], [LoaiTaiKhoan]) VALUES (N'choduyet', N'123456', N'admin')
INSERT [dbo].[ThongTinDangNhap] ([TaiKhoan], [MatKhau], [LoaiTaiKhoan]) VALUES (N'chutro', N'123456', N'user')
INSERT [dbo].[ThongTinDangNhap] ([TaiKhoan], [MatKhau], [LoaiTaiKhoan]) VALUES (N'tan', N'123456', N'user')
INSERT [dbo].[ThongTinDangNhap] ([TaiKhoan], [MatKhau], [LoaiTaiKhoan]) VALUES (N'thanhtan', N'123456', N'user')
INSERT [dbo].[ThongTinDangNhap] ([TaiKhoan], [MatKhau], [LoaiTaiKhoan]) VALUES (N'thanhtan3', N'123456', N'user')
INSERT [dbo].[ThongTinDangNhap] ([TaiKhoan], [MatKhau], [LoaiTaiKhoan]) VALUES (N'timtro', N'123456', N'user')
INSERT [dbo].[TinDang] ([MaTinDang], [NgayDang], [TieuDe], [MoTa], [MaQTVDuyet], [DaAn]) VALUES (N'1010_07062022_214200', CAST(N'2022-06-07' AS Date), N'Trọ 10 triệu', N'abc', 1, 0)
INSERT [dbo].[TinDang] ([MaTinDang], [NgayDang], [TieuDe], [MoTa], [MaQTVDuyet], [DaAn]) VALUES (N'6_23042022_232955', CAST(N'2022-04-24' AS Date), N'Trọ cho thuê giá 5tr/tháng', N'- Phòng từ 10m2 - 15m2.
- Có gác để đồ hoặc gác để ở.
- WiFi free
- Phòng sạch sẽ thoáng mát, vị trí đẹp thuận lợi di chuyển qua các quận trung tâm, an ninh đảm bảo.
- Ra vào cửa bằng vân tay, có camera giám sát 24/24.
- Gần nhiều trường đại học, cao đẳng.
- Giờ giấc tự do.', 1, 0)
INSERT [dbo].[TinDang] ([MaTinDang], [NgayDang], [TieuDe], [MoTa], [MaQTVDuyet], [DaAn]) VALUES (N'6_23042022_233227', CAST(N'2022-04-02' AS Date), N'Trọ cho sinh viên chỉ 1tr/tháng', N'Chưa có mô tả', 1, 0)
INSERT [dbo].[TinDang] ([MaTinDang], [NgayDang], [TieuDe], [MoTa], [MaQTVDuyet], [DaAn]) VALUES (N'6_24042022_105327', CAST(N'2022-06-07' AS Date), N'Nhà trọ ABC', N'Homestay Hoang Phuc- KTX Q4 Cao Cấp, Sạch sẽ, Tiện nghi.
🌬️ ☀️ Kytucxa Q4 GIÁ RẺ - THỔI BAY NẮNG NÓNG TRỌN GÓI CHỈ VỚI 800K tháng đầu ( Các tháng sau chỉ từ 1TR ) !!! Cam kết không phát sinh.
🏘️ Về nhà chúng tớ, bạn sẽ có:
✨ Phòng ở mới tinh tươm, decor xinh xinh và luôn được vệ sinh hằng ngày.
🛏️ Bạn chỉ cần dọn tới, mọi thứ khác cứ để tụi tớ lo, từ Phòng khách, phòng đọc sách, nhà bếp , tủ, máy lạnh , máy giặt, máy lọc nước, tắm nóng lạnh 🛁
❄️ Máy lạnh inverter kèm wifi chạy vi vu không lo ngắt quãng.
👨‍🍳Nhà mình có bếp to đùng, tha hồ nấu ăn
🛎️ Với những member ghét giặt tay thì aka “máy giặt” bên mình sẵn sàng hỗ trợ bạn mọi lúc mọi nơi. Thậm chí nước uống 💦 đều Free hết ✌️
🏯Địa chỉ: 84 Nguyễn Tất Thành P12 Q4
📌 CS2: 1134/4 Huỳnh Tấn Phát, Q7
📌 CS3: Hẻm 350 Huỳnh Tấn Phát, Q7
📌 CS4: 34 đường 36 Tân quy q7 ( Ngay 434 Nguyễn thị thập) cách Lotte Mart 400m.
📌 CS5: Hẻm C4 đường Phạm Hùng, Q8', 1, 0)
INSERT [dbo].[TinDang] ([MaTinDang], [NgayDang], [TieuDe], [MoTa], [MaQTVDuyet], [DaAn]) VALUES (N'8_11052022_221948', CAST(N'2022-05-11' AS Date), N'Phòng trọ cho thuê ở Bình Dương', N'- Phòng trọ rộng rãi phù hợp cho 4 người
- Có wifi 100k/tháng
- Có hầm giữ xe
- Ra vào có vân tay
- Tiền cọc 5000000 VNÐ
- Liên hệ: 09xxx hoặc chọn "Đặt lịch hẹn"', 1, 0)
INSERT [dbo].[Tinh_ThanhPho] ([MaT_TP], [TenT_TP]) VALUES (N'02', N'TP Hồ Chí Minh')
INSERT [dbo].[Tinh_ThanhPho] ([MaT_TP], [TenT_TP]) VALUES (N'44', N'Tỉnh Bình Dương')
INSERT [dbo].[Xa_Phuong_ThiTran] ([MaX_P_TT], [TenX_P_TT], [MaQ_H_TX]) VALUES (N'021816', N'Phường Linh Xuân', N'0218')
INSERT [dbo].[Xa_Phuong_ThiTran] ([MaX_P_TT], [TenX_P_TT], [MaQ_H_TX]) VALUES (N'021823', N'Phường Phước Long A', N'0218')
INSERT [dbo].[Xa_Phuong_ThiTran] ([MaX_P_TT], [TenX_P_TT], [MaQ_H_TX]) VALUES (N'021827', N'Phường Tân Nhơn Phú A', N'0218')
INSERT [dbo].[Xa_Phuong_ThiTran] ([MaX_P_TT], [TenX_P_TT], [MaQ_H_TX]) VALUES (N'440401', N'Phường An Phú', N'4404')
INSERT [dbo].[Xa_Phuong_ThiTran] ([MaX_P_TT], [TenX_P_TT], [MaQ_H_TX]) VALUES (N'440402', N'Phường An Thạnh', N'4404')
INSERT [dbo].[YeuThich] ([MaNguoiDung], [MaTinDang], [NgayGioThem]) VALUES (1, N'6_23042022_232955', CAST(N'2022-05-04 17:39:02.280' AS DateTime))
INSERT [dbo].[YeuThich] ([MaNguoiDung], [MaTinDang], [NgayGioThem]) VALUES (1, N'6_23042022_233227', CAST(N'2022-05-04 17:39:03.920' AS DateTime))
INSERT [dbo].[YeuThich] ([MaNguoiDung], [MaTinDang], [NgayGioThem]) VALUES (2, N'1010_07062022_214200', CAST(N'2022-06-07 21:55:14.900' AS DateTime))
INSERT [dbo].[YeuThich] ([MaNguoiDung], [MaTinDang], [NgayGioThem]) VALUES (2, N'6_24042022_105327', CAST(N'2022-06-01 12:24:08.287' AS DateTime))
INSERT [dbo].[YeuThich] ([MaNguoiDung], [MaTinDang], [NgayGioThem]) VALUES (1005, N'6_24042022_105327', CAST(N'2022-06-07 11:32:04.413' AS DateTime))
SET ANSI_PADDING ON

GO
/****** Object:  Index [UK_NguoiDung_SDT]    Script Date: 7/8/2022 4:56:15 PM ******/
ALTER TABLE [dbo].[NguoiDung] ADD  CONSTRAINT [UK_NguoiDung_SDT] UNIQUE NONCLUSTERED 
(
	[SDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UK_NguoiDung_TAIKHOAN]    Script Date: 7/8/2022 4:56:15 PM ******/
ALTER TABLE [dbo].[NguoiDung] ADD  CONSTRAINT [UK_NguoiDung_TAIKHOAN] UNIQUE NONCLUSTERED 
(
	[MaNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UK_PhongTro_MaTinDang]    Script Date: 7/8/2022 4:56:15 PM ******/
ALTER TABLE [dbo].[PhongTro] ADD  CONSTRAINT [UK_PhongTro_MaTinDang] UNIQUE NONCLUSTERED 
(
	[MaPhongTro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UK_QuanTriVien]    Script Date: 7/8/2022 4:56:15 PM ******/
ALTER TABLE [dbo].[QuanTriVien] ADD  CONSTRAINT [UK_QuanTriVien] UNIQUE NONCLUSTERED 
(
	[CMND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_TinDang_NgayDang]    Script Date: 7/8/2022 4:56:15 PM ******/
CREATE NONCLUSTERED INDEX [IX_TinDang_NgayDang] ON [dbo].[TinDang]
(
	[NgayDang] DESC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DatLichHen]  WITH CHECK ADD  CONSTRAINT [FK_DatLichHen_NguoiDung] FOREIGN KEY([MaNguoiDung])
REFERENCES [dbo].[NguoiDung] ([MaNguoiDung])
GO
ALTER TABLE [dbo].[DatLichHen] CHECK CONSTRAINT [FK_DatLichHen_NguoiDung]
GO
ALTER TABLE [dbo].[DatLichHen]  WITH CHECK ADD  CONSTRAINT [FK_DatLichHen_PhongTro] FOREIGN KEY([MaPhongTro])
REFERENCES [dbo].[PhongTro] ([MaPhongTro])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[DatLichHen] CHECK CONSTRAINT [FK_DatLichHen_PhongTro]
GO
ALTER TABLE [dbo].[HinhThamKhao]  WITH CHECK ADD  CONSTRAINT [FK_HinhThamKhao_PhongTro] FOREIGN KEY([MaPhongTro])
REFERENCES [dbo].[PhongTro] ([MaPhongTro])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[HinhThamKhao] CHECK CONSTRAINT [FK_HinhThamKhao_PhongTro]
GO
ALTER TABLE [dbo].[NguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_NguoiDung_QuanTriVien] FOREIGN KEY([MaQTVDuyet])
REFERENCES [dbo].[QuanTriVien] ([MaQTV])
GO
ALTER TABLE [dbo].[NguoiDung] CHECK CONSTRAINT [FK_NguoiDung_QuanTriVien]
GO
ALTER TABLE [dbo].[NguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_NguoiDung_ThongTinDangNhap] FOREIGN KEY([TaiKhoan])
REFERENCES [dbo].[ThongTinDangNhap] ([TaiKhoan])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[NguoiDung] CHECK CONSTRAINT [FK_NguoiDung_ThongTinDangNhap]
GO
ALTER TABLE [dbo].[NhaTro]  WITH CHECK ADD  CONSTRAINT [FK_NhaTro_NguoiDung] FOREIGN KEY([MaNguoiDung])
REFERENCES [dbo].[NguoiDung] ([MaNguoiDung])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[NhaTro] CHECK CONSTRAINT [FK_NhaTro_NguoiDung]
GO
ALTER TABLE [dbo].[NhaTro]  WITH CHECK ADD  CONSTRAINT [FK_NhaTro_Xa_Phuong_ThiTran] FOREIGN KEY([MaX_P_TT])
REFERENCES [dbo].[Xa_Phuong_ThiTran] ([MaX_P_TT])
GO
ALTER TABLE [dbo].[NhaTro] CHECK CONSTRAINT [FK_NhaTro_Xa_Phuong_ThiTran]
GO
ALTER TABLE [dbo].[PhongTro]  WITH CHECK ADD  CONSTRAINT [FK_PhongTro_NhaTro] FOREIGN KEY([MaNhaTro])
REFERENCES [dbo].[NhaTro] ([MaNhaTro])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[PhongTro] CHECK CONSTRAINT [FK_PhongTro_NhaTro]
GO
ALTER TABLE [dbo].[Quan_Huyen_ThiXa]  WITH CHECK ADD  CONSTRAINT [FK_Quan_Huyen_ThiXa_Tinh_ThanhPho] FOREIGN KEY([MaT_TP])
REFERENCES [dbo].[Tinh_ThanhPho] ([MaT_TP])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Quan_Huyen_ThiXa] CHECK CONSTRAINT [FK_Quan_Huyen_ThiXa_Tinh_ThanhPho]
GO
ALTER TABLE [dbo].[QuangCao]  WITH CHECK ADD  CONSTRAINT [FK_QuangCao_GoiQuangCao] FOREIGN KEY([MaGoiQC])
REFERENCES [dbo].[GoiQuangCao] ([MaGoiQC])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[QuangCao] CHECK CONSTRAINT [FK_QuangCao_GoiQuangCao]
GO
ALTER TABLE [dbo].[QuangCao]  WITH CHECK ADD  CONSTRAINT [FK_QuangCao_TinDang] FOREIGN KEY([MaTin])
REFERENCES [dbo].[TinDang] ([MaTinDang])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[QuangCao] CHECK CONSTRAINT [FK_QuangCao_TinDang]
GO
ALTER TABLE [dbo].[QuanTriVien]  WITH CHECK ADD  CONSTRAINT [FK_QuanTriVien_ThongTinDangNhap] FOREIGN KEY([TaiKhoan])
REFERENCES [dbo].[ThongTinDangNhap] ([TaiKhoan])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[QuanTriVien] CHECK CONSTRAINT [FK_QuanTriVien_ThongTinDangNhap]
GO
ALTER TABLE [dbo].[TinDang]  WITH CHECK ADD  CONSTRAINT [FK_TinDang_PhongTro] FOREIGN KEY([MaTinDang])
REFERENCES [dbo].[PhongTro] ([MaPhongTro])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[TinDang] CHECK CONSTRAINT [FK_TinDang_PhongTro]
GO
ALTER TABLE [dbo].[TinDang]  WITH CHECK ADD  CONSTRAINT [FK_TinDang_QuanTriVien] FOREIGN KEY([MaQTVDuyet])
REFERENCES [dbo].[QuanTriVien] ([MaQTV])
GO
ALTER TABLE [dbo].[TinDang] CHECK CONSTRAINT [FK_TinDang_QuanTriVien]
GO
ALTER TABLE [dbo].[Xa_Phuong_ThiTran]  WITH CHECK ADD  CONSTRAINT [FK_Xa_Phuong_ThiTran_Quan_Huyen_ThiXa] FOREIGN KEY([MaQ_H_TX])
REFERENCES [dbo].[Quan_Huyen_ThiXa] ([MaQ_H_TX])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Xa_Phuong_ThiTran] CHECK CONSTRAINT [FK_Xa_Phuong_ThiTran_Quan_Huyen_ThiXa]
GO
ALTER TABLE [dbo].[YeuThich]  WITH CHECK ADD  CONSTRAINT [FK_YeuThich_NguoiDung] FOREIGN KEY([MaNguoiDung])
REFERENCES [dbo].[NguoiDung] ([MaNguoiDung])
GO
ALTER TABLE [dbo].[YeuThich] CHECK CONSTRAINT [FK_YeuThich_NguoiDung]
GO
ALTER TABLE [dbo].[YeuThich]  WITH CHECK ADD  CONSTRAINT [FK_YeuThich_TinDang] FOREIGN KEY([MaTinDang])
REFERENCES [dbo].[TinDang] ([MaTinDang])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[YeuThich] CHECK CONSTRAINT [FK_YeuThich_TinDang]
GO
ALTER TABLE [dbo].[DatLichHen]  WITH CHECK ADD  CONSTRAINT [CK_DatLichHen_TrangThai] CHECK  (([TrangThai]='DPH' OR [TrangThai]='H' OR [TrangThai]='TC' OR [TrangThai]='DY'))
GO
ALTER TABLE [dbo].[DatLichHen] CHECK CONSTRAINT [CK_DatLichHen_TrangThai]
GO
ALTER TABLE [dbo].[ThongTinDangNhap]  WITH CHECK ADD  CONSTRAINT [CK_ThongTinDangNhap] CHECK  (([LoaiTaiKhoan]='admin' OR [LoaiTaiKhoan]='user'))
GO
ALTER TABLE [dbo].[ThongTinDangNhap] CHECK CONSTRAINT [CK_ThongTinDangNhap]
GO
/****** Object:  StoredProcedure [dbo].[SP_CAPNHAT_ANHIEN_TINDANG]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CAPNHAT_ANHIEN_TINDANG] @MATIN NVARCHAR(128), @DAAN BIT AS
BEGIN
	UPDATE TinDang
	SET DaAn = @DAAN
	WHERE MaTinDang = @MATIN
END

GO
/****** Object:  StoredProcedure [dbo].[SP_CAPNHAT_HOTEN]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CAPNHAT_HOTEN] @MANGUOIDUNG int, @TEN NVARCHAR(50)
AS
BEGIN
	UPDATE NguoiDung
	SET HoTen = @TEN
	WHERE MaNguoiDung = @MANGUOIDUNG
END

GO
/****** Object:  StoredProcedure [dbo].[SP_CAPNHAT_MATKHAU]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CAPNHAT_MATKHAU] @TAIKHOAN NVARCHAR(20), @MATKHAUCU NVARCHAR(20), @MATKHAUMOI NVARCHAR(20) AS
BEGIN
	IF EXISTS (SELECT TaiKhoan FROM ThongTinDangNhap WHERE TaiKhoan = @TAIKHOAN AND MatKhau = @MATKHAUCU COLLATE SQL_Latin1_General_CP1_CS_AS)
		UPDATE ThongTinDangNhap
		SET MatKhau = @MATKHAUMOI
		WHERE TaiKhoan = @TAIKHOAN
	ELSE
		RAISERROR('Mật khẩu cũ không chính xác', 16, 1);
END

GO
/****** Object:  StoredProcedure [dbo].[SP_CAPNHAT_NGUOIDUNG_CHAPNHAN]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CAPNHAT_NGUOIDUNG_CHAPNHAN] @MANGUOIDUNG INT, @MAQTV INT AS
BEGIN
	UPDATE NguoiDung
	SET MaQTVDuyet = @MAQTV
	WHERE MaNguoiDung = @MANGUOIDUNG
END

GO
/****** Object:  StoredProcedure [dbo].[SP_CAPNHAT_NGUOIDUNG_TUCHOI]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CAPNHAT_NGUOIDUNG_TUCHOI] @MANGUOIDUNG INT AS
BEGIN
	UPDATE NguoiDung
	SET MaQTVDuyet = NULL
	WHERE MaNguoiDung = @MANGUOIDUNG
END

GO
/****** Object:  StoredProcedure [dbo].[SP_CAPNHAT_PHONGTRO]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CAPNHAT_PHONGTRO] @MAPHONGTRO NVARCHAR(128), @GIAPHONG INT, @SOPHONGTRONG INT AS
BEGIN
	UPDATE PhongTro
	SET GiaPhong = @GIAPHONG, SoPhongTrong = @SOPHONGTRONG
	WHERE MaPhongTro = @MAPHONGTRO
END

GO
/****** Object:  StoredProcedure [dbo].[SP_CAPNHAT_SDT]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CAPNHAT_SDT] @MANGUOIDUNG int, @SDT NVARCHAR(10)
AS
BEGIN
	IF EXISTS (SELECT SDT FROM NguoiDung WHERE SDT = @SDT)
		RAISERROR('Số điện thoại này đã tồn tại', 16, 1);
	ELSE
		UPDATE NguoiDung
		SET SDT = @sdt
		WHERE MaNguoiDung = @MANGUOIDUNG
END

GO
/****** Object:  StoredProcedure [dbo].[SP_CAPNHAT_TINDANG]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CAPNHAT_TINDANG] @MATIN NVARCHAR(128), @TIEUDE NVARCHAR(128), @MOTA NTEXT AS
BEGIN
	UPDATE TinDang
	SET TieuDe = @TIEUDE, MoTa = @MOTA
	WHERE MaTinDang = @MATIN
END

GO
/****** Object:  StoredProcedure [dbo].[SP_CAPNHAT_TINDANG_CHAPNHAN]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CAPNHAT_TINDANG_CHAPNHAN] @MATINDANG NVARCHAR(128), @MAQTV INT AS
BEGIN
	UPDATE TinDang
	SET MaQTVDuyet = @MAQTV
	WHERE MaTinDang = @MATINDANG
END

GO
/****** Object:  StoredProcedure [dbo].[SP_CAPNHAT_TINDANG_TUCHOI]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CAPNHAT_TINDANG_TUCHOI] @MATINDANG NVARCHAR(128) AS
BEGIN
	DELETE YeuThich
	WHERE MaTinDang = @MATINDANG

	DELETE QuangCao
	WHERE MaTin = @MATINDANG

	DELETE TinDang
	WHERE MaTinDang = @MATINDANG
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GET_1_NHATRO]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GET_1_NHATRO] @MANHATRO INT AS
BEGIN
	SELECT GiaDien, GiaNuoc, SoNha, MaX_P_TT
	FROM NhaTro
	WHERE MaNhaTro = @MANHATRO
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GET_1_PHONGTRO]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GET_1_PHONGTRO] @MAPHONGTRO NVARCHAR(128) AS
BEGIN
	SELECT ChieuDai, ChieuRong, SoPhongTrong, GiaPhong, HinhDaiDien, MaNhaTro
	FROM PhongTro
	WHERE MaPhongTro = @MAPHONGTRO
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GET_1_TINDANG]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GET_1_TINDANG] @MATIN NVARCHAR(128) AS
BEGIN
	SELECT TinDang.MaTinDang, TinDang.NgayDang, TinDang.TieuDe, TinDang.MoTa, PhongTro.ChieuDai, PhongTro.ChieuRong, PhongTro.SoPhongTrong, PhongTro.GiaDien, PhongTro.GiaNuoc, PhongTro.GiaPhong,
		PhongTro.HinhDaiDien, PhongTro.SoNha, PhongTro.MaX_P_TT
	FROM TinDang
	INNER JOIN VIEW_THONGTIN_PHONGTRO AS PhongTro
	ON TinDang.MaTinDang = PhongTro.MaPhongTro
	WHERE TinDang.MaTinDang = @MATIN
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GET_ALL_ACCOUNT]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GET_ALL_ACCOUNT] AS
BEGIN
	SELECT * FROM ThongTinDangNhap
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GET_ALL_TINDANG]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GET_ALL_TINDANG] @MANGUOIDUNG INT AS
BEGIN
	-- SELECT các tin đăng theo thứ tự tiên tiên quảng cáo và ngày đăng
	SELECT TEMP.MaTinDang, TEMP.NgayDang, TEMP.TieuDe, TEMP.MoTa, TEMP.DaAn, TEMP.MaQTVDuyet, DoUuTien = IIF(TEMP.MaGoiQC IS NULL, 0, (SELECT Gia FROM GoiQuangCao WHERE GoiQuangCao.MaGoiQC = TEMP.MaGoiQC))
	INTO #TEMP0
	FROM
	(
		SELECT TinDang.*, MaGoiQC = (SELECT MaGoiQC FROM QuangCao WHERE MaTin = MaTinDang AND NgayKetThuc > GETDATE())
		FROM TinDang
	) AS TEMP
	-- SELECT thông tin chi tiết tất cả tin đăng
	SELECT #TEMP0.MaTinDang, #TEMP0.NgayDang, #TEMP0.TieuDe, #TEMP0.MoTa, #TEMP0.DoUuTien, PhongTro.ChieuDai, PhongTro.ChieuRong, PhongTro.SoPhongTrong, PhongTro.GiaDien, PhongTro.GiaNuoc, PhongTro.GiaPhong,
		PhongTro.HinhDaiDien, PhongTro.SoNha, PhongTro.MaX_P_TT
	INTO #TEMP1
	FROM #TEMP0
	INNER JOIN VIEW_THONGTIN_PHONGTRO AS PhongTro
	ON #TEMP0.MaTinDang = PhongTro.MaPhongTro
	WHERE #TEMP0.DaAn = 'FALSE' AND #TEMP0.MaQTVDuyet IS NOT NULL
	-- SELECT Mã những tin đăng người dùng yêu thích
	SELECT MaTinDang
	INTO #TEMP2
	FROM YeuThich
	WHERE MaNguoiDung = @MANGUOIDUNG
	-- Trả về tất cả tin đăng kết thêm field đã thích
	SELECT #TEMP1.*, DATHICH = IIF(#TEMP1.MaTinDang IN (SELECT MaTinDang FROM #TEMP2), 'TRUE', 'FALSE')
	FROM #TEMP1
	ORDER BY #TEMP1.DoUuTien DESC, #TEMP1.NgayDang DESC
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GET_GOIQUANGCAO]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GET_GOIQUANGCAO] AS
BEGIN
	SELECT * FROM GoiQuangCao
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GET_HINHTHAMKHAO]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GET_HINHTHAMKHAO] @MAPHONGTRO NVARCHAR(128) AS
BEGIN
	SELECT Hinh
	FROM HinhThamKhao
	WHERE MaPhongTro = @MAPHONGTRO
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GET_ID_CHUPHONGTRO]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GET_ID_CHUPHONGTRO] @MAPHONGTRO NVARCHAR(128) AS
BEGIN
	SELECT NguoiDung.MaNguoiDung
	FROM NguoiDung
	INNER JOIN 
	(
		SELECT NhaTro.MaNhaTro, MaNguoiDung
		FROM PhongTro
		INNER JOIN NhaTro
		ON PhongTro.MaNhaTro = NhaTro.MaNhaTro
		WHERE MaPhongTro = @MAPHONGTRO
	) AS TEMP
	ON NguoiDung.MaNguoiDung = TEMP.MaNguoiDung
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GET_INFO]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GET_INFO]
	@mauser int
AS
BEGIN
SELECT ThongTinDangNhap.TaiKhoan, MatKhau, LoaiTaiKhoan, HoTen, SDT
	FROM ThongTinDangNhap JOIN NguoiDung ON ThongTinDangNhap.TaiKhoan = NguoiDung.TaiKhoan
	WHERE MaNguoiDung = @mauser
END
-- Đổi mật khẩu


GO
/****** Object:  StoredProcedure [dbo].[SP_GET_LICHHEN_DADAT]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GET_LICHHEN_DADAT] @MANGUOIDUNG INT AS
BEGIN
	SELECT MaPhongTro, NgayHen, GioHen, GhiChu, NgayLap, TrangThai
	FROM DatLichHen
	WHERE MaNguoiDung = @MANGUOIDUNG
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GET_LICHHEN_DANHAN]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GET_LICHHEN_DANHAN] @MANGUOIDUNG INT AS
BEGIN
	SELECT PhongTro.MaPhongTro
	INTO #TEMP
	FROM PhongTro,
	(
		SELECT MaNhaTro
		FROM NhaTro
		WHERE MaNguoiDung = @MANGUOIDUNG
	) AS TEMP
	WHERE PhongTro.MaNhaTro = TEMP.MaNhaTro

	SELECT MaNguoiDung, DatLichHen.MaPhongTro, NgayHen, GioHen, GhiChu, NgayLap, TrangThai
	INTO #TEMP2
	FROM DatLichHen, #TEMP
	WHERE DatLichHen.MaPhongTro = #TEMP.MaPhongTro
	ORDER BY NgayLap

	SELECT HoTen, #TEMP2.*
	FROM #TEMP2
	INNER JOIN NguoiDung
	ON #TEMP2.MaNguoiDung = NguoiDung.MaNguoiDung
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GET_NGUOIDUNG_DUYET]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GET_NGUOIDUNG_DUYET] AS
BEGIN
	SELECT MaNguoiDung, HoTen, SDT
	FROM NguoiDung
	WHERE MaQTVDuyet = 0
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GET_NHATRO]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GET_NHATRO] @MANGUOIDUNG INT AS
BEGIN
	SELECT MaNhaTro, GiaDien, GiaNuoc, SoNha, MaX_P_TT
	FROM NhaTro
	WHERE MaNguoiDung = @MANGUOIDUNG AND DaAn = 0
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GET_PHONGTRO]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GET_PHONGTRO] @MANHATRO INT AS
BEGIN
	SELECT 
		PhongTro.MaPhongTro, PhongTro.ChieuDai, PhongTro.ChieuRong, PhongTro.SoPhongTrong, PhongTro.GiaPhong, PhongTro.HinhDaiDien,
		TrangThai = IIF(
			MaPhongTro IN (SELECT MaTinDang FROM TinDang), 
			IIF(MaPhongTro IN (SELECT MaTinDang FROM TinDang WHERE MaQTVDuyet IS NOT NULL), 'dadangtin', 'dangchoduyet'), 
			'chuadangtin'
		)
	--INTO #TEMP_PHONGTRO
	FROM PhongTro
	LEFT JOIN TinDang
	ON PhongTro.MaPhongTro = TinDang.MaTinDang
	WHERE PhongTro.MaNhaTro = @MANHATRO AND PhongTro.DaAn = 'FALSE'
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GET_QUAN_HUYEN_THIXA]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GET_QUAN_HUYEN_THIXA] AS
BEGIN
	SELECT * FROM Quan_Huyen_ThiXa
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GET_QUANGCAO]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GET_QUANGCAO] @MATIN NVARCHAR(128) AS
BEGIN
	SELECT * 
	INTO #TEMP
	FROM QuangCao
	WHERE MaTin = @MATIN AND NgayKetThuc > GETDATE()

	IF (SELECT COUNT(*) FROM #TEMP) > 0
		SELECT * FROM #TEMP
	ELSE
		RAISERROR(N'Tin này không có quảng cáo hiệu lực', 16, 1);
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GET_SERVICE]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GET_SERVICE] @Icon NVARCHAR(50) AS
BEGIN
	SELECT * FROM DichVu WHERE Icon = @Icon
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GET_TIN_YEUTHICH]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GET_TIN_YEUTHICH] @MANGUOIDUNG INT AS
BEGIN
	SELECT * 
	INTO #TEMP
	FROM YeuThich
	WHERE MaNguoiDung = @MANGUOIDUNG

	SELECT TinDang.MaTinDang, TinDang.NgayDang, TinDang.TieuDe, TinDang.MoTa, TinDang.DaAn
	INTO #TEMP2
	FROM #TEMP
	INNER JOIN TinDang
	ON #TEMP.MaTinDang = TinDang.MaTinDang
	ORDER BY #TEMP.NgayGioThem

	SELECT #TEMP2.MaTinDang, #TEMP2.NgayDang, #TEMP2.TieuDe, #TEMP2.MoTa, PhongTro.ChieuDai, PhongTro.ChieuRong, PhongTro.SoPhongTrong, PhongTro.GiaDien, PhongTro.GiaNuoc, PhongTro.GiaPhong,
		PhongTro.HinhDaiDien, PhongTro.SoNha, PhongTro.MaX_P_TT, DATHICH = 'TRUE'
	FROM #TEMP2
	INNER JOIN VIEW_THONGTIN_PHONGTRO AS PhongTro
	ON #TEMP2.MaTinDang = PhongTro.MaPhongTro
	WHERE #TEMP2.MaTinDang IN (SELECT MaTinDang FROM #TEMP) AND #TEMP2.DaAn = 'FALSE'
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GET_TINDANG]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GET_TINDANG] @MANGUOIDUNG INT AS
BEGIN
	SELECT MaPhongTro
	INTO #TEMP
	FROM NhaTro
	JOIN PhongTro
	ON NhaTro.MaNhaTro = PhongTro.MaNhaTro
	WHERE MaNguoiDung = @MANGUOIDUNG AND NhaTro.DaAn = 'FALSE'

	SELECT *
	FROM TinDang
	WHERE MaTinDang IN (SELECT MaPhongTro FROM #TEMP)
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GET_TINDANG_DUYET]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GET_TINDANG_DUYET] AS
BEGIN
	SELECT MaTinDang, TieuDe, MoTa, MaNhaTro
	INTO #TEMP
	FROM TinDang
	INNER JOIN PhongTro
	ON MaTinDang = MaPhongTro
	WHERE MaQTVDuyet IS NULL

	SELECT MaTinDang, TieuDe, MoTa, MaNguoiDung
	INTO #TEMP2
	FROM #TEMP
	INNER JOIN NhaTro
	ON #TEMP.MaNhaTro = NhaTro.MaNhaTro

	SELECT MaTinDang, HoTen, TieuDe, MoTa
	FROM #TEMP2
	INNER JOIN NguoiDung
	ON #TEMP2.MaNguoiDung = NguoiDung.MaNguoiDung
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GET_TINH_THANHPHO]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GET_TINH_THANHPHO] AS
BEGIN
	SELECT * FROM Tinh_ThanhPho
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GET_USER_ID]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GET_USER_ID] @TAIKHOAN NVARCHAR(20) AS
BEGIN
	SELECT MaNguoiDung
	FROM NguoiDung
	WHERE TaiKhoan = @TAIKHOAN
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GET_XA_PHUONG_TRITRAN]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GET_XA_PHUONG_TRITRAN] AS
BEGIN
	SELECT * FROM Xa_Phuong_ThiTran
END

GO
/****** Object:  StoredProcedure [dbo].[SP_HUY_LICHHEN]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_HUY_LICHHEN] @MANGUOIDUNG INT, @MAPHONGTRO NVARCHAR(128), @NGAYHEN NVARCHAR(10), @TRANGTHAI NVARCHAR(10) AS
BEGIN
	UPDATE DatLichHen
	SET TrangThai = @TRANGTHAI
	WHERE NgayHen = CONVERT(DATE, @NGAYHEN) AND MaPhongTro = @MAPHONGTRO AND MaNguoiDung = @MANGUOIDUNG
END

GO
/****** Object:  StoredProcedure [dbo].[SP_LOGIN]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_LOGIN] @USERNAME NVARCHAR(20), @PASSWORD NVARCHAR(20) AS
BEGIN
	DECLARE @LOAITAIKHOAN NVARCHAR(10)
	SET @LOAITAIKHOAN = (SELECT LoaiTaiKhoan FROM ThongTinDangNhap WHERE  TaiKhoan = @USERNAME COLLATE SQL_Latin1_General_CP1_CS_AS AND MatKhau = @PASSWORD COLLATE SQL_Latin1_General_CP1_CS_AS)
	
	IF @LOAITAIKHOAN = 'user'
		SELECT MaNguoiDung AS MaNguoiDung, SDT, HoTen, IIF(MaQTVDuyet IS NULL, 'chuaduyet', IIF(MaQTVDuyet = 0, 'choduyet', 'daduyet')) AS TrangThai, @LOAITAIKHOAN AS LoaiTK
		FROM NguoiDung
		WHERE TaiKhoan = @USERNAME
	ELSE IF @LOAITAIKHOAN = 'admin'
		IF EXISTS (SELECT MaQTV FROM QuanTriVien WHERE TaiKhoan = @USERNAME AND ConHoatDong = 'true')
			SELECT MaQTV AS MaNguoiDung, SDT, HoTen = Ho + ' ' + Ten, NgaySinh, DiaChi, @LOAITAIKHOAN AS LoaiTK
			FROM QuanTriVien
			WHERE TaiKhoan = @USERNAME
		ELSE
			RAISERROR(N'Tài khoản này đã bị vô hiệu', 16, 1);
	ELSE
		RAISERROR(N'Thông tin đăng nhập không chính xác', 16, 1);
END

GO
/****** Object:  StoredProcedure [dbo].[SP_SIGNUP]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_SIGNUP] @USERNAME NVARCHAR(20), @PASSWORD NVARCHAR(20), @SDT NVARCHAR(10) AS
BEGIN
	IF EXISTS (SELECT TaiKhoan FROM ThongTinDangNhap WHERE TaiKhoan = @USERNAME) 
		RAISERROR(N'Tài khoản đã tồn tại', 16, 1);
	ELSE
		IF EXISTS (SELECT SDT FROM NguoiDung WHERE SDT = @SDT) 
			RAISERROR(N'Số điện thoại đã tồn tại', 16, 1);
		ELSE
			BEGIN
				INSERT INTO ThongTinDangNhap 
				VALUES(@USERNAME, @PASSWORD, 'user');

				INSERT INTO NguoiDung(SDT, HoTen, TaiKhoan)
				VALUES(@SDT, @USERNAME, @USERNAME)
			END
END

GO
/****** Object:  StoredProcedure [dbo].[SP_SUA_NHATRO]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_SUA_NHATRO] @MANHATRO INT, @GIADIEN INT, @GIANUOC INT AS
BEGIN
	UPDATE NhaTro
	SET GiaDien = @GIADIEN, GiaNuoc = @GiaNuoc
	WHERE MaNhaTro = @MANHATRO
END

GO
/****** Object:  StoredProcedure [dbo].[SP_THEM_DATLICHHEN]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_THEM_DATLICHHEN] @MANGUOIDUNG INT, @MAPHONGTRO NVARCHAR(128), @NGAYHEN DATE, @GIOHEN TIME, @GHICHU NVARCHAR(128) AS
BEGIN
	IF (SELECT COUNT(MaNguoiDung) FROM DatLichHen WHERE NgayLap = CONVERT(DATE, GETDATE())) >= 5
		RAISERROR(N'Bạn chỉ được phép lập lịch hẹn tối đa 5 lần/ngày', 16, 1);
	ELSE IF EXISTS (SELECT MaNguoiDung FROM DatLichHen WHERE NgayHen = @NGAYHEN AND MaPhongTro = @MAPHONGTRO AND MaNguoiDung = @MANGUOIDUNG)
		RAISERROR(N'Bạn không thể đặt nhiều lịch hẹn cùng một ngày ở cùng một phòng trọ', 16, 1);
	ELSE
		INSERT INTO DatLichHen(MaNguoiDung, MaPhongTro, NgayHen, GioHen, GHICHU, NgayLap, TrangThai)
		VALUES(@MANGUOIDUNG, @MAPHONGTRO, @NGAYHEN, @GIOHEN, @GHICHU, CONVERT(DATE, GETDATE()), 'DPH')
END

GO
/****** Object:  StoredProcedure [dbo].[SP_THEM_HINHTHAMKHAO]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_THEM_HINHTHAMKHAO] @HINH NVARCHAR(128), @MAPHONGTRO NVARCHAR(128) AS
BEGIN
	INSERT INTO HinhThamKhao
	VALUES(@HINH, @MAPHONGTRO)
END

GO
/****** Object:  StoredProcedure [dbo].[SP_THEM_NHATRO]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_THEM_NHATRO] @GIADIEN INT, @GIANUOC INT, @SONHA NVARCHAR(128), @MAX_P_TT NVARCHAR(6), @MANGUOIDUNG INT AS
BEGIN
	INSERT INTO NhaTro(GiaDien, GiaNuoc, SoNha, MaX_P_TT, MaNguoiDung)
	VALUES(@GIADIEN, @GIANUOC, @SONHA, @MAX_P_TT, @MANGUOIDUNG)
END

GO
/****** Object:  StoredProcedure [dbo].[SP_THEM_PHONGTRO]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_THEM_PHONGTRO] @MAPHONGTRO NVARCHAR(128), @CHIEUDAI FLOAT, @CHIEURONG FLOAT, @SOPHONGTRONG INT, @GIAPHONG INT, @HINH NVARCHAR(128), @MANHATRO INT AS
BEGIN
	INSERT INTO PhongTro(MaPhongTro, ChieuDai, ChieuRong, SoPhongTrong, GiaPhong, HinhDaiDien, MaNhaTro)
	VALUES(@MAPHONGTRO, @CHIEUDAI, @CHIEURONG, @SOPHONGTRONG, @GIAPHONG, @HINH, @MANHATRO)
END

GO
/****** Object:  StoredProcedure [dbo].[SP_THEM_QUANGCAO]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_THEM_QUANGCAO] @MATIN NVARCHAR(128), @MAGOIQC NVARCHAR(20), @SONGAY INT AS
BEGIN
	DECLARE @NOW DATE
	SET @NOW = GETDATE()
	IF EXISTS (SELECT * FROM QuangCao WHERE MaTin = @MATIN AND NgayKetThuc > @NOW)
		RAISERROR(N'Tin này đang được quảng cáo, không thể đăng ký thêm', 16, 1);
	ELSE
		INSERT INTO QuangCao
		VALUES(@MATIN, @MAGOIQC, @NOW, dateadd(day, @SONGAY, @NOW))
END

GO
/****** Object:  StoredProcedure [dbo].[SP_THEM_TINDANG]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_THEM_TINDANG] @MATINDANG NVARCHAR(128), @NGAYDANG DATE, @TIEUDE NVARCHAR(50), @MOTA NTEXT AS
BEGIN
	INSERT INTO TinDang(MaTinDang, NgayDang, TieuDe, MoTa)
	VALUES(@MATINDANG, @NGAYDANG, @TIEUDE, @MOTA)
END

GO
/****** Object:  StoredProcedure [dbo].[SP_THEM_YEUTHICH]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_THEM_YEUTHICH] @MANGUOIDUNG INT, @MATIN NVARCHAR(128) AS
BEGIN
	INSERT INTO YeuThich
	VALUES(@MANGUOIDUNG, @MATIN, GETDATE())
END

GO
/****** Object:  StoredProcedure [dbo].[SP_XOA_NHATRO]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_XOA_NHATRO] @MANHATRO INT AS
BEGIN
	UPDATE NhaTro
	SET DaAn = 1
	WHERE MaNhaTro = @MANHATRO
END

GO
/****** Object:  StoredProcedure [dbo].[SP_XOA_PHONGTRO]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_XOA_PHONGTRO] @MAPHONGTRO NVARCHAR(128) AS
BEGIN
	UPDATE PhongTro
	SET DaAn = 'TRUE'
	WHERE MaPhongTro = @MAPHONGTRO
END

GO
/****** Object:  StoredProcedure [dbo].[SP_XOA_YEUTHICH]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_XOA_YEUTHICH] @MANGUOIDUNG INT, @MATIN NVARCHAR(128) AS
BEGIN
	DELETE YeuThich
	WHERE MaNguoiDung = @MANGUOIDUNG AND MaTinDang = @MATIN
END

GO
/****** Object:  StoredProcedure [dbo].[SP_YEUCAU_DUYET_TAIKHOAN]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_YEUCAU_DUYET_TAIKHOAN] @MANGUOIDUNG INT AS
BEGIN
	UPDATE NguoiDung
	SET MaQTVDuyet = 0
	WHERE MaNguoiDung = @MANGUOIDUNG
END

GO
/****** Object:  Trigger [dbo].[TR_AN_NHATRO]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TR_AN_NHATRO] ON [dbo].[NhaTro]
FOR UPDATE AS
BEGIN
	IF(UPDATE(DaAn))
		UPDATE PhongTro
		SET DaAn = 'TRUE'
		WHERE MaNhaTro = (SELECT MaNhaTro FROM deleted)
END
GO
/****** Object:  Trigger [dbo].[TR_CAPNHAT_TINDANG]    Script Date: 7/8/2022 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TR_CAPNHAT_TINDANG] ON [dbo].[TinDang] 
FOR UPDATE AS
BEGIN
	IF(UPDATE(TieuDe) OR UPDATE(MoTa))
		UPDATE TinDang
		SET MaQTVDuyet = NULL
		WHERE MaTinDang = (SELECT MaTinDang FROM inserted)
END
GO
USE [master]
GO
ALTER DATABASE [DangTinThueTro] SET  READ_WRITE 
GO
