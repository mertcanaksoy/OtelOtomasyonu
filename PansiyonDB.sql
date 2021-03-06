USE [master]
GO
/****** Object:  Database [PansiyonDB]    Script Date: 24.09.2017 22:56:26 ******/
CREATE DATABASE [PansiyonDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PansiyonDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\PansiyonDB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'PansiyonDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\PansiyonDB_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [PansiyonDB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PansiyonDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PansiyonDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PansiyonDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PansiyonDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PansiyonDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PansiyonDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [PansiyonDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PansiyonDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PansiyonDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PansiyonDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PansiyonDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PansiyonDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PansiyonDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PansiyonDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PansiyonDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PansiyonDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PansiyonDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PansiyonDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PansiyonDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PansiyonDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PansiyonDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PansiyonDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PansiyonDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PansiyonDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PansiyonDB] SET  MULTI_USER 
GO
ALTER DATABASE [PansiyonDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PansiyonDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PansiyonDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PansiyonDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [PansiyonDB] SET DELAYED_DURABILITY = DISABLED 
GO
USE [PansiyonDB]
GO
/****** Object:  Table [dbo].[Duyurular]    Script Date: 24.09.2017 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Duyurular](
	[DuyuruId] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAdi] [varchar](50) NULL,
	[DuyuruMetni] [varchar](500) NULL,
	[Aktif] [bit] NULL CONSTRAINT [DF_Duyurular_Aktif]  DEFAULT ((1)),
 CONSTRAINT [PK_Duyurular] PRIMARY KEY CLUSTERED 
(
	[DuyuruId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Fatura]    Script Date: 24.09.2017 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fatura](
	[Elektrik] [int] NULL,
	[Su] [int] NULL,
	[Isinma] [int] NULL,
	[Internet] [int] NULL,
	[Tarih] [date] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Musteri]    Script Date: 24.09.2017 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Musteri](
	[MusteriId] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [varchar](30) NULL,
	[Soyadi] [varchar](30) NULL,
	[Cinsiyet] [varchar](5) NULL,
	[Telefon] [varchar](15) NULL,
	[Mail] [varchar](40) NULL,
	[KimlikNo] [varchar](11) NULL,
	[OdaNo] [varchar](5) NULL,
	[Ucret] [int] NULL,
	[GirisTarihi] [date] NULL,
	[CikisTarihi] [date] NULL,
	[Aktif] [bit] NULL CONSTRAINT [DF_Musteri_Aktif]  DEFAULT ((1)),
 CONSTRAINT [PK_MusteriEkle] PRIMARY KEY CLUSTERED 
(
	[MusteriId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Oda101]    Script Date: 24.09.2017 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Oda101](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Oda102]    Script Date: 24.09.2017 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Oda102](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Oda103]    Script Date: 24.09.2017 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Oda103](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Oda104]    Script Date: 24.09.2017 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Oda104](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Oda201]    Script Date: 24.09.2017 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Oda201](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Oda202]    Script Date: 24.09.2017 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Oda202](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Oda203]    Script Date: 24.09.2017 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Oda203](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Oda204]    Script Date: 24.09.2017 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Oda204](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Oda301]    Script Date: 24.09.2017 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Oda301](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Oda302]    Script Date: 24.09.2017 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Oda302](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Oda303]    Script Date: 24.09.2017 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Oda303](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Oda304]    Script Date: 24.09.2017 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Oda304](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Oda401]    Script Date: 24.09.2017 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Oda401](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Oda402]    Script Date: 24.09.2017 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Oda402](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Oda403]    Script Date: 24.09.2017 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Oda403](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Oda404]    Script Date: 24.09.2017 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Oda404](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Oda501]    Script Date: 24.09.2017 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Oda501](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Oda502]    Script Date: 24.09.2017 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Oda502](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Oda503]    Script Date: 24.09.2017 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Oda503](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Oda504]    Script Date: 24.09.2017 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Oda504](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PersonelGiris]    Script Date: 24.09.2017 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PersonelGiris](
	[PersonelId] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAdi] [varchar](20) NULL,
	[Sifre] [varchar](20) NULL,
 CONSTRAINT [PK_PersonelGiris] PRIMARY KEY CLUSTERED 
(
	[PersonelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Stok]    Script Date: 24.09.2017 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stok](
	[Gida] [int] NULL,
	[Icecek] [int] NULL,
	[Aburcubur] [int] NULL,
	[Tarih] [date] NULL
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Duyurular] ON 

INSERT [dbo].[Duyurular] ([DuyuruId], [KullaniciAdi], [DuyuruMetni], [Aktif]) VALUES (1, N'mert', N'Deneme yapıyorum güncellendi mi', 1)
INSERT [dbo].[Duyurular] ([DuyuruId], [KullaniciAdi], [DuyuruMetni], [Aktif]) VALUES (2, N'admin', N'Yeni duyuru ekleme şekliyle ilk deneme', 1)
INSERT [dbo].[Duyurular] ([DuyuruId], [KullaniciAdi], [DuyuruMetni], [Aktif]) VALUES (3, N'mert', N'Yeni duyuu ekleme şekliyle ikinci deneme', 0)
INSERT [dbo].[Duyurular] ([DuyuruId], [KullaniciAdi], [DuyuruMetni], [Aktif]) VALUES (4, N'admin', N'Temizle işleminden sonra ilk ekleme denemsi tekrar', 0)
INSERT [dbo].[Duyurular] ([DuyuruId], [KullaniciAdi], [DuyuruMetni], [Aktif]) VALUES (5, N'a', N'a', 0)
INSERT [dbo].[Duyurular] ([DuyuruId], [KullaniciAdi], [DuyuruMetni], [Aktif]) VALUES (6, N'admin', N'yeni deneme', 1)
SET IDENTITY_INSERT [dbo].[Duyurular] OFF
INSERT [dbo].[Fatura] ([Elektrik], [Su], [Isinma], [Internet], [Tarih]) VALUES (1200, 1000, 300, 150, CAST(N'2017-09-18' AS Date))
INSERT [dbo].[Fatura] ([Elektrik], [Su], [Isinma], [Internet], [Tarih]) VALUES (800, 2000, 500, 150, CAST(N'2017-09-20' AS Date))
SET IDENTITY_INSERT [dbo].[Musteri] ON 

INSERT [dbo].[Musteri] ([MusteriId], [Adi], [Soyadi], [Cinsiyet], [Telefon], [Mail], [KimlikNo], [OdaNo], [Ucret], [GirisTarihi], [CikisTarihi], [Aktif]) VALUES (1, N'Mert', N'Aydın', N'Erkek', N'(564) 865-2254', N'mert@gmail.com', N'64684653132', N'101', 150, CAST(N'2017-09-17' AS Date), CAST(N'2017-09-20' AS Date), 1)
INSERT [dbo].[Musteri] ([MusteriId], [Adi], [Soyadi], [Cinsiyet], [Telefon], [Mail], [KimlikNo], [OdaNo], [Ucret], [GirisTarihi], [CikisTarihi], [Aktif]) VALUES (2, N'Fatma', N'Gündüz', N'Kadın', N'(564) 846-3533', N'fatma@gmail.com', N'68465132153', N'301', 100, CAST(N'2017-09-17' AS Date), CAST(N'2017-09-19' AS Date), 1)
INSERT [dbo].[Musteri] ([MusteriId], [Adi], [Soyadi], [Cinsiyet], [Telefon], [Mail], [KimlikNo], [OdaNo], [Ucret], [GirisTarihi], [CikisTarihi], [Aktif]) VALUES (20, N'Gizem', N'Şen', N'Kadın', N'(498) 465-1651', N'gizem@gmail.com', N'84653223215', N'104', 100, CAST(N'2017-09-21' AS Date), CAST(N'2017-09-23' AS Date), 0)
SET IDENTITY_INSERT [dbo].[Musteri] OFF
INSERT [dbo].[Oda101] ([Adi], [Soyadi]) VALUES (N'Mert', N'Aydın')
INSERT [dbo].[Oda301] ([Adi], [Soyadi]) VALUES (N'Fatma', N'Gündüz')
SET IDENTITY_INSERT [dbo].[PersonelGiris] ON 

INSERT [dbo].[PersonelGiris] ([PersonelId], [KullaniciAdi], [Sifre]) VALUES (1, N'admin', N'admin1234')
INSERT [dbo].[PersonelGiris] ([PersonelId], [KullaniciAdi], [Sifre]) VALUES (2, N'mert', N'mert1234')
SET IDENTITY_INSERT [dbo].[PersonelGiris] OFF
INSERT [dbo].[Stok] ([Gida], [Icecek], [Aburcubur], [Tarih]) VALUES (2000, 1500, 1000, CAST(N'2017-09-18' AS Date))
INSERT [dbo].[Stok] ([Gida], [Icecek], [Aburcubur], [Tarih]) VALUES (600, 200, 300, CAST(N'2017-09-20' AS Date))
USE [master]
GO
ALTER DATABASE [PansiyonDB] SET  READ_WRITE 
GO
