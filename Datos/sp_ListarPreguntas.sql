CREATE PROCEDURE [dbo].[sp_ListarPreguntas]
AS
BEGIN
SET NOCOUNT ON;

    SELECT Id_Pregunta, Pregunta
    FROM Preguntas
    ORDER BY Id_Pregunta;
END;