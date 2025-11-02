CREATE OR ALTER PROCEDURE sp_ListarClientes
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
    ORDER BY RazonSocial;
END;
GO
