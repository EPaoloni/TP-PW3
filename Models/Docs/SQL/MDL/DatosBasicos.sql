USE [TP-20201C]
GO
SET IDENTITY_INSERT UsuariosTipo ON
INSERT INTO [dbo].[UsuariosTipo]
           (IdUsuarioTipo, Descripcion)
     VALUES
           (1,'Admin'),
		   (2,'Normal')

SET IDENTITY_INSERT UsuariosTipo OFF
GO

USE [TP-20201C]
GO

SET IDENTITY_INSERT [Usuarios] ON

INSERT INTO [dbo].[Usuarios]
           ([IdUsuario]
		   ,[Nombre]
           ,[Apellido]
           ,[FechaNacimiento]
           ,[UserName]
           ,[Email]
           ,[Password]
           ,[Foto]
           ,[TipoUsuario]
           ,[FechaCreacion]
           ,[Activo]
           ,[Token])
     VALUES
           (1
		   ,null
           ,null
           ,'19831205'
           ,null
           ,'jpabmai@gmail.com'
           ,'Pablo2020'
           ,null
           ,1
           ,'20200521'
           ,1
           ,'0A0WhCnC7YKkb9r3qeX6')
GO


SET IDENTITY_INSERT [Usuarios] OFF

GO

USE [TP-20201C]
GO
SET IDENTITY_INSERT [dbo].[DenunciasEstado] ON 

INSERT [dbo].[DenunciasEstado] ([IdDenunciaEstado], [Descripcion]) VALUES (1, N'Pendiente           ')
INSERT [dbo].[DenunciasEstado] ([IdDenunciaEstado], [Descripcion]) VALUES (2, N'Aprobado            ')
INSERT [dbo].[DenunciasEstado] ([IdDenunciaEstado], [Descripcion]) VALUES (3, N'Desestimado         ')
SET IDENTITY_INSERT [dbo].[DenunciasEstado] OFF



USE [TP-20201C]
GO
SET IDENTITY_INSERT [dbo].[DonacionesTipo] ON 

INSERT [dbo].[DonacionesTipo] ([IdDonacionTipo], [Descripcion]) VALUES (1, N'Monetaria')
INSERT [dbo].[DonacionesTipo] ([IdDonacionTipo], [Descripcion]) VALUES (2, N'Insumo')
SET IDENTITY_INSERT [dbo].[DonacionesTipo] OFF



USE [TP-20201C]
GO
SET IDENTITY_INSERT [dbo].[MotivoDenuncia] ON 

INSERT [dbo].[MotivoDenuncia] ([IdMotivoDenuncia], [Descripcion]) VALUES (1, N'Fraude')
INSERT [dbo].[MotivoDenuncia] ([IdMotivoDenuncia], [Descripcion]) VALUES (2, N'Indebida')
INSERT [dbo].[MotivoDenuncia] ([IdMotivoDenuncia], [Descripcion]) VALUES (3, N'Violación de derechos')
INSERT [dbo].[MotivoDenuncia] ([IdMotivoDenuncia], [Descripcion]) VALUES (4, N'Contiene información política')
SET IDENTITY_INSERT [dbo].[MotivoDenuncia] OFF


USE [TP-20201C]
GO
SET IDENTITY_INSERT [dbo].[NecesidadesEstado] ON 

INSERT [dbo].[NecesidadesEstado] ([IdNecesidadEstado], [Descripcion]) VALUES (1, N'Activo')
INSERT [dbo].[NecesidadesEstado] ([IdNecesidadEstado], [Descripcion]) VALUES (2, N'Bloqueado')
SET IDENTITY_INSERT [dbo].[NecesidadesEstado] OFF

