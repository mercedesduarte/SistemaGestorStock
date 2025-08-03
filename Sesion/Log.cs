using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion
{
    internal class Log
    {
        public int IdLog { get; set; }
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Accion { get; set; }

        public Log(int idLog, int idUsuario, string usuario, string accion)
        {
            IdLog = idLog;
            IdUsuario = idUsuario;
            Usuario = usuario;
            Accion = accion;
        }

        public string ObtenerMensaje()
        {
            if (IdUsuario > 0)
                return $"El usuario {Usuario} realizó la acción: {Accion}";
            else
                throw new Exception("El ID del usuario no puede ser encontrado");
        }
    }
}