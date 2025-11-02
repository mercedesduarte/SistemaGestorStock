CREATE OR ALTER PROCEDURE sp_ModificarCliente
    @IdCliente INT,
    @Codigo NVARCHAR(20),
    @RazonSocial NVARCHAR(150),
    @Email NVARCHAR(150),
    @FormaPago NVARCHAR(100),
    @Descuento DECIMAL(5,2),
    @LimiteCredito DECIMAL(12,2),
    @Activo BIT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Clientes
    SET Codigo = @Codigo,
        RazonSocial = @RazonSocial,
        Email = @Email,
        FormaPago = @FormaPago,
        Descuento = @Descuento,
        LimiteCredito = @LimiteCredito,
        Activo = @Activo
    WHERE IdCliente = @IdCliente;
END;
GO
