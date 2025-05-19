using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Datos.Conecction;

public class L_Restriccion 

{
    public class EstadoRestricciones
    {
        public int MinimoCar { get; set; }
        public int MayusMinus { get; set; }
        public int NumeroLetras { get; set; }
        public int CaracterEsp { get; set; }
        public int ContrasenaAnterior { get; set; }
        public int DatosPersonales { get; set; }
        public int DosFA { get; set; }
    }

    public EstadoRestricciones ConseguirRestricciones()
    {
        try
        {
            using (SqlConnection conexion = ConnectionBD.ObtenerConexion())
            {
                conexion.Open();
                EstadoRestricciones estado = QueryRestricciones(conexion);

                Console.WriteLine("\nRestricciones activas:");
                if (estado.MinimoCar == 1) Console.WriteLine("- Mínimo de caracteres");
                if (estado.MayusMinus == 1) Console.WriteLine("- Combinar mayúsculas y minúsculas");
                if (estado.NumeroLetras == 1) Console.WriteLine("- Contener números y letras");
                if (estado.CaracterEsp == 1) Console.WriteLine("- Contener un carácter especial");
                if (estado.ContrasenaAnterior == 1) Console.WriteLine("- No repetir contraseñas anteriores");
                if (estado.DatosPersonales == 1) Console.WriteLine("- No permitir datos personales");
                if (estado.DosFA == 1) Console.WriteLine("- Requiere autenticación 2FA por correo");

                Console.WriteLine("Finalizó la carga de restricciones.");
                return estado;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al obtener las restricciones: " + ex.Message);
            return new EstadoRestricciones();
        }

    }


    public EstadoRestricciones QueryRestricciones(SqlConnection conexion)
    {
        var estado = new EstadoRestricciones();

        using (SqlCommand cmd = new SqlCommand("sp_ObtenerRestricciones", conexion))
        {
            cmd.CommandType = CommandType.StoredProcedure;

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (!reader.HasRows)
                {
                    Console.WriteLine("No se encontraron restricciones activas.");
                    return estado;
                }

                while (reader.Read())
                {
                    string restriccion = reader["Restriccion"]?.ToString() ?? "Sin nombre";
                    bool activo = reader["Activo"] != DBNull.Value && Convert.ToBoolean(reader["Activo"]);

                    if (!activo)
                        continue;

                    switch (restriccion)
                    {
                        case "Mínimo de caracteres":
                            estado.MinimoCar = 1;
                            break;
                        case "Combinar mayúsculas y minúsculas":
                            estado.MayusMinus = 1;
                            break;
                        case "Contener números y letras":
                            estado.NumeroLetras = 1;
                            break;
                        case "Contener un carácter especial":
                            estado.CaracterEsp = 1;
                            break;
                        case "No repetir contraseñas anteriores":
                            estado.ContrasenaAnterior = 1;
                            break;
                        case "No permitir datos personales":
                            estado.DatosPersonales = 1;
                            break;
                        case "Requerir autenticación en dos pasos (2FA) por correo electrónico":
                            estado.DosFA = 1;
                            break;
                    }
                }
            }
        }

        return estado;
    }




    public void GuardarRestricciones(
        decimal minCaracteres,
        bool mayusMinus,
        bool numLetras,
        bool caracterEspecial,
        bool noRepetir,
        bool noDatosPersonales,
        bool dosFA)
    {
        try
        {
            using (SqlConnection conexion = ConnectionBD.ObtenerConexion())
            {
                conexion.Open();

                MandarRestriccion(conexion, "Mínimo de caracteres", minCaracteres.ToString(), true);
                MandarRestriccion(conexion, "Combinar mayúsculas y minúsculas", "0", mayusMinus);
                MandarRestriccion(conexion, "Contener números y letras", "0", numLetras);
                MandarRestriccion(conexion, "Contener un carácter especial", "0", caracterEspecial);
                MandarRestriccion(conexion, "No repetir contraseñas anteriores", "0", noRepetir);
                MandarRestriccion(conexion, "No permitir datos personales", "0", noDatosPersonales);
                MandarRestriccion(conexion, "Requerir autenticación en dos pasos (2FA) por correo electrónico", "0", dosFA);

                Console.WriteLine("Éxito");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error", ex);
        }
    }

    private void MandarRestriccion(SqlConnection conexion, string nombre, string caracteresMin, bool activo)
    {
        using (SqlCommand cmd = new SqlCommand("sp_ActualizarRestriccion", conexion))
        {
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Restriccion", nombre);
            cmd.Parameters.AddWithValue("@Caracteres_Min", caracteresMin);
            cmd.Parameters.AddWithValue("@Activo", activo);

            cmd.ExecuteNonQuery();
        }
    }
}