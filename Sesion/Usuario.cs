using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion
{
    public class Usuario
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string HashedPassword { get; set; }
        public Dictionary<string, string> PreguntasSeguridad { get; set; }
        public bool DebeCambiarContraseña { get; set; } = false;
        public string CodigoVerificacion { get; set; }
    }
}
