USE [BD_GESTION]
GO

/****** Object:  StoredProcedure [dbo].[sp_PersonasSinUsuario]    Script Date: 29/7/2025 23:09:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[sp_PersonasSinUsuario]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        P.Id_Persona,
        P.Nombre + ' ' + P.Apellido AS NombreCompleto,
        P.Num_Documento,
        P.CUIL,
        P.Email
    FROM Personas P
    LEFT JOIN Usuarios U ON P.Id_Persona = U.Id_Persona
    WHERE U.Id_Persona IS NULL
    ORDER BY P.Apellido, P.Nombre;
END
GO


