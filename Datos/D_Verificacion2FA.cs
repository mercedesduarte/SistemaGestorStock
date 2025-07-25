using System;
using System.Data;
using System.Data.SqlClient;
using Datos.Conecction;

namespace Datos
{
    public class D_Verificacion2FA
    {
        public string GenerarCodigo(int idUsuario)
        {
            try
            {
                using (SqlConnection conn = ConnectionBD.ObtenerConexion())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_Generar2FACodigo", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id_Usuario", idUsuario);

                        SqlParameter output = new SqlParameter("@CodigoGenerado", SqlDbType.NVarChar, 6)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(output);

                        cmd.ExecuteNonQuery();
                        return output.Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al generar el código 2FA: " + ex.Message);
                return null;
            }
        }

        public bool ValidarCodigoIngresado(int idUsuario, string codigoIngresado)
        {
            try
            {
                using (SqlConnection conn = ConnectionBD.ObtenerConexion())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_Validar2FACodigo", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id_Usuario", idUsuario);
                        cmd.Parameters.AddWithValue("@CodigoIngresado", codigoIngresado);

                        SqlParameter esValido = new SqlParameter("@EsValido", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(esValido);

                        cmd.ExecuteNonQuery();
                        return Convert.ToBoolean(esValido.Value);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al validar el código 2FA: " + ex.Message);
                return false;
            }
        }
    }
}
