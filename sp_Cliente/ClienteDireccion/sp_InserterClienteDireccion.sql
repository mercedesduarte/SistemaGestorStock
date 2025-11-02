CREATE OR ALTER PROCEDURE sp_InsertarClienteDireccion
    @IdCliente INT,
    @Direccion NVARCHAR(250),
    @Localidad NVARCHAR(100),
    @Provincia NVARCHAR(100),
    @Activo BIT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO ClienteDirecciones
        (IdCliente, Direccion, Localidad, Provincia, Activo)
    VALUES
        (@IdCliente, @Direccion, @Localidad, @Provincia, @Activo);
END;
GO
