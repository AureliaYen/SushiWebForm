USE [master]
GO
/****** Object:  Database [Sushi]    Script Date: 2023/4/26 下午 06:05:15 ******/
CREATE DATABASE [Sushi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Sushi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Sushi.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Sushi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Sushi_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Sushi] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Sushi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Sushi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Sushi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Sushi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Sushi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Sushi] SET ARITHABORT OFF 
GO
ALTER DATABASE [Sushi] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Sushi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Sushi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Sushi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Sushi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Sushi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Sushi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Sushi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Sushi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Sushi] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Sushi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Sushi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Sushi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Sushi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Sushi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Sushi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Sushi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Sushi] SET RECOVERY FULL 
GO
ALTER DATABASE [Sushi] SET  MULTI_USER 
GO
ALTER DATABASE [Sushi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Sushi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Sushi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Sushi] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Sushi] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Sushi] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Sushi', N'ON'
GO
ALTER DATABASE [Sushi] SET QUERY_STORE = OFF
GO
USE [Sushi]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 2023/4/26 下午 06:05:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[ID] [int] IDENTITY(100001,1) NOT NULL,
	[姓名] [nvarchar](100) NULL,
	[電話] [nvarchar](10) NULL,
	[Email] [nvarchar](100) NULL,
	[生日] [date] NULL,
	[會員點數] [int] NULL,
	[類別] [nvarchar](10) NULL,
 CONSTRAINT [PK_Member] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderHistory]    Script Date: 2023/4/26 下午 06:05:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderHistory](
	[訂單編號] [int] IDENTITY(1,1) NOT NULL,
	[會員ID] [int] NULL,
	[會員名稱] [nvarchar](10) NULL,
	[商品名稱] [nvarchar](10) NULL,
	[商品價格] [int] NULL,
	[商品數量] [int] NULL,
	[訂購時間] [datetime] NULL,
 CONSTRAINT [PK_OrderHistory] PRIMARY KEY CLUSTERED 
(
	[訂單編號] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 2023/4/26 下午 06:05:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[pid] [int] IDENTITY(1,1) NOT NULL,
	[pname] [nvarchar](100) NULL,
	[price] [int] NULL,
	[pdesc] [nvarchar](100) NULL,
	[pimage] [nvarchar](100) NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[pid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Member] ON 

INSERT [dbo].[Member] ([ID], [姓名], [電話], [Email], [生日], [會員點數], [類別]) VALUES (100001, N'管理員', N'0912345678', N'test@gmail.com', CAST(N'1997-04-23' AS Date), 100, N'程式管理員')
INSERT [dbo].[Member] ([ID], [姓名], [電話], [Email], [生日], [會員點數], [類別]) VALUES (100002, N'店長', N'0912345679', N'boss@gmail.com', CAST(N'1992-02-28' AS Date), 50, N'管理職')
INSERT [dbo].[Member] ([ID], [姓名], [電話], [Email], [生日], [會員點數], [類別]) VALUES (100003, N'店員', N'0912345670', N'member@gmail.com', CAST(N'1995-07-31' AS Date), 50, N'員工')
INSERT [dbo].[Member] ([ID], [姓名], [電話], [Email], [生日], [會員點數], [類別]) VALUES (100004, N'張開心', N'0912345671', N'chang@gmail.com', CAST(N'1985-03-23' AS Date), 30, N'一般會員')
INSERT [dbo].[Member] ([ID], [姓名], [電話], [Email], [生日], [會員點數], [類別]) VALUES (100007, N'Yen', N'0912345678', N'123', CAST(N'2022-12-18' AS Date), 100, N'程式管理員')
INSERT [dbo].[Member] ([ID], [姓名], [電話], [Email], [生日], [會員點數], [類別]) VALUES (100009, N'Arelia', N'0911223344', N'123', CAST(N'2022-12-18' AS Date), 100, N'一般會員')
INSERT [dbo].[Member] ([ID], [姓名], [電話], [Email], [生日], [會員點數], [類別]) VALUES (100010, N'ㄖ', N'0915166588', N'123', CAST(N'2022-12-18' AS Date), 100, N'一般會員')
SET IDENTITY_INSERT [dbo].[Member] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderHistory] ON 

INSERT [dbo].[OrderHistory] ([訂單編號], [會員ID], [會員名稱], [商品名稱], [商品價格], [商品數量], [訂購時間]) VALUES (1, 100001, N'管理員', N'炙烤鮭魚肚', 80, 2, CAST(N'2022-12-18T17:27:22.713' AS DateTime))
INSERT [dbo].[OrderHistory] ([訂單編號], [會員ID], [會員名稱], [商品名稱], [商品價格], [商品數量], [訂購時間]) VALUES (2, 100001, N'管理員', N'鮭魚', 40, 1, CAST(N'2022-12-18T17:28:58.087' AS DateTime))
INSERT [dbo].[OrderHistory] ([訂單編號], [會員ID], [會員名稱], [商品名稱], [商品價格], [商品數量], [訂購時間]) VALUES (4, 100007, N'Yen', N'抹茶牛奶綜合霜淇淋', 40, 1, CAST(N'2022-12-18T19:01:03.993' AS DateTime))
INSERT [dbo].[OrderHistory] ([訂單編號], [會員ID], [會員名稱], [商品名稱], [商品價格], [商品數量], [訂購時間]) VALUES (5, 100004, N'張開心', N'鮪魚大腹', 80, 1, CAST(N'2022-12-18T19:44:53.203' AS DateTime))
INSERT [dbo].[OrderHistory] ([訂單編號], [會員ID], [會員名稱], [商品名稱], [商品價格], [商品數量], [訂購時間]) VALUES (6, 100007, N'Yen', N'炙烤鹽味生鮭', 60, 1, CAST(N'2022-12-18T20:06:00.103' AS DateTime))
INSERT [dbo].[OrderHistory] ([訂單編號], [會員ID], [會員名稱], [商品名稱], [商品價格], [商品數量], [訂購時間]) VALUES (7, 100009, N'Arelia', N'生鮭魚', 60, 1, CAST(N'2022-12-18T20:28:40.913' AS DateTime))
INSERT [dbo].[OrderHistory] ([訂單編號], [會員ID], [會員名稱], [商品名稱], [商品價格], [商品數量], [訂購時間]) VALUES (8, 100009, N'Arelia', N'生鮭魚', 60, 1, CAST(N'2022-12-18T20:33:35.533' AS DateTime))
INSERT [dbo].[OrderHistory] ([訂單編號], [會員ID], [會員名稱], [商品名稱], [商品價格], [商品數量], [訂購時間]) VALUES (9, 100009, N'Arelia', N'北海道牛奶霜淇淋', 40, 1, CAST(N'2022-12-18T20:33:45.473' AS DateTime))
INSERT [dbo].[OrderHistory] ([訂單編號], [會員ID], [會員名稱], [商品名稱], [商品價格], [商品數量], [訂購時間]) VALUES (10, 100007, N'Yen', N'炙燒羅勒鮭魚', 40, 1, CAST(N'2022-12-18T21:39:48.940' AS DateTime))
INSERT [dbo].[OrderHistory] ([訂單編號], [會員ID], [會員名稱], [商品名稱], [商品價格], [商品數量], [訂購時間]) VALUES (11, 100007, N'Yen', N'鮪魚大腹', 80, 1, CAST(N'2022-12-18T21:41:08.420' AS DateTime))
INSERT [dbo].[OrderHistory] ([訂單編號], [會員ID], [會員名稱], [商品名稱], [商品價格], [商品數量], [訂購時間]) VALUES (12, 100007, N'Yen', N'千層蛋糕', 60, 1, CAST(N'2022-12-18T21:41:12.243' AS DateTime))
INSERT [dbo].[OrderHistory] ([訂單編號], [會員ID], [會員名稱], [商品名稱], [商品價格], [商品數量], [訂購時間]) VALUES (13, 100007, N'Yen', N'鮪魚沙拉軍艦', 40, 1, CAST(N'2022-12-18T21:41:18.567' AS DateTime))
INSERT [dbo].[OrderHistory] ([訂單編號], [會員ID], [會員名稱], [商品名稱], [商品價格], [商品數量], [訂購時間]) VALUES (14, 100007, N'Yen', N'甜蝦軍艦', 40, 1, CAST(N'2022-12-18T21:41:22.667' AS DateTime))
INSERT [dbo].[OrderHistory] ([訂單編號], [會員ID], [會員名稱], [商品名稱], [商品價格], [商品數量], [訂購時間]) VALUES (15, 100007, N'Yen', N'抹茶牛奶綜合霜淇淋', 40, 1, CAST(N'2022-12-18T21:41:26.570' AS DateTime))
INSERT [dbo].[OrderHistory] ([訂單編號], [會員ID], [會員名稱], [商品名稱], [商品價格], [商品數量], [訂購時間]) VALUES (16, 100007, N'Yen', N'玉子', 40, 1, CAST(N'2022-12-18T21:41:34.063' AS DateTime))
INSERT [dbo].[OrderHistory] ([訂單編號], [會員ID], [會員名稱], [商品名稱], [商品價格], [商品數量], [訂購時間]) VALUES (17, 100007, N'Yen', N'毛豆', 40, 1, CAST(N'2022-12-18T21:41:42.927' AS DateTime))
INSERT [dbo].[OrderHistory] ([訂單編號], [會員ID], [會員名稱], [商品名稱], [商品價格], [商品數量], [訂購時間]) VALUES (18, 100007, N'Yen', N'檸檬羅勒鳥貝', 40, 1, CAST(N'2022-12-18T21:41:47.050' AS DateTime))
INSERT [dbo].[OrderHistory] ([訂單編號], [會員ID], [會員名稱], [商品名稱], [商品價格], [商品數量], [訂購時間]) VALUES (19, 100007, N'Yen', N'雪碧', 40, 1, CAST(N'2022-12-18T21:42:58.377' AS DateTime))
INSERT [dbo].[OrderHistory] ([訂單編號], [會員ID], [會員名稱], [商品名稱], [商品價格], [商品數量], [訂購時間]) VALUES (20, 100010, N'ㄖ', N'鮭魚', 40, 1, CAST(N'2022-12-18T21:44:59.933' AS DateTime))
INSERT [dbo].[OrderHistory] ([訂單編號], [會員ID], [會員名稱], [商品名稱], [商品價格], [商品數量], [訂購時間]) VALUES (21, 100001, N'管理員', N'醬烤日本產貝柱', 60, 1, CAST(N'2023-04-26T17:49:57.833' AS DateTime))
INSERT [dbo].[OrderHistory] ([訂單編號], [會員ID], [會員名稱], [商品名稱], [商品價格], [商品數量], [訂購時間]) VALUES (22, 100001, N'管理員', N'鮪魚大腹', 80, 1, CAST(N'2023-04-26T17:50:42.310' AS DateTime))
INSERT [dbo].[OrderHistory] ([訂單編號], [會員ID], [會員名稱], [商品名稱], [商品價格], [商品數量], [訂購時間]) VALUES (23, 100001, N'管理員', N'醬烤日本產貝柱', 60, 1, CAST(N'2023-04-26T17:51:47.843' AS DateTime))
SET IDENTITY_INSERT [dbo].[OrderHistory] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (1, N'鮭魚', 40, N'經典原味鮭魚', N'salmon_1.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (2, N'炙烤鮭魚肚', 40, N'現烤炙烤鮭魚肚', N'salmon_2.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (3, N'生鮭魚', 60, N'後切大塊鮭魚', N'salmon_3.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (4, N'炙烤鹽味生鮭', 60, N'後切炙烤鹽味生鮭', N'202212181822051621.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (5, N'炙燒羅勒鮭魚', 40, N'炙燒羅勒鮭魚', N'202212181824374752.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (6, N'鮪魚大腹', 80, N'鮪魚大腹', N'202212181825412847.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (7, N'鮪魚中腹', 60, N'鮪魚中腹', N'202212181825598747.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (8, N'醃漬鮪魚', 40, N'醃漬鮪魚', N'202212181826146394.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (9, N'醬烤日本產貝柱', 60, N'醬烤日本產貝柱', N'202212181826376534.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (10, N'日本產貝柱', 60, N'日本產貝柱', N'202212181826537321.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (11, N'鮮蝦', 40, N'鮮蝦', N'202212181828134004.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (12, N'麻辣赤蝦', 40, N'麻辣赤蝦', N'202212181828301749.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (13, N'炙燒起司鮮蝦', 40, N'炙燒起司鮮蝦', N'202212181828584943.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (14, N'炙燒羅勒鮮蝦', 40, N'炙燒羅勒鮮蝦', N'202212181829071636.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (15, N'鮮蝦3貫', 60, N'鮮蝦3貫', N'202212181829161059.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (16, N'鮮蝦天婦羅', 60, N'鮮蝦天婦羅', N'202212181829555245.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (17, N'花枝', 40, N'花枝', N'202212181830234895.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (18, N'北寄貝', 40, N'北寄貝', N'202212181830542985.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (19, N'鰈魚鰭緣', 40, N'鰈魚鰭緣', N'202212181831168798.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (20, N'玉子', 40, N'玉子', N'202212181831297917.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (21, N'甜蝦軍艦', 40, N'甜蝦軍艦', N'202212181831452775.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (22, N'鮭魚卵軍艦', 40, N'鮭魚卵軍艦', N'202212181831575496.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (23, N'小黃瓜飛魚卵軍艦', 40, N'小黃瓜飛魚卵軍艦', N'202212181832115556.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (24, N'漬鯡魚卵軍艦', 40, N'漬鯡魚卵軍艦', N'202212181832243232.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (25, N'鮪魚沙拉軍艦', 40, N'鮪魚沙拉軍艦

', N'202212181832356609.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (26, N'蔥花鮪魚軍艦', 40, N'蔥花鮪魚軍艦
', N'202212181832496386.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (27, N'蟹膏軍艦', 40, N'蟹膏軍艦
', N'202212181832593491.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (28, N'玉米沙拉軍艦', 40, N'玉米沙拉軍艦', N'202212181833126968.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (29, N'蟹肉蟹膏軍艦', 60, N'蟹肉蟹膏軍艦', N'202212181833251002.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (30, N'鱈魚子沙拉軍艦', 60, N'鱈魚子沙拉軍艦', N'202212181833407432.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (31, N'可爾必思水語', 40, N'可爾必思水語', N'202212181834079242.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (32, N'雪碧', 40, N'雪碧', N'202212181834211932.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (33, N'紀州產南高梅梅酒', 90, N'紀州產南高梅梅酒', N'202212181834326752.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (34, N'日本清酒', 140, N'日本清酒', N'202212181835122351.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (35, N'三得利頂級啤酒', 110, N'三得利頂級啤酒', N'202212181836253283.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (36, N'黃金脆薯', 40, N'黃金脆薯', N'202212181836412313.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (37, N'毛豆', 40, N'毛豆', N'202212181836554130.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (38, N'酥炸莫札瑞拉起司條', 60, N'酥炸莫札瑞拉起司條', N'202212181837149404.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (39, N'北海道牛奶霜淇淋', 40, N'北海道牛奶霜淇淋', N'202212181837292005.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (40, N'抹茶牛奶綜合霜淇淋', 40, N'抹茶牛奶綜合霜淇淋', N'202212181837423224.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (41, N'濃厚巧克力鮮奶油蛋糕', 60, N'濃厚巧克力鮮奶油蛋糕', N'202212181837552244.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (42, N'千層蛋糕', 60, N'千層蛋糕', N'202212181838094876.png')
INSERT [dbo].[Products] ([pid], [pname], [price], [pdesc], [pimage]) VALUES (43, N'檸檬羅勒鳥貝', 40, N'檸檬羅勒鳥貝', N'202212182116283154.png')
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
USE [master]
GO
ALTER DATABASE [Sushi] SET  READ_WRITE 
GO
