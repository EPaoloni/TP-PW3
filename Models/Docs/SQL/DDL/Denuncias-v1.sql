USE [TP-20201C]
GO
/****** Object:  Table [dbo].[Denuncias]    Script Date: 15/06/2020 15:13:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Denuncias](
	[IdDenuncia] [int] IDENTITY(1,1) NOT NULL,
	[IdNecesidad] [int] NOT NULL,
	[IdMotivo] [int] NOT NULL,
	[IdComentarios] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_Denuncias] PRIMARY KEY CLUSTERED 
(
	[IdDenuncia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Denuncias]  WITH CHECK ADD  CONSTRAINT [FK_Denuncias_Usuarios] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuarios] ([IdUsuario])
GO
ALTER TABLE [dbo].[Denuncias] CHECK CONSTRAINT [FK_Denuncias_Usuarios]
GO
ALTER TABLE [dbo].[Denuncias]  WITH CHECK ADD  CONSTRAINT [FK_DenunciasCometario_Denuncias] FOREIGN KEY([IdComentarios])
REFERENCES [dbo].[DenunciasComentario] ([IdComentario])
GO
ALTER TABLE [dbo].[Denuncias] CHECK CONSTRAINT [FK_DenunciasCometario_Denuncias]
GO
ALTER TABLE [dbo].[Denuncias]  WITH CHECK ADD  CONSTRAINT [FK_DenunciasEstado_Denuncias] FOREIGN KEY([IdDenuncia])
REFERENCES [dbo].[DenunciasEstado] ([IdDenunciaEstado])
GO
ALTER TABLE [dbo].[Denuncias] CHECK CONSTRAINT [FK_DenunciasEstado_Denuncias]
GO
