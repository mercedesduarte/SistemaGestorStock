using System;
using System.Data;

namespace Datos
{
    public class ResultadoUsuario
    {
        public bool Existe { get; set; }
        public int? IdUsuario { get; set; }
    }

    public class D_BuscarUsuario
    {

        public string ObtenerCorreoPorIdUsuario(int idUsuario)
        {
            string email = null;

            using (var conexion = Conecction.ConnectionBD.ObtenerConexion())
            {
                conexion.Open();
                using (var cmd = conexion.CreateCommand())
                {
                    cmd.CommandText = "sp_ObtenerCorreoPorIdUsuario";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Id_Usuario", idUsuario);

                    var result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        email = Convert.ToString(result);
                    }
                }
            }

            return email;
        }

        public ResultadoUsuario BuscarUsuario(string usuarioIngresado)
        {
            ResultadoUsuario resultado = new ResultadoUsuario();

            using (var conexion = Conecction.ConnectionBD.ObtenerConexion())
            {
                conexion.Open();
                using (var cmd = conexion.CreateCommand())
                {
                    cmd.CommandText = "sp_BuscarUsuario";
                    cmd.Parameters.AddWithValue("@usuario", usuarioIngresado);

                    var id = cmd.ExecuteScalar();

                    if (id != null)
                    {
                        resultado.Existe = true;
                        resultado.IdUsuario = Convert.ToInt32(id);
                    }
                    else
                    {
                        resultado.Existe = false;
                        resultado.IdUsuario = null;
                    }
                }
            }

            return resultado;
        }
    }
}
