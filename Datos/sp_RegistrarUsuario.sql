CREATE PROCEDURE [dbo].[sp_RegistrarUsuario]
    @Id_Persona INT = NULL,
    @Usuario NVARCHAR(12),
    @Contrasena NVARCHAR(20),
    @Id_Rol INT
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM Usuarios WHERE Usuario = @Usuario)
    BEGIN
        RETURN 0;
    END

    INSERT INTO Usuarios (
        Id_Persona,
        Usuario,
        Contrasena,
        Bloqueado,
        Fecha_Bloqueo,
        CambioContra,
        FechaCambioContra,
        Id_Rol
    )
    VALUES (
        @Id_Persona,
        @Usuario,
        @Contrasena,
        0,
        NULL,
        1,
        GETDATE(),
        @Id_Rol
    );

    RETURN 1;
END