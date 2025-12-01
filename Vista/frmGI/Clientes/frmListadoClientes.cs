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

namespace Vista.frmGI.Clientes
{
    public partial class frmListadoClientes : Form
    {
        private L_Cliente logicaCliente = new L_Cliente();

        public frmListadoClientes()
        {
            InitializeComponent();
        }

        private void frmListadoClientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
            try
            {
                DataTable dt = logicaCliente.Listar();
                dgvClientes.DataSource = dt;

                // Ocultar columnas que no queremos mostrar
                if (dgvClientes.Columns.Contains("IdCliente"))
                    dgvClientes.Columns["IdCliente"].Visible = false;

                // Opcional: ajustar ancho de columnas automáticamente
                //dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Botón para refrescar la grilla
        //private void btnRefrescar_Click(object sender, EventArgs e)
        //{
        //    CargarClientes();
        //}

        //private void btnModificar_Click(object sender, EventArgs e)
        //{
        //    if (dgvClientes.CurrentRow == null)
        //    {
        //        MessageBox.Show("Debe seleccionar un cliente para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    // Obtener el IdCliente de la fila seleccionada
        //    int idCliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells["IdCliente"].Value);

        //    // Abrir el formulario de modificación de cliente
        //    using (var frm = new frmModificarCliente(idCliente))
        //    {
        //        if (frm.ShowDialog() == DialogResult.OK)
        //        {
        //            // Refrescar la grilla después de modificar
        //            CargarClientes();
        //        }
        //    }
        //}

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un cliente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idCliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells["IdCliente"].Value);

            // Abrimos el detalle como un formulario normal (no bloquea la ventana padre)
            frmDetalleCliente frm = new frmDetalleCliente(idCliente);
            frm.MdiParent = this.MdiParent; // lo hace hijo del contenedor MDI
            frm.WindowState = FormWindowState.Maximized; // opcional: abrirlo maximizado
            frm.Show();

            // Cierra el listado actual si querés que quede solo el detalle
            this.Close();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarClientes();
        }
    }
}
