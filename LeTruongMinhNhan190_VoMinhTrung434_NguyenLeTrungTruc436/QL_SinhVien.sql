CREATE DATABASE QuanLySinhVien

USE QuanLySinhVien
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KetQua](
	[MaSo] [int] NOT NULL,
	[MaMH] [nchar](6) NOT NULL,
	[Diem] [int] NULL,
 CONSTRAINT [PK_KetQua] PRIMARY KEY CLUSTERED 
(
	[MaSo] ASC,
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHOA](
	[MaKhoa] [nchar](6) NOT NULL,
	[TenKhoa] [nchar](30) NULL,
 CONSTRAINT [PK_KHOA] PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mon](
	[MaMH] [nchar](6) NOT NULL,
	[TenMH] [nchar](50) NULL,
	[SoTiet] [int] NULL,
 CONSTRAINT [PK_Mon] PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSo] [int] NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [bit] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [int] NULL,
	[MaKhoa] [nchar](6) NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[MaSo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[KetQua]  WITH CHECK ADD  CONSTRAINT [FK_KetQua_Mon] FOREIGN KEY([MaMH])
REFERENCES [dbo].[Mon] ([MaMH])
GO
ALTER TABLE [dbo].[KetQua] CHECK CONSTRAINT [FK_KetQua_Mon]
GO
ALTER TABLE [dbo].[KetQua]  WITH CHECK ADD  CONSTRAINT [FK_KetQua_SinhVien] FOREIGN KEY([MaSo])
REFERENCES [dbo].[SinhVien] ([MaSo])
GO
ALTER TABLE [dbo].[KetQua] CHECK CONSTRAINT [FK_KetQua_SinhVien]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_KHOA] FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[KHOA] ([MaKhoa])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_KHOA]
GO

---Nhap lieu
insert into KHOA values('CNTP', N'Công nghệ thực phẩm')
insert into KHOA values('CNTT',N'Công nghệ thông tin')
insert into KHOA values('DDT',N'Điện điện tử')
insert into KHOA values('MT',N'Môi trường')
insert into KHOA values('NN',N'Ngoại ngữ')
insert into KHOA values('QTKD',N'Quản trị kinh doanh')

insert into Mon values('CSDL', N'Cơ sở dữ liệu','50')
insert into Mon values('CTDL', N'Cấu trúc dữ liệu','45')
insert into Mon values('DH', N'Đọc hiểu','30')
insert into Mon values('DH2', N'Đồ họa','40')
insert into Mon values('KTLT', N'Kĩ thuật lập trình','60')
insert into Mon values('LTW', N'Lập trình Windows','45')
insert into Mon values('NN', N'Nghe nói','25')
insert into Mon values('NP', N'Ngữ pháp','30')
insert into Mon values('NVA', N'Ngữ văn anh','40')

insert into SinhVien values('101', N'Trần Văn Tèo', '2011-07-17', 'True', N'Quận 3', '12342455', 'MT')
insert into SinhVien values('102', N'Huỳnh Thị Ánh', '2000-10-01', 'False', N'Bình Chánh', '22344232', 'NN')
insert into SinhVien values('103', N'Phạm Ngọc Bích', '1999-02-10', 'False', N'Quận 9', '23456789', 'QTKD')
insert into SinhVien values('104', N'Võ Minh Minh', '2000-12-12', 'True', N'Bình Tân', '18999018', 'CNTT')
insert into SinhVien values('105', N'Nguyễn Trung Thành', '1998-02-01', 'True', N'Quận 1', '12243534', 'DDT')
insert into SinhVien values('107', N'Phạm Mỹ Kiều', '1997-07-27', 'False', N'Tân Bình', '88798700', 'NN')
insert into SinhVien values('108', N'Phạm Mỹ Mỹ', '1995-05-25', 'False', N'Hòa Bình', '67890554', 'CNTP')
insert into SinhVien values('109', N'Nguyễn Trung Thanh', '2001-10-05', 'True', N'Phú Yên', '19001911', 'CNTT')

insert into KetQua values('101', 'CSDL', '10')
insert into KetQua values('101', 'CTDL', '8')
insert into KetQua values('101', 'KTLT', '7')
insert into KetQua values('101', 'NN', '8')
insert into KetQua values('102', 'NN', '8')
insert into KetQua values('102', 'NP', '7')
insert into KetQua values('102', 'NVA', '8')
insert into KetQua values('109', 'CTDL', '9')
insert into KetQua values('109', 'DH2', '9')
insert into KetQua values('109', 'LTW', '10')