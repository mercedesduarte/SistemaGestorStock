using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos.Conecction
{
    public class ConnectionBD
    {
        private static string cadenaConexion = "Data Source=DESKTOP-9T1FLTV;Initial Catalog=BD_GESTION;Integrated Security=True;";
        /* NOMBRE DE LA BASE DE DATOS ES BD_GESTION */
        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
