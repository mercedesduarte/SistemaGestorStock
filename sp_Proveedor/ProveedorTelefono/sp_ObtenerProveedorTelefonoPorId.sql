CREATE OR ALTER PROCEDURE sp_ObtenerProveedorTelefonoPorId
    @IdTelefono INT
AS
BEGIN
    SELECT * FROM ProveedorTelefonos WHERE IdTelefono = @IdTelefono;
END
GO
