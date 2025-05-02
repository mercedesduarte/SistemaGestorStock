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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.AliceBlue;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            L_Conexion.Conexiones();
        }

       

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            string usuario = txtuser.Text;
            string contrasena = txtcontra.Text;

            bool loginValido = L_Login.LoginUsuario(usuario, contrasena);

            if (loginValido)
            {
                MessageBox.Show("¡Login exitoso!");
                Form3 form3 = new Form3(); 
                form3.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}
