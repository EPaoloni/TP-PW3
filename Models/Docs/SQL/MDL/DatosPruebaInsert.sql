USE [TP-20201C]
GO
SET IDENTITY_INSERT [dbo].[UsuariosTipo] ON 

INSERT [dbo].[UsuariosTipo] ([IdUsuarioTipo], [Descripcion]) VALUES (1, N'Admin')
INSERT [dbo].[UsuariosTipo] ([IdUsuarioTipo], [Descripcion]) VALUES (2, N'Normal')
SET IDENTITY_INSERT [dbo].[UsuariosTipo] OFF
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [FechaNacimiento], [UserName], [Email], [Password], [Foto], [TipoUsuario], [FechaCreacion], [Activo], [Token]) VALUES (1, NULL, NULL, CAST(N'2020-04-07 00:00:00.000' AS DateTime), N'Admin', N'admin@ayudando.com.ar', N'Admin2020', NULL, 1, CAST(N'2020-04-07 00:00:00.000' AS DateTime), 1, N'f1Up71vG2WFIQiPa')
INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [FechaNacimiento], [UserName], [Email], [Password], [Foto], [TipoUsuario], [FechaCreacion], [Activo], [Token]) VALUES (2, N'Julia', N'Hernandez', CAST(N'2000-05-06 00:00:00.000' AS DateTime), N'Julia.Hernandez', N'Julia.Hernandez@gmail.com', N'Julia2020', N'Files\Julia.Hernandez\perfil.png', 2, CAST(N'2020-05-05 00:00:00.000' AS DateTime), 1, N'KcYvmo4e0TxB0904')
INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [FechaNacimiento], [UserName], [Email], [Password], [Foto], [TipoUsuario], [FechaCreacion], [Activo], [Token]) VALUES (3, N'Maria', N'Perez', CAST(N'1995-02-17 00:00:00.000' AS DateTime), N'Maria.Perez', N'Maria.Perez@yahoo.com', N'Maria2020', N'Files\Maria.Perez\perfil.png', 2, CAST(N'2020-05-05 00:00:00.000' AS DateTime), 1, N'EZufMMYXQDIC8yLB')
INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [FechaNacimiento], [UserName], [Email], [Password], [Foto], [TipoUsuario], [FechaCreacion], [Activo], [Token]) VALUES (4, N'Emilia', N'Gomez', CAST(N'1990-06-25 00:00:00.000' AS DateTime), N'Emilia.Gomez', N'Emilia.Gomez@gmail.com', N'Emilia2020', N'Files\Emilia.Gomez\perfil.png', 2, CAST(N'2020-05-06 00:00:00.000' AS DateTime), 1, N'iRBBJenAkipgvted')
INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [FechaNacimiento], [UserName], [Email], [Password], [Foto], [TipoUsuario], [FechaCreacion], [Activo], [Token]) VALUES (5, N'Maria', N'Perez', CAST(N'1993-04-08 00:00:00.000' AS DateTime), N'Maria.Perez.1', N'Maria.Perez.1@hotmail.com', N'Maria12020', N'Files\Maria.Perez.1\perfil.png', 2, CAST(N'2020-05-06 00:00:00.000' AS DateTime), 1, N'jlfxJE3mX4PmKgxY')
INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [FechaNacimiento], [UserName], [Email], [Password], [Foto], [TipoUsuario], [FechaCreacion], [Activo], [Token]) VALUES (6, N'Brenda', N'Sosa', CAST(N'1988-02-20 00:00:00.000' AS DateTime), N'Brenda.Sosa', N'Brenda.Sosa@yahoo.com.ar', N'Brenda2020', N'Files\Brenda.Sosa\perfil.png', 2, CAST(N'2020-05-07 00:00:00.000' AS DateTime), 1, N'XkDASMTpVFmzlbAH')
INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [FechaNacimiento], [UserName], [Email], [Password], [Foto], [TipoUsuario], [FechaCreacion], [Activo], [Token]) VALUES (7, N'Maria', N'Perez', CAST(N'1999-09-15 00:00:00.000' AS DateTime), N'Maria.Perez.2', N'Maria.Perez.2@outlook.com', N'Maria22020', N'Files\Maria.Perez.2\perfil.png', 2, CAST(N'2020-05-12 00:00:00.000' AS DateTime), 1, N'KTfmz1nkufFHPC7i')
INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [FechaNacimiento], [UserName], [Email], [Password], [Foto], [TipoUsuario], [FechaCreacion], [Activo], [Token]) VALUES (8, N'Paula', N'Garcia', CAST(N'1993-03-22 00:00:00.000' AS DateTime), N'Paula.Garcia', N'Paula.Garcia@gmail.com', N'Paula2020', N'Files\Paula.Garcia\perfil.png', 2, CAST(N'2020-05-14 00:00:00.000' AS DateTime), 1, N'3sx1bYy22Vuk5H3J')
INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [FechaNacimiento], [UserName], [Email], [Password], [Foto], [TipoUsuario], [FechaCreacion], [Activo], [Token]) VALUES (9, N'Sofia', N'Sanchez', CAST(N'1991-05-26 00:00:00.000' AS DateTime), N'Sofia.Sanchez', N'Sofia.Sanchez@hotmail.com', N'Sofia2020', N'Files\Sofia.Sanchez\perfil.png', 2, CAST(N'2020-05-14 00:00:00.000' AS DateTime), 1, N'gafa7YoANjK7FjGx')
INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [FechaNacimiento], [UserName], [Email], [Password], [Foto], [TipoUsuario], [FechaCreacion], [Activo], [Token]) VALUES (10, N'Daniel', N'Gonzalez', CAST(N'1999-06-05 00:00:00.000' AS DateTime), N'Daniel.Gonzalez', N'Daniel.Gonzalez@live.com', N'Daniel2020', N'Files\Daniel.Gonzalez\perfil.png', 2, CAST(N'2020-05-15 00:00:00.000' AS DateTime), 1, N'JYJmYfbDyopumx18')
INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [FechaNacimiento], [UserName], [Email], [Password], [Foto], [TipoUsuario], [FechaCreacion], [Activo], [Token]) VALUES (11, N'Matias', N'Diaz', CAST(N'1992-07-05 00:00:00.000' AS DateTime), N'Matias.Diaz', N'Matias.Diaz@gmail.com', N'Matias2020', N'Files\Matias.Diaz\perfil.png', 2, CAST(N'2020-05-15 00:00:00.000' AS DateTime), 1, N'mKFy3erzbCZsK6WC')
INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [FechaNacimiento], [UserName], [Email], [Password], [Foto], [TipoUsuario], [FechaCreacion], [Activo], [Token]) VALUES (12, N'Javier', N'Garcia', CAST(N'1994-08-12 00:00:00.000' AS DateTime), N'Javier.Garcia', N'Javier.Garcia@hotmail.com', N'Javier2020', N'Files\Javier.Garcia\perfil.png', 2, CAST(N'2020-05-15 00:00:00.000' AS DateTime), 1, N'BySUKFOVN6euoycF')
INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [FechaNacimiento], [UserName], [Email], [Password], [Foto], [TipoUsuario], [FechaCreacion], [Activo], [Token]) VALUES (13, N'Daniel', N'Gonzalez', CAST(N'1989-04-02 00:00:00.000' AS DateTime), N'Daniel.Gonzalez.1', N'Daniel.Gonzalez.1@hotmail.com', N'Daniel12020', N'Files\Daniel.Gonzalez.1\perfil.png', 2, CAST(N'2020-05-16 00:00:00.000' AS DateTime), 1, N'pfthqGrVHoWiYvXS')
INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [FechaNacimiento], [UserName], [Email], [Password], [Foto], [TipoUsuario], [FechaCreacion], [Activo], [Token]) VALUES (14, N'Javier', N'Garcia', CAST(N'1990-05-24 00:00:00.000' AS DateTime), N'Javier.Garcia.1', N'Javier.Garcia.1@live.com', N'Javier12020', N'Files\Javier.Garcia.1\perfil.png', 2, CAST(N'2020-05-16 00:00:00.000' AS DateTime), 1, N'BuiGLnvDHKigWvGc')
INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [FechaNacimiento], [UserName], [Email], [Password], [Foto], [TipoUsuario], [FechaCreacion], [Activo], [Token]) VALUES (15, N'Esteban', N'Romero', CAST(N'1992-11-04 00:00:00.000' AS DateTime), N'Esteban.Romero', N'Esteban.Romero@gmail.com', N'Esteban2020', N'Files\Esteban.Romero\perfil.png', 2, CAST(N'2020-05-19 00:00:00.000' AS DateTime), 1, N'5NGWiNLVJ8y0uWjU')
INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [FechaNacimiento], [UserName], [Email], [Password], [Foto], [TipoUsuario], [FechaCreacion], [Activo], [Token]) VALUES (16, N'Daniel', N'Gonzalez', CAST(N'1989-06-12 00:00:00.000' AS DateTime), N'Daniel.Gonzalez.2', N'Daniel.Gonzalez.2@gmail', N'Daniel22020', N'Files\Daniel.Gonzalez.2\perfil.png', 2, CAST(N'2020-04-19 00:00:00.000' AS DateTime), 1, N'EvX8GmjQNE7BpC9Z')
INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [FechaNacimiento], [UserName], [Email], [Password], [Foto], [TipoUsuario], [FechaCreacion], [Activo], [Token]) VALUES (17, N'Mario', N'Flores', CAST(N'1997-02-25 00:00:00.000' AS DateTime), N'Mario.Flores', N'Mario.Flores@outlook.com', N'Mario2020', N'Files\Mario.Flores\perfil.png', 2, CAST(N'2020-04-19 00:00:00.000' AS DateTime), 1, N'lf4ItLt1QBzDH8qW')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
SET IDENTITY_INSERT [dbo].[DonacionesTipo] ON 

INSERT [dbo].[DonacionesTipo] ([IdDonacionTipo], [Descripcion]) VALUES (1, N'Monetaria')
INSERT [dbo].[DonacionesTipo] ([IdDonacionTipo], [Descripcion]) VALUES (2, N'Insumo')
SET IDENTITY_INSERT [dbo].[DonacionesTipo] OFF
SET IDENTITY_INSERT [dbo].[NecesidadesEstado] ON 

INSERT [dbo].[NecesidadesEstado] ([IdNecesidadEstado], [Descripcion]) VALUES (1, N'Activo              ')
INSERT [dbo].[NecesidadesEstado] ([IdNecesidadEstado], [Descripcion]) VALUES (2, N'Cerrado             ')
SET IDENTITY_INSERT [dbo].[NecesidadesEstado] OFF
SET IDENTITY_INSERT [dbo].[Necesidades] ON 

INSERT [dbo].[Necesidades] ([IdNecesidad], [Nombre], [Descripcion], [FechaCreacion], [FechaFin], [TelefonoContacto], [TipoDonacion], [Foto], [IdUsuarioCreador], [Estado], [Valoracion]) VALUES (1, N'Comedor Carlos Mujica
', N'Se necesita alimentos no perecedero para gente de pocos recursos económicos
', CAST(N'2020-05-06 00:00:00.000' AS DateTime), CAST(N'2020-05-14 00:00:00.000' AS DateTime), N'11-4523-4589
', 2, N'Images\Necesidad\img.png
', 2, 2, NULL)
INSERT [dbo].[Necesidades] ([IdNecesidad], [Nombre], [Descripcion], [FechaCreacion], [FechaFin], [TelefonoContacto], [TipoDonacion], [Foto], [IdUsuarioCreador], [Estado], [Valoracion]) VALUES (2, N'UNICEF Argentina
', N'Necesitamos la colaboracion monetaria para ayudar a los chicos del virus COVID
', CAST(N'2020-05-20 00:00:00.000' AS DateTime), CAST(N'2020-06-12 00:00:00.000' AS DateTime), N'11-2525-8000
', 1, N'Images\Necesidad\img.png
', 12, 2, NULL)
INSERT [dbo].[Necesidades] ([IdNecesidad], [Nombre], [Descripcion], [FechaCreacion], [FechaFin], [TelefonoContacto], [TipoDonacion], [Foto], [IdUsuarioCreador], [Estado], [Valoracion]) VALUES (3, N'Apoyo al Hospital Britanico
', N'No se dispone con los recursos para comprar insumos de uso habitual en el Hospital Británico
', CAST(N'2020-06-10 00:00:00.000' AS DateTime), CAST(N'2020-07-10 00:00:00.000' AS DateTime), N'11-4523-4589
', 1, N'Images\Necesidad\img.png
', 2, 1, NULL)
INSERT [dbo].[Necesidades] ([IdNecesidad], [Nombre], [Descripcion], [FechaCreacion], [FechaFin], [TelefonoContacto], [TipoDonacion], [Foto], [IdUsuarioCreador], [Estado], [Valoracion]) VALUES (4, N'Fundacion Pilares
', N'Necesitamos donación monetaria para poder realizar el mantenimiento edilicio de la Fundación
', CAST(N'2020-06-12 00:00:00.000' AS DateTime), CAST(N'2020-07-20 00:00:00.000' AS DateTime), N'11-3566-7865
', 1, N'Images\Necesidad\img.png
', 3, 1, NULL)
INSERT [dbo].[Necesidades] ([IdNecesidad], [Nombre], [Descripcion], [FechaCreacion], [FechaFin], [TelefonoContacto], [TipoDonacion], [Foto], [IdUsuarioCreador], [Estado], [Valoracion]) VALUES (5, N'Cruz Roja Argentina
', N'Es necesario de la donacion de insumos de primeros auxilios
', CAST(N'2020-06-12 00:00:00.000' AS DateTime), CAST(N'2020-07-22 00:00:00.000' AS DateTime), N'11-6064-0450
', 2, N'Images\Necesidad\img.png
', 4, 1, NULL)
INSERT [dbo].[Necesidades] ([IdNecesidad], [Nombre], [Descripcion], [FechaCreacion], [FechaFin], [TelefonoContacto], [TipoDonacion], [Foto], [IdUsuarioCreador], [Estado], [Valoracion]) VALUES (6, N'Fundacion Redes Solidarias
', N'Se necesita la donacion de juguetes para los chicos de sectores vulnerables
', CAST(N'2020-06-12 00:00:00.000' AS DateTime), CAST(N'2020-07-24 00:00:00.000' AS DateTime), N'11-5688-8956
', 2, N'Images\Necesidad\img.png
', 2, 1, NULL)
INSERT [dbo].[Necesidades] ([IdNecesidad], [Nombre], [Descripcion], [FechaCreacion], [FechaFin], [TelefonoContacto], [TipoDonacion], [Foto], [IdUsuarioCreador], [Estado], [Valoracion]) VALUES (7, N'Dona a Greenpeace
', N'Se necesita la colaboracion monetaria para la ayuda al medio ambiente
', CAST(N'2020-06-16 00:00:00.000' AS DateTime), CAST(N'2020-07-20 00:00:00.000' AS DateTime), N'11-4000-5000
', 1, N'Images\Necesidad\img.png
', 10, 1, NULL)
INSERT [dbo].[Necesidades] ([IdNecesidad], [Nombre], [Descripcion], [FechaCreacion], [FechaFin], [TelefonoContacto], [TipoDonacion], [Foto], [IdUsuarioCreador], [Estado], [Valoracion]) VALUES (8, N'TECHO
', N'Necesitamos la donacion de material de contruccion para poder construir viviendas a la gente de pocos recursos economicos
', CAST(N'2020-06-16 00:00:00.000' AS DateTime), CAST(N'2020-07-22 00:00:00.000' AS DateTime), N'11-5689-4578
', 2, N'Images\Necesidad\img.png
', 15, 1, NULL)
INSERT [dbo].[Necesidades] ([IdNecesidad], [Nombre], [Descripcion], [FechaCreacion], [FechaFin], [TelefonoContacto], [TipoDonacion], [Foto], [IdUsuarioCreador], [Estado], [Valoracion]) VALUES (9, N'Fundacion Noelia
', N'Se necesita la donacion monetaria para poder construir un comedor comunitario
', CAST(N'2020-06-18 00:00:00.000' AS DateTime), CAST(N'2020-07-20 00:00:00.000' AS DateTime), N'11-4556-7887
', 1, N'Images\Necesidad\img.png
', 16, 1, NULL)
INSERT [dbo].[Necesidades] ([IdNecesidad], [Nombre], [Descripcion], [FechaCreacion], [FechaFin], [TelefonoContacto], [TipoDonacion], [Foto], [IdUsuarioCreador], [Estado], [Valoracion]) VALUES (10, N'Fundacion San Francisco
', N'Es necesario la provision de alimentos no perecedero para gente de pocos recursos económicos
', CAST(N'2020-06-18 00:00:00.000' AS DateTime), CAST(N'2020-07-20 00:00:00.000' AS DateTime), N'11-2356-5689
', 2, N'Images\Necesidad\img.png
', 17, 1, NULL)
INSERT [dbo].[Necesidades] ([IdNecesidad], [Nombre], [Descripcion], [FechaCreacion], [FechaFin], [TelefonoContacto], [TipoDonacion], [Foto], [IdUsuarioCreador], [Estado], [Valoracion]) VALUES (11, N'Fundacion Pupi
', N'Nesecitamos la colaboracion de su donacion monetaria para los chicos de bajos recursos
', CAST(N'2020-06-20 00:00:00.000' AS DateTime), CAST(N'2020-07-24 00:00:00.000' AS DateTime), N'11-2000-7000
', 1, N'Images\Necesidad\img.png
', 11, 1, NULL)
INSERT [dbo].[Necesidades] ([IdNecesidad], [Nombre], [Descripcion], [FechaCreacion], [FechaFin], [TelefonoContacto], [TipoDonacion], [Foto], [IdUsuarioCreador], [Estado], [Valoracion]) VALUES (12, N'Volver a empezar
', N'La fundacion necesita la colaboracion de alimentos no perecederos a las victimas del Corona Virus
', CAST(N'2020-06-20 00:00:00.000' AS DateTime), CAST(N'2020-07-25 00:00:00.000' AS DateTime), N'11-4520-5689
', 2, N'Images\Necesidad\img.png
', 6, 1, NULL)
INSERT [dbo].[Necesidades] ([IdNecesidad], [Nombre], [Descripcion], [FechaCreacion], [FechaFin], [TelefonoContacto], [TipoDonacion], [Foto], [IdUsuarioCreador], [Estado], [Valoracion]) VALUES (13, N'Fundacion Cel
', N'Es necesaria la donacion monetaria para la compra de insumos para el Hospital Italiano
', CAST(N'2020-06-20 00:00:00.000' AS DateTime), CAST(N'2020-07-24 00:00:00.000' AS DateTime), N'11-4486-2056
', 1, N'Images\Necesidad\img.png
', 7, 1, NULL)
INSERT [dbo].[Necesidades] ([IdNecesidad], [Nombre], [Descripcion], [FechaCreacion], [FechaFin], [TelefonoContacto], [TipoDonacion], [Foto], [IdUsuarioCreador], [Estado], [Valoracion]) VALUES (14, N'Creality 3D
', N'Necesitamos la donacion de insumos para la creacion de mascaras de proteccion
', CAST(N'2020-06-20 00:00:00.000' AS DateTime), CAST(N'2020-07-24 00:00:00.000' AS DateTime), N'11-2356-5689
', 2, N'Images\Necesidad\img.png
', 17, 1, NULL)
INSERT [dbo].[Necesidades] ([IdNecesidad], [Nombre], [Descripcion], [FechaCreacion], [FechaFin], [TelefonoContacto], [TipoDonacion], [Foto], [IdUsuarioCreador], [Estado], [Valoracion]) VALUES (15, N'Fundacion Padre Agustin
', N'Se necesita la donacion de alimentos no perecederos para la gente de pocos recursos
', CAST(N'2020-06-21 00:00:00.000' AS DateTime), CAST(N'2020-07-21 00:00:00.000' AS DateTime), N'11-2356-5689
', 2, N'Images\Necesidad\img.png
', 17, 1, NULL)
INSERT [dbo].[Necesidades] ([IdNecesidad], [Nombre], [Descripcion], [FechaCreacion], [FechaFin], [TelefonoContacto], [TipoDonacion], [Foto], [IdUsuarioCreador], [Estado], [Valoracion]) VALUES (16, N'Fundacion Emiliano
', N'Se requiere la colaboracion monetaria para poder ayudar en el comedor comunitario
', CAST(N'2020-06-21 00:00:00.000' AS DateTime), CAST(N'2020-07-21 00:00:00.000' AS DateTime), N'11-2589-5645
', 1, N'Images\Necesidad\img.png
', 8, 1, NULL)
SET IDENTITY_INSERT [dbo].[Necesidades] OFF
SET IDENTITY_INSERT [dbo].[NecesidadesReferencias] ON 

INSERT [dbo].[NecesidadesReferencias] ([IdReferencia], [IdNecesidad], [Nombre], [Telefono]) VALUES (1, 1, N'Maria Lopez', N'11-4565-4589')
INSERT [dbo].[NecesidadesReferencias] ([IdReferencia], [IdNecesidad], [Nombre], [Telefono]) VALUES (2, 1, N'Norma Perotti', N'11-3060-4565')
INSERT [dbo].[NecesidadesReferencias] ([IdReferencia], [IdNecesidad], [Nombre], [Telefono]) VALUES (3, 2, N'Carlos Foti', N'11-2600-8545')
INSERT [dbo].[NecesidadesReferencias] ([IdReferencia], [IdNecesidad], [Nombre], [Telefono]) VALUES (4, 2, N'Raul Mendez', N'11-5678-8956')
INSERT [dbo].[NecesidadesReferencias] ([IdReferencia], [IdNecesidad], [Nombre], [Telefono]) VALUES (5, 3, N'Lionel Messi
', N'11-4765-5645
')
INSERT [dbo].[NecesidadesReferencias] ([IdReferencia], [IdNecesidad], [Nombre], [Telefono]) VALUES (6, 3, N'Pepe Argento
', N'11-2587-5645
')
INSERT [dbo].[NecesidadesReferencias] ([IdReferencia], [IdNecesidad], [Nombre], [Telefono]) VALUES (7, 4, N'Alberto Gonzalez
', N'11-2578-7856
')
INSERT [dbo].[NecesidadesReferencias] ([IdReferencia], [IdNecesidad], [Nombre], [Telefono]) VALUES (8, 4, N'Sofia Martinez
', N'11-2654-8978
')
INSERT [dbo].[NecesidadesReferencias] ([IdReferencia], [IdNecesidad], [Nombre], [Telefono]) VALUES (9, 5, N'Carolina Fernandez
', N'11-3645-5689
')
INSERT [dbo].[NecesidadesReferencias] ([IdReferencia], [IdNecesidad], [Nombre], [Telefono]) VALUES (10, 5, N'Mario Lopez
', N'11-5852-4589
')
INSERT [dbo].[NecesidadesReferencias] ([IdReferencia], [IdNecesidad], [Nombre], [Telefono]) VALUES (11, 6, N'Daniel Sosa
', N'11-5262-5678
')
INSERT [dbo].[NecesidadesReferencias] ([IdReferencia], [IdNecesidad], [Nombre], [Telefono]) VALUES (12, 6, N'Pablo Maidana
', N'11-4565-7595
')
INSERT [dbo].[NecesidadesReferencias] ([IdReferencia], [IdNecesidad], [Nombre], [Telefono]) VALUES (13, 7, N'Jorge Ruiz
', N'11-1564-8978
')
INSERT [dbo].[NecesidadesReferencias] ([IdReferencia], [IdNecesidad], [Nombre], [Telefono]) VALUES (14, 7, N'Alejandro Acosta
', N'11-9485-5678
')
INSERT [dbo].[NecesidadesReferencias] ([IdReferencia], [IdNecesidad], [Nombre], [Telefono]) VALUES (15, 8, N'Martin Silva
', N'11-5678-2651
')
INSERT [dbo].[NecesidadesReferencias] ([IdReferencia], [IdNecesidad], [Nombre], [Telefono]) VALUES (16, 8, N'Juana Ramos
', N'11-7856-8451
')
INSERT [dbo].[NecesidadesReferencias] ([IdReferencia], [IdNecesidad], [Nombre], [Telefono]) VALUES (18, 9, N'Nahuel Navarro
', N'11-3054-8945
')
INSERT [dbo].[NecesidadesReferencias] ([IdReferencia], [IdNecesidad], [Nombre], [Telefono]) VALUES (19, 9, N'Jesica Coronel
', N'11-5645-8978
')
INSERT [dbo].[NecesidadesReferencias] ([IdReferencia], [IdNecesidad], [Nombre], [Telefono]) VALUES (20, 10, N'Cristina Cordoba
', N'11-4584-6235
')
INSERT [dbo].[NecesidadesReferencias] ([IdReferencia], [IdNecesidad], [Nombre], [Telefono]) VALUES (21, 10, N'Paola Vargas
', N'11-5678-8954
')
INSERT [dbo].[NecesidadesReferencias] ([IdReferencia], [IdNecesidad], [Nombre], [Telefono]) VALUES (23, 11, N'Ariel Vera
', N'11-2546-6584
')
INSERT [dbo].[NecesidadesReferencias] ([IdReferencia], [IdNecesidad], [Nombre], [Telefono]) VALUES (24, 11, N'Carlos Guzman
', N'11-6485-8957
')
INSERT [dbo].[NecesidadesReferencias] ([IdReferencia], [IdNecesidad], [Nombre], [Telefono]) VALUES (25, 12, N'Esteban Lucero
', N'11-5486-8795
')
INSERT [dbo].[NecesidadesReferencias] ([IdReferencia], [IdNecesidad], [Nombre], [Telefono]) VALUES (26, 12, N'Manuel Roldan
', N'11-8451-6253
')
INSERT [dbo].[NecesidadesReferencias] ([IdReferencia], [IdNecesidad], [Nombre], [Telefono]) VALUES (27, 13, N'Alicia Avila
', N'11-5126-8945
')
INSERT [dbo].[NecesidadesReferencias] ([IdReferencia], [IdNecesidad], [Nombre], [Telefono]) VALUES (28, 13, N'Gaston Duarte
', N'11-2645-5623
')
INSERT [dbo].[NecesidadesReferencias] ([IdReferencia], [IdNecesidad], [Nombre], [Telefono]) VALUES (29, 14, N'Alejandro Colombani
', N'11-5425-8451
')
INSERT [dbo].[NecesidadesReferencias] ([IdReferencia], [IdNecesidad], [Nombre], [Telefono]) VALUES (30, 14, N'Javier Soto
', N'11-5678-5612
')
INSERT [dbo].[NecesidadesReferencias] ([IdReferencia], [IdNecesidad], [Nombre], [Telefono]) VALUES (31, 15, N'Daniel Campos
', N'11-9878-5645
')
INSERT [dbo].[NecesidadesReferencias] ([IdReferencia], [IdNecesidad], [Nombre], [Telefono]) VALUES (32, 15, N'Martin Franco
', N'11-5645-8945
')
INSERT [dbo].[NecesidadesReferencias] ([IdReferencia], [IdNecesidad], [Nombre], [Telefono]) VALUES (33, 16, N'Teresa Chavez
', N'11-8584-6254
')
INSERT [dbo].[NecesidadesReferencias] ([IdReferencia], [IdNecesidad], [Nombre], [Telefono]) VALUES (34, 16, N'Alicia Avila

', N'11-5126-8945
')
SET IDENTITY_INSERT [dbo].[NecesidadesReferencias] OFF
SET IDENTITY_INSERT [dbo].[NecesidadesDonacionesMonetarias] ON 

INSERT [dbo].[NecesidadesDonacionesMonetarias] ([IdNecesidadDonacionMonetaria], [IdNecesidad], [Dinero], [CBU]) VALUES (1, 2, CAST(100000.00 AS Decimal(18, 2)), N'4625462545112245
')
INSERT [dbo].[NecesidadesDonacionesMonetarias] ([IdNecesidadDonacionMonetaria], [IdNecesidad], [Dinero], [CBU]) VALUES (2, 3, CAST(50000.00 AS Decimal(18, 2)), N'5812568795468752
')
INSERT [dbo].[NecesidadesDonacionesMonetarias] ([IdNecesidadDonacionMonetaria], [IdNecesidad], [Dinero], [CBU]) VALUES (3, 4, CAST(40000.00 AS Decimal(18, 2)), N'2654893674598654
')
INSERT [dbo].[NecesidadesDonacionesMonetarias] ([IdNecesidadDonacionMonetaria], [IdNecesidad], [Dinero], [CBU]) VALUES (4, 7, CAST(80000.00 AS Decimal(18, 2)), N'1223548968753546
')
INSERT [dbo].[NecesidadesDonacionesMonetarias] ([IdNecesidadDonacionMonetaria], [IdNecesidad], [Dinero], [CBU]) VALUES (5, 9, CAST(45000.00 AS Decimal(18, 2)), N'4523562485624896
')
INSERT [dbo].[NecesidadesDonacionesMonetarias] ([IdNecesidadDonacionMonetaria], [IdNecesidad], [Dinero], [CBU]) VALUES (6, 11, CAST(60000.00 AS Decimal(18, 2)), N'2123524263598748
')
INSERT [dbo].[NecesidadesDonacionesMonetarias] ([IdNecesidadDonacionMonetaria], [IdNecesidad], [Dinero], [CBU]) VALUES (7, 13, CAST(70000.00 AS Decimal(18, 2)), N'5956457565234589
')
INSERT [dbo].[NecesidadesDonacionesMonetarias] ([IdNecesidadDonacionMonetaria], [IdNecesidad], [Dinero], [CBU]) VALUES (8, 16, CAST(55000.00 AS Decimal(18, 2)), N'7556426857952345
')
SET IDENTITY_INSERT [dbo].[NecesidadesDonacionesMonetarias] OFF
INSERT [dbo].[NecesidadesDonacionesInsumos] ([IdNecesidadDonacionInsumo], [IdNecesidad], [Nombre], [Cantidad], [FechaCreacion]) VALUES (1, 1, N'Azucar 1Kg
', 1, CAST(N'2020-05-06 00:00:00.000' AS DateTime))
INSERT [dbo].[NecesidadesDonacionesInsumos] ([IdNecesidadDonacionInsumo], [IdNecesidad], [Nombre], [Cantidad], [FechaCreacion]) VALUES (2, 1, N'Fideos 500g
', 3, CAST(N'2020-05-06 00:00:00.000' AS DateTime))
INSERT [dbo].[NecesidadesDonacionesInsumos] ([IdNecesidadDonacionInsumo], [IdNecesidad], [Nombre], [Cantidad], [FechaCreacion]) VALUES (3, 1, N'Aceite 1,5 Lts
', 2, CAST(N'2020-05-06 00:00:00.000' AS DateTime))
INSERT [dbo].[NecesidadesDonacionesInsumos] ([IdNecesidadDonacionInsumo], [IdNecesidad], [Nombre], [Cantidad], [FechaCreacion]) VALUES (4, 1, N'Leche en polvo
', 2, CAST(N'2020-05-06 00:00:00.000' AS DateTime))
INSERT [dbo].[NecesidadesDonacionesInsumos] ([IdNecesidadDonacionInsumo], [IdNecesidad], [Nombre], [Cantidad], [FechaCreacion]) VALUES (5, 5, N'Agua oxigenada 
', 1, CAST(N'2020-06-12 00:00:00.000' AS DateTime))
INSERT [dbo].[NecesidadesDonacionesInsumos] ([IdNecesidadDonacionInsumo], [IdNecesidad], [Nombre], [Cantidad], [FechaCreacion]) VALUES (6, 5, N'Frasco de alcohol
', 1, CAST(N'2020-06-12 00:00:00.000' AS DateTime))
INSERT [dbo].[NecesidadesDonacionesInsumos] ([IdNecesidadDonacionInsumo], [IdNecesidad], [Nombre], [Cantidad], [FechaCreacion]) VALUES (7, 5, N'Venda 
', 2, CAST(N'2020-06-12 00:00:00.000' AS DateTime))
INSERT [dbo].[NecesidadesDonacionesInsumos] ([IdNecesidadDonacionInsumo], [IdNecesidad], [Nombre], [Cantidad], [FechaCreacion]) VALUES (8, 6, N'Pelota de futbol
', 2, CAST(N'2020-06-12 00:00:00.000' AS DateTime))
INSERT [dbo].[NecesidadesDonacionesInsumos] ([IdNecesidadDonacionInsumo], [IdNecesidad], [Nombre], [Cantidad], [FechaCreacion]) VALUES (9, 6, N'Muñeca Barbie
', 2, CAST(N'2020-06-12 00:00:00.000' AS DateTime))
INSERT [dbo].[NecesidadesDonacionesInsumos] ([IdNecesidadDonacionInsumo], [IdNecesidad], [Nombre], [Cantidad], [FechaCreacion]) VALUES (10, 8, N'Ladrillo hueco
', 20, CAST(N'2020-06-16 00:00:00.000' AS DateTime))
INSERT [dbo].[NecesidadesDonacionesInsumos] ([IdNecesidadDonacionInsumo], [IdNecesidad], [Nombre], [Cantidad], [FechaCreacion]) VALUES (11, 8, N'Bolsa de arena
', 5, CAST(N'2020-06-16 00:00:00.000' AS DateTime))
INSERT [dbo].[NecesidadesDonacionesInsumos] ([IdNecesidadDonacionInsumo], [IdNecesidad], [Nombre], [Cantidad], [FechaCreacion]) VALUES (12, 8, N'Bolsa de cal
', 3, CAST(N'2020-06-16 00:00:00.000' AS DateTime))
INSERT [dbo].[NecesidadesDonacionesInsumos] ([IdNecesidadDonacionInsumo], [IdNecesidad], [Nombre], [Cantidad], [FechaCreacion]) VALUES (13, 10, N'Arroz 1Kg
', 5, CAST(N'2020-06-18 00:00:00.000' AS DateTime))
INSERT [dbo].[NecesidadesDonacionesInsumos] ([IdNecesidadDonacionInsumo], [IdNecesidad], [Nombre], [Cantidad], [FechaCreacion]) VALUES (14, 10, N'Sal 500g
', 2, CAST(N'2020-06-18 00:00:00.000' AS DateTime))
INSERT [dbo].[NecesidadesDonacionesInsumos] ([IdNecesidadDonacionInsumo], [IdNecesidad], [Nombre], [Cantidad], [FechaCreacion]) VALUES (15, 10, N'Atun enlatado
', 2, CAST(N'2020-06-18 00:00:00.000' AS DateTime))
INSERT [dbo].[NecesidadesDonacionesInsumos] ([IdNecesidadDonacionInsumo], [IdNecesidad], [Nombre], [Cantidad], [FechaCreacion]) VALUES (16, 12, N'Fideos 500g
', 2, CAST(N'2020-06-20 00:00:00.000' AS DateTime))
INSERT [dbo].[NecesidadesDonacionesInsumos] ([IdNecesidadDonacionInsumo], [IdNecesidad], [Nombre], [Cantidad], [FechaCreacion]) VALUES (17, 12, N'Cafe 1Kg
', 2, CAST(N'2020-06-20 00:00:00.000' AS DateTime))
INSERT [dbo].[NecesidadesDonacionesInsumos] ([IdNecesidadDonacionInsumo], [IdNecesidad], [Nombre], [Cantidad], [FechaCreacion]) VALUES (18, 12, N'Arroz 1Kg
', 3, CAST(N'2020-06-20 00:00:00.000' AS DateTime))
INSERT [dbo].[NecesidadesDonacionesInsumos] ([IdNecesidadDonacionInsumo], [IdNecesidad], [Nombre], [Cantidad], [FechaCreacion]) VALUES (19, 14, N'Cristal PVC 500mic
', 5, CAST(N'2020-06-20 00:00:00.000' AS DateTime))
INSERT [dbo].[NecesidadesDonacionesInsumos] ([IdNecesidadDonacionInsumo], [IdNecesidad], [Nombre], [Cantidad], [FechaCreacion]) VALUES (20, 15, N'Fideos 500g
', 3, CAST(N'2020-06-21 00:00:00.000' AS DateTime))
INSERT [dbo].[NecesidadesDonacionesInsumos] ([IdNecesidadDonacionInsumo], [IdNecesidad], [Nombre], [Cantidad], [FechaCreacion]) VALUES (21, 15, N'Arroz 1Kg
', 3, CAST(N'2020-06-21 00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[DenunciasEstado] ON 

INSERT [dbo].[DenunciasEstado] ([IdDenunciaEstado], [Descripcion]) VALUES (1, N'Pendiente           ')
INSERT [dbo].[DenunciasEstado] ([IdDenunciaEstado], [Descripcion]) VALUES (2, N'Aprobado            ')
INSERT [dbo].[DenunciasEstado] ([IdDenunciaEstado], [Descripcion]) VALUES (3, N'Desestimado         ')
SET IDENTITY_INSERT [dbo].[DenunciasEstado] OFF
SET IDENTITY_INSERT [dbo].[MotivoDenuncia] ON 

INSERT [dbo].[MotivoDenuncia] ([IdMotivoDenuncia], [Descripcion]) VALUES (1, N'Fraude')
INSERT [dbo].[MotivoDenuncia] ([IdMotivoDenuncia], [Descripcion]) VALUES (2, N'Indebida')
INSERT [dbo].[MotivoDenuncia] ([IdMotivoDenuncia], [Descripcion]) VALUES (3, N'Violación de derechos')
INSERT [dbo].[MotivoDenuncia] ([IdMotivoDenuncia], [Descripcion]) VALUES (4, N'Contiene información política')
SET IDENTITY_INSERT [dbo].[MotivoDenuncia] OFF
SET IDENTITY_INSERT [dbo].[Denuncias] ON 

INSERT [dbo].[Denuncias] ([IdDenuncia], [IdNecesidad], [IdMotivo], [IdUsuario], [Cometario], [FechaCreacion], [Estado]) VALUES (1, 9, 1, 6, N'No pude realizar la entrega de material de contruccion
', CAST(N'2020-06-20 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Denuncias] ([IdDenuncia], [IdNecesidad], [IdMotivo], [IdUsuario], [Cometario], [FechaCreacion], [Estado]) VALUES (2, 13, 1, 8, N'Me muestra un error al realizar la tranferencia
', CAST(N'2020-06-20 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Denuncias] ([IdDenuncia], [IdNecesidad], [IdMotivo], [IdUsuario], [Cometario], [FechaCreacion], [Estado]) VALUES (3, 15, 2, 4, N'No me parece ético el pedido de la necesidad
', CAST(N'2020-06-21 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Denuncias] ([IdDenuncia], [IdNecesidad], [IdMotivo], [IdUsuario], [Cometario], [FechaCreacion], [Estado]) VALUES (5, 16, 4, 2, N'Esto se debe encargar los politicos
', CAST(N'2020-06-21 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Denuncias] ([IdDenuncia], [IdNecesidad], [IdMotivo], [IdUsuario], [Cometario], [FechaCreacion], [Estado]) VALUES (6, 9, 1, 4, N'Tuve problemas al realizar la entrega
', CAST(N'2020-06-22 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Denuncias] ([IdDenuncia], [IdNecesidad], [IdMotivo], [IdUsuario], [Cometario], [FechaCreacion], [Estado]) VALUES (7, 16, 2, 14, N'No me parece una necesidad adecuada
', CAST(N'2020-06-22 00:00:00.000' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Denuncias] OFF
SET IDENTITY_INSERT [dbo].[DonacionesMonetarias] ON 

INSERT [dbo].[DonacionesMonetarias] ([IdDonacionMonetaria], [IdNecesidadDonacionMonetaria], [IdUsuario], [Dinero], [ArchivoTransferencia], [FechaCreacion]) VALUES (1, 1, 1, CAST(1000.00 AS Decimal(18, 2)), N'Images\Necesidad\constancia.png
', CAST(N'2020-05-22 00:00:00.000' AS DateTime))
INSERT [dbo].[DonacionesMonetarias] ([IdDonacionMonetaria], [IdNecesidadDonacionMonetaria], [IdUsuario], [Dinero], [ArchivoTransferencia], [FechaCreacion]) VALUES (4, 1, 2, CAST(2000.00 AS Decimal(18, 2)), N'Images\Necesidad\constancia.png
', CAST(N'2020-05-23 00:00:00.000' AS DateTime))
INSERT [dbo].[DonacionesMonetarias] ([IdDonacionMonetaria], [IdNecesidadDonacionMonetaria], [IdUsuario], [Dinero], [ArchivoTransferencia], [FechaCreacion]) VALUES (5, 2, 3, CAST(1500.00 AS Decimal(18, 2)), N'Images\Necesidad\constancia.png
', CAST(N'2020-06-12 00:00:00.000' AS DateTime))
INSERT [dbo].[DonacionesMonetarias] ([IdDonacionMonetaria], [IdNecesidadDonacionMonetaria], [IdUsuario], [Dinero], [ArchivoTransferencia], [FechaCreacion]) VALUES (6, 3, 7, CAST(500.00 AS Decimal(18, 2)), N'Images\Necesidad\constancia.png
', CAST(N'2020-06-14 00:00:00.000' AS DateTime))
INSERT [dbo].[DonacionesMonetarias] ([IdDonacionMonetaria], [IdNecesidadDonacionMonetaria], [IdUsuario], [Dinero], [ArchivoTransferencia], [FechaCreacion]) VALUES (7, 4, 10, CAST(1200.00 AS Decimal(18, 2)), N'Images\Necesidad\constancia.png
', CAST(N'2020-06-16 00:00:00.000' AS DateTime))
INSERT [dbo].[DonacionesMonetarias] ([IdDonacionMonetaria], [IdNecesidadDonacionMonetaria], [IdUsuario], [Dinero], [ArchivoTransferencia], [FechaCreacion]) VALUES (8, 7, 17, CAST(800.00 AS Decimal(18, 2)), N'Images\Necesidad\constancia.png
', CAST(N'2020-06-23 00:00:00.000' AS DateTime))
INSERT [dbo].[DonacionesMonetarias] ([IdDonacionMonetaria], [IdNecesidadDonacionMonetaria], [IdUsuario], [Dinero], [ArchivoTransferencia], [FechaCreacion]) VALUES (9, 7, 12, CAST(600.00 AS Decimal(18, 2)), N'Images\Necesidad\constancia.png
', CAST(N'2020-06-24 00:00:00.000' AS DateTime))
INSERT [dbo].[DonacionesMonetarias] ([IdDonacionMonetaria], [IdNecesidadDonacionMonetaria], [IdUsuario], [Dinero], [ArchivoTransferencia], [FechaCreacion]) VALUES (11, 8, 15, CAST(220.00 AS Decimal(18, 2)), N'Images\Necesidad\constancia.png
', CAST(N'2020-06-24 00:00:00.000' AS DateTime))
INSERT [dbo].[DonacionesMonetarias] ([IdDonacionMonetaria], [IdNecesidadDonacionMonetaria], [IdUsuario], [Dinero], [ArchivoTransferencia], [FechaCreacion]) VALUES (12, 5, 15, CAST(300.50 AS Decimal(18, 2)), N'Images\Necesidad\constancia.png
', CAST(N'2020-06-25 00:00:00.000' AS DateTime))
INSERT [dbo].[DonacionesMonetarias] ([IdDonacionMonetaria], [IdNecesidadDonacionMonetaria], [IdUsuario], [Dinero], [ArchivoTransferencia], [FechaCreacion]) VALUES (13, 6, 8, CAST(1250.00 AS Decimal(18, 2)), N'Images\Necesidad\constancia.png
', CAST(N'2020-06-26 00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[DonacionesMonetarias] OFF
SET IDENTITY_INSERT [dbo].[DonacionesInsumos] ON 

INSERT [dbo].[DonacionesInsumos] ([IdDonacionInsumo], [IdNecesidadDonacionInsumo], [IdUsuario], [Cantidad], [FechaCreacion]) VALUES (1, 1, 2, 1, CAST(N'2020-05-06 00:00:00.000' AS DateTime))
INSERT [dbo].[DonacionesInsumos] ([IdDonacionInsumo], [IdNecesidadDonacionInsumo], [IdUsuario], [Cantidad], [FechaCreacion]) VALUES (2, 2, 4, 3, CAST(N'2020-06-12 00:00:00.000' AS DateTime))
INSERT [dbo].[DonacionesInsumos] ([IdDonacionInsumo], [IdNecesidadDonacionInsumo], [IdUsuario], [Cantidad], [FechaCreacion]) VALUES (3, 3, 2, 1, CAST(N'2020-06-12 00:00:00.000' AS DateTime))
INSERT [dbo].[DonacionesInsumos] ([IdDonacionInsumo], [IdNecesidadDonacionInsumo], [IdUsuario], [Cantidad], [FechaCreacion]) VALUES (4, 5, 15, 1, CAST(N'2020-06-16 00:00:00.000' AS DateTime))
INSERT [dbo].[DonacionesInsumos] ([IdDonacionInsumo], [IdNecesidadDonacionInsumo], [IdUsuario], [Cantidad], [FechaCreacion]) VALUES (5, 6, 17, 1, CAST(N'2020-06-18 00:00:00.000' AS DateTime))
INSERT [dbo].[DonacionesInsumos] ([IdDonacionInsumo], [IdNecesidadDonacionInsumo], [IdUsuario], [Cantidad], [FechaCreacion]) VALUES (6, 7, 6, 1, CAST(N'2020-06-20 00:00:00.000' AS DateTime))
INSERT [dbo].[DonacionesInsumos] ([IdDonacionInsumo], [IdNecesidadDonacionInsumo], [IdUsuario], [Cantidad], [FechaCreacion]) VALUES (7, 10, 17, 10, CAST(N'2020-06-20 00:00:00.000' AS DateTime))
INSERT [dbo].[DonacionesInsumos] ([IdDonacionInsumo], [IdNecesidadDonacionInsumo], [IdUsuario], [Cantidad], [FechaCreacion]) VALUES (8, 19, 17, 2, CAST(N'2020-06-21 00:00:00.000' AS DateTime))
INSERT [dbo].[DonacionesInsumos] ([IdDonacionInsumo], [IdNecesidadDonacionInsumo], [IdUsuario], [Cantidad], [FechaCreacion]) VALUES (11, 10, 7, 5, CAST(N'2020-06-22 00:00:00.000' AS DateTime))
INSERT [dbo].[DonacionesInsumos] ([IdDonacionInsumo], [IdNecesidadDonacionInsumo], [IdUsuario], [Cantidad], [FechaCreacion]) VALUES (12, 20, 10, 2, CAST(N'2020-06-22 00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[DonacionesInsumos] OFF
