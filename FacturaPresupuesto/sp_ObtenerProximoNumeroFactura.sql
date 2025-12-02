IF OBJECT_ID('dbo.sp_ObtenerProximoNumeroFactura', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_ObtenerProximoNumeroFactura;
GO

CREATE PROCEDURE dbo.sp_ObtenerProximoNumeroFactura
    @Prefijo NVARCHAR(10) = 'FAC-',
    @PuntoVenta NVARCHAR(10) = '001'
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @Anio INT = YEAR(GETDATE());
    DECLARE @Mes INT = MONTH(GETDATE());
    DECLARE @UltimoNumero INT = 0;
    DECLARE @NuevoNumero INT;
    DECLARE @NumeroCompleto NVARCHAR(50);
    DECLARE @Patron NVARCHAR(50);
    
    -- Formar patrón: FAC-001-202412-%
    SET @Patron = @Prefijo + @PuntoVenta + '-' + 
                  CAST(@Anio AS NVARCHAR(4)) + 
                  RIGHT('0' + CAST(@Mes AS NVARCHAR(2)), 2) + '-%';
    
    
    IF NOT EXISTS (SELECT 1 FROM dbo.Facturas)
    BEGIN
        SET @NuevoNumero = 1;
    END
    ELSE
    BEGIN
       
        SELECT TOP 1 @UltimoNumero = 
            TRY_CAST(
                SUBSTRING(NumeroFactura, 
                    LEN(@Prefijo + @PuntoVenta + '-' + 
                        CAST(@Anio AS NVARCHAR(4)) + 
                        RIGHT('0' + CAST(@Mes AS NVARCHAR(2)), 2) + '-') + 1,
                    6
                ) AS INT
            )
        FROM dbo.Facturas
        WHERE NumeroFactura LIKE @Patron
        ORDER BY IdFactura DESC;
        
        SET @UltimoNumero = ISNULL(@UltimoNumero, 0);
        SET @NuevoNumero = @UltimoNumero + 1;
    END
    
    -- Formato: FAC-001-202412-000001
    SET @NumeroCompleto = @Prefijo + 
                          @PuntoVenta + '-' +
                          CAST(@Anio AS NVARCHAR(4)) + 
                          RIGHT('0' + CAST(@Mes AS NVARCHAR(2)), 2) + 
                          '-' + 
                          RIGHT('000000' + CAST(@NuevoNumero AS NVARCHAR(6)), 6);
    
    SELECT @NumeroCompleto AS NumeroFactura;
END
GO
