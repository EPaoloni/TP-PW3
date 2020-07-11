USE [TP-20201C]
GO
/****** Object:  Table [dbo].[Denuncias]    Script Date: 11/07/2020 14:12:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Denuncias](
	[IdDenuncia] [int] IDENTITY(1,1) NOT NULL,
	[IdNecesidad] [int] NOT NULL,
	[IdMotivo] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[Cometario] [text] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_Denuncias] PRIMARY KEY CLUSTERED 
(
	[IdDenuncia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DenunciasEstado]    Script Date: 11/07/2020 14:12:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DenunciasEstado](
	[IdDenunciaEstado] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nchar](20) NOT NULL,
 CONSTRAINT [PK_DenunciasEstado] PRIMARY KEY CLUSTERED 
(
	[IdDenunciaEstado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonacionesInsumos]    Script Date: 11/07/2020 14:12:24 ******/
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
 CONSTRAINT [PK_DonacionesInsumos] PRIMARY KEY CLUSTERED 
(
	[IdDonacionInsumo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonacionesMonetarias]    Script Date: 11/07/2020 14:12:24 ******/
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
 CONSTRAINT [PK_DonacionesMonetarias] PRIMARY KEY CLUSTERED 
(
	[IdDonacionMonetaria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonacionesTipo]    Script Date: 11/07/2020 14:12:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonacionesTipo](
	[IdDonacionTipo] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](30) NOT NULL,
 CONSTRAINT [PK_DonacionTipo] PRIMARY KEY CLUSTERED 
(
	[IdDonacionTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MotivoDenuncia]    Script Date: 11/07/2020 14:12:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MotivoDenuncia](
	[IdMotivoDenuncia] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](30) NOT NULL,
 CONSTRAINT [PK_MotivoDenuncia] PRIMARY KEY CLUSTERED 
(
	[IdMotivoDenuncia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Necesidades]    Script Date: 11/07/2020 14:12:24 ******/
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
 CONSTRAINT [PK_Necesidades] PRIMARY KEY CLUSTERED 
(
	[IdNecesidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NecesidadesDonacionesInsumos]    Script Date: 11/07/2020 14:12:24 ******/
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
 CONSTRAINT [PK_NecesidadesDonacionesInsumos_1] PRIMARY KEY CLUSTERED 
(
	[IdNecesidadDonacionInsumo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NecesidadesDonacionesMonetarias]    Script Date: 11/07/2020 14:12:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NecesidadesDonacionesMonetarias](
	[IdNecesidadDonacionMonetaria] [int] IDENTITY(1,1) NOT NULL,
	[IdNecesidad] [int] NOT NULL,
	[Dinero] [decimal](18, 2) NOT NULL,
	[CBU] [nvarchar](80) NOT NULL,
 CONSTRAINT [PK_NecesidadesDonacionesMonetarias] PRIMARY KEY CLUSTERED 
(
	[IdNecesidadDonacionMonetaria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NecesidadesEstado]    Script Date: 11/07/2020 14:12:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NecesidadesEstado](
	[IdNecesidadEstado] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nchar](20) NOT NULL,
 CONSTRAINT [PK_NecesidadesEstado] PRIMARY KEY CLUSTERED 
(
	[IdNecesidadEstado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NecesidadesReferencias]    Script Date: 11/07/2020 14:12:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NecesidadesReferencias](
	[IdReferencia] [int] IDENTITY(1,1) NOT NULL,
	[IdNecesidad] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Telefono] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NecesidadesReferencias] PRIMARY KEY CLUSTERED 
(
	[IdReferencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NecesidadesValoraciones]    Script Date: 11/07/2020 14:12:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NecesidadesValoraciones](
	[IdValoracion] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[IdNecesidad] [int] NOT NULL,
	[Valoracion] [bit] NOT NULL,
 CONSTRAINT [PK_NecesidadesValoraciones] PRIMARY KEY CLUSTERED 
(
	[IdValoracion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 11/07/2020 14:12:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Apellido] [nvarchar](50) NULL,
	[FechaNacimiento] [datetime] NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Foto] [nvarchar](100) NULL,
	[TipoUsuario] [int] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[Activo] [bit] NOT NULL,
	[Token] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuariosTipo]    Script Date: 11/07/2020 14:12:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuariosTipo](
	[IdUsuarioTipo] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](30) NOT NULL,
 CONSTRAINT [PK_UsuariosTipo] PRIMARY KEY CLUSTERED 
(
	[IdUsuarioTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Denuncias]  WITH CHECK ADD  CONSTRAINT [FK_Denuncia_MotivoDenuncia] FOREIGN KEY([IdMotivo])
REFERENCES [dbo].[MotivoDenuncia] ([IdMotivoDenuncia])
GO
ALTER TABLE [dbo].[Denuncias] CHECK CONSTRAINT [FK_Denuncia_MotivoDenuncia]
GO
ALTER TABLE [dbo].[Denuncias]  WITH CHECK ADD  CONSTRAINT [FK_Denuncias_Usuarios] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuarios] ([IdUsuario])
GO
ALTER TABLE [dbo].[Denuncias] CHECK CONSTRAINT [FK_Denuncias_Usuarios]
GO
ALTER TABLE [dbo].[Denuncias]  WITH CHECK ADD  CONSTRAINT [FK_DenunciasEstado_Denuncias] FOREIGN KEY([Estado])
REFERENCES [dbo].[DenunciasEstado] ([IdDenunciaEstado])
GO
ALTER TABLE [dbo].[Denuncias] CHECK CONSTRAINT [FK_DenunciasEstado_Denuncias]
GO
ALTER TABLE [dbo].[Denuncias]  WITH CHECK ADD  CONSTRAINT [FK_MotivoDenuncia_Denuncias] FOREIGN KEY([IdMotivo])
REFERENCES [dbo].[MotivoDenuncia] ([IdMotivoDenuncia])
GO
ALTER TABLE [dbo].[Denuncias] CHECK CONSTRAINT [FK_MotivoDenuncia_Denuncias]
GO
ALTER TABLE [dbo].[Denuncias]  WITH CHECK ADD  CONSTRAINT [FK_Necesidad_Denuncias] FOREIGN KEY([IdNecesidad])
REFERENCES [dbo].[Necesidades] ([IdNecesidad])
GO
ALTER TABLE [dbo].[Denuncias] CHECK CONSTRAINT [FK_Necesidad_Denuncias]
GO
ALTER TABLE [dbo].[DonacionesInsumos]  WITH CHECK ADD  CONSTRAINT [FK_DonacionesInsumos_NecesidadesDonacionesInsumos] FOREIGN KEY([IdNecesidadDonacionInsumo])
REFERENCES [dbo].[NecesidadesDonacionesInsumos] ([IdNecesidadDonacionInsumo])
GO
ALTER TABLE [dbo].[DonacionesInsumos] CHECK CONSTRAINT [FK_DonacionesInsumos_NecesidadesDonacionesInsumos]
GO
ALTER TABLE [dbo].[DonacionesInsumos]  WITH CHECK ADD  CONSTRAINT [FK_DonacionesInsumos_Usuarios] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuarios] ([IdUsuario])
GO
ALTER TABLE [dbo].[DonacionesInsumos] CHECK CONSTRAINT [FK_DonacionesInsumos_Usuarios]
GO
ALTER TABLE [dbo].[DonacionesMonetarias]  WITH CHECK ADD  CONSTRAINT [FK_DonacionesMonetarias_NecesidadesDonacionesMonetarias] FOREIGN KEY([IdNecesidadDonacionMonetaria])
REFERENCES [dbo].[NecesidadesDonacionesMonetarias] ([IdNecesidadDonacionMonetaria])
GO
ALTER TABLE [dbo].[DonacionesMonetarias] CHECK CONSTRAINT [FK_DonacionesMonetarias_NecesidadesDonacionesMonetarias]
GO
ALTER TABLE [dbo].[DonacionesMonetarias]  WITH CHECK ADD  CONSTRAINT [FK_DonacionesMonetarias_Usuarios] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuarios] ([IdUsuario])
GO
ALTER TABLE [dbo].[DonacionesMonetarias] CHECK CONSTRAINT [FK_DonacionesMonetarias_Usuarios]
GO
ALTER TABLE [dbo].[Necesidades]  WITH CHECK ADD  CONSTRAINT [FK_DonacionTipo_Necesidades] FOREIGN KEY([TipoDonacion])
REFERENCES [dbo].[DonacionesTipo] ([IdDonacionTipo])
GO
ALTER TABLE [dbo].[Necesidades] CHECK CONSTRAINT [FK_DonacionTipo_Necesidades]
GO
ALTER TABLE [dbo].[Necesidades]  WITH CHECK ADD  CONSTRAINT [FK_NecesidadesEstado_Necesidades] FOREIGN KEY([Estado])
REFERENCES [dbo].[NecesidadesEstado] ([IdNecesidadEstado])
GO
ALTER TABLE [dbo].[Necesidades] CHECK CONSTRAINT [FK_NecesidadesEstado_Necesidades]
GO
ALTER TABLE [dbo].[Necesidades]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Necesidades] FOREIGN KEY([IdUsuarioCreador])
REFERENCES [dbo].[Usuarios] ([IdUsuario])
GO
ALTER TABLE [dbo].[Necesidades] CHECK CONSTRAINT [FK_Usuarios_Necesidades]
GO
ALTER TABLE [dbo].[NecesidadesDonacionesInsumos]  WITH CHECK ADD  CONSTRAINT [FK_NecesidadesDonacionesInsumos_Necesidades] FOREIGN KEY([IdNecesidad])
REFERENCES [dbo].[Necesidades] ([IdNecesidad])
GO
ALTER TABLE [dbo].[NecesidadesDonacionesInsumos] CHECK CONSTRAINT [FK_NecesidadesDonacionesInsumos_Necesidades]
GO
ALTER TABLE [dbo].[NecesidadesDonacionesMonetarias]  WITH CHECK ADD  CONSTRAINT [FK_NecesidadesDonacionesMonetarias_Necesidades] FOREIGN KEY([IdNecesidad])
REFERENCES [dbo].[Necesidades] ([IdNecesidad])
GO
ALTER TABLE [dbo].[NecesidadesDonacionesMonetarias] CHECK CONSTRAINT [FK_NecesidadesDonacionesMonetarias_Necesidades]
GO
ALTER TABLE [dbo].[NecesidadesReferencias]  WITH CHECK ADD  CONSTRAINT [FK_NecesidadesReferencias_Necesidades] FOREIGN KEY([IdNecesidad])
REFERENCES [dbo].[Necesidades] ([IdNecesidad])
GO
ALTER TABLE [dbo].[NecesidadesReferencias] CHECK CONSTRAINT [FK_NecesidadesReferencias_Necesidades]
GO
ALTER TABLE [dbo].[NecesidadesValoraciones]  WITH CHECK ADD  CONSTRAINT [FK_NecesidadesValoraciones_Necesidades] FOREIGN KEY([IdNecesidad])
REFERENCES [dbo].[Necesidades] ([IdNecesidad])
GO
ALTER TABLE [dbo].[NecesidadesValoraciones] CHECK CONSTRAINT [FK_NecesidadesValoraciones_Necesidades]
GO
ALTER TABLE [dbo].[NecesidadesValoraciones]  WITH CHECK ADD  CONSTRAINT [FK_NecesidadesValoraciones_Usuarios] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuarios] ([IdUsuario])
GO
ALTER TABLE [dbo].[NecesidadesValoraciones] CHECK CONSTRAINT [FK_NecesidadesValoraciones_Usuarios]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_UsuariosTipo] FOREIGN KEY([TipoUsuario])
REFERENCES [dbo].[UsuariosTipo] ([IdUsuarioTipo])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_UsuariosTipo]
GO
