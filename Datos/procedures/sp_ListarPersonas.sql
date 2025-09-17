CREATE OR ALTER PROCEDURE sp_ListarPersonas
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        Id_Persona,
        Nro_legajo,
        Nombre,
        Apellido,
        Num_Documento,
        CUIL,
        Email
    FROM Personas
    ORDER BY Apellido, Nombre;
END
