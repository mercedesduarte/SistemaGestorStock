using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Conecction;

namespace Logica
{
    public class L_Conexion 
    {

        public static void Conexiones()
        {

            using (SqlConnection conexion = ConnectionBD.ObtenerConexion())
            {
                try
                {
                    conexion.Open();
                    Console.WriteLine("CONEXION EXITOSA");
                
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Fallo la conexion:");
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
