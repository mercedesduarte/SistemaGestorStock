CREATE PROCEDURE sp_ReporteProductosCriticos
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        p.IdProducto,
        p.Codigo,
        p.Nombre,
        c.Nombre AS Categoria,
        m.Nombre AS Marca,
        p.Lote,
        p.FechaVencimiento,
        p.StockActual,
        p.StockMinimo,
        p.StockIdeal,
        p.StockMinimo + CAST((p.StockIdeal - p.StockMinimo) * 0.3 AS INT) AS PuntoReposicion,
        CASE 
            WHEN p.FechaVencimiento IS NULL THEN 'SIN_VENCIMIENTO'
            WHEN p.FechaVencimiento < GETDATE() THEN 'VENCIDO'
            WHEN p.FechaVencimiento <= DATEADD(DAY, ISNULL(p.DiasAvisoVencimiento, 30), GETDATE()) THEN 'PROXIMO_VENCER'
            ELSE 'VIGENTE'
        END AS EstadoVencimiento,
        CASE 
            WHEN p.FechaVencimiento IS NOT NULL THEN 
                DATEDIFF(DAY, GETDATE(), p.FechaVencimiento)
            ELSE NULL
        END AS DiasHastaVencimiento,
        CASE 
            WHEN p.StockActual <= p.StockMinimo AND p.FechaVencimiento < GETDATE() THEN 'URGENTE'
            WHEN p.StockActual <= p.StockMinimo AND p.FechaVencimiento <= DATEADD(DAY, ISNULL(p.DiasAvisoVencimiento, 30), GETDATE()) THEN 'ALTA'
            WHEN p.StockActual <= p.StockMinimo THEN 'ALTA'
            WHEN p.FechaVencimiento < GETDATE() THEN 'ALTA'
            WHEN p.FechaVencimiento <= DATEADD(DAY, ISNULL(p.DiasAvisoVencimiento, 30), GETDATE()) THEN 'MEDIA'
            ELSE 'BAJA'
        END AS Prioridad
    FROM 
        Productos p
        INNER JOIN Categorias c ON p.IdCategoria = c.IdCategoria
        INNER JOIN Marcas m ON p.IdMarca = m.IdMarca
    WHERE 
        p.Activo = 1
        AND (
            p.StockActual <= p.StockMinimo
            OR p.StockActual <= (p.StockMinimo + CAST((p.StockIdeal - p.StockMinimo) * 0.3 AS INT))
            OR p.FechaVencimiento < GETDATE()
            OR p.FechaVencimiento <= DATEADD(DAY, ISNULL(p.DiasAvisoVencimiento, 30), GETDATE())
        )
    ORDER BY 
        CASE 
            WHEN p.StockActual <= p.StockMinimo AND p.FechaVencimiento < GETDATE() THEN 1
            WHEN p.StockActual <= p.StockMinimo AND p.FechaVencimiento <= DATEADD(DAY, ISNULL(p.DiasAvisoVencimiento, 30), GETDATE()) THEN 2
            WHEN p.StockActual <= p.StockMinimo THEN 3
            WHEN p.FechaVencimiento < GETDATE() THEN 4
            WHEN p.FechaVencimiento <= DATEADD(DAY, ISNULL(p.DiasAvisoVencimiento, 30), GETDATE()) THEN 5
            ELSE 6
        END,
        p.Nombre;
END
GO