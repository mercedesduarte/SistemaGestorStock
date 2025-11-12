CREATE OR ALTER PROCEDURE sp_AlertasPreventivasStock
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
        p.StockMaximo,
        -- Calcular punto de reposición (30% entre mínimo e ideal)
        p.StockMinimo + CAST((p.StockIdeal - p.StockMinimo) * 0.3 AS INT) AS PuntoReposicion,
        -- Diferencia hasta el stock mínimo
        p.StockActual - p.StockMinimo AS MargenSeguridad,
        -- Porcentaje de stock actual vs mínimo
        CASE 
            WHEN p.StockMinimo > 0 THEN
                CAST((p.StockActual * 100.0 / p.StockMinimo) AS DECIMAL(10,2))
            ELSE 100.0
        END AS PorcentajeSobreMinimo,
        -- Nivel de alerta preventiva
        CASE 
            WHEN p.StockActual <= p.StockMinimo THEN 'CRITICO_YA_ALCANZADO'
            WHEN p.StockActual <= (p.StockMinimo + CAST((p.StockIdeal - p.StockMinimo) * 0.3 AS INT)) THEN 'ALERTA_ALTA'
            WHEN p.StockActual <= (p.StockMinimo + CAST((p.StockIdeal - p.StockMinimo) * 0.5 AS INT)) THEN 'ALERTA_MEDIA'
            WHEN p.StockActual <= (p.StockMinimo + CAST((p.StockIdeal - p.StockMinimo) * 0.7 AS INT)) THEN 'ALERTA_BAJA'
            ELSE 'NORMAL'
        END AS NivelAlertaPreventiva,
        -- Mensaje descriptivo de la alerta
        CASE 
            WHEN p.StockActual <= p.StockMinimo THEN 'STOCK YA ESTÁ EN NIVEL CRÍTICO'
            WHEN p.StockActual <= (p.StockMinimo + CAST((p.StockIdeal - p.StockMinimo) * 0.3 AS INT)) THEN 
                'STOCK MUY CERCA DEL MÍNIMO - REVISIÓN URGENTE'
            WHEN p.StockActual <= (p.StockMinimo + CAST((p.StockIdeal - p.StockMinimo) * 0.5 AS INT)) THEN 
                'STOCK ACERCÁNDOSE AL MÍNIMO - PLANIFICAR REPOSICIÓN'
            WHEN p.StockActual <= (p.StockMinimo + CAST((p.StockIdeal - p.StockMinimo) * 0.7 AS INT)) THEN 
                'STOCK EN ZONA DE OBSERVACIÓN'
            ELSE 'STOCK EN NIVELES ADECUADOS'
        END AS MensajeAlerta,
        -- Días de stock restante (estimado basado en consumo promedio)
        NULL AS DiasStockRestante, -- Aquí podrías integrar datos históricos de ventas
        -- Estado de vencimiento
        CASE 
            WHEN p.FechaVencimiento IS NULL THEN 'SIN_VENCIMIENTO'
            WHEN p.FechaVencimiento < GETDATE() THEN 'VENCIDO'
            WHEN p.FechaVencimiento <= DATEADD(DAY, ISNULL(p.DiasAvisoVencimiento, 30), GETDATE()) THEN 'PROXIMO_VENCER'
            ELSE 'VIGENTE'
        END AS EstadoVencimiento,
        -- Prioridad combinada (stock + vencimiento)
        CASE 
            WHEN p.StockActual <= p.StockMinimo THEN 1
            WHEN p.StockActual <= (p.StockMinimo + CAST((p.StockIdeal - p.StockMinimo) * 0.3 AS INT)) AND 
                 p.FechaVencimiento <= DATEADD(DAY, ISNULL(p.DiasAvisoVencimiento, 30), GETDATE()) THEN 2
            WHEN p.StockActual <= (p.StockMinimo + CAST((p.StockIdeal - p.StockMinimo) * 0.3 AS INT)) THEN 3
            WHEN p.StockActual <= (p.StockMinimo + CAST((p.StockIdeal - p.StockMinimo) * 0.5 AS INT)) THEN 4
            ELSE 5
        END AS Prioridad,
        p.Activo
    FROM 
        Productos p
        INNER JOIN Categorias c ON p.IdCategoria = c.IdCategoria
        INNER JOIN Marcas m ON p.IdMarca = m.IdMarca
    WHERE 
        p.Activo = 1
        AND (
            -- Incluir productos que ya están en crítico O están en zona de alerta preventiva
            p.StockActual <= p.StockMinimo
            OR p.StockActual <= (p.StockMinimo + CAST((p.StockIdeal - p.StockMinimo) * 0.7 AS INT))
        )
    ORDER BY 
        Prioridad ASC,
        p.StockActual - p.StockMinimo ASC, -- Los más cercanos al mínimo primero
        p.Nombre;
END
GO