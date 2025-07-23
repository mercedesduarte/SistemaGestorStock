namespace Sesion
{
    internal class ArmarMail
    {
        public static string DireccionCorreo { get; set; }
        public static string Asunto { get; set; }
        public static string CodigoRecuperacion { get; set; }

        public static void Preparar()
        {
            string body = $@"
                <style>
                    h1{{color:dodgerblue;}}
                    h2{{color:darkorange;}}
                </style>
                <h1>Código de recuperación:</h1><br/>
                <h2>{CodigoRecuperacion}</h2>";

            EnviarMail.SendCustomMail(DireccionCorreo, Asunto, body);
        }
    }
}
