using Logica;
using Sesion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmCambiarContra : Form
    {
        public frmCambiarContra()
        {
            InitializeComponent();
        }

        private void frmCrearRespuesta_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCambiarContra_Click(object sender, EventArgs e)
        {
            string contra = txtContra.Text;
            string confContra = txtConfContra.Text;

            if (contra != confContra)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            L_Restriccion restriccion = new L_Restriccion();

            if (!restriccion.ObtenerMinimoCaracteres(contra))
            {
                MessageBox.Show("La contraseña no cumple con el mínimo de caracteres requeridos.", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!restriccion.ObtenerNumeros(contra))
            {
                MessageBox.Show("La contraseña no cumple con la cantidad mínima de números.", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!restriccion.ObtenerMayusculas(contra))
            {
                MessageBox.Show("La contraseña no cumple con la cantidad mínima de mayúsculas.", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!restriccion.ObtenerCaracteresEspeciales(contra))
            {
                MessageBox.Show("La contraseña no cumple con la cantidad mínima de caracteres especiales.", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string resultadoVerificacion = restriccion.VerificarContraContraDatosPersonales(SesionUsuario.IdUsuario, contra);
            if (resultadoVerificacion != "OK")
            {
                MessageBox.Show(resultadoVerificacion, "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            L_CambioObligatorio cambio = new L_CambioObligatorio();
            cambio.CambiaContra(SesionUsuario.Usuario, contra, confContra);

            MessageBox.Show(
                "Contraseña cambiada exitosamente",
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void lblContra_Click(object sender, EventArgs e)
        {

        }

        private void lblConfContra_Click(object sender, EventArgs e)
        {

        }
    }
}