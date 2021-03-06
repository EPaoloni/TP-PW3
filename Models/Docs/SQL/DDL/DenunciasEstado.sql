USE [TP-20201C]
GO
/****** Object:  Table [dbo].[DenunciasEstado]    Script Date: 20/06/2020 20:14:37 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
