-- Listar Teléfonos por Proveedor
CREATE OR ALTER PROCEDURE sp_ListarProveedorTelefonos
    @IdProveedor INT
AS
BEGIN
    SELECT *
    FROM ProveedorTelefonos
    WHERE IdProveedor = @IdProveedor;
END
GO