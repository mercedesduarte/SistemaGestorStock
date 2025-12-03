using System;
using System.Data;
using System.Windows.Forms;
using Logica;
using System.Drawing;

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
            AplicarEstilosGrillas();

            // Wire refresh buttons to reload data (additional safety)
            try
            {
                button7.Click += (s, ev) => CargarDatos(); // Minimo
                button6.Click += (s, ev) => CargarDatos(); // Reposicion
                button5.Click += (s, ev) => CargarDatos(); // Por vencer
                btnRefrescar.Click += (s, ev) => CargarDatos(); // Vencidos

                // Wire close buttons
                button1.Click += (s, ev) => this.Close();
                button2.Click += (s, ev) => this.Close();
                button3.Click += (s, ev) => this.Close();
                button4.Click += (s, ev) => this.Close();
            }
            catch { /* ignore if designer already wired events */ }
        }

        // Methods expected by Designer event hookups
        private void btnRefrescarMinimo_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnRefrescarReposicion_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnRefrescarPorVencer_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnRefrescarVencidos_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AplicarEstilosGrillas()
        {
            // Configure all DataGridViews used in this form
            var dgvList = new DataGridView[] { dgvStockMinimo, dgvPuntoReposicion, dgvPorVencer, dgvVencidos };

            foreach (var dgv in dgvList)
            {
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv.ReadOnly = true;
                dgv.AllowUserToAddRows = false;
                dgv.RowHeadersVisible = false;
                dgv.MultiSelect = false;
                dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 153, 255);
                dgv.DefaultCellStyle.SelectionForeColor = Color.White;
                dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
                dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Consolas", 11F, FontStyle.Bold);
                dgv.DefaultCellStyle.Font = new Font("Consolas", 10F);
                dgv.EnableHeadersVisualStyles = false;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 230, 230);
            }
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

                // diagnostic: si todas las grillas están vacías, obtener conteos directos de fuentes
                int total = (dgvStockMinimo.DataSource as DataTable)?.Rows.Count ?? 0;
                total += (dgvPuntoReposicion.DataSource as DataTable)?.Rows.Count ?? 0;
                total += (dgvPorVencer.DataSource as DataTable)?.Rows.Count ?? 0;
                total += (dgvVencidos.DataSource as DataTable)?.Rows.Count ?? 0;

                Func<DataGridView, bool> isMessageTable = (dgv) =>
                {
                    var dt = dgv.DataSource as DataTable;
                    return dt != null && dt.Columns.Count == 1 && dt.Columns.Contains("Mensaje");
                };

                if (total == 0 || isMessageTable(dgvStockMinimo) || isMessageTable(dgvPuntoReposicion) || isMessageTable(dgvPorVencer) || isMessageTable(dgvVencidos))
                {
                    // get underlying data counts to help debug
                    DataTable rawFromProductos = logicaControl.ObtenerReporteCompleto();
                    DataTable rawCriticos = logicaControl.ObtenerProductosCriticos();

                    string detail = $"Resumen fuentes:\n- Productos (ListarControlStockVencimientos): {rawFromProductos?.Rows.Count ?? 0} filas\n- SP Productos Criticos: {rawCriticos?.Rows.Count ?? 0} filas\n\nSi estas cifras son 0, revisá que las tablas y los stored procedures en la base de datos existan y contengan datos.";

                    MessageBox.Show(detail, "Diagnóstico carga stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable CreateEmptyMessageTable(string message)
        {
            var dt = new DataTable();
            dt.Columns.Add("Mensaje");
            dt.Rows.Add(message);
            return dt;
        }

        private void CargarPestanaStockMinimo()
        {
            DataTable datos = logicaControl.ObtenerProductosStockMinimo();
            if (datos == null || datos.Rows.Count == 0)
            {
                dgvStockMinimo.DataSource = CreateEmptyMessageTable("No hay productos en estado 'Stock mínimo' o no se pudo recuperar la información.");
            }
            else
            {
                dgvStockMinimo.DataSource = datos;
            }

            lblCantStockMinimo.Text = $"{(datos?.Rows.Count ?? 0)} productos";
        }

        private void CargarPestanaPuntoReposicion()
        {
            DataTable datos = logicaControl.ObtenerProductosPuntoReposicion();
            if (datos == null || datos.Rows.Count == 0)
            {
                dgvPuntoReposicion.DataSource = CreateEmptyMessageTable("No hay productos en 'Punto de reposición' o no se pudo recuperar la información.");
            }
            else
            {
                dgvPuntoReposicion.DataSource = datos;
            }

            lblCantReposicion.Text = $"{(datos?.Rows.Count ?? 0)} productos";
        }

        private void CargarPestanaPorVencer()
        {
            DataTable datos = logicaControl.ObtenerProductosPorVencer();
            if (datos == null || datos.Rows.Count == 0)
            {
                dgvPorVencer.DataSource = CreateEmptyMessageTable("No hay productos próximos a vencer o no se pudo recuperar la información.");
            }
            else
            {
                dgvPorVencer.DataSource = datos;

                // format date column if exists
                if (datos.Columns.Contains("Fecha Vencimiento"))
                {
                    dgvPorVencer.Columns["Fecha Vencimiento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }

            lblCountPorVencer.Text = $"{(datos?.Rows.Count ?? 0)} productos";
        }

        private void CargarPestanaVencidos()
        {
            DataTable datos = logicaControl.ObtenerProductosVencidos();
            if (datos == null || datos.Rows.Count == 0)
            {
                dgvVencidos.DataSource = CreateEmptyMessageTable("No hay productos vencidos o no se pudo recuperar la información.");
            }
            else
            {
                dgvVencidos.DataSource = datos;

                if (datos.Columns.Contains("Fecha Vencimiento"))
                {
                    dgvVencidos.Columns["Fecha Vencimiento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }

            lblCountVencidos.Text = $"{(datos?.Rows.Count ?? 0)} productos";
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