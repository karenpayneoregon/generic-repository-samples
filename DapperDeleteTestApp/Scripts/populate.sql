USE [master]
GO
/****** Object:  Database [Bogus1]    Script Date: 1/21/2024 3:47:43 AM ******/
CREATE DATABASE [Bogus1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Bogus1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Bogus1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Bogus1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Bogus1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Bogus1] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Bogus1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Bogus1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Bogus1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Bogus1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Bogus1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Bogus1] SET ARITHABORT OFF 
GO
ALTER DATABASE [Bogus1] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Bogus1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Bogus1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Bogus1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Bogus1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Bogus1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Bogus1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Bogus1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Bogus1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Bogus1] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Bogus1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Bogus1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Bogus1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Bogus1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Bogus1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Bogus1] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [Bogus1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Bogus1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Bogus1] SET  MULTI_USER 
GO
ALTER DATABASE [Bogus1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Bogus1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Bogus1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Bogus1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Bogus1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Bogus1] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Bogus1] SET QUERY_STORE = OFF
GO
USE [Bogus1]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 1/21/2024 3:47:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](max) NULL,
	[Category] [nvarchar](max) NULL,
	[Price] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([Id], [ProductName], [Category], [Price]) VALUES (1, N'Ergonomic Granite Car', N'Music', CAST(50 AS Decimal(18, 0)))
INSERT [dbo].[Product] ([Id], [ProductName], [Category], [Price]) VALUES (2, N'Licensed Plastic Pants', N'Books', CAST(50 AS Decimal(18, 0)))
INSERT [dbo].[Product] ([Id], [ProductName], [Category], [Price]) VALUES (3, N'Licensed Rubber Sausages', N'Movies', CAST(51 AS Decimal(18, 0)))
INSERT [dbo].[Product] ([Id], [ProductName], [Category], [Price]) VALUES (4, N'Ergonomic Steel Pizza', N'Home', CAST(57 AS Decimal(18, 0)))
INSERT [dbo].[Product] ([Id], [ProductName], [Category], [Price]) VALUES (5, N'Rustic Soft Chair', N'Home', CAST(50 AS Decimal(18, 0)))
INSERT [dbo].[Product] ([Id], [ProductName], [Category], [Price]) VALUES (6, N'Fantastic Concrete Towels', N'Baby', CAST(52 AS Decimal(18, 0)))
INSERT [dbo].[Product] ([Id], [ProductName], [Category], [Price]) VALUES (7, N'Handmade Wooden Gloves', N'Automotive', CAST(57 AS Decimal(18, 0)))
INSERT [dbo].[Product] ([Id], [ProductName], [Category], [Price]) VALUES (8, N'Handcrafted Granite Bacon', N'Outdoors', CAST(51 AS Decimal(18, 0)))
INSERT [dbo].[Product] ([Id], [ProductName], [Category], [Price]) VALUES (9, N'Licensed Wooden Hat', N'Baby', CAST(50 AS Decimal(18, 0)))
INSERT [dbo].[Product] ([Id], [ProductName], [Category], [Price]) VALUES (10, N'Unbranded Soft Table', N'Electronics', CAST(49 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Primary key' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Product', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Product name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Product', @level2type=N'COLUMN',@level2name=N'ProductName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Product category' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Product', @level2type=N'COLUMN',@level2name=N'Category'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Retail price' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Product', @level2type=N'COLUMN',@level2name=N'Price'
GO
USE [master]
GO
ALTER DATABASE [Bogus1] SET  READ_WRITE 
GO
