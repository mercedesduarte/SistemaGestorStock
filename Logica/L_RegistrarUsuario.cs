using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sesion;

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
            if (!ValidaMail.Valid(usuario))
            {
                throw new ArgumentException("El correo electrónico no es válido.");
            }

 
            if (string.IsNullOrWhiteSpace(contrasena))
            {
                contrasena = GeneradorContraseña.Generar(6); 
            }

            return Datos.D_RegistrarUsuario.RegistrarUsuario(
                idpersona,
                usuario,
                contrasena,
                idrol
            );
        }
    }
}