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
                this.Tag = rol;

                this.DialogResult = DialogResult.OK;

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
                this.Close(); 
            }
          
        }

        private void lblIniciarSesion_Click(object sender, EventArgs e)
        {

        }
    }
}
