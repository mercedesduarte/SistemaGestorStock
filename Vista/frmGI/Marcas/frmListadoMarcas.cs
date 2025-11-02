
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

namespace Vista.frmGI.Marcas
{
    public partial class frmListadoMarcas : Form
    {
        private L_Marca logicaMarca = new L_Marca();

        public frmListadoMarcas()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListadoMarcas_Load(object sender, EventArgs e)
        {
            CargarMarcas();
        }

        private void CargarMarcas()
        {
            dgvMarcas.DataSource = logicaMarca.Listar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.CurrentRow != null)
            {
                int idMarca = Convert.ToInt32(dgvMarcas.CurrentRow.Cells["IdMarca"].Value);
                string nombre = dgvMarcas.CurrentRow.Cells["Nombre"].Value.ToString();
                bool activo = Convert.ToBoolean(dgvMarcas.CurrentRow.Cells["Activo"].Value);

                frmModificarMarca frm = new frmModificarMarca(idMarca, nombre, activo);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarMarcas(); // Refresca el listado al cerrar
                }
            }
            else
            {
                MessageBox.Show("Seleccione una marca para modificar.");
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarMarcas();
        }
    }
}
