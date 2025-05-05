CREATE PROCEDURE [dbo].[Login_Verificado_Nuevo2]
    @Usuario NVARCHAR(MAX),
    @Contrasena NVARCHAR(MAX),
    @EsAdmin BIT OUTPUT,
    @NombreRol NVARCHAR(50) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Id_Rol INT;
    DECLARE @Rol NVARCHAR(50);

    IF EXISTS (
        SELECT 1 
        FROM dbo.Usuarios
        WHERE Usuario = @Usuario AND Contraseña = @Contrasena
    )
    BEGIN
        SELECT @Id_Rol = Id_Rol
        FROM dbo.Usuarios
        WHERE Usuario = @Usuario AND Contraseña = @Contrasena;

        SELECT @Rol = Rol
        FROM dbo.Roles
        WHERE Id_Rol = @Id_Rol;

        SET @NombreRol = @Rol;

        IF @Rol = 'Administrador'
            SET @EsAdmin = 1;
        ELSE
            SET @EsAdmin = 0;

        RETURN 1;
    END
    ELSE
    BEGIN
        SET @NombreRol = NULL;
        RETURN 0;
    END
END
