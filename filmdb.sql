USE [SinemaDB]
GO
/****** Object:  Table [dbo].[Adisyon]    Script Date: 13.06.2022 16:53:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adisyon](
	[AdisyonID] [int] IDENTITY(1,1) NOT NULL,
	[toplamUcret] [money] NULL,
	[tarih] [smalldatetime] NULL,
	[kullaniciID] [int] NULL,
 CONSTRAINT [PK_Adisyon] PRIMARY KEY CLUSTERED 
(
	[AdisyonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AdisyonDetay]    Script Date: 13.06.2022 16:53:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdisyonDetay](
	[adisyonDetayID] [int] IDENTITY(1,1) NOT NULL,
	[adisyonID] [int] NULL,
	[urunID] [int] NULL,
	[miktar] [int] NULL,
	[birimFiyat] [money] NULL,
 CONSTRAINT [PK_AdisyonDetay] PRIMARY KEY CLUSTERED 
(
	[adisyonDetayID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bilet]    Script Date: 13.06.2022 16:53:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bilet](
	[biletID] [int] IDENTITY(1,1) NOT NULL,
	[No] [bigint] NULL,
	[durum] [nvarchar](50) NULL,
	[tarih] [date] NULL,
	[seansID] [int] NULL,
	[cinsiyet] [nvarchar](5) NULL,
 CONSTRAINT [PK_BiletTBL] PRIMARY KEY CLUSTERED 
(
	[biletID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Film]    Script Date: 13.06.2022 16:53:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Film](
	[filmID] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](50) NULL,
	[Sure] [smallint] NULL,
	[Aciklama] [text] NULL,
	[Konu] [text] NULL,
	[Puan] [decimal](18, 0) NULL,
	[Oyuncu] [nvarchar](50) NULL,
	[yonetmen] [nvarchar](50) NULL,
	[filmTurID] [int] NULL,
	[afis] [varchar](200) NULL,
	[vizyonBasTarihi] [smalldatetime] NULL,
	[vizyonBitTarihi] [smalldatetime] NULL,
 CONSTRAINT [PK_FilmTBL] PRIMARY KEY CLUSTERED 
(
	[filmID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FilmTur]    Script Date: 13.06.2022 16:53:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FilmTur](
	[filmTurID] [int] IDENTITY(1,1) NOT NULL,
	[ad] [nchar](10) NULL,
 CONSTRAINT [PK_FilmTur] PRIMARY KEY CLUSTERED 
(
	[filmTurID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanici]    Script Date: 13.06.2022 16:53:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanici](
	[kullaniciID] [int] IDENTITY(1,1) NOT NULL,
	[ad] [nvarchar](50) NULL,
	[soyad] [nvarchar](50) NULL,
	[eposta] [nvarchar](50) NULL,
	[sifre] [nvarchar](50) NULL,
	[yetkiID] [int] NULL,
	[kayitTarihi] [smalldatetime] NULL,
 CONSTRAINT [PK_Kullanici] PRIMARY KEY CLUSTERED 
(
	[kullaniciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salon]    Script Date: 13.06.2022 16:53:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salon](
	[salonID] [int] IDENTITY(1,1) NOT NULL,
	[salonNo] [smallint] NULL,
	[ad] [smallint] NULL,
	[durum] [nvarchar](50) NULL,
	[ucret] [money] NULL,
	[koltukSayisi] [int] NULL,
 CONSTRAINT [PK_SalonTBL] PRIMARY KEY CLUSTERED 
(
	[salonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Seans]    Script Date: 13.06.2022 16:53:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seans](
	[seansID] [int] IDENTITY(1,1) NOT NULL,
	[filmID] [int] NULL,
	[salonID] [int] NULL,
	[seansBaslangicSaati] [time](7) NULL,
	[seansBitisSaati] [time](7) NULL,
 CONSTRAINT [PK_Seans] PRIMARY KEY CLUSTERED 
(
	[seansID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tur]    Script Date: 13.06.2022 16:53:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tur](
	[TurID] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](50) NULL,
 CONSTRAINT [PK_Tur] PRIMARY KEY CLUSTERED 
(
	[TurID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Urun]    Script Date: 13.06.2022 16:53:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Urun](
	[urunID] [int] IDENTITY(1,1) NOT NULL,
	[turID] [int] NULL,
	[ad] [nvarchar](50) NULL,
	[resim] [nvarchar](100) NULL,
	[fiyat] [money] NULL,
 CONSTRAINT [PK_Urun] PRIMARY KEY CLUSTERED 
(
	[urunID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yetki]    Script Date: 13.06.2022 16:53:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yetki](
	[yetkilD] [int] IDENTITY(1,1) NOT NULL,
	[yetkiAd] [nvarchar](50) NULL,
 CONSTRAINT [PK_YetkiliTBL] PRIMARY KEY CLUSTERED 
(
	[yetkilD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Bilet] ON 

INSERT [dbo].[Bilet] ([biletID], [No], [durum], [tarih], [seansID], [cinsiyet]) VALUES (8, 2250, N'false', CAST(N'2022-05-27' AS Date), NULL, N'erkek')
INSERT [dbo].[Bilet] ([biletID], [No], [durum], [tarih], [seansID], [cinsiyet]) VALUES (9, NULL, NULL, CAST(N'2022-06-01' AS Date), 4, N'Erkek')
INSERT [dbo].[Bilet] ([biletID], [No], [durum], [tarih], [seansID], [cinsiyet]) VALUES (10, NULL, NULL, CAST(N'2022-06-01' AS Date), 4, N'Erkek')
INSERT [dbo].[Bilet] ([biletID], [No], [durum], [tarih], [seansID], [cinsiyet]) VALUES (11, NULL, NULL, CAST(N'2022-06-01' AS Date), 4, N'Kadın')
INSERT [dbo].[Bilet] ([biletID], [No], [durum], [tarih], [seansID], [cinsiyet]) VALUES (12, NULL, NULL, CAST(N'2022-06-01' AS Date), 4, N'Kadın')
INSERT [dbo].[Bilet] ([biletID], [No], [durum], [tarih], [seansID], [cinsiyet]) VALUES (13, NULL, NULL, CAST(N'2022-06-01' AS Date), 4, N'Kadın')
INSERT [dbo].[Bilet] ([biletID], [No], [durum], [tarih], [seansID], [cinsiyet]) VALUES (14, NULL, NULL, CAST(N'2022-06-01' AS Date), 4, N'Kadın')
INSERT [dbo].[Bilet] ([biletID], [No], [durum], [tarih], [seansID], [cinsiyet]) VALUES (15, NULL, NULL, CAST(N'2022-06-01' AS Date), 4, N'Kadın')
INSERT [dbo].[Bilet] ([biletID], [No], [durum], [tarih], [seansID], [cinsiyet]) VALUES (16, NULL, NULL, CAST(N'2022-06-01' AS Date), 4, N'Erkek')
INSERT [dbo].[Bilet] ([biletID], [No], [durum], [tarih], [seansID], [cinsiyet]) VALUES (17, NULL, NULL, CAST(N'2022-06-13' AS Date), 4, N'Erkek')
SET IDENTITY_INSERT [dbo].[Bilet] OFF
GO
SET IDENTITY_INSERT [dbo].[Film] ON 

INSERT [dbo].[Film] ([filmID], [Ad], [Sure], [Aciklama], [Konu], [Puan], [Oyuncu], [yonetmen], [filmTurID], [afis], [vizyonBasTarihi], [vizyonBitTarihi]) VALUES (2, N'Spiderman ', 1, N'-Taşradan gelen genç bir oğlan olan  Merlin hayat dolu Camelot şehrine  gelir ve bir idama tanık olur.', N'Aksiyon', CAST(8 AS Decimal(18, 0)), N'Tobey Maguire,Marry Jeen,  Will Smith', N'Reshit SANCHEZ', 1, N'C:\Users\Asım Mutlu\Desktop\SinemaOtomasyonu\SinemaOtomasyonu\Cinema Otomasyonu V1\Spiderman.jpg', CAST(N'2022-05-25T13:00:00' AS SmallDateTime), CAST(N'2020-05-22T00:00:00' AS SmallDateTime))
INSERT [dbo].[Film] ([filmID], [Ad], [Sure], [Aciklama], [Konu], [Puan], [Oyuncu], [yonetmen], [filmTurID], [afis], [vizyonBasTarihi], [vizyonBitTarihi]) VALUES (4, N'Eren', 2, N'-Ahmetin Şefkatli kalbi', N'Aksiyon', CAST(7 AS Decimal(18, 0)), N'Reshit,Asım', N'Ahmet BURAK', 2, N'C:\Users\Asım Mutlu\Desktop\SinemaOtomasyonu\SinemaOtomasyonu\Cinema Otomasyonu V1\eren .jpg', CAST(N'2022-05-25T12:00:00' AS SmallDateTime), CAST(N'2023-05-25T13:00:00' AS SmallDateTime))
INSERT [dbo].[Film] ([filmID], [Ad], [Sure], [Aciklama], [Konu], [Puan], [Oyuncu], [yonetmen], [filmTurID], [afis], [vizyonBasTarihi], [vizyonBitTarihi]) VALUES (5, N'Aquaman', 1, N'-Hebele hübele', N'Dram', CAST(8 AS Decimal(18, 0)), N'Faruk Hoca,Talha Sekoğlu', N'Asım Mutlu', 3, N'C:\Users\Asım Mutlu\Desktop\SinemaOtomasyonu\SinemaOtomasyonu\Cinema Otomasyonu V1\auaman.jpg', CAST(N'2001-12-15T00:00:00' AS SmallDateTime), CAST(N'2001-12-15T00:00:00' AS SmallDateTime))
INSERT [dbo].[Film] ([filmID], [Ad], [Sure], [Aciklama], [Konu], [Puan], [Oyuncu], [yonetmen], [filmTurID], [afis], [vizyonBasTarihi], [vizyonBitTarihi]) VALUES (6, N'Batman', 2, N'-Batman Jokeri Durdurmaya Çalışırı Çünkğ Batman İyi Biri', N'Aksiyon', CAST(9 AS Decimal(18, 0)), N'Batman,Joker', N'Robin', 1, N'C:\Users\Asım Mutlu\Desktop\SinemaOtomasyonu\SinemaOtomasyonu\Cinema Otomasyonu V1\batman.jpg', CAST(N'2022-05-25T13:00:00' AS SmallDateTime), CAST(N'2022-05-25T15:00:00' AS SmallDateTime))
INSERT [dbo].[Film] ([filmID], [Ad], [Sure], [Aciklama], [Konu], [Puan], [Oyuncu], [yonetmen], [filmTurID], [afis], [vizyonBasTarihi], [vizyonBitTarihi]) VALUES (7, N'Colon', 2, N'-Colon Adlı Genç Adam Colonlardan Oluşan dünyada hayatta kalmaya çalışır ', N'Dram', CAST(2 AS Decimal(18, 0)), N'Colon', N'Coloff', 3, N'C:\Users\Asım Mutlu\Desktop\SinemaOtomasyonu\SinemaOtomasyonu\Cinema Otomasyonu V1\colon.jpg', CAST(N'2022-05-25T13:00:00' AS SmallDateTime), CAST(N'2022-05-25T19:00:00' AS SmallDateTime))
INSERT [dbo].[Film] ([filmID], [Ad], [Sure], [Aciklama], [Konu], [Puan], [Oyuncu], [yonetmen], [filmTurID], [afis], [vizyonBasTarihi], [vizyonBitTarihi]) VALUES (8, N'Her Şey Yolunda', 2, N'-Türkiyede her şey yolunda kesinlikle', N'Dram', CAST(9 AS Decimal(18, 0)), N'Tr Gencii', N'RTE', 3, N'C:\Users\Asım Mutlu\Desktop\SinemaOtomasyonu\SinemaOtomasyonu\Cinema Otomasyonu V1\her şey yolunda.jpg', CAST(N'2022-05-25T16:00:00' AS SmallDateTime), CAST(N'2022-05-25T15:00:00' AS SmallDateTime))
INSERT [dbo].[Film] ([filmID], [Ad], [Sure], [Aciklama], [Konu], [Puan], [Oyuncu], [yonetmen], [filmTurID], [afis], [vizyonBasTarihi], [vizyonBitTarihi]) VALUES (9, N'Hotel Transilvanya', 2, N'-Otelde Olan tuhaf olayla', N'Animasyon', CAST(9 AS Decimal(18, 0)), N'Adam', N'Vampir Adam', 10, N'C:\Users\Asım Mutlu\Desktop\SinemaOtomasyonu\SinemaOtomasyonu\Cinema Otomasyonu V1\hotel transilvania .jpg', CAST(N'2022-05-25T16:00:00' AS SmallDateTime), CAST(N'2022-05-25T16:00:00' AS SmallDateTime))
INSERT [dbo].[Film] ([filmID], [Ad], [Sure], [Aciklama], [Konu], [Puan], [Oyuncu], [yonetmen], [filmTurID], [afis], [vizyonBasTarihi], [vizyonBitTarihi]) VALUES (10, N'Hürkuş', 2, N'-Uçak kullanan bir adamın hikayesi', N'Aksiyon', CAST(9 AS Decimal(18, 0)), N'Jake ', N'Lady Gaga', 1, N'C:\Users\Asım Mutlu\Desktop\SinemaOtomasyonu\SinemaOtomasyonu\Cinema Otomasyonu V1\hürkuş.jpg', CAST(N'2022-05-25T16:00:00' AS SmallDateTime), CAST(N'2022-05-25T16:00:00' AS SmallDateTime))
INSERT [dbo].[Film] ([filmID], [Ad], [Sure], [Aciklama], [Konu], [Puan], [Oyuncu], [yonetmen], [filmTurID], [afis], [vizyonBasTarihi], [vizyonBitTarihi]) VALUES (11, N'Joker', 2, N'-Jokerin nasıl joker olduğunu anlatan film', N'Aksiyon', CAST(9 AS Decimal(18, 0)), N'Joker', N'Batman', 1, N'C:\Users\Asım Mutlu\Desktop\SinemaOtomasyonu\SinemaOtomasyonu\Cinema Otomasyonu V1\Joker.jpg', CAST(N'2022-05-25T16:00:00' AS SmallDateTime), CAST(N'2022-05-25T16:00:00' AS SmallDateTime))
INSERT [dbo].[Film] ([filmID], [Ad], [Sure], [Aciklama], [Konu], [Puan], [Oyuncu], [yonetmen], [filmTurID], [afis], [vizyonBasTarihi], [vizyonBitTarihi]) VALUES (12, N'Korku Seansı', 2, N'-Evde geçen paranormal olaylar anlatılır.', N'Korku', CAST(8 AS Decimal(18, 0)), N'Will Smith', N'Brad Pitt', 2, N'C:\Users\Asım Mutlu\Desktop\SinemaOtomasyonu\SinemaOtomasyonu\Cinema Otomasyonu V1\korkuSeansi.jpg', CAST(N'2022-05-25T16:00:00' AS SmallDateTime), CAST(N'2022-05-25T16:00:00' AS SmallDateTime))
INSERT [dbo].[Film] ([filmID], [Ad], [Sure], [Aciklama], [Konu], [Puan], [Oyuncu], [yonetmen], [filmTurID], [afis], [vizyonBasTarihi], [vizyonBitTarihi]) VALUES (13, N'Sıfır Bir', 1, N'-Sokakta Dönen Çatışmalar', N'Aksiyon', CAST(1 AS Decimal(18, 0)), N'Savaş,Cihangir', N'Jhonny Deep', 1, N'C:\Users\Asım Mutlu\Desktop\SinemaOtomasyonu\SinemaOtomasyonu\Cinema Otomasyonu V1\sıfır bir.jpg', CAST(N'2022-05-25T16:00:00' AS SmallDateTime), CAST(N'2022-05-25T16:00:00' AS SmallDateTime))
INSERT [dbo].[Film] ([filmID], [Ad], [Sure], [Aciklama], [Konu], [Puan], [Oyuncu], [yonetmen], [filmTurID], [afis], [vizyonBasTarihi], [vizyonBitTarihi]) VALUES (14, N'The Godfather', 2, N'-Bir mafya hikayesi', N'Aksiyon', CAST(8 AS Decimal(18, 0)), N'Marlon Brando', N'Alpacino', 1, N'C:\Users\Asım Mutlu\Desktop\SinemaOtomasyonu\SinemaOtomasyonu\Cinema Otomasyonu V1\the godfather.jpg', CAST(N'2022-05-25T16:00:00' AS SmallDateTime), CAST(N'2022-05-25T16:00:00' AS SmallDateTime))
SET IDENTITY_INSERT [dbo].[Film] OFF
GO
SET IDENTITY_INSERT [dbo].[FilmTur] ON 

INSERT [dbo].[FilmTur] ([filmTurID], [ad]) VALUES (1, N'Aksiyon   ')
INSERT [dbo].[FilmTur] ([filmTurID], [ad]) VALUES (2, N'Korku     ')
INSERT [dbo].[FilmTur] ([filmTurID], [ad]) VALUES (3, N'Dram      ')
INSERT [dbo].[FilmTur] ([filmTurID], [ad]) VALUES (4, N'Gerilim   ')
INSERT [dbo].[FilmTur] ([filmTurID], [ad]) VALUES (5, N'Komedi    ')
INSERT [dbo].[FilmTur] ([filmTurID], [ad]) VALUES (6, N'Türk      ')
INSERT [dbo].[FilmTur] ([filmTurID], [ad]) VALUES (7, N'Casusluk  ')
INSERT [dbo].[FilmTur] ([filmTurID], [ad]) VALUES (8, N'Belgesel  ')
INSERT [dbo].[FilmTur] ([filmTurID], [ad]) VALUES (9, N'Bilimkurgu')
INSERT [dbo].[FilmTur] ([filmTurID], [ad]) VALUES (10, N'Animasyon ')
INSERT [dbo].[FilmTur] ([filmTurID], [ad]) VALUES (11, N'Macera    ')
INSERT [dbo].[FilmTur] ([filmTurID], [ad]) VALUES (12, N'Fantastik ')
INSERT [dbo].[FilmTur] ([filmTurID], [ad]) VALUES (13, N'Romantik  ')
SET IDENTITY_INSERT [dbo].[FilmTur] OFF
GO
SET IDENTITY_INSERT [dbo].[Kullanici] ON 

INSERT [dbo].[Kullanici] ([kullaniciID], [ad], [soyad], [eposta], [sifre], [yetkiID], [kayitTarihi]) VALUES (1, N'Asim', N'Mutlu', N'asim@gmail.com', N'123456', 1, NULL)
INSERT [dbo].[Kullanici] ([kullaniciID], [ad], [soyad], [eposta], [sifre], [yetkiID], [kayitTarihi]) VALUES (5, N'Emre', N'Yıldız', N'emre@gmail.com', N'123', 2, CAST(N'2005-05-12T00:00:00' AS SmallDateTime))
INSERT [dbo].[Kullanici] ([kullaniciID], [ad], [soyad], [eposta], [sifre], [yetkiID], [kayitTarihi]) VALUES (6, N'Reşit', N'Bucak', N'resit@gmail.com', N'12456', 2, CAST(N'2022-06-01T14:08:00' AS SmallDateTime))
INSERT [dbo].[Kullanici] ([kullaniciID], [ad], [soyad], [eposta], [sifre], [yetkiID], [kayitTarihi]) VALUES (7, N'Talha', N'Sakaoglu', N'talha@gmail.com', N'123456', 2, CAST(N'2022-06-01T14:10:00' AS SmallDateTime))
INSERT [dbo].[Kullanici] ([kullaniciID], [ad], [soyad], [eposta], [sifre], [yetkiID], [kayitTarihi]) VALUES (8, N'ahmet', N'Burak', N'ahmet@gmail.com', N'123', 2, CAST(N'2022-06-01T15:30:00' AS SmallDateTime))
SET IDENTITY_INSERT [dbo].[Kullanici] OFF
GO
SET IDENTITY_INSERT [dbo].[Salon] ON 

INSERT [dbo].[Salon] ([salonID], [salonNo], [ad], [durum], [ucret], [koltukSayisi]) VALUES (1, 10, 2, N'true', 25.0000, 500)
INSERT [dbo].[Salon] ([salonID], [salonNo], [ad], [durum], [ucret], [koltukSayisi]) VALUES (2, 13, 3, N'true', 50.0000, 100)
SET IDENTITY_INSERT [dbo].[Salon] OFF
GO
SET IDENTITY_INSERT [dbo].[Seans] ON 

INSERT [dbo].[Seans] ([seansID], [filmID], [salonID], [seansBaslangicSaati], [seansBitisSaati]) VALUES (4, 2, 1, CAST(N'10:30:00' AS Time), CAST(N'11:30:00' AS Time))
SET IDENTITY_INSERT [dbo].[Seans] OFF
GO
SET IDENTITY_INSERT [dbo].[Tur] ON 

INSERT [dbo].[Tur] ([TurID], [Ad]) VALUES (1, N'Yiyecek')
INSERT [dbo].[Tur] ([TurID], [Ad]) VALUES (2, N'İcecek')
SET IDENTITY_INSERT [dbo].[Tur] OFF
GO
SET IDENTITY_INSERT [dbo].[Urun] ON 

INSERT [dbo].[Urun] ([urunID], [turID], [ad], [resim], [fiyat]) VALUES (1, 1, N'Mısır', N'C:\Users\Asım Mutlu\Desktop\SinemaOtomasyonu\Yiyecek İçecek Resimler\mısır.png', 9.0000)
INSERT [dbo].[Urun] ([urunID], [turID], [ad], [resim], [fiyat]) VALUES (2, 1, N'Bisküvi', N'C:\Users\Asım Mutlu\Desktop\SinemaOtomasyonu\Yiyecek İçecek Resimler\kurabiye.png', 5.0000)
INSERT [dbo].[Urun] ([urunID], [turID], [ad], [resim], [fiyat]) VALUES (3, 1, N'Tatlı', N'C:\Users\Asım Mutlu\Desktop\SinemaOtomasyonu\Yiyecek İçecek Resimler\tatlı.png', 7.0000)
INSERT [dbo].[Urun] ([urunID], [turID], [ad], [resim], [fiyat]) VALUES (4, 1, N'Cips', N'C:\Users\Asım Mutlu\Desktop\SinemaOtomasyonu\Yiyecek İçecek Resimler\cips.png', 8.0000)
INSERT [dbo].[Urun] ([urunID], [turID], [ad], [resim], [fiyat]) VALUES (5, 1, N'Çikolata', N'C:\Users\Asım Mutlu\Desktop\SinemaOtomasyonu\Yiyecek İçecek Resimler\cikolata.png', 6.0000)
INSERT [dbo].[Urun] ([urunID], [turID], [ad], [resim], [fiyat]) VALUES (6, 1, N'Dondurma', N'C:\Users\Asım Mutlu\Desktop\SinemaOtomasyonu\Yiyecek İçecek Resimler\Dondurma.png', 6.0000)
INSERT [dbo].[Urun] ([urunID], [turID], [ad], [resim], [fiyat]) VALUES (7, 2, N'Çay', N'C:\Users\Asım Mutlu\Desktop\SinemaOtomasyonu\Yiyecek İçecek Resimler\cay.png', 5.0000)
INSERT [dbo].[Urun] ([urunID], [turID], [ad], [resim], [fiyat]) VALUES (8, 2, N'Kola', N'C:\Users\Asım Mutlu\Desktop\SinemaOtomasyonu\Yiyecek İçecek Resimler\kola.png', 8.0000)
INSERT [dbo].[Urun] ([urunID], [turID], [ad], [resim], [fiyat]) VALUES (9, 2, N'Monster', N'C:\Users\Asım Mutlu\Desktop\SinemaOtomasyonu\Yiyecek İçecek Resimler\monster.png', 8.0000)
INSERT [dbo].[Urun] ([urunID], [turID], [ad], [resim], [fiyat]) VALUES (10, 2, N'Soda', N'C:\Users\Asım Mutlu\Desktop\SinemaOtomasyonu\Yiyecek İçecek Resimler\soda.png', 7.0000)
INSERT [dbo].[Urun] ([urunID], [turID], [ad], [resim], [fiyat]) VALUES (11, 2, N'Fanta', N'C:\Users\Asım Mutlu\Desktop\SinemaOtomasyonu\Yiyecek İçecek Resimler\Fanta.png', 8.0000)
INSERT [dbo].[Urun] ([urunID], [turID], [ad], [resim], [fiyat]) VALUES (12, 2, N'Su', N'C:\Users\Asım Mutlu\Desktop\SinemaOtomasyonu\Yiyecek İçecek Resimler\su.png', 4.0000)
SET IDENTITY_INSERT [dbo].[Urun] OFF
GO
SET IDENTITY_INSERT [dbo].[Yetki] ON 

INSERT [dbo].[Yetki] ([yetkilD], [yetkiAd]) VALUES (1, N'Admin')
INSERT [dbo].[Yetki] ([yetkilD], [yetkiAd]) VALUES (2, N'Musteri')
SET IDENTITY_INSERT [dbo].[Yetki] OFF
GO
ALTER TABLE [dbo].[AdisyonDetay]  WITH CHECK ADD  CONSTRAINT [FK_AdisyonDetay_Adisyon] FOREIGN KEY([adisyonID])
REFERENCES [dbo].[Adisyon] ([AdisyonID])
GO
ALTER TABLE [dbo].[AdisyonDetay] CHECK CONSTRAINT [FK_AdisyonDetay_Adisyon]
GO
ALTER TABLE [dbo].[AdisyonDetay]  WITH CHECK ADD  CONSTRAINT [FK_AdisyonDetay_Urun] FOREIGN KEY([urunID])
REFERENCES [dbo].[Urun] ([urunID])
GO
ALTER TABLE [dbo].[AdisyonDetay] CHECK CONSTRAINT [FK_AdisyonDetay_Urun]
GO
ALTER TABLE [dbo].[Bilet]  WITH CHECK ADD  CONSTRAINT [FK_Bilet_Seans] FOREIGN KEY([seansID])
REFERENCES [dbo].[Seans] ([seansID])
GO
ALTER TABLE [dbo].[Bilet] CHECK CONSTRAINT [FK_Bilet_Seans]
GO
ALTER TABLE [dbo].[Film]  WITH CHECK ADD  CONSTRAINT [FK_Film_FilmTur] FOREIGN KEY([filmTurID])
REFERENCES [dbo].[FilmTur] ([filmTurID])
GO
ALTER TABLE [dbo].[Film] CHECK CONSTRAINT [FK_Film_FilmTur]
GO
ALTER TABLE [dbo].[Kullanici]  WITH CHECK ADD  CONSTRAINT [FK_Kullanici_Yetki] FOREIGN KEY([yetkiID])
REFERENCES [dbo].[Yetki] ([yetkilD])
GO
ALTER TABLE [dbo].[Kullanici] CHECK CONSTRAINT [FK_Kullanici_Yetki]
GO
ALTER TABLE [dbo].[Seans]  WITH CHECK ADD  CONSTRAINT [FK_Seans_Film] FOREIGN KEY([filmID])
REFERENCES [dbo].[Film] ([filmID])
GO
ALTER TABLE [dbo].[Seans] CHECK CONSTRAINT [FK_Seans_Film]
GO
ALTER TABLE [dbo].[Seans]  WITH CHECK ADD  CONSTRAINT [FK_Seans_Salon] FOREIGN KEY([salonID])
REFERENCES [dbo].[Salon] ([salonID])
GO
ALTER TABLE [dbo].[Seans] CHECK CONSTRAINT [FK_Seans_Salon]
GO
