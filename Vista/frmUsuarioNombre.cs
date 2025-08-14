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
                SesionUsuario.Usuario = nombreUsuario;

                int? idUsuario = logicaBuscar.ObtenerIdPorUsuario(nombreUsuario);

                if (!idUsuario.HasValue)
                {
                    errorProvider1.SetError(txtNombreUsuario, "Usuario no encontrado.");
                    return;
                }

                SesionUsuario.IdUsuario = idUsuario.Value;

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
