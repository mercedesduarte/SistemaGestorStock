using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;
using System.Windows.Forms;

namespace Vista.frmGI.Proveedores.Productos
{
    public partial class frmModificarProveedorProducto : Form
    {

        private int _idProductoProveedor;
        private int _idProveedor;

        public frmModificarProveedorProducto(int idProductoProveedor, int idProveedor)
        {
            InitializeComponent();
            _idProductoProveedor = idProductoProveedor;
            _idProveedor = idProveedor;
        }



        private void frmModificarProveedorProducto_Load(object sender, EventArgs e)
        {
            CargarProductos();
            CargarDatos();
        }

        private void CargarProductos()
        {
            try
            {
                L_Producto logicaProducto = new L_Producto();
                DataTable dt = logicaProducto.Listar(); // Trae todos los productos
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

        private void CargarDatos()
        {
            try
            {
                L_ProveedorProducto logicaProductos = new L_ProveedorProducto();
                string mensaje;
                DataRow row = logicaProductos.ObtenerPorId(_idProductoProveedor, out mensaje);

                if (row != null)
                {
                    // Seleccionamos el producto correspondiente en el combo
                    cmbProducto.SelectedValue = Convert.ToInt32(row["IdProducto"]);

                    nudPrecioCompra.Value = Convert.ToDecimal(row["PrecioCompra"]);
                    txtCatalogo.Text = row["Catalogo"].ToString();
                    chkActivo.Checked = Convert.ToBoolean(row["Activo"]);
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos del producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje;
                L_ProveedorProducto logicaProductos = new L_ProveedorProducto();

                int idProducto = Convert.ToInt32(cmbProducto.SelectedValue); // Tomamos el IdProducto del combo
                decimal precioCompra = nudPrecioCompra.Value;
                string catalogo = txtCatalogo.Text.Trim();
                bool activo = chkActivo.Checked;

                bool actualizado = logicaProductos.Modificar(
                    _idProductoProveedor,
                    idProducto,
                    _idProveedor,
                    precioCompra,
                    catalogo,
                    activo,
                    out mensaje
                );

                if (actualizado)
                {
                    MessageBox.Show("Producto del proveedor modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cambios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void nudPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidadorTextBox.SoloNumeros(sender, e);
        }
    }
}
