CREATE PROCEDURE sp_ObtenerClientePorId
    @IdCliente INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        IdCliente,
        Codigo,
        RazonSocial,
        Email,
        FormaPago,
        Descuento,
        LimiteCredito,
        Activo
    FROM Clientes
    WHERE IdCliente = @IdCliente;
END;
GO
