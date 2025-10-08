-- Modificar Teléfono
CREATE OR ALTER PROCEDURE sp_ModificarProveedorTelefono
    @IdTelefono INT,
    @Telefono NVARCHAR(30),
    @Contacto NVARCHAR(100),
    @Sector NVARCHAR(100),
    @Horario NVARCHAR(50),
    @EmailContacto NVARCHAR(150),
    @Activo BIT
AS
BEGIN
    UPDATE ProveedorTelefonos
    SET Telefono = @Telefono,
        Contacto = @Contacto,
        Sector = @Sector,
        Horario = @Horario,
        EmailContacto = @EmailContacto,
        Activo = @Activo
    WHERE IdTelefono = @IdTelefono;
END
GO