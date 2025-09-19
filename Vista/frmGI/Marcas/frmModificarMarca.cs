using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;
using Logica;

namespace Vista.frmGI.Marcas
{
    public partial class frmModificarMarca : Form
    {
        private L_Marca logicaMarca = new L_Marca();
        private int _idMarca;

        public frmModificarMarca(int idMarca, string nombre, bool activo)
        {
            InitializeComponent();
            _idMarca = idMarca;
            txtNombre.Text = nombre;
            chkActivo.Checked = activo;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifcar_Click(object sender, EventArgs e)
        {
            string mensaje;
            bool ok = logicaMarca.Modificar(_idMarca, txtNombre.Text, chkActivo.Checked, out mensaje);

            if (ok)
            {
                MessageBox.Show("Marca modificada correctamente.");
                this.DialogResult = DialogResult.OK; // Para avisar al listado que se actualice
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
