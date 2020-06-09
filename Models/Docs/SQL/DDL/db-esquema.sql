CREATE DATABASE [TP-20201C]
GO
ALTER DATABASE [TP-20201C] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TP-20201C].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TP-20201C] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TP-20201C] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TP-20201C] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TP-20201C] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TP-20201C] SET ARITHABORT OFF 
GO
ALTER DATABASE [TP-20201C] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TP-20201C] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TP-20201C] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TP-20201C] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TP-20201C] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TP-20201C] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TP-20201C] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TP-20201C] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TP-20201C] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TP-20201C] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TP-20201C] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TP-20201C] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TP-20201C] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TP-20201C] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TP-20201C] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TP-20201C] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TP-20201C] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TP-20201C] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TP-20201C] SET  MULTI_USER 
GO
ALTER DATABASE [TP-20201C] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TP-20201C] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TP-20201C] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TP-20201C] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [TP-20201C] SET DELAYED_DURABILITY = DISABLED 
GO
USE [TP-20201C]
GO

/****** Object:  Table [dbo].[UsuariosTipo] ******/
CREATE TABLE [dbo].UsuariosTipo(
IdUsuarioTipo int IDENTITY(1,1) NOT NULL,
Descripcion varchar(30) NOT NULL,
CONSTRAINT PK_UsuariosTipo PRIMARY KEY CLUSTERED(
IdUsuarioTipo ASC)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
)
GO

/****** Object:  Table [dbo].[Usuarios] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Apellido] [nvarchar](50) NULL,
	[FechaNacimiento] [datetime] NOT NULL,
	[UserName] [nvarchar](20) NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Foto] [nvarchar](100) NULL,
	[TipoUsuario] [int] NOT NULL,
	[FechaCracion] [datetime] NOT NULL,
	[Activo] [bit] NOT NULL,
	[Token] [nvarchar](50) NOT NULL,
	CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED(
	[IdUsuario] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
	CONSTRAINT FK_Usuarios_UsuariosTipo FOREIGN KEY ([TipoUsuario])
		REFERENCES [dbo].UsuariosTipo(IdUsuarioTipo)
	
)

GO
/****** Object:  Table [dbo].[Denuncias] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Denuncias](
	[IdDenuncia] [int] IDENTITY(1,1) NOT NULL,
	[IdNecesidad] [int] NOT NULL,
	[IdMotivo] [int] NOT NULL,
	[Comentarios] [nvarchar](300) NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[Estado] [int] NOT NULL,
	CONSTRAINT [PK_Denuncias] PRIMARY KEY CLUSTERED(
	[IdDenuncia] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
	CONSTRAINT FK_Denuncias_Usuarios FOREIGN KEY (IdUsuario)
		REFERENCES [dbo].[Usuarios]([IdUsuario])
)

GO

/****** Object:  Table [dbo].[MotivoDenuncia] ******/
CREATE TABLE [dbo].[MotivoDenuncia](
IdMotivoDenuncia int not null,
Descripcion varchar(30) not null,
CONSTRAINT PK_MotivoDenuncia PRIMARY KEY CLUSTERED(
IdMotivoDenuncia ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
CONSTRAINT FK_MotivoDenuncia_Denuncia FOREIGN KEY (IdMotivoDenuncia)
	REFERENCES [dbo].[Denuncias]([IdDenuncia])
)
GO

/****** Object:  Table [dbo].[DonacionesInsumos] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonacionesInsumos](
	[IdDonacionInsumo] [int] IDENTITY(1,1) NOT NULL,
	[IdNecesidadDonacionInsumo] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
 CONSTRAINT [PK_DonacionesInsumos] PRIMARY KEY CLUSTERED(
 [IdDonacionInsumo] ASC
 )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT FK_DonacionesInsumos_Usuarios FOREIGN KEY ([IdUsuario])
		REFERENCES [dbo].[Usuarios]([IdUsuario])
)

GO

/****** Object:  Table [dbo].[DonacionesMonetarias] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonacionesMonetarias](
	[IdDonacionMonetaria] [int] IDENTITY(1,1) NOT NULL,
	[IdNecesidadDonacionMonetaria] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[Dinero] [decimal](18, 2) NOT NULL,
	[ArchivoTransferencia] [nvarchar](200) NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
 CONSTRAINT [PK_DonacionesMonetarias] PRIMARY KEY CLUSTERED (
 [IdDonacionMonetaria] ASC
 )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT FK_DonacionesMonetarias_Usuarios FOREIGN KEY ([IdUsuario])
		REFERENCES [dbo].[Usuarios]([IdUsuario])
)

GO

/****** Object:  Table [dbo].[UsuariosTipo] ******/
CREATE TABLE [dbo].DonacionTipo(
IdDonacionTipo int IDENTITY(1,1) NOT NULL,
Descripcion varchar(30) NOT NULL,
CONSTRAINT PK_DonacionTipo PRIMARY KEY CLUSTERED(
IdDonacionTipo ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
)
GO

/****** Object:  Table [dbo].[Necesidades] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Necesidades](
	[IdNecesidad] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Descripcion] [text] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[FechaFin] [datetime] NOT NULL,
	[TelefonoContacto] [nvarchar](30) NOT NULL,
	[TipoDonacion] [int] NOT NULL,
	[Foto] [nvarchar](100) NOT NULL,
	[IdUsuarioCreador] [int] NOT NULL,
	[Estado] [int] NOT NULL,
	[Valoracion] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Necesidades] PRIMARY KEY CLUSTERED (
 [IdNecesidad] ASC
 )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT FK_DonacionTipo_Necesidades FOREIGN KEY ([TipoDonacion])
		REFERENCES [dbo].[DonacionTipo]([IdDonacionTipo])
 )

GO

/****** Object:  Table [dbo].[NecesidadesValoraciones] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NecesidadesValoraciones](
	[IdValoracion] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[IdNecesidad] [int] NOT NULL,
	[Valoracion] [bit] NOT NULL,
 CONSTRAINT [PK_NecesidadesValoraciones] PRIMARY KEY CLUSTERED (
 [IdValoracion] ASC
 )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT FK_NecesidadesValoraciones_Usuarios FOREIGN KEY ([IdUsuario])
		REFERENCES [dbo].[Usuarios]([IdUsuario]),
 CONSTRAINT FK_NecesidadesValoraciones_Necesidades FOREIGN KEY ([IdNecesidad])
		REFERENCES [dbo].[Necesidades]([IdNecesidad])
)

GO

/****** Object:  Table [dbo].[NecesidadesDonacionesInsumos] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NecesidadesDonacionesInsumos](
	[IdNecesidadDonacionInsumo] [int] IDENTITY(1,1) NOT NULL,
	[IdNecesidad] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
 CONSTRAINT [PK_NecesidadesDonacionesInsumos] PRIMARY KEY CLUSTERED (
 [IdNecesidadDonacionInsumo] ASC
 )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT FK_NecesidadesDonacionesInsumos_DonacionesInsumos FOREIGN KEY ([IdNecesidadDonacionInsumo])
		REFERENCES [dbo].[DonacionesInsumos]([IdDonacionInsumo])
)

GO

/****** Object:  Table [dbo].[NecesidadesDonacionesMonetarias] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NecesidadesDonacionesMonetarias](
	[IdNecesidadDonacionMonetaria] [int] IDENTITY(1,1) NOT NULL,
	[IdNecesidad] [int] NOT NULL,
	[Dinero] [decimal](18, 2) NOT NULL,
	[CBU] [nvarchar](80) NOT NULL,
 CONSTRAINT [PK_NecesidadesDonacionesMonetarias] PRIMARY KEY CLUSTERED (
 [IdNecesidadDonacionMonetaria] ASC
 )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT FK_NecesidadesDonacionesMonetarias_DonacionesInsumos FOREIGN KEY ([IdNecesidadDonacionMonetaria])
		REFERENCES [dbo].[DonacionesMonetarias]([IdDonacionMonetaria])
)

GO

/****** Object:  Table [dbo].[NecesidadesReferencias] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NecesidadesReferencias](
	[IdReferencia] [int] IDENTITY(1,1) NOT NULL,
	[IdNecesidad] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Telefono] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NecesidadesReferencias] PRIMARY KEY CLUSTERED (
 [IdReferencia] ASC
 )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT FK_NecesidadesReferencias_Necesidades FOREIGN KEY ([IdNecesidad])
		REFERENCES [dbo].[Necesidades]([IdNecesidad])
)

GO

