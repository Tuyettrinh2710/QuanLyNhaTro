USE [QLNhaTro]
GO
/****** Object:  StoredProcedure [dbo].[XoaPhi]    Script Date: 9/4/2021 6:19:13 PM ******/
DROP PROCEDURE [dbo].[XoaPhi]
GO
/****** Object:  StoredProcedure [dbo].[XemCacLoaiPhi]    Script Date: 9/4/2021 6:19:13 PM ******/
DROP PROCEDURE [dbo].[XemCacLoaiPhi]
GO
/****** Object:  StoredProcedure [dbo].[ThemPhi]    Script Date: 9/4/2021 6:19:13 PM ******/
DROP PROCEDURE [dbo].[ThemPhi]
GO
/****** Object:  StoredProcedure [dbo].[SuaPhi]    Script Date: 9/4/2021 6:19:13 PM ******/
DROP PROCEDURE [dbo].[SuaPhi]
GO
ALTER TABLE [dbo].[TraPhong] DROP CONSTRAINT [FK__TraPhong__5CD6CB2B]
GO
ALTER TABLE [dbo].[ThuePhong] DROP CONSTRAINT [FK__ThuePhong__ID_Ph__5629CD9C]
GO
ALTER TABLE [dbo].[ThuePhong] DROP CONSTRAINT [FK__ThuePhong__ID_KH__5535A963]
GO
ALTER TABLE [dbo].[Phong] DROP CONSTRAINT [FK__Phong__IDLoaiPho__4D94879B]
GO
ALTER TABLE [dbo].[KhachHang] DROP CONSTRAINT [FK__KhachHang__MaPho__5070F446]
GO
ALTER TABLE [dbo].[HoaDon] DROP CONSTRAINT [FK__HoaDon__ID_Phong__70DDC3D8]
GO
ALTER TABLE [dbo].[HoaDon] DROP CONSTRAINT [FK__HoaDon__ID_KH__6FE99F9F]
GO
ALTER TABLE [dbo].[Phong] DROP CONSTRAINT [DF__Phong__SoNguoiHi__4CA06362]
GO
ALTER TABLE [dbo].[Phong] DROP CONSTRAINT [DF__Phong__SoNguoiTo__4BAC3F29]
GO
/****** Object:  Table [dbo].[TraPhong]    Script Date: 9/4/2021 6:19:13 PM ******/
DROP TABLE [dbo].[TraPhong]
GO
/****** Object:  Table [dbo].[ThuePhong]    Script Date: 9/4/2021 6:19:13 PM ******/
DROP TABLE [dbo].[ThuePhong]
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 9/4/2021 6:19:13 PM ******/
DROP TABLE [dbo].[Phong]
GO
/****** Object:  Table [dbo].[Phi]    Script Date: 9/4/2021 6:19:13 PM ******/
DROP TABLE [dbo].[Phi]
GO
/****** Object:  Table [dbo].[LoaiPhong]    Script Date: 9/4/2021 6:19:13 PM ******/
DROP TABLE [dbo].[LoaiPhong]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 9/4/2021 6:19:13 PM ******/
DROP TABLE [dbo].[KhachHang]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 9/4/2021 6:19:13 PM ******/
DROP TABLE [dbo].[HoaDon]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 9/4/2021 6:19:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_KH] [nvarchar](10) NOT NULL,
	[ID_Phong] [int] NOT NULL,
	[NgayLap] [datetime] NULL,
	[NgayThu] [datetime] NULL,
	[GiaPhong] [decimal](18, 0) NULL,
	[SkDien] [int] NULL,
	[TienDien] [decimal](18, 0) NULL,
	[SkNuoc] [int] NULL,
	[TienNuoc] [decimal](18, 0) NULL,
	[TienDV] [decimal](18, 0) NULL,
	[TongTien] [decimal](18, 0) NULL,
	[TrangThai] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 9/4/2021 6:19:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[ID] [nvarchar](10) NOT NULL,
	[HoTen] [nvarchar](100) NOT NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[NgaySinh] [datetime] NULL,
	[Sdt] [nvarchar](10) NOT NULL,
	[CMND] [nvarchar](12) NOT NULL,
	[QueQuan] [nvarchar](150) NOT NULL,
	[MaPhong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiPhong]    Script Date: 9/4/2021 6:19:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiPhong](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenLP] [nvarchar](10) NOT NULL,
	[DienTich] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Phi]    Script Date: 9/4/2021 6:19:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phi](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenPhi] [nvarchar](10) NOT NULL,
	[GiaTien] [decimal](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Phong]    Script Date: 9/4/2021 6:19:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenPhong] [nvarchar](10) NOT NULL,
	[IDLoaiPhong] [int] NOT NULL,
	[SoNguoiToiDa] [int] NOT NULL,
	[SoNguoiHienTai] [int] NOT NULL,
	[GiaTien] [decimal](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThuePhong]    Script Date: 9/4/2021 6:19:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThuePhong](
	[ID] [nvarchar](10) NOT NULL,
	[ID_KH] [nvarchar](10) NOT NULL,
	[ID_Phong] [int] NOT NULL,
	[NgayThue] [datetime] NULL,
	[TienCoc] [decimal](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[ID_KH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TraPhong]    Script Date: 9/4/2021 6:19:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TraPhong](
	[ID_Thue] [nvarchar](10) NOT NULL,
	[ID_KH] [nvarchar](10) NOT NULL,
	[ID_Phong] [int] NOT NULL,
	[NgayThue] [datetime] NULL,
	[NgayTra] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Thue] ASC,
	[ID_KH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Phi] ON 

INSERT [dbo].[Phi] ([ID], [TenPhi], [GiaTien]) VALUES (1, N'Điện', CAST(2927 AS Decimal(18, 0)))
INSERT [dbo].[Phi] ([ID], [TenPhi], [GiaTien]) VALUES (2, N'Nước', CAST(6300 AS Decimal(18, 0)))
INSERT [dbo].[Phi] ([ID], [TenPhi], [GiaTien]) VALUES (3, N'Dịch vụ', CAST(20000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[Phi] OFF
ALTER TABLE [dbo].[Phong] ADD  DEFAULT ((0)) FOR [SoNguoiToiDa]
GO
ALTER TABLE [dbo].[Phong] ADD  DEFAULT ((0)) FOR [SoNguoiHienTai]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([ID_KH])
REFERENCES [dbo].[KhachHang] ([ID])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([ID_Phong])
REFERENCES [dbo].[Phong] ([ID])
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([ID])
GO
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD FOREIGN KEY([IDLoaiPhong])
REFERENCES [dbo].[LoaiPhong] ([ID])
GO
ALTER TABLE [dbo].[ThuePhong]  WITH CHECK ADD FOREIGN KEY([ID_KH])
REFERENCES [dbo].[KhachHang] ([ID])
GO
ALTER TABLE [dbo].[ThuePhong]  WITH CHECK ADD FOREIGN KEY([ID_Phong])
REFERENCES [dbo].[Phong] ([ID])
GO
ALTER TABLE [dbo].[TraPhong]  WITH CHECK ADD FOREIGN KEY([ID_Thue], [ID_KH])
REFERENCES [dbo].[ThuePhong] ([ID], [ID_KH])
GO
/****** Object:  StoredProcedure [dbo].[SuaPhi]    Script Date: 9/4/2021 6:19:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaPhi](@id int, @Ten NVARCHAR(10), @GiaTien DECIMAL(18,0))
AS
	UPDATE Phi
	SET TenPhi = @Ten,
		GiaTien = @GiaTien
	WHERE ID = @id

GO
/****** Object:  StoredProcedure [dbo].[ThemPhi]    Script Date: 9/4/2021 6:19:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemPhi] (@Ten NVARCHAR(10), @GiaTien DECIMAL(18,0))
AS
	INSERT INTO Phi (TenPhi, GiaTien) VALUES (@Ten, @GiaTien)

GO
/****** Object:  StoredProcedure [dbo].[XemCacLoaiPhi]    Script Date: 9/4/2021 6:19:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XemCacLoaiPhi]
AS
	SELECT * FROM Phi

GO
/****** Object:  StoredProcedure [dbo].[XoaPhi]    Script Date: 9/4/2021 6:19:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaPhi] (@id INT)
AS
	DELETE FROM Phi WHERE ID = @id

GO
