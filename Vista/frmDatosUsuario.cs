using Logica;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmDatosUsuario : Form
    {
        private L_DatosUsuario logicaDatos = new L_DatosUsuario();

        public frmDatosUsuario()
        {
            InitializeComponent();

            txtApellido.Enabled = false;
            txtEmail.Enabled = false;
            txtNombre.Enabled = false;
            txtUsuario.Enabled = false;
        }

        private void frmDatosUsuario_Load(object sender, EventArgs e)
        {
            List<string> datos = logicaDatos.ObtenerDatosUsuario();

            if (datos.Count > 0) {
                txtUsuario.Text = Sesion.SesionUsuario.Usuario; 
                txtNombre.Text = datos[0];
                txtApellido.Text = datos[1];
                txtEmail.Text = datos[2];
            }
            else
            {
                MessageBox.Show("No se encontraron datos del usuario.");
            }
        }

        private void btnModificarContra_Click(object sender, EventArgs e)
        {
            frmCambiarContra modificarContraForm = new frmCambiarContra();
            modificarContraForm.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
