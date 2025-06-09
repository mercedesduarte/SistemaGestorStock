using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class L_RegistrarUsuario
    {
        public bool RegistrarUsuario(
            int idpersona,
            string usuario,
            string contrasena,
            int idrol
        )
        {
            return Datos.D_RegistrarUsuario.RegistrarUsuario(
                idpersona,
                usuario,
                contrasena,
                idrol
            );
        }
    }
}
