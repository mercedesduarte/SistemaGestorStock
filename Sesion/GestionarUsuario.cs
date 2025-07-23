using Servicios.obligatorias;
using System.Collections.Generic;

namespace Sesion
{
    public static class GestorUsuario
    {
        // Cambiar la contraseña del propio usuario
        public static bool CambiarMiContraseña(string username, string nuevaContraseña)
        {
            if (!UsuarioDTO.ExisteUsuario(username))
                return false;

            string hash = HashconUsu.Hashconusu(username, nuevaContraseña);
            UsuarioDTO.ActualizarContraseña(username, hash);
            return true;
        }

        // Cambiar las preguntas de seguridad del propio usuario
        public static bool CambiarMisPreguntas(string username, Dictionary<string, string> nuevasRespuestas)
        {
            if (!UsuarioDTO.ExisteUsuario(username))
                return false;

            UsuarioDTO.ActualizarPreguntas(username, nuevasRespuestas);
            return true;
        }

        // Verificar que el usuario general no tenga permisos de administrador
        public static bool EsUsuarioGeneral(string username)
        {
            var user = UsuarioDTO.BuscarPorUsername(username);
            return user != null && user.Rol == "usuario";
        }
    }
}