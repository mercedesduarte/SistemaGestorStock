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
namespace Vista.frmGI.Productos
{
    public partial class frmModificarProducto : Form
    {
        private int IdProducto;
        private L_Producto logicaProducto = new L_Producto();

        public frmModificarProducto(int idProducto)
        {
            InitializeComponent();
            this.IdProducto = idProducto;
            CargarCombos();   // Primero lleno los combos
            CargarDatos();

        }

        private void CargarDatos()
        {
            string mensaje;
            DataRow dr = logicaProducto.ObtenerPorId(IdProducto, out mensaje);

            if (dr == null)
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            txtCodigo.Text = dr["Codigo"].ToString();
            txtNombre.Text = dr["Nombre"].ToString();
            txtDescripcion.Text = dr["Descripcion"].ToString();
            txtLote.Text = dr["Lote"].ToString();

            if (dr["FechaVencimiento"] != DBNull.Value)
                dtpFechaVencimiento.Value = Convert.ToDateTime(dr["FechaVencimiento"]);
            else
                dtpFechaVencimiento.Value = DateTime.Now;

            nudDiasAviso.Value = Convert.ToInt32(dr["DiasAvisoVencimiento"]);
            nudPrecioCompra.Value = Convert.ToDecimal(dr["PrecioCompra"]);
            nudPrecioVenta.Value = Convert.ToDecimal(dr["PrecioVenta"]);
            nudStockActual.Value = Convert.ToInt32(dr["StockActual"]);
            nudStockMinimo.Value = Convert.ToInt32(dr["StockMinimo"]);
            nudStockIdeal.Value = Convert.ToInt32(dr["StockIdeal"]);
            nudStockMaximo.Value = Convert.ToInt32(dr["StockMaximo"]);

            cmbTipoStock.SelectedItem = dr["TipoStock"].ToString();
            chkActivo.Checked = Convert.ToBoolean(dr["Activo"]);

            // combos de marca y categoría
            cmbCategoria.SelectedValue = Convert.ToInt32(dr["IdCategoria"]);
            cmbMarca.SelectedValue = Convert.ToInt32(dr["IdMarca"]);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string mensaje;
            bool ok = logicaProducto.Modificar(
                IdProducto,
                txtCodigo.Text,
                txtNombre.Text,
                txtDescripcion.Text,
                Convert.ToInt32(cmbCategoria.SelectedValue),
                Convert.ToInt32(cmbMarca.SelectedValue),
                txtLote.Text,
                dtpFechaVencimiento.Value,
                (int)nudDiasAviso.Value,
                nudPrecioCompra.Value,
                nudPrecioVenta.Value,
                (int)nudStockActual.Value,
                (int)nudStockMinimo.Value,
                (int)nudStockIdeal.Value,
                (int)nudStockMaximo.Value,
                cmbTipoStock.SelectedItem?.ToString() ?? "Existencia",
                chkActivo.Checked,
                out mensaje
            );

            if (ok)
            {
                MessageBox.Show("Producto modificado correctamente.");
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

        private void CargarCombos()
        {
            // Cargar Categorías
            L_Categoria logicaCategoria = new L_Categoria();
            DataTable categorias = logicaCategoria.Listar();
            cmbCategoria.DataSource = categorias;
            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "IdCategoria";

            // Cargar Marcas
            L_Marca logicaMarca = new L_Marca();
            DataTable marcas = logicaMarca.Listar();
            cmbMarca.DataSource = marcas;
            cmbMarca.DisplayMember = "Nombre";
            cmbMarca.ValueMember = "IdMarca";

            // Cargar TipoStock
            cmbTipoStock.Items.Clear();
            cmbTipoStock.Items.Add("Existencia");
            cmbTipoStock.Items.Add("JIT");
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
