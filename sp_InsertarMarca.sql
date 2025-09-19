-- Insertar Marca
CREATE OR ALTER PROCEDURE sp_InsertarMarca
    @Nombre NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Marcas (Nombre, Activo)
    VALUES (@Nombre, 1);
END
GO