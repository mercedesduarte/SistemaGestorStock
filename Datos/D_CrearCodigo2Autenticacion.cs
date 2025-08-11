using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class D_CrearCodigo2Autenticacion
    {
        public void CrearCodigo2FA(int idUsuario, string codigo2FA, DateTime fechaGeneracion)
        {
            Console.WriteLine(idUsuario);
            Console.WriteLine(codigo2FA);
            Console.WriteLine(fechaGeneracion);
            using (var conexion = Conecction.ConnectionBD.ObtenerConexion())
            {
                conexion.Open();
                using (var cmd = conexion.CreateCommand())
                {
                    cmd.CommandText = "sp_Generar2FACodigo";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Id_Usuario", idUsuario);
                    cmd.Parameters.AddWithValue("@CodigoGenerado", codigo2FA);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
