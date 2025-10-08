-- Listar Direcciones por Proveedor
CREATE OR ALTER PROCEDURE sp_ListarProveedorDirecciones
    @IdProveedor INT
AS
BEGIN
    SELECT *
    FROM ProveedorDirecciones
    WHERE IdProveedor = @IdProveedor;
END
GO