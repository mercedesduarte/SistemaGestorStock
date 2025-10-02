-- Modificar Marca (nombre y/o activar/desactivar)
CREATE OR ALTER PROCEDURE sp_ModificarMarca
    @IdMarca INT,
    @Nombre NVARCHAR(100),
    @Activo BIT
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (SELECT 1 FROM Marcas WHERE IdMarca = @IdMarca)
    BEGIN
        RAISERROR('La marca no existe.', 16, 1);
        RETURN;
    END

    UPDATE Marcas
    SET Nombre = @Nombre,
        Activo = @Activo
    WHERE IdMarca = @IdMarca;
END
GO