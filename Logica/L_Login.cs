using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Datos.Conecction;
using Datos;


namespace Logica
{
    public class L_Login
    {
        public static bool LoginUsuario(string usuario, string contrasena, out bool esAdmin, out string nombreRol)
        {

            return D_Login.LoginBD(usuario, contrasena, out esAdmin, out nombreRol);
        }
    }
}
