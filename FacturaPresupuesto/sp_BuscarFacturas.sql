IF OBJECT_ID('dbo.sp_BuscarFacturas', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_BuscarFacturas;
GO

CREATE PROCEDURE dbo.sp_BuscarFacturas
    @FechaDesde DATETIME = NULL,
    @FechaHasta DATETIME = NULL,
    @IdCliente INT = NULL,
    @Estado NVARCHAR(20) = NULL,
    @NumeroFactura NVARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        f.IdFactura,
        f.NumeroFactura,
        f.Fecha,
        c.RazonSocial AS Cliente,
        f.SubTotal,
        f.Descuento,
        f.IVA,
        f.Total,
        f.Estado,
        f.Usuario,
        f.FechaCreacion
    FROM dbo.Facturas f
    INNER JOIN dbo.Clientes c ON f.IdCliente = c.IdCliente
    WHERE (@FechaDesde IS NULL OR f.Fecha >= @FechaDesde)
      AND (@FechaHasta IS NULL OR f.Fecha <= @FechaHasta)
      AND (@IdCliente IS NULL OR f.IdCliente = @IdCliente)
      AND (@Estado IS NULL OR f.Estado = @Estado)
      AND (@NumeroFactura IS NULL OR f.NumeroFactura LIKE '%' + @NumeroFactura + '%')
    ORDER BY f.Fecha DESC, f.NumeroFactura DESC;
END
GO
