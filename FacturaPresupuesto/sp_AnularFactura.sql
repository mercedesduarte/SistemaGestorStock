IF OBJECT_ID('dbo.sp_AnularFactura', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_AnularFactura;
GO

CREATE PROCEDURE dbo.sp_AnularFactura
    @IdFactura INT,
    @MotivoAnulacion NVARCHAR(500),
    @Usuario NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;
    
    BEGIN TRANSACTION;
    
    BEGIN TRY

        IF NOT EXISTS (SELECT 1 FROM dbo.Facturas WHERE IdFactura = @IdFactura AND Estado = 'PENDIENTE')
        BEGIN
            RAISERROR('La factura no existe o no está en estado PENDIENTE', 16, 1);
            RETURN;
        END
        

        UPDATE p
        SET p.StockActual = p.StockActual + df.Cantidad
        FROM dbo.Productos p
        INNER JOIN dbo.DetallesFactura df ON p.IdProducto = df.IdProducto
        WHERE df.IdFactura = @IdFactura;
        

        UPDATE dbo.Facturas
        SET Estado = 'ANULADA',
            FechaAnulacion = GETDATE(),
            MotivoAnulacion = @MotivoAnulacion
        WHERE IdFactura = @IdFactura;

        UPDATE dbo.PresupuestosVenta
        SET Estado = 'ANULADO'
        WHERE IdPresupuesto = (SELECT IdPresupuestoOrigen FROM dbo.Facturas WHERE IdFactura = @IdFactura);
        
        COMMIT TRANSACTION;
        
        SELECT 1 AS Resultado, 'Factura anulada exitosamente' AS Mensaje;
        
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        RAISERROR(@ErrorMessage, 16, 1);
    END CATCH
END
GO
