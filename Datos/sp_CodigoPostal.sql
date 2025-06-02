CREATE PROCEDURE sp_CodigoPostal
    @CodigoPostal INT
AS
BEGIN
    SELECT 
        l.Localidad,
        p.Partido,
        pr.Provincia
    FROM Localidad l
    INNER JOIN Partido p ON l.Id_Partido = p.Id_Partido
    INNER JOIN Provincia pr ON p.Id_Provincia = pr.Id_Provincia
    WHERE l.Codigo_postal = @CodigoPostal;
END
