using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Logica;

namespace Vista.frmGI.Presupuesto
{
    public partial class frmEmisionPresupuesto : Form
    {
        private int idProductoSeleccionado = 0;
        private int idClienteSeleccionado = 0;

        public frmEmisionPresupuesto()
        {
            InitializeComponent();

           
            txtCantidad.KeyDown += txtCantidad_KeyDown;

            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtNombreCliente.Clear();
            txtDireccionCliente.Clear();
            txtEmailCliente.Clear();
            txtTelefonoCliente.Clear();
            txtCondicionVenta.Text = "Contado";

            txtProducto.Clear();
            txtMarca.Clear();
            txtCategoria.Clear();
            txtCantidad.Clear();
            txtPrecioUnitario.Clear();

            txtSubtotal.Clear();
            txtTotal.Clear();
            txtObservaciones.Clear();

            idProductoSeleccionado = 0;
            idClienteSeleccionado = 0;

            L_EmisionPresupuesto.LimpiarPresupuesto();

            btnCalcular.Enabled = false;
            btnConvertirPedido.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                using (var frmBusqueda = CrearFormularioBusqueda("cliente"))
                {
                    if (frmBusqueda.ShowDialog() == DialogResult.OK)
                    {
                        var dgv = (DataGridView)frmBusqueda.Controls.Find("dgvBusqueda", true)[0];
                        if (dgv.SelectedRows.Count > 0)
                        {
                            idClienteSeleccionado = Convert.ToInt32(dgv.SelectedRows[0].Cells["IdCliente"].Value);
                            CargarCliente(idClienteSeleccionado);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar cliente: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCliente(int idCliente)
        {
            try
            {
                string nombre = "", email = "", formaPago = "";

                if (L_EmisionPresupuesto.CargarDatosCliente(idCliente, ref nombre, ref email, ref formaPago))
                {
                    txtNombreCliente.Text = nombre;
                    txtEmailCliente.Text = email;
                    txtCondicionVenta.Text = formaPago;

                    MessageBox.Show($"Cliente cargado: {nombre}", "Éxito",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (L_EmisionPresupuesto.ObtenerCantidadProductos() > 0)
                    {
                        btnConvertirPedido.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo cargar los datos del cliente.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                using (var frmBusqueda = CrearFormularioBusqueda("producto"))
                {
                    if (frmBusqueda.ShowDialog() == DialogResult.OK)
                    {
                        var dgv = (DataGridView)frmBusqueda.Controls.Find("dgvBusqueda", true)[0];
                        if (dgv.SelectedRows.Count > 0)
                        {
                            idProductoSeleccionado = Convert.ToInt32(dgv.SelectedRows[0].Cells["IdProducto"].Value);
                            CargarProducto(idProductoSeleccionado);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar producto: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProducto(int idProducto)
        {
            try
            {
                string nombre = "", categoria = "", marca = "";
                decimal precio = 0, stock = 0;

                if (L_EmisionPresupuesto.CargarDatosProductoCompleto(
                    idProducto, ref nombre, ref categoria, ref marca, ref precio, ref stock))
                {
                    txtProducto.Text = nombre;
                    txtCategoria.Text = categoria;
                    txtMarca.Text = marca;
                    txtPrecioUnitario.Text = precio.ToString("N2");

                    txtCantidad.ReadOnly = false;
                    txtCantidad.Focus();
                    txtCantidad.SelectAll();

                    MessageBox.Show($"Producto cargado: {nombre}\nPrecio: {precio:N2}",
                                  "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo cargar los datos del producto.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AgregarProductoAPresupuesto();
                e.Handled = true;
            }
        }

        private void AgregarProductoAPresupuesto()
        {
            if (idProductoSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un producto primero.", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtCantidad.Text, out decimal cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida mayor a cero.", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidad.Focus();
                return;
            }

            if (!decimal.TryParse(txtPrecioUnitario.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Precio unitario no válido.", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (L_EmisionPresupuesto.AgregarProductoAPresupuesto(
                idProductoSeleccionado, txtProducto.Text, txtCategoria.Text,
                txtMarca.Text, cantidad, precio))
            {
                
                LimpiarCamposProducto();

                btnCalcular.Enabled = true;
                if (idClienteSeleccionado > 0)
                {
                    btnConvertirPedido.Enabled = true;
                }

                CalcularYMostrarTotales();

                MessageBox.Show("Producto agregado al presupuesto.", "Éxito",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al agregar el producto.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCamposProducto()
        {
            txtProducto.Clear();
            txtCategoria.Clear();
            txtMarca.Clear();
            txtCantidad.Clear();
            txtPrecioUnitario.Clear();
            txtCantidad.ReadOnly = true;
            idProductoSeleccionado = 0;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularYMostrarTotales();
        }

        private void CalcularYMostrarTotales()
        {
            try
            {
                if (L_EmisionPresupuesto.ObtenerCantidadProductos() == 0)
                {
                    MessageBox.Show("Agregue productos al presupuesto primero.", "Validación",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataTable resultados = L_EmisionPresupuesto.CalcularTotalesConSP();

                if (resultados.Rows.Count > 0)
                {
                    DataRow fila = resultados.Rows[0];

                    decimal subtotal = Convert.ToDecimal(fila["SubTotal"]);
                    decimal total = Convert.ToDecimal(fila["Total"]);

                    txtSubtotal.Text = subtotal.ToString("N2");
                    txtTotal.Text = total.ToString("N2");

                    if (fila.Table.Columns.Contains("Descuento"))
                    {
                        decimal descuento = Convert.ToDecimal(fila["Descuento"]);
                        decimal porcentajeDescuento = Convert.ToDecimal(fila["PorcentajeDescuento"]);

                        if (descuento > 0)
                        {
                            string mensajeDetalles = $"Cálculo completado:\n" +
                                                   $"SubTotal: {subtotal:N2}\n" +
                                                   $"Descuento ({porcentajeDescuento}%): {descuento:N2}\n" +
                                                   $"Total: {total:N2}";

                            MessageBox.Show(mensajeDetalles, "Resultados",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Cálculo completado:\nSubTotal: {subtotal:N2}\nTotal: {total:N2}",
                                          "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se pudieron calcular los totales.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al calcular: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private Form CrearFormularioBusqueda(string tipo)
        {
            Form frm = new Form();
            frm.FormBorderStyle = FormBorderStyle.FixedDialog;
            frm.StartPosition = FormStartPosition.CenterParent;

            
            TextBox txtBuscar = new TextBox();
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Location = new Point(10, 10);
            txtBuscar.Size = new Size(200, 20);
            txtBuscar.Text = "";

            
            DataGridView dgv = new DataGridView();
            dgv.Name = "dgvBusqueda";
            dgv.Location = new Point(10, 40);
            dgv.Size = new Size(560, 280);
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ReadOnly = true;

            
            Button btnAceptar = new Button();
            btnAceptar.Text = "Aceptar";
            btnAceptar.Location = new Point(470, 330);
            btnAceptar.Size = new Size(100, 30);
            btnAceptar.DialogResult = DialogResult.OK;

            Button btnCancelar = new Button();
            btnCancelar.Text = "Cancelar";
            btnCancelar.Location = new Point(360, 330);
            btnCancelar.Size = new Size(100, 30);
            btnCancelar.DialogResult = DialogResult.Cancel;

            
            if (tipo == "cliente")
            {
                frm.Text = "Buscar Cliente";
                frm.Size = new Size(600, 400);
                ConfigurarGridClientes(dgv);

                
                txtBuscar.TextChanged += (s, ev) =>
                {
                    if (!string.IsNullOrEmpty(txtBuscar.Text))
                    {
                        dgv.DataSource = L_EmisionPresupuesto.BuscarClientes(txtBuscar.Text);
                    }
                };
            }
            else if (tipo == "producto")
            {
                frm.Text = "Buscar Producto";
                frm.Size = new Size(600, 400);
                ConfigurarGridProductos(dgv);

                
                txtBuscar.TextChanged += (s, ev) =>
                {
                    if (!string.IsNullOrEmpty(txtBuscar.Text))
                    {
                        dgv.DataSource = L_EmisionPresupuesto.BuscarProductos(txtBuscar.Text);
                    }
                };
            }

            dgv.CellDoubleClick += (s, ev) =>
            {
                if (ev.RowIndex >= 0)
                {
                    frm.DialogResult = DialogResult.OK;
                    frm.Close();
                }
            };

            
            frm.Controls.Add(txtBuscar); frm.Controls.Add(dgv); frm.Controls.Add(btnAceptar);
            frm.Controls.Add(btnCancelar); frm.AcceptButton = btnAceptar;frm.CancelButton = btnCancelar;

            return frm;
        }

        private void ConfigurarGridClientes(DataGridView dgv)
        {
            dgv.Columns.Clear();

            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.Name = "IdCliente";
            colId.HeaderText = "ID";
            colId.DataPropertyName = "IdCliente";
            colId.Width = 50;
            dgv.Columns.Add(colId);

            DataGridViewTextBoxColumn colRazon = new DataGridViewTextBoxColumn();
            colRazon.Name = "RazonSocial";
            colRazon.HeaderText = "Razón Social";
            colRazon.DataPropertyName = "RazonSocial";
            colRazon.Width = 250;
            dgv.Columns.Add(colRazon);

            DataGridViewTextBoxColumn colEmail = new DataGridViewTextBoxColumn();
            colEmail.Name = "Email";
            colEmail.HeaderText = "Email";
            colEmail.DataPropertyName = "Email";
            colEmail.Width = 200;
            dgv.Columns.Add(colEmail);
        }

        private void ConfigurarGridProductos(DataGridView dgv)
        {
            dgv.Columns.Clear();

            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.Name = "IdProducto";
            colId.HeaderText = "ID";
            colId.DataPropertyName = "IdProducto";
            colId.Width = 50;
            dgv.Columns.Add(colId);

            DataGridViewTextBoxColumn colCodigo = new DataGridViewTextBoxColumn();
            colCodigo.Name = "Codigo";
            colCodigo.HeaderText = "Código";
            colCodigo.DataPropertyName = "Codigo";
            colCodigo.Width = 80;
            dgv.Columns.Add(colCodigo);

            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.Name = "Nombre";
            colNombre.HeaderText = "Producto";
            colNombre.DataPropertyName = "Nombre";
            colNombre.Width = 200;
            dgv.Columns.Add(colNombre);

            DataGridViewTextBoxColumn colPrecio = new DataGridViewTextBoxColumn();
            colPrecio.Name = "PrecioVenta";
            colPrecio.HeaderText = "Precio";
            colPrecio.DataPropertyName = "PrecioVenta";
            colPrecio.Width = 80;
            colPrecio.DefaultCellStyle.Format = "N2";
            dgv.Columns.Add(colPrecio);

            DataGridViewTextBoxColumn colStock = new DataGridViewTextBoxColumn();
            colStock.Name = "StockActual";
            colStock.HeaderText = "Stock";
            colStock.DataPropertyName = "StockActual";
            colStock.Width = 70;
            colStock.DefaultCellStyle.Format = "N2";
            dgv.Columns.Add(colStock);
        }

        private void btnConvertirPedido_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (!L_EmisionPresupuesto.HayClienteSeleccionado())
                {
                    MessageBox.Show("Seleccione un cliente primero.", "Validación",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (L_EmisionPresupuesto.ObtenerCantidadProductos() == 0)
                {
                    MessageBox.Show("Agregue productos al presupuesto.", "Validación",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(txtTotal.Text) || !decimal.TryParse(txtTotal.Text, out decimal total) || total <= 0)
                {
                    MessageBox.Show("Calcule los totales primero.", "Validación",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("¿Convertir presupuesto a pedido?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("La funcionalidad para guardar el pedido se implementará después.", "Información",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConvertirPedido_Click_1(object sender, EventArgs e)
        {

        }
    }
}