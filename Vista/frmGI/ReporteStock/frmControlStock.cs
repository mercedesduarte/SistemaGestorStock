using System;
using System.Data;
using System.Windows.Forms;
using Logica;

namespace Vista.frmGI.ReporteStock
{
    public partial class frmControlStock : Form
    {
        private L_Control logicaControl = new L_Control();

        public frmControlStock()
        {
            InitializeComponent();
        }

        private void frmControlStock_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                CargarPestanaStockMinimo();
                CargarPestanaPuntoReposicion();
                CargarPestanaPorVencer();
                CargarPestanaVencidos();
                ActualizarContadoresPestanas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPestanaStockMinimo()
        {
            DataTable datos = logicaControl.ObtenerProductosStockMinimo();
            dgvStockMinimo.DataSource = datos;
            lblCantStockMinimo.Text = $"{datos.Rows.Count} productos";
        }

        private void CargarPestanaPuntoReposicion()
        {
            DataTable datos = logicaControl.ObtenerProductosPuntoReposicion();
            dgvPuntoReposicion.DataSource = datos;
            lblCantReposicion.Text = $"{datos.Rows.Count} productos";
        }

        private void CargarPestanaPorVencer()
        {
            DataTable datos = logicaControl.ObtenerProductosPorVencer();
            dgvPorVencer.DataSource = datos;
            lblCountPorVencer.Text = $"{datos.Rows.Count} productos";
        }

        private void CargarPestanaVencidos()
        {
            DataTable datos = logicaControl.ObtenerProductosVencidos();
            dgvVencidos.DataSource = datos;
            lblCountVencidos.Text = $"{datos.Rows.Count} productos";
        }

        private void ActualizarContadoresPestanas()
        {
            tabMinimo.Text = $"Stock Minimo ({dgvStockMinimo.RowCount})";
            tabReposicion.Text = $"Punto Reposicion ({dgvPuntoReposicion.RowCount})";
            tabPorVencer.Text = $"Por Vencer ({dgvPorVencer.RowCount})";
            tabPage5.Text = $"Vencidos ({dgvVencidos.RowCount})";
        }
    }
}