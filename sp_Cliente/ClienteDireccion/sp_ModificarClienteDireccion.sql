CREATE OR ALTER PROCEDURE sp_ModificarClienteDireccion
    @IdClienteDireccion INT,
    @Direccion NVARCHAR(250),
    @Localidad NVARCHAR(100),
    @Provincia NVARCHAR(100),
    @Activo BIT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE ClienteDirecciones
    SET Direccion = @Direccion,
        Localidad = @Localidad,
        Provincia = @Provincia,
        Activo = @Activo
    WHERE IdClienteDireccion = @IdClienteDireccion;
END;
GO
