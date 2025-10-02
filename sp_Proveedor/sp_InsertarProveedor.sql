CREATE PROCEDURE sp_InsertarProveedor
    @Codigo NVARCHAR(50),
    @RazonSocial NVARCHAR(150),
    @Cuit NVARCHAR(20),
    @Email NVARCHAR(150) = NULL,
    @FormaPago NVARCHAR(100) = NULL,
    @TiempoEntrega INT = NULL, -- en días
    @Descuento DECIMAL(5,2) = 0
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Proveedores (Codigo, RazonSocial, Cuit, Email, FormaPago, TiempoEntrega, Descuento, Activo)
    VALUES (@Codigo, @RazonSocial, @Cuit, @Email, @FormaPago, @TiempoEntrega, @Descuento, 1);
END;
