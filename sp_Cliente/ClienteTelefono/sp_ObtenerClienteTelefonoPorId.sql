CREATE OR ALTER PROCEDURE sp_ObtenerClienteTelefonoPorId
    @IdClienteTelefono INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        IdClienteTelefono,
        IdCliente,
        Telefono,
        Contacto,
        Sector,
        Horario,
        EmailContacto,
        Activo
    FROM ClienteTelefonos
    WHERE IdClienteTelefono = @IdClienteTelefono;
END;
GO
