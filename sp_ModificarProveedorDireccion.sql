-- Modificar Dirección
CREATE OR ALTER PROCEDURE sp_ModificarProveedorDireccion
    @IdDireccion INT,
    @Direccion NVARCHAR(250),
    @Localidad NVARCHAR(100),
    @Provincia NVARCHAR(100),
    @Activo BIT
AS
BEGIN
    UPDATE ProveedorDirecciones
    SET Direccion = @Direccion,
        Localidad = @Localidad,
        Provincia = @Provincia,
        Activo = @Activo
    WHERE IdDireccion = @IdDireccion;
END
GO