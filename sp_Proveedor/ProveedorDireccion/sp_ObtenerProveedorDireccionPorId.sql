CREATE OR ALTER PROCEDURE sp_ObtenerProveedorDireccionPorId
    @IdDireccion INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        IdDireccion,
        IdProveedor,
        Direccion,
        Localidad,
        Provincia,
        Activo
    FROM 
        ProveedorDirecciones
    WHERE 
        IdDireccion = @IdDireccion;
END
GO
