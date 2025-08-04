using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Vista
{
    public partial class frmRegistrarPersonas : Form
    {
        public frmRegistrarPersonas()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchImg_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCodigoPostal.Text, out int cp))
            {
                bool encontrado = L_EjecutarBusquedaCP.BuscarCP(cp);

                if (encontrado)
                {
                    txtLocalidad.Text = L_EjecutarBusquedaCP.Localidad;
                    txtPartido.Text = L_EjecutarBusquedaCP.Partido;
                    txtProvincia.Text = L_EjecutarBusquedaCP.Provincia;

                    Console.WriteLine(L_EjecutarBusquedaCP.idLocalidad);
                    Console.WriteLine(L_EjecutarBusquedaCP.idPartido);
                    Console.WriteLine(L_EjecutarBusquedaCP.idProvincia);
                }
                else
                {
                    MessageBox.Show("No se encontraron datos para ese código postal.");
                    txtLocalidad.Text = "";
                    txtPartido.Text = "";
                    txtProvincia.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Ingrese un código postal válido.");
            }
        }

        private void btnCrearPersona_Click(object sender, EventArgs e)
        {
            try
            {
      
                if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
                    throw new ArgumentException("Nombre y Apellido son campos obligatorios.");

                if (cbTipoDocumento.SelectedItem == null)
                    throw new ArgumentNullException("Tipo de documento no seleccionado.");

                if (cbGenero.SelectedItem == null)
                    throw new ArgumentNullException("Debe seleccionar un género.");

                if (cbSexo.SelectedItem == null)
                    throw new ArgumentNullException("Debe seleccionar un sexo.");

                string nombre = txtNombre.Text.Trim();
                string apellido = txtApellido.Text.Trim();
                string tipoDocumento = cbTipoDocumento.SelectedItem.ToString();
                string numDocumento = txtNumeroDocumento.Text.Trim();
                string cuil = txtCUIL.Text.Trim();
                string calle = txtCalle.Text.Trim();
                string altura = txtAltura.Text.Trim();
                string piso = txtPiso.Text.Trim();
                string departamento = txtDepartamento.Text.Trim();
                string codigoPostal = txtCodigoPostal.Text.Trim();
                string genero = cbGenero.SelectedItem.ToString();
                bool sexo = cbSexo.SelectedItem.ToString() == "Masculino";
                string email = txtCorreoElectronico.Text.Trim();
                int provincia = L_EjecutarBusquedaCP.idLocalidad;
                int partido = L_EjecutarBusquedaCP.idPartido;
                int localidad = L_EjecutarBusquedaCP.idProvincia;
                DateTime fechaAlta = DateTime.Now;


                var traerGenero = new L_Traer_Genero();
                traerGenero.Genero = genero;

                if (!traerGenero.BuscarGenero())
                {
                    MessageBox.Show("No se encontró el ID del género seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idGenero = traerGenero.IdGenero;

            
                Logica.L_Registro logica = new Logica.L_Registro();

                bool resultado = logica.RegistrarPersona(
                    nombre, apellido, tipoDocumento, numDocumento, cuil,
                    calle, altura, piso, departamento, codigoPostal,
                    provincia, partido, localidad, idGenero,
                    sexo, email, fechaAlta
                );

                if (resultado == true)
                {
                    MessageBox.Show("Persona registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al registrar la persona.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Falta un campo obligatorio: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Datos inválidos: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Formato incorrecto en los datos ingresados. " + ex.Message, "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                foreach (System.Data.SqlClient.SqlError error in ex.Errors)
                {
                    sb.AppendLine($"Código: {error.Number} | Línea: {error.LineNumber} | Mensaje: {error.Message}");
                }
                MessageBox.Show("Error en la base de datos:\n" + sb.ToString(), "Error SQL Detallado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error general", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
