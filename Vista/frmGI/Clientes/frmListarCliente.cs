using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.frmGI.Proveedores;
namespace Vista.frmGI.Clientes
{
    public partial class frmListarCliente : Form
    {
        private L_Cliente logicaCliente = new L_Cliente();
        public frmListarCliente()
        {
            InitializeComponent();
        }

        private void frmListarCliente_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }
        private void CargarClientes()
        {
            DataTable dt = logicaCliente.Listar();
            dgvCliente.DataSource = dt;

            
            if (dgvCliente.Columns.Contains("IdCliente"))
                dgvCliente.Columns["IdCliente"].Visible = false;

            
        }
        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvCliente.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un cliente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int ClienteID = Convert.ToInt32(dgvCliente.CurrentRow.Cells["ClienteId"].Value);

            frmModificarCliente frm = new frmModificarCliente(ClienteID);
            frm.ShowDialog();
            CargarClientes(); // Recarga después de modificar
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            if (dgvCliente.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un proveedor.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idProveedor = Convert.ToInt32(dgvCliente.CurrentRow.Cells["IdCliente"].Value);

            // Abro el detalle como un formulario normal (no bloquea la ventana padre)
            frmDetalleCliente frm = new frmDetalleCliente(_idCliente);
            frm.MdiParent = this.MdiParent; // si estás usando MDI, lo hace hijo del contenedor
            frm.WindowState = FormWindowState.Maximized; // opcional: para abrirlo maximizado
            frm.Show();

            this.Close(); 

        }
        
    }
}
