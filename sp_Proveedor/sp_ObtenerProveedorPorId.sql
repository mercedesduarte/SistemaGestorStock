CREATE PROCEDURE sp_ObtenerProveedorPorId
    @IdProveedor INT
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
    FROM Proveedores
    WHERE IdProveedor = @IdProveedor;
END;
