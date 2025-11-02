CREATE OR ALTER PROCEDURE sp_ListarClienteTelefonos
    @IdCliente INT
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
    WHERE IdCliente = @IdCliente;
END;
GO
