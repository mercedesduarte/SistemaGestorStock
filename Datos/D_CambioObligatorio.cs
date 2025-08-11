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
                        cmd.Parameters.AddWithValue("@Id_Usuario", idUsuario);

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
                // Podés decidir si lanzás la excepción o devolver null
                // throw;
            }

            return correo;
        }

        public static bool ActualizarContra(string usuario, string contrasena, DateTime fechacambio)
        {
            try
            {
                using (SqlConnection conexion = ConnectionBD.ObtenerConexion())
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_ActualizarContra", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;


                        cmd.Parameters.AddWithValue("@Usuario", usuario);
                        cmd.Parameters.AddWithValue("@Contrasena", contrasena);
                        cmd.Parameters.AddWithValue("@FechaCambio", fechacambio);

                        cmd.ExecuteNonQuery();

                        Console.WriteLine("Contraseña cambiada exitosamente");

                        return true;

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cambiar contraseña: " + ex.Message);
                return false;
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
