-- Insertar Teléfono
CREATE OR ALTER PROCEDURE sp_InsertarProveedorTelefono
    @IdProveedor INT,
    @Telefono NVARCHAR(30),
    @Contacto NVARCHAR(100),
    @Sector NVARCHAR(100),
    @Horario NVARCHAR(50),
    @EmailContacto NVARCHAR(150)
AS
BEGIN
    INSERT INTO ProveedorTelefonos
    (IdProveedor, Telefono, Contacto, Sector, Horario, EmailContacto, Activo)
    VALUES
    (@IdProveedor, @Telefono, @Contacto, @Sector, @Horario, @EmailContacto, 1);
END
GO