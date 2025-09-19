-- Listar Productos
CREATE OR ALTER PROCEDURE sp_ListarProductos
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        p.IdProducto,
        p.Codigo,
        p.Nombre,
        p.Descripcion,
        c.Nombre AS Categoria,
        m.Nombre AS Marca,
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
    INNER JOIN Categorias c ON p.IdCategoria = c.IdCategoria
    INNER JOIN Marcas m ON p.IdMarca = m.IdMarca;
END
GO