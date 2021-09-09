USE [QLNhaTro]
GO
/****** Object:  StoredProcedure [dbo].[XoaPhong]    Script Date: 9/9/2021 11:22:58 AM ******/
DROP PROCEDURE [dbo].[XoaPhong]
GO
/****** Object:  StoredProcedure [dbo].[XoaPhi]    Script Date: 9/9/2021 11:22:58 AM ******/
DROP PROCEDURE [dbo].[XoaPhi]
GO
/****** Object:  StoredProcedure [dbo].[XoaLP]    Script Date: 9/9/2021 11:22:58 AM ******/
DROP PROCEDURE [dbo].[XoaLP]
GO
/****** Object:  StoredProcedure [dbo].[XemDSPhong]    Script Date: 9/9/2021 11:22:58 AM ******/
DROP PROCEDURE [dbo].[XemDSPhong]
GO
/****** Object:  StoredProcedure [dbo].[XemCacLoaiPhi]    Script Date: 9/9/2021 11:22:58 AM ******/
DROP PROCEDURE [dbo].[XemCacLoaiPhi]
GO
/****** Object:  StoredProcedure [dbo].[ThemPhong]    Script Date: 9/9/2021 11:22:58 AM ******/
DROP PROCEDURE [dbo].[ThemPhong]
GO
/****** Object:  StoredProcedure [dbo].[ThemPhi]    Script Date: 9/9/2021 11:22:58 AM ******/
DROP PROCEDURE [dbo].[ThemPhi]
GO
/****** Object:  StoredProcedure [dbo].[ThemLP]    Script Date: 9/9/2021 11:22:58 AM ******/
DROP PROCEDURE [dbo].[ThemLP]
GO
/****** Object:  StoredProcedure [dbo].[SuaPhong]    Script Date: 9/9/2021 11:22:58 AM ******/
DROP PROCEDURE [dbo].[SuaPhong]
GO
/****** Object:  StoredProcedure [dbo].[SuaPhi]    Script Date: 9/9/2021 11:22:58 AM ******/
DROP PROCEDURE [dbo].[SuaPhi]
GO
/****** Object:  StoredProcedure [dbo].[SuaLP]    Script Date: 9/9/2021 11:22:58 AM ******/
DROP PROCEDURE [dbo].[SuaLP]
GO
/****** Object:  StoredProcedure [dbo].[LayPhongTrongTheoLoai]    Script Date: 9/9/2021 11:22:58 AM ******/
DROP PROCEDURE [dbo].[LayPhongTrongTheoLoai]
GO
/****** Object:  StoredProcedure [dbo].[LayDSLoaiPhong]    Script Date: 9/9/2021 11:22:58 AM ******/
DROP PROCEDURE [dbo].[LayDSLoaiPhong]
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
/****** Object:  Table [dbo].[TraPhong]    Script Date: 9/9/2021 11:22:58 AM ******/
DROP TABLE [dbo].[TraPhong]
GO
/****** Object:  Table [dbo].[ThuePhong]    Script Date: 9/9/2021 11:22:58 AM ******/
DROP TABLE [dbo].[ThuePhong]
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 9/9/2021 11:22:58 AM ******/
DROP TABLE [dbo].[Phong]
GO
/****** Object:  Table [dbo].[Phi]    Script Date: 9/9/2021 11:22:58 AM ******/
DROP TABLE [dbo].[Phi]
GO
/****** Object:  Table [dbo].[LoaiPhong]    Script Date: 9/9/2021 11:22:58 AM ******/
DROP TABLE [dbo].[LoaiPhong]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 9/9/2021 11:22:58 AM ******/
DROP TABLE [dbo].[KhachHang]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 9/9/2021 11:22:58 AM ******/
DROP TABLE [dbo].[HoaDon]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 9/9/2021 11:22:58 AM ******/
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
/****** Object:  Table [dbo].[KhachHang]    Script Date: 9/9/2021 11:22:58 AM ******/
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
/****** Object:  Table [dbo].[LoaiPhong]    Script Date: 9/9/2021 11:22:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiPhong](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenLP] [nvarchar](10) NOT NULL,
	[GiaTien] [decimal](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Phi]    Script Date: 9/9/2021 11:22:58 AM ******/
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
/****** Object:  Table [dbo].[Phong]    Script Date: 9/9/2021 11:22:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenPhong] [nvarchar](10) NOT NULL,
	[IDLoaiPhong] [int] NOT NULL,
	[SoNguoiToiDa] [int] NOT NULL DEFAULT ((0)),
	[SoNguoiHienTai] [int] NOT NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThuePhong]    Script Date: 9/9/2021 11:22:58 AM ******/
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
/****** Object:  Table [dbo].[TraPhong]    Script Date: 9/9/2021 11:22:58 AM ******/
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
SET IDENTITY_INSERT [dbo].[LoaiPhong] ON 

INSERT [dbo].[LoaiPhong] ([ID], [TenLP], [GiaTien]) VALUES (1, N'Nhỏ', CAST(1500000 AS Decimal(18, 0)))
INSERT [dbo].[LoaiPhong] ([ID], [TenLP], [GiaTien]) VALUES (2, N'Vừa', CAST(2000000 AS Decimal(18, 0)))
INSERT [dbo].[LoaiPhong] ([ID], [TenLP], [GiaTien]) VALUES (3, N'Lớn', CAST(2500000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[LoaiPhong] OFF
SET IDENTITY_INSERT [dbo].[Phi] ON 

INSERT [dbo].[Phi] ([ID], [TenPhi], [GiaTien]) VALUES (1, N'Điện', CAST(3000 AS Decimal(18, 0)))
INSERT [dbo].[Phi] ([ID], [TenPhi], [GiaTien]) VALUES (2, N'Nước', CAST(6300 AS Decimal(18, 0)))
INSERT [dbo].[Phi] ([ID], [TenPhi], [GiaTien]) VALUES (3, N'Dịch vụ', CAST(20000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[Phi] OFF
SET IDENTITY_INSERT [dbo].[Phong] ON 

INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SoNguoiToiDa], [SoNguoiHienTai]) VALUES (1, N'001', 1, 2, 0)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SoNguoiToiDa], [SoNguoiHienTai]) VALUES (2, N'002', 2, 3, 0)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SoNguoiToiDa], [SoNguoiHienTai]) VALUES (3, N'003', 3, 4, 0)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SoNguoiToiDa], [SoNguoiHienTai]) VALUES (4, N'004', 2, 3, 0)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SoNguoiToiDa], [SoNguoiHienTai]) VALUES (5, N'005', 1, 2, 0)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SoNguoiToiDa], [SoNguoiHienTai]) VALUES (6, N'006', 3, 4, 0)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SoNguoiToiDa], [SoNguoiHienTai]) VALUES (8, N'007', 2, 3, 0)
SET IDENTITY_INSERT [dbo].[Phong] OFF
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
/****** Object:  StoredProcedure [dbo].[LayDSLoaiPhong]    Script Date: 9/9/2021 11:22:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LayDSLoaiPhong]
AS
	SELECT * FROM LoaiPhong


GO
/****** Object:  StoredProcedure [dbo].[LayPhongTrongTheoLoai]    Script Date: 9/9/2021 11:22:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LayPhongTrongTheoLoai](@idLoai INT)
AS
	SELECT * FROM Phong 
	WHERE IDLoaiPhong = @idLoai
		AND SoNguoiHienTai = 0


GO
/****** Object:  StoredProcedure [dbo].[SuaLP]    Script Date: 9/9/2021 11:22:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaLP] (@id int, @Ten NVARCHAR(10), @Gia DECIMAL(18, 0))
AS
	UPDATE LoaiPhong
	SET TenLP = @Ten,
		GiaTien = @Gia
	WHERE ID = @id


GO
/****** Object:  StoredProcedure [dbo].[SuaPhi]    Script Date: 9/9/2021 11:22:58 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SuaPhong]    Script Date: 9/9/2021 11:22:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaPhong] (@id int, @Ten NVARCHAR(10), @Loai int, @ToiDa int, @HienTai int)
AS
	UPDATE Phong
	SET TenPhong = @Ten, 
		IDLoaiPhong = @Loai, 
		SoNguoiToiDa = @ToiDa, 
		SoNguoiHienTai = @HienTai
	WHERE ID = @id


GO
/****** Object:  StoredProcedure [dbo].[ThemLP]    Script Date: 9/9/2021 11:22:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemLP] (@Ten NVARCHAR(10), @Gia DECIMAL(18, 0))
AS
	INSERT INTO LoaiPhong(TenLP, GiaTien) VALUES (@Ten, @Gia)


GO
/****** Object:  StoredProcedure [dbo].[ThemPhi]    Script Date: 9/9/2021 11:22:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemPhi] (@Ten NVARCHAR(10), @GiaTien DECIMAL(18,0))
AS
	INSERT INTO Phi (TenPhi, GiaTien) VALUES (@Ten, @GiaTien)

GO
/****** Object:  StoredProcedure [dbo].[ThemPhong]    Script Date: 9/9/2021 11:22:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemPhong] (@Ten NVARCHAR(10), @Loai int, @ToiDa int, @HienTai int)
AS
	INSERT INTO Phong(TenPhong, IDLoaiPhong, SoNguoiToiDa, SoNguoiHienTai) 
	VALUES (@Ten, @Loai, @ToiDa, @HienTai)


GO
/****** Object:  StoredProcedure [dbo].[XemCacLoaiPhi]    Script Date: 9/9/2021 11:22:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XemCacLoaiPhi]
AS
	SELECT * FROM Phi

GO
/****** Object:  StoredProcedure [dbo].[XemDSPhong]    Script Date: 9/9/2021 11:22:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XemDSPhong]
AS
	SELECT Phong.ID, TenPhong, TenLP, SoNguoiToiDa, SoNguoiHienTai  FROM Phong, LoaiPhong
	WHERE Phong.IDLoaiPhong = LoaiPhong.ID
	ORDER BY Phong.ID DESC

GO
/****** Object:  StoredProcedure [dbo].[XoaLP]    Script Date: 9/9/2021 11:22:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaLP] (@id INT)
AS
	DELETE FROM LoaiPhong WHERE ID = @id


GO
/****** Object:  StoredProcedure [dbo].[XoaPhi]    Script Date: 9/9/2021 11:22:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaPhi] (@id INT)
AS
	DELETE FROM Phi WHERE ID = @id

GO
/****** Object:  StoredProcedure [dbo].[XoaPhong]    Script Date: 9/9/2021 11:22:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaPhong] (@id INT)
AS
	DELETE FROM Phong WHERE ID = @id


GO
