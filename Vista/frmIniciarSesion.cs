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


//Capas
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
            L_Conexion.Conexiones();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;
            string rol;
            bool esAdmin;

            bool loginValido = L_Login.LoginUsuario(usuario, contrasena, out esAdmin, out rol);

            if (loginValido)
            {
                MessageBox.Show(
                        "¡Login exitoso!",
                        "Bienvenido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                // Opcional: podrías guardar el rol en una propiedad pública si lo querés pasar  
                this.Tag = rol;

                // Este resultado lo va a ver Program.cs  
                this.DialogResult = DialogResult.OK;

                // Cerramos el login para que se abra el MDI principal  
                this.Close();
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
                this.Close(); // Cierra el formulario actual
            }
            // Si elige No, no hace nada
        }
    }
}
