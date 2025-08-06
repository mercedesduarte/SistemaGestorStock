using System;
using System.Windows.Forms;
using Sesion;
using Logica;

namespace Vista
{
    public partial class frmUsuarioNombre : Form
    {
        private L_BuscarUsuario logicaBuscarUsuario = new L_BuscarUsuario();

        public frmUsuarioNombre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = txtNombreUsuario.Text.Trim();

            if (string.IsNullOrWhiteSpace(usuarioIngresado))
            {
                MessageBox.Show("Por favor, ingrese un nombre de usuario.");
                return;
            }

            try
            {
                var resultado = logicaBuscarUsuario.BuscarUsuario(usuarioIngresado);

                if (!resultado.Existe)
                {
                    MessageBox.Show("Usuario no encontrado. Intente nuevamente.");
                    return;
                }

                SesionUsuario.Usuario = usuarioIngresado;

                this.Hide();
                frmResponderRespuesta responderForm = new frmResponderRespuesta();
                DialogResult res = responderForm.ShowDialog();

                if (res == DialogResult.OK)
                {
                    MessageBox.Show("Respuestas correctas. Puedes continuar.");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Respuestas incorrectas o proceso cancelado.");
                    this.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void frmUsuarioNombre_Load(object sender, EventArgs e)
        {
        }
    }
}
