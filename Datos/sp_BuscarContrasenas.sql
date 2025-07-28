CREATE PROCEDURE sp_BuscarContrasenas
    @usuario NVARCHAR(15)
AS
BEGIN
    SELECT H.Id_Historial, H.Contrasena
    FROM Usuarios U
    INNER JOIN HistorialContrasenas H ON U.Id_Usuario = H.Id_Usuario
    WHERE U.Usuario = @usuario;
END