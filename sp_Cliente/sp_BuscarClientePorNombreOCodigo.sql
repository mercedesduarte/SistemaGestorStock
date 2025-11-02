CREATE PROCEDURE sp_BuscarClientePorNombreOCodigo
    @Filtro NVARCHAR(100)
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
    WHERE RazonSocial LIKE '%' + @Filtro + '%'
       OR Codigo LIKE '%' + @Filtro + '%'
    ORDER BY RazonSocial;
END;
GO
