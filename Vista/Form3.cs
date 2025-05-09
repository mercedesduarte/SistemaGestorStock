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
    public partial class Form3 : Form
    {
        private string rol;

        public Form3(string rol)
        {
            InitializeComponent(); // Esta función no lleva parámetros
            this.rol = rol;

            label1.Text = $"Rol: {rol}";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (rol == "")
            {
                Console.WriteLine("No se trae nada pa");
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHoras.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("ddd/dd/MM/yyyy");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}

