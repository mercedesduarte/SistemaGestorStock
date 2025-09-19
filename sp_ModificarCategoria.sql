-- Modificar Categoría (nombre/descr y/o activar/desactivar)
CREATE OR ALTER PROCEDURE sp_ModificarCategoria
    @IdCategoria INT,
    @Nombre NVARCHAR(100),
    @Descripcion NVARCHAR(255),
    @Activo BIT
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (SELECT 1 FROM Categorias WHERE IdCategoria = @IdCategoria)
    BEGIN
        RAISERROR('La categoría no existe.', 16, 1);
        RETURN;
    END

    UPDATE Categorias
    SET Nombre = @Nombre,
        Descripcion = @Descripcion,
        Activo = @Activo
    WHERE IdCategoria = @IdCategoria;
END
GO