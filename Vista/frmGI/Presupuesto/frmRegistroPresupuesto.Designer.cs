namespace Vista.frmGI.Presupuesto
{
    partial class frmRegistroPresupuesto
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.gbDatosCliente = new System.Windows.Forms.GroupBox();
            this.txtSaldoCliente = new System.Windows.Forms.TextBox();
            this.lblSaldoCliente = new System.Windows.Forms.Label();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.lblIDCliente = new System.Windows.Forms.Label();
            this.txtCategoriaCliente = new System.Windows.Forms.TextBox();
            this.lblCategoriaCliente = new System.Windows.Forms.Label();
            this.txtLimiteCredito = new System.Windows.Forms.TextBox();
            this.lblLimiteCredito = new System.Windows.Forms.Label();
            this.gbDatosSistema = new System.Windows.Forms.GroupBox();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.cmbListaPrecios = new System.Windows.Forms.ComboBox();
            this.lblListaPrecios = new System.Windows.Forms.Label();
            this.txtCanalVenta = new System.Windows.Forms.TextBox();
            this.lblCanalVenta = new System.Windows.Forms.Label();
            this.gbControlInterno = new System.Windows.Forms.GroupBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtUsuarioCreacion = new System.Windows.Forms.TextBox();
            this.lblUsuarioCreacion = new System.Windows.Forms.Label();
            this.txtFechaHoraCreacion = new System.Windows.Forms.TextBox();
            this.lblFechaHoraCreacion = new System.Windows.Forms.Label();
            this.txtIDPresupuesto = new System.Windows.Forms.TextBox();
            this.lblIDPresupuesto = new System.Windows.Forms.Label();
            this.pnlDetalle = new System.Windows.Forms.Panel();
            this.dgvDetalleRegistro = new System.Windows.Forms.DataGridView();
            this.colIDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCostoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMargen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeposito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlAuditoria = new System.Windows.Forms.Panel();
            this.gbAuditoria = new System.Windows.Forms.GroupBox();
            this.txtUsuarioModificacion = new System.Windows.Forms.TextBox();
            this.lblUsuarioModificacion = new System.Windows.Forms.Label();
            this.txtFechaHoraModificacion = new System.Windows.Forms.TextBox();
            this.lblFechaHoraModificacion = new System.Windows.Forms.Label();
            this.pnlResumen = new System.Windows.Forms.Panel();
            this.gbResumen = new System.Windows.Forms.GroupBox();
            this.txtMargenTotal = new System.Windows.Forms.TextBox();
            this.lblMargenTotal = new System.Windows.Forms.Label();
            this.txtCostoTotal = new System.Windows.Forms.TextBox();
            this.lblCostoTotal = new System.Windows.Forms.Label();
            this.txtCantidadItems = new System.Windows.Forms.TextBox();
            this.lblCantidadItems = new System.Windows.Forms.Label();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnAuditoriaCompleta = new System.Windows.Forms.Button();
            this.btnVerHistorialCliente = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.pnlCabecera.SuspendLayout();
            this.gbDatosCliente.SuspendLayout();
            this.gbDatosSistema.SuspendLayout();
            this.gbControlInterno.SuspendLayout();
            this.pnlDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleRegistro)).BeginInit();
            this.pnlAuditoria.SuspendLayout();
            this.gbAuditoria.SuspendLayout();
            this.pnlResumen.SuspendLayout();
            this.gbResumen.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.Controls.Add(this.gbDatosCliente);
            this.pnlCabecera.Controls.Add(this.gbDatosSistema);
            this.pnlCabecera.Controls.Add(this.gbControlInterno);
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(984, 150);
            this.pnlCabecera.TabIndex = 0;
            // 
            // gbDatosCliente
            // 
            this.gbDatosCliente.Controls.Add(this.txtSaldoCliente);
            this.gbDatosCliente.Controls.Add(this.lblSaldoCliente);
            this.gbDatosCliente.Controls.Add(this.txtIDCliente);
            this.gbDatosCliente.Controls.Add(this.lblIDCliente);
            this.gbDatosCliente.Controls.Add(this.txtCategoriaCliente);
            this.gbDatosCliente.Controls.Add(this.lblCategoriaCliente);
            this.gbDatosCliente.Controls.Add(this.txtLimiteCredito);
            this.gbDatosCliente.Controls.Add(this.lblLimiteCredito);
            this.gbDatosCliente.Location = new System.Drawing.Point(624, 12);
            this.gbDatosCliente.Name = "gbDatosCliente";
            this.gbDatosCliente.Size = new System.Drawing.Size(348, 125);
            this.gbDatosCliente.TabIndex = 2;
            this.gbDatosCliente.TabStop = false;
            this.gbDatosCliente.Text = "Datos del Cliente (Sistema)";
            // 
            // txtSaldoCliente
            // 
            this.txtSaldoCliente.Location = new System.Drawing.Point(120, 100);
            this.txtSaldoCliente.Name = "txtSaldoCliente";
            this.txtSaldoCliente.ReadOnly = true;
            this.txtSaldoCliente.Size = new System.Drawing.Size(120, 20);
            this.txtSaldoCliente.TabIndex = 7;
            this.txtSaldoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSaldoCliente
            // 
            this.lblSaldoCliente.AutoSize = true;
            this.lblSaldoCliente.Location = new System.Drawing.Point(16, 103);
            this.lblSaldoCliente.Name = "lblSaldoCliente";
            this.lblSaldoCliente.Size = new System.Drawing.Size(37, 13);
            this.lblSaldoCliente.TabIndex = 6;
            this.lblSaldoCliente.Text = "Saldo:";
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Location = new System.Drawing.Point(120, 25);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.ReadOnly = true;
            this.txtIDCliente.Size = new System.Drawing.Size(120, 20);
            this.txtIDCliente.TabIndex = 5;
            // 
            // lblIDCliente
            // 
            this.lblIDCliente.AutoSize = true;
            this.lblIDCliente.Location = new System.Drawing.Point(16, 28);
            this.lblIDCliente.Name = "lblIDCliente";
            this.lblIDCliente.Size = new System.Drawing.Size(56, 13);
            this.lblIDCliente.TabIndex = 4;
            this.lblIDCliente.Text = "ID Cliente:";
            // 
            // txtCategoriaCliente
            // 
            this.txtCategoriaCliente.Location = new System.Drawing.Point(120, 50);
            this.txtCategoriaCliente.Name = "txtCategoriaCliente";
            this.txtCategoriaCliente.ReadOnly = true;
            this.txtCategoriaCliente.Size = new System.Drawing.Size(120, 20);
            this.txtCategoriaCliente.TabIndex = 3;
            // 
            // lblCategoriaCliente
            // 
            this.lblCategoriaCliente.AutoSize = true;
            this.lblCategoriaCliente.Location = new System.Drawing.Point(16, 53);
            this.lblCategoriaCliente.Name = "lblCategoriaCliente";
            this.lblCategoriaCliente.Size = new System.Drawing.Size(57, 13);
            this.lblCategoriaCliente.TabIndex = 2;
            this.lblCategoriaCliente.Text = "Categoría:";
            // 
            // txtLimiteCredito
            // 
            this.txtLimiteCredito.Location = new System.Drawing.Point(120, 75);
            this.txtLimiteCredito.Name = "txtLimiteCredito";
            this.txtLimiteCredito.ReadOnly = true;
            this.txtLimiteCredito.Size = new System.Drawing.Size(120, 20);
            this.txtLimiteCredito.TabIndex = 1;
            this.txtLimiteCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblLimiteCredito
            // 
            this.lblLimiteCredito.AutoSize = true;
            this.lblLimiteCredito.Location = new System.Drawing.Point(16, 78);
            this.lblLimiteCredito.Name = "lblLimiteCredito";
            this.lblLimiteCredito.Size = new System.Drawing.Size(75, 13);
            this.lblLimiteCredito.TabIndex = 0;
            this.lblLimiteCredito.Text = "Límite Crédito:";
            // 
            // gbDatosSistema
            // 
            this.gbDatosSistema.Controls.Add(this.txtVendedor);
            this.gbDatosSistema.Controls.Add(this.lblVendedor);
            this.gbDatosSistema.Controls.Add(this.cmbListaPrecios);
            this.gbDatosSistema.Controls.Add(this.lblListaPrecios);
            this.gbDatosSistema.Controls.Add(this.txtCanalVenta);
            this.gbDatosSistema.Controls.Add(this.lblCanalVenta);
            this.gbDatosSistema.Location = new System.Drawing.Point(318, 12);
            this.gbDatosSistema.Name = "gbDatosSistema";
            this.gbDatosSistema.Size = new System.Drawing.Size(300, 125);
            this.gbDatosSistema.TabIndex = 1;
            this.gbDatosSistema.TabStop = false;
            this.gbDatosSistema.Text = "Datos del Sistema";
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(120, 75);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.ReadOnly = true;
            this.txtVendedor.Size = new System.Drawing.Size(120, 20);
            this.txtVendedor.TabIndex = 5;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(16, 78);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(56, 13);
            this.lblVendedor.TabIndex = 4;
            this.lblVendedor.Text = "Vendedor:";
            // 
            // cmbListaPrecios
            // 
            this.cmbListaPrecios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListaPrecios.FormattingEnabled = true;
            this.cmbListaPrecios.Items.AddRange(new object[] {
            "Lista General",
            "Lista Mayorista",
            "Lista Minorista",
            "Lista Promocional"});
            this.cmbListaPrecios.Location = new System.Drawing.Point(120, 50);
            this.cmbListaPrecios.Name = "cmbListaPrecios";
            this.cmbListaPrecios.Size = new System.Drawing.Size(120, 21);
            this.cmbListaPrecios.TabIndex = 3;
            // 
            // lblListaPrecios
            // 
            this.lblListaPrecios.AutoSize = true;
            this.lblListaPrecios.Location = new System.Drawing.Point(16, 53);
            this.lblListaPrecios.Name = "lblListaPrecios";
            this.lblListaPrecios.Size = new System.Drawing.Size(70, 13);
            this.lblListaPrecios.TabIndex = 2;
            this.lblListaPrecios.Text = "Lista Precios:";
            // 
            // txtCanalVenta
            // 
            this.txtCanalVenta.Location = new System.Drawing.Point(120, 25);
            this.txtCanalVenta.Name = "txtCanalVenta";
            this.txtCanalVenta.ReadOnly = true;
            this.txtCanalVenta.Size = new System.Drawing.Size(120, 20);
            this.txtCanalVenta.TabIndex = 1;
            this.txtCanalVenta.Text = "Mostrador";
            // 
            // lblCanalVenta
            // 
            this.lblCanalVenta.AutoSize = true;
            this.lblCanalVenta.Location = new System.Drawing.Point(16, 28);
            this.lblCanalVenta.Name = "lblCanalVenta";
            this.lblCanalVenta.Size = new System.Drawing.Size(68, 13);
            this.lblCanalVenta.TabIndex = 0;
            this.lblCanalVenta.Text = "Canal Venta:";
            // 
            // gbControlInterno
            // 
            this.gbControlInterno.Controls.Add(this.cmbEstado);
            this.gbControlInterno.Controls.Add(this.lblEstado);
            this.gbControlInterno.Controls.Add(this.txtUsuarioCreacion);
            this.gbControlInterno.Controls.Add(this.lblUsuarioCreacion);
            this.gbControlInterno.Controls.Add(this.txtFechaHoraCreacion);
            this.gbControlInterno.Controls.Add(this.lblFechaHoraCreacion);
            this.gbControlInterno.Controls.Add(this.txtIDPresupuesto);
            this.gbControlInterno.Controls.Add(this.lblIDPresupuesto);
            this.gbControlInterno.Location = new System.Drawing.Point(12, 12);
            this.gbControlInterno.Name = "gbControlInterno";
            this.gbControlInterno.Size = new System.Drawing.Size(300, 125);
            this.gbControlInterno.TabIndex = 0;
            this.gbControlInterno.TabStop = false;
            this.gbControlInterno.Text = "Control Interno";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Pendiente",
            "Aprobado",
            "Rechazado",
            "Convertido a Pedido",
            "Vencido"});
            this.cmbEstado.Location = new System.Drawing.Point(120, 100);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(120, 21);
            this.cmbEstado.TabIndex = 7;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(16, 103);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Estado:";
            // 
            // txtUsuarioCreacion
            // 
            this.txtUsuarioCreacion.Location = new System.Drawing.Point(120, 75);
            this.txtUsuarioCreacion.Name = "txtUsuarioCreacion";
            this.txtUsuarioCreacion.ReadOnly = true;
            this.txtUsuarioCreacion.Size = new System.Drawing.Size(120, 20);
            this.txtUsuarioCreacion.TabIndex = 5;
            // 
            // lblUsuarioCreacion
            // 
            this.lblUsuarioCreacion.AutoSize = true;
            this.lblUsuarioCreacion.Location = new System.Drawing.Point(16, 78);
            this.lblUsuarioCreacion.Name = "lblUsuarioCreacion";
            this.lblUsuarioCreacion.Size = new System.Drawing.Size(90, 13);
            this.lblUsuarioCreacion.TabIndex = 4;
            this.lblUsuarioCreacion.Text = "Usuario creación:";
            // 
            // txtFechaHoraCreacion
            // 
            this.txtFechaHoraCreacion.Location = new System.Drawing.Point(120, 50);
            this.txtFechaHoraCreacion.Name = "txtFechaHoraCreacion";
            this.txtFechaHoraCreacion.ReadOnly = true;
            this.txtFechaHoraCreacion.Size = new System.Drawing.Size(120, 20);
            this.txtFechaHoraCreacion.TabIndex = 3;
            // 
            // lblFechaHoraCreacion
            // 
            this.lblFechaHoraCreacion.AutoSize = true;
            this.lblFechaHoraCreacion.Location = new System.Drawing.Point(16, 53);
            this.lblFechaHoraCreacion.Name = "lblFechaHoraCreacion";
            this.lblFechaHoraCreacion.Size = new System.Drawing.Size(110, 13);
            this.lblFechaHoraCreacion.TabIndex = 2;
            this.lblFechaHoraCreacion.Text = "Fecha/hora creación:";
            // 
            // txtIDPresupuesto
            // 
            this.txtIDPresupuesto.Location = new System.Drawing.Point(120, 25);
            this.txtIDPresupuesto.Name = "txtIDPresupuesto";
            this.txtIDPresupuesto.ReadOnly = true;
            this.txtIDPresupuesto.Size = new System.Drawing.Size(120, 20);
            this.txtIDPresupuesto.TabIndex = 1;
            // 
            // lblIDPresupuesto
            // 
            this.lblIDPresupuesto.AutoSize = true;
            this.lblIDPresupuesto.Location = new System.Drawing.Point(16, 28);
            this.lblIDPresupuesto.Name = "lblIDPresupuesto";
            this.lblIDPresupuesto.Size = new System.Drawing.Size(21, 13);
            this.lblIDPresupuesto.TabIndex = 0;
            this.lblIDPresupuesto.Text = "ID:";
            // 
            // pnlDetalle
            // 
            this.pnlDetalle.Controls.Add(this.dgvDetalleRegistro);
            this.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetalle.Location = new System.Drawing.Point(0, 150);
            this.pnlDetalle.Name = "pnlDetalle";
            this.pnlDetalle.Size = new System.Drawing.Size(984, 351);
            this.pnlDetalle.TabIndex = 1;
            // 
            // dgvDetalleRegistro
            // 
            this.dgvDetalleRegistro.AllowUserToAddRows = false;
            this.dgvDetalleRegistro.AllowUserToDeleteRows = false;
            this.dgvDetalleRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDProducto,
            this.colCodigo,
            this.colDescripcion,
            this.colCantidad,
            this.colUnidad,
            this.colPrecioUnitario,
            this.colCostoUnitario,
            this.colMargen,
            this.colStockActual,
            this.colTipoStock,
            this.colDeposito});
            this.dgvDetalleRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalleRegistro.Location = new System.Drawing.Point(0, 0);
            this.dgvDetalleRegistro.Name = "dgvDetalleRegistro";
            this.dgvDetalleRegistro.ReadOnly = true;
            this.dgvDetalleRegistro.Size = new System.Drawing.Size(984, 351);
            this.dgvDetalleRegistro.TabIndex = 0;
            // 
            // colIDProducto
            // 
            this.colIDProducto.HeaderText = "ID Producto";
            this.colIDProducto.Name = "colIDProducto";
            this.colIDProducto.ReadOnly = true;
            this.colIDProducto.Visible = false;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.Width = 80;
            // 
            // colDescripcion
            // 
            this.colDescripcion.HeaderText = "Descripción";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            this.colDescripcion.Width = 200;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 70;
            // 
            // colUnidad
            // 
            this.colUnidad.HeaderText = "Unidad";
            this.colUnidad.Name = "colUnidad";
            this.colUnidad.ReadOnly = true;
            this.colUnidad.Width = 60;
            // 
            // colPrecioUnitario
            // 
            this.colPrecioUnitario.HeaderText = "Precio Unitario";
            this.colPrecioUnitario.Name = "colPrecioUnitario";
            this.colPrecioUnitario.ReadOnly = true;
            // 
            // colCostoUnitario
            // 
            this.colCostoUnitario.HeaderText = "Costo Unitario";
            this.colCostoUnitario.Name = "colCostoUnitario";
            this.colCostoUnitario.ReadOnly = true;
            // 
            // colMargen
            // 
            this.colMargen.HeaderText = "Margen %";
            this.colMargen.Name = "colMargen";
            this.colMargen.ReadOnly = true;
            this.colMargen.Width = 80;
            // 
            // colStockActual
            // 
            this.colStockActual.HeaderText = "Stock Actual";
            this.colStockActual.Name = "colStockActual";
            this.colStockActual.ReadOnly = true;
            this.colStockActual.Width = 80;
            // 
            // colTipoStock
            // 
            this.colTipoStock.HeaderText = "Tipo Stock";
            this.colTipoStock.Name = "colTipoStock";
            this.colTipoStock.ReadOnly = true;
            this.colTipoStock.Width = 80;
            // 
            // colDeposito
            // 
            this.colDeposito.HeaderText = "Depósito";
            this.colDeposito.Name = "colDeposito";
            this.colDeposito.ReadOnly = true;
            this.colDeposito.Width = 80;
            // 
            // pnlAuditoria
            // 
            this.pnlAuditoria.Controls.Add(this.gbAuditoria);
            this.pnlAuditoria.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAuditoria.Location = new System.Drawing.Point(0, 501);
            this.pnlAuditoria.Name = "pnlAuditoria";
            this.pnlAuditoria.Size = new System.Drawing.Size(984, 60);
            this.pnlAuditoria.TabIndex = 2;
            // 
            // gbAuditoria
            // 
            this.gbAuditoria.Controls.Add(this.txtUsuarioModificacion);
            this.gbAuditoria.Controls.Add(this.lblUsuarioModificacion);
            this.gbAuditoria.Controls.Add(this.txtFechaHoraModificacion);
            this.gbAuditoria.Controls.Add(this.lblFechaHoraModificacion);
            this.gbAuditoria.Location = new System.Drawing.Point(12, 10);
            this.gbAuditoria.Name = "gbAuditoria";
            this.gbAuditoria.Size = new System.Drawing.Size(400, 40);
            this.gbAuditoria.TabIndex = 0;
            this.gbAuditoria.TabStop = false;
            this.gbAuditoria.Text = "Auditoría";
            // 
            // txtUsuarioModificacion
            // 
            this.txtUsuarioModificacion.Location = new System.Drawing.Point(280, 15);
            this.txtUsuarioModificacion.Name = "txtUsuarioModificacion";
            this.txtUsuarioModificacion.ReadOnly = true;
            this.txtUsuarioModificacion.Size = new System.Drawing.Size(100, 20);
            this.txtUsuarioModificacion.TabIndex = 3;
            // 
            // lblUsuarioModificacion
            // 
            this.lblUsuarioModificacion.AutoSize = true;
            this.lblUsuarioModificacion.Location = new System.Drawing.Point(200, 18);
            this.lblUsuarioModificacion.Name = "lblUsuarioModificacion";
            this.lblUsuarioModificacion.Size = new System.Drawing.Size(76, 13);
            this.lblUsuarioModificacion.TabIndex = 2;
            this.lblUsuarioModificacion.Text = "Último usuario:";
            // 
            // txtFechaHoraModificacion
            // 
            this.txtFechaHoraModificacion.Location = new System.Drawing.Point(90, 15);
            this.txtFechaHoraModificacion.Name = "txtFechaHoraModificacion";
            this.txtFechaHoraModificacion.ReadOnly = true;
            this.txtFechaHoraModificacion.Size = new System.Drawing.Size(100, 20);
            this.txtFechaHoraModificacion.TabIndex = 1;
            // 
            // lblFechaHoraModificacion
            // 
            this.lblFechaHoraModificacion.AutoSize = true;
            this.lblFechaHoraModificacion.Location = new System.Drawing.Point(16, 18);
            this.lblFechaHoraModificacion.Name = "lblFechaHoraModificacion";
            this.lblFechaHoraModificacion.Size = new System.Drawing.Size(67, 13);
            this.lblFechaHoraModificacion.TabIndex = 0;
            this.lblFechaHoraModificacion.Text = "Última modif:";
            // 
            // pnlResumen
            // 
            this.pnlResumen.Controls.Add(this.gbResumen);
            this.pnlResumen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlResumen.Location = new System.Drawing.Point(0, 561);
            this.pnlResumen.Name = "pnlResumen";
            this.pnlResumen.Size = new System.Drawing.Size(984, 70);
            this.pnlResumen.TabIndex = 3;
            // 
            // gbResumen
            // 
            this.gbResumen.Controls.Add(this.txtMargenTotal);
            this.gbResumen.Controls.Add(this.lblMargenTotal);
            this.gbResumen.Controls.Add(this.txtCostoTotal);
            this.gbResumen.Controls.Add(this.lblCostoTotal);
            this.gbResumen.Controls.Add(this.txtCantidadItems);
            this.gbResumen.Controls.Add(this.lblCantidadItems);
            this.gbResumen.Location = new System.Drawing.Point(500, 10);
            this.gbResumen.Name = "gbResumen";
            this.gbResumen.Size = new System.Drawing.Size(472, 50);
            this.gbResumen.TabIndex = 0;
            this.gbResumen.TabStop = false;
            this.gbResumen.Text = "Resumen Interno";
            // 
            // txtMargenTotal
            // 
            this.txtMargenTotal.Location = new System.Drawing.Point(370, 20);
            this.txtMargenTotal.Name = "txtMargenTotal";
            this.txtMargenTotal.ReadOnly = true;
            this.txtMargenTotal.Size = new System.Drawing.Size(80, 20);
            this.txtMargenTotal.TabIndex = 5;
            this.txtMargenTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMargenTotal
            // 
            this.lblMargenTotal.AutoSize = true;
            this.lblMargenTotal.Location = new System.Drawing.Point(320, 23);
            this.lblMargenTotal.Name = "lblMargenTotal";
            this.lblMargenTotal.Size = new System.Drawing.Size(46, 13);
            this.lblMargenTotal.TabIndex = 4;
            this.lblMargenTotal.Text = "Margen:";
            // 
            // txtCostoTotal
            // 
            this.txtCostoTotal.Location = new System.Drawing.Point(220, 20);
            this.txtCostoTotal.Name = "txtCostoTotal";
            this.txtCostoTotal.ReadOnly = true;
            this.txtCostoTotal.Size = new System.Drawing.Size(80, 20);
            this.txtCostoTotal.TabIndex = 3;
            this.txtCostoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCostoTotal
            // 
            this.lblCostoTotal.AutoSize = true;
            this.lblCostoTotal.Location = new System.Drawing.Point(180, 23);
            this.lblCostoTotal.Name = "lblCostoTotal";
            this.lblCostoTotal.Size = new System.Drawing.Size(37, 13);
            this.lblCostoTotal.TabIndex = 2;
            this.lblCostoTotal.Text = "Costo:";
            // 
            // txtCantidadItems
            // 
            this.txtCantidadItems.Location = new System.Drawing.Point(80, 20);
            this.txtCantidadItems.Name = "txtCantidadItems";
            this.txtCantidadItems.ReadOnly = true;
            this.txtCantidadItems.Size = new System.Drawing.Size(80, 20);
            this.txtCantidadItems.TabIndex = 1;
            this.txtCantidadItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCantidadItems
            // 
            this.lblCantidadItems.AutoSize = true;
            this.lblCantidadItems.Location = new System.Drawing.Point(20, 23);
            this.lblCantidadItems.Name = "lblCantidadItems";
            this.lblCantidadItems.Size = new System.Drawing.Size(35, 13);
            this.lblCantidadItems.TabIndex = 0;
            this.lblCantidadItems.Text = "Items:";
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnAuditoriaCompleta);
            this.pnlBotones.Controls.Add(this.btnVerHistorialCliente);
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Controls.Add(this.btnConfirmar);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotones.Location = new System.Drawing.Point(0, 631);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(984, 50);
            this.pnlBotones.TabIndex = 4;
            // 
            // btnAuditoriaCompleta
            // 
            this.btnAuditoriaCompleta.Location = new System.Drawing.Point(32, 15);
            this.btnAuditoriaCompleta.Name = "btnAuditoriaCompleta";
            this.btnAuditoriaCompleta.Size = new System.Drawing.Size(100, 23);
            this.btnAuditoriaCompleta.TabIndex = 3;
            this.btnAuditoriaCompleta.Text = "Auditoría Completa";
            this.btnAuditoriaCompleta.UseVisualStyleBackColor = true;
            // 
            // btnVerHistorialCliente
            // 
            this.btnVerHistorialCliente.Location = new System.Drawing.Point(138, 15);
            this.btnVerHistorialCliente.Name = "btnVerHistorialCliente";
            this.btnVerHistorialCliente.Size = new System.Drawing.Size(120, 23);
            this.btnVerHistorialCliente.TabIndex = 2;
            this.btnVerHistorialCliente.Text = "Ver Historial Cliente";
            this.btnVerHistorialCliente.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(885, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(804, 15);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // frmRegistroPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 681);
            this.Controls.Add(this.pnlDetalle);
            this.Controls.Add(this.pnlAuditoria);
            this.Controls.Add(this.pnlResumen);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlCabecera);
            this.Name = "frmRegistroPresupuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro - Presupuesto de Venta";
            this.pnlCabecera.ResumeLayout(false);
            this.gbDatosCliente.ResumeLayout(false);
            this.gbDatosCliente.PerformLayout();
            this.gbDatosSistema.ResumeLayout(false);
            this.gbDatosSistema.PerformLayout();
            this.gbControlInterno.ResumeLayout(false);
            this.gbControlInterno.PerformLayout();
            this.pnlDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleRegistro)).EndInit();
            this.pnlAuditoria.ResumeLayout(false);
            this.gbAuditoria.ResumeLayout(false);
            this.gbAuditoria.PerformLayout();
            this.pnlResumen.ResumeLayout(false);
            this.gbResumen.ResumeLayout(false);
            this.gbResumen.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.GroupBox gbControlInterno;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtUsuarioCreacion;
        private System.Windows.Forms.Label lblUsuarioCreacion;
        private System.Windows.Forms.TextBox txtFechaHoraCreacion;
        private System.Windows.Forms.Label lblFechaHoraCreacion;
        private System.Windows.Forms.TextBox txtIDPresupuesto;
        private System.Windows.Forms.Label lblIDPresupuesto;
        private System.Windows.Forms.GroupBox gbDatosSistema;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.ComboBox cmbListaPrecios;
        private System.Windows.Forms.Label lblListaPrecios;
        private System.Windows.Forms.TextBox txtCanalVenta;
        private System.Windows.Forms.Label lblCanalVenta;
        private System.Windows.Forms.GroupBox gbDatosCliente;
        private System.Windows.Forms.TextBox txtSaldoCliente;
        private System.Windows.Forms.Label lblSaldoCliente;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.Label lblIDCliente;
        private System.Windows.Forms.TextBox txtCategoriaCliente;
        private System.Windows.Forms.Label lblCategoriaCliente;
        private System.Windows.Forms.TextBox txtLimiteCredito;
        private System.Windows.Forms.Label lblLimiteCredito;
        private System.Windows.Forms.Panel pnlDetalle;
        private System.Windows.Forms.DataGridView dgvDetalleRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCostoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMargen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeposito;
        private System.Windows.Forms.Panel pnlAuditoria;
        private System.Windows.Forms.GroupBox gbAuditoria;
        private System.Windows.Forms.TextBox txtUsuarioModificacion;
        private System.Windows.Forms.Label lblUsuarioModificacion;
        private System.Windows.Forms.TextBox txtFechaHoraModificacion;
        private System.Windows.Forms.Label lblFechaHoraModificacion;
        private System.Windows.Forms.Panel pnlResumen;
        private System.Windows.Forms.GroupBox gbResumen;
        private System.Windows.Forms.TextBox txtMargenTotal;
        private System.Windows.Forms.Label lblMargenTotal;
        private System.Windows.Forms.TextBox txtCostoTotal;
        private System.Windows.Forms.Label lblCostoTotal;
        private System.Windows.Forms.TextBox txtCantidadItems;
        private System.Windows.Forms.Label lblCantidadItems;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnAuditoriaCompleta;
        private System.Windows.Forms.Button btnVerHistorialCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
    }
}