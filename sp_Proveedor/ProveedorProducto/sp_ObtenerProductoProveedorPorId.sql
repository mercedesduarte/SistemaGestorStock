CREATE OR ALTER PROCEDURE sp_ObtenerProductoProveedorPorId
    @IdProductoProveedor INT
AS
BEGIN
    SELECT pp.IdProductoProveedor, pp.IdProducto, pp.IdProveedor, pp.PrecioCompra, pp.Catalogo, pp.Activo
    FROM ProductoProveedor pp
    WHERE pp.IdProductoProveedor = @IdProductoProveedor;
END
GO
