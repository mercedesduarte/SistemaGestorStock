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
    public partial class frmListadoCategorias : Form
    {
        private L_Categoria logica = new L_Categoria();

        public frmListadoCategorias()
        {
            InitializeComponent();
        }

        private void frmListadoCategoria_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void CargarCategorias()
        {
            dgvCategorias.DataSource = logica.Listar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvCategorias.CurrentRow.Cells["IdCategoria"].Value);
                string nombre = dgvCategorias.CurrentRow.Cells["Nombre"].Value.ToString();
                string descripcion = dgvCategorias.CurrentRow.Cells["Descripcion"].Value.ToString();
                bool activo = Convert.ToBoolean(dgvCategorias.CurrentRow.Cells["Activo"].Value);

                frmModificarCategoria frm = new frmModificarCategoria(id, nombre, descripcion, activo);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarCategorias();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una categoría para modificar.");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarCategorias();
        }
    }
}
