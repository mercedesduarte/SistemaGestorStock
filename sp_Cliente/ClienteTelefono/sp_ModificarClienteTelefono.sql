CREATE OR ALTER PROCEDURE sp_ModificarClienteTelefono
    @IdClienteTelefono INT,
    @Telefono NVARCHAR(50),
    @Contacto NVARCHAR(100),
    @Sector NVARCHAR(100),
    @Horario NVARCHAR(100),
    @EmailContacto NVARCHAR(150),
    @Activo BIT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE ClienteTelefonos
    SET 
        Telefono = @Telefono,
        Contacto = @Contacto,
        Sector = @Sector,
        Horario = @Horario,
        EmailContacto = @EmailContacto,
        Activo = @Activo
    WHERE IdClienteTelefono = @IdClienteTelefono;
END;
GO
