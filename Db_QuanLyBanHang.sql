USE [master]
GO
/****** Object:  Database [QuanLyBanHang]    Script Date: 5/25/2022 10:32:30 PM ******/
CREATE DATABASE [QuanLyBanHang]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyBanHang', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\QuanLyBanHang.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyBanHang_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\QuanLyBanHang_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [QuanLyBanHang] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyBanHang].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyBanHang] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyBanHang] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyBanHang] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyBanHang] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyBanHang] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyBanHang] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyBanHang] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyBanHang] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyBanHang] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyBanHang] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyBanHang] SET QUERY_STORE = OFF
GO
USE [QuanLyBanHang]
GO
/****** Object:  Table [dbo].[HANGHOA]    Script Date: 5/25/2022 10:32:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HANGHOA](
	[MaHang] [nvarchar](255) NOT NULL,
	[TenHang] [nvarchar](255) NULL,
	[NhaCC] [nvarchar](255) NULL,
	[DVT] [int] NULL,
	[MaLoai] [nvarchar](255) NULL,
	[GiaBan] [int] NULL,
	[Anh] [nvarchar](50) NULL,
 CONSTRAINT [PK_HANGHOA] PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 5/25/2022 10:32:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [nvarchar](25) NOT NULL,
	[TenKH] [nvarchar](255) NULL,
	[DiaChi] [nvarchar](255) NULL,
	[DienThoai] [nvarchar](12) NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOGIN]    Script Date: 5/25/2022 10:32:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOGIN](
	[Username] [nvarchar](255) NOT NULL,
	[Password] [nvarchar](255) NULL,
 CONSTRAINT [PK_LOGIN] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHAPKHO]    Script Date: 5/25/2022 10:32:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHAPKHO](
	[SoPhieuN] [int] NOT NULL,
	[NgayNhap] [datetime] NULL,
	[MaNV] [nvarchar](25) NULL,
	[LyDoNhap] [nvarchar](max) NULL,
 CONSTRAINT [PK_NHAPKHO] PRIMARY KEY CLUSTERED 
(
	[SoPhieuN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHAPKHO_CT]    Script Date: 5/25/2022 10:32:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHAPKHO_CT](
	[SoPhieuN] [int] NOT NULL,
	[STT] [int] IDENTITY(1,1) NOT NULL,
	[MaHang] [nvarchar](255) NULL,
	[SLNhap] [int] NULL,
	[DGNhap] [int] NULL,
 CONSTRAINT [PK_NHAPKHO_CT] PRIMARY KEY CLUSTERED 
(
	[STT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[XUATKHO]    Script Date: 5/25/2022 10:32:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[XUATKHO](
	[SoPhieuX] [int] NOT NULL,
	[NgayXuat] [datetime] NULL,
	[MaKH] [nvarchar](25) NULL,
	[LyDoXuat] [nvarchar](max) NULL,
 CONSTRAINT [PK_XUATKHO] PRIMARY KEY CLUSTERED 
(
	[SoPhieuX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[XUATKHO_CT]    Script Date: 5/25/2022 10:32:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[XUATKHO_CT](
	[SoPhieuX] [int] NOT NULL,
	[STT] [int] IDENTITY(1,1) NOT NULL,
	[MaHang] [nvarchar](255) NULL,
	[SLXuat] [int] NULL,
	[DGXuat] [int] NULL,
 CONSTRAINT [PK_XUATKHO_CT] PRIMARY KEY CLUSTERED 
(
	[STT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [NhaCC], [DVT], [MaLoai], [GiaBan], [Anh]) VALUES (N'7UP', N'7UP', N'PEPSICO', 5, N'UP', 150000, N'anh6.jpg')
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [NhaCC], [DVT], [MaLoai], [GiaBan], [Anh]) VALUES (N'B', N'Bia', N'BIA', 2, N'B1', 150000, N'anh1.jpg')
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [NhaCC], [DVT], [MaLoai], [GiaBan], [Anh]) VALUES (N'CC', N'COCA', N'COCA', 1, N'CC1', 50000, N'anh2.jpg')
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [NhaCC], [DVT], [MaLoai], [GiaBan], [Anh]) VALUES (N'NB1', N'NUMBER1', N'PEPSICO', 5, N'NB1', 170000, N'anh8.jpg')
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [NhaCC], [DVT], [MaLoai], [GiaBan], [Anh]) VALUES (N'OLONG', N'OLONG', N'PEPSICO', 5, N'OLONG', 120000, N'anh7.jpg')
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [NhaCC], [DVT], [MaLoai], [GiaBan], [Anh]) VALUES (N'PS', N'PEPSI', N'PEPSICO', 1, N'PS1', 100000, N'anh3.jpg')
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [NhaCC], [DVT], [MaLoai], [GiaBan], [Anh]) VALUES (N'STI', N'STING', N'PEPSICO', 2, N'ST', 150000, N'anh5.jpg')
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [NhaCC], [DVT], [MaLoai], [GiaBan], [Anh]) VALUES (N'STR', N'STRONGBOW', N'vbl', 2, N'SB', 150000, N'anh4.jpg')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChi], [DienThoai]) VALUES (N'01', N'Lý Anh', N'Nguyễn Trãi', N'0123456789')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChi], [DienThoai]) VALUES (N'02', N'Hữu Đông', N'Hoàng Diệu', N'0987654321')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChi], [DienThoai]) VALUES (N'03', N'Đình Khôi', N'Quận 6', N'0912584788')
INSERT [dbo].[LOGIN] ([Username], [Password]) VALUES (N'admin', N'1234')
INSERT [dbo].[NHAPKHO] ([SoPhieuN], [NgayNhap], [MaNV], [LyDoNhap]) VALUES (1, CAST(N'2022-03-01T00:00:00.000' AS DateTime), N'01', N'Nhập hàng tháng 5')
INSERT [dbo].[NHAPKHO] ([SoPhieuN], [NgayNhap], [MaNV], [LyDoNhap]) VALUES (2, CAST(N'2022-04-01T00:00:00.000' AS DateTime), N'01', N'Nhập hàng tháng 5')
INSERT [dbo].[NHAPKHO] ([SoPhieuN], [NgayNhap], [MaNV], [LyDoNhap]) VALUES (3, CAST(N'2022-05-05T00:00:00.000' AS DateTime), N'02', N'Nhập hàng tháng 3')
INSERT [dbo].[NHAPKHO] ([SoPhieuN], [NgayNhap], [MaNV], [LyDoNhap]) VALUES (4, CAST(N'2022-05-20T00:00:00.000' AS DateTime), N'02', N'Nhập hàng tháng 5')
INSERT [dbo].[NHAPKHO] ([SoPhieuN], [NgayNhap], [MaNV], [LyDoNhap]) VALUES (5, CAST(N'2022-05-15T00:00:00.000' AS DateTime), N'02', N'Nhập hàng tháng 4')
INSERT [dbo].[NHAPKHO] ([SoPhieuN], [NgayNhap], [MaNV], [LyDoNhap]) VALUES (6, CAST(N'2022-05-01T00:00:00.000' AS DateTime), N'02', N'Bán cho khách VIP')
INSERT [dbo].[NHAPKHO] ([SoPhieuN], [NgayNhap], [MaNV], [LyDoNhap]) VALUES (7, CAST(N'2022-05-25T00:00:00.000' AS DateTime), N'03', N'Nhập hàng tháng 5')
INSERT [dbo].[NHAPKHO] ([SoPhieuN], [NgayNhap], [MaNV], [LyDoNhap]) VALUES (8, CAST(N'2022-05-17T00:00:00.000' AS DateTime), N'02', N'Nhập hàng mới')
SET IDENTITY_INSERT [dbo].[NHAPKHO_CT] ON 

INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [SLNhap], [DGNhap]) VALUES (1, 1, N'PS', 10, 10000)
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [SLNhap], [DGNhap]) VALUES (1, 2, N'CC', 10, 10000)
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [SLNhap], [DGNhap]) VALUES (1, 3, N'B', 10, 7000)
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [SLNhap], [DGNhap]) VALUES (2, 4, N'PS', 20, 9000)
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [SLNhap], [DGNhap]) VALUES (2, 5, N'CC', 20, 6000)
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [SLNhap], [DGNhap]) VALUES (2, 6, N'B', 20, 6000)
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [SLNhap], [DGNhap]) VALUES (5, 7, N'PS', 10, 50000)
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [SLNhap], [DGNhap]) VALUES (5, 8, N'CC', 20, 100000)
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [SLNhap], [DGNhap]) VALUES (5, 9, N'B', 10, 50000)
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [SLNhap], [DGNhap]) VALUES (6, 14, N'B', 20, 20000)
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [SLNhap], [DGNhap]) VALUES (6, 15, N'CC', 10, 50000)
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [SLNhap], [DGNhap]) VALUES (6, 16, N'PS', 15, 30000)
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [SLNhap], [DGNhap]) VALUES (3, 17, N'CC', 5, 50000)
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [SLNhap], [DGNhap]) VALUES (4, 18, N'CC', 10, 30000)
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [SLNhap], [DGNhap]) VALUES (4, 19, N'PS', 15, 40000)
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [SLNhap], [DGNhap]) VALUES (1, 20, N'STR', 10, 20000)
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [SLNhap], [DGNhap]) VALUES (1, 21, N'STI', 10, 20000)
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [SLNhap], [DGNhap]) VALUES (1, 22, N'7UP', 10, 20000)
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [SLNhap], [DGNhap]) VALUES (1, 23, N'OLONG', 10, 20000)
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [SLNhap], [DGNhap]) VALUES (1, 24, N'NB1', 10, 20000)
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [SLNhap], [DGNhap]) VALUES (2, 25, N'STR', 20, 22000)
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [SLNhap], [DGNhap]) VALUES (2, 26, N'STI', 20, 22000)
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [SLNhap], [DGNhap]) VALUES (2, 27, N'7UP', 20, 22000)
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [SLNhap], [DGNhap]) VALUES (2, 28, N'OLONG', 20, 22000)
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [SLNhap], [DGNhap]) VALUES (2, 29, N'NB1', 20, 22000)
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [SLNhap], [DGNhap]) VALUES (7, 30, N'OLONG', 10, 20000)
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [SLNhap], [DGNhap]) VALUES (7, 31, N'NB1', 10, 30000)
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [SLNhap], [DGNhap]) VALUES (8, 32, N'CC', 10, 20000)
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [SLNhap], [DGNhap]) VALUES (8, 33, N'NB1', 20, 20000)
SET IDENTITY_INSERT [dbo].[NHAPKHO_CT] OFF
INSERT [dbo].[XUATKHO] ([SoPhieuX], [NgayXuat], [MaKH], [LyDoXuat]) VALUES (1, CAST(N'2022-03-20T00:00:00.000' AS DateTime), N'01', N'Bán lẻ')
INSERT [dbo].[XUATKHO] ([SoPhieuX], [NgayXuat], [MaKH], [LyDoXuat]) VALUES (2, CAST(N'2022-04-26T00:00:00.000' AS DateTime), N'02', N'Khách hàng yêu cầu')
INSERT [dbo].[XUATKHO] ([SoPhieuX], [NgayXuat], [MaKH], [LyDoXuat]) VALUES (3, CAST(N'2022-05-22T00:00:00.000' AS DateTime), N'03', N'Khách hàng đặt')
INSERT [dbo].[XUATKHO] ([SoPhieuX], [NgayXuat], [MaKH], [LyDoXuat]) VALUES (4, CAST(N'2022-04-01T00:00:00.000' AS DateTime), N'01', N'Bán lẻ')
INSERT [dbo].[XUATKHO] ([SoPhieuX], [NgayXuat], [MaKH], [LyDoXuat]) VALUES (5, CAST(N'2022-05-24T00:00:00.000' AS DateTime), N'03', N'Bán lẻ')
SET IDENTITY_INSERT [dbo].[XUATKHO_CT] ON 

INSERT [dbo].[XUATKHO_CT] ([SoPhieuX], [STT], [MaHang], [SLXuat], [DGXuat]) VALUES (1, 1, N'PS', 2, 100000)
INSERT [dbo].[XUATKHO_CT] ([SoPhieuX], [STT], [MaHang], [SLXuat], [DGXuat]) VALUES (2, 2, N'CC', 1, 50000)
INSERT [dbo].[XUATKHO_CT] ([SoPhieuX], [STT], [MaHang], [SLXuat], [DGXuat]) VALUES (1, 5, N'B', 1, 150000)
INSERT [dbo].[XUATKHO_CT] ([SoPhieuX], [STT], [MaHang], [SLXuat], [DGXuat]) VALUES (1, 6, N'CC', 2, 50000)
INSERT [dbo].[XUATKHO_CT] ([SoPhieuX], [STT], [MaHang], [SLXuat], [DGXuat]) VALUES (2, 7, N'PS', 5, 100000)
INSERT [dbo].[XUATKHO_CT] ([SoPhieuX], [STT], [MaHang], [SLXuat], [DGXuat]) VALUES (3, 8, N'PS', 1, 100000)
INSERT [dbo].[XUATKHO_CT] ([SoPhieuX], [STT], [MaHang], [SLXuat], [DGXuat]) VALUES (3, 9, N'CC', 2, 50000)
INSERT [dbo].[XUATKHO_CT] ([SoPhieuX], [STT], [MaHang], [SLXuat], [DGXuat]) VALUES (4, 10, N'PS', 8, 100000)
INSERT [dbo].[XUATKHO_CT] ([SoPhieuX], [STT], [MaHang], [SLXuat], [DGXuat]) VALUES (4, 11, N'CC', 16, 200000)
INSERT [dbo].[XUATKHO_CT] ([SoPhieuX], [STT], [MaHang], [SLXuat], [DGXuat]) VALUES (4, 12, N'B', 7, 70000)
INSERT [dbo].[XUATKHO_CT] ([SoPhieuX], [STT], [MaHang], [SLXuat], [DGXuat]) VALUES (5, 13, N'CC', 10, 20000)
INSERT [dbo].[XUATKHO_CT] ([SoPhieuX], [STT], [MaHang], [SLXuat], [DGXuat]) VALUES (5, 14, N'B', 20, 20000)
INSERT [dbo].[XUATKHO_CT] ([SoPhieuX], [STT], [MaHang], [SLXuat], [DGXuat]) VALUES (1, 15, N'STR', 8, 30000)
INSERT [dbo].[XUATKHO_CT] ([SoPhieuX], [STT], [MaHang], [SLXuat], [DGXuat]) VALUES (1, 16, N'STI', 8, 30000)
INSERT [dbo].[XUATKHO_CT] ([SoPhieuX], [STT], [MaHang], [SLXuat], [DGXuat]) VALUES (1, 17, N'7UP', 8, 30000)
INSERT [dbo].[XUATKHO_CT] ([SoPhieuX], [STT], [MaHang], [SLXuat], [DGXuat]) VALUES (1, 18, N'OLONG', 8, 30000)
INSERT [dbo].[XUATKHO_CT] ([SoPhieuX], [STT], [MaHang], [SLXuat], [DGXuat]) VALUES (1, 19, N'NB1', 8, 30000)
INSERT [dbo].[XUATKHO_CT] ([SoPhieuX], [STT], [MaHang], [SLXuat], [DGXuat]) VALUES (2, 20, N'B', 8, 30000)
INSERT [dbo].[XUATKHO_CT] ([SoPhieuX], [STT], [MaHang], [SLXuat], [DGXuat]) VALUES (2, 21, N'STR', 8, 30000)
INSERT [dbo].[XUATKHO_CT] ([SoPhieuX], [STT], [MaHang], [SLXuat], [DGXuat]) VALUES (2, 22, N'STI', 8, 30000)
INSERT [dbo].[XUATKHO_CT] ([SoPhieuX], [STT], [MaHang], [SLXuat], [DGXuat]) VALUES (2, 23, N'7UP', 8, 30000)
INSERT [dbo].[XUATKHO_CT] ([SoPhieuX], [STT], [MaHang], [SLXuat], [DGXuat]) VALUES (2, 24, N'OLONG', 8, 30000)
INSERT [dbo].[XUATKHO_CT] ([SoPhieuX], [STT], [MaHang], [SLXuat], [DGXuat]) VALUES (2, 25, N'NB1', 8, 30000)
SET IDENTITY_INSERT [dbo].[XUATKHO_CT] OFF
ALTER TABLE [dbo].[NHAPKHO_CT]  WITH CHECK ADD  CONSTRAINT [FK_NHAPKHO_CT_HANGHOA] FOREIGN KEY([MaHang])
REFERENCES [dbo].[HANGHOA] ([MaHang])
GO
ALTER TABLE [dbo].[NHAPKHO_CT] CHECK CONSTRAINT [FK_NHAPKHO_CT_HANGHOA]
GO
ALTER TABLE [dbo].[NHAPKHO_CT]  WITH CHECK ADD  CONSTRAINT [FK_NHAPKHO_CT_NHAPKHO] FOREIGN KEY([SoPhieuN])
REFERENCES [dbo].[NHAPKHO] ([SoPhieuN])
GO
ALTER TABLE [dbo].[NHAPKHO_CT] CHECK CONSTRAINT [FK_NHAPKHO_CT_NHAPKHO]
GO
ALTER TABLE [dbo].[XUATKHO]  WITH CHECK ADD  CONSTRAINT [FK_XUATKHO_KHACHHANG] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[XUATKHO] CHECK CONSTRAINT [FK_XUATKHO_KHACHHANG]
GO
ALTER TABLE [dbo].[XUATKHO_CT]  WITH CHECK ADD  CONSTRAINT [FK_XUATKHO_CT_HANGHOA] FOREIGN KEY([MaHang])
REFERENCES [dbo].[HANGHOA] ([MaHang])
GO
ALTER TABLE [dbo].[XUATKHO_CT] CHECK CONSTRAINT [FK_XUATKHO_CT_HANGHOA]
GO
ALTER TABLE [dbo].[XUATKHO_CT]  WITH CHECK ADD  CONSTRAINT [FK_XUATKHO_CT_XUATKHO] FOREIGN KEY([SoPhieuX])
REFERENCES [dbo].[XUATKHO] ([SoPhieuX])
GO
ALTER TABLE [dbo].[XUATKHO_CT] CHECK CONSTRAINT [FK_XUATKHO_CT_XUATKHO]
GO
USE [master]
GO
ALTER DATABASE [QuanLyBanHang] SET  READ_WRITE 
GO
