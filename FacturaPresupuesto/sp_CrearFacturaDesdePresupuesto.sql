IF OBJECT_ID('dbo.sp_CrearFacturaDesdePresupuesto', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_CrearFacturaDesdePresupuesto;
GO

CREATE PROCEDURE dbo.sp_CrearFacturaDesdePresupuesto
    @IdPresupuesto INT,
    @NumeroFactura NVARCHAR(50),
    @FechaFactura DATETIME,
    @FechaVencimiento DATETIME,
    @IdCliente INT,
    @SubTotal DECIMAL(18,2),
    @Descuento DECIMAL(18,2),
    @Total DECIMAL(18,2),
    @Observaciones NVARCHAR(MAX) = NULL,
    @Usuario NVARCHAR(100),
    @IdFactura INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;
    
    DECLARE @IVA DECIMAL(18,2);
    
    BEGIN TRANSACTION;
    
    BEGIN TRY
        -- Calcular IVA (21% sobre la base imponible)
        SET @IVA = (@SubTotal - @Descuento) * 0.21;
        
        -- 1. Insertar la factura
        INSERT INTO dbo.Facturas (
            NumeroFactura,
            Fecha,
            FechaVencimiento,
            IdCliente,
            IdPresupuestoOrigen,
            SubTotal,
            Descuento,
            IVA,
            Total,
            Estado,
            Observaciones,
            Usuario,
            FechaCreacion
        )
        VALUES (
            @NumeroFactura,
            @FechaFactura,
            @FechaVencimiento,
            @IdCliente,
            @IdPresupuesto,
            @SubTotal,
            @Descuento,
            @IVA,
            @Total,
            'PENDIENTE',
            ISNULL(@Observaciones, ''),
            @Usuario,
            GETDATE()
        );
        
        SET @IdFactura = SCOPE_IDENTITY();
        
        -- 2. Copiar detalles del presupuesto a la factura
        INSERT INTO dbo.DetallesFactura (
            IdFactura,
            IdProducto,
            CodigoProducto,
            Descripcion,
            Cantidad,
            PrecioUnitario,
            SubTotal,
            FechaCreacion
        )
        SELECT 
            @IdFactura,
            pd.IdProducto,
            p.Codigo,
            p.Nombre,
            pd.Cantidad,
            pd.PrecioUnitario,
            pd.SubTotal,
            GETDATE()
        FROM dbo.PresupuestosVentaDetalle pd
        INNER JOIN dbo.Productos p ON pd.IdProducto = p.IdProducto
        WHERE pd.IdPresupuesto = @IdPresupuesto;
        
        -- 3. Actualizar stock de productos
        UPDATE p
        SET p.StockActual = p.StockActual - pd.Cantidad
        FROM dbo.Productos p
        INNER JOIN dbo.PresupuestosVentaDetalle pd ON p.IdProducto = pd.IdProducto
        WHERE pd.IdPresupuesto = @IdPresupuesto;
        
        -- 4. Actualizar estado del presupuesto (SIN FechaModificacion)
        UPDATE dbo.PresupuestosVenta
        SET Estado = 'FACTURADO'
        WHERE IdPresupuesto = @IdPresupuesto;
        
        COMMIT TRANSACTION;
        
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        SET @IdFactura = -1;
        
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        RAISERROR (@ErrorMessage, 16, 1);
    END CATCH
END
GO
