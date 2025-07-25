USE [master]
GO
/****** Object:  Database [Usuarios]    Script Date: 14/7/2025 09:04:44 ******/
CREATE DATABASE [Usuarios]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Usuarios', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Usuarios.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Usuarios_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Usuarios_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Usuarios] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Usuarios].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Usuarios] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Usuarios] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Usuarios] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Usuarios] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Usuarios] SET ARITHABORT OFF 
GO
ALTER DATABASE [Usuarios] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Usuarios] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Usuarios] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Usuarios] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Usuarios] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Usuarios] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Usuarios] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Usuarios] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Usuarios] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Usuarios] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Usuarios] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Usuarios] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Usuarios] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Usuarios] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Usuarios] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Usuarios] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Usuarios] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Usuarios] SET RECOVERY FULL 
GO
ALTER DATABASE [Usuarios] SET  MULTI_USER 
GO
ALTER DATABASE [Usuarios] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Usuarios] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Usuarios] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Usuarios] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Usuarios] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Usuarios', N'ON'
GO
ALTER DATABASE [Usuarios] SET QUERY_STORE = OFF
GO
USE [Usuarios]
GO
/****** Object:  User [alumno]    Script Date: 14/7/2025 09:04:44 ******/
CREATE USER [alumno] FOR LOGIN [alumno] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Integrante]    Script Date: 14/7/2025 09:04:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Integrante](
	[NombreDeUsuario] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[CuadroDeFutbol] [varchar](50) NOT NULL,
	[ComidaFavorita] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Edad] [int] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Integrante] ([NombreDeUsuario], [Email], [Password], [CuadroDeFutbol], [ComidaFavorita], [Nombre], [Apellido], [Edad]) VALUES (N'Lucas08', N'lucasdue08@gmail.com', N'OholachauT08', N'Atlanta', N'Pancho', N'Lucas', N'Dueñaz', 17)
INSERT [dbo].[Integrante] ([NombreDeUsuario], [Email], [Password], [CuadroDeFutbol], [ComidaFavorita], [Nombre], [Apellido], [Edad]) VALUES (N'Toto1312', N'toto1312toto@gmail.com', N'Toto1312', N'Boca Juniors', N'Milanesas', N'Tobias', N'Epsztein', 16)
INSERT [dbo].[Integrante] ([NombreDeUsuario], [Email], [Password], [CuadroDeFutbol], [ComidaFavorita], [Nombre], [Apellido], [Edad]) VALUES (N'LucasAcade28', N'lucasacade28@gmail.com', N'LucasDorin09', N'Racing', N'Pizza', N'Lucas', N'Dorin', 16)
GO
USE [master]
GO
ALTER DATABASE [Usuarios] SET  READ_WRITE 
GO
