using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Conecction;

public class L_Restriccion 
{
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