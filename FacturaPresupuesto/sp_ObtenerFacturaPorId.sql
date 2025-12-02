IF OBJECT_ID('dbo.sp_ObtenerFacturaPorId', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_ObtenerFacturaPorId;
GO

CREATE PROCEDURE dbo.sp_ObtenerFacturaPorId
    @IdFactura INT
AS
BEGIN
    SET NOCOUNT ON;
    

    SELECT 
        f.IdFactura,
        f.NumeroFactura,
        f.Fecha,
        f.FechaVencimiento,
        f.IdCliente,
        c.RazonSocial AS Cliente,
        c.Email,
        f.IdPresupuestoOrigen,
        pv.NumeroPresupuesto,
        f.SubTotal,
        f.Descuento,
        f.IVA,
        f.Total,
        f.Estado,
        f.Observaciones,
        f.Usuario,
        f.FechaCreacion
    FROM dbo.Facturas f
    INNER JOIN dbo.Clientes c ON f.IdCliente = c.IdCliente
    LEFT JOIN dbo.PresupuestosVenta pv ON f.IdPresupuestoOrigen = pv.IdPresupuesto
    WHERE f.IdFactura = @IdFactura;
    
    -- Detalles de factura
    SELECT 
        df.IdDetalleFactura,
        df.IdProducto,
        df.CodigoProducto,
        df.Descripcion,
        df.Cantidad,
        df.PrecioUnitario,
        df.SubTotal
    FROM dbo.DetallesFactura df
    WHERE df.IdFactura = @IdFactura
    ORDER BY df.IdDetalleFactura;
END
GO
