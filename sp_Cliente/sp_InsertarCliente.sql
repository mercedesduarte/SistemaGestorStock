CREATE OR ALTER PROCEDURE sp_InsertarCliente
    @Codigo NVARCHAR(20),
    @RazonSocial NVARCHAR(150),
    @Email NVARCHAR(150),
    @FormaPago NVARCHAR(100),
    @Descuento DECIMAL(5,2),
    @LimiteCredito DECIMAL(12,2)
AS
BEGIN
    SET NOCOUNT ON;

    -- Insertamos el cliente directamente
    INSERT INTO Clientes (Codigo, RazonSocial, Email, FormaPago, Descuento, LimiteCredito, Activo)
    VALUES (@Codigo, @RazonSocial, @Email, @FormaPago, @Descuento, @LimiteCredito, 1);
END;
GO
