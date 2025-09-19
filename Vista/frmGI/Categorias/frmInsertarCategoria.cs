using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using System;

namespace Vista.frmGI.Categorias
{
    public partial class frmInsertarCategoria : Form
    {
        private L_Categoria logica = new L_Categoria();

        public frmInsertarCategoria()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsertarCategoria_Click(object sender, EventArgs e)
        {
            string mensaje;
            bool ok = logica.Insertar(txtNombre.Text, txtDescripcion.Text, out mensaje);

            if (ok)
            {
                MessageBox.Show("Categoría registrada correctamente.");
                txtNombre.Clear();
                txtDescripcion.Clear();
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
