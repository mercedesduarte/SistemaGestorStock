CREATE PROCEDURE sp_ActualizarContra
    @id_usuario INT,
    @contrasena NVARCHAR(100),
    @fechacambio DATETIME
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO HistorialContrasenas (Id_Usuario, FechaCambio, Contrasena)
    VALUES (@id_usuario, @fechacambio, @contrasena);

    UPDATE Usuarios
    SET 
        Contrasena = @contrasena,
        FechaCambioContra = @fechacambio,
        CambioContra = ISNULL(CambioContra, 0) + 1
    WHERE Id_Usuario = @id_usuario;
END;