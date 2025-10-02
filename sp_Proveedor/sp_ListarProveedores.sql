CREATE PROCEDURE sp_ListarProveedores
AS
BEGIN
    SET NOCOUNT ON;

    SELECT IdProveedor,
           Codigo,
           RazonSocial,
           Cuit,
           Email,
           FormaPago,
           TiempoEntrega,
           Descuento,
           Activo
    FROM Proveedores;
END;
