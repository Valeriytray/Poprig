USE [master]
GO
/****** Object:  Database [drivers]    Script Date: 06.12.2021 13:16:47 ******/
CREATE DATABASE [drivers]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'drivers', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\drivers.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'drivers_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\drivers_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [drivers] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [drivers].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [drivers] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [drivers] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [drivers] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [drivers] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [drivers] SET ARITHABORT OFF 
GO
ALTER DATABASE [drivers] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [drivers] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [drivers] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [drivers] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [drivers] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [drivers] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [drivers] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [drivers] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [drivers] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [drivers] SET  DISABLE_BROKER 
GO
ALTER DATABASE [drivers] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [drivers] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [drivers] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [drivers] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [drivers] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [drivers] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [drivers] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [drivers] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [drivers] SET  MULTI_USER 
GO
ALTER DATABASE [drivers] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [drivers] SET DB_CHAINING OFF 
GO
ALTER DATABASE [drivers] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [drivers] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [drivers] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [drivers] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [drivers] SET QUERY_STORE = OFF
GO
USE [drivers]
GO
/****** Object:  Table [dbo].[Autorisation]    Script Date: 06.12.2021 13:16:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Autorisation](
	[Login] [nvarchar](20) NOT NULL,
	[Password] [nvarchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Drivers]    Script Date: 06.12.2021 13:16:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Drivers](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NULL,
	[middlename] [nvarchar](50) NULL,
	[passport serial] [int] NULL,
	[passport number] [int] NULL,
	[postcode] [nvarchar](255) NULL,
	[address] [nvarchar](255) NULL,
	[address life] [nvarchar](255) NULL,
	[company] [nvarchar](255) NULL,
	[jobname] [nvarchar](255) NULL,
	[phone] [nvarchar](20) NULL,
	[email] [nvarchar](255) NULL,
	[photo] [nvarchar](255) NULL,
	[description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Drivers] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[License]    Script Date: 06.12.2021 13:16:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[License](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NULL,
	[middlename] [nvarchar](50) NULL,
	[passport serial] [int] NULL,
	[passport number] [int] NULL,
	[postcode] [nvarchar](255) NULL,
	[address] [nvarchar](255) NULL,
	[address life] [nvarchar](255) NULL,
	[company] [nvarchar](255) NULL,
	[jobname] [nvarchar](255) NULL,
	[phone] [nvarchar](20) NULL,
	[email] [nvarchar](255) NULL,
	[photo] [nvarchar](255) NULL,
	[description] [nvarchar](max) NULL,
	[licence date] [date] NULL,
	[expire date] [date] NULL,
	[categories] [nvarchar](255) NULL,
	[licence series] [int] NULL,
	[licence number] [int] NULL,
	[Status] [nvarchar](255) NULL,
	[VIN] [nvarchar](255) NULL,
	[Manufacturer] [nvarchar](255) NULL,
	[Model] [nvarchar](255) NULL,
	[Year] [int] NULL,
	[Weight] [int] NULL,
	[Color] [nvarchar](255) NULL,
	[Engine Type] [int] NULL,
	[type of drive] [nvarchar](20) NULL,
 CONSTRAINT [PK_License] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[License]  WITH CHECK ADD  CONSTRAINT [FK_License_Drivers] FOREIGN KEY([id])
REFERENCES [dbo].[Drivers] ([id])
GO
ALTER TABLE [dbo].[License] CHECK CONSTRAINT [FK_License_Drivers]
GO
USE [master]
GO
ALTER DATABASE [drivers] SET  READ_WRITE 
GO
