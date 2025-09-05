CREATE PROCEDURE sp_DatosDeUsuario
	@Usuario nvarchar(30)
AS
BEGIN
    DECLARE @Id_Usuario INT;

    SELECT @Id_Usuario = Id_Usuario
    FROM Usuarios AS U
    WHERE U.Usuario = @Usuario;
    
    SELECT Nombre, Apellido, Email
    FROM Usuarios AS U INNER JOIN Personas AS P ON U.Id_Persona = P.Id_Persona
    WHERE U.Id_Usuario = @Id_Usuario
END