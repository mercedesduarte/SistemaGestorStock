-- Listar Marcas
CREATE OR ALTER PROCEDURE sp_ListarMarcas
AS
BEGIN
    SET NOCOUNT ON;

    SELECT IdMarca, Nombre, Activo
    FROM Marcas;
END
GO