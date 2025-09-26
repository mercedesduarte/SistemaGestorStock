-- Insertar Relación Producto-Proveedor
CREATE OR ALTER PROCEDURE sp_InsertarProductoProveedor
    @IdProducto INT,
    @IdProveedor INT,
    @PrecioCompra DECIMAL(12,2),
    @Catalogo NVARCHAR(250)
AS
BEGIN
    INSERT INTO ProductoProveedor
    (IdProducto, IdProveedor, PrecioCompra, Catalogo, Activo)
    VALUES
    (@IdProducto, @IdProveedor, @PrecioCompra, @Catalogo, 1);
END
GO