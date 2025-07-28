USE [BD_GESTION]
GO

/****** Object:  StoredProcedure [dbo].[sp_ListarRoles]    Script Date: 28/7/2025 00:10:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ListarRoles]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT Id_Rol, Rol
    FROM Roles
    ORDER BY Rol;
END;
GO


