USE [TP-20201C]
GO
/****** Object:  Table [dbo].[MotivoDenuncia]    Script Date: 15/06/2020 20:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MotivoDenuncia](
	[IdMotivoDenuncia] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](30) NOT NULL,
 CONSTRAINT [PK_MotivoDenuncia] PRIMARY KEY CLUSTERED 
(
	[IdMotivoDenuncia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[MotivoDenuncia]  WITH CHECK ADD  CONSTRAINT [FK_MotivoDenuncia_MotivoDenuncia] FOREIGN KEY([IdMotivoDenuncia])
REFERENCES [dbo].[MotivoDenuncia] ([IdMotivoDenuncia])
GO
ALTER TABLE [dbo].[MotivoDenuncia] CHECK CONSTRAINT [FK_MotivoDenuncia_MotivoDenuncia]
GO
