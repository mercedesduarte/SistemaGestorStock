-- Listar Productos por Proveedor
CREATE OR ALTER PROCEDURE sp_ListarProductosPorProveedor
    @IdProveedor INT
AS
BEGIN
    SELECT pp.IdProductoProveedor, p.Nombre AS Producto, pp.PrecioCompra, pp.Catalogo, pp.Activo
    FROM ProductoProveedor pp
    INNER JOIN Productos p ON pp.IdProducto = p.IdProducto
    WHERE pp.IdProveedor = @IdProveedor;
END
GO