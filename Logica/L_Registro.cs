using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Conecction;
using Datos;

namespace Logica
{
    public class L_Registro : ConnectionBD
    {
        public bool RegistrarUsuario(string usuario, string contrasena)
        {
            return D_Registro.RegistrarUsuario(usuario, contrasena);
        }
    }
}
