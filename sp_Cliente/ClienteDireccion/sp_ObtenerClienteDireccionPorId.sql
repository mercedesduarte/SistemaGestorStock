CREATE OR ALTER PROCEDURE sp_ObtenerClienteDireccionPorId
    @IdClienteDireccion INT
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
    WHERE IdClienteDireccion = @IdClienteDireccion;
END;
GO
