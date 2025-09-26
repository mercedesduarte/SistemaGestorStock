CREATE PROCEDURE sp_BuscarProveedorPorNombreOCuit
    @Filtro NVARCHAR(150)
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
    WHERE RazonSocial LIKE '%' + @Filtro + '%'
       OR Cuit LIKE '%' + @Filtro + '%';
END;
