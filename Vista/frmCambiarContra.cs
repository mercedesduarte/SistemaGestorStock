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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            string usuario = SesionUsuario.Usuario;

            Console.WriteLine("Usuario en sesión: " + SesionUsuario.Usuario);
            Console.WriteLine("IdUsuario en sesión: " + SesionUsuario.IdUsuario);
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
                Timer timer = new Timer();
                timer.Tick += (senderTimer, args) =>
                {
                    errorProvider1.SetError(txtContra, "Las contraseñas no son iguales");
                    errorProvider2.SetError(txtConfContra, "Las contraseñas no son iguales");
                    timer.Stop();
                };
                timer.Start();
                return;
            }

            L_Restriccion restriccion = new L_Restriccion();

            if (!restriccion.ObtenerMinimoCaracteres(contra))
            {
                L_Restriccion Restriccion = new L_Restriccion();
                EstadoRestricciones estado = Restriccion.ConseguirRestricciones();

                int nudMinCaracteres = estado.CaracteresUtilizados;

                Timer timer = new Timer();
                timer.Tick += (senderTimer, args) =>
                {
                    errorProvider1.SetError(txtContra, $"La contraseña no cumple con el mínimo de caracteres requeridos {nudMinCaracteres}.");
                    timer.Stop();
                };
                timer.Start();
                return;
            }

            if (!restriccion.ObtenerNumeros(contra))
            {
                Timer timer = new Timer();
                timer.Tick += (senderTimer, args) =>
                {
                    errorProvider1.SetError(txtContra, "La contraseña no tiene números");
                    timer.Stop();
                };
                timer.Start();
                return;
            }

            if (!restriccion.ObtenerMayusculas(contra))
            {
                Timer timer = new Timer();
                timer.Tick += (senderTimer, args) =>
                {
                    errorProvider1.SetError(txtContra, "La contraseña no tiene Mayúsculas");
                    timer.Stop();
                };
                timer.Start();
                return;
            }

            if (!restriccion.ObtenerCaracteresEspeciales(contra))
            {
                Timer timer = new Timer();
                timer.Tick += (senderTimer, args) =>
                {
                    errorProvider1.SetError(txtContra, "La contraseña no tiene caracteres especiales.");
                    timer.Stop();
                };
                timer.Start();
                return;
            }

            string resultadoVerificacion = restriccion.VerificarContraContraDatosPersonales(SesionUsuario.IdUsuario, contra);
            if (resultadoVerificacion != "OK")
            {
                Timer timer = new Timer();
                timer.Tick += (senderTimer, args) =>
                {
                    errorProvider1.SetError(txtContra, resultadoVerificacion);
                    timer.Stop();
                };
                timer.Start();
                return;
            }

            L_HistorialContras l = new L_HistorialContras();
            var historial = l.HistorialDeContrasenas(SesionUsuario.Usuario);

            if (historial != null && historial.Count > 0)
            {
                bool encontrada = false;

                foreach (var contras in historial)
                {
                    if (contras.Value == contra)
                    {
                        encontrada = true;
                        break;
                    }

                    if (encontrada)
                    {
                        Timer timer = new Timer();
                        timer.Tick += (senderTimer, args) =>
                        {
                            errorProvider1.SetError(txtContra, "Estas contraseña ya fue utilizada anteriormente.");
                            timer.Stop();
                        };
                        timer.Start();
                    }
                }
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

        private void lblContra_Click(object sender, EventArgs e)
        {

        }

        private void lblConfContra_Click(object sender, EventArgs e)
        {

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
            this.Close( );
        }
    }
}