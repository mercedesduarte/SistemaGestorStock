CREATE PROCEDURE sp_ObtenerClientesPorId
    @ClienteID INT
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
    FROM Clientes
    WHERE ClienteID = @ClienteID;
END;
