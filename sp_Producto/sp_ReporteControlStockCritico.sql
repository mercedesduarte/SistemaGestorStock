CREATE PROCEDURE sp_ReporteControlStockVencimientos
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
        p.StockActual,
        p.StockMinimo,
        p.StockIdeal,
        p.StockMaximo,
        -- Calcular punto de reposición (30% entre mínimo e ideal)
        p.StockMinimo + CAST((p.StockIdeal - p.StockMinimo) * 0.3 AS INT) AS PuntoReposicion,
        -- Estado del stock
        CASE 
            WHEN p.StockActual <= p.StockMinimo THEN 'CRITICO'
            WHEN p.StockActual <= (p.StockMinimo + CAST((p.StockIdeal - p.StockMinimo) * 0.3 AS INT)) THEN 'ALERTA'
            WHEN p.StockActual <= p.StockIdeal THEN 'NORMAL'
            WHEN p.StockActual <= p.StockMaximo THEN 'OPTIMO'
            ELSE 'EXCEDIDO'
        END AS EstadoStock,
        -- Estado de vencimiento
        CASE 
            WHEN p.FechaVencimiento IS NULL THEN 'SIN_VENCIMIENTO'
            WHEN p.FechaVencimiento < GETDATE() THEN 'VENCIDO'
            WHEN p.FechaVencimiento <= DATEADD(DAY, ISNULL(p.DiasAvisoVencimiento, 30), GETDATE()) THEN 'PROXIMO_VENCER'
            ELSE 'VIGENTE'
        END AS EstadoVencimiento,
        -- Días hasta vencimiento
        CASE 
            WHEN p.FechaVencimiento IS NOT NULL THEN 
                DATEDIFF(DAY, GETDATE(), p.FechaVencimiento)
            ELSE NULL
        END AS DiasHastaVencimiento,
        -- Alertas combinadas
        CASE 
            WHEN p.StockActual <= p.StockMinimo AND p.FechaVencimiento < GETDATE() THEN 'STOCK_CRITICO_Y_VENCIDO'
            WHEN p.StockActual <= p.StockMinimo AND p.FechaVencimiento <= DATEADD(DAY, ISNULL(p.DiasAvisoVencimiento, 30), GETDATE()) THEN 'STOCK_CRITICO_Y_PROXIMO_VENCER'
            WHEN p.StockActual <= p.StockMinimo THEN 'STOCK_CRITICO'
            WHEN p.FechaVencimiento < GETDATE() THEN 'VENCIDO'
            WHEN p.FechaVencimiento <= DATEADD(DAY, ISNULL(p.DiasAvisoVencimiento, 30), GETDATE()) THEN 'PROXIMO_A_VENCER'
            WHEN p.StockActual <= (p.StockMinimo + CAST((p.StockIdeal - p.StockMinimo) * 0.3 AS INT)) THEN 'STOCK_BAJO'
            ELSE 'NORMAL'
        END AS AlertaCombinada,
        p.Activo
    FROM 
        Productos p
        INNER JOIN Categorias c ON p.IdCategoria = c.IdCategoria
        INNER JOIN Marcas m ON p.IdMarca = m.IdMarca
    WHERE 
        p.Activo = 1
    ORDER BY 
        CASE 
            WHEN p.StockActual <= p.StockMinimo AND p.FechaVencimiento < GETDATE() THEN 1
            WHEN p.StockActual <= p.StockMinimo THEN 2
            WHEN p.FechaVencimiento < GETDATE() THEN 3
            WHEN p.FechaVencimiento <= DATEADD(DAY, ISNULL(p.DiasAvisoVencimiento, 30), GETDATE()) THEN 4
            WHEN p.StockActual <= (p.StockMinimo + CAST((p.StockIdeal - p.StockMinimo) * 0.3 AS INT)) THEN 5
            ELSE 6
        END,
        p.Nombre;
END
GO