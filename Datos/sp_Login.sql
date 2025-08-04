USE [BD_GESTION]
GO

/****** Object:  StoredProcedure [dbo].[sp_Login]    Script Date: 3/8/2025 23:20:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_Login]
    @Usuario NVARCHAR(MAX),
    @Contrasena NVARCHAR(MAX),
    @EsAdmin BIT OUTPUT,
    @NombreRol NVARCHAR(50) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Id_Rol INT;
    DECLARE @Rol NVARCHAR(50);
    DECLARE @IdUsuario INT;

    IF EXISTS (
        SELECT 1 
        FROM dbo.Usuarios
        WHERE Usuario = @Usuario AND Contrasena = @Contrasena
    )
    BEGIN
        SELECT 
            @IdUsuario = Id_Usuario,
            @Id_Rol = Id_Rol
        FROM dbo.Usuarios
        WHERE Usuario = @Usuario AND Contrasena = @Contrasena;

        SELECT @Rol = Rol
        FROM dbo.Roles
        WHERE Id_Rol = @Id_Rol;

        SET @NombreRol = @Rol;
        SET @EsAdmin = CASE WHEN @Rol = 'Administrador' THEN 1 ELSE 0 END;

        SELECT @IdUsuario AS IdUsuario;

        RETURN 1;
    END
    ELSE
    BEGIN
        SET @NombreRol = NULL;
        SET @EsAdmin = 0;

        RETURN 0;
    END
END
GO


