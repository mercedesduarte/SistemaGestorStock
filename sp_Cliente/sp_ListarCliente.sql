CREATE PROCEDURE sp_ListarClientes
AS
BEGIN
    SET NOCOUNT ON;

    SELECT ClienteID,
           Codigo,
           Nombre,
           Email,
           FormaPago,
           Descuento,
           LimiteCredito,
           Activo
    FROM Clientes;
END;
