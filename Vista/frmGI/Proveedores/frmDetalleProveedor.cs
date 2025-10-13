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
using Vista.frmGI.Proveedores.Direcciones;
using Vista.frmGI.Proveedores.Productos;

namespace Vista.frmGI.Proveedores
{
    public partial class frmDetalleProveedor : Form
    {
        private int _idProveedor;
        private L_ProveedorTelefono logicaTelefonos = new L_ProveedorTelefono();
        private L_Proveedor logicaProveedor = new L_Proveedor();


        public frmDetalleProveedor(int idProveedor)
        {
            InitializeComponent();
            _idProveedor = idProveedor;
        }

        private void frmDetalleProveedor_Load(object sender, EventArgs e)
        {
            CargarDatosGenerales();
            CargarTelefonos();
            CargarDirecciones();
            CargarProductos();

        }

     //---------------------------------- START DATOS GENERALES ----------------------------------------
        private void CargarDatosGenerales()
        {
            string mensaje;
            DataRow row = logicaProveedor.ObtenerPorId(_idProveedor, out mensaje);

            if (row != null)
            {
                txtCodigo.Text = row["Codigo"].ToString();
                txtRazonSocial.Text = row["RazonSocial"].ToString();
                txtCuit.Text = row["Cuit"].ToString();
                txtEmail.Text = row["Email"].ToString();
                cmbFormaPago.Text = row["FormaPago"].ToString();
                nudTiempoEntrega.Text = row["TiempoEntrega"].ToString();
                txtDescuento.Text = row["Descuento"].ToString();
                chkActivo.Checked = Convert.ToBoolean(row["Activo"]);
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnGuardarGeneral_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text.Trim();
            string razonSocial = txtRazonSocial.Text.Trim();
            string cuit = txtCuit.Text.Trim();
            string email = txtEmail.Text.Trim();
            string formaPago = cmbFormaPago.Text.Trim();

            int? tiempoEntrega = null;
            if (int.TryParse(nudTiempoEntrega.Text, out int t))
                tiempoEntrega = t;

            decimal descuento = 0;
            decimal.TryParse(txtDescuento.Text, out descuento);

            bool activo = chkActivo.Checked;

            string mensaje;
            bool actualizado = logicaProveedor.Modificar(_idProveedor, codigo, razonSocial, cuit, email, formaPago, tiempoEntrega, descuento, activo, out mensaje);

            if (actualizado)
            {
                MessageBox.Show("Proveedor actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatosGenerales();
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     //----------------------------------- END DATOS GENERALES -----------------------------------------






     //----------------------------------- START TELEFONOS ---------------------------------------------
        private void btnAgregarTelefono_Click(object sender, EventArgs e)
        {
            using (var frm = new frmAgregarProveedorTelefono(_idProveedor))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarTelefonos(); // recarga el grid
                }
            }
        }
        private void btnModificarTelefono_Click(object sender, EventArgs e)
        {
            if (dgvTelefonos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un teléfono para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idTelefono = Convert.ToInt32(dgvTelefonos.CurrentRow.Cells["IdTelefono"].Value);

            frmModificarProveedorTelefono frm = new frmModificarProveedorTelefono(idTelefono, _idProveedor);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarTelefonos(); // refresca la grilla de teléfonos del proveedor
            }
        }
        private void CargarTelefonos()
        {
            try
            {
                DataTable dt = logicaTelefonos.Listar(_idProveedor);
                dgvTelefonos.DataSource = dt;

                dgvTelefonos.Columns["IdTelefono"].Visible = false;
                dgvTelefonos.Columns["IdProveedor"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar teléfonos: " + ex.Message);
            }
        }
     //------------------------------------ END TELEFONOS ---------------------------------------------







     //------------------------------------ START DIRECCIONES -----------------------------------------

        private void btnAgregarDireccion_Click(object sender, EventArgs e)
        {
            using (var frm = new frmAgregarProveedorDireccion(_idProveedor))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarDirecciones(); // Método que recarga el DataGridView de direcciones
                }
            }
        }
        private void btnModificarDireccion_Click(object sender, EventArgs e)
        {
            if (dgvDirecciones.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una dirección para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtenemos el IdDireccion de la fila seleccionada
            int idDireccion = Convert.ToInt32(dgvDirecciones.CurrentRow.Cells["IdDireccion"].Value);

            // Abrimos el formulario de modificación de manera modal
            using (var frm = new frmModificarProveedorDireccion(idDireccion, _idProveedor))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarDirecciones(); // refresca el DataGridView de direcciones del proveedor
                }
            }
        }
        private void CargarDirecciones()
        {
            try
            {
                L_ProveedorDireccion logicaDirecciones = new L_ProveedorDireccion();
                DataTable dt = logicaDirecciones.Listar(_idProveedor);

                dgvDirecciones.DataSource = dt;

                // Ocultar columnas innecesarias
                dgvDirecciones.Columns["IdDireccion"].Visible = false;
                dgvDirecciones.Columns["IdProveedor"].Visible = false;

                // Opcional: ajustar ancho de columnas automáticamente
                //dgvDirecciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar direcciones: " + ex.Message);
            }
        }
        //------------------------------------ END DIRECCIONES ------------------------------------------






        //------------------------------------ START PRODUCTOS ------------------------------------------
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            using (var frm = new frmAgregarProveedorProducto(_idProveedor))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarProductos(); // recarga la grilla de productos
                }
            }
        }
        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un producto para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtenemos el IdProductoProveedor de la fila seleccionada
            int idProductoProveedor = Convert.ToInt32(dgvProductos.CurrentRow.Cells["IdProductoProveedor"].Value);

            // Abrimos el formulario de modificación de manera modal
            using (var frm = new frmModificarProveedorProducto(idProductoProveedor, _idProveedor))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarProductos(); // refresca la grilla de productos del proveedor
                }
            }
        }
        private void CargarProductos()
        {
            try
            {
                L_ProveedorProducto logicaProductos = new L_ProveedorProducto();
                DataTable dt = logicaProductos.ListarProductosPorProveedor(_idProveedor); // <- usar este método

                dgvProductos.DataSource = dt;

                dgvProductos.Columns["IdProductoProveedor"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //------------------------------------- END PRODUCTOS -------------------------------------------



        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
