USE [master]
GO
/****** Object:  Database [SuiteFHFSoft]    Script Date: 31/8/2017 1:02:41 a.m. ******/
CREATE DATABASE [SuiteFHFSoft]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SuiteFHFSoft', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\SuiteFHFSoft.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SuiteFHFSoft_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\SuiteFHFSoft_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SuiteFHFSoft] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SuiteFHFSoft].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SuiteFHFSoft] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SuiteFHFSoft] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SuiteFHFSoft] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SuiteFHFSoft] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SuiteFHFSoft] SET ARITHABORT OFF 
GO
ALTER DATABASE [SuiteFHFSoft] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SuiteFHFSoft] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SuiteFHFSoft] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SuiteFHFSoft] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SuiteFHFSoft] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SuiteFHFSoft] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SuiteFHFSoft] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SuiteFHFSoft] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SuiteFHFSoft] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SuiteFHFSoft] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SuiteFHFSoft] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SuiteFHFSoft] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SuiteFHFSoft] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SuiteFHFSoft] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SuiteFHFSoft] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SuiteFHFSoft] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SuiteFHFSoft] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SuiteFHFSoft] SET RECOVERY FULL 
GO
ALTER DATABASE [SuiteFHFSoft] SET  MULTI_USER 
GO
ALTER DATABASE [SuiteFHFSoft] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SuiteFHFSoft] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SuiteFHFSoft] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SuiteFHFSoft] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [SuiteFHFSoft] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SuiteFHFSoft', N'ON'
GO
USE [SuiteFHFSoft]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 31/8/2017 1:02:41 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clientes](
	[ClienteID] [bigint] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Cedula] [varchar](50) NULL,
	[Descuento] [money] NULL,
	[LimiteCredito] [money] NULL,
	[Email] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL,
	[Celular] [varchar](50) NULL,
	[Direccion] [varchar](250) NULL,
	[ProvinciaID] [int] NULL,
	[PasID] [int] NULL,
	[CudadID] [int] NULL,
	[Estatus] [int] NULL,
	[FechaCreacion] [datetime] NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[ClienteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MenuItem]    Script Date: 31/8/2017 1:02:41 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MenuItem](
	[MenuitemID] [bigint] IDENTITY(1,1) NOT NULL,
	[Detalle] [varchar](150) NULL,
	[FormName] [varchar](150) NULL,
	[ItemOrder1] [int] NULL,
	[ItemOrder2] [int] NULL,
	[ItemOrder3] [int] NULL,
	[ImageID] [int] NULL,
	[Active] [int] NULL,
 CONSTRAINT [PK_MenuItem] PRIMARY KEY CLUSTERED 
(
	[MenuitemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SpecalPermitAccess]    Script Date: 31/8/2017 1:02:41 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SpecalPermitAccess](
	[SpecialPermitAccessID] [bigint] IDENTITY(1,1) NOT NULL,
	[SpecialPermitID] [bigint] NULL,
	[UserProfileID] [bigint] NULL,
	[Active] [int] NULL,
 CONSTRAINT [PK_SpecalPermitAccess] PRIMARY KEY CLUSTERED 
(
	[SpecialPermitAccessID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SpecialPermit]    Script Date: 31/8/2017 1:02:41 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SpecialPermit](
	[SpecialPermitID] [bigint] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[Code] [int] NULL,
	[Active] [int] NULL,
 CONSTRAINT [PK_SpecialPermit] PRIMARY KEY CLUSTERED 
(
	[SpecialPermitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sucursal]    Script Date: 31/8/2017 1:02:41 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sucursal](
	[SucursalID] [bigint] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](150) NULL,
	[Direccion] [varchar](150) NULL,
	[ProvinciaID] [bigint] NULL,
	[PaisID] [bigint] NULL,
	[Telefono] [varchar](50) NULL,
	[Celular] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Active] [int] NULL CONSTRAINT [DF_Sucursal_Active]  DEFAULT ((1))
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserProfile]    Script Date: 31/8/2017 1:02:41 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserProfile](
	[UserProfileID] [bigint] IDENTITY(1,1) NOT NULL,
	[SucursalID] [bigint] NULL,
	[Detalle] [varchar](50) NULL,
	[Active] [int] NULL,
 CONSTRAINT [PK_UserProfile] PRIMARY KEY CLUSTERED 
(
	[UserProfileID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserProfileAccess]    Script Date: 31/8/2017 1:02:41 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserProfileAccess](
	[UserProfileAccessID] [bigint] IDENTITY(1,1) NOT NULL,
	[MenuitemID] [bigint] NULL,
	[UserProfileID] [bigint] NULL,
	[Active] [int] NULL,
 CONSTRAINT [PK_UserProfileAccess] PRIMARY KEY CLUSTERED 
(
	[UserProfileAccessID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 31/8/2017 1:02:41 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[UsuarioID] [bigint] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[UserName] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[ProvinciaID] [bigint] NULL,
	[PaisID] [bigint] NULL,
	[Direccion] [varchar](250) NULL,
	[Telefono] [varchar](50) NULL,
	[Celular] [varchar](50) NULL,
	[Email] [varchar](150) NULL,
	[TipoID] [bigint] NULL,
	[UserProfileID] [bigint] NULL,
	[ID] [varchar](50) NULL,
	[Active] [int] NULL CONSTRAINT [DF_Usuarios_Active]  DEFAULT ((1)),
	[CreationDate] [datetime] NULL CONSTRAINT [DF_Usuarios_CreationDate]  DEFAULT (getdate()),
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[UsuarioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Index [IX_SpecialPermit]    Script Date: 31/8/2017 1:02:41 a.m. ******/
CREATE NONCLUSTERED INDEX [IX_SpecialPermit] ON [dbo].[SpecialPermit]
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[SpecalPermitAccess] ADD  CONSTRAINT [DF_SpecalPermitAccess_Active]  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[SpecialPermit] ADD  CONSTRAINT [DF_SpecialPermit_Active]  DEFAULT ((1)) FOR [Active]
GO
/****** Object:  StoredProcedure [dbo].[INI_L]    Script Date: 31/8/2017 1:02:41 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[INI_L]
AS

SELECT R='MAAxAC8AMQAwAC8AMgAwADEANwA='--01-10-2017
--MQAwAC8AMAAxAC8AMgAwADUAMgA=  --2052
GO
/****** Object:  StoredProcedure [dbo].[LOGIN_L]    Script Date: 31/8/2017 1:02:41 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LOGIN_L]
@USERNAME VARCHAR(100)='FHF',
@PASSWORD VARCHAR(100)='Michael0103'
AS

SET NOCOUNT ON


IF EXISTS(
SELECT a.*,b.Detalle,d.*
FROM Usuarios a
left join UserProfile b on a.UserProfileID = b.UserProfileID
left join UserProfileAccess c on c.UserProfileID=b.UserProfileID
left join MenuItem d on c.MenuitemID = d.MenuitemID
WHERE 
(UserName = @USERNAME AND Password  = @PASSWORD COLLATE SQL_Latin1_General_CP1_CS_AS))
BEGIN
SELECT RESULT=0,a.*,b.Detalle,d.*,Descripcion=d.Detalle, PerfilName=b.Detalle,b.SucursalID, SucursalName=S.Descripcion
FROM Usuarios a
left join UserProfile b on a.UserProfileID = b.UserProfileID and b.Active =1
left join UserProfileAccess c on b.UserProfileID=c.UserProfileID and c.Active=1
left join MenuItem d on c.MenuitemID = d.MenuitemID and d.Active =1
Left Join Sucursal s on b.sucursalID =s.sucursalID
WHERE 
(UserName = @USERNAME AND Password  = @PASSWORD COLLATE SQL_Latin1_General_CP1_CS_AS)
order by ItemOrder1,ItemOrder2,ItemOrder3
END

ELSE
BEGIN
SELECT RESULT=1,MSGBOX='ACCESO DENEGADO USUARIO O CONTRASEÑA INVALIDOS'
END

GO
/****** Object:  StoredProcedure [dbo].[SUCURSAL_L]    Script Date: 31/8/2017 1:02:41 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SUCURSAL_L]
@USERPROFILEID INT =NULL
AS

SET NOCOUNT ON

SELECT * FROM Sucursal 
GO
/****** Object:  StoredProcedure [dbo].[USERPROFILE_L]    Script Date: 31/8/2017 1:02:41 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USERPROFILE_L]
AS

SELECT * FROM UserProfile
GO
USE [master]
GO
ALTER DATABASE [SuiteFHFSoft] SET  READ_WRITE 
GO
