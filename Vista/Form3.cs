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
    }
}

