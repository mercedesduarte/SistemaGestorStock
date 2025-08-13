using System;
using System.Windows.Forms;
using Sesion;
using Logica;

namespace Vista
{
    public partial class frmUsuarioNombre : Form
    {
        private L_BuscarUsuario logicaBuscar = new L_BuscarUsuario();

        public frmUsuarioNombre()
        {
            InitializeComponent();
        }

        private void frmUsuarioNombre_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreUsuario.Text.Trim();

            if (string.IsNullOrEmpty(nombreUsuario))
            {
                MessageBox.Show("Debe ingresar un nombre de usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Guardar el nombre en sesión
                SesionUsuario.Usuario = nombreUsuario;

                // Obtener el ID desde la lógica
                int? idUsuario = logicaBuscar.ObtenerIdPorUsuario(nombreUsuario);

                if (!idUsuario.HasValue)
                {
                    MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Guardar el ID en sesión
                SesionUsuario.IdUsuario = idUsuario.Value;

                // Mostrar el ID al usuario
                MessageBox.Show($"Usuario válido. Su ID es: {SesionUsuario.IdUsuario}", "Usuario Validado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abrir el formulario de responder preguntas
                frmResponderRespuesta formRespuestas = new frmResponderRespuesta();
                this.Hide();

                DialogResult res = formRespuestas.ShowDialog();

                if (res == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    this.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al validar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
