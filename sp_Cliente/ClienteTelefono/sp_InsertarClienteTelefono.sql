CREATE OR ALTER PROCEDURE sp_InsertarClienteTelefono
    @IdCliente INT,
    @Telefono NVARCHAR(50),
    @Contacto NVARCHAR(100),
    @Sector NVARCHAR(100),
    @Horario NVARCHAR(100),
    @EmailContacto NVARCHAR(150),
    @Activo BIT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO ClienteTelefonos 
        (IdCliente, Telefono, Contacto, Sector, Horario, EmailContacto, Activo)
    VALUES 
        (@IdCliente, @Telefono, @Contacto, @Sector, @Horario, @EmailContacto, @Activo);
END;
GO
