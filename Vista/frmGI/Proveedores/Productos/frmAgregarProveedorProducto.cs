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

namespace Vista.frmGI.Proveedores.Productos
{
    public partial class frmAgregarProveedorProducto : Form
    {
        private int _idProveedor;
        private L_ProveedorProducto logicaProveedorProducto = new L_ProveedorProducto();
        private L_Producto logicaProducto = new L_Producto(); // Debe existir para listar productos

        public frmAgregarProveedorProducto(int idProveedor)
        {
            InitializeComponent();
            _idProveedor = idProveedor;

        }

        private void frmAgregarProveedorProducto_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            try
            {
                DataTable dt = logicaProducto.Listar(); // Método que devuelve todos los productos
                cmbProducto.DataSource = dt;
                cmbProducto.DisplayMember = "Nombre";
                cmbProducto.ValueMember = "IdProducto";
                cmbProducto.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un producto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idProducto = Convert.ToInt32(cmbProducto.SelectedValue);
            decimal precioCompra;
            if (!decimal.TryParse(txtPrecioCompra.Text.Trim(), out precioCompra))
            {
                MessageBox.Show("Ingrese un precio de compra válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string catalogo = txtCatalogo.Text.Trim();

            string mensaje;
            bool insertado = logicaProveedorProducto.Insertar(idProducto, _idProveedor, precioCompra, catalogo, out mensaje);

            if (insertado)
            {
                MessageBox.Show("Producto agregado correctamente al proveedor.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidadorTextBox.NoPermitirEscribir(sender, e);
        }

        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidadorTextBox.SoloNumeros(sender, e);
        }
    }
}
