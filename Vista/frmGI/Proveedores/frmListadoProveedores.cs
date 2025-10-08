using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Logica;
using System;

namespace Vista.frmGI.Proveedores
{
    public partial class frmListadoProveedores : Form
    {
        private L_Proveedor logicaProveedor = new L_Proveedor();

        public frmListadoProveedores()
        {
            InitializeComponent();
        }

        private void frmListadoProveedores_Load(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        private void CargarProveedores()
        {
            DataTable dt = logicaProveedor.Listar();
            dgvProveedores.DataSource = dt;

            // Ocultar columnas innecesarias si querés
            dgvProveedores.Columns["IdProveedor"].Visible = false;

            // Ajustar ancho
            //dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un proveedor.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idProveedor = Convert.ToInt32(dgvProveedores.CurrentRow.Cells["IdProveedor"].Value);

            frmModificarProveedor frm = new frmModificarProveedor(idProveedor);
            frm.ShowDialog();
            CargarProveedores();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {

            if (dgvProveedores.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un proveedor.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idProveedor = Convert.ToInt32(dgvProveedores.CurrentRow.Cells["IdProveedor"].Value);

            // Abro el detalle como un formulario normal (no bloquea la ventana padre)
            frmDetalleProveedor frm = new frmDetalleProveedor(idProveedor);
            frm.MdiParent = this.MdiParent; // si estás usando MDI, lo hace hijo del contenedor
            frm.WindowState = FormWindowState.Maximized; // opcional: para abrirlo maximizado
            frm.Show();

            this.Close(); // cierro el listado si es necesario
        }
    }
}
