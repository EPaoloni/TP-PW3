USE [TP-20201C]
GO
/****** Object:  Table [dbo].[DenunciasComentario]    Script Date: 15/06/2020 15:23:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DenunciasComentario](
	[IdComentario] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [text] NOT NULL,
 CONSTRAINT [PK_DenunciasComentario] PRIMARY KEY CLUSTERED 
(
	[IdComentario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
