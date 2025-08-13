using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


using Logica;
using Servicios;
using Sesion;



namespace Vista
{
    public partial class frmIniciarSesion : Form
    {
        public frmIniciarSesion()
        {
            InitializeComponent();
            this.BackColor = Color.AliceBlue;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text;
            string rol;
            bool esAdmin;
            int idUsuario;

            string contrasenaHasheada = HashconUsu.Hashconusu(usuario, contrasena);

            bool loginValido = L_Login.LoginUsuario(usuario, contrasenaHasheada, out idUsuario, out esAdmin, out rol);

            if (!loginValido)
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SesionUsuario.Usuario = usuario;
            SesionUsuario.IdUsuario = idUsuario;
            SesionUsuario.EsAdmin = esAdmin;
            SesionUsuario.Rol = rol;

            try
            {
                Logica.L_Logs logicaLogs = new Logica.L_Logs();
                logicaLogs.InsertarLog(usuario, "Inicio de sesión");

                L_Restriccion Restriccion = new L_Restriccion();
                EstadoRestricciones estado = Restriccion.ConseguirRestricciones();
                if (estado.DosFA == 1)
                {
                    frm2FA dobleAutenticacionForm = new frm2FA();
                    dobleAutenticacionForm.Id_Usuario = idUsuario;
                    DialogResult res2FA = dobleAutenticacionForm.ShowDialog();
                    if (res2FA != DialogResult.OK)
                    {
                        MessageBox.Show("Autenticación fallida. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar log: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Historial de contraseñas
            Logica.L_HistorialContras l = new Logica.L_HistorialContras();
            var historial = l.HistorialDeContrasenas(usuario);

            if (historial == null)
            {
                this.Hide();
                frmResponderPreguntas cambiarContrasenaForm = new frmResponderPreguntas();
                DialogResult res = cambiarContrasenaForm.ShowDialog();
                if (res != DialogResult.OK)
                {
                    this.Show();
                    return;
                }
            }

            // Login exitoso
            this.Tag = rol;
            this.DialogResult = DialogResult.OK;
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "¿Estás seguro que deseas salir del sistema?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void btnMostrarContra_Click(object sender, EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = !txtContrasena.UseSystemPasswordChar;

            btnMostrarContra.Image = txtContrasena.UseSystemPasswordChar
                ? Properties.Resources.nomoscon
                : Properties.Resources.moscon;
        }

        private void lkbContraOlvidada_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var UsuarioNombreForm = new frmUsuarioNombre())
            {
                if (UsuarioNombreForm.ShowDialog() == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.Show();
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}