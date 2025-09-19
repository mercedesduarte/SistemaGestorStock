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
    public partial class frmModificarCategoria : Form
    {
        private L_Categoria logica = new L_Categoria();
        private int _id;

        public frmModificarCategoria(int id, string nombre, string descripcion, bool activo)
        {
            InitializeComponent();
            _id = id;
            txtNombre.Text = nombre;
            txtDescripcion.Text = descripcion;
            chkActivo.Checked = activo;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifcar_Click(object sender, EventArgs e)
        {
            string mensaje;
            bool ok = logica.Modificar(_id, txtNombre.Text, txtDescripcion.Text, chkActivo.Checked, out mensaje);

            if (ok)
            {
                MessageBox.Show("Categoría modificada correctamente.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
