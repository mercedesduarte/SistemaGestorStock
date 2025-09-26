-- Insertar Dirección
CREATE OR ALTER PROCEDURE sp_InsertarProveedorDireccion
    @IdProveedor INT,
    @Direccion NVARCHAR(250),
    @Localidad NVARCHAR(100),
    @Provincia NVARCHAR(100)
AS
BEGIN
    INSERT INTO ProveedorDirecciones
    (IdProveedor, Direccion, Localidad, Provincia, Activo)
    VALUES
    (@IdProveedor, @Direccion, @Localidad, @Provincia, 1);
END
GO