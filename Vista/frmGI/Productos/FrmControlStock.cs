using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Vista.frmGI.Productos
{
    public partial class FrmControlStock : Form
    {
        private L_Producto logicaProducto = new L_Producto();
        private L_Control logicaControl = new L_Control();

        public FrmControlStock()
        {
            InitializeComponent();
        }

        private void FrmControlStock_Load(object sender, EventArgs e)
        {
            CargarControlStock();
            MostrarResumenStock();
        }

        private void btnRefrescar_Click_1(object sender, EventArgs e)
        {
            CargarControlStock();
            MostrarResumenStock();
            MessageBox.Show("Stock actualizado correctamente", "Información",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dvgStock_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dvgStock.Rows[e.RowIndex].Cells["Nivel"].Value != null)
            {
                string nivel = dvgStock.Rows[e.RowIndex].Cells["Nivel"].Value.ToString();

                switch (nivel)
                {
                    case "CRITICO":
                        dvgStock.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                        dvgStock.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkRed;
                        dvgStock.Rows[e.RowIndex].DefaultCellStyle.Font = new Font(dvgStock.Font, FontStyle.Bold);
                        break;
                    case "ALERTA":
                        dvgStock.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
                        dvgStock.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.OrangeRed;
                        break;
                    case "NORMAL":
                        dvgStock.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                        dvgStock.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkGreen;
                        break;
                    case "OPTIMO":
                        dvgStock.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
                        dvgStock.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkBlue;
                        break;
                    case "EXCEDIDO":
                        dvgStock.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Lavender;
                        dvgStock.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Purple;
                        break;
                }
            }
        }

        private void dvgStock_SelectionChanged(object sender, EventArgs e)
        {
            if (dvgStock.CurrentRow != null &&
                dvgStock.CurrentRow.Cells["Estado"].Value != null)
            {
                string estado = dvgStock.CurrentRow.Cells["Estado"].Value.ToString();
                string producto = dvgStock.CurrentRow.Cells["Producto"].Value.ToString();
                this.Text = $"Control de Stock - {producto}";
            }
        }

        private void dvgStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Método para clic en celdas (puedes agregar lógica aquí si necesitas)
        }

        private void CargarControlStock()
        {
            try
            {
                // Obtener productos de la base de datos
                DataTable productos = logicaProducto.Listar();

                // Verificar si se obtuvieron datos
                if (productos != null && productos.Rows.Count > 0)
                {
                    // Procesar los datos con L_Control
                    DataTable controlStock = logicaControl.ObtenerControlStock(productos);

                    // Asignar al DataGrid
                    dvgStock.DataSource = controlStock;

                    // Aplicar formato
                    AplicarFormatoGrid();

                    // Mostrar mensaje de éxito en consola (opcional)
                    Console.WriteLine($"Datos cargados: {controlStock.Rows.Count} productos");
                }
                else
                {
                    MessageBox.Show("No se encontraron productos para mostrar", "Información",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar control de stock: " + ex.Message, "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AplicarFormatoGrid()
        {
            if (dvgStock.Columns.Count > 0)
            {
                dvgStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Ocultar columnas que no se necesitan mostrar
                if (dvgStock.Columns.Contains("Nivel"))
                    dvgStock.Columns["Nivel"].Visible = false;

                if (dvgStock.Columns.Contains("ID"))
                    dvgStock.Columns["ID"].Visible = false;

                // Formato de números alineados a la derecha
                if (dvgStock.Columns.Contains("Stock Actual"))
                    dvgStock.Columns["Stock Actual"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                if (dvgStock.Columns.Contains("Stock Mínimo"))
                    dvgStock.Columns["Stock Mínimo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                if (dvgStock.Columns.Contains("Stock Ideal"))
                    dvgStock.Columns["Stock Ideal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                if (dvgStock.Columns.Contains("Stock Máximo"))
                    dvgStock.Columns["Stock Máximo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                if (dvgStock.Columns.Contains("Punto Reposición"))
                    dvgStock.Columns["Punto Reposición"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                // Hacer que el DataGrid sea más presentable
                dvgStock.EnableHeadersVisualStyles = false;
                dvgStock.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
                dvgStock.ColumnHeadersDefaultCellStyle.Font = new Font(dvgStock.Font, FontStyle.Bold);
            }
        }

        private void MostrarResumenStock()
        {
            try
            {
                if (dvgStock.DataSource != null)
                {
                    DataTable controlStock = (DataTable)dvgStock.DataSource;

                    int totalProductos = controlStock.Rows.Count;
                    int criticos = controlStock.AsEnumerable().Count(row => row["Nivel"].ToString() == "CRITICO");
                    int alertas = controlStock.AsEnumerable().Count(row => row["Nivel"].ToString() == "ALERTA");

                    if (criticos > 0)
                    {
                        MessageBox.Show($"🚨 ALERTA: {criticos} productos con stock CRÍTICO\n" +
                                      $"📊 Total productos: {totalProductos}",
                                      "Alerta de Stock",
                                      MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                // Error silencioso
            }
        }
    }
}