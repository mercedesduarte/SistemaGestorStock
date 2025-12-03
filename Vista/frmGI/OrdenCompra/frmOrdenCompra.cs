using Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Vista.frmGI.OrdenCompra
{
    public partial class frmOrdenCompra : Form
    {
        private L_Proveedor logicaProveedor = new L_Proveedor();
        private L_Producto logicaProducto = new L_Producto();
        private L_OrdenCompra logicaOrden = new L_OrdenCompra();

        public frmOrdenCompra()
        {
            InitializeComponent();
        }

        private void frmOrdenCompra_Load(object sender, EventArgs e)
        {
            CargarProveedores();
            CargarProductosCombo();
            btnAgregarProducto.Click += BtnAgregarProducto_Click;
            btnEliminarProducto.Click += BtnEliminarProducto_Click;
            btnGenerarOrden.Click += BtnGenerarOrden_Click;
            btnLimpiar.Click += BtnLimpiar_Click;
            EnsureHiddenIdColumn();
        }

        private void EnsureHiddenIdColumn()
        {
            if (!dgvProductos.Columns.Contains("IdProductoHidden"))
            {
                var col = new DataGridViewTextBoxColumn();
                col.Name = "IdProductoHidden";
                col.HeaderText = "IdProductoHidden";
                col.Visible = false;
                dgvProductos.Columns.Add(col);
            }
        }

        private void CargarProveedores()
        {
            try
            {
                var dt = logicaProveedor.Listar();
                txtProveedorNombre.ReadOnly = true;
                txtProveedorNombre.Click += (s, e) => {
                    using (var f = new Vista.frmGI.Proveedores.frmListadoProveedores())
                    {
                        if (f.ShowDialog(this) == System.Windows.Forms.DialogResult.OK && f.SelectedProveedorId > 0)
                        {
                            int id = f.SelectedProveedorId;
                            // cargar datos del proveedor seleccionado
                            string mensaje;
                            var row = logicaProveedor.ObtenerPorId(id, out mensaje);
                            if (row != null)
                            {
                                txtProveedorNombre.Text = row["RazonSocial"].ToString();
                                // D_Proveedor.ObtenerPorId may not return a Direccion column; check safely
                                txtProveedorDireccion.Text = row.Table.Columns.Contains("Direccion") ? row["Direccion"].ToString() : string.Empty;
                                txtProveedorNombre.Tag = id; // store id for later
                            }
                            else
                            {
                                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                };
            }
            catch { }
        }

        private void CargarProductosCombo()
        {
            try
            {
                var dt = logicaProducto.Listar();
                cmbProductoData = dt;
            }
            catch { cmbProductoData = null; }
        }

        private DataTable cmbProductoData;

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                using (var f = new Form())
                {
                    f.StartPosition = FormStartPosition.CenterParent;
                    f.Size = new System.Drawing.Size(700, 400);
                    var dgv = new DataGridView { Dock = DockStyle.Fill, ReadOnly = true, SelectionMode = DataGridViewSelectionMode.FullRowSelect };
                    dgv.DataSource = cmbProductoData;
                    f.Controls.Add(dgv);
                    var btn = new Button { Text = "Seleccionar", Dock = DockStyle.Bottom, Height = 40 };
                    btn.Click += (s, ev) => { f.DialogResult = DialogResult.OK; f.Close(); };
                    f.Controls.Add(btn);

                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        if (dgv.SelectedRows.Count == 0) return;
                        var row = (dgv.SelectedRows[0].DataBoundItem as DataRowView).Row;
                        int idProducto = Convert.ToInt32(row["IdProducto"]);
                        string nombre = row["Nombre"].ToString();
                        string marca = row.Table.Columns.Contains("Marca") ? row["Marca"].ToString() : string.Empty;
                        string categoria = row.Table.Columns.Contains("Categoria") ? row["Categoria"].ToString() : string.Empty;

                        string sCant = Prompt.ShowDialog("Cantidad:", "Cantidad", "1");
                        if (!int.TryParse(sCant, out int cantidad) || cantidad <= 0) return;
                        string sPrecio = Prompt.ShowDialog("Precio unitario:", "Precio", row.Table.Columns.Contains("PrecioCompra") && row["PrecioCompra"] != DBNull.Value ? row["PrecioCompra"].ToString() : "0");
                        if (!decimal.TryParse(sPrecio, out decimal precio) || precio < 0) return;

                        decimal subtotal = cantidad * precio;

                        // add empty row and set cells by column name to ensure correct mapping
                        int rowIndex = dgvProductos.Rows.Add();
                        var newRow = dgvProductos.Rows[rowIndex];
                        if (dgvProductos.Columns.Contains("colProducto")) newRow.Cells["colProducto"].Value = nombre;
                        else newRow.Cells[0].Value = nombre;
                        if (dgvProductos.Columns.Contains("colMarca")) newRow.Cells["colMarca"].Value = marca;
                        if (dgvProductos.Columns.Contains("colCategoria")) newRow.Cells["colCategoria"].Value = categoria;
                        if (dgvProductos.Columns.Contains("colCantidad")) newRow.Cells["colCantidad"].Value = cantidad;
                        if (dgvProductos.Columns.Contains("colPrecio")) newRow.Cells["colPrecio"].Value = priceToString(precio);
                        if (dgvProductos.Columns.Contains("colSubtotal")) newRow.Cells["colSubtotal"].Value = subtotal.ToString("N2");
                        // store product id in hidden column for reliable retrieval later
                        if (dgvProductos.Columns.Contains("IdProductoHidden")) newRow.Cells["IdProductoHidden"].Value = idProducto;
                        ActualizarTotal();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                dgvProductos.Rows.Remove(dgvProductos.CurrentRow);
                ActualizarTotal();
            }
        }

        private void ActualizarTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow r in dgvProductos.Rows)
            {
                if (r.Cells[5].Value != null && decimal.TryParse(r.Cells[5].Value.ToString(), out decimal s)) total += s;
            }
            lblTotal.Text = $"TOTAL: ${total:N2}";
        }

        private void BtnGenerarOrden_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtProveedorNombre.Text))
                {
                    MessageBox.Show("Seleccione un proveedor (clic en Nombre).", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idProveedor = 0;
                if (txtProveedorNombre.Tag != null && int.TryParse(txtProveedorNombre.Tag.ToString(), out int tagId) && tagId > 0)
                {
                    idProveedor = tagId;
                }
                else
                {
                    // fallback: try to obtain from user if not selected via selector
                    string sIdProv = Prompt.ShowDialog("Id del proveedor:", "Proveedor", "0");
                    if (!int.TryParse(sIdProv, out idProveedor) || idProveedor <= 0)
                    {
                        MessageBox.Show("Id de proveedor inválido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                var detalles = new List<(int idProducto, int cantidad, decimal precio)>();
                var skipped = new List<string>();
                foreach (DataGridViewRow r in dgvProductos.Rows)
                {
                    int idProducto = 0;
                    // prefer stored hidden id
                    if (r.Cells["IdProductoHidden"] != null && r.Cells["IdProductoHidden"].Value != null)
                    {
                        int.TryParse(r.Cells["IdProductoHidden"].Value.ToString(), out idProducto);
                    }
                    else
                    {
                        // fallback to name lookup if hidden id not present
                        string nombre = r.Cells[0].Value?.ToString();
                        if (cmbProductoData != null)
                        {
                            var found = cmbProductoData.AsEnumerable().FirstOrDefault(dr => dr.Field<string>("Nombre") == nombre);
                            if (found != null) idProducto = found.Field<int>("IdProducto");
                        }
                    }

                    string prodName = (r.Cells[0].Value ?? string.Empty).ToString();
                    if (idProducto == 0)
                    {
                        // skip this row but remember to inform the user
                        skipped.Add(string.IsNullOrWhiteSpace(prodName) ? "(sin nombre)" : prodName);
                        continue;
                    }

                    int cantidad = 0;
                    decimal precio = 0;
                    try
                    {
                        cantidad = Convert.ToInt32(r.Cells[3].Value);
                    }
                    catch { cantidad = 0; }
                    try
                    {
                        precio = decimal.Parse(r.Cells[4].Value.ToString());
                    }
                    catch { precio = 0; }

                    if (cantidad <= 0)
                    {
                        skipped.Add(prodName + " (cantidad inválida)");
                        continue;
                    }

                    detalles.Add((idProducto, cantidad, precio));
                }

                if (detalles.Count == 0)
                {
                    MessageBox.Show("No hay productos válidos en la orden. Agregue productos desde el selector.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (skipped.Count > 0)
                {
                    MessageBox.Show("Se omitieron productos no válidos: \n" + string.Join("\n", skipped), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                string mensaje;
                bool ok = logicaOrden.CrearOrden(idProveedor, DateTime.Now, detalles, out mensaje);
                if (ok)
                {
                    MessageBox.Show("Orden de compra generada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvProductos.Rows.Clear();
                    ActualizarTotal();
                }
                else
                {
                    MessageBox.Show("No se pudo generar la orden: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generando orden: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtClienteNombre.Clear();
            txtClienteRUC.Clear();
            txtProveedorNombre.Clear();
            txtProveedorNombre.Tag = null;
            txtProveedorDireccion.Clear();
            dgvProductsClear();
            lblTotal.Text = "TOTAL: $0.00";
        }

        private void dgvProductsClear()
        {
            dgvProductos.Rows.Clear();
        }

        // Small prompt helper to avoid VB dependency
        private static class Prompt
        {
            public static string ShowDialog(string text, string caption, string defaultValue)
            {
                using (Form prompt = new Form())
                {
                    prompt.Width = 400;
                    prompt.Height = 150;
                    prompt.Text = caption;
                    prompt.StartPosition = FormStartPosition.CenterParent;
                    var lbl = new Label() { Left = 10, Top = 10, Text = text, AutoSize = true };
                    var txt = new TextBox() { Left = 10, Top = 40, Width = 360, Text = defaultValue };
                    var ok = new Button() { Text = "OK", Left = 200, Width = 80, Top = 70, DialogResult = DialogResult.OK };
                    var cancel = new Button() { Text = "Cancelar", Left = 290, Width = 80, Top = 70, DialogResult = DialogResult.Cancel };
                    prompt.Controls.Add(lbl);
                    prompt.Controls.Add(txt);
                    prompt.Controls.Add(ok);
                    prompt.Controls.Add(cancel);
                    prompt.AcceptButton = ok;
                    prompt.CancelButton = cancel;

                    return prompt.ShowDialog() == DialogResult.OK ? txt.Text : string.Empty;
                }
            }
        }

        // helper to format price consistently
        private static string priceToString(decimal price)
        {
            return price.ToString("N2");
        }
    }
}
