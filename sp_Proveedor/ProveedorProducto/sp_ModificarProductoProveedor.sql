-- Modificar Relación Producto-Proveedor
CREATE OR ALTER PROCEDURE sp_ModificarProductoProveedor
    @IdProductoProveedor INT,
    @IdProducto INT,
    @IdProveedor INT,
    @PrecioCompra DECIMAL(12,2),
    @Catalogo NVARCHAR(250),
    @Activo BIT
AS
BEGIN
    UPDATE ProductoProveedor
    SET IdProducto = @IdProducto,
        IdProveedor = @IdProveedor,
        PrecioCompra = @PrecioCompra,
        Catalogo = @Catalogo,
        Activo = @Activo
    WHERE IdProductoProveedor = @IdProductoProveedor;
END
GO