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
           (NULL
           ,NULL
           ,'2001-06-12 00:00:00.000'
           ,NULL
           ,'test@ayudando.com.ar'
           ,'Test2020'
           ,NULL
           ,2
           ,'2020-06-12 00:00:00.000'
           ,1
           ,'b0bb6ce0a6464002')
GO