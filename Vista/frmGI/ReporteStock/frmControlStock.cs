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

namespace Vista.frmGI.ReporteStock
{
    public partial class frmControlStock : Form
    {
        private L_Producto logicaProducto = new L_Producto();
        private L_Control logicaControl = new L_Control();

        public frmControlStock()
        {
            InitializeComponent();
        }

        private void CargarControlStock()
        {
            try
            {
                DataTable productos = logicaProducto.Listar();

                if (productos != null && productos.Rows.Count > 0)
                {
                    DataTable controlStock = logicaControl.ObtenerControlStock(productos);
                    dvgStock.DataSource = controlStock;
                    AplicarFormatoGrid();
                    Console.WriteLine($"Datos cargados: {controlStock.Rows.Count} productos");

                    // Actualizar el label después de cargar los datos
                    ActualizarLabelResumen();
                }
                else
                {
                    MessageBox.Show("No se encontraron productos para mostrar", "Información",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label3.Text = "No hay productos disponibles";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar control de stock: " + ex.Message, "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                label3.Text = "Error al cargar datos";
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

        private void ActualizarLabelResumen()
        {
            try
            {
                if (dvgStock.DataSource != null)
                {
                    DataTable controlStock = (DataTable)dvgStock.DataSource;

                    int totalProductos = controlStock.Rows.Count;

                    // Contar por nivel usando la columna "Nivel" que ya existe
                    int criticos = controlStock.AsEnumerable()
                        .Count(row => row.Field<string>("Nivel") == "CRITICO");
                    int alertas = controlStock.AsEnumerable()
                        .Count(row => row.Field<string>("Nivel") == "ALERTA");
                    int normales = controlStock.AsEnumerable()
                        .Count(row => row.Field<string>("Nivel") == "NORMAL");
                    int optimos = controlStock.AsEnumerable()
                        .Count(row => row.Field<string>("Nivel") == "OPTIMO");
                    int excedidos = controlStock.AsEnumerable()
                        .Count(row => row.Field<string>("Nivel") == "EXCEDIDO");

                    // Actualizar el label con la información
                    label3.Text = $"📊 Total: {totalProductos} | 🚨 Críticos: {criticos} | ⚠ Alertas: {alertas} | ✅ Normales: {normales} | 👍 Óptimos: {optimos} | 📦 Excedidos: {excedidos}";

                    // Cambiar color del label según la situación
                    if (criticos > 0)
                    {
                        label3.BackColor = Color.LightCoral;
                        label3.ForeColor = Color.DarkRed;
                        label3.Font = new Font(label3.Font, FontStyle.Bold);
                    }
                    else if (alertas > 0)
                    {
                        label3.BackColor = Color.LightYellow;
                        label3.ForeColor = Color.OrangeRed;
                    }
                    else
                    {
                        label3.BackColor = Color.LightGreen;
                        label3.ForeColor = Color.DarkGreen;
                    }
                }
            }
            catch (Exception ex)
            {
                label3.Text = "Error al calcular resumen";
                label3.BackColor = Color.LightGray;
            }
        }

        private void MostrarResumenCompleto()
        {
            try
            {
                if (dvgStock.DataSource != null)
                {
                    DataTable controlStock = (DataTable)dvgStock.DataSource;

                    int totalProductos = controlStock.Rows.Count;
                    int criticos = controlStock.AsEnumerable().Count(row => row["Nivel"].ToString() == "CRITICO");
                    int alertas = controlStock.AsEnumerable().Count(row => row["Nivel"].ToString() == "ALERTA");
                    int normales = controlStock.AsEnumerable().Count(row => row["Nivel"].ToString() == "NORMAL");
                    int optimos = controlStock.AsEnumerable().Count(row => row["Nivel"].ToString() == "OPTIMO");
                    int excedidos = controlStock.AsEnumerable().Count(row => row["Nivel"].ToString() == "EXCEDIDO");

                    string mensaje = $"📊 RESUMEN COMPLETO DE STOCK\n\n" +
                                   $"Total de productos: {totalProductos}\n" +
                                   $"🚨 Críticos: {criticos}\n" +
                                   $"⚠ En alerta: {alertas}\n" +
                                   $"✅ Normales: {normales}\n" +
                                   $"👍 Óptimos: {optimos}\n" +
                                   $"📦 Excedidos: {excedidos}";

                    MessageBox.Show(mensaje, "Resumen de Stock",
                                  MessageBoxButtons.OK,
                                  criticos > 0 ? MessageBoxIcon.Warning : MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar resumen", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmControlStock_Load(object sender, EventArgs e)
        {
            CargarControlStock();
            // Ya no llamamos a MostrarResumenStock() aquí
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarControlStock();
            MessageBox.Show("Stock actualizado correctamente", "Información",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMostrarResumen_Click(object sender, EventArgs e)
        {
            MostrarResumenCompleto();
        }

        private void dvgStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dvgStock.Rows[e.RowIndex].Cells["Nivel"].Value != null)
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}