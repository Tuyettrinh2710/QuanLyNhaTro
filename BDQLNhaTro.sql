USE [QLNhaTro]
GO
/****** Object:  StoredProcedure [dbo].[XoaPhong]    Script Date: 11/5/2021 14:27:15 ******/
DROP PROCEDURE [dbo].[XoaPhong]
GO
/****** Object:  StoredProcedure [dbo].[XemDSPhong]    Script Date: 11/5/2021 14:27:15 ******/
DROP PROCEDURE [dbo].[XemDSPhong]
GO
/****** Object:  StoredProcedure [dbo].[XemCacLoaiPhi]    Script Date: 11/5/2021 14:27:15 ******/
DROP PROCEDURE [dbo].[XemCacLoaiPhi]
GO
/****** Object:  StoredProcedure [dbo].[TimKhachThue]    Script Date: 11/5/2021 14:27:15 ******/
DROP PROCEDURE [dbo].[TimKhachThue]
GO
/****** Object:  StoredProcedure [dbo].[ThemTraPhong]    Script Date: 11/5/2021 14:27:15 ******/
DROP PROCEDURE [dbo].[ThemTraPhong]
GO
/****** Object:  StoredProcedure [dbo].[ThemThuePhong]    Script Date: 11/5/2021 14:27:15 ******/
DROP PROCEDURE [dbo].[ThemThuePhong]
GO
/****** Object:  StoredProcedure [dbo].[ThemPhong]    Script Date: 11/5/2021 14:27:15 ******/
DROP PROCEDURE [dbo].[ThemPhong]
GO
/****** Object:  StoredProcedure [dbo].[ThemKH]    Script Date: 11/5/2021 14:27:15 ******/
DROP PROCEDURE [dbo].[ThemKH]
GO
/****** Object:  StoredProcedure [dbo].[ThemHoaDon]    Script Date: 11/5/2021 14:27:15 ******/
DROP PROCEDURE [dbo].[ThemHoaDon]
GO
/****** Object:  StoredProcedure [dbo].[SuaSoNguoiHienTai]    Script Date: 11/5/2021 14:27:15 ******/
DROP PROCEDURE [dbo].[SuaSoNguoiHienTai]
GO
/****** Object:  StoredProcedure [dbo].[SuaPhong]    Script Date: 11/5/2021 14:27:15 ******/
DROP PROCEDURE [dbo].[SuaPhong]
GO
/****** Object:  StoredProcedure [dbo].[SuaPhi]    Script Date: 11/5/2021 14:27:15 ******/
DROP PROCEDURE [dbo].[SuaPhi]
GO
/****** Object:  StoredProcedure [dbo].[SuaLP]    Script Date: 11/5/2021 14:27:15 ******/
DROP PROCEDURE [dbo].[SuaLP]
GO
/****** Object:  StoredProcedure [dbo].[SuaKH]    Script Date: 11/5/2021 14:27:15 ******/
DROP PROCEDURE [dbo].[SuaKH]
GO
/****** Object:  StoredProcedure [dbo].[LaySoNguoiHTVaTD]    Script Date: 11/5/2021 14:27:15 ******/
DROP PROCEDURE [dbo].[LaySoNguoiHTVaTD]
GO
/****** Object:  StoredProcedure [dbo].[LayPhongTrongTheoLoai]    Script Date: 11/5/2021 14:27:15 ******/
DROP PROCEDURE [dbo].[LayPhongTrongTheoLoai]
GO
/****** Object:  StoredProcedure [dbo].[LayPhongTheoTen]    Script Date: 11/5/2021 14:27:15 ******/
DROP PROCEDURE [dbo].[LayPhongTheoTen]
GO
/****** Object:  StoredProcedure [dbo].[LayMa]    Script Date: 11/5/2021 14:27:15 ******/
DROP PROCEDURE [dbo].[LayMa]
GO
/****** Object:  StoredProcedure [dbo].[LayHoaDonChuaThuTien]    Script Date: 11/5/2021 14:27:15 ******/
DROP PROCEDURE [dbo].[LayHoaDonChuaThuTien]
GO
/****** Object:  StoredProcedure [dbo].[LayDSTraPhong]    Script Date: 11/5/2021 14:27:15 ******/
DROP PROCEDURE [dbo].[LayDSTraPhong]
GO
/****** Object:  StoredProcedure [dbo].[LayDSThuePhong]    Script Date: 11/5/2021 14:27:15 ******/
DROP PROCEDURE [dbo].[LayDSThuePhong]
GO
/****** Object:  StoredProcedure [dbo].[LayDSPhongTrong]    Script Date: 11/5/2021 14:27:15 ******/
DROP PROCEDURE [dbo].[LayDSPhongTrong]
GO
/****** Object:  StoredProcedure [dbo].[LayDSPhongDaChoThue]    Script Date: 11/5/2021 14:27:15 ******/
DROP PROCEDURE [dbo].[LayDSPhongDaChoThue]
GO
/****** Object:  StoredProcedure [dbo].[LayDSPhongChuaLapHoaDon]    Script Date: 11/5/2021 14:27:15 ******/
DROP PROCEDURE [dbo].[LayDSPhongChuaLapHoaDon]
GO
/****** Object:  StoredProcedure [dbo].[LayDSLoaiPhong]    Script Date: 11/5/2021 14:27:15 ******/
DROP PROCEDURE [dbo].[LayDSLoaiPhong]
GO
/****** Object:  StoredProcedure [dbo].[LayDSKhachTheoIDPhong]    Script Date: 11/5/2021 14:27:15 ******/
DROP PROCEDURE [dbo].[LayDSKhachTheoIDPhong]
GO
/****** Object:  StoredProcedure [dbo].[LayDSKhachKhongConThue]    Script Date: 11/5/2021 14:27:15 ******/
DROP PROCEDURE [dbo].[LayDSKhachKhongConThue]
GO
/****** Object:  StoredProcedure [dbo].[LayDSHoaDon]    Script Date: 11/5/2021 14:27:15 ******/
DROP PROCEDURE [dbo].[LayDSHoaDon]
GO
/****** Object:  StoredProcedure [dbo].[KTPhongTonTai]    Script Date: 11/5/2021 14:27:15 ******/
DROP PROCEDURE [dbo].[KTPhongTonTai]
GO
/****** Object:  StoredProcedure [dbo].[KTIDThue]    Script Date: 11/5/2021 14:27:15 ******/
DROP PROCEDURE [dbo].[KTIDThue]
GO
/****** Object:  StoredProcedure [dbo].[KTIDPhongTrongThue]    Script Date: 11/5/2021 14:27:15 ******/
DROP PROCEDURE [dbo].[KTIDPhongTrongThue]
GO
/****** Object:  StoredProcedure [dbo].[KTIdKhachHangToiTai]    Script Date: 11/5/2021 14:27:15 ******/
DROP PROCEDURE [dbo].[KTIdKhachHangToiTai]
GO
/****** Object:  StoredProcedure [dbo].[KiemTraIDThue]    Script Date: 11/5/2021 14:27:15 ******/
DROP PROCEDURE [dbo].[KiemTraIDThue]
GO
/****** Object:  StoredProcedure [dbo].[CapNhatThuTien]    Script Date: 11/5/2021 14:27:15 ******/
DROP PROCEDURE [dbo].[CapNhatThuTien]
GO
/****** Object:  StoredProcedure [dbo].[CapNhatThamSo]    Script Date: 11/5/2021 14:27:15 ******/
DROP PROCEDURE [dbo].[CapNhatThamSo]
GO
/****** Object:  StoredProcedure [dbo].[CapNhatMaPhongNUll]    Script Date: 11/5/2021 14:27:15 ******/
DROP PROCEDURE [dbo].[CapNhatMaPhongNUll]
GO
/****** Object:  StoredProcedure [dbo].[CapNhatMaPhongKH]    Script Date: 11/5/2021 14:27:15 ******/
DROP PROCEDURE [dbo].[CapNhatMaPhongKH]
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
/****** Object:  Table [dbo].[TraPhong]    Script Date: 11/5/2021 14:27:15 ******/
DROP TABLE [dbo].[TraPhong]
GO
/****** Object:  Table [dbo].[ThuePhong]    Script Date: 11/5/2021 14:27:15 ******/
DROP TABLE [dbo].[ThuePhong]
GO
/****** Object:  Table [dbo].[ThamSo]    Script Date: 11/5/2021 14:27:15 ******/
DROP TABLE [dbo].[ThamSo]
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 11/5/2021 14:27:15 ******/
DROP TABLE [dbo].[Phong]
GO
/****** Object:  Table [dbo].[Phi]    Script Date: 11/5/2021 14:27:15 ******/
DROP TABLE [dbo].[Phi]
GO
/****** Object:  Table [dbo].[LoaiPhong]    Script Date: 11/5/2021 14:27:15 ******/
DROP TABLE [dbo].[LoaiPhong]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 11/5/2021 14:27:15 ******/
DROP TABLE [dbo].[KhachHang]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 11/5/2021 14:27:15 ******/
DROP TABLE [dbo].[HoaDon]
GO
/****** Object:  UserDefinedFunction [dbo].[fChuyenCoDauThanhKhongDau]    Script Date: 11/5/2021 14:27:15 ******/
DROP FUNCTION [dbo].[fChuyenCoDauThanhKhongDau]
GO
/****** Object:  UserDefinedFunction [dbo].[fChuyenCoDauThanhKhongDau]    Script Date: 11/5/2021 14:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fChuyenCoDauThanhKhongDau](@inputVar NVARCHAR(MAX) )
RETURNS NVARCHAR(MAX)
AS
BEGIN    
    IF (@inputVar IS NULL OR @inputVar = '')  RETURN ''
   
    DECLARE @RT NVARCHAR(MAX)
    DECLARE @SIGN_CHARS NCHAR(256)
    DECLARE @UNSIGN_CHARS NCHAR (256)
 
    SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệếìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵýĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' + NCHAR(272) + NCHAR(208)
    SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeeeiiiiiooooooooooooooouuuuuuuuuuyyyyyAADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIIIOOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'
 
    DECLARE @COUNTER int
    DECLARE @COUNTER1 int
   
    SET @COUNTER = 1
    WHILE (@COUNTER <= LEN(@inputVar))
    BEGIN  
        SET @COUNTER1 = 1
        WHILE (@COUNTER1 <= LEN(@SIGN_CHARS) + 1)
        BEGIN
            IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@inputVar,@COUNTER ,1))
            BEGIN          
                IF @COUNTER = 1
                    SET @inputVar = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@inputVar, @COUNTER+1,LEN(@inputVar)-1)      
                ELSE
                    SET @inputVar = SUBSTRING(@inputVar, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@inputVar, @COUNTER+1,LEN(@inputVar)- @COUNTER)
                BREAK
            END
            SET @COUNTER1 = @COUNTER1 +1
        END
        SET @COUNTER = @COUNTER +1
    END
    -- SET @inputVar = replace(@inputVar,' ','-')
    RETURN @inputVar
END
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 11/5/2021 14:27:15 ******/
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
/****** Object:  Table [dbo].[KhachHang]    Script Date: 11/5/2021 14:27:15 ******/
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
/****** Object:  Table [dbo].[LoaiPhong]    Script Date: 11/5/2021 14:27:15 ******/
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
/****** Object:  Table [dbo].[Phi]    Script Date: 11/5/2021 14:27:15 ******/
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
/****** Object:  Table [dbo].[Phong]    Script Date: 11/5/2021 14:27:15 ******/
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
/****** Object:  Table [dbo].[ThamSo]    Script Date: 11/5/2021 14:27:15 ******/
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
/****** Object:  Table [dbo].[ThuePhong]    Script Date: 11/5/2021 14:27:15 ******/
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
/****** Object:  Table [dbo].[TraPhong]    Script Date: 11/5/2021 14:27:15 ******/
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
SET IDENTITY_INSERT [dbo].[HoaDon] ON 

INSERT [dbo].[HoaDon] ([ID], [ID_KH], [ID_Phong], [NgayLap], [NgayThu], [GiaPhong], [SkDien], [TienDien], [SkNuoc], [TienNuoc], [TienDV], [TongTien], [TrangThai]) VALUES (7, N'0987647862', 2, CAST(N'2021-10-13 15:18:52.533' AS DateTime), CAST(N'2021-10-13 15:19:44.910' AS DateTime), CAST(2000000 AS Decimal(18, 0)), 24, CAST(144000 AS Decimal(18, 0)), 26, CAST(169000 AS Decimal(18, 0)), CAST(20000 AS Decimal(18, 0)), CAST(2333000 AS Decimal(18, 0)), N'Đã thu')
INSERT [dbo].[HoaDon] ([ID], [ID_KH], [ID_Phong], [NgayLap], [NgayThu], [GiaPhong], [SkDien], [TienDien], [SkNuoc], [TienNuoc], [TienDV], [TongTien], [TrangThai]) VALUES (8, N'0987668762', 32, CAST(N'2021-10-13 15:18:52.533' AS DateTime), CAST(N'2021-10-19 10:45:54.640' AS DateTime), CAST(1500000 AS Decimal(18, 0)), 26, CAST(156000 AS Decimal(18, 0)), 32, CAST(208000 AS Decimal(18, 0)), CAST(20000 AS Decimal(18, 0)), CAST(1884000 AS Decimal(18, 0)), N'Đã thu')
INSERT [dbo].[HoaDon] ([ID], [ID_KH], [ID_Phong], [NgayLap], [NgayThu], [GiaPhong], [SkDien], [TienDien], [SkNuoc], [TienNuoc], [TienDV], [TongTien], [TrangThai]) VALUES (9, N'0789273744', 1, CAST(N'2021-10-19 10:56:08.347' AS DateTime), CAST(N'2021-10-19 10:56:27.240' AS DateTime), CAST(1500000 AS Decimal(18, 0)), 24, CAST(144000 AS Decimal(18, 0)), 35, CAST(227500 AS Decimal(18, 0)), CAST(20000 AS Decimal(18, 0)), CAST(1891500 AS Decimal(18, 0)), N'Đã thu')
INSERT [dbo].[HoaDon] ([ID], [ID_KH], [ID_Phong], [NgayLap], [NgayThu], [GiaPhong], [SkDien], [TienDien], [SkNuoc], [TienNuoc], [TienDV], [TongTien], [TrangThai]) VALUES (10, N'0987654321', 34, CAST(N'2021-10-29 13:59:32.617' AS DateTime), CAST(N'2021-10-29 17:51:04.277' AS DateTime), CAST(1500000 AS Decimal(18, 0)), 25, CAST(125000 AS Decimal(18, 0)), 23, CAST(149500 AS Decimal(18, 0)), CAST(20000 AS Decimal(18, 0)), CAST(1794500 AS Decimal(18, 0)), N'Đã thu')
INSERT [dbo].[HoaDon] ([ID], [ID_KH], [ID_Phong], [NgayLap], [NgayThu], [GiaPhong], [SkDien], [TienDien], [SkNuoc], [TienNuoc], [TienDV], [TongTien], [TrangThai]) VALUES (11, N'0998548922', 33, CAST(N'2021-10-31 16:59:41.787' AS DateTime), CAST(N'2021-10-31 17:01:53.400' AS DateTime), CAST(1500000 AS Decimal(18, 0)), 34, CAST(170000 AS Decimal(18, 0)), 43, CAST(279500 AS Decimal(18, 0)), CAST(20000 AS Decimal(18, 0)), CAST(1969500 AS Decimal(18, 0)), N'Đã thu')
INSERT [dbo].[HoaDon] ([ID], [ID_KH], [ID_Phong], [NgayLap], [NgayThu], [GiaPhong], [SkDien], [TienDien], [SkNuoc], [TienNuoc], [TienDV], [TongTien], [TrangThai]) VALUES (12, N'0789273744', 1, CAST(N'2021-11-03 10:30:18.363' AS DateTime), CAST(N'2021-11-03 10:30:50.117' AS DateTime), CAST(1500000 AS Decimal(18, 0)), 26, CAST(130000 AS Decimal(18, 0)), 27, CAST(175500 AS Decimal(18, 0)), CAST(20000 AS Decimal(18, 0)), CAST(1825500 AS Decimal(18, 0)), N'Đã thu')
INSERT [dbo].[HoaDon] ([ID], [ID_KH], [ID_Phong], [NgayLap], [NgayThu], [GiaPhong], [SkDien], [TienDien], [SkNuoc], [TienNuoc], [TienDV], [TongTien], [TrangThai]) VALUES (13, N'0789278333', 3, CAST(N'2021-11-03 10:57:58.787' AS DateTime), NULL, CAST(2500000 AS Decimal(18, 0)), 25, CAST(125000 AS Decimal(18, 0)), 36, CAST(234000 AS Decimal(18, 0)), CAST(20000 AS Decimal(18, 0)), CAST(2879000 AS Decimal(18, 0)), N'Chưa thu')
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
INSERT [dbo].[KhachHang] ([ID], [HoTen], [GioiTinh], [NgaySinh], [Sdt], [CMND], [QueQuan], [MaPhong]) VALUES (N'0778989732', N'Phan Thanh Thanh', N'Nữ', CAST(N'2000-05-23 00:00:00.000' AS DateTime), N'0778989732', N'098387223444', N'Quảng Ngãi', NULL)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [GioiTinh], [NgaySinh], [Sdt], [CMND], [QueQuan], [MaPhong]) VALUES (N'0788937433', N'Nguyễn Ánh Tiên', N'Nữ', CAST(N'1999-02-24 00:00:00.000' AS DateTime), N'0788937433', N'097887472000', N'Bình Thuận', NULL)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [GioiTinh], [NgaySinh], [Sdt], [CMND], [QueQuan], [MaPhong]) VALUES (N'0789273681', N'Nguyễn Ánh Hồng', N'Nữ', CAST(N'1999-11-01 00:00:00.000' AS DateTime), N'0789273681', N'098230000849', N'Vĩnh Long', 5)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [GioiTinh], [NgaySinh], [Sdt], [CMND], [QueQuan], [MaPhong]) VALUES (N'0789273744', N'Nguyễn Nhật Thanh', N'Nam', CAST(N'2000-10-28 00:00:00.000' AS DateTime), N'0789273744', N'098747833443', N'Bình Dương', 1)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [GioiTinh], [NgaySinh], [Sdt], [CMND], [QueQuan], [MaPhong]) VALUES (N'0789278333', N'Lê Ngọc Quyên', N'Nữ', CAST(N'1998-10-13 00:00:00.000' AS DateTime), N'0789278333', N'098774273445', N'Kiên Giang', 3)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [GioiTinh], [NgaySinh], [Sdt], [CMND], [QueQuan], [MaPhong]) VALUES (N'0789387474', N'Trần Anh Quân', N'Nam', CAST(N'1999-11-01 00:00:00.000' AS DateTime), N'0789387474', N'098220000488', N'An Giang', 25)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [GioiTinh], [NgaySinh], [Sdt], [CMND], [QueQuan], [MaPhong]) VALUES (N'0789837847', N'Nguyễn Thanh Phước', N'Nam', CAST(N'2000-04-28 00:00:00.000' AS DateTime), N'0789837847', N'080894983988', N'Tây Ninh', 25)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [GioiTinh], [NgaySinh], [Sdt], [CMND], [QueQuan], [MaPhong]) VALUES (N'0878387321', N'Lê Thanh Minh', N'Nam', CAST(N'2000-04-14 00:00:00.000' AS DateTime), N'0878387321', N'098746683661', N'An Giang', 1)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [GioiTinh], [NgaySinh], [Sdt], [CMND], [QueQuan], [MaPhong]) VALUES (N'0984782874', N'Trần Ngọc Thư', N'Nữ', CAST(N'2000-05-01 00:00:00.000' AS DateTime), N'0984782874', N'098847902023', N'Hậu Giang', 5)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [GioiTinh], [NgaySinh], [Sdt], [CMND], [QueQuan], [MaPhong]) VALUES (N'0984932345', N'Nguyễn Thanh Nhàn', N'Nữ', CAST(N'2000-06-25 00:00:00.000' AS DateTime), N'0984932345', N'098748392033', N'Cần Thơ', 3)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [GioiTinh], [NgaySinh], [Sdt], [CMND], [QueQuan], [MaPhong]) VALUES (N'0987647855', N'Nguyễn Thị Thúy Hằng', N'Nữ', CAST(N'2000-11-03 00:00:00.000' AS DateTime), N'0987647855', N'092397700034', N'Cà Mau', 3)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [GioiTinh], [NgaySinh], [Sdt], [CMND], [QueQuan], [MaPhong]) VALUES (N'0987647862', N'Lê Minh Nhựt', N'Nam', CAST(N'2003-05-23 00:00:00.000' AS DateTime), N'0987647862', N'098263780004', N'Bình Thuận', NULL)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [GioiTinh], [NgaySinh], [Sdt], [CMND], [QueQuan], [MaPhong]) VALUES (N'0987654321', N'Phan Thị Tuyết Trinh', N'Nữ', CAST(N'2000-10-27 00:00:00.000' AS DateTime), N'0987654321', N'098987245800', N'Cần Thơ', 34)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [GioiTinh], [NgaySinh], [Sdt], [CMND], [QueQuan], [MaPhong]) VALUES (N'0987668762', N'Nguyễn Hữu Lợi', N'Nam', CAST(N'1999-03-13 00:00:00.000' AS DateTime), N'0987668762', N'098763234432', N'Đồng Tháp', NULL)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [GioiTinh], [NgaySinh], [Sdt], [CMND], [QueQuan], [MaPhong]) VALUES (N'0988493234', N'Trần Bảo Ngọc', N'Nữ', CAST(N'1999-09-03 00:00:00.000' AS DateTime), N'0988493234', N'098739920999', N'Long An', 3)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [GioiTinh], [NgaySinh], [Sdt], [CMND], [QueQuan], [MaPhong]) VALUES (N'0998548922', N'Trần Mỹ Ngọc', N'Nữ', CAST(N'1999-10-13 00:00:00.000' AS DateTime), N'0998548922', N'098734893798', N'An Giang', 33)
SET IDENTITY_INSERT [dbo].[LoaiPhong] ON 

INSERT [dbo].[LoaiPhong] ([ID], [TenLP], [GiaTien]) VALUES (1, N'Nhỏ', CAST(1500000 AS Decimal(18, 0)))
INSERT [dbo].[LoaiPhong] ([ID], [TenLP], [GiaTien]) VALUES (2, N'Vừa', CAST(2000000 AS Decimal(18, 0)))
INSERT [dbo].[LoaiPhong] ([ID], [TenLP], [GiaTien]) VALUES (3, N'Lớn', CAST(2500000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[LoaiPhong] OFF
SET IDENTITY_INSERT [dbo].[Phi] ON 

INSERT [dbo].[Phi] ([ID], [TenPhi], [GiaTien]) VALUES (2, N'Nước', CAST(6500 AS Decimal(18, 0)))
INSERT [dbo].[Phi] ([ID], [TenPhi], [GiaTien]) VALUES (3, N'Dịch vụ', CAST(20000 AS Decimal(18, 0)))
INSERT [dbo].[Phi] ([ID], [TenPhi], [GiaTien]) VALUES (16, N'Điện', CAST(5000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[Phi] OFF
SET IDENTITY_INSERT [dbo].[Phong] ON 

INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SoNguoiToiDa], [SoNguoiHienTai]) VALUES (1, N'001', 1, 2, 2)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SoNguoiToiDa], [SoNguoiHienTai]) VALUES (2, N'002', 2, 3, 0)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SoNguoiToiDa], [SoNguoiHienTai]) VALUES (3, N'003', 3, 4, 4)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SoNguoiToiDa], [SoNguoiHienTai]) VALUES (4, N'004', 2, 3, 0)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SoNguoiToiDa], [SoNguoiHienTai]) VALUES (5, N'005', 1, 2, 2)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SoNguoiToiDa], [SoNguoiHienTai]) VALUES (6, N'006', 3, 4, 0)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SoNguoiToiDa], [SoNguoiHienTai]) VALUES (20, N'007', 1, 2, 0)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SoNguoiToiDa], [SoNguoiHienTai]) VALUES (21, N'008', 1, 2, 0)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SoNguoiToiDa], [SoNguoiHienTai]) VALUES (22, N'009', 2, 3, 0)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SoNguoiToiDa], [SoNguoiHienTai]) VALUES (23, N'010', 2, 3, 0)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SoNguoiToiDa], [SoNguoiHienTai]) VALUES (24, N'011', 3, 4, 0)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SoNguoiToiDa], [SoNguoiHienTai]) VALUES (25, N'012', 2, 3, 2)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SoNguoiToiDa], [SoNguoiHienTai]) VALUES (28, N'013', 3, 4, 0)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SoNguoiToiDa], [SoNguoiHienTai]) VALUES (29, N'014', 1, 2, 0)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SoNguoiToiDa], [SoNguoiHienTai]) VALUES (31, N'015', 1, 2, 0)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SoNguoiToiDa], [SoNguoiHienTai]) VALUES (32, N'016', 1, 2, 0)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SoNguoiToiDa], [SoNguoiHienTai]) VALUES (33, N'017', 1, 2, 1)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SoNguoiToiDa], [SoNguoiHienTai]) VALUES (34, N'018', 1, 2, 1)
SET IDENTITY_INSERT [dbo].[Phong] OFF
INSERT [dbo].[ThamSo] ([ID], [GiaTri], [GhiChu]) VALUES (N'TP', N'00000010', N'Mã thuê phòng')
INSERT [dbo].[ThuePhong] ([ID], [ID_KH], [ID_Phong], [NgayThue], [TienCoc]) VALUES (N'TP00000001', N'0987654321', 34, CAST(N'2021-10-12 09:30:22.167' AS DateTime), CAST(1500000 AS Decimal(18, 0)))
INSERT [dbo].[ThuePhong] ([ID], [ID_KH], [ID_Phong], [NgayThue], [TienCoc]) VALUES (N'TP00000002', N'0789278333', 33, CAST(N'2021-10-13 15:06:37.920' AS DateTime), CAST(1500000 AS Decimal(18, 0)))
INSERT [dbo].[ThuePhong] ([ID], [ID_KH], [ID_Phong], [NgayThue], [TienCoc]) VALUES (N'TP00000002', N'0998548922', 33, CAST(N'2021-10-13 15:06:37.920' AS DateTime), CAST(1500000 AS Decimal(18, 0)))
INSERT [dbo].[ThuePhong] ([ID], [ID_KH], [ID_Phong], [NgayThue], [TienCoc]) VALUES (N'TP00000003', N'0789837847', 32, CAST(N'2021-10-13 15:06:37.920' AS DateTime), CAST(1500000 AS Decimal(18, 0)))
INSERT [dbo].[ThuePhong] ([ID], [ID_KH], [ID_Phong], [NgayThue], [TienCoc]) VALUES (N'TP00000003', N'0987668762', 32, CAST(N'2021-10-13 15:06:37.920' AS DateTime), CAST(1500000 AS Decimal(18, 0)))
INSERT [dbo].[ThuePhong] ([ID], [ID_KH], [ID_Phong], [NgayThue], [TienCoc]) VALUES (N'TP00000004', N'0987647862', 2, CAST(N'2021-10-13 15:06:37.920' AS DateTime), CAST(2000000 AS Decimal(18, 0)))
INSERT [dbo].[ThuePhong] ([ID], [ID_KH], [ID_Phong], [NgayThue], [TienCoc]) VALUES (N'TP00000005', N'0789273744', 1, CAST(N'2021-10-14 11:50:53.240' AS DateTime), CAST(1500000 AS Decimal(18, 0)))
INSERT [dbo].[ThuePhong] ([ID], [ID_KH], [ID_Phong], [NgayThue], [TienCoc]) VALUES (N'TP00000005', N'0878387321', 1, CAST(N'2021-10-14 11:50:53.240' AS DateTime), CAST(1500000 AS Decimal(18, 0)))
INSERT [dbo].[ThuePhong] ([ID], [ID_KH], [ID_Phong], [NgayThue], [TienCoc]) VALUES (N'TP00000006', N'0778989732', 31, CAST(N'2021-11-01 10:11:39.167' AS DateTime), CAST(1500000 AS Decimal(18, 0)))
INSERT [dbo].[ThuePhong] ([ID], [ID_KH], [ID_Phong], [NgayThue], [TienCoc]) VALUES (N'TP00000006', N'0788937433', 31, CAST(N'2021-11-01 10:11:39.167' AS DateTime), CAST(1500000 AS Decimal(18, 0)))
INSERT [dbo].[ThuePhong] ([ID], [ID_KH], [ID_Phong], [NgayThue], [TienCoc]) VALUES (N'TP00000007', N'0789387474', 25, CAST(N'2021-11-01 10:18:13.103' AS DateTime), CAST(2000000 AS Decimal(18, 0)))
INSERT [dbo].[ThuePhong] ([ID], [ID_KH], [ID_Phong], [NgayThue], [TienCoc]) VALUES (N'TP00000007', N'0789837847', 25, CAST(N'2021-11-01 10:18:13.103' AS DateTime), CAST(2000000 AS Decimal(18, 0)))
INSERT [dbo].[ThuePhong] ([ID], [ID_KH], [ID_Phong], [NgayThue], [TienCoc]) VALUES (N'TP00000008', N'0789273681', 5, CAST(N'2021-11-01 10:24:48.117' AS DateTime), CAST(1500000 AS Decimal(18, 0)))
INSERT [dbo].[ThuePhong] ([ID], [ID_KH], [ID_Phong], [NgayThue], [TienCoc]) VALUES (N'TP00000008', N'0984782874', 5, CAST(N'2021-11-01 10:24:48.117' AS DateTime), CAST(1500000 AS Decimal(18, 0)))
INSERT [dbo].[ThuePhong] ([ID], [ID_KH], [ID_Phong], [NgayThue], [TienCoc]) VALUES (N'TP00000009', N'0998548922', 33, CAST(N'2021-11-01 10:24:48.117' AS DateTime), CAST(1500000 AS Decimal(18, 0)))
INSERT [dbo].[ThuePhong] ([ID], [ID_KH], [ID_Phong], [NgayThue], [TienCoc]) VALUES (N'TP00000010', N'0789278333', 3, CAST(N'2021-11-03 09:55:23.427' AS DateTime), CAST(2500000 AS Decimal(18, 0)))
INSERT [dbo].[ThuePhong] ([ID], [ID_KH], [ID_Phong], [NgayThue], [TienCoc]) VALUES (N'TP00000010', N'0984932345', 3, CAST(N'2021-11-03 09:55:23.427' AS DateTime), CAST(2500000 AS Decimal(18, 0)))
INSERT [dbo].[ThuePhong] ([ID], [ID_KH], [ID_Phong], [NgayThue], [TienCoc]) VALUES (N'TP00000010', N'0987647855', 3, CAST(N'2021-11-03 09:55:23.427' AS DateTime), CAST(2500000 AS Decimal(18, 0)))
INSERT [dbo].[ThuePhong] ([ID], [ID_KH], [ID_Phong], [NgayThue], [TienCoc]) VALUES (N'TP00000010', N'0988493234', 3, CAST(N'2021-11-03 09:55:23.427' AS DateTime), CAST(2500000 AS Decimal(18, 0)))
INSERT [dbo].[TraPhong] ([ID_Thue], [ID_KH], [ID_Phong], [NgayThue], [NgayTra]) VALUES (N'TP00000002', N'0789278333', 33, CAST(N'2021-10-13 00:00:00.000' AS DateTime), CAST(N'2021-10-13 00:00:00.000' AS DateTime))
INSERT [dbo].[TraPhong] ([ID_Thue], [ID_KH], [ID_Phong], [NgayThue], [NgayTra]) VALUES (N'TP00000002', N'0998548922', 33, CAST(N'2021-10-13 00:00:00.000' AS DateTime), CAST(N'2021-11-01 00:00:00.000' AS DateTime))
INSERT [dbo].[TraPhong] ([ID_Thue], [ID_KH], [ID_Phong], [NgayThue], [NgayTra]) VALUES (N'TP00000003', N'0789837847', 32, CAST(N'2021-10-13 00:00:00.000' AS DateTime), CAST(N'2021-10-13 00:00:00.000' AS DateTime))
INSERT [dbo].[TraPhong] ([ID_Thue], [ID_KH], [ID_Phong], [NgayThue], [NgayTra]) VALUES (N'TP00000003', N'0987668762', 32, CAST(N'2021-10-13 00:00:00.000' AS DateTime), CAST(N'2021-11-03 00:00:00.000' AS DateTime))
INSERT [dbo].[TraPhong] ([ID_Thue], [ID_KH], [ID_Phong], [NgayThue], [NgayTra]) VALUES (N'TP00000004', N'0987647862', 2, CAST(N'2021-10-13 00:00:00.000' AS DateTime), CAST(N'2021-11-03 00:00:00.000' AS DateTime))
INSERT [dbo].[TraPhong] ([ID_Thue], [ID_KH], [ID_Phong], [NgayThue], [NgayTra]) VALUES (N'TP00000006', N'0778989732', 31, CAST(N'2021-11-01 00:00:00.000' AS DateTime), CAST(N'2021-11-03 00:00:00.000' AS DateTime))
INSERT [dbo].[TraPhong] ([ID_Thue], [ID_KH], [ID_Phong], [NgayThue], [NgayTra]) VALUES (N'TP00000006', N'0788937433', 31, CAST(N'2021-11-01 00:00:00.000' AS DateTime), CAST(N'2021-11-03 00:00:00.000' AS DateTime))
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
/****** Object:  StoredProcedure [dbo].[CapNhatMaPhongKH]    Script Date: 11/5/2021 14:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CapNhatMaPhongKH](@idKH NVARCHAR(10), @maPhong int)
AS
	UPDATE KhachHang
	SET MaPhong = @maPhong
	WHERE ID = @idKH

GO
/****** Object:  StoredProcedure [dbo].[CapNhatMaPhongNUll]    Script Date: 11/5/2021 14:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CapNhatMaPhongNUll](@idKH NVARCHAR(10))
AS
	UPDATE KhachHang 
	SET MaPhong = NULL
	WHERE ID = @idKH

GO
/****** Object:  StoredProcedure [dbo].[CapNhatThamSo]    Script Date: 11/5/2021 14:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CapNhatThamSo] (@id NVARCHAR(2), @giaTri NVARCHAR(8))
AS
	UPDATE ThamSo
	SET GiaTri = @giaTri
	WHERE ID = @id

GO
/****** Object:  StoredProcedure [dbo].[CapNhatThuTien]    Script Date: 11/5/2021 14:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CapNhatThuTien](@id int)
AS
	UPDATE HoaDon
	SET NgayThu = GETDATE(), TrangThai = N'Đã thu'
	WHERE ID = @id

GO
/****** Object:  StoredProcedure [dbo].[KiemTraIDThue]    Script Date: 11/5/2021 14:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[KiemTraIDThue](@id NVARCHAR(10), @KQ BIT OUTPUT)
AS
	IF EXISTS (SELECT * FROM ThuePhong WHERE ID = @id)
		SET @KQ = 1
	ELSE
		SET @KQ = 0

GO
/****** Object:  StoredProcedure [dbo].[KTIdKhachHangToiTai]    Script Date: 11/5/2021 14:27:15 ******/
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
/****** Object:  StoredProcedure [dbo].[KTIDPhongTrongThue]    Script Date: 11/5/2021 14:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[KTIDPhongTrongThue](@idPhong int, @kq bit output)
AS
	IF EXISTS (SELECT * FROM ThuePhong WHERE ID_Phong = @idPhong)
		set @kq = 1
	ELSE
		set @kq = 0

GO
/****** Object:  StoredProcedure [dbo].[KTIDThue]    Script Date: 11/5/2021 14:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[KTIDThue](@idThue nvarchar(10), @idKH nvarchar(10), @kq bit output)
AS
	IF EXISTS (SELECT * FROM ThuePhong WHERE ID =@idThue AND ID_KH = @idKH)
		set @kq = 1
	ELSE
		set @kq = 0

GO
/****** Object:  StoredProcedure [dbo].[KTPhongTonTai]    Script Date: 11/5/2021 14:27:15 ******/
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
/****** Object:  StoredProcedure [dbo].[LayDSHoaDon]    Script Date: 11/5/2021 14:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LayDSHoaDon](@thang int, @nam int)
AS
BEGIN
	IF @thang = 0
	BEGIN
		SELECT h.ID, k.HoTen, p.TenPhong
           ,NgayLap, NgayThu
           ,GiaPhong
           ,SkDien
           ,TienDien
           ,SkNuoc
           ,TienNuoc
           ,TienDV
           ,TongTien
		   ,TrangThai 
		FROM HoaDon h, KhachHang k, Phong p
		WHERE h.ID_Phong = p.ID
		AND h.ID_KH = k.ID
		AND YEAR(NgayLap) = @nam
	END
	ELSE
	BEGIN
		SELECT h.ID, k.HoTen, p.TenPhong
           ,NgayLap, NgayThu
           ,GiaPhong
           ,SkDien
           ,TienDien
           ,SkNuoc
           ,TienNuoc
           ,TienDV
           ,TongTien
		   ,TrangThai 
		FROM HoaDon h, KhachHang k, Phong p
		WHERE h.ID_Phong = p.ID
		AND h.ID_KH = k.ID
		AND YEAR(NgayLap) = @nam AND MONTH(NgayLap) = @thang
	END
END

GO
/****** Object:  StoredProcedure [dbo].[LayDSKhachKhongConThue]    Script Date: 11/5/2021 14:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LayDSKhachKhongConThue]
AS
	SELECT ID, HoTen, GioiTinh, NgaySinh, Sdt, CMND, QueQuan 
	FROM KhachHang 
	WHERE MaPhong IS NULL

GO
/****** Object:  StoredProcedure [dbo].[LayDSKhachTheoIDPhong]    Script Date: 11/5/2021 14:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LayDSKhachTheoIDPhong](@idPhong int)
AS
	SELECT k.ID, HoTen,GioiTinh, NgaySinh, Sdt, CMND, QueQuan, p.TenPhong
	FROM KhachHang k, Phong p
	WHERE MaPhong = @idPhong
	AND k.MaPhong = p.ID

GO
/****** Object:  StoredProcedure [dbo].[LayDSLoaiPhong]    Script Date: 11/5/2021 14:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LayDSLoaiPhong]
AS
	SELECT * FROM LoaiPhong


GO
/****** Object:  StoredProcedure [dbo].[LayDSPhongChuaLapHoaDon]    Script Date: 11/5/2021 14:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LayDSPhongChuaLapHoaDon](@nam NVARCHAR(4), @thang NVARCHAR(2))
AS
	SELECT * FROM Phong WHERE ID NOT IN (SELECT ID_Phong FROM HoaDon WHERE YEAR(NgayLap) = @nam AND MONTH(NgayLap) = @thang)
					AND SoNguoiHienTai > 0

GO
/****** Object:  StoredProcedure [dbo].[LayDSPhongDaChoThue]    Script Date: 11/5/2021 14:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LayDSPhongDaChoThue]
AS
	SELECT p.ID, TenPhong, TenLP, SoNguoiToiDa, SoNguoiHienTai FROM Phong p, LoaiPhong l
	WHERE p.IDLoaiPhong = l.ID
	AND SoNguoiHienTai > 0

GO
/****** Object:  StoredProcedure [dbo].[LayDSPhongTrong]    Script Date: 11/5/2021 14:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LayDSPhongTrong]
AS
	SELECT p.ID, TenPhong, TenLP, SoNguoiToiDa, SoNguoiHienTai FROM Phong p, LoaiPhong l
	WHERE p.IDLoaiPhong = l.ID
	AND SoNguoiHienTai = 0

GO
/****** Object:  StoredProcedure [dbo].[LayDSThuePhong]    Script Date: 11/5/2021 14:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LayDSThuePhong](@thang int, @nam int)
AS
BEGIN
	IF (@thang = 0)
	BEGIN
		SELECT t.ID, k.HoTen, p.TenPhong, NgayThue, TienCoc  FROM ThuePhong t, KhachHang k, Phong p
		WHERE YEAR(NgayThue) = @nam
		AND t.ID_KH = k.ID
		And t.ID_Phong = p.ID
	END
	ELSE
	BEGIN
		SELECT t.ID, k.HoTen, p.TenPhong, NgayThue, TienCoc  FROM ThuePhong t, KhachHang k, Phong p
		WHERE YEAR(NgayThue) = @nam AND MONTH(NgayThue) = @thang
		AND t.ID_KH = k.ID
		And t.ID_Phong = p.ID
	END
END

GO
/****** Object:  StoredProcedure [dbo].[LayDSTraPhong]    Script Date: 11/5/2021 14:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LayDSTraPhong](@thang int, @nam int)
AS
BEGIN
	IF (@thang = 0)
	BEGIN
		SELECT t.ID_Thue, k.HoTen, p.TenPhong, NgayThue, NgayTra  FROM TraPhong t, KhachHang k, Phong p
		WHERE YEAR(NgayTra) = @nam
		AND t.ID_KH = k.ID
		And t.ID_Phong = p.ID
	END
	ELSE
	BEGIN
		SELECT t.ID_Thue, k.HoTen, p.TenPhong, NgayThue, NgayTra  FROM TraPhong t, KhachHang k, Phong p
		WHERE YEAR(NgayTra) = @nam AND MONTH(NgayTra) = @thang
		AND t.ID_KH = k.ID
		And t.ID_Phong = p.ID
	END
END

GO
/****** Object:  StoredProcedure [dbo].[LayHoaDonChuaThuTien]    Script Date: 11/5/2021 14:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LayHoaDonChuaThuTien]
AS
	SELECT h.ID, p.TenPhong, k.HoTen, NgayLap, GiaPhong, SkDien, TienDien,SkNuoc, TienNuoc, TienDV, TongTien
	FROM HoaDon h, Phong p, KhachHang k
	WHERE TrangThai = N'Chưa thu'
	AND h.ID_KH = k.ID
	AND h.ID_Phong = p.ID

GO
/****** Object:  StoredProcedure [dbo].[LayMa]    Script Date: 11/5/2021 14:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LayMa](@id NVARCHAR(2), @giaTri NVARCHAR(8) output)
AS
	SELECT @giaTri = GiaTri FROM ThamSo
	WHERE ID = @id

GO
/****** Object:  StoredProcedure [dbo].[LayPhongTheoTen]    Script Date: 11/5/2021 14:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LayPhongTheoTen](@ten NVARCHAR(10))
AS
	SELECT * FROM Phong WHERE TenPhong = @ten

GO
/****** Object:  StoredProcedure [dbo].[LayPhongTrongTheoLoai]    Script Date: 11/5/2021 14:27:15 ******/
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
/****** Object:  StoredProcedure [dbo].[LaySoNguoiHTVaTD]    Script Date: 11/5/2021 14:27:15 ******/
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
/****** Object:  StoredProcedure [dbo].[SuaKH]    Script Date: 11/5/2021 14:27:15 ******/
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
/****** Object:  StoredProcedure [dbo].[SuaLP]    Script Date: 11/5/2021 14:27:15 ******/
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
/****** Object:  StoredProcedure [dbo].[SuaPhi]    Script Date: 11/5/2021 14:27:15 ******/
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
/****** Object:  StoredProcedure [dbo].[SuaPhong]    Script Date: 11/5/2021 14:27:15 ******/
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
/****** Object:  StoredProcedure [dbo].[SuaSoNguoiHienTai]    Script Date: 11/5/2021 14:27:15 ******/
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
/****** Object:  StoredProcedure [dbo].[ThemHoaDon]    Script Date: 11/5/2021 14:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemHoaDon](@ID_KH nvarchar(10),
						@ID_Phong int,
						@NgayLap datetime,
						@GiaPhong decimal(18, 0),
						@SkDien int ,
						@TienDien decimal(18, 0),
						@SkNuoc int,
						@TienNuoc decimal(18, 0),
						@TienDV decimal(18, 0), 
						@TongTien decimal(18, 0))
AS
	INSERT INTO HoaDon
           (ID_KH
           ,ID_Phong
           ,NgayLap
           ,GiaPhong
           ,SkDien
           ,TienDien
           ,SkNuoc
           ,TienNuoc
           ,TienDV
           ,TongTien
           ,TrangThai)
     VALUES
           (@ID_KH,
			@ID_Phong,
			@NgayLap,
			@GiaPhong,
			@SkDien,
			@TienDien,
			@SkNuoc,
			@TienNuoc,
			@TienDV, 
			@TongTien,
			N'Chưa thu')

GO
/****** Object:  StoredProcedure [dbo].[ThemKH]    Script Date: 11/5/2021 14:27:15 ******/
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
					,@QueQuan NVARCHAR(150))
AS
	INSERT INTO KhachHang(ID, HoTen, GioiTinh, NgaySinh, Sdt ,CMND ,QueQuan) 
	VALUES (@ID, @HoTen, @GioiTinh, @NgaySinh, @Sdt , @CMND, @QueQuan)


GO
/****** Object:  StoredProcedure [dbo].[ThemPhong]    Script Date: 11/5/2021 14:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemPhong] (@Ten NVARCHAR(10), @Loai int, @ToiDa int, @HienTai int)
AS
	INSERT INTO Phong(TenPhong, IDLoaiPhong, SoNguoiToiDa, SoNguoiHienTai) 
	VALUES (@Ten, @Loai, @ToiDa, @HienTai)


GO
/****** Object:  StoredProcedure [dbo].[ThemThuePhong]    Script Date: 11/5/2021 14:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemThuePhong] (@id NVARCHAR(10)
					, @idKH NVARCHAR(10)
					, @idPhong int
					, @ngayThue DATETIME
					, @tienCoc DECIMAL(18,0))
AS
	INSERT INTO ThuePhong (ID, ID_KH, ID_Phong, NgayThue, TienCoc)
	VALUES	(@id, @idKH, @idPhong, @ngayThue, @tienCoc)

GO
/****** Object:  StoredProcedure [dbo].[ThemTraPhong]    Script Date: 11/5/2021 14:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemTraPhong](@idThue NVARCHAR(10), @idKH NVARCHAR(10), @idPhong INT, @ngayThue DATETIME, @ngayTra DATETIME)
AS
	INSERT INTO	TraPhong
		(ID_Thue,
		ID_KH,
		ID_Phong,
		NgayThue,
		NgayTra)
	VALUES
		(@idThue,
		@idKH,
		@idPhong,
		@ngayThue,
		@ngayTra)

GO
/****** Object:  StoredProcedure [dbo].[TimKhachThue]    Script Date: 11/5/2021 14:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TimKhachThue](@ten NVARCHAR(100))
AS
BEGIN
	SELECT k.ID, k.HoTen, k.GioiTinh, k.NgaySinh, k.Sdt, k.CMND, k.QueQuan, p.TenPhong
	FROM KhachHang k, Phong p
	WHERE k.MaPhong = p.ID
	AND dbo.fChuyenCoDauThanhKhongDau(HoTen) like '%' + dbo.fChuyenCoDauThanhKhongDau(@ten) + '%'
END

GO
/****** Object:  StoredProcedure [dbo].[XemCacLoaiPhi]    Script Date: 11/5/2021 14:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XemCacLoaiPhi]
AS
	SELECT * FROM Phi

GO
/****** Object:  StoredProcedure [dbo].[XemDSPhong]    Script Date: 11/5/2021 14:27:15 ******/
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
/****** Object:  StoredProcedure [dbo].[XoaPhong]    Script Date: 11/5/2021 14:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaPhong] (@id INT)
AS
	DELETE FROM Phong WHERE ID = @id


GO
