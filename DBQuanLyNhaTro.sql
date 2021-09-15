USE [QLNhaTro]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 9/15/2021 2:56:54 PM ******/
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
/****** Object:  Table [dbo].[KhachHang]    Script Date: 9/15/2021 2:56:54 PM ******/
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
/****** Object:  Table [dbo].[LoaiPhong]    Script Date: 9/15/2021 2:56:54 PM ******/
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
/****** Object:  Table [dbo].[Phi]    Script Date: 9/15/2021 2:56:54 PM ******/
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
/****** Object:  Table [dbo].[Phong]    Script Date: 9/15/2021 2:56:54 PM ******/
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
/****** Object:  Table [dbo].[ThamSo]    Script Date: 9/15/2021 2:56:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThamSo](
	[ID] [nvarchar](2) NOT NULL,
	[GiaTri] [nvarchar](8) NULL,
	[GhiChu] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThuePhong]    Script Date: 9/15/2021 2:56:54 PM ******/
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
/****** Object:  Table [dbo].[TraPhong]    Script Date: 9/15/2021 2:56:54 PM ******/
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
INSERT [dbo].[KhachHang] ([ID], [HoTen], [GioiTinh], [NgaySinh], [Sdt], [CMND], [QueQuan], [MaPhong]) VALUES (N'0987433456', N'Phan Ngọc Ánh', N'Nữ', CAST(N'2000-06-13 16:12:51.000' AS DateTime), N'0987433456', N'092300001223', N'Kiên Giang', 22)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [GioiTinh], [NgaySinh], [Sdt], [CMND], [QueQuan], [MaPhong]) VALUES (N'0987654321', N'Lương Dương Bình', N'Nam', CAST(N'2012-06-14 10:31:51.000' AS DateTime), N'0987654321', N'092300382912', N'371 Nguyễn Kiệm, phường 3, quận Gò Vấp, TP.HCM', 2)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [GioiTinh], [NgaySinh], [Sdt], [CMND], [QueQuan], [MaPhong]) VALUES (N'0987665547', N'Nguyễn Ngọc Lan', N'Nam', CAST(N'1999-10-19 10:42:33.000' AS DateTime), N'0987665547', N'098765432235', N'Cần Thơ', 29)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [GioiTinh], [NgaySinh], [Sdt], [CMND], [QueQuan], [MaPhong]) VALUES (N'0987723554', N'Lê Thị Thu Thủy', N'Nữ', CAST(N'1998-09-13 17:13:51.000' AS DateTime), N'0987723554', N'092198000025', N'Cần Thơ', 5)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [GioiTinh], [NgaySinh], [Sdt], [CMND], [QueQuan], [MaPhong]) VALUES (N'0987764652', N'Trần Thị Bé Ba', N'Nữ', CAST(N'2021-09-13 17:16:36.940' AS DateTime), N'0987764652', N'092197003452', N'An Giang', 3)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [GioiTinh], [NgaySinh], [Sdt], [CMND], [QueQuan], [MaPhong]) VALUES (N'0988374631', N'Nguyễn Hoàng Minh', N'Nam', CAST(N'2000-08-10 00:00:00.000' AS DateTime), N'0988374633', N'098837463323', N'An Giang', 1)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [GioiTinh], [NgaySinh], [Sdt], [CMND], [QueQuan], [MaPhong]) VALUES (N'0988374633', N'Nguyễn Hải Đăng', N'Nam', CAST(N'2000-08-10 00:00:00.000' AS DateTime), N'0988374633', N'092310990981', N'An Giang', 1)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [GioiTinh], [NgaySinh], [Sdt], [CMND], [QueQuan], [MaPhong]) VALUES (N'0988575782', N'Lê Văn Minh', N'Nam', CAST(N'2000-06-13 00:00:00.000' AS DateTime), N'0988575782', N'123456789097', N'An Giang', 22)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [GioiTinh], [NgaySinh], [Sdt], [CMND], [QueQuan], [MaPhong]) VALUES (N'2345987654', N'Nguyễn Thanh Nhàn', N'Nam', CAST(N'2021-09-15 10:49:00.000' AS DateTime), N'0985987654', N'098757525576', N'Kiên Giang', 29)
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

INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SoNguoiToiDa], [SoNguoiHienTai]) VALUES (1, N'001', 1, 2, 2)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SoNguoiToiDa], [SoNguoiHienTai]) VALUES (2, N'002', 2, 3, 1)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SoNguoiToiDa], [SoNguoiHienTai]) VALUES (3, N'003', 3, 4, 1)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SoNguoiToiDa], [SoNguoiHienTai]) VALUES (4, N'004', 2, 3, 0)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SoNguoiToiDa], [SoNguoiHienTai]) VALUES (5, N'005', 1, 2, 1)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SoNguoiToiDa], [SoNguoiHienTai]) VALUES (6, N'006', 3, 4, 0)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SoNguoiToiDa], [SoNguoiHienTai]) VALUES (20, N'007', 1, 2, 0)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SoNguoiToiDa], [SoNguoiHienTai]) VALUES (21, N'008', 1, 2, 0)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SoNguoiToiDa], [SoNguoiHienTai]) VALUES (22, N'009', 2, 3, 2)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SoNguoiToiDa], [SoNguoiHienTai]) VALUES (23, N'010', 2, 3, 0)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SoNguoiToiDa], [SoNguoiHienTai]) VALUES (24, N'011', 3, 4, 0)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SoNguoiToiDa], [SoNguoiHienTai]) VALUES (25, N'012', 2, 3, 0)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SoNguoiToiDa], [SoNguoiHienTai]) VALUES (28, N'013', 3, 4, 0)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SoNguoiToiDa], [SoNguoiHienTai]) VALUES (29, N'014', 1, 2, 2)
SET IDENTITY_INSERT [dbo].[Phong] OFF
INSERT [dbo].[ThamSo] ([ID], [GiaTri], [GhiChu]) VALUES (N'TP', N'0', N'Mã thuê phòng')
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
/****** Object:  StoredProcedure [dbo].[KTIdKhachHangToiTai]    Script Date: 9/15/2021 2:56:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[KTIdKhachHangToiTai](@id NVARCHAR(10), @kq bit output)
AS
	BEGIN
		IF EXISTS (SELECT * FROM KhachHang WHERE ID = @id)
			set @kq = 1; 
		else
			set @kq = 0;
	END

GO
/****** Object:  StoredProcedure [dbo].[KTPhongTonTai]    Script Date: 9/15/2021 2:56:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[KTPhongTonTai](@idPhong int, @kq bit output)
AS
	BEGIN
		IF EXISTS (SELECT * FROM KhachHang WHERE MaPhong = @idPhong)
			set @kq = 1; 
		else
			set @kq = 0;
	END

GO
/****** Object:  StoredProcedure [dbo].[LayDSLoaiPhong]    Script Date: 9/15/2021 2:56:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LayDSLoaiPhong]
AS
	SELECT * FROM LoaiPhong


GO
/****** Object:  StoredProcedure [dbo].[LayMa]    Script Date: 9/15/2021 2:56:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LayMa](@id NVARCHAR(2), @giaTri NVARCHAR(8) output)
AS
	SELECT @giaTri = GiaTri FROM ThamSo
	WHERE ID = @id

GO
/****** Object:  StoredProcedure [dbo].[LayPhongTrongTheoLoai]    Script Date: 9/15/2021 2:56:54 PM ******/
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
/****** Object:  StoredProcedure [dbo].[LaySoNguoiHTVaTD]    Script Date: 9/15/2021 2:56:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LaySoNguoiHTVaTD] (@id int, @ToiDa int output, @HienTai int output)
AS
	SELECT @ToiDa = SoNguoiToiDa, @HienTai = SoNguoiHienTai 
	FROM Phong
	WHERE ID = @id

GO
/****** Object:  StoredProcedure [dbo].[SuaKH]    Script Date: 9/15/2021 2:56:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaKH] (@ID NVARCHAR(10)
					,@HoTen NVARCHAR(100)
					,@GioiTinh NVARCHAR(5)
					,@NgaySinh DATETIME
					,@Sdt NVARCHAR(10)
					,@CMND NVARCHAR(12)
					,@QueQuan NVARCHAR(150))
AS
	UPDATE KhachHang
	SET HoTen = @HoTen, 
		GioiTinh = @GioiTinh, 
		NgaySinh = @NgaySinh, 
		Sdt = @Sdt, 
		CMND = @CMND, 
		QueQuan = @QueQuan
	WHERE ID = @ID

GO
/****** Object:  StoredProcedure [dbo].[SuaLP]    Script Date: 9/15/2021 2:56:54 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SuaPhi]    Script Date: 9/15/2021 2:56:54 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SuaPhong]    Script Date: 9/15/2021 2:56:54 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SuaSoNguoiHienTai]    Script Date: 9/15/2021 2:56:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaSoNguoiHienTai] (@id int, @HienTai int)
AS
	UPDATE Phong
	SET SoNguoiHienTai = @HienTai
	WHERE ID = @id

GO
/****** Object:  StoredProcedure [dbo].[ThemKH]    Script Date: 9/15/2021 2:56:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemKH] (@ID NVARCHAR(10)
					,@HoTen NVARCHAR(100)
					,@GioiTinh NVARCHAR(5)
					,@NgaySinh DATETIME
					,@Sdt NVARCHAR(10)
					,@CMND NVARCHAR(12)
					,@QueQuan NVARCHAR(150)
					 ,@MaPhong INT)
AS
	INSERT INTO KhachHang(ID, HoTen, GioiTinh, NgaySinh, Sdt ,CMND ,QueQuan, MaPhong) 
	VALUES (@ID, @HoTen, @GioiTinh, @NgaySinh, @Sdt , @CMND, @QueQuan, @MaPhong)


GO
/****** Object:  StoredProcedure [dbo].[ThemLP]    Script Date: 9/15/2021 2:56:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemLP] (@Ten NVARCHAR(10), @Gia DECIMAL(18, 0))
AS
	INSERT INTO LoaiPhong(TenLP, GiaTien) VALUES (@Ten, @Gia)


GO
/****** Object:  StoredProcedure [dbo].[ThemPhi]    Script Date: 9/15/2021 2:56:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemPhi] (@Ten NVARCHAR(10), @GiaTien DECIMAL(18,0))
AS
	INSERT INTO Phi (TenPhi, GiaTien) VALUES (@Ten, @GiaTien)

GO
/****** Object:  StoredProcedure [dbo].[ThemPhong]    Script Date: 9/15/2021 2:56:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemPhong] (@Ten NVARCHAR(10), @Loai int, @ToiDa int, @HienTai int)
AS
	INSERT INTO Phong(TenPhong, IDLoaiPhong, SoNguoiToiDa, SoNguoiHienTai) 
	VALUES (@Ten, @Loai, @ToiDa, @HienTai)


GO
/****** Object:  StoredProcedure [dbo].[TimKH]    Script Date: 9/15/2021 2:56:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TimKH] (@ten NVARCHAR(100))
AS
	BEGIN
		IF (@ten is null)
			BEGIN
				SELECT k.ID, HoTen, GioiTinh, NgaySinh, Sdt, CMND, QueQuan, TenPhong
				FROM KhachHang k, Phong p
				WHERE k.MaPhong = p.ID
			END
		ELSE
			BEGIN
				SELECT k.ID, HoTen, GioiTinh, NgaySinh, Sdt, CMND, QueQuan, TenPhong
				FROM KhachHang k, Phong p
				WHERE k.MaPhong = p.ID
					AND HoTen LIKE '%' + @Ten + '%'
			END
	END

GO
/****** Object:  StoredProcedure [dbo].[XemCacLoaiPhi]    Script Date: 9/15/2021 2:56:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XemCacLoaiPhi]
AS
	SELECT * FROM Phi

GO
/****** Object:  StoredProcedure [dbo].[XemDSPhong]    Script Date: 9/15/2021 2:56:54 PM ******/
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
/****** Object:  StoredProcedure [dbo].[XemKH]    Script Date: 9/15/2021 2:56:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XemKH]
AS
	SELECT k.ID, HoTen, GioiTinh, NgaySinh, Sdt, CMND, QueQuan, TenPhong
	FROM KhachHang k, Phong p
	WHERE k.MaPhong = p.ID

GO
/****** Object:  StoredProcedure [dbo].[XoaLP]    Script Date: 9/15/2021 2:56:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaLP] (@id INT)
AS
	DELETE FROM LoaiPhong WHERE ID = @id


GO
/****** Object:  StoredProcedure [dbo].[XoaPhi]    Script Date: 9/15/2021 2:56:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaPhi] (@id INT)
AS
	DELETE FROM Phi WHERE ID = @id

GO
/****** Object:  StoredProcedure [dbo].[XoaPhong]    Script Date: 9/15/2021 2:56:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaPhong] (@id INT)
AS
	DELETE FROM Phong WHERE ID = @id


GO
