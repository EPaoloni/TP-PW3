USE [TP-20201C]
GO
/****** Object:  Table [dbo].[NecesidadesEstado]    Script Date: 15/06/2020 11:47:29 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
