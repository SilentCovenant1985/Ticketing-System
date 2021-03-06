USE [master]
GO
/****** Object:  Database [TicketingSystem]    Script Date: 11/13/2016 8:15:43 AM ******/
CREATE DATABASE [TicketingSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TicketingSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\TicketingSystem.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TicketingSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\TicketingSystem_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TicketingSystem] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TicketingSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TicketingSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TicketingSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TicketingSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TicketingSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TicketingSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [TicketingSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TicketingSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TicketingSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TicketingSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TicketingSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TicketingSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TicketingSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TicketingSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TicketingSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TicketingSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TicketingSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TicketingSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TicketingSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TicketingSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TicketingSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TicketingSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TicketingSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TicketingSystem] SET RECOVERY FULL 
GO
ALTER DATABASE [TicketingSystem] SET  MULTI_USER 
GO
ALTER DATABASE [TicketingSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TicketingSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TicketingSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TicketingSystem] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [TicketingSystem] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'TicketingSystem', N'ON'
GO
USE [TicketingSystem]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 11/13/2016 8:15:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [varchar](50) NOT NULL,
	[CategoryDescription] [varchar](1000) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Events]    Script Date: 11/13/2016 8:15:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Events](
	[EventID] [int] IDENTITY(1,1) NOT NULL,
	[EventDate] [datetime] NOT NULL,
	[RequestStatusChange] [varchar](50) NOT NULL,
	[RequestDescription] [varchar](1000) NOT NULL,
	[EventDescription] [varchar](1000) NOT NULL,
	[Requests_RequestID] [int] NOT NULL,
 CONSTRAINT [PK_Events] PRIMARY KEY CLUSTERED 
(
	[EventID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Requests]    Script Date: 11/13/2016 8:15:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Requests](
	[RequestID] [int] IDENTITY(1,1) NOT NULL,
	[TrackingNumber] [varchar](50) NOT NULL,
	[InitialDescription] [varchar](1000) NOT NULL,
	[RequestStatus] [varchar](50) NOT NULL,
	[DateSubmitted] [datetime] NOT NULL,
	[AttachmentFileName] [varchar](200) NULL,
	[Users_UserID] [int] NOT NULL,
	[Categories_CategoryID] [int] NOT NULL,
 CONSTRAINT [PK_Requests] PRIMARY KEY CLUSTERED 
(
	[RequestID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Users]    Script Date: 11/13/2016 8:15:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Phone] [varchar](50) NOT NULL,
	[Company] [varchar](50) NOT NULL,
	[UserType] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [CategoryDescription]) VALUES (1, N'Technical', N'Technical Issue')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [CategoryDescription]) VALUES (2, N'Product Defect', N'Product Defect')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [CategoryDescription]) VALUES (3, N'Billing Issue', N'Billing Issue')
SET IDENTITY_INSERT [dbo].[Categories] OFF

SET IDENTITY_INSERT [dbo].[Requests] ON 
INSERT [dbo].[Requests] ([RequestID], [TrackingNumber], [InitialDescription], [RequestStatus], [DateSubmitted], [AttachmentFileName], [Users_UserID], [Categories_CategoryID]) VALUES (1, N'809c6e28-c695-43b9-a10a-812437bfea34', N'hello', N'open', CAST(N'2016-11-13 00:00:00.000' AS DateTime), N'', 2, 3)
INSERT [dbo].[Requests] ([RequestID], [TrackingNumber], [InitialDescription], [RequestStatus], [DateSubmitted], [AttachmentFileName], [Users_UserID], [Categories_CategoryID]) VALUES (2, N'd2d121b5-b308-4769-a54a-eefa17c052f2', N'fdsfdfsd', N'closed', CAST(N'2016-11-13 00:00:00.000' AS DateTime), N'', 2, 2)
SET IDENTITY_INSERT [dbo].[Requests] OFF

SET IDENTITY_INSERT [dbo].[Users] ON 
INSERT [dbo].[Users] ([UserID], [Username], [Password], [Name], [Email], [Phone], [Company], [UserType]) VALUES (1, N'vladimir', N'vladimir', N'vladimir', N'vladimir@gmail.com', N' â@', N'accenture', N'admin')
SET IDENTITY_INSERT [dbo].[Users] OFF
SET ANSI_PADDING ON

GO

ALTER TABLE [dbo].[Events]  WITH CHECK ADD  CONSTRAINT [FK_Events_Requests] FOREIGN KEY([Requests_RequestID])
REFERENCES [dbo].[Requests] ([RequestID])
GO
ALTER TABLE [dbo].[Events] CHECK CONSTRAINT [FK_Events_Requests]
GO
ALTER TABLE [dbo].[Requests]  WITH CHECK ADD  CONSTRAINT [FK_Requests_Categories] FOREIGN KEY([Categories_CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
GO
ALTER TABLE [dbo].[Requests] CHECK CONSTRAINT [FK_Requests_Categories]
GO
ALTER TABLE [dbo].[Requests]  WITH CHECK ADD  CONSTRAINT [FK_Requests_Users] FOREIGN KEY([Users_UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Requests] CHECK CONSTRAINT [FK_Requests_Users]
GO
USE [master]
GO
ALTER DATABASE [TicketingSystem] SET  READ_WRITE 
GO
