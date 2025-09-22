
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
    public partial class frmInsertarProducto : Form
    {
        private L_Producto logicaProducto = new L_Producto();
        private L_Categoria logicaCategoria = new L_Categoria();
        private L_Marca logicaMarca = new L_Marca();

        public frmInsertarProducto()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInsertarProducto_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            CargarMarcas();
            cmbTipoStock.Items.Add("Existencia");
            cmbTipoStock.Items.Add("JIT");
            cmbTipoStock.SelectedIndex = 0;
        }


        private void CargarCategorias()
        {
            cmbCategoria.DataSource = logicaCategoria.Listar();
            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "IdCategoria";
        }

        private void CargarMarcas()
        {
            cmbMarca.DataSource = logicaMarca.Listar();
            cmbMarca.DisplayMember = "Nombre";
            cmbMarca.ValueMember = "IdMarca";
        }

        private void btnInsertarCategoria_Click(object sender, EventArgs e)
        {
            string mensaje;

            bool ok = logicaProducto.Insertar(
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
                cmbTipoStock.SelectedItem.ToString(),
                out mensaje
            );

            if (ok)
            {
                MessageBox.Show("Producto registrado correctamente.");
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtLote.Clear();
            nudDiasAviso.Value = 0;
            nudPrecioCompra.Value = 0;
            nudPrecioVenta.Value = 0;
            nudStockActual.Value = 0;
            nudStockMinimo.Value = 0;
            nudStockIdeal.Value = 0;
            nudStockMaximo.Value = 0;
            cmbCategoria.SelectedIndex = 0;
            cmbMarca.SelectedIndex = 0;
            cmbTipoStock.SelectedIndex = 0;
            dtpFechaVencimiento.Value = DateTime.Now;
        }
    }
}
