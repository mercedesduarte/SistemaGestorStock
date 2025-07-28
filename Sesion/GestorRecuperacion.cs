
using System;
using System.Collections.Generic;

namespace Sesion {

    public static class GestorRecuperacion
    {

        private static Dictionary<string, Usuario> usuarios = new Dictionary<string, Usuario>();

        public static void RegistrarUsuario(Usuario user)
        {
            usuarios[user.Username] = user;
        }

        public static bool VerificarPreguntas(string username, Dictionary<string, string> respuestas)
        {
            if (!usuarios.ContainsKey(username)) return false;

            var user = usuarios[username];
            foreach (var pregunta in respuestas)
            {
                if (!user.PreguntasSeguridad.ContainsKey(pregunta.Key)) return false;
                if (user.PreguntasSeguridad[pregunta.Key].ToLower() != pregunta.Value.ToLower())
                    return false;
            }
            return true;
        }

        public static void EnviarCodigo(string username)
        {
            var codigo = new Random().Next(100000, 999999).ToString();
            usuarios[username].CodigoVerificacion = codigo;

            ArmarMail.DireccionCorreo = usuarios[username].Email;
            ArmarMail.Asunto = "Código de Verificación";
            ArmarMail.CodigoRecuperacion = codigo;
            ArmarMail.Preparar();
        }
        public static bool VerificarCodigo(string username, string codigoIngresado)
        {
            return usuarios.ContainsKey(username) &&
                   usuarios[username].CodigoVerificacion == codigoIngresado;
        }

        public static string AsignarContraseñaTemporal(string username)
        {
            var nueva = GeneradorContraseña.Generar(10);
            var hash = HashconUsu.Hashconusu(username, nueva);
            usuarios[username].HashedPassword = hash;
            usuarios[username].DebeCambiarContraseña = true;

            return nueva; // puede ser enviada por correo también
        }

        public static bool DebeCambiarContraseña(string username)
        {
            return usuarios.ContainsKey(username) && usuarios[username].DebeCambiarContraseña;
        }

        public static void CambiarContraseña(string username, string nuevaContraseña)
        {
            var hash = HashconUsu.Hashconusu(username, nuevaContraseña);
            usuarios[username].HashedPassword = hash;
            usuarios[username].DebeCambiarContraseña = false;
        }
    }
}