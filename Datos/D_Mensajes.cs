using System;
using System.Data;
using System.Data.SqlClient;
using Datos.Conecction; 

namespace MensajeriaApp.Datos
{
    public class MensajeDAL
    {
        public void EnviarMensaje(int emisorId, int receptorId, string contenido)
        {
            using (SqlConnection conn = ConnectionBD.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("sp_EnviarMensaje", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmisorId", emisorId);
                cmd.Parameters.AddWithValue("@ReceptorId", receptorId);
                cmd.Parameters.AddWithValue("@Contenido", contenido);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ObtenerMensajes(int usuarioId)
        {
            using (SqlConnection conn = ConnectionBD.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("sp_ObtenerMensajesRecibidos", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;
            }
        }
    }
}
