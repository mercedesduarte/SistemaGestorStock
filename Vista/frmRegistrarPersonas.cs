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
            if(txtNombre.Text.Trim() == "")
            {
                Timer timer = new Timer();
                timer.Interval = 3000;
                timer.Tick += (senderTimer, args) =>
                {
                    errorProvider1.SetError(txtNombre, "Debe ingresar un nombre.");
                    timer.Stop();
                };
                timer.Start();
                txtNombre.Focus();
                return;
            }
            if(txtApellido.Text.Trim() == "")
            {
                Timer timer = new Timer();
                timer.Interval = 3000;
                timer.Tick += (senderTimer, args) =>
                {
                    errorProvider1.SetError(txtApellido, "Debe ingresar un apellido.");
                    timer.Stop();
                };
                timer.Start();
                txtApellido.Focus();
                return;
            }
            if(cbTipoDocumento.SelectedItem == null)
            {
                Timer timer = new Timer();
                timer.Interval = 3000;
                timer.Tick += (senderTimer, args) =>
                {
                    errorProvider1.SetError(cbTipoDocumento, "Debe seleccionar un tipo de documento.");
                    timer.Stop();
                };
                timer.Start();
                cbTipoDocumento.Focus();
                return;
            }
            if(txtNumeroDocumento.Visible && txtNumeroDocumento.Text.Trim() == "")
            {
                Timer timer = new Timer();
                timer.Interval = 3000;
                timer.Tick += (senderTimer, args) =>
                {
                    errorProvider1.SetError(txtNumeroDocumento, "Debe ingresar un número de documento.");
                    timer.Stop();
                };
                timer.Start();
                txtNumeroDocumento.Focus();
                return;
            }
            if(txtCUIL.Visible && txtCUIL.Text.Trim() == "")
            {
                Timer timer = new Timer();
                timer.Interval = 3000;
                timer.Tick += (senderTimer, args) =>
                {
                    errorProvider1.SetError(txtCUIL, "Debe ingresar un CUIL.");
                    timer.Stop();
                };
                timer.Start();
                txtCUIL.Focus();
                return;
            }
            if(txtCalle.Text.Trim() == "")
            {
                Timer timer = new Timer();
                timer.Interval = 3000;
                timer.Tick += (senderTimer, args) =>
                {
                    errorProvider1.SetError(txtCalle, "Debe ingresar una calle.");
                    timer.Stop();
                };
                timer.Start();
                txtCalle.Focus();
                return;
            }
            if(txtAltura.Text.Trim() == "")
            {
                Timer timer = new Timer();
                timer.Interval = 3000;
                timer.Tick += (senderTimer, args) =>
                {
                    errorProvider1.SetError(txtAltura, "Debe ingresar una altura.");
                    timer.Stop();
                };
                timer.Start();
                txtAltura.Focus();
                return;
            }
            if(txtCodigoPostal.Text.Trim() == "")
            {
                Timer timer = new Timer();
                timer.Interval = 3000;
                timer.Tick += (senderTimer, args) =>
                {
                    errorProvider1.SetError(txtCodigoPostal, "Debe ingresar un código postal.");
                    timer.Stop();
                };
                timer.Start();
                txtCodigoPostal.Focus();
                return;
            }
            if (cbGenero.SelectedItem == null)
            {
                Timer timer = new Timer();
                timer.Interval = 3000;
                timer.Tick += (senderTimer, args) =>
                {
                    errorProvider1.SetError(cbGenero, "Debe seleccionar un género.");
                    timer.Stop();
                };
                timer.Start();
                cbGenero.Focus();
                return;
            }
            if (cbSexo.SelectedItem == null)
            {
                Timer timer = new Timer();
                timer.Interval = 3000;
                timer.Tick += (senderTimer, args) =>
                {
                    errorProvider1.SetError(cbSexo, "Debe seleccionar un sexo.");
                    timer.Stop();
                };
                timer.Start();
                cbSexo.Focus();
                return;
            }
            if (txtCorreoElectronico.Text.Trim() == "")
            {
                Timer timer = new Timer();
                timer.Interval = 3000;
                timer.Tick += (senderTimer, args) =>
                {
                    errorProvider1.SetError(txtCorreoElectronico, "Debe ingresar un correo electrónico.");
                    timer.Stop();
                };
                timer.Start();
                txtCorreoElectronico.Focus();
                return;
            }
            if (!txtCorreoElectronico.Text.Contains("@") || !txtCorreoElectronico.Text.Contains("."))
            {
                Timer timer = new Timer();
                timer.Interval = 3000;
                timer.Tick += (senderTimer, args) =>
                {
                    errorProvider1.SetError(txtCorreoElectronico, "El correo electrónico debe contener '@' y un dominio válido.");
                    timer.Stop();
                };
                timer.Start();
                txtCorreoElectronico.Focus();
                return;
            }
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

        private void cbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seleccionado = cbTipoDocumento.SelectedItem?.ToString();

            if (seleccionado == "DNI")
            {
                txtNumeroDocumento.Visible = true;
                lblNumeroDocumento.Visible = true;

                txtCUIL.Visible = false;
                lblCUIL.Visible = false;
            }
            else if (seleccionado == "CUIL")
            {
                txtCUIL.Visible = true;
                lblCUIL.Visible = true;

                txtNumeroDocumento.Visible = false;
                lblNumeroDocumento.Visible = false;
            }
            else
            {
                txtNumeroDocumento.Visible = false;
                lblNumeroDocumento.Visible = false;

                txtCUIL.Visible = false;
                lblCUIL.Visible = false;
            }
            

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidadorTextBox.SoloLetras(sender, e);
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidadorTextBox.SoloLetras(sender, e);
        }

        private void txtNumeroDocumento_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidadorTextBox.SoloNumeros(sender, e);
        }
        private void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidadorTextBox.SoloNumeros(sender, e);
        }

        private void txtCUIL_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidadorTextBox.SoloNumeros(sender, e);
        }

        private void txtAltura_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ValidadorTextBox.SoloNumeros(sender, e);
        }

        private void txtPiso_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidadorTextBox.SoloNumeros(sender, e);
        }

        private void txtDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidadorTextBox.SoloNumeros(sender, e);
        }

        private void txtCodigoPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidadorTextBox.SoloNumeros(sender, e);
        }
    }
}


