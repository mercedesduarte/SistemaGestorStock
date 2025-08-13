using Datos.Conecction;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class D_CambioObligatorio
    {
        public string ObtenerCorreoPorId(int idUsuario)
        {
            string correo = null;

            try
            {
                using (SqlConnection conexion = ConnectionBD.ObtenerConexion())
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_ObtenerCorreoPorIdUsuario", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id_Usuario", Sesion.SesionUsuario.IdUsuario);

                        object resultado = cmd.ExecuteScalar();

                        if (resultado != null && resultado != DBNull.Value)
                        {
                            correo = resultado.ToString();
                            Console.WriteLine(correo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener correo: " + ex.Message);
              
            }

            return correo;
        }

        public static bool ActualizarContra(int idUsuario, string contrasena, DateTime fechacambio)
        {
            try
            {
                using (SqlConnection conexion = ConnectionBD.ObtenerConexion())
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_ActualizarContra", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id_usuario", idUsuario);
                        cmd.Parameters.AddWithValue("@contrasena", contrasena);
                        cmd.Parameters.AddWithValue("@fechacambio", fechacambio);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error SQL: {ex.Message}", ex);
            }
        }



        //    public void GuardarCodigo2FA(int idUsuario, string codigo2FA, DateTime fechaGeneracion)
        //    {
        //        using (var context = new GestionEntities())
        //        {
        //            var nuevoCodigo2FA = new Codigo2FA
        //            {
        //                IdUsuario = idUsuario,
        //                Codigo = codigo2FA,
        //                FechaGeneracion = fechaGeneracion
        //            };
        //            context.Codigo2FA.Add(nuevoCodigo2FA);
        //            context.SaveChanges();
        //        }
        //    }
        //}
    }
}
