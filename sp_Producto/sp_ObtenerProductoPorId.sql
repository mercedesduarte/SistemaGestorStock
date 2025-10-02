CREATE OR ALTER PROCEDURE sp_ObtenerProductoPorId
    @IdProducto INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        p.IdProducto,
        p.Codigo,
        p.Nombre,
        p.Descripcion,
        p.IdCategoria,
        p.IdMarca,
        p.Lote,
        p.FechaVencimiento,
        p.DiasAvisoVencimiento,
        p.PrecioCompra,
        p.PrecioVenta,
        p.StockActual,
        p.StockMinimo,
        p.StockIdeal,
        p.StockMaximo,
        p.TipoStock,
        p.Activo
    FROM Productos p
    WHERE p.IdProducto = @IdProducto;
END
GO
