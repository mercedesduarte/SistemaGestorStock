using Logica;
using Sesion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmCambiarContra : Form
    {
        private MostrarToolTip mostrarTT = new MostrarToolTip();
        private L_Restriccion restriccion = new L_Restriccion();
        private EstadoRestricciones estadoRestricciones;

        public frmCambiarContra()
        {
            InitializeComponent();

            btnCambiarContra.Enabled = false;
            txtContra.TextChanged += txtContra_TextChanged;

            estadoRestricciones = restriccion.ConseguirRestricciones();
            ConfigurarVisibilidadRestricciones();
        }

        

        private void frmCrearRespuesta_Load(object sender, EventArgs e)
        {
            
            foreach (Control control in this.Controls)
            {
                if (control is CheckBox chk && !chk.Enabled)
                {
                    chk.Checked = true;
                }
            }
        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {
            ValidarRestricciones();
        }
        private void btnCambiarContra_Click(object sender, EventArgs e)
        {
            string contra = txtContra.Text;
            string confContra = txtConfContra.Text;

            if (contra != confContra)
            {
                mostrarTT.MostrarTooltip(txtConfContra, "Las contraseñas no son iguales.");
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
        private void ConfigurarVisibilidadRestricciones()
        {
            chkMinCaracteres.Visible = estadoRestricciones.CaracteresUtilizados > 0;
            chkMinCaracteres.Enabled = estadoRestricciones.CaracteresUtilizados > 0;

            chkNumeros.Visible = estadoRestricciones.NumeroLetras == 1;
            chkNumeros.Enabled = estadoRestricciones.NumeroLetras == 1;

            chkMayuscula.Visible = estadoRestricciones.MayusMinus == 1;
            chkMayuscula.Enabled = estadoRestricciones.MayusMinus == 1;

            chkEspeciales.Visible = estadoRestricciones.CaracterEsp == 1;
            chkEspeciales.Enabled = estadoRestricciones.CaracterEsp == 1;

            chkHistorial.Visible = estadoRestricciones.ContrasenaAnterior == 1;
            chkHistorial.Enabled = estadoRestricciones.ContrasenaAnterior == 1;

            chkDatosPersonales.Visible = estadoRestricciones.DatosPersonales == 1;
            chkDatosPersonales.Enabled = estadoRestricciones.DatosPersonales == 1;
        }

        private void ValidarRestricciones()
        {
            string contra = txtContra.Text;

            if (chkMinCaracteres.Enabled)
            {
                chkMinCaracteres.Checked = restriccion.ObtenerMinimoCaracteres(contra);
                chkMinCaracteres.Text = $"Debe tener al menos \n{estadoRestricciones.CaracteresUtilizados} caracteres";
            }
            else
            {
                chkMinCaracteres.Checked = true;
            }

            if (chkNumeros.Enabled)
            {
                chkNumeros.Checked = restriccion.ObtenerNumeros(contra);
            }
            else
            {
                chkNumeros.Checked = true;
            }

            if (chkMayuscula.Enabled)
            {
                chkMayuscula.Checked = restriccion.ObtenerMayusculas(contra);
            }
            else
            {
                chkMayuscula.Checked = true;
            }

            if (chkEspeciales.Enabled)
            {
                chkEspeciales.Checked = restriccion.ObtenerCaracteresEspeciales(contra);
            }
            else
            {
                chkEspeciales.Checked = true;
            }

            if (chkHistorial.Enabled)
            {
                L_HistorialContras l = new L_HistorialContras();
                var historial = l.HistorialDeContrasenas(SesionUsuario.Usuario);
                chkHistorial.Checked = historial == null || historial.Count == 0 || !historial.Any(c => c.Value == contra);
            }
            else
            {
                chkHistorial.Checked = true;
            }

            if (chkDatosPersonales.Enabled)
            {
                string resultadoVerificacion = restriccion.VerificarContraContraDatosPersonales(SesionUsuario.IdUsuario, contra);
                chkDatosPersonales.Checked = (resultadoVerificacion == "OK");
            }
            else
            {
                chkDatosPersonales.Checked = true;
            }

            btnCambiarContra.Enabled =
                chkMinCaracteres.Checked &&
                chkNumeros.Checked &&
                chkMayuscula.Checked &&
                chkEspeciales.Checked &&
                chkHistorial.Checked &&
                chkDatosPersonales.Checked;
        }
    }
}