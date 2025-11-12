using System;
using System.Data;
using System.Drawing;
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
                Cursor = Cursors.WaitCursor;

                // Cargar cada pestaña individualmente
                CargarPestañaStockMinimo();
                CargarPestañaPuntoReposicion();
                CargarPestañaPorVencer();
                CargarPestañaVencidos();
                CargarPestañaReporteCompleto();
                CargarPestañaProductosCriticos();

                ActualizarContadoresPestanas();
                VerificarAlertasCriticas();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void CargarPestañaStockMinimo()
        {
            DataTable datos = logicaControl.ObtenerProductosStockMinimo();
            dgvStockMinimo.DataSource = datos;
            ConfigurarDataGridView(dgvStockMinimo, Color.LightCoral);
            lblCantStockMinimo.Text = $"{datos.Rows.Count} productos";
        }

        private void CargarPestañaPuntoReposicion()
        {
            DataTable datos = logicaControl.ObtenerProductosPuntoReposicion();
            dgvPuntoReposicion.DataSource = datos;
            ConfigurarDataGridView(dgvPuntoReposicion, Color.LightGoldenrodYellow);
            lblCantReposicion.Text = $"{datos.Rows.Count} productos";
        }

        private void CargarPestañaPorVencer()
        {
            DataTable datos = logicaControl.ObtenerProductosPorVencer();
            dgvPorVencer.DataSource = datos;
            ConfigurarDataGridView(dgvPorVencer, Color.LightBlue);
            lblCountPorVencer.Text = $"{datos.Rows.Count} productos";
        }

        private void CargarPestañaVencidos()
        {
            DataTable datos = logicaControl.ObtenerProductosVencidos();
            dgvVencidos.DataSource = datos;
            ConfigurarDataGridView(dgvVencidos, Color.LightCoral);
            lblCountVencidos.Text = $"{datos.Rows.Count} productos";
        }


        private void ConfigurarDataGridView(DataGridView dgv, Color backColor)
        {
            dgv.BackgroundColor = backColor;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.RowHeadersVisible = false;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;

            // Ajustar columnas específicas si existen
            if (dgv.Columns.Count > 0)
            {
                if (dgv.Columns.Contains("Producto"))
                    dgv.Columns["Producto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                if (dgv.Columns.Contains("Código"))
                    dgv.Columns["Código"].Width = 80;

                if (dgv.Columns.Contains("Stock Actual"))
                    dgv.Columns["Stock Actual"].Width = 80;

                if (dgv.Columns.Contains("Estado"))
                    dgv.Columns["Estado"].Width = 150;
            }
        }

        private void ActualizarContadoresPestanas()
        {
            // Actualizar textos de las pestañas con contadores
            tabMinim.Text = $"Stock Mínimo ({dgvStockMinimo.RowCount})";
            TabPuntoReposicion.Text = $"Punto Reposición ({dgvPuntoReposicion.RowCount})";
            TabPorVencer.Text = $"Por Vencer ({dgvPorVencer.RowCount})";
            TabVencidos.Text = $"Vencidos ({dgvVencidos.RowCount})";

        }

        private void VerificarAlertasCriticas()
        {
            int stockMinimo = dgvStockMinimo.RowCount;
            int vencidos = dgvVencidos.RowCount;

            if (stockMinimo > 0 || vencidos > 0)
            {
                string mensaje = "";

                if (stockMinimo > 0 && vencidos > 0)
                {
                    mensaje = $"ALERTA CRÍTICA:\n\n• {stockMinimo} productos con STOCK MÍNIMO\n• {vencidos} productos VENCIDOS\n\nRequieren atención inmediata.";
                }
                else if (stockMinimo > 0)
                {
                    mensaje = $"ALERTA:\n\n• {stockMinimo} productos con STOCK MÍNIMO\n\nRequieren reposición urgente.";
                }
                else if (vencidos > 0)
                {
                    mensaje = $"ALERTA:\n\n• {vencidos} productos VENCIDOS\n\nDeben ser retirados del inventario.";
                }

                MessageBox.Show(mensaje, "Alertas de Inventario",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            ExportarPestañaActual();
        }

        private void ExportarPestañaActual()
        {
            try
            {
                DataGridView dgvActual = ObtenerDataGridViewActual();

                if (dgvActual != null && dgvActual.RowCount > 0)
                {
                    MessageBox.Show($"Exportando {dgvActual.RowCount} registros de la pestaña actual...",
                                  "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No hay datos para exportar en esta pestaña.", "Exportar",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataGridView ObtenerDataGridViewActual()
        {
            switch (tabControl1.SelectedTab.Name)
            {
                case "tabStockMinimo": return dgvStockMinimo;
                case "tabPuntoReposicion": return dgvPuntoReposicion;
                case "tabPorVencer": return dgvPorVencer;
                case "tabVencidos": return dgvVencidos;
                default: return null;
            }
        }

        private void dgvStockMinimo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            AplicarFormatoCeldas((DataGridView)sender, e.RowIndex);
        }

        private void dgvVencidos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            AplicarFormatoCeldas((DataGridView)sender, e.RowIndex);
        }

        private void AplicarFormatoCeldas(DataGridView dgv, int rowIndex)
        {
            if (rowIndex >= 0)
            {
                // Resaltar filas críticas
                if (dgv.Name == "dgvStockMinimo" || dgv.Name == "dgvVencidos")
                {
                    dgv.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                    dgv.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }
    }
}