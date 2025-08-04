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
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;
            string rol;
            bool esAdmin;
            int idUsuario;

            bool loginValido = L_Login.LoginUsuario(usuario, contrasena, out idUsuario, out esAdmin, out rol);

            if (loginValido)
            {
                SesionUsuario.Usuario = usuario;
                SesionUsuario.EsAdmin = esAdmin;
                SesionUsuario.Rol = rol;

                this.Tag = rol;

                try
                {
                    Logica.L_Logs logicaLogs = new Logica.L_Logs();
                    logicaLogs.InsertarLog(usuario, "Inicio de sesión");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar log: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Logica.L_HistorialContras l = new Logica.L_HistorialContras();
                var historial = l.HistorialDeContrasenas(usuario);

                if (historial == null)
                {
                    this.Hide();
                    frmResponderPreguntas cambiarContrasenaForm = new frmResponderPreguntas();
                    DialogResult res = cambiarContrasenaForm.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        this.Show();
                    }
                }
                else
                {
                    this.Tag = rol;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(
                    "Usuario o contraseña incorrectos",
                    "Error de autenticación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
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
    }
}
