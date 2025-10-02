CREATE PROCEDURE sp_ModificarProveedor
    @IdProveedor INT,
    @Codigo NVARCHAR(50),
    @RazonSocial NVARCHAR(150),
    @Cuit NVARCHAR(20),
    @Email NVARCHAR(150) = NULL,
    @FormaPago NVARCHAR(100) = NULL,
    @TiempoEntrega INT = NULL,
    @Descuento DECIMAL(5,2) = 0,
    @Activo BIT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Proveedores
    SET Codigo = @Codigo,
        RazonSocial = @RazonSocial,
        Cuit = @Cuit,
        Email = @Email,
        FormaPago = @FormaPago,
        TiempoEntrega = @TiempoEntrega,
        Descuento = @Descuento,
        Activo = @Activo
    WHERE IdProveedor = @IdProveedor;
END;
