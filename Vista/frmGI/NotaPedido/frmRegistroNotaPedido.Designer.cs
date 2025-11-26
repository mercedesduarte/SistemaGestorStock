namespace Vista.frmGI.NotaPedido
{
    partial class frmRegistroNotaPedido
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
            this.txtIDPedido = new System.Windows.Forms.TextBox();
            this.lblIDPedido = new System.Windows.Forms.Label();
            this.gbDatosSistema = new System.Windows.Forms.GroupBox();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.cmbListaPrecios = new System.Windows.Forms.ComboBox();
            this.lblListaPrecios = new System.Windows.Forms.Label();
            this.txtCanalVenta = new System.Windows.Forms.TextBox();
            this.lblCanalVenta = new System.Windows.Forms.Label();
            this.gbControlStock = new System.Windows.Forms.GroupBox();
            this.txtEstadoReserva = new System.Windows.Forms.TextBox();
            this.lblEstadoReserva = new System.Windows.Forms.Label();
            this.txtUsuarioReserva = new System.Windows.Forms.TextBox();
            this.lblUsuarioReserva = new System.Windows.Forms.Label();
            this.txtFechaHoraReserva = new System.Windows.Forms.TextBox();
            this.lblFechaHoraReserva = new System.Windows.Forms.Label();
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
            this.colStockReservado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeposito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlResumenStock = new System.Windows.Forms.Panel();
            this.gbResumenStock = new System.Windows.Forms.GroupBox();
            this.txtProductosJIT = new System.Windows.Forms.TextBox();
            this.lblProductosJIT = new System.Windows.Forms.Label();
            this.txtProductosSinStock = new System.Windows.Forms.TextBox();
            this.lblProductosSinStock = new System.Windows.Forms.Label();
            this.txtProductosReservados = new System.Windows.Forms.TextBox();
            this.lblProductosReservados = new System.Windows.Forms.Label();
            this.txtProductosConStock = new System.Windows.Forms.TextBox();
            this.lblProductosConStock = new System.Windows.Forms.Label();
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
            this.btnVerMovimientosStock = new System.Windows.Forms.Button();
            this.btnLiberarReserva = new System.Windows.Forms.Button();
            this.btnReservarStock = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbControlInterno.SuspendLayout();
            this.gbDatosSistema.SuspendLayout();
            this.gbControlStock.SuspendLayout();
            this.pnlDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleRegistro)).BeginInit();
            this.pnlResumenStock.SuspendLayout();
            this.gbResumenStock.SuspendLayout();
            this.pnlAuditoria.SuspendLayout();
            this.gbAuditoria.SuspendLayout();
            this.pnlResumen.SuspendLayout();
            this.gbResumen.SuspendLayout();
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
            this.gbControlInterno.Controls.Add(this.txtIDPedido);
            this.gbControlInterno.Controls.Add(this.lblIDPedido);
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
            "Confirmado",
            "En Preparación",
            "Listo para Entrega",
            "Entregado",
            "Facturado",
            "Cancelado"});
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
            this.lblUsuarioCreacion.Size = new System.Drawing.Size(126, 19);
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
            // txtIDPedido
            // 
            this.txtIDPedido.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDPedido.Location = new System.Drawing.Point(140, 30);
            this.txtIDPedido.Name = "txtIDPedido";
            this.txtIDPedido.ReadOnly = true;
            this.txtIDPedido.Size = new System.Drawing.Size(200, 26);
            this.txtIDPedido.TabIndex = 1;
            // 
            // lblIDPedido
            // 
            this.lblIDPedido.AutoSize = true;
            this.lblIDPedido.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDPedido.Location = new System.Drawing.Point(20, 33);
            this.lblIDPedido.Name = "lblIDPedido";
            this.lblIDPedido.Size = new System.Drawing.Size(36, 19);
            this.lblIDPedido.TabIndex = 0;
            this.lblIDPedido.Text = "ID:";
            // 
            // gbDatosSistema
            // 
            this.gbDatosSistema.Controls.Add(this.txtVendedor);
            this.gbDatosSistema.Controls.Add(this.lblVendedor);
            this.gbDatosSistema.Controls.Add(this.cmbListaPrecios);
            this.gbDatosSistema.Controls.Add(this.lblListaPrecios);
            this.gbDatosSistema.Controls.Add(this.txtCanalVenta);
            this.gbDatosSistema.Controls.Add(this.lblCanalVenta);
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
            this.txtVendedor.Location = new System.Drawing.Point(140, 90);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.ReadOnly = true;
            this.txtVendedor.Size = new System.Drawing.Size(280, 26);
            this.txtVendedor.TabIndex = 5;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.Location = new System.Drawing.Point(20, 93);
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
            this.cmbListaPrecios.Location = new System.Drawing.Point(140, 60);
            this.cmbListaPrecios.Name = "cmbListaPrecios";
            this.cmbListaPrecios.Size = new System.Drawing.Size(200, 27);
            this.cmbListaPrecios.TabIndex = 3;
            // 
            // lblListaPrecios
            // 
            this.lblListaPrecios.AutoSize = true;
            this.lblListaPrecios.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaPrecios.Location = new System.Drawing.Point(20, 63);
            this.lblListaPrecios.Name = "lblListaPrecios";
            this.lblListaPrecios.Size = new System.Drawing.Size(126, 19);
            this.lblListaPrecios.TabIndex = 2;
            this.lblListaPrecios.Text = "Lista Precio:";
            // 
            // txtCanalVenta
            // 
            this.txtCanalVenta.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCanalVenta.Location = new System.Drawing.Point(140, 30);
            this.txtCanalVenta.Name = "txtCanalVenta";
            this.txtCanalVenta.ReadOnly = true;
            this.txtCanalVenta.Size = new System.Drawing.Size(200, 26);
            this.txtCanalVenta.TabIndex = 1;
            this.txtCanalVenta.Text = "Mostrador";
            // 
            // lblCanalVenta
            // 
            this.lblCanalVenta.AutoSize = true;
            this.lblCanalVenta.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanalVenta.Location = new System.Drawing.Point(20, 33);
            this.lblCanalVenta.Name = "lblCanalVenta";
            this.lblCanalVenta.Size = new System.Drawing.Size(117, 19);
            this.lblCanalVenta.TabIndex = 0;
            this.lblCanalVenta.Text = "Canal Venta:";
            // 
            // gbControlStock
            // 
            this.gbControlStock.Controls.Add(this.txtEstadoReserva);
            this.gbControlStock.Controls.Add(this.lblEstadoReserva);
            this.gbControlStock.Controls.Add(this.txtUsuarioReserva);
            this.gbControlStock.Controls.Add(this.lblUsuarioReserva);
            this.gbControlStock.Controls.Add(this.txtFechaHoraReserva);
            this.gbControlStock.Controls.Add(this.lblFechaHoraReserva);
            this.gbControlStock.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbControlStock.Location = new System.Drawing.Point(20, 280);
            this.gbControlStock.Name = "gbControlStock";
            this.gbControlStock.Size = new System.Drawing.Size(450, 180);
            this.gbControlStock.TabIndex = 3;
            this.gbControlStock.TabStop = false;
            this.gbControlStock.Text = "CONTROL DE STOCK";
            // 
            // txtEstadoReserva
            // 
            this.txtEstadoReserva.BackColor = System.Drawing.Color.LightYellow;
            this.txtEstadoReserva.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadoReserva.Location = new System.Drawing.Point(179, 33);
            this.txtEstadoReserva.Name = "txtEstadoReserva";
            this.txtEstadoReserva.ReadOnly = true;
            this.txtEstadoReserva.Size = new System.Drawing.Size(200, 26);
            this.txtEstadoReserva.TabIndex = 5;
            this.txtEstadoReserva.Text = "PENDIENTE";
            this.txtEstadoReserva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEstadoReserva
            // 
            this.lblEstadoReserva.AutoSize = true;
            this.lblEstadoReserva.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoReserva.Location = new System.Drawing.Point(20, 33);
            this.lblEstadoReserva.Name = "lblEstadoReserva";
            this.lblEstadoReserva.Size = new System.Drawing.Size(144, 19);
            this.lblEstadoReserva.TabIndex = 4;
            this.lblEstadoReserva.Text = "Estado Reserva:";
            // 
            // txtUsuarioReserva
            // 
            this.txtUsuarioReserva.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioReserva.Location = new System.Drawing.Point(179, 93);
            this.txtUsuarioReserva.Name = "txtUsuarioReserva";
            this.txtUsuarioReserva.ReadOnly = true;
            this.txtUsuarioReserva.Size = new System.Drawing.Size(200, 26);
            this.txtUsuarioReserva.TabIndex = 3;
            // 
            // lblUsuarioReserva
            // 
            this.lblUsuarioReserva.AutoSize = true;
            this.lblUsuarioReserva.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioReserva.Location = new System.Drawing.Point(20, 93);
            this.lblUsuarioReserva.Name = "lblUsuarioReserva";
            this.lblUsuarioReserva.Size = new System.Drawing.Size(153, 19);
            this.lblUsuarioReserva.TabIndex = 2;
            this.lblUsuarioReserva.Text = "Usuario Reserva:";
            // 
            // txtFechaHoraReserva
            // 
            this.txtFechaHoraReserva.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaHoraReserva.Location = new System.Drawing.Point(179, 63);
            this.txtFechaHoraReserva.Name = "txtFechaHoraReserva";
            this.txtFechaHoraReserva.ReadOnly = true;
            this.txtFechaHoraReserva.Size = new System.Drawing.Size(200, 26);
            this.txtFechaHoraReserva.TabIndex = 1;
            // 
            // lblFechaHoraReserva
            // 
            this.lblFechaHoraReserva.AutoSize = true;
            this.lblFechaHoraReserva.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHoraReserva.Location = new System.Drawing.Point(20, 63);
            this.lblFechaHoraReserva.Name = "lblFechaHoraReserva";
            this.lblFechaHoraReserva.Size = new System.Drawing.Size(108, 19);
            this.lblFechaHoraReserva.TabIndex = 0;
            this.lblFechaHoraReserva.Text = "Fecha/Hora:";
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
            this.colStockReservado,
            this.colTipoStock,
            this.colDeposito,
            this.colEstadoItem});
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
            this.colDescripcion.Width = 150;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "CANTIDAD";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 70;
            // 
            // colUnidad
            // 
            this.colUnidad.HeaderText = "UNIDAD";
            this.colUnidad.Name = "colUnidad";
            this.colUnidad.ReadOnly = true;
            this.colUnidad.Width = 60;
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
            this.colMargen.Width = 80;
            // 
            // colStockActual
            // 
            this.colStockActual.HeaderText = "STOCK ACT.";
            this.colStockActual.Name = "colStockActual";
            this.colStockActual.ReadOnly = true;
            this.colStockActual.Width = 80;
            // 
            // colStockReservado
            // 
            this.colStockReservado.HeaderText = "STOCK RES.";
            this.colStockReservado.Name = "colStockReservado";
            this.colStockReservado.ReadOnly = true;
            this.colStockReservado.Width = 80;
            // 
            // colTipoStock
            // 
            this.colTipoStock.HeaderText = "TIPO STOCK";
            this.colTipoStock.Name = "colTipoStock";
            this.colTipoStock.ReadOnly = true;
            this.colTipoStock.Width = 80;
            // 
            // colDeposito
            // 
            this.colDeposito.HeaderText = "DEPÓSITO";
            this.colDeposito.Name = "colDeposito";
            this.colDeposito.ReadOnly = true;
            this.colDeposito.Width = 80;
            // 
            // colEstadoItem
            // 
            this.colEstadoItem.HeaderText = "ESTADO ITEM";
            this.colEstadoItem.Name = "colEstadoItem";
            this.colEstadoItem.ReadOnly = true;
            // 
            // pnlResumenStock
            // 
            this.pnlResumenStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlResumenStock.Controls.Add(this.gbResumenStock);
            this.pnlResumenStock.Location = new System.Drawing.Point(20, 538);
            this.pnlResumenStock.Name = "pnlResumenStock";
            this.pnlResumenStock.Size = new System.Drawing.Size(450, 100);
            this.pnlResumenStock.TabIndex = 5;
            // 
            // gbResumenStock
            // 
            this.gbResumenStock.Controls.Add(this.txtProductosJIT);
            this.gbResumenStock.Controls.Add(this.lblProductosJIT);
            this.gbResumenStock.Controls.Add(this.txtProductosSinStock);
            this.gbResumenStock.Controls.Add(this.lblProductosSinStock);
            this.gbResumenStock.Controls.Add(this.txtProductosReservados);
            this.gbResumenStock.Controls.Add(this.lblProductosReservados);
            this.gbResumenStock.Controls.Add(this.txtProductosConStock);
            this.gbResumenStock.Controls.Add(this.lblProductosConStock);
            this.gbResumenStock.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResumenStock.Location = new System.Drawing.Point(0, 10);
            this.gbResumenStock.Name = "gbResumenStock";
            this.gbResumenStock.Size = new System.Drawing.Size(450, 80);
            this.gbResumenStock.TabIndex = 0;
            this.gbResumenStock.TabStop = false;
            this.gbResumenStock.Text = "RESUMEN DE STOCK";
            // 
            // txtProductosJIT
            // 
            this.txtProductosJIT.BackColor = System.Drawing.Color.Khaki;
            this.txtProductosJIT.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductosJIT.Location = new System.Drawing.Point(340, 45);
            this.txtProductosJIT.Name = "txtProductosJIT";
            this.txtProductosJIT.ReadOnly = true;
            this.txtProductosJIT.Size = new System.Drawing.Size(50, 26);
            this.txtProductosJIT.TabIndex = 7;
            this.txtProductosJIT.Text = "0";
            this.txtProductosJIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblProductosJIT
            // 
            this.lblProductosJIT.AutoSize = true;
            this.lblProductosJIT.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductosJIT.Location = new System.Drawing.Point(340, 25);
            this.lblProductosJIT.Name = "lblProductosJIT";
            this.lblProductosJIT.Size = new System.Drawing.Size(90, 19);
            this.lblProductosJIT.TabIndex = 6;
            this.lblProductosJIT.Text = "STOCK JIT";
            // 
            // txtProductosSinStock
            // 
            this.txtProductosSinStock.BackColor = System.Drawing.Color.LightCoral;
            this.txtProductosSinStock.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductosSinStock.Location = new System.Drawing.Point(230, 45);
            this.txtProductosSinStock.Name = "txtProductosSinStock";
            this.txtProductosSinStock.ReadOnly = true;
            this.txtProductosSinStock.Size = new System.Drawing.Size(50, 26);
            this.txtProductosSinStock.TabIndex = 5;
            this.txtProductosSinStock.Text = "0";
            this.txtProductosSinStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblProductosSinStock
            // 
            this.lblProductosSinStock.AutoSize = true;
            this.lblProductosSinStock.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductosSinStock.Location = new System.Drawing.Point(230, 25);
            this.lblProductosSinStock.Name = "lblProductosSinStock";
            this.lblProductosSinStock.Size = new System.Drawing.Size(90, 19);
            this.lblProductosSinStock.TabIndex = 4;
            this.lblProductosSinStock.Text = "SIN STOCK";
            // 
            // txtProductosReservados
            // 
            this.txtProductosReservados.BackColor = System.Drawing.Color.LightGreen;
            this.txtProductosReservados.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductosReservados.Location = new System.Drawing.Point(120, 45);
            this.txtProductosReservados.Name = "txtProductosReservados";
            this.txtProductosReservados.ReadOnly = true;
            this.txtProductosReservados.Size = new System.Drawing.Size(50, 26);
            this.txtProductosReservados.TabIndex = 3;
            this.txtProductosReservados.Text = "0";
            this.txtProductosReservados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblProductosReservados
            // 
            this.lblProductosReservados.AutoSize = true;
            this.lblProductosReservados.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductosReservados.Location = new System.Drawing.Point(120, 25);
            this.lblProductosReservados.Name = "lblProductosReservados";
            this.lblProductosReservados.Size = new System.Drawing.Size(99, 19);
            this.lblProductosReservados.TabIndex = 2;
            this.lblProductosReservados.Text = "RESERVADOS";
            // 
            // txtProductosConStock
            // 
            this.txtProductosConStock.BackColor = System.Drawing.Color.LightBlue;
            this.txtProductosConStock.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductosConStock.Location = new System.Drawing.Point(10, 45);
            this.txtProductosConStock.Name = "txtProductosConStock";
            this.txtProductosConStock.ReadOnly = true;
            this.txtProductosConStock.Size = new System.Drawing.Size(50, 26);
            this.txtProductosConStock.TabIndex = 1;
            this.txtProductosConStock.Text = "0";
            this.txtProductosConStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblProductosConStock
            // 
            this.lblProductosConStock.AutoSize = true;
            this.lblProductosConStock.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductosConStock.Location = new System.Drawing.Point(10, 25);
            this.lblProductosConStock.Name = "lblProductosConStock";
            this.lblProductosConStock.Size = new System.Drawing.Size(90, 19);
            this.lblProductosConStock.TabIndex = 0;
            this.lblProductosConStock.Text = "CON STOCK";
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
            this.lblUsuarioModificacion.Size = new System.Drawing.Size(135, 19);
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
            this.lblFechaHoraModificacion.Size = new System.Drawing.Size(180, 19);
            this.lblFechaHoraModificacion.TabIndex = 0;
            this.lblFechaHoraModificacion.Text = "ÚLTIMA MODIFICACIÓN";
            // 
            // pnlResumen
            // 
            this.pnlResumen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlResumen.Controls.Add(this.gbResumen);
            this.pnlResumen.Location = new System.Drawing.Point(20, 658);
            this.pnlResumen.Name = "pnlResumen";
            this.pnlResumen.Size = new System.Drawing.Size(450, 70);
            this.pnlResumen.TabIndex = 7;
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
            this.gbResumen.Size = new System.Drawing.Size(450, 50);
            this.gbResumen.TabIndex = 0;
            this.gbResumen.TabStop = false;
            this.gbResumen.Text = "RESUMEN INTERNO";
            // 
            // txtMargenTotal
            // 
            this.txtMargenTotal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMargenTotal.Location = new System.Drawing.Point(320, 20);
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
            this.lblMargenTotal.Location = new System.Drawing.Point(320, 0);
            this.lblMargenTotal.Name = "lblMargenTotal";
            this.lblMargenTotal.Size = new System.Drawing.Size(63, 19);
            this.lblMargenTotal.TabIndex = 4;
            this.lblMargenTotal.Text = "MARGEN";
            // 
            // txtCostoTotal
            // 
            this.txtCostoTotal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoTotal.Location = new System.Drawing.Point(170, 20);
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
            this.lblCostoTotal.Location = new System.Drawing.Point(170, 0);
            this.lblCostoTotal.Name = "lblCostoTotal";
            this.lblCostoTotal.Size = new System.Drawing.Size(54, 19);
            this.lblCostoTotal.TabIndex = 2;
            this.lblCostoTotal.Text = "COSTO";
            // 
            // txtCantidadItems
            // 
            this.txtCantidadItems.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadItems.Location = new System.Drawing.Point(20, 20);
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
            this.lblCantidadItems.Location = new System.Drawing.Point(20, 0);
            this.lblCantidadItems.Name = "lblCantidadItems";
            this.lblCantidadItems.Size = new System.Drawing.Size(54, 19);
            this.lblCantidadItems.TabIndex = 0;
            this.lblCantidadItems.Text = "ITEMS";
            // 
            // pnlBotones
            // 
            this.pnlBotones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBotones.Controls.Add(this.btnAuditoriaCompleta);
            this.pnlBotones.Controls.Add(this.btnVerMovimientosStock);
            this.pnlBotones.Controls.Add(this.btnLiberarReserva);
            this.pnlBotones.Controls.Add(this.btnReservarStock);
            this.pnlBotones.Controls.Add(this.btnConfirmar);
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Location = new System.Drawing.Point(500, 658);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(450, 70);
            this.pnlBotones.TabIndex = 8;
            // 
            // btnAuditoriaCompleta
            // 
            this.btnAuditoriaCompleta.BackColor = System.Drawing.Color.LightBlue;
            this.btnAuditoriaCompleta.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuditoriaCompleta.Location = new System.Drawing.Point(20, 20);
            this.btnAuditoriaCompleta.Name = "btnAuditoriaCompleta";
            this.btnAuditoriaCompleta.Size = new System.Drawing.Size(100, 35);
            this.btnAuditoriaCompleta.TabIndex = 5;
            this.btnAuditoriaCompleta.Text = "AUDITORÍA";
            this.btnAuditoriaCompleta.UseVisualStyleBackColor = false;
            // 
            // btnVerMovimientosStock
            // 
            this.btnVerMovimientosStock.BackColor = System.Drawing.Color.LightBlue;
            this.btnVerMovimientosStock.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerMovimientosStock.Location = new System.Drawing.Point(130, 20);
            this.btnVerMovimientosStock.Name = "btnVerMovimientosStock";
            this.btnVerMovimientosStock.Size = new System.Drawing.Size(100, 35);
            this.btnVerMovimientosStock.TabIndex = 4;
            this.btnVerMovimientosStock.Text = "MOVIMIENTOS";
            this.btnVerMovimientosStock.UseVisualStyleBackColor = false;
            // 
            // btnLiberarReserva
            // 
            this.btnLiberarReserva.BackColor = System.Drawing.Color.LightCoral;
            this.btnLiberarReserva.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiberarReserva.Location = new System.Drawing.Point(240, 20);
            this.btnLiberarReserva.Name = "btnLiberarReserva";
            this.btnLiberarReserva.Size = new System.Drawing.Size(100, 35);
            this.btnLiberarReserva.TabIndex = 3;
            this.btnLiberarReserva.Text = "LIBERAR RESERVA";
            this.btnLiberarReserva.UseVisualStyleBackColor = false;
            // 
            // btnReservarStock
            // 
            this.btnReservarStock.BackColor = System.Drawing.Color.LightGreen;
            this.btnReservarStock.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservarStock.Location = new System.Drawing.Point(350, 20);
            this.btnReservarStock.Name = "btnReservarStock";
            this.btnReservarStock.Size = new System.Drawing.Size(90, 35);
            this.btnReservarStock.TabIndex = 2;
            this.btnReservarStock.Text = "RESERVAR STOCK";
            this.btnReservarStock.UseVisualStyleBackColor = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.LightGreen;
            this.btnConfirmar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(260, 20);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(90, 35);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancelar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(350, 20);
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
            this.label1.Text = "Registro Nota de Pedido";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmRegistroNotaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlResumen);
            this.Controls.Add(this.pnlAuditoria);
            this.Controls.Add(this.pnlResumenStock);
            this.Controls.Add(this.pnlDetalle);
            this.Controls.Add(this.gbControlStock);
            this.Controls.Add(this.gbDatosSistema);
            this.Controls.Add(this.gbControlInterno);
            this.MinimumSize = new System.Drawing.Size(1000, 726);
            this.Name = "frmRegistroNotaPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Nota de Pedido";
            this.gbControlInterno.ResumeLayout(false);
            this.gbControlInterno.PerformLayout();
            this.gbDatosSistema.ResumeLayout(false);
            this.gbDatosSistema.PerformLayout();
            this.gbControlStock.ResumeLayout(false);
            this.gbControlStock.PerformLayout();
            this.pnlDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleRegistro)).EndInit();
            this.pnlResumenStock.ResumeLayout(false);
            this.gbResumenStock.ResumeLayout(false);
            this.gbResumenStock.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbControlInterno;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtUsuarioCreacion;
        private System.Windows.Forms.Label lblUsuarioCreacion;
        private System.Windows.Forms.TextBox txtFechaHoraCreacion;
        private System.Windows.Forms.Label lblFechaHoraCreacion;
        private System.Windows.Forms.TextBox txtIDPedido;
        private System.Windows.Forms.Label lblIDPedido;
        private System.Windows.Forms.GroupBox gbDatosSistema;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.ComboBox cmbListaPrecios;
        private System.Windows.Forms.Label lblListaPrecios;
        private System.Windows.Forms.TextBox txtCanalVenta;
        private System.Windows.Forms.Label lblCanalVenta;
        private System.Windows.Forms.GroupBox gbControlStock;
        private System.Windows.Forms.TextBox txtEstadoReserva;
        private System.Windows.Forms.Label lblEstadoReserva;
        private System.Windows.Forms.TextBox txtUsuarioReserva;
        private System.Windows.Forms.Label lblUsuarioReserva;
        private System.Windows.Forms.TextBox txtFechaHoraReserva;
        private System.Windows.Forms.Label lblFechaHoraReserva;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockReservado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeposito;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoItem;
        private System.Windows.Forms.Panel pnlResumenStock;
        private System.Windows.Forms.GroupBox gbResumenStock;
        private System.Windows.Forms.TextBox txtProductosJIT;
        private System.Windows.Forms.Label lblProductosJIT;
        private System.Windows.Forms.TextBox txtProductosSinStock;
        private System.Windows.Forms.Label lblProductosSinStock;
        private System.Windows.Forms.TextBox txtProductosReservados;
        private System.Windows.Forms.Label lblProductosReservados;
        private System.Windows.Forms.TextBox txtProductosConStock;
        private System.Windows.Forms.Label lblProductosConStock;
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
        private System.Windows.Forms.Button btnVerMovimientosStock;
        private System.Windows.Forms.Button btnLiberarReserva;
        private System.Windows.Forms.Button btnReservarStock;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
    }
}