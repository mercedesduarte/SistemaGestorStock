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
            this.gbControlInterno = new System.Windows.Forms.GroupBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtUsuarioCreacion = new System.Windows.Forms.TextBox();
            this.lblUsuarioCreacion = new System.Windows.Forms.Label();
            this.txtFechaHoraCreacion = new System.Windows.Forms.TextBox();
            this.lblFechaHoraCreacion = new System.Windows.Forms.Label();
            this.txtIDPresupuesto = new System.Windows.Forms.TextBox();
            this.lblIDPresupuesto = new System.Windows.Forms.Label();
            this.gbDatosSistema = new System.Windows.Forms.GroupBox();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.cmbListaPrecios = new System.Windows.Forms.ComboBox();
            this.lblListaPrecios = new System.Windows.Forms.Label();
            this.gbDatosCliente = new System.Windows.Forms.GroupBox();
            this.txtSaldoCliente = new System.Windows.Forms.TextBox();
            this.lblSaldoCliente = new System.Windows.Forms.Label();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.lblIDCliente = new System.Windows.Forms.Label();
            this.txtCategoriaCliente = new System.Windows.Forms.TextBox();
            this.lblCategoriaCliente = new System.Windows.Forms.Label();
            this.txtLimiteCredito = new System.Windows.Forms.TextBox();
            this.lblLimiteCredito = new System.Windows.Forms.Label();
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
            this.pnlResumen = new System.Windows.Forms.Panel();
            this.gbResumen = new System.Windows.Forms.GroupBox();
            this.txtMargenTotal = new System.Windows.Forms.TextBox();
            this.lblMargenTotal = new System.Windows.Forms.Label();
            this.txtCostoTotal = new System.Windows.Forms.TextBox();
            this.lblCostoTotal = new System.Windows.Forms.Label();
            this.txtCantidadItems = new System.Windows.Forms.TextBox();
            this.lblCantidadItems = new System.Windows.Forms.Label();
            this.pnlAuditoria = new System.Windows.Forms.Panel();
            this.gbAuditoria = new System.Windows.Forms.GroupBox();
            this.txtUsuarioModificacion = new System.Windows.Forms.TextBox();
            this.lblUsuarioModificacion = new System.Windows.Forms.Label();
            this.txtFechaHoraModificacion = new System.Windows.Forms.TextBox();
            this.lblFechaHoraModificacion = new System.Windows.Forms.Label();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnAuditoriaCompleta = new System.Windows.Forms.Button();
            this.btnVerHistorialCliente = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbControlInterno.SuspendLayout();
            this.gbDatosSistema.SuspendLayout();
            this.gbDatosCliente.SuspendLayout();
            this.pnlDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleRegistro)).BeginInit();
            this.pnlResumen.SuspendLayout();
            this.gbResumen.SuspendLayout();
            this.pnlAuditoria.SuspendLayout();
            this.gbAuditoria.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
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
            this.gbControlInterno.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbControlInterno.Location = new System.Drawing.Point(20, 80);
            this.gbControlInterno.Name = "gbControlInterno";
            this.gbControlInterno.Size = new System.Drawing.Size(450, 180);
            this.gbControlInterno.TabIndex = 1;
            this.gbControlInterno.TabStop = false;
            this.gbControlInterno.Text = "CONTROL INTERNO";
            // 
            // cmbEstado
            // 
            this.cmbEstado.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Pendiente",
            "Aprobado",
            "Rechazado",
            "Convertido a Pedido",
            "Vencido"});
            this.cmbEstado.Location = new System.Drawing.Point(140, 120);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(200, 27);
            this.cmbEstado.TabIndex = 7;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(20, 123);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(72, 19);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Estado:";
            // 
            // txtUsuarioCreacion
            // 
            this.txtUsuarioCreacion.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioCreacion.Location = new System.Drawing.Point(140, 90);
            this.txtUsuarioCreacion.Name = "txtUsuarioCreacion";
            this.txtUsuarioCreacion.ReadOnly = true;
            this.txtUsuarioCreacion.Size = new System.Drawing.Size(200, 26);
            this.txtUsuarioCreacion.TabIndex = 5;
            // 
            // lblUsuarioCreacion
            // 
            this.lblUsuarioCreacion.AutoSize = true;
            this.lblUsuarioCreacion.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioCreacion.Location = new System.Drawing.Point(20, 93);
            this.lblUsuarioCreacion.Name = "lblUsuarioCreacion";
            this.lblUsuarioCreacion.Size = new System.Drawing.Size(117, 19);
            this.lblUsuarioCreacion.TabIndex = 4;
            this.lblUsuarioCreacion.Text = "Usuario Crea:";
            // 
            // txtFechaHoraCreacion
            // 
            this.txtFechaHoraCreacion.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaHoraCreacion.Location = new System.Drawing.Point(140, 60);
            this.txtFechaHoraCreacion.Name = "txtFechaHoraCreacion";
            this.txtFechaHoraCreacion.ReadOnly = true;
            this.txtFechaHoraCreacion.Size = new System.Drawing.Size(200, 26);
            this.txtFechaHoraCreacion.TabIndex = 3;
            // 
            // lblFechaHoraCreacion
            // 
            this.lblFechaHoraCreacion.AutoSize = true;
            this.lblFechaHoraCreacion.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHoraCreacion.Location = new System.Drawing.Point(20, 63);
            this.lblFechaHoraCreacion.Name = "lblFechaHoraCreacion";
            this.lblFechaHoraCreacion.Size = new System.Drawing.Size(108, 19);
            this.lblFechaHoraCreacion.TabIndex = 2;
            this.lblFechaHoraCreacion.Text = "Fecha/Hora:";
            // 
            // txtIDPresupuesto
            // 
            this.txtIDPresupuesto.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDPresupuesto.Location = new System.Drawing.Point(140, 30);
            this.txtIDPresupuesto.Name = "txtIDPresupuesto";
            this.txtIDPresupuesto.ReadOnly = true;
            this.txtIDPresupuesto.Size = new System.Drawing.Size(200, 26);
            this.txtIDPresupuesto.TabIndex = 1;
            // 
            // lblIDPresupuesto
            // 
            this.lblIDPresupuesto.AutoSize = true;
            this.lblIDPresupuesto.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDPresupuesto.Location = new System.Drawing.Point(20, 33);
            this.lblIDPresupuesto.Name = "lblIDPresupuesto";
            this.lblIDPresupuesto.Size = new System.Drawing.Size(36, 19);
            this.lblIDPresupuesto.TabIndex = 0;
            this.lblIDPresupuesto.Text = "ID:";
            // 
            // gbDatosSistema
            // 
            this.gbDatosSistema.Controls.Add(this.txtVendedor);
            this.gbDatosSistema.Controls.Add(this.lblVendedor);
            this.gbDatosSistema.Controls.Add(this.cmbListaPrecios);
            this.gbDatosSistema.Controls.Add(this.lblListaPrecios);
            this.gbDatosSistema.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosSistema.Location = new System.Drawing.Point(500, 80);
            this.gbDatosSistema.Name = "gbDatosSistema";
            this.gbDatosSistema.Size = new System.Drawing.Size(450, 180);
            this.gbDatosSistema.TabIndex = 2;
            this.gbDatosSistema.TabStop = false;
            this.gbDatosSistema.Text = "DATOS DEL SISTEMA";
            // 
            // txtVendedor
            // 
            this.txtVendedor.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendedor.Location = new System.Drawing.Point(140, 60);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.ReadOnly = true;
            this.txtVendedor.Size = new System.Drawing.Size(280, 26);
            this.txtVendedor.TabIndex = 5;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.Location = new System.Drawing.Point(20, 63);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(90, 19);
            this.lblVendedor.TabIndex = 4;
            this.lblVendedor.Text = "Vendedor:";
            // 
            // cmbListaPrecios
            // 
            this.cmbListaPrecios.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbListaPrecios.FormattingEnabled = true;
            this.cmbListaPrecios.Items.AddRange(new object[] {
            "Lista General",
            "Lista Mayorista",
            "Lista Minorista",
            "Lista Promocional"});
            this.cmbListaPrecios.Location = new System.Drawing.Point(140, 30);
            this.cmbListaPrecios.Name = "cmbListaPrecios";
            this.cmbListaPrecios.Size = new System.Drawing.Size(200, 27);
            this.cmbListaPrecios.TabIndex = 3;
            // 
            // lblListaPrecios
            // 
            this.lblListaPrecios.AutoSize = true;
            this.lblListaPrecios.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaPrecios.Location = new System.Drawing.Point(20, 33);
            this.lblListaPrecios.Name = "lblListaPrecios";
            this.lblListaPrecios.Size = new System.Drawing.Size(99, 19);
            this.lblListaPrecios.TabIndex = 2;
            this.lblListaPrecios.Text = "Lista Precio:";
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
            this.gbDatosCliente.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosCliente.Location = new System.Drawing.Point(20, 280);
            this.gbDatosCliente.Name = "gbDatosCliente";
            this.gbDatosCliente.Size = new System.Drawing.Size(450, 180);
            this.gbDatosCliente.TabIndex = 3;
            this.gbDatosCliente.TabStop = false;
            this.gbDatosCliente.Text = "DATOS DEL CLIENTE (SISTEMA)";
            // 
            // txtSaldoCliente
            // 
            this.txtSaldoCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoCliente.Location = new System.Drawing.Point(140, 120);
            this.txtSaldoCliente.Name = "txtSaldoCliente";
            this.txtSaldoCliente.ReadOnly = true;
            this.txtSaldoCliente.Size = new System.Drawing.Size(200, 26);
            this.txtSaldoCliente.TabIndex = 7;
            this.txtSaldoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSaldoCliente
            // 
            this.lblSaldoCliente.AutoSize = true;
            this.lblSaldoCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoCliente.Location = new System.Drawing.Point(20, 123);
            this.lblSaldoCliente.Name = "lblSaldoCliente";
            this.lblSaldoCliente.Size = new System.Drawing.Size(63, 19);
            this.lblSaldoCliente.TabIndex = 6;
            this.lblSaldoCliente.Text = "Saldo:";
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCliente.Location = new System.Drawing.Point(140, 30);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.ReadOnly = true;
            this.txtIDCliente.Size = new System.Drawing.Size(200, 26);
            this.txtIDCliente.TabIndex = 5;
            // 
            // lblIDCliente
            // 
            this.lblIDCliente.AutoSize = true;
            this.lblIDCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCliente.Location = new System.Drawing.Point(20, 33);
            this.lblIDCliente.Name = "lblIDCliente";
            this.lblIDCliente.Size = new System.Drawing.Size(90, 19);
            this.lblIDCliente.TabIndex = 4;
            this.lblIDCliente.Text = "ID Cliente:";
            // 
            // txtCategoriaCliente
            // 
            this.txtCategoriaCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoriaCliente.Location = new System.Drawing.Point(140, 60);
            this.txtCategoriaCliente.Name = "txtCategoriaCliente";
            this.txtCategoriaCliente.ReadOnly = true;
            this.txtCategoriaCliente.Size = new System.Drawing.Size(200, 26);
            this.txtCategoriaCliente.TabIndex = 3;
            // 
            // lblCategoriaCliente
            // 
            this.lblCategoriaCliente.AutoSize = true;
            this.lblCategoriaCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaCliente.Location = new System.Drawing.Point(20, 63);
            this.lblCategoriaCliente.Name = "lblCategoriaCliente";
            this.lblCategoriaCliente.Size = new System.Drawing.Size(99, 19);
            this.lblCategoriaCliente.TabIndex = 2;
            this.lblCategoriaCliente.Text = "Categoría:";
            // 
            // txtLimiteCredito
            // 
            this.txtLimiteCredito.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLimiteCredito.Location = new System.Drawing.Point(140, 90);
            this.txtLimiteCredito.Name = "txtLimiteCredito";
            this.txtLimiteCredito.ReadOnly = true;
            this.txtLimiteCredito.Size = new System.Drawing.Size(200, 26);
            this.txtLimiteCredito.TabIndex = 1;
            this.txtLimiteCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblLimiteCredito
            // 
            this.lblLimiteCredito.AutoSize = true;
            this.lblLimiteCredito.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimiteCredito.Location = new System.Drawing.Point(20, 93);
            this.lblLimiteCredito.Name = "lblLimiteCredito";
            this.lblLimiteCredito.Size = new System.Drawing.Size(108, 19);
            this.lblLimiteCredito.TabIndex = 0;
            this.lblLimiteCredito.Text = "Límite Cred.:";
            // 
            // pnlDetalle
            // 
            this.pnlDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDetalle.Controls.Add(this.dgvDetalleRegistro);
            this.pnlDetalle.Location = new System.Drawing.Point(500, 280);
            this.pnlDetalle.Name = "pnlDetalle";
            this.pnlDetalle.Size = new System.Drawing.Size(450, 238);
            this.pnlDetalle.TabIndex = 4;
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
            this.dgvDetalleRegistro.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetalleRegistro.Location = new System.Drawing.Point(0, 0);
            this.dgvDetalleRegistro.Name = "dgvDetalleRegistro";
            this.dgvDetalleRegistro.ReadOnly = true;
            this.dgvDetalleRegistro.Size = new System.Drawing.Size(450, 238);
            this.dgvDetalleRegistro.TabIndex = 0;
            // 
            // colIDProducto
            // 
            this.colIDProducto.HeaderText = "ID PRODUCTO";
            this.colIDProducto.Name = "colIDProducto";
            this.colIDProducto.ReadOnly = true;
            this.colIDProducto.Visible = false;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "CÓDIGO";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.Width = 80;
            // 
            // colDescripcion
            // 
            this.colDescripcion.HeaderText = "DESCRIPCIÓN";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            this.colDescripcion.Width = 200;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "CANTIDAD";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 80;
            // 
            // colUnidad
            // 
            this.colUnidad.HeaderText = "UNIDAD";
            this.colUnidad.Name = "colUnidad";
            this.colUnidad.ReadOnly = true;
            this.colUnidad.Width = 70;
            // 
            // colPrecioUnitario
            // 
            this.colPrecioUnitario.HeaderText = "PRECIO UNIT.";
            this.colPrecioUnitario.Name = "colPrecioUnitario";
            this.colPrecioUnitario.ReadOnly = true;
            this.colPrecioUnitario.Width = 120;
            // 
            // colCostoUnitario
            // 
            this.colCostoUnitario.HeaderText = "COSTO UNIT.";
            this.colCostoUnitario.Name = "colCostoUnitario";
            this.colCostoUnitario.ReadOnly = true;
            this.colCostoUnitario.Width = 120;
            // 
            // colMargen
            // 
            this.colMargen.HeaderText = "MARGEN %";
            this.colMargen.Name = "colMargen";
            this.colMargen.ReadOnly = true;
            this.colMargen.Width = 100;
            // 
            // colStockActual
            // 
            this.colStockActual.HeaderText = "STOCK";
            this.colStockActual.Name = "colStockActual";
            this.colStockActual.ReadOnly = true;
            this.colStockActual.Width = 80;
            // 
            // colTipoStock
            // 
            this.colTipoStock.HeaderText = "TIPO STOCK";
            this.colTipoStock.Name = "colTipoStock";
            this.colTipoStock.ReadOnly = true;
            this.colTipoStock.Width = 120;
            // 
            // colDeposito
            // 
            this.colDeposito.HeaderText = "DEPÓSITO";
            this.colDeposito.Name = "colDeposito";
            this.colDeposito.ReadOnly = true;
            this.colDeposito.Width = 100;
            // 
            // pnlResumen
            // 
            this.pnlResumen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlResumen.Controls.Add(this.gbResumen);
            this.pnlResumen.Location = new System.Drawing.Point(20, 538);
            this.pnlResumen.Name = "pnlResumen";
            this.pnlResumen.Size = new System.Drawing.Size(450, 100);
            this.pnlResumen.TabIndex = 5;
            // 
            // gbResumen
            // 
            this.gbResumen.Controls.Add(this.txtMargenTotal);
            this.gbResumen.Controls.Add(this.lblMargenTotal);
            this.gbResumen.Controls.Add(this.txtCostoTotal);
            this.gbResumen.Controls.Add(this.lblCostoTotal);
            this.gbResumen.Controls.Add(this.txtCantidadItems);
            this.gbResumen.Controls.Add(this.lblCantidadItems);
            this.gbResumen.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResumen.Location = new System.Drawing.Point(0, 10);
            this.gbResumen.Name = "gbResumen";
            this.gbResumen.Size = new System.Drawing.Size(450, 80);
            this.gbResumen.TabIndex = 0;
            this.gbResumen.TabStop = false;
            this.gbResumen.Text = "RESUMEN INTERNO";
            // 
            // txtMargenTotal
            // 
            this.txtMargenTotal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMargenTotal.Location = new System.Drawing.Point(320, 45);
            this.txtMargenTotal.Name = "txtMargenTotal";
            this.txtMargenTotal.ReadOnly = true;
            this.txtMargenTotal.Size = new System.Drawing.Size(120, 26);
            this.txtMargenTotal.TabIndex = 5;
            this.txtMargenTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMargenTotal
            // 
            this.lblMargenTotal.AutoSize = true;
            this.lblMargenTotal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMargenTotal.Location = new System.Drawing.Point(320, 25);
            this.lblMargenTotal.Name = "lblMargenTotal";
            this.lblMargenTotal.Size = new System.Drawing.Size(81, 19);
            this.lblMargenTotal.TabIndex = 4;
            this.lblMargenTotal.Text = "MARGEN";
            // 
            // txtCostoTotal
            // 
            this.txtCostoTotal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoTotal.Location = new System.Drawing.Point(170, 45);
            this.txtCostoTotal.Name = "txtCostoTotal";
            this.txtCostoTotal.ReadOnly = true;
            this.txtCostoTotal.Size = new System.Drawing.Size(120, 26);
            this.txtCostoTotal.TabIndex = 3;
            this.txtCostoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCostoTotal
            // 
            this.lblCostoTotal.AutoSize = true;
            this.lblCostoTotal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoTotal.Location = new System.Drawing.Point(170, 25);
            this.lblCostoTotal.Name = "lblCostoTotal";
            this.lblCostoTotal.Size = new System.Drawing.Size(63, 19);
            this.lblCostoTotal.TabIndex = 2;
            this.lblCostoTotal.Text = "COSTO";
            // 
            // txtCantidadItems
            // 
            this.txtCantidadItems.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadItems.Location = new System.Drawing.Point(20, 45);
            this.txtCantidadItems.Name = "txtCantidadItems";
            this.txtCantidadItems.ReadOnly = true;
            this.txtCantidadItems.Size = new System.Drawing.Size(120, 26);
            this.txtCantidadItems.TabIndex = 1;
            this.txtCantidadItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCantidadItems
            // 
            this.lblCantidadItems.AutoSize = true;
            this.lblCantidadItems.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadItems.Location = new System.Drawing.Point(20, 25);
            this.lblCantidadItems.Name = "lblCantidadItems";
            this.lblCantidadItems.Size = new System.Drawing.Size(63, 19);
            this.lblCantidadItems.TabIndex = 0;
            this.lblCantidadItems.Text = "ITEMS";
            // 
            // pnlAuditoria
            // 
            this.pnlAuditoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAuditoria.Controls.Add(this.gbAuditoria);
            this.pnlAuditoria.Location = new System.Drawing.Point(500, 538);
            this.pnlAuditoria.Name = "pnlAuditoria";
            this.pnlAuditoria.Size = new System.Drawing.Size(450, 100);
            this.pnlAuditoria.TabIndex = 6;
            // 
            // gbAuditoria
            // 
            this.gbAuditoria.Controls.Add(this.txtUsuarioModificacion);
            this.gbAuditoria.Controls.Add(this.lblUsuarioModificacion);
            this.gbAuditoria.Controls.Add(this.txtFechaHoraModificacion);
            this.gbAuditoria.Controls.Add(this.lblFechaHoraModificacion);
            this.gbAuditoria.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAuditoria.Location = new System.Drawing.Point(0, 10);
            this.gbAuditoria.Name = "gbAuditoria";
            this.gbAuditoria.Size = new System.Drawing.Size(450, 80);
            this.gbAuditoria.TabIndex = 0;
            this.gbAuditoria.TabStop = false;
            this.gbAuditoria.Text = "AUDITORÍA";
            // 
            // txtUsuarioModificacion
            // 
            this.txtUsuarioModificacion.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioModificacion.Location = new System.Drawing.Point(280, 45);
            this.txtUsuarioModificacion.Name = "txtUsuarioModificacion";
            this.txtUsuarioModificacion.ReadOnly = true;
            this.txtUsuarioModificacion.Size = new System.Drawing.Size(150, 26);
            this.txtUsuarioModificacion.TabIndex = 3;
            // 
            // lblUsuarioModificacion
            // 
            this.lblUsuarioModificacion.AutoSize = true;
            this.lblUsuarioModificacion.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioModificacion.Location = new System.Drawing.Point(280, 25);
            this.lblUsuarioModificacion.Name = "lblUsuarioModificacion";
            this.lblUsuarioModificacion.Size = new System.Drawing.Size(144, 19);
            this.lblUsuarioModificacion.TabIndex = 2;
            this.lblUsuarioModificacion.Text = "ÚLTIMO USUARIO";
            // 
            // txtFechaHoraModificacion
            // 
            this.txtFechaHoraModificacion.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaHoraModificacion.Location = new System.Drawing.Point(20, 45);
            this.txtFechaHoraModificacion.Name = "txtFechaHoraModificacion";
            this.txtFechaHoraModificacion.ReadOnly = true;
            this.txtFechaHoraModificacion.Size = new System.Drawing.Size(240, 26);
            this.txtFechaHoraModificacion.TabIndex = 1;
            // 
            // lblFechaHoraModificacion
            // 
            this.lblFechaHoraModificacion.AutoSize = true;
            this.lblFechaHoraModificacion.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHoraModificacion.Location = new System.Drawing.Point(20, 25);
            this.lblFechaHoraModificacion.Name = "lblFechaHoraModificacion";
            this.lblFechaHoraModificacion.Size = new System.Drawing.Size(225, 19);
            this.lblFechaHoraModificacion.TabIndex = 0;
            this.lblFechaHoraModificacion.Text = "ÚLTIMA MODIFICACIÓN";
            // 
            // pnlBotones
            // 
            this.pnlBotones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBotones.Controls.Add(this.btnAuditoriaCompleta);
            this.pnlBotones.Controls.Add(this.btnVerHistorialCliente);
            this.pnlBotones.Controls.Add(this.btnConfirmar);
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Location = new System.Drawing.Point(20, 658);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(930, 60);
            this.pnlBotones.TabIndex = 7;
            // 
            // btnAuditoriaCompleta
            // 
            this.btnAuditoriaCompleta.BackColor = System.Drawing.Color.LightBlue;
            this.btnAuditoriaCompleta.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuditoriaCompleta.Location = new System.Drawing.Point(20, 15);
            this.btnAuditoriaCompleta.Name = "btnAuditoriaCompleta";
            this.btnAuditoriaCompleta.Size = new System.Drawing.Size(180, 35);
            this.btnAuditoriaCompleta.TabIndex = 3;
            this.btnAuditoriaCompleta.Text = "AUDITORÍA COMPLETA";
            this.btnAuditoriaCompleta.UseVisualStyleBackColor = false;
            // 
            // btnVerHistorialCliente
            // 
            this.btnVerHistorialCliente.BackColor = System.Drawing.Color.LightBlue;
            this.btnVerHistorialCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerHistorialCliente.Location = new System.Drawing.Point(220, 15);
            this.btnVerHistorialCliente.Name = "btnVerHistorialCliente";
            this.btnVerHistorialCliente.Size = new System.Drawing.Size(180, 35);
            this.btnVerHistorialCliente.TabIndex = 2;
            this.btnVerHistorialCliente.Text = "VER HISTORIAL";
            this.btnVerHistorialCliente.UseVisualStyleBackColor = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.LightGreen;
            this.btnConfirmar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(730, 15);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(90, 35);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancelar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(830, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 35);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "CERRAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(133, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(754, 49);
            this.label1.TabIndex = 15;
            this.label1.Text = "Registro Presupuesto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmRegistroPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlAuditoria);
            this.Controls.Add(this.pnlResumen);
            this.Controls.Add(this.pnlDetalle);
            this.Controls.Add(this.gbDatosCliente);
            this.Controls.Add(this.gbDatosSistema);
            this.Controls.Add(this.gbControlInterno);
            this.MinimumSize = new System.Drawing.Size(1000, 726);
            this.Name = "frmRegistroPresupuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Presupuesto";
            this.gbControlInterno.ResumeLayout(false);
            this.gbControlInterno.PerformLayout();
            this.gbDatosSistema.ResumeLayout(false);
            this.gbDatosSistema.PerformLayout();
            this.gbDatosCliente.ResumeLayout(false);
            this.gbDatosCliente.PerformLayout();
            this.pnlDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleRegistro)).EndInit();
            this.pnlResumen.ResumeLayout(false);
            this.gbResumen.ResumeLayout(false);
            this.gbResumen.PerformLayout();
            this.pnlAuditoria.ResumeLayout(false);
            this.gbAuditoria.ResumeLayout(false);
            this.gbAuditoria.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Panel pnlResumen;
        private System.Windows.Forms.GroupBox gbResumen;
        private System.Windows.Forms.TextBox txtMargenTotal;
        private System.Windows.Forms.Label lblMargenTotal;
        private System.Windows.Forms.TextBox txtCostoTotal;
        private System.Windows.Forms.Label lblCostoTotal;
        private System.Windows.Forms.TextBox txtCantidadItems;
        private System.Windows.Forms.Label lblCantidadItems;
        private System.Windows.Forms.Panel pnlAuditoria;
        private System.Windows.Forms.GroupBox gbAuditoria;
        private System.Windows.Forms.TextBox txtUsuarioModificacion;
        private System.Windows.Forms.Label lblUsuarioModificacion;
        private System.Windows.Forms.TextBox txtFechaHoraModificacion;
        private System.Windows.Forms.Label lblFechaHoraModificacion;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnAuditoriaCompleta;
        private System.Windows.Forms.Button btnVerHistorialCliente;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
    }
}