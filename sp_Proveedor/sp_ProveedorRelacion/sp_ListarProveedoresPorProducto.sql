-- Listar Proveedores por Producto
CREATE OR ALTER PROCEDURE sp_ListarProveedoresPorProducto
    @IdProducto INT
AS
BEGIN
    SELECT pp.IdProductoProveedor, pr.RazonSocial AS Proveedor, pp.PrecioCompra, pp.Catalogo, pp.Activo
    FROM ProductoProveedor pp
    INNER JOIN Proveedores pr ON pp.IdProveedor = pr.IdProveedor
    WHERE pp.IdProducto = @IdProducto;
END
GO