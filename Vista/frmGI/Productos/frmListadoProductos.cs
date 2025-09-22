
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
namespace Vista.frmGI.Productos
{
    public partial class frmListadoProductos : Form
    {
        private L_Producto logicaProducto = new L_Producto();

        public frmListadoProductos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListadoProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();
            ConfigurarGrid();
        }

        private void CargarProductos()
        {
            dgvProductos.DataSource = logicaProducto.Listar();
        }

        private void ConfigurarGrid()
        {
            if (dgvProductos.Columns.Count > 0)
            {
                dgvProductos.Columns["IdProducto"].Visible = false;
                dgvProductos.Columns["Descripcion"].Visible = false;
                //dgvProductos.Columns["Activo"].HeaderText = "Estado";

                //dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un producto.");
                return;
            }

            int idProducto = Convert.ToInt32(dgvProductos.CurrentRow.Cells["IdProducto"].Value);

            frmModificarProducto frm = new frmModificarProducto(idProducto);
            frm.ShowDialog();

            CargarProductos();
        }
    }
}
