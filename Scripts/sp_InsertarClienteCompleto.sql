USE [BD_GESTION]
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_InsertarClienteCompleto]
    @Codigo           NVARCHAR(20),
    @RazonSocial      NVARCHAR(150),
    @Email            NVARCHAR(150)       = NULL,
    @FormaPago        NVARCHAR(100)       = NULL,
    @Descuento        DECIMAL(5,2)        = 0,
    @LimiteCredito    DECIMAL(12,2)       = 0,

    -- Dirección (opcional)
    @Direccion        NVARCHAR(250)       = NULL,
    @Localidad        NVARCHAR(100)       = NULL,
    @Provincia        NVARCHAR(100)       = NULL,
    @ActivoDireccion  BIT                 = 1,

    -- Teléfono (opcional)
    @Telefono         NVARCHAR(50)        = NULL,
    @Contacto         NVARCHAR(100)       = NULL,
    @Sector           NVARCHAR(100)       = NULL,
    @Horario          NVARCHAR(100)       = NULL,
    @EmailContacto    NVARCHAR(150)       = NULL,
    @ActivoTelefono   BIT                 = 1,

    @IdCliente        INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        -- Insertar cliente
        INSERT INTO Clientes (Codigo, RazonSocial, Email, FormaPago, Descuento, LimiteCredito, Activo)
        VALUES (
            @Codigo,
            @RazonSocial,
            NULLIF(LTRIM(RTRIM(@Email)), ''),
            NULLIF(LTRIM(RTRIM(@FormaPago)), ''),
            @Descuento,
            @LimiteCredito,
            1
        );

        -- Obtener Id insertado en el mismo scope
        SET @IdCliente = CAST(SCOPE_IDENTITY() AS INT);

        IF @IdCliente IS NULL OR @IdCliente = 0
        BEGIN
            ROLLBACK TRANSACTION;
            RAISERROR('No se pudo obtener IdCliente luego de insertar cliente.', 16, 1);
            RETURN;
        END

        -- Insertar dirección si se provee (campo no vacío)
        IF @Direccion IS NOT NULL AND LTRIM(RTRIM(@Direccion)) <> ''
        BEGIN
            INSERT INTO ClienteDirecciones (IdCliente, Direccion, Localidad, Provincia, Activo)
            VALUES (
                @IdCliente,
                @Direccion,
                NULLIF(LTRIM(RTRIM(@Localidad)), ''),
                NULLIF(LTRIM(RTRIM(@Provincia)), ''),
                ISNULL(@ActivoDireccion, 1)
            );
        END

        -- Insertar teléfono si se provee (campo no vacío)
        IF @Telefono IS NOT NULL AND LTRIM(RTRIM(@Telefono)) <> ''
        BEGIN
            INSERT INTO ClienteTelefonos (IdCliente, Telefono, Contacto, Sector, Horario, EmailContacto, Activo)
            VALUES (
                @IdCliente,
                @Telefono,
                NULLIF(LTRIM(RTRIM(@Contacto)), ''),
                NULLIF(LTRIM(RTRIM(@Sector)), ''),
                NULLIF(LTRIM(RTRIM(@Horario)), ''),
                NULLIF(LTRIM(RTRIM(@EmailContacto)), ''),
                ISNULL(@ActivoTelefono, 1)
            );
        END

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF XACT_STATE() <> 0
            ROLLBACK TRANSACTION;

        DECLARE @ErrMsg NVARCHAR(4000) = ERROR_MESSAGE();
        DECLARE @ErrNum INT = ERROR_NUMBER();
        RAISERROR('Error en sp_InsertarClienteCompleto: %d - %s', 16, 1, @ErrNum, @ErrMsg);
        RETURN;
    END CATCH
END
GO
