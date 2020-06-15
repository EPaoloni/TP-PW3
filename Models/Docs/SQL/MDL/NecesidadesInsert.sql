USE [TP-20201C]
GO

INSERT INTO [dbo].[Necesidades]
           ([Nombre]
           ,[Descripcion]
           ,[FechaCreacion]
           ,[FechaFin]
           ,[TelefonoContacto]
           ,[TipoDonacion]
           ,[Foto]
           ,[IdUsuarioCreador]
           ,[Estado]
           ,[Valoracion])
     VALUES
           ('Comedor Comunitario Evita'
           ,'Es necesaria la colaboracion de donacion monetaria para poder realizar la compra el menu diario'
           ,2020-05-20
           ,2020-06-27
           ,'11-4243-2604'
           ,1
           ,'/Images/Necesidad/img.png'
           ,1
           ,1
           ,0.0)
GO