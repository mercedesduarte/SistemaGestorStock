-- Modificar Producto (datos generales y/o activar/desactivar)
CREATE OR ALTER PROCEDURE sp_ModificarProducto
    @IdProducto INT,
    @Codigo NVARCHAR(50),
    @Nombre NVARCHAR(150),
    @Descripcion NVARCHAR(500),
    @IdCategoria INT,
    @IdMarca INT,
    @Lote NVARCHAR(50),
    @FechaVencimiento DATE,
    @DiasAvisoVencimiento INT,
    @PrecioCompra DECIMAL(18,2),
    @PrecioVenta DECIMAL(18,2),
    @StockActual INT,
    @StockMinimo INT,
    @StockIdeal INT,
    @StockMaximo INT,
    @TipoStock NVARCHAR(20),
    @Activo BIT
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (SELECT 1 FROM Productos WHERE IdProducto = @IdProducto)
    BEGIN
        RAISERROR('El producto no existe.', 16, 1);
        RETURN;
    END

    UPDATE Productos
    SET Codigo = @Codigo,
        Nombre = @Nombre,
        Descripcion = @Descripcion,
        IdCategoria = @IdCategoria,
        IdMarca = @IdMarca,
        Lote = @Lote,
        FechaVencimiento = @FechaVencimiento,
        DiasAvisoVencimiento = @DiasAvisoVencimiento,
        PrecioCompra = @PrecioCompra,
        PrecioVenta = @PrecioVenta,
        StockActual = @StockActual,
        StockMinimo = @StockMinimo,
        StockIdeal = @StockIdeal,
        StockMaximo = @StockMaximo,
        TipoStock = @TipoStock,
        Activo = @Activo
    WHERE IdProducto = @IdProducto;
END
GO