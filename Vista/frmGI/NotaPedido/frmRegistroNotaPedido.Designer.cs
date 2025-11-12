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
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.gbControlStock = new System.Windows.Forms.GroupBox();
            this.txtEstadoReserva = new System.Windows.Forms.TextBox();
            this.lblEstadoReserva = new System.Windows.Forms.Label();
            this.txtUsuarioReserva = new System.Windows.Forms.TextBox();
            this.lblUsuarioReserva = new System.Windows.Forms.Label();
            this.txtFechaHoraReserva = new System.Windows.Forms.TextBox();
            this.lblFechaHoraReserva = new System.Windows.Forms.Label();
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
            this.txtIDPedido = new System.Windows.Forms.TextBox();
            this.lblIDPedido = new System.Windows.Forms.Label();
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.pnlCabecera.SuspendLayout();
            this.gbControlStock.SuspendLayout();
            this.gbDatosSistema.SuspendLayout();
            this.gbControlInterno.SuspendLayout();
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
            // pnlCabecera
            // 
            this.pnlCabecera.Controls.Add(this.gbControlStock);
            this.pnlCabecera.Controls.Add(this.gbDatosSistema);
            this.pnlCabecera.Controls.Add(this.gbControlInterno);
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(984, 150);
            this.pnlCabecera.TabIndex = 0;
            // 
            // gbControlStock
            // 
            this.gbControlStock.Controls.Add(this.txtEstadoReserva);
            this.gbControlStock.Controls.Add(this.lblEstadoReserva);
            this.gbControlStock.Controls.Add(this.txtUsuarioReserva);
            this.gbControlStock.Controls.Add(this.lblUsuarioReserva);
            this.gbControlStock.Controls.Add(this.txtFechaHoraReserva);
            this.gbControlStock.Controls.Add(this.lblFechaHoraReserva);
            this.gbControlStock.Location = new System.Drawing.Point(624, 12);
            this.gbControlStock.Name = "gbControlStock";
            this.gbControlStock.Size = new System.Drawing.Size(348, 125);
            this.gbControlStock.TabIndex = 2;
            this.gbControlStock.TabStop = false;
            this.gbControlStock.Text = "Control de Stock";
            // 
            // txtEstadoReserva
            // 
            this.txtEstadoReserva.BackColor = System.Drawing.Color.LightYellow;
            this.txtEstadoReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadoReserva.Location = new System.Drawing.Point(120, 25);
            this.txtEstadoReserva.Name = "txtEstadoReserva";
            this.txtEstadoReserva.ReadOnly = true;
            this.txtEstadoReserva.Size = new System.Drawing.Size(120, 20);
            this.txtEstadoReserva.TabIndex = 5;
            this.txtEstadoReserva.Text = "PENDIENTE";
            this.txtEstadoReserva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEstadoReserva
            // 
            this.lblEstadoReserva.AutoSize = true;
            this.lblEstadoReserva.Location = new System.Drawing.Point(16, 28);
            this.lblEstadoReserva.Name = "lblEstadoReserva";
            this.lblEstadoReserva.Size = new System.Drawing.Size(86, 13);
            this.lblEstadoReserva.TabIndex = 4;
            this.lblEstadoReserva.Text = "Estado Reserva:";
            // 
            // txtUsuarioReserva
            // 
            this.txtUsuarioReserva.Location = new System.Drawing.Point(120, 75);
            this.txtUsuarioReserva.Name = "txtUsuarioReserva";
            this.txtUsuarioReserva.ReadOnly = true;
            this.txtUsuarioReserva.Size = new System.Drawing.Size(120, 20);
            this.txtUsuarioReserva.TabIndex = 3;
            // 
            // lblUsuarioReserva
            // 
            this.lblUsuarioReserva.AutoSize = true;
            this.lblUsuarioReserva.Location = new System.Drawing.Point(16, 78);
            this.lblUsuarioReserva.Name = "lblUsuarioReserva";
            this.lblUsuarioReserva.Size = new System.Drawing.Size(89, 13);
            this.lblUsuarioReserva.TabIndex = 2;
            this.lblUsuarioReserva.Text = "Usuario Reserva:";
            // 
            // txtFechaHoraReserva
            // 
            this.txtFechaHoraReserva.Location = new System.Drawing.Point(120, 50);
            this.txtFechaHoraReserva.Name = "txtFechaHoraReserva";
            this.txtFechaHoraReserva.ReadOnly = true;
            this.txtFechaHoraReserva.Size = new System.Drawing.Size(120, 20);
            this.txtFechaHoraReserva.TabIndex = 1;
            // 
            // lblFechaHoraReserva
            // 
            this.lblFechaHoraReserva.AutoSize = true;
            this.lblFechaHoraReserva.Location = new System.Drawing.Point(16, 53);
            this.lblFechaHoraReserva.Name = "lblFechaHoraReserva";
            this.lblFechaHoraReserva.Size = new System.Drawing.Size(109, 13);
            this.lblFechaHoraReserva.TabIndex = 0;
            this.lblFechaHoraReserva.Text = "Fecha/hora Reserva:";
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
            this.gbControlInterno.Controls.Add(this.txtIDPedido);
            this.gbControlInterno.Controls.Add(this.lblIDPedido);
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
            "Confirmado",
            "En Preparación",
            "Listo para Entrega",
            "Entregado",
            "Facturado",
            "Cancelado"});
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
            // txtIDPedido
            // 
            this.txtIDPedido.Location = new System.Drawing.Point(120, 25);
            this.txtIDPedido.Name = "txtIDPedido";
            this.txtIDPedido.ReadOnly = true;
            this.txtIDPedido.Size = new System.Drawing.Size(120, 20);
            this.txtIDPedido.TabIndex = 1;
            // 
            // lblIDPedido
            // 
            this.lblIDPedido.AutoSize = true;
            this.lblIDPedido.Location = new System.Drawing.Point(16, 28);
            this.lblIDPedido.Name = "lblIDPedido";
            this.lblIDPedido.Size = new System.Drawing.Size(21, 13);
            this.lblIDPedido.TabIndex = 0;
            this.lblIDPedido.Text = "ID:";
            // 
            // pnlDetalle
            // 
            this.pnlDetalle.Controls.Add(this.dgvDetalleRegistro);
            this.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetalle.Location = new System.Drawing.Point(0, 150);
            this.pnlDetalle.Name = "pnlDetalle";
            this.pnlDetalle.Size = new System.Drawing.Size(984, 301);
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
            this.colStockReservado,
            this.colTipoStock,
            this.colDeposito,
            this.colEstadoItem});
            this.dgvDetalleRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalleRegistro.Location = new System.Drawing.Point(0, 0);
            this.dgvDetalleRegistro.Name = "dgvDetalleRegistro";
            this.dgvDetalleRegistro.ReadOnly = true;
            this.dgvDetalleRegistro.Size = new System.Drawing.Size(984, 301);
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
            this.colDescripcion.Width = 150;
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
            // colStockReservado
            // 
            this.colStockReservado.HeaderText = "Stock Reservado";
            this.colStockReservado.Name = "colStockReservado";
            this.colStockReservado.ReadOnly = true;
            this.colStockReservado.Width = 80;
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
            // colEstadoItem
            // 
            this.colEstadoItem.HeaderText = "Estado Item";
            this.colEstadoItem.Name = "colEstadoItem";
            this.colEstadoItem.ReadOnly = true;
            // 
            // pnlResumenStock
            // 
            this.pnlResumenStock.Controls.Add(this.gbResumenStock);
            this.pnlResumenStock.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlResumenStock.Location = new System.Drawing.Point(0, 451);
            this.pnlResumenStock.Name = "pnlResumenStock";
            this.pnlResumenStock.Size = new System.Drawing.Size(984, 80);
            this.pnlResumenStock.TabIndex = 2;
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
            this.gbResumenStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbResumenStock.Location = new System.Drawing.Point(0, 0);
            this.gbResumenStock.Name = "gbResumenStock";
            this.gbResumenStock.Size = new System.Drawing.Size(984, 80);
            this.gbResumenStock.TabIndex = 0;
            this.gbResumenStock.TabStop = false;
            this.gbResumenStock.Text = "Resumen de Stock";
            // 
            // txtProductosJIT
            // 
            this.txtProductosJIT.BackColor = System.Drawing.Color.Khaki;
            this.txtProductosJIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductosJIT.Location = new System.Drawing.Point(400, 40);
            this.txtProductosJIT.Name = "txtProductosJIT";
            this.txtProductosJIT.ReadOnly = true;
            this.txtProductosJIT.Size = new System.Drawing.Size(50, 21);
            this.txtProductosJIT.TabIndex = 7;
            this.txtProductosJIT.Text = "0";
            this.txtProductosJIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblProductosJIT
            // 
            this.lblProductosJIT.AutoSize = true;
            this.lblProductosJIT.Location = new System.Drawing.Point(400, 20);
            this.lblProductosJIT.Name = "lblProductosJIT";
            this.lblProductosJIT.Size = new System.Drawing.Size(53, 13);
            this.lblProductosJIT.TabIndex = 6;
            this.lblProductosJIT.Text = "Stock JIT";
            // 
            // txtProductosSinStock
            // 
            this.txtProductosSinStock.BackColor = System.Drawing.Color.LightCoral;
            this.txtProductosSinStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductosSinStock.Location = new System.Drawing.Point(300, 40);
            this.txtProductosSinStock.Name = "txtProductosSinStock";
            this.txtProductosSinStock.ReadOnly = true;
            this.txtProductosSinStock.Size = new System.Drawing.Size(50, 21);
            this.txtProductosSinStock.TabIndex = 5;
            this.txtProductosSinStock.Text = "0";
            this.txtProductosSinStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblProductosSinStock
            // 
            this.lblProductosSinStock.AutoSize = true;
            this.lblProductosSinStock.Location = new System.Drawing.Point(300, 20);
            this.lblProductosSinStock.Name = "lblProductosSinStock";
            this.lblProductosSinStock.Size = new System.Drawing.Size(53, 13);
            this.lblProductosSinStock.TabIndex = 4;
            this.lblProductosSinStock.Text = "Sin Stock";
            // 
            // txtProductosReservados
            // 
            this.txtProductosReservados.BackColor = System.Drawing.Color.LightGreen;
            this.txtProductosReservados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductosReservados.Location = new System.Drawing.Point(200, 40);
            this.txtProductosReservados.Name = "txtProductosReservados";
            this.txtProductosReservados.ReadOnly = true;
            this.txtProductosReservados.Size = new System.Drawing.Size(50, 21);
            this.txtProductosReservados.TabIndex = 3;
            this.txtProductosReservados.Text = "0";
            this.txtProductosReservados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblProductosReservados
            // 
            this.lblProductosReservados.AutoSize = true;
            this.lblProductosReservados.Location = new System.Drawing.Point(200, 20);
            this.lblProductosReservados.Name = "lblProductosReservados";
            this.lblProductosReservados.Size = new System.Drawing.Size(64, 13);
            this.lblProductosReservados.TabIndex = 2;
            this.lblProductosReservados.Text = "Reservados";
            // 
            // txtProductosConStock
            // 
            this.txtProductosConStock.BackColor = System.Drawing.Color.LightBlue;
            this.txtProductosConStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductosConStock.Location = new System.Drawing.Point(100, 40);
            this.txtProductosConStock.Name = "txtProductosConStock";
            this.txtProductosConStock.ReadOnly = true;
            this.txtProductosConStock.Size = new System.Drawing.Size(50, 21);
            this.txtProductosConStock.TabIndex = 1;
            this.txtProductosConStock.Text = "0";
            this.txtProductosConStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblProductosConStock
            // 
            this.lblProductosConStock.AutoSize = true;
            this.lblProductosConStock.Location = new System.Drawing.Point(100, 20);
            this.lblProductosConStock.Name = "lblProductosConStock";
            this.lblProductosConStock.Size = new System.Drawing.Size(57, 13);
            this.lblProductosConStock.TabIndex = 0;
            this.lblProductosConStock.Text = "Con Stock";
            // 
            // pnlAuditoria
            // 
            this.pnlAuditoria.Controls.Add(this.gbAuditoria);
            this.pnlAuditoria.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAuditoria.Location = new System.Drawing.Point(0, 531);
            this.pnlAuditoria.Name = "pnlAuditoria";
            this.pnlAuditoria.Size = new System.Drawing.Size(984, 60);
            this.pnlAuditoria.TabIndex = 3;
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
            this.pnlResumen.Location = new System.Drawing.Point(0, 591);
            this.pnlResumen.Name = "pnlResumen";
            this.pnlResumen.Size = new System.Drawing.Size(984, 70);
            this.pnlResumen.TabIndex = 4;
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
            this.pnlBotones.Controls.Add(this.btnVerMovimientosStock);
            this.pnlBotones.Controls.Add(this.btnLiberarReserva);
            this.pnlBotones.Controls.Add(this.btnReservarStock);
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Controls.Add(this.btnConfirmar);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotones.Location = new System.Drawing.Point(0, 661);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(984, 50);
            this.pnlBotones.TabIndex = 5;
            // 
            // btnAuditoriaCompleta
            // 
            this.btnAuditoriaCompleta.Location = new System.Drawing.Point(32, 15);
            this.btnAuditoriaCompleta.Name = "btnAuditoriaCompleta";
            this.btnAuditoriaCompleta.Size = new System.Drawing.Size(100, 23);
            this.btnAuditoriaCompleta.TabIndex = 5;
            this.btnAuditoriaCompleta.Text = "Auditoría Completa";
            this.btnAuditoriaCompleta.UseVisualStyleBackColor = true;
            // 
            // btnVerMovimientosStock
            // 
            this.btnVerMovimientosStock.Location = new System.Drawing.Point(138, 15);
            this.btnVerMovimientosStock.Name = "btnVerMovimientosStock";
            this.btnVerMovimientosStock.Size = new System.Drawing.Size(140, 23);
            this.btnVerMovimientosStock.TabIndex = 4;
            this.btnVerMovimientosStock.Text = "Ver Movimientos Stock";
            this.btnVerMovimientosStock.UseVisualStyleBackColor = true;
            // 
            // btnLiberarReserva
            // 
            this.btnLiberarReserva.BackColor = System.Drawing.Color.LightCoral;
            this.btnLiberarReserva.Location = new System.Drawing.Point(284, 15);
            this.btnLiberarReserva.Name = "btnLiberarReserva";
            this.btnLiberarReserva.Size = new System.Drawing.Size(120, 23);
            this.btnLiberarReserva.TabIndex = 3;
            this.btnLiberarReserva.Text = "Liberar Reserva";
            this.btnLiberarReserva.UseVisualStyleBackColor = false;
            // 
            // btnReservarStock
            // 
            this.btnReservarStock.BackColor = System.Drawing.Color.LightGreen;
            this.btnReservarStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservarStock.Location = new System.Drawing.Point(410, 15);
            this.btnReservarStock.Name = "btnReservarStock";
            this.btnReservarStock.Size = new System.Drawing.Size(120, 23);
            this.btnReservarStock.TabIndex = 2;
            this.btnReservarStock.Text = "Reservar Stock";
            this.btnReservarStock.UseVisualStyleBackColor = false;
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
            // frmRegistroNotaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.pnlDetalle);
            this.Controls.Add(this.pnlResumenStock);
            this.Controls.Add(this.pnlAuditoria);
            this.Controls.Add(this.pnlResumen);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlCabecera);
            this.Name = "frmRegistroNotaPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro - Nota de Pedido";
            this.pnlCabecera.ResumeLayout(false);
            this.gbControlStock.ResumeLayout(false);
            this.gbControlStock.PerformLayout();
            this.gbDatosSistema.ResumeLayout(false);
            this.gbDatosSistema.PerformLayout();
            this.gbControlInterno.ResumeLayout(false);
            this.gbControlInterno.PerformLayout();
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

        private System.Windows.Forms.Panel pnlCabecera;
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
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
    }
}