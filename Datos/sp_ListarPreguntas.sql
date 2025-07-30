CREATE PROCEDURE sp_ListarPreguntas
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        P.Id_Pregunta, 
        P.Pregunta, 
        R.Respuesta, 
        R.Id_Usuario
    FROM Preguntas P
    LEFT JOIN Respuestas R ON P.Id_Pregunta = R.Id_Pregunta
    ORDER BY P.Id_Pregunta;
END;

