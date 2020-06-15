USE [TP-20201C]
GO

INSERT INTO [dbo].[Usuarios]
           ([Nombre]
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
           ('NombreTest'
           ,'ApellidoTest'
           ,'2001-01-12 00:00:00.000'
           ,'NombreTest.ApellidoTest'
           ,'test@ayudando.com.ar'
           ,'Test2020'
           ,NULL
           ,2
           ,'2020-06-12 00:00:00.000'
           ,1
           ,'b0bb6ce0a6464002')
GO