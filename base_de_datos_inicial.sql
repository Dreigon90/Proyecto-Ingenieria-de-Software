USE [master]
GO
/****** Object:  Database [GestionCanchas]    Script Date: 3/7/2026 20:43:20 ******/
CREATE DATABASE [GestionCanchas]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GestionCanchas', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\GestionCanchas.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GestionCanchas_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\GestionCanchas_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [GestionCanchas] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GestionCanchas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GestionCanchas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GestionCanchas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GestionCanchas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GestionCanchas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GestionCanchas] SET ARITHABORT OFF 
GO
ALTER DATABASE [GestionCanchas] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GestionCanchas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GestionCanchas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GestionCanchas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GestionCanchas] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GestionCanchas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GestionCanchas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GestionCanchas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GestionCanchas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GestionCanchas] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GestionCanchas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GestionCanchas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GestionCanchas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GestionCanchas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GestionCanchas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GestionCanchas] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GestionCanchas] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GestionCanchas] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GestionCanchas] SET  MULTI_USER 
GO
ALTER DATABASE [GestionCanchas] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GestionCanchas] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GestionCanchas] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GestionCanchas] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GestionCanchas] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GestionCanchas] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [GestionCanchas] SET QUERY_STORE = ON
GO
ALTER DATABASE [GestionCanchas] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [GestionCanchas]
GO
/****** Object:  Table [dbo].[AuditoriaUsuarios]    Script Date: 3/7/2026 20:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AuditoriaUsuarios](
	[IdAuditoria] [int] IDENTITY(1,1) NOT NULL,
	[UsuarioId] [int] NOT NULL,
	[EmailAnterior] [varchar](100) NOT NULL,
	[EmailActual] [varchar](100) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[ModificadoPor] [varchar](50) NOT NULL,
	[Accion] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdAuditoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 3/7/2026 20:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bitacora](
	[id_bitacora] [int] IDENTITY(1,1) NOT NULL,
	[id_usuario] [int] NOT NULL,
	[mensaje] [varchar](255) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[estado] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_bitacora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Etiqueta]    Script Date: 3/7/2026 20:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Etiqueta](
	[IdEtiqueta] [int] IDENTITY(1,1) NOT NULL,
	[Clave] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdEtiqueta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Idioma]    Script Date: 3/7/2026 20:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Idioma](
	[IdIdioma] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdIdioma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permiso]    Script Date: 3/7/2026 20:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permiso](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Tipo] [nvarchar](50) NULL,
 CONSTRAINT [PK__Permiso__3214EC0742C435A4] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permiso_Permiso]    Script Date: 3/7/2026 20:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permiso_Permiso](
	[Id_Permiso_Padre] [int] NOT NULL,
	[Id_Permiso_Hijo] [int] NOT NULL,
 CONSTRAINT [PK_Permiso_Permiso] PRIMARY KEY CLUSTERED 
(
	[Id_Permiso_Padre] ASC,
	[Id_Permiso_Hijo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Traduccion]    Script Date: 3/7/2026 20:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Traduccion](
	[IdTraduccion] [int] IDENTITY(1,1) NOT NULL,
	[IdIdioma] [int] NOT NULL,
	[IdEtiqueta] [int] NOT NULL,
	[Texto] [nvarchar](250) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdTraduccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 3/7/2026 20:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](255) NOT NULL,
	[Telefono] [varchar](30) NULL,
	[Email] [varchar](150) NULL,
	[IdIdioma] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario_Permiso]    Script Date: 3/7/2026 20:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario_Permiso](
	[Id_Usuario] [int] NOT NULL,
	[Id_Permiso] [int] NOT NULL,
 CONSTRAINT [PK_Usuario_Permiso] PRIMARY KEY CLUSTERED 
(
	[Id_Usuario] ASC,
	[Id_Permiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AuditoriaUsuarios] ON 

INSERT [dbo].[AuditoriaUsuarios] ([IdAuditoria], [UsuarioId], [EmailAnterior], [EmailActual], [Fecha], [ModificadoPor], [Accion]) VALUES (3, 2, N'seba@gmail.com', N'sebastian@gmail.com', CAST(N'2026-07-01T00:08:10.907' AS DateTime), N'admin', N'Modificación Email')
INSERT [dbo].[AuditoriaUsuarios] ([IdAuditoria], [UsuarioId], [EmailAnterior], [EmailActual], [Fecha], [ModificadoPor], [Accion]) VALUES (4, 2, N'seba@gmail.com', N'seba.martin@gmail.com', CAST(N'2026-07-01T00:13:45.187' AS DateTime), N'admin', N'Modificación Email')
INSERT [dbo].[AuditoriaUsuarios] ([IdAuditoria], [UsuarioId], [EmailAnterior], [EmailActual], [Fecha], [ModificadoPor], [Accion]) VALUES (5, 2, N'seba.martin@gmail.com', N'seba.martin90@gmail.com', CAST(N'2026-07-01T00:14:09.413' AS DateTime), N'admin', N'Modificación Email')
INSERT [dbo].[AuditoriaUsuarios] ([IdAuditoria], [UsuarioId], [EmailAnterior], [EmailActual], [Fecha], [ModificadoPor], [Accion]) VALUES (6, 2, N'seba@gmail.com', N'seba@hotmail.com', CAST(N'2026-07-03T20:22:19.177' AS DateTime), N'admin', N'Modificación Email')
SET IDENTITY_INSERT [dbo].[AuditoriaUsuarios] OFF
GO
SET IDENTITY_INSERT [dbo].[Bitacora] ON 

INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (1, 1, N'Ingreso de usuario', CAST(N'2026-05-08T00:58:14.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (2, 1, N'Ingreso de usuario', CAST(N'2026-05-08T00:58:30.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (3, 1, N'Ingreso de usuario', CAST(N'2026-05-08T00:59:01.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4, 1, N'Ingreso de usuario', CAST(N'2026-05-08T00:59:38.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (5, 1, N'Ingreso de usuario', CAST(N'2026-05-08T01:02:33.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (1002, 1, N'Ingreso de usuario', CAST(N'2026-06-04T01:23:56.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (1003, 1, N'Ingreso de usuario', CAST(N'2026-06-04T01:33:00.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (2002, 1, N'Ingreso de usuario', CAST(N'2026-06-05T20:07:24.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (2003, 1, N'Ingreso de usuario', CAST(N'2026-06-05T20:09:46.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (2004, 1, N'Ingreso de usuario', CAST(N'2026-06-05T20:18:01.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (2005, 1, N'Ingreso de usuario', CAST(N'2026-06-05T22:33:03.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (2006, 1, N'Ingreso de usuario', CAST(N'2026-06-05T22:34:57.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (2007, 1, N'Ingreso de usuario', CAST(N'2026-06-05T22:35:51.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (2008, 1, N'Cierre de sesión', CAST(N'2026-06-05T22:36:10.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (2009, 1, N'Ingreso de usuario', CAST(N'2026-06-05T22:42:41.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (2010, 1, N'Cierre de sesión', CAST(N'2026-06-05T22:42:57.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (2011, 1, N'Ingreso de usuario', CAST(N'2026-06-05T22:46:21.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (2012, 1, N'Ingreso de usuario', CAST(N'2026-06-05T22:53:47.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (2013, 1, N'Ingreso de usuario', CAST(N'2026-06-05T22:54:22.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (2014, 1, N'Ingreso de usuario', CAST(N'2026-06-05T22:56:29.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (2015, 1, N'Ingreso de usuario', CAST(N'2026-06-05T22:59:40.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (2016, 1, N'Cierre de sesión', CAST(N'2026-06-05T23:01:21.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (2017, 1, N'Ingreso de usuario', CAST(N'2026-06-05T23:04:17.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (2018, 1, N'Cierre de sesión', CAST(N'2026-06-05T23:04:52.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (2019, 1, N'Ingreso de usuario', CAST(N'2026-06-06T00:25:34.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (2020, 1, N'Ingreso de usuario', CAST(N'2026-06-06T00:34:02.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (2021, 1, N'Ingreso al módulo Bitácora', CAST(N'2026-06-06T00:34:03.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (2022, 1, N'Ingreso de usuario', CAST(N'2026-06-06T00:35:20.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (2023, 1, N'Ingreso al módulo Bitácora', CAST(N'2026-06-06T00:35:22.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (2024, 1, N'Ingreso de usuario', CAST(N'2026-06-06T00:38:52.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (2025, 1, N'Ingreso al módulo Bitácora', CAST(N'2026-06-06T00:38:57.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (2026, 1, N'Ingreso de usuario', CAST(N'2026-06-06T00:41:46.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (2027, 1, N'Ingreso al módulo Bitácora', CAST(N'2026-06-06T00:41:48.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (2028, 1, N'Ingreso de usuario', CAST(N'2026-06-06T00:42:57.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (2029, 1, N'Ingreso al módulo Bitácora', CAST(N'2026-06-06T00:42:59.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (2030, 1, N'Cierre de sesión', CAST(N'2026-06-06T00:43:14.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (2031, 1, N'Ingreso de usuario', CAST(N'2026-06-06T00:43:29.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (2032, 1, N'Ingreso al módulo Bitácora', CAST(N'2026-06-06T00:43:31.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (2033, 1, N'Ingreso de usuario', CAST(N'2026-06-06T00:50:06.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (2034, 1, N'Ingreso al módulo Bitácora', CAST(N'2026-06-06T00:50:12.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (2035, 1, N'Cierre de sesión', CAST(N'2026-06-06T00:51:02.000' AS DateTime), NULL)
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (3015, 1, N'Ingreso de usuario', CAST(N'2026-06-09T00:44:29.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (3016, 1, N'Ingreso al módulo Bitácora', CAST(N'2026-06-09T00:44:42.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (3017, 1, N'Cierre de sesión', CAST(N'2026-06-09T00:45:10.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4015, 1, N'Ingreso de usuario', CAST(N'2026-06-27T01:32:25.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4016, 1, N'Ingreso al módulo Bitácora', CAST(N'2026-06-27T01:32:31.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4017, 1, N'Ingreso de usuario', CAST(N'2026-06-29T00:12:03.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4018, 1, N'Ingreso de usuario', CAST(N'2026-06-29T00:13:14.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4019, 1, N'Ingreso de usuario', CAST(N'2026-06-29T02:10:05.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4020, 1, N'Ingreso de usuario', CAST(N'2026-06-29T02:11:18.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4021, 1, N'Ingreso de usuario', CAST(N'2026-06-29T23:57:05.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4022, 1, N'Ingreso de usuario', CAST(N'2026-06-30T00:00:00.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4023, 1, N'Cierre de sesión', CAST(N'2026-06-30T00:00:14.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4024, 2, N'Ingreso de usuario', CAST(N'2026-06-30T00:05:50.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4025, 2, N'Ingreso de usuario', CAST(N'2026-06-30T00:12:30.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4026, 2, N'Ingreso de usuario', CAST(N'2026-06-30T00:13:19.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4027, 2, N'Cierre de sesión', CAST(N'2026-06-30T00:14:11.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4028, 2, N'Ingreso de usuario', CAST(N'2026-06-30T00:15:00.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4029, 2, N'Ingreso de usuario', CAST(N'2026-06-30T00:18:52.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4030, 2, N'Ingreso al módulo Bitácora', CAST(N'2026-06-30T00:18:54.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4031, 1, N'Ingreso de usuario', CAST(N'2026-06-30T00:23:11.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4032, 1, N'Ingreso de usuario', CAST(N'2026-06-30T00:44:36.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4033, 1, N'Cierre de sesión', CAST(N'2026-06-30T00:44:45.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4034, 1, N'Ingreso de usuario', CAST(N'2026-06-30T00:45:55.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4035, 1, N'Ingreso de usuario', CAST(N'2026-06-30T00:54:33.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4036, 1, N'Ingreso de usuario', CAST(N'2026-06-30T01:10:38.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4037, 2, N'Ingreso de usuario', CAST(N'2026-06-30T01:13:40.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4038, 2, N'Cierre de sesión', CAST(N'2026-06-30T01:38:38.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4039, 1, N'Ingreso de usuario', CAST(N'2026-06-30T01:39:30.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4040, 1, N'Cierre de sesión', CAST(N'2026-06-30T01:39:31.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4041, 1, N'Ingreso de usuario', CAST(N'2026-06-30T01:44:51.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4042, 1, N'Cierre de sesión', CAST(N'2026-06-30T01:44:52.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4043, 1, N'Ingreso de usuario', CAST(N'2026-06-30T01:44:58.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4044, 1, N'Cierre de sesión', CAST(N'2026-06-30T01:44:58.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4045, 2, N'Ingreso de usuario', CAST(N'2026-06-30T01:45:06.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4046, 2, N'Cierre de sesión', CAST(N'2026-06-30T01:45:08.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4047, 1, N'Ingreso de usuario', CAST(N'2026-06-30T18:37:07.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4048, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-06-30T18:37:10.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4049, 1, N'Modificó el usuario ''seba''', CAST(N'2026-06-30T18:37:52.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4050, 2, N'Ingreso de usuario', CAST(N'2026-06-30T18:42:10.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4051, 2, N'Ingreso al módulo de Auditoría', CAST(N'2026-06-30T18:42:12.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4052, 1, N'Ingreso de usuario', CAST(N'2026-06-30T18:50:58.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4053, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-06-30T18:51:00.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4054, 1, N'Restauró el usuario ''sebastian''', CAST(N'2026-06-30T18:51:24.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4055, 1, N'Ingreso de usuario', CAST(N'2026-06-30T19:08:43.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4056, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-06-30T19:08:44.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4057, 1, N'Ingreso de usuario', CAST(N'2026-06-30T19:15:03.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4058, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-06-30T19:15:04.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4059, 1, N'Ingreso de usuario', CAST(N'2026-06-30T21:27:09.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4060, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-06-30T21:27:11.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4061, 1, N'Ingreso de usuario', CAST(N'2026-06-30T23:02:54.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4062, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-06-30T23:04:35.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4063, 1, N'Ingreso de usuario', CAST(N'2026-06-30T23:11:48.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4064, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-06-30T23:11:50.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4065, 1, N'Ingreso de usuario', CAST(N'2026-06-30T23:14:10.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4066, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-06-30T23:14:12.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4067, 1, N'Ingreso de usuario', CAST(N'2026-06-30T23:14:46.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4068, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-06-30T23:14:47.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4069, 1, N'Ingreso de usuario', CAST(N'2026-06-30T23:17:34.000' AS DateTime), N'INFO')
GO
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4070, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-06-30T23:17:35.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4071, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-06-30T23:17:52.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4072, 1, N'Ingreso de usuario', CAST(N'2026-06-30T23:20:29.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4073, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-06-30T23:20:30.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4074, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-06-30T23:21:50.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4075, 1, N'Ingreso de usuario', CAST(N'2026-06-30T23:31:09.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4076, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-06-30T23:33:56.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4077, 1, N'Ingreso de usuario', CAST(N'2026-06-30T23:48:50.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4078, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-06-30T23:48:53.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4079, 1, N'Ingreso de usuario', CAST(N'2026-06-30T23:50:04.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4080, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-06-30T23:50:05.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4081, 1, N'Ingreso de usuario', CAST(N'2026-06-30T23:53:28.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4082, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-06-30T23:54:25.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4083, 1, N'Ingreso de usuario', CAST(N'2026-06-30T23:58:11.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4084, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-06-30T23:58:12.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4085, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-06-30T23:58:15.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4086, 1, N'Ingreso de usuario', CAST(N'2026-06-30T23:59:55.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4087, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-06-30T23:59:56.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4088, 1, N'Ingreso de usuario', CAST(N'2026-07-01T00:01:49.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4089, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-01T00:01:51.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4090, 1, N'Modificó el usuario ''sebas''', CAST(N'2026-07-01T00:02:26.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4091, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-07-01T00:03:29.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4092, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-01T00:03:35.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4093, 1, N'Modificó el usuario ''sebas''', CAST(N'2026-07-01T00:08:57.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4094, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-07-01T00:09:21.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4095, 1, N'Restauró el email del usuario ID 2', CAST(N'2026-07-01T00:11:52.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4096, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-01T00:12:19.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4097, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-07-01T00:12:59.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4098, 1, N'Restauró el email del usuario ID 2', CAST(N'2026-07-01T00:13:02.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4099, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-01T00:13:06.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4100, 1, N'Modificó el usuario ''sebas''', CAST(N'2026-07-01T00:13:21.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4101, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-07-01T00:13:29.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4102, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-01T00:13:32.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4103, 1, N'Modificó el usuario ''sebas''', CAST(N'2026-07-01T00:13:45.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4104, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-07-01T00:13:48.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4105, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-01T00:14:04.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4106, 1, N'Modificó el usuario ''sebas''', CAST(N'2026-07-01T00:14:09.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4107, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-07-01T00:14:12.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4108, 1, N'Restauró el email del usuario ID 2', CAST(N'2026-07-01T00:14:28.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4109, 1, N'Restauró el email del usuario ID 2', CAST(N'2026-07-01T00:14:31.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4110, 1, N'Restauró el email del usuario ID 2', CAST(N'2026-07-01T00:14:34.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4111, 1, N'Ingreso de usuario', CAST(N'2026-07-01T00:24:34.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4112, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-01T00:24:36.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4113, 1, N'Ingreso de usuario', CAST(N'2026-07-01T00:26:03.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4114, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-01T00:26:04.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4115, 1, N'Ingreso de usuario', CAST(N'2026-07-01T00:26:20.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4116, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-01T00:26:21.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4117, 1, N'Ingreso de usuario', CAST(N'2026-07-01T00:26:56.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4118, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-01T00:26:57.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4119, 1, N'Ingreso de usuario', CAST(N'2026-07-01T00:27:14.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4120, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-01T00:27:15.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4121, 1, N'Ingreso al módulo Bitácora', CAST(N'2026-07-01T00:27:29.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4122, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-01T00:27:35.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4123, 1, N'Ingreso al módulo Bitácora', CAST(N'2026-07-01T00:27:45.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4124, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-07-01T00:27:48.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4125, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-01T00:28:04.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4126, 1, N'Ingreso al módulo Bitácora', CAST(N'2026-07-01T00:28:06.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4127, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-01T00:28:37.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4128, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-07-01T00:28:40.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4129, 1, N'Ingreso de usuario', CAST(N'2026-07-01T00:30:58.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4130, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-07-01T00:30:59.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4131, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-01T00:31:07.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4132, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-07-01T00:31:13.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4133, 1, N'Ingreso al módulo Bitácora', CAST(N'2026-07-01T00:31:16.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4134, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-07-01T00:31:16.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4135, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-07-01T00:31:36.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4136, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-01T00:31:43.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4137, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-07-01T00:31:54.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4138, 1, N'Ingreso al módulo Bitácora', CAST(N'2026-07-01T00:31:57.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4139, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-01T00:32:01.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4140, 1, N'Ingreso al módulo Bitácora', CAST(N'2026-07-01T00:32:06.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4141, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-07-01T00:32:08.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4142, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-01T00:32:09.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4143, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-07-01T00:32:13.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4144, 1, N'Ingreso de usuario', CAST(N'2026-07-01T00:32:33.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4145, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-07-01T00:32:35.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4146, 1, N'Ingreso de usuario', CAST(N'2026-07-01T00:35:13.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4147, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-07-01T00:35:14.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4148, 1, N'Ingreso de usuario', CAST(N'2026-07-01T00:40:24.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4149, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-01T00:40:27.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4150, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-07-01T00:40:30.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4151, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-01T00:40:31.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4152, 1, N'Ingreso de usuario', CAST(N'2026-07-01T00:42:17.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4153, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-01T00:42:21.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4154, 1, N'Ingreso al módulo Bitácora', CAST(N'2026-07-01T00:42:30.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4155, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-07-01T00:42:34.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4156, 1, N'Cierre de sesión', CAST(N'2026-07-01T00:43:03.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4157, 1, N'Ingreso de usuario', CAST(N'2026-07-01T00:43:24.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4158, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-01T00:43:31.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4159, 1, N'Ingreso de usuario', CAST(N'2026-07-01T00:44:04.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4160, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-01T00:44:10.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4161, 1, N'Ingreso de usuario', CAST(N'2026-07-01T00:51:49.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4162, 1, N'Cierre de sesión', CAST(N'2026-07-01T00:51:54.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4163, 1, N'Ingreso de usuario', CAST(N'2026-07-01T00:53:54.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4164, 1, N'Cierre de sesión', CAST(N'2026-07-01T00:54:01.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4165, 1, N'Ingreso de usuario', CAST(N'2026-07-01T00:55:35.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4166, 1, N'Cierre de sesión', CAST(N'2026-07-01T00:55:40.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4167, 1, N'Ingreso de usuario', CAST(N'2026-07-01T00:58:19.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4168, 1, N'Ingreso de usuario', CAST(N'2026-07-01T01:01:42.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4169, 2, N'Ingreso de usuario', CAST(N'2026-07-01T01:02:31.000' AS DateTime), N'INFO')
GO
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4170, 2, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-01T01:02:37.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4171, 2, N'Ingreso al módulo Bitácora', CAST(N'2026-07-01T01:02:44.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4172, 2, N'Ingreso al módulo de Auditoría', CAST(N'2026-07-01T01:02:47.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4173, 2, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-01T01:02:53.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4174, 1, N'Ingreso de usuario', CAST(N'2026-07-01T01:11:10.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4175, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-01T01:11:21.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4176, 1, N'Cierre de sesión', CAST(N'2026-07-01T01:11:24.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4177, 2, N'Ingreso de usuario', CAST(N'2026-07-01T01:11:42.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4178, 1, N'Ingreso de usuario', CAST(N'2026-07-01T01:29:27.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4179, 1, N'Cierre de sesión', CAST(N'2026-07-01T01:29:34.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4180, 1, N'Ingreso de usuario', CAST(N'2026-07-01T01:30:44.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4181, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-01T01:30:48.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4182, 1, N'Ingreso al módulo Bitácora', CAST(N'2026-07-01T01:30:54.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4183, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-07-01T01:31:00.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4184, 1, N'Cierre de sesión', CAST(N'2026-07-01T01:31:06.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4185, 1, N'Ingreso de usuario', CAST(N'2026-07-01T01:33:21.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4186, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-01T01:33:34.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4187, 1, N'Ingreso al módulo Bitácora', CAST(N'2026-07-01T01:33:43.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4188, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-07-01T01:33:48.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4189, 1, N'Ingreso al módulo Bitácora', CAST(N'2026-07-01T01:33:54.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4190, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-01T01:33:59.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4191, 1, N'Ingreso de usuario', CAST(N'2026-07-01T01:34:32.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4192, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-01T01:34:44.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4193, 1, N'Ingreso al módulo Bitácora', CAST(N'2026-07-01T01:34:51.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4194, 1, N'Ingreso al módulo Bitácora', CAST(N'2026-07-01T01:35:07.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4195, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-07-01T01:35:11.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4196, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-01T01:35:13.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4197, 1, N'Cierre de sesión', CAST(N'2026-07-01T01:35:39.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4198, 1, N'Ingreso de usuario', CAST(N'2026-07-01T19:05:47.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4199, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-01T19:06:00.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4200, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-07-01T19:06:31.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4201, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-01T19:07:27.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4202, 1, N'Modificó el usuario ''sebastian''', CAST(N'2026-07-01T19:08:04.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4203, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-07-01T19:08:09.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4204, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-01T19:08:14.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4205, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-07-01T19:08:37.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4206, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-01T19:16:46.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4207, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-01T19:16:47.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4208, 1, N'Ingreso de usuario', CAST(N'2026-07-02T02:17:28.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4209, 1, N'Cierre de sesión', CAST(N'2026-07-02T02:17:34.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4210, 1, N'Ingreso de usuario', CAST(N'2026-07-03T00:29:40.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4211, 1, N'Cierre de sesión', CAST(N'2026-07-03T00:29:50.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4212, 1, N'Ingreso de usuario', CAST(N'2026-07-03T01:16:08.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4213, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-03T01:16:36.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4214, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-07-03T01:16:41.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4215, 1, N'Cierre de sesión', CAST(N'2026-07-03T01:16:43.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4216, 1, N'Ingreso de usuario', CAST(N'2026-07-03T01:20:23.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4217, 1, N'Cierre de sesión', CAST(N'2026-07-03T01:20:37.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4218, 1, N'Ingreso de usuario', CAST(N'2026-07-03T01:53:29.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4219, 1, N'Cierre de sesión', CAST(N'2026-07-03T01:53:42.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4220, 1, N'Ingreso de usuario', CAST(N'2026-07-03T01:56:59.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4221, 1, N'Ingreso de usuario', CAST(N'2026-07-03T01:57:42.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4222, 1, N'Cierre de sesión', CAST(N'2026-07-03T01:57:52.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4223, 1, N'Ingreso de usuario', CAST(N'2026-07-03T02:00:17.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4224, 1, N'Ingreso de usuario', CAST(N'2026-07-03T02:00:55.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4225, 1, N'Ingreso de usuario', CAST(N'2026-07-03T02:27:09.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4226, 1, N'Cierre de sesión', CAST(N'2026-07-03T02:27:17.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4227, 1, N'Ingreso de usuario', CAST(N'2026-07-03T02:27:34.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4228, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-03T02:27:36.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4229, 1, N'Cierre de sesión', CAST(N'2026-07-03T02:27:44.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4230, 1, N'Ingreso de usuario', CAST(N'2026-07-03T02:28:08.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4231, 1, N'Ingreso de usuario', CAST(N'2026-07-03T02:32:40.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4232, 1, N'Ingreso de usuario', CAST(N'2026-07-03T02:39:21.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4233, 1, N'Ingreso de usuario', CAST(N'2026-07-03T02:44:18.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4234, 1, N'Cierre de sesión', CAST(N'2026-07-03T02:44:41.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4235, 1, N'Ingreso de usuario', CAST(N'2026-07-03T02:44:56.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4236, 1, N'Cierre de sesión', CAST(N'2026-07-03T02:45:04.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4237, 1, N'Ingreso de usuario', CAST(N'2026-07-03T02:45:13.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4238, 1, N'Cierre de sesión', CAST(N'2026-07-03T02:45:18.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4239, 1, N'Ingreso de usuario', CAST(N'2026-07-03T02:47:11.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4240, 1, N'Cierre de sesión', CAST(N'2026-07-03T02:47:14.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4241, 1, N'Ingreso de usuario', CAST(N'2026-07-03T02:47:23.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4242, 1, N'Cierre de sesión', CAST(N'2026-07-03T02:47:25.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4243, 1, N'Ingreso de usuario', CAST(N'2026-07-03T02:47:36.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4244, 1, N'Ingreso al módulo Bitácora', CAST(N'2026-07-03T02:47:39.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4245, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-07-03T02:47:44.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4246, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-03T02:47:52.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4247, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-03T02:48:00.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4248, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-07-03T02:48:04.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4249, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-03T02:48:11.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4250, 1, N'Cierre de sesión', CAST(N'2026-07-03T02:48:15.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4251, 1, N'Ingreso de usuario', CAST(N'2026-07-03T02:59:43.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4252, 1, N'Ingreso al módulo Bitácora', CAST(N'2026-07-03T02:59:46.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4253, 1, N'Cierre de sesión', CAST(N'2026-07-03T02:59:54.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4254, 1, N'Ingreso de usuario', CAST(N'2026-07-03T03:05:59.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4255, 1, N'Ingreso al módulo Bitácora', CAST(N'2026-07-03T03:06:01.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4256, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-07-03T03:06:05.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4257, 1, N'Cierre de sesión', CAST(N'2026-07-03T03:06:15.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4258, 1, N'Ingreso de usuario', CAST(N'2026-07-03T03:08:20.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4259, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-03T03:08:21.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4260, 1, N'Ingreso al módulo Bitácora', CAST(N'2026-07-03T03:08:27.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4261, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-07-03T03:08:33.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4262, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-07-03T03:09:15.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4263, 1, N'Ingreso al módulo Bitácora', CAST(N'2026-07-03T03:09:17.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4264, 1, N'Ingreso al módulo Bitácora', CAST(N'2026-07-03T03:09:29.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4265, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-07-03T03:09:35.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4266, 1, N'Ingreso al módulo Bitácora', CAST(N'2026-07-03T03:09:37.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4267, 1, N'Cierre de sesión', CAST(N'2026-07-03T03:09:50.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4268, 1, N'Ingreso de usuario', CAST(N'2026-07-03T19:25:17.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4269, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-03T19:25:21.000' AS DateTime), N'INFO')
GO
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4270, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-03T19:25:22.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4271, 1, N'Ingreso al módulo Bitácora', CAST(N'2026-07-03T19:25:25.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4272, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-07-03T19:25:26.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4273, 1, N'Ingreso al módulo Bitácora', CAST(N'2026-07-03T19:25:27.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4274, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-03T19:25:29.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4275, 1, N'Ingreso de usuario', CAST(N'2026-07-03T20:17:39.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4276, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-03T20:17:40.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4277, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-03T20:17:45.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4278, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-07-03T20:17:54.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4279, 1, N'Ingreso al módulo Bitácora', CAST(N'2026-07-03T20:17:55.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4280, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-03T20:17:56.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4281, 1, N'Ingreso de usuario', CAST(N'2026-07-03T20:21:58.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4282, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-07-03T20:22:00.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4283, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-03T20:22:04.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4284, 1, N'Modificó el usuario ''sebastian''', CAST(N'2026-07-03T20:22:19.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4285, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-07-03T20:22:22.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4286, 1, N'Restauró el email del usuario ID 2', CAST(N'2026-07-03T20:22:32.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4287, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-03T20:22:42.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4288, 1, N'Ingreso de usuario', CAST(N'2026-07-03T20:28:20.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4289, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-03T20:28:22.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4290, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-03T20:28:30.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4291, 1, N'Ingreso de usuario', CAST(N'2026-07-03T20:29:51.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4292, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-03T20:29:55.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4293, 1, N'Ingreso al módulo Bitácora', CAST(N'2026-07-03T20:30:03.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4294, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-07-03T20:30:04.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4295, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-03T20:30:06.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4296, 1, N'Cierre de sesión', CAST(N'2026-07-03T20:30:10.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4297, 1, N'Ingreso de usuario', CAST(N'2026-07-03T20:30:55.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4298, 1, N'Ingreso al módulo de Auditoría', CAST(N'2026-07-03T20:30:56.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4299, 1, N'Ingreso al módulo Bitácora', CAST(N'2026-07-03T20:30:59.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4300, 1, N'Ingreso al módulo Bitácora', CAST(N'2026-07-03T20:31:02.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4301, 1, N'Ingreso al módulo Gestion de Usuarios', CAST(N'2026-07-03T20:31:07.000' AS DateTime), N'INFO')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [mensaje], [fecha], [estado]) VALUES (4302, 1, N'Cierre de sesión', CAST(N'2026-07-03T20:31:14.000' AS DateTime), N'INFO')
SET IDENTITY_INSERT [dbo].[Bitacora] OFF
GO
SET IDENTITY_INSERT [dbo].[Etiqueta] ON 

INSERT [dbo].[Etiqueta] ([IdEtiqueta], [Clave]) VALUES (10, N'auditoriaToolStripMenuItem')
INSERT [dbo].[Etiqueta] ([IdEtiqueta], [Clave]) VALUES (9, N'bitacoraToolStripMenuItem')
INSERT [dbo].[Etiqueta] ([IdEtiqueta], [Clave]) VALUES (14, N'btnFiltrar')
INSERT [dbo].[Etiqueta] ([IdEtiqueta], [Clave]) VALUES (4, N'btnLogin')
INSERT [dbo].[Etiqueta] ([IdEtiqueta], [Clave]) VALUES (15, N'btnVolver')
INSERT [dbo].[Etiqueta] ([IdEtiqueta], [Clave]) VALUES (16, N'btnVolverEstado')
INSERT [dbo].[Etiqueta] ([IdEtiqueta], [Clave]) VALUES (7, N'canchasToolStripMenuItem')
INSERT [dbo].[Etiqueta] ([IdEtiqueta], [Clave]) VALUES (12, N'chkDesde')
INSERT [dbo].[Etiqueta] ([IdEtiqueta], [Clave]) VALUES (13, N'chkHasta')
INSERT [dbo].[Etiqueta] ([IdEtiqueta], [Clave]) VALUES (1, N'frmLogin')
INSERT [dbo].[Etiqueta] ([IdEtiqueta], [Clave]) VALUES (17, N'groupBox1')
INSERT [dbo].[Etiqueta] ([IdEtiqueta], [Clave]) VALUES (18, N'groupBox2')
INSERT [dbo].[Etiqueta] ([IdEtiqueta], [Clave]) VALUES (3, N'lblPassword')
INSERT [dbo].[Etiqueta] ([IdEtiqueta], [Clave]) VALUES (5, N'lblTitulo')
INSERT [dbo].[Etiqueta] ([IdEtiqueta], [Clave]) VALUES (2, N'lblUsuario')
INSERT [dbo].[Etiqueta] ([IdEtiqueta], [Clave]) VALUES (6, N'menuGestionUsuarios')
INSERT [dbo].[Etiqueta] ([IdEtiqueta], [Clave]) VALUES (11, N'menuLogout')
INSERT [dbo].[Etiqueta] ([IdEtiqueta], [Clave]) VALUES (8, N'reservasToolStripMenuItem')
SET IDENTITY_INSERT [dbo].[Etiqueta] OFF
GO
SET IDENTITY_INSERT [dbo].[Idioma] ON 

INSERT [dbo].[Idioma] ([IdIdioma], [Nombre]) VALUES (2, N'English')
INSERT [dbo].[Idioma] ([IdIdioma], [Nombre]) VALUES (1, N'Español')
SET IDENTITY_INSERT [dbo].[Idioma] OFF
GO
SET IDENTITY_INSERT [dbo].[Permiso] ON 

INSERT [dbo].[Permiso] ([Id], [Nombre], [Tipo]) VALUES (1, N'Administrador', N'PuedeHacerTodo')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Tipo]) VALUES (2, N'Administrador de reservas', N'PuedeHacerA')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Tipo]) VALUES (3, N'Prueba', N'PuedeHacerB')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Tipo]) VALUES (4, N'FamiliaPrueba', NULL)
INSERT [dbo].[Permiso] ([Id], [Nombre], [Tipo]) VALUES (5, N'FamiliaPrueba', NULL)
INSERT [dbo].[Permiso] ([Id], [Nombre], [Tipo]) VALUES (6, N'FamiliaPrueba', NULL)
INSERT [dbo].[Permiso] ([Id], [Nombre], [Tipo]) VALUES (7, N'Juan', NULL)
INSERT [dbo].[Permiso] ([Id], [Nombre], [Tipo]) VALUES (8, N'prueba', N'PuedeHacerC')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Tipo]) VALUES (9, N'NuevaFamiliaDeAdmin', NULL)
INSERT [dbo].[Permiso] ([Id], [Nombre], [Tipo]) VALUES (10, N'Profe', NULL)
INSERT [dbo].[Permiso] ([Id], [Nombre], [Tipo]) VALUES (11, N'Profe2', NULL)
INSERT [dbo].[Permiso] ([Id], [Nombre], [Tipo]) VALUES (12, N'Profe3', NULL)
INSERT [dbo].[Permiso] ([Id], [Nombre], [Tipo]) VALUES (13, N'Profe4', NULL)
INSERT [dbo].[Permiso] ([Id], [Nombre], [Tipo]) VALUES (14, N'PatprofeA', N'PuedeHacerB')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Tipo]) VALUES (15, N'PatprofeB', N'PuedeHacerC')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Tipo]) VALUES (16, N'PatprofeC', N'PuedeHacerD')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Tipo]) VALUES (17, N'Reporteria', N'PuedeHacerC')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Tipo]) VALUES (18, N'Joaco', NULL)
INSERT [dbo].[Permiso] ([Id], [Nombre], [Tipo]) VALUES (19, N'Sofi', NULL)
INSERT [dbo].[Permiso] ([Id], [Nombre], [Tipo]) VALUES (20, N'Habilita Reserva', N'PuedeHacerD')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Tipo]) VALUES (21, N'Prueba recursividad', NULL)
INSERT [dbo].[Permiso] ([Id], [Nombre], [Tipo]) VALUES (22, N'Recepcionista', N'PuedeReservar')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Tipo]) VALUES (23, N'SupervisorCancha', N'PuedeBloquearCancha')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Tipo]) VALUES (24, N'Cajero', N'PuedeConfirmarPagos')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Tipo]) VALUES (25, N'FamiliaAdmin', NULL)
INSERT [dbo].[Permiso] ([Id], [Nombre], [Tipo]) VALUES (26, N'EncargadoMantenimiento', N'PuedeConfigurarMantenimiento')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Tipo]) VALUES (27, N'PuedeAutorizarPromos', N'JefeDeVentas')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Tipo]) VALUES (28, N'Puede Aplicar Promos', N'PuedeAplicarPromociones')
SET IDENTITY_INSERT [dbo].[Permiso] OFF
GO
SET IDENTITY_INSERT [dbo].[Traduccion] ON 

INSERT [dbo].[Traduccion] ([IdTraduccion], [IdIdioma], [IdEtiqueta], [Texto]) VALUES (1, 1, 1, N'Gestion Canchas')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdIdioma], [IdEtiqueta], [Texto]) VALUES (2, 1, 2, N'Usuario')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdIdioma], [IdEtiqueta], [Texto]) VALUES (3, 1, 3, N'Contraseña')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdIdioma], [IdEtiqueta], [Texto]) VALUES (4, 1, 4, N'Ingresar')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdIdioma], [IdEtiqueta], [Texto]) VALUES (5, 1, 5, N'Sistema de Gestión de canchas')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdIdioma], [IdEtiqueta], [Texto]) VALUES (6, 1, 6, N'Gestionar Usuarios')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdIdioma], [IdEtiqueta], [Texto]) VALUES (7, 1, 7, N'Canchas')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdIdioma], [IdEtiqueta], [Texto]) VALUES (8, 1, 8, N'Reservas')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdIdioma], [IdEtiqueta], [Texto]) VALUES (9, 1, 9, N'Bitacora')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdIdioma], [IdEtiqueta], [Texto]) VALUES (10, 1, 10, N'Auditoria')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdIdioma], [IdEtiqueta], [Texto]) VALUES (11, 1, 11, N'Cerrar sesión')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdIdioma], [IdEtiqueta], [Texto]) VALUES (12, 1, 12, N'Fecha desde')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdIdioma], [IdEtiqueta], [Texto]) VALUES (13, 1, 13, N'Fecha hasta')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdIdioma], [IdEtiqueta], [Texto]) VALUES (14, 1, 14, N'Filtrar')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdIdioma], [IdEtiqueta], [Texto]) VALUES (15, 2, 1, N'Managment Field')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdIdioma], [IdEtiqueta], [Texto]) VALUES (16, 2, 2, N'User')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdIdioma], [IdEtiqueta], [Texto]) VALUES (17, 2, 3, N'Password')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdIdioma], [IdEtiqueta], [Texto]) VALUES (18, 2, 4, N'Login')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdIdioma], [IdEtiqueta], [Texto]) VALUES (19, 2, 5, N'Soccer Field Management System')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdIdioma], [IdEtiqueta], [Texto]) VALUES (20, 2, 6, N'Manage users')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdIdioma], [IdEtiqueta], [Texto]) VALUES (21, 2, 7, N'Courts')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdIdioma], [IdEtiqueta], [Texto]) VALUES (22, 2, 8, N'Reservations')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdIdioma], [IdEtiqueta], [Texto]) VALUES (23, 2, 9, N'Binnacle')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdIdioma], [IdEtiqueta], [Texto]) VALUES (24, 2, 10, N'Audit')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdIdioma], [IdEtiqueta], [Texto]) VALUES (25, 2, 11, N'Logout')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdIdioma], [IdEtiqueta], [Texto]) VALUES (26, 2, 12, N'Start date')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdIdioma], [IdEtiqueta], [Texto]) VALUES (27, 2, 13, N'End date')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdIdioma], [IdEtiqueta], [Texto]) VALUES (28, 2, 14, N'Search')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdIdioma], [IdEtiqueta], [Texto]) VALUES (30, 1, 15, N'Volver')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdIdioma], [IdEtiqueta], [Texto]) VALUES (31, 2, 15, N'Back')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdIdioma], [IdEtiqueta], [Texto]) VALUES (32, 1, 16, N'Volver al estado anterior')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdIdioma], [IdEtiqueta], [Texto]) VALUES (33, 1, 17, N'Usuarios del sistema')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdIdioma], [IdEtiqueta], [Texto]) VALUES (34, 1, 18, N'Historial de cambios')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdIdioma], [IdEtiqueta], [Texto]) VALUES (35, 2, 16, N'return to the previous state')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdIdioma], [IdEtiqueta], [Texto]) VALUES (36, 2, 17, N'Users')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdIdioma], [IdEtiqueta], [Texto]) VALUES (37, 2, 18, N'Change history')
SET IDENTITY_INSERT [dbo].[Traduccion] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([id_usuario], [username], [password], [Telefono], [Email], [IdIdioma]) VALUES (1, N'admin', N'$2a$11$jNmcK1VAr4HMMFxST8ImvOaMtnLG8Rq78YzOSFI2.I/Rc41YEtT9S', N'1134567890', N'admin@gmail.com', 2)
INSERT [dbo].[Usuario] ([id_usuario], [username], [password], [Telefono], [Email], [IdIdioma]) VALUES (2, N'sebastian', N'$2a$11$jNmcK1VAr4HMMFxST8ImvOaMtnLG8Rq78YzOSFI2.I/Rc41YEtT9S', N'110123888', N'seba@gmail.com', 1)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
INSERT [dbo].[Usuario_Permiso] ([Id_Usuario], [Id_Permiso]) VALUES (1, 1)
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Etiqueta__E8181E119B8825A1]    Script Date: 3/7/2026 20:43:21 ******/
ALTER TABLE [dbo].[Etiqueta] ADD UNIQUE NONCLUSTERED 
(
	[Clave] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Idioma__75E3EFCF322E4F89]    Script Date: 3/7/2026 20:43:21 ******/
ALTER TABLE [dbo].[Idioma] ADD UNIQUE NONCLUSTERED 
(
	[Nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Usuarios__F3DBC572AEB8E16B]    Script Date: 3/7/2026 20:43:21 ******/
ALTER TABLE [dbo].[Usuario] ADD UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Usuario] ADD  CONSTRAINT [DF_Usuarios_Idioma]  DEFAULT ((1)) FOR [IdIdioma]
GO
ALTER TABLE [dbo].[Bitacora]  WITH CHECK ADD  CONSTRAINT [FK_Bitacora_Usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Bitacora] CHECK CONSTRAINT [FK_Bitacora_Usuario]
GO
ALTER TABLE [dbo].[Permiso_Permiso]  WITH CHECK ADD  CONSTRAINT [FK_PP_Hijo] FOREIGN KEY([Id_Permiso_Hijo])
REFERENCES [dbo].[Permiso] ([Id])
GO
ALTER TABLE [dbo].[Permiso_Permiso] CHECK CONSTRAINT [FK_PP_Hijo]
GO
ALTER TABLE [dbo].[Permiso_Permiso]  WITH CHECK ADD  CONSTRAINT [FK_PP_Padre] FOREIGN KEY([Id_Permiso_Padre])
REFERENCES [dbo].[Permiso] ([Id])
GO
ALTER TABLE [dbo].[Permiso_Permiso] CHECK CONSTRAINT [FK_PP_Padre]
GO
ALTER TABLE [dbo].[Traduccion]  WITH CHECK ADD FOREIGN KEY([IdEtiqueta])
REFERENCES [dbo].[Etiqueta] ([IdEtiqueta])
GO
ALTER TABLE [dbo].[Traduccion]  WITH CHECK ADD FOREIGN KEY([IdIdioma])
REFERENCES [dbo].[Idioma] ([IdIdioma])
GO
ALTER TABLE [dbo].[Usuario_Permiso]  WITH CHECK ADD  CONSTRAINT [FK_UP_Permiso] FOREIGN KEY([Id_Permiso])
REFERENCES [dbo].[Permiso] ([Id])
GO
ALTER TABLE [dbo].[Usuario_Permiso] CHECK CONSTRAINT [FK_UP_Permiso]
GO
ALTER TABLE [dbo].[Usuario_Permiso]  WITH CHECK ADD  CONSTRAINT [FK_UP_Usuario] FOREIGN KEY([Id_Usuario])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Usuario_Permiso] CHECK CONSTRAINT [FK_UP_Usuario]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarUsuario]    Script Date: 3/7/2026 20:43:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActualizarUsuario]
(
    @Id INT,
    @Username VARCHAR(100),
    @PasswordHash VARCHAR(200),
	@Email VARCHAR(100),
	@Telefono VARCHAR(30)
)
AS
BEGIN

    UPDATE Usuario
    SET
        username = @Username,
        password = @PasswordHash,
		Email=@Email,
		Telefono=@Telefono
    WHERE id_usuario = @Id;

END
GO
/****** Object:  StoredProcedure [dbo].[Auditoria_Insertar]    Script Date: 3/7/2026 20:43:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[Auditoria_Insertar]

@UsuarioId INT,
@EmailAnterior VARCHAR(100),
@EmailActual VARCHAR(100),
@Fecha DATETIME,
@ModificadoPor VARCHAR(50),
@Accion VARCHAR(50)

AS
BEGIN

INSERT INTO AuditoriaUsuarios
(
    UsuarioId,
    EmailAnterior,
    EmailActual,
    Fecha,
    ModificadoPor,
    Accion
)

VALUES
(
    @UsuarioId,
    @EmailAnterior,
    @EmailActual,
    @Fecha,
    @ModificadoPor,
    @Accion
)

END
GO
/****** Object:  StoredProcedure [dbo].[Auditoria_ObtenerHistorial]    Script Date: 3/7/2026 20:43:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[Auditoria_ObtenerHistorial]
    @UsuarioId INT
AS
BEGIN
    SELECT * FROM AuditoriaUsuarios
    WHERE UsuarioId = @UsuarioId
    ORDER BY Fecha DESC
END
GO
/****** Object:  StoredProcedure [dbo].[Auditoria_ObtenerPorId]    Script Date: 3/7/2026 20:43:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Auditoria_ObtenerPorId]
    @IdAuditoria INT
AS
BEGIN
    SELECT * FROM AuditoriaUsuarios WHERE IdAuditoria = @IdAuditoria
END
GO
/****** Object:  StoredProcedure [dbo].[BuscarUsuario]    Script Date: 3/7/2026 20:43:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BuscarUsuario]
(
    @nombre VARCHAR(50)
)
AS
BEGIN

    SELECT
        id_usuario,
        username,
        password,
		email,
		telefono,
		IdIdioma
    FROM Usuario
    WHERE username = @nombre

END
GO
/****** Object:  StoredProcedure [dbo].[GetAllComponentes]    Script Date: 3/7/2026 20:43:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[GetAllComponentes]
    @familiaId INT = NULL
AS
BEGIN
    WITH recursivo AS (
        SELECT sp2.id_permiso_padre, sp2.id_permiso_hijo
        FROM permiso_permiso sp2
        WHERE (@familiaId IS NULL AND sp2.id_permiso_padre IS NULL)
           OR (@familiaId IS NOT NULL AND sp2.id_permiso_padre = @familiaId)
        
        UNION ALL

        SELECT sp.id_permiso_padre, sp.id_permiso_hijo
        FROM permiso_permiso sp
        INNER JOIN recursivo r ON r.id_permiso_hijo = sp.id_permiso_padre
    )
    SELECT r.id_permiso_padre, r.id_permiso_hijo, p.id, p.nombre, p.Tipo
    FROM recursivo r
    INNER JOIN permiso p ON r.id_permiso_hijo = p.id;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetAllFamilias]    Script Date: 3/7/2026 20:43:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetAllFamilias]
AS
BEGIN
    SELECT Id, Nombre
    FROM Permiso
    WHERE Tipo IS NULL;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetAllPatentes]    Script Date: 3/7/2026 20:43:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllPatentes]
AS
BEGIN
    SELECT Id, Nombre, Tipo
    FROM Permiso
    WHERE Tipo IS NOT NULL;
END;
GO
/****** Object:  StoredProcedure [dbo].[GuardarUsuario]    Script Date: 3/7/2026 20:43:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GuardarUsuario]
(
    @username VARCHAR(50),
    @password VARCHAR(255)
)
AS
BEGIN

    INSERT INTO Usuario
    (
        username,
        password
    )
    VALUES
    (
        @username,
        @password
    )

END
GO
/****** Object:  StoredProcedure [dbo].[InsertarBitacora]    Script Date: 3/7/2026 20:43:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarBitacora]
(
    @idUsuario INT,
    @mensaje VARCHAR(255),
    @fecha DATETIME,
	@estado VARCHAR(50)
)
AS
BEGIN

    INSERT INTO Bitacora
    (
        id_usuario,
        mensaje,
        fecha,
		estado
    )
    VALUES
    (
        @idUsuario,
        @mensaje,
        @fecha,
		@estado
    )

END
GO
/****** Object:  StoredProcedure [dbo].[ObtenerBitacora]    Script Date: 3/7/2026 20:43:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerBitacora]
(
    @fechaDesde DATETIME = NULL,
    @fechaHasta DATETIME = NULL
)
AS
BEGIN

    SELECT
        B.id_bitacora,
        U.username,
        B.mensaje,
        B.fecha,
		B.estado
    FROM Bitacora B
    INNER JOIN Usuario U
        ON B.id_usuario = U.id_usuario
    WHERE
        (@fechaDesde IS NULL
            OR B.fecha >= @fechaDesde)
    AND
        (@fechaHasta IS NULL
            OR B.fecha <= @fechaHasta)
    ORDER BY B.fecha DESC

END
GO
/****** Object:  StoredProcedure [dbo].[ObtenerIdiomas]    Script Date: 3/7/2026 20:43:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ObtenerIdiomas]
AS
BEGIN

SELECT *

FROM Idioma

ORDER BY Nombre

END
GO
/****** Object:  StoredProcedure [dbo].[ObtenerPermisosUsuario]    Script Date: 3/7/2026 20:43:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ObtenerPermisosUsuario]
    @usuarioId INT
AS
BEGIN
    SELECT p.id, p.nombre, p.Tipo
    FROM Usuario_Permiso up
    INNER JOIN permiso p ON up.id_permiso = p.id
    WHERE up.id_usuario = @usuarioId;
END
GO
/****** Object:  StoredProcedure [dbo].[ObtenerTraducciones]    Script Date: 3/7/2026 20:43:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerTraducciones]
@IdIdioma INT
AS
BEGIN

SELECT

E.Clave,

T.Texto

FROM Traduccion T

INNER JOIN Etiqueta E
ON T.IdEtiqueta = E.IdEtiqueta

WHERE T.IdIdioma = @IdIdioma

END
GO
/****** Object:  StoredProcedure [dbo].[ObtenerUsuarios]    Script Date: 3/7/2026 20:43:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ObtenerUsuarios]
AS
BEGIN
	SELECT *
	FROM Usuario;
END
GO
/****** Object:  StoredProcedure [dbo].[RestaurarEmail]    Script Date: 3/7/2026 20:43:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[RestaurarEmail]

@IdUsuario INT,
@Email VARCHAR(100)

AS
BEGIN

UPDATE Usuario

SET Email=@Email

WHERE id_usuario=@IdUsuario

END
GO
/****** Object:  StoredProcedure [dbo].[Usuario_ActualizarIdioma]    Script Date: 3/7/2026 20:43:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE PROCEDURE [dbo].[Usuario_ActualizarIdioma]
(
    @IdUsuario INT,
    @IdIdioma INT
)
AS
BEGIN

    UPDATE Usuario
       SET IdIdioma=@IdIdioma
     WHERE id_usuario=@IdUsuario

END
GO
/****** Object:  StoredProcedure [dbo].[Usuario_ObtenerPorId]    Script Date: 3/7/2026 20:43:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_ObtenerPorId]
(
    @Id INT
)
AS
BEGIN

    SELECT
        id_usuario,
        username,
        password,
		email,
		telefono
    FROM Usuario
    WHERE id_usuario = @Id;

END
GO
USE [master]
GO
ALTER DATABASE [GestionCanchas] SET  READ_WRITE 
GO

INSERT INTO dbo.Permiso_Permiso (Id_Permiso_Padre, Id_Permiso_Hijo)
VALUES
    (4, 1),
    (4, 2),
    (4, 3),
    (5, 4),
    (5, 6),
    (10, 14),
    (10, 15),
    (10, 16),
    (11, 8),
    (11, 10),
    (11, 14),
    (12, 11),
    (13, 12),
    (13, 25),
    (18, 1),
    (19, 17),
    (21, 1),
    (21, 5),
    (21, 6),
    (21, 9),
    (21, 20),
    (25, 1),
    (25, 12),
    (25, 17),
    (25, 22),
    (25, 23),
    (25, 24),
    (25, 26);
GO

