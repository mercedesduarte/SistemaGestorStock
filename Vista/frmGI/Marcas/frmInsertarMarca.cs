using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;


namespace Vista.frmGI.Marcas
{
    public partial class frmInsertarMarca : Form
    {
        private L_Marca logicaMarca = new L_Marca();

        public frmInsertarMarca()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsertarMarca_Click(object sender, EventArgs e)
        {
            string mensaje;
            bool ok = logicaMarca.Insertar(txtNombre.Text, out mensaje);

            if (ok)
            {
                MessageBox.Show("Marca registrada correctamente.");
                txtNombre.Clear();
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
