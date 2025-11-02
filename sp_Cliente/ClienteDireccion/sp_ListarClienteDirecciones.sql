CREATE OR ALTER PROCEDURE sp_ListarClienteDirecciones
    @IdCliente INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        IdClienteDireccion,
        IdCliente,
        Direccion,
        Localidad,
        Provincia,
        Activo
    FROM ClienteDirecciones
    WHERE IdCliente = @IdCliente;
END;
GO
