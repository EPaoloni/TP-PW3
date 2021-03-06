USE [TP-20201C]
GO
/****** Object:  Table [dbo].[DenunciasCometarios]    Script Date: 20/06/2020 20:11:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DenunciasCometarios](
	[idDenuncia] [int] NOT NULL,
	[idCometario] [int] NOT NULL,
 CONSTRAINT [PK_DenunciasCometarios_1] PRIMARY KEY CLUSTERED 
(
	[idDenuncia] ASC,
	[idCometario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[DenunciasCometarios]  WITH CHECK ADD  CONSTRAINT [FK_Comentarios_DenunciasCometarios] FOREIGN KEY([idCometario])
REFERENCES [dbo].[Comentarios] ([IdComentario])
GO
ALTER TABLE [dbo].[DenunciasCometarios] CHECK CONSTRAINT [FK_Comentarios_DenunciasCometarios]
GO
ALTER TABLE [dbo].[DenunciasCometarios]  WITH CHECK ADD  CONSTRAINT [FK_Denuncias_DenunciasCometarios] FOREIGN KEY([idDenuncia])
REFERENCES [dbo].[Denuncias] ([IdDenuncia])
GO
ALTER TABLE [dbo].[DenunciasCometarios] CHECK CONSTRAINT [FK_Denuncias_DenunciasCometarios]
GO
