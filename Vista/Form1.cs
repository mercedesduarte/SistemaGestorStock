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
    


        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;
            string rol; 
            bool esAdmin;

     
            bool loginValido = L_Login.LoginUsuario(usuario, contrasena, out esAdmin, out rol);

            if (loginValido)
            {
                MessageBox.Show("¡Login exitoso!");

                Console.WriteLine($"Login exitoso. Rol: {rol}");

   
                Form3 form3 = new Form3(rol);
                form3.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3("Admin");
            form3.Show();
        }

    }
}
