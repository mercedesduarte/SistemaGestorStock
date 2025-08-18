using Logica;
using Sesion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmCambiarContra : Form
    {
        public frmCambiarContra()
        {
            InitializeComponent();

            btnCambiarContra.Enabled = false;

            txtContra.TextChanged += txtContra_TextChanged;
        }

        private void frmCrearRespuesta_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Usuario en sesión: " + SesionUsuario.Usuario);
            Console.WriteLine("IdUsuario en sesión: " + SesionUsuario.IdUsuario);
            chkMinCaracteres.Enabled = false;
            chkNumeros.Enabled = false;
            chkMayuscula.Enabled = false;
            chkEspeciales.Enabled = false;
            chkHistorial.Enabled = false;
            chkDatosPersonales.Enabled = false;
        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {
            ValidarRestricciones();
        }

        private void ValidarRestricciones()
        {
            string contra = txtContra.Text;
            L_Restriccion restriccion = new L_Restriccion();

            EstadoRestricciones estado = restriccion.ConseguirRestricciones();

            chkMinCaracteres.Checked = restriccion.ObtenerMinimoCaracteres(contra);
            chkMinCaracteres.Text = $"Debe tener al menos \n{estado.CaracteresUtilizados}  caracteres";

            chkNumeros.Checked = restriccion.ObtenerNumeros(contra);
            chkMayuscula.Checked = restriccion.ObtenerMayusculas(contra);
            chkEspeciales.Checked = restriccion.ObtenerCaracteresEspeciales(contra);

            L_HistorialContras l = new L_HistorialContras();
            var historial = l.HistorialDeContrasenas(SesionUsuario.Usuario);
            chkHistorial.Checked = historial == null || historial.Count == 0 || !historial.Any(c => c.Value == contra);

            string resultadoVerificacion = restriccion.VerificarContraContraDatosPersonales(SesionUsuario.IdUsuario, contra);
            chkDatosPersonales.Checked = (resultadoVerificacion == "OK");

            btnCambiarContra.Enabled =
                chkMinCaracteres.Checked &&
                chkNumeros.Checked &&
                chkMayuscula.Checked &&
                chkEspeciales.Checked &&
                chkHistorial.Checked &&
                chkDatosPersonales.Checked;
        }

        private void btnCambiarContra_Click(object sender, EventArgs e)
        {
            string contra = txtContra.Text;
            string confContra = txtConfContra.Text;

            if (contra != confContra)
            {
                MessageBox.Show("Las contraseñas no son iguales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            L_CambioObligatorio cambio = new L_CambioObligatorio();
            cambio.CambiaContra(SesionUsuario.IdUsuario, SesionUsuario.Usuario, contra, confContra);

            MessageBox.Show(
                "Contraseña cambiada exitosamente",
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnMostrarContra_Click(object sender, EventArgs e)
        {
            txtContra.UseSystemPasswordChar = !txtContra.UseSystemPasswordChar;

            btnMostrarContra.Image = txtContra.UseSystemPasswordChar
                ? Properties.Resources.nomoscon
                : Properties.Resources.moscon;
        }

        private void btnMostrarContraC_Click(object sender, EventArgs e)
        {
            txtConfContra.UseSystemPasswordChar = !txtConfContra.UseSystemPasswordChar;

            btnMostrarContraC.Image = txtConfContra.UseSystemPasswordChar
                ? Properties.Resources.nomoscon
                : Properties.Resources.moscon;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
