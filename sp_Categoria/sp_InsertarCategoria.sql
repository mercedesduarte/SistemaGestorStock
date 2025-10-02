-- Insertar Categoría
CREATE OR ALTER PROCEDURE sp_InsertarCategoria
    @Nombre NVARCHAR(100),
    @Descripcion NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Categorias (Nombre, Descripcion, Activo)
    VALUES (@Nombre, @Descripcion, 1);
END
GO