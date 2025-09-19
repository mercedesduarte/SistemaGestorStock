-- Insertar Producto
CREATE OR ALTER PROCEDURE sp_InsertarProducto
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
    @TipoStock NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Productos (
        Codigo, Nombre, Descripcion, IdCategoria, IdMarca,
        Lote, FechaVencimiento, DiasAvisoVencimiento,
        PrecioCompra, PrecioVenta,
        StockActual, StockMinimo, StockIdeal, StockMaximo,
        TipoStock, Activo
    )
    VALUES (
        @Codigo, @Nombre, @Descripcion, @IdCategoria, @IdMarca,
        @Lote, @FechaVencimiento, @DiasAvisoVencimiento,
        @PrecioCompra, @PrecioVenta,
        @StockActual, @StockMinimo, @StockIdeal, @StockMaximo,
        @TipoStock, 1
    );
END
GO