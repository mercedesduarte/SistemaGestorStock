    USE [BD_GESTION];
    GO


    IF OBJECT_ID('sp_CalcularTotalesPresupuesto', 'P') IS NOT NULL
        DROP PROCEDURE sp_CalcularTotalesPresupuesto;
    GO


    CREATE PROCEDURE sp_CalcularTotalesPresupuesto
        @Productos ProductosPresupuestoTVP READONLY,
        @IdCliente INT = NULL
    AS
    BEGIN
        SET NOCOUNT ON;
    
        DECLARE @PorcentajeDescuento DECIMAL(18,2) = 0;
        DECLARE @IVA DECIMAL(18,2) = 21;
        DECLARE @SubTotal DECIMAL(18,2);
        DECLARE @DescuentoMonto DECIMAL(18,2);
        DECLARE @Total DECIMAL(18,2);
    
        IF @IdCliente IS NOT NULL
        BEGIN
            SELECT @PorcentajeDescuento = ISNULL(Descuento, 0)
            FROM dbo.Clientes
            WHERE IdCliente = @IdCliente;
        END
    
        SELECT @SubTotal = ISNULL(SUM(Cantidad * PrecioUnitario), 0)
        FROM @Productos;
    
        SET @DescuentoMonto = @SubTotal * (@PorcentajeDescuento / 100);
        SET @Total = (@SubTotal - @DescuentoMonto) * 1.21;
    
        SELECT 
            @SubTotal AS SubTotal,
            @PorcentajeDescuento AS PorcentajeDescuento,
            @DescuentoMonto AS Descuento,
            @Total AS Total;
    END
    GO

