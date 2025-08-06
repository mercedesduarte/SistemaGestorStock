using System;

namespace Datos
{
    public class ResultadoUsuario
    {
        public bool Existe { get; set; }
        public int? IdUsuario { get; set; }
    }

    public class D_BuscarUsuario
    {
        public ResultadoUsuario BuscarUsuario(string usuarioIngresado)
        {
            ResultadoUsuario resultado = new ResultadoUsuario();

            // Aquí va la conexión y consulta a la BD
            using (var conexion = Conecction.ConnectionBD.ObtenerConexion())
            {
                conexion.Open();
                using (var cmd = conexion.CreateCommand())
                {
                    cmd.CommandText = "SELECT Id_Usuario FROM Usuarios WHERE Usuario = @usuario";
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
