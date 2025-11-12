namespace Vista.frmGI.NotaDebito
{
    partial class frmRegistroNotaDebito
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
            this.gbComprobanteOrigen = new System.Windows.Forms.GroupBox();
            this.txtIDFacturaOrigen = new System.Windows.Forms.TextBox();
            this.lblIDFacturaOrigen = new System.Windows.Forms.Label();
            this.txtNumeroFacturaOrigen = new System.Windows.Forms.TextBox();
            this.lblNumeroFacturaOrigen = new System.Windows.Forms.Label();
            this.txtFechaFacturaOrigen = new System.Windows.Forms.TextBox();
            this.lblFechaFacturaOrigen = new System.Windows.Forms.Label();
            this.gbDatosCliente = new System.Windows.Forms.GroupBox();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.lblIDCliente = new System.Windows.Forms.Label();
            this.txtCategoriaCliente = new System.Windows.Forms.TextBox();
            this.lblCategoriaCliente = new System.Windows.Forms.Label();
            this.txtSaldoCliente = new System.Windows.Forms.TextBox();
            this.lblSaldoCliente = new System.Windows.Forms.Label();
            this.gbDatosSistema = new System.Windows.Forms.GroupBox();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.cmbMotivo = new System.Windows.Forms.ComboBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.txtCanalVenta = new System.Windows.Forms.TextBox();
            this.lblCanalVenta = new System.Windows.Forms.Label();
            this.gbControlInterno = new System.Windows.Forms.GroupBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtUsuarioCreacion = new System.Windows.Forms.TextBox();
            this.lblUsuarioCreacion = new System.Windows.Forms.Label();
            this.txtFechaHoraCreacion = new System.Windows.Forms.TextBox();
            this.lblFechaHoraCreacion = new System.Windows.Forms.Label();
            this.txtIDNotaDebito = new System.Windows.Forms.TextBox();
            this.lblIDNotaDebito = new System.Windows.Forms.Label();
            this.pnlDetalle = new System.Windows.Forms.Panel();
            this.dgvDetalleRegistro = new System.Windows.Forms.DataGridView();
            this.colIDConcepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConcepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCostoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMargen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAfectaStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlAuditoria = new System.Windows.Forms.Panel();
            this.gbAuditoria = new System.Windows.Forms.GroupBox();
            this.txtUsuarioModificacion = new System.Windows.Forms.TextBox();
            this.lblUsuarioModificacion = new System.Windows.Forms.Label();
            this.txtFechaHoraModificacion = new System.Windows.Forms.TextBox();
            this.lblFechaHoraModificacion = new System.Windows.Forms.Label();
            this.pnlResumen = new System.Windows.Forms.Panel();
            this.gbResumen = new System.Windows.Forms.GroupBox();
            this.txtTotalDebito = new System.Windows.Forms.TextBox();
            this.lblTotalDebito = new System.Windows.Forms.Label();
            this.txtMargenTotal = new System.Windows.Forms.TextBox();
            this.lblMargenTotal = new System.Windows.Forms.Label();
            this.txtCostoTotal = new System.Windows.Forms.TextBox();
            this.lblCostoTotal = new System.Windows.Forms.Label();
            this.txtCantidadItems = new System.Windows.Forms.TextBox();
            this.lblCantidadItems = new System.Windows.Forms.Label();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnAuditoriaCompleta = new System.Windows.Forms.Button();
            this.btnVerMovimientos = new System.Windows.Forms.Button();
            this.btnAplicarCobro = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.pnlCabecera.SuspendLayout();
            this.gbComprobanteOrigen.SuspendLayout();
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
            this.pnlCabecera.Controls.Add(this.gbComprobanteOrigen);
            this.pnlCabecera.Controls.Add(this.gbDatosCliente);
            this.pnlCabecera.Controls.Add(this.gbDatosSistema);
            this.pnlCabecera.Controls.Add(this.gbControlInterno);
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(984, 180);
            this.pnlCabecera.TabIndex = 0;
            // 
            // gbComprobanteOrigen
            // 
            this.gbComprobanteOrigen.Controls.Add(this.txtIDFacturaOrigen);
            this.gbComprobanteOrigen.Controls.Add(this.lblIDFacturaOrigen);
            this.gbComprobanteOrigen.Controls.Add(this.txtNumeroFacturaOrigen);
            this.gbComprobanteOrigen.Controls.Add(this.lblNumeroFacturaOrigen);
            this.gbComprobanteOrigen.Controls.Add(this.txtFechaFacturaOrigen);
            this.gbComprobanteOrigen.Controls.Add(this.lblFechaFacturaOrigen);
            this.gbComprobanteOrigen.Location = new System.Drawing.Point(780, 12);
            this.gbComprobanteOrigen.Name = "gbComprobanteOrigen";
            this.gbComprobanteOrigen.Size = new System.Drawing.Size(192, 155);
            this.gbComprobanteOrigen.TabIndex = 3;
            this.gbComprobanteOrigen.TabStop = false;
            this.gbComprobanteOrigen.Text = "Comprobante Origen";
            // 
            // txtIDFacturaOrigen
            // 
            this.txtIDFacturaOrigen.Location = new System.Drawing.Point(120, 25);
            this.txtIDFacturaOrigen.Name = "txtIDFacturaOrigen";
            this.txtIDFacturaOrigen.ReadOnly = true;
            this.txtIDFacturaOrigen.Size = new System.Drawing.Size(60, 20);
            this.txtIDFacturaOrigen.TabIndex = 5;
            // 
            // lblIDFacturaOrigen
            // 
            this.lblIDFacturaOrigen.AutoSize = true;
            this.lblIDFacturaOrigen.Location = new System.Drawing.Point(16, 28);
            this.lblIDFacturaOrigen.Name = "lblIDFacturaOrigen";
            this.lblIDFacturaOrigen.Size = new System.Drawing.Size(21, 13);
            this.lblIDFacturaOrigen.TabIndex = 4;
            this.lblIDFacturaOrigen.Text = "ID:";
            // 
            // txtNumeroFacturaOrigen
            // 
            this.txtNumeroFacturaOrigen.Location = new System.Drawing.Point(120, 75);
            this.txtNumeroFacturaOrigen.Name = "txtNumeroFacturaOrigen";
            this.txtNumeroFacturaOrigen.ReadOnly = true;
            this.txtNumeroFacturaOrigen.Size = new System.Drawing.Size(60, 20);
            this.txtNumeroFacturaOrigen.TabIndex = 3;
            this.txtNumeroFacturaOrigen.Text = "FAC-00000001";
            // 
            // lblNumeroFacturaOrigen
            // 
            this.lblNumeroFacturaOrigen.AutoSize = true;
            this.lblNumeroFacturaOrigen.Location = new System.Drawing.Point(16, 78);
            this.lblNumeroFacturaOrigen.Name = "lblNumeroFacturaOrigen";
            this.lblNumeroFacturaOrigen.Size = new System.Drawing.Size(47, 13);
            this.lblNumeroFacturaOrigen.TabIndex = 2;
            this.lblNumeroFacturaOrigen.Text = "Número:";
            // 
            // txtFechaFacturaOrigen
            // 
            this.txtFechaFacturaOrigen.Location = new System.Drawing.Point(120, 50);
            this.txtFechaFacturaOrigen.Name = "txtFechaFacturaOrigen";
            this.txtFechaFacturaOrigen.ReadOnly = true;
            this.txtFechaFacturaOrigen.Size = new System.Drawing.Size(60, 20);
            this.txtFechaFacturaOrigen.TabIndex = 1;
            // 
            // lblFechaFacturaOrigen
            // 
            this.lblFechaFacturaOrigen.AutoSize = true;
            this.lblFechaFacturaOrigen.Location = new System.Drawing.Point(16, 53);
            this.lblFechaFacturaOrigen.Name = "lblFechaFacturaOrigen";
            this.lblFechaFacturaOrigen.Size = new System.Drawing.Size(40, 13);
            this.lblFechaFacturaOrigen.TabIndex = 0;
            this.lblFechaFacturaOrigen.Text = "Fecha:";
            // 
            // gbDatosCliente
            // 
            this.gbDatosCliente.Controls.Add(this.txtIDCliente);
            this.gbDatosCliente.Controls.Add(this.lblIDCliente);
            this.gbDatosCliente.Controls.Add(this.txtCategoriaCliente);
            this.gbDatosCliente.Controls.Add(this.lblCategoriaCliente);
            this.gbDatosCliente.Controls.Add(this.txtSaldoCliente);
            this.gbDatosCliente.Controls.Add(this.lblSaldoCliente);
            this.gbDatosCliente.Location = new System.Drawing.Point(524, 12);
            this.gbDatosCliente.Name = "gbDatosCliente";
            this.gbDatosCliente.Size = new System.Drawing.Size(250, 155);
            this.gbDatosCliente.TabIndex = 2;
            this.gbDatosCliente.TabStop = false;
            this.gbDatosCliente.Text = "Datos del Cliente (Sistema)";
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
            // txtSaldoCliente
            // 
            this.txtSaldoCliente.Location = new System.Drawing.Point(120, 75);
            this.txtSaldoCliente.Name = "txtSaldoCliente";
            this.txtSaldoCliente.ReadOnly = true;
            this.txtSaldoCliente.Size = new System.Drawing.Size(120, 20);
            this.txtSaldoCliente.TabIndex = 1;
            this.txtSaldoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSaldoCliente
            // 
            this.lblSaldoCliente.AutoSize = true;
            this.lblSaldoCliente.Location = new System.Drawing.Point(16, 78);
            this.lblSaldoCliente.Name = "lblSaldoCliente";
            this.lblSaldoCliente.Size = new System.Drawing.Size(37, 13);
            this.lblSaldoCliente.TabIndex = 0;
            this.lblSaldoCliente.Text = "Saldo:";
            // 
            // gbDatosSistema
            // 
            this.gbDatosSistema.Controls.Add(this.txtVendedor);
            this.gbDatosSistema.Controls.Add(this.lblVendedor);
            this.gbDatosSistema.Controls.Add(this.cmbMotivo);
            this.gbDatosSistema.Controls.Add(this.lblMotivo);
            this.gbDatosSistema.Controls.Add(this.txtCanalVenta);
            this.gbDatosSistema.Controls.Add(this.lblCanalVenta);
            this.gbDatosSistema.Location = new System.Drawing.Point(268, 12);
            this.gbDatosSistema.Name = "gbDatosSistema";
            this.gbDatosSistema.Size = new System.Drawing.Size(250, 155);
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
            // cmbMotivo
            // 
            this.cmbMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotivo.FormattingEnabled = true;
            this.cmbMotivo.Items.AddRange(new object[] {
            "Intereses por mora",
            "Gastos administrativos",
            "Ajustes de precios",
            "Servicios adicionales",
            "Diferencias de cambio",
            "Otros conceptos"});
            this.cmbMotivo.Location = new System.Drawing.Point(120, 50);
            this.cmbMotivo.Name = "cmbMotivo";
            this.cmbMotivo.Size = new System.Drawing.Size(120, 21);
            this.cmbMotivo.TabIndex = 3;
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(16, 53);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(42, 13);
            this.lblMotivo.TabIndex = 2;
            this.lblMotivo.Text = "Motivo:";
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
            this.gbControlInterno.Controls.Add(this.txtIDNotaDebito);
            this.gbControlInterno.Controls.Add(this.lblIDNotaDebito);
            this.gbControlInterno.Location = new System.Drawing.Point(12, 12);
            this.gbControlInterno.Name = "gbControlInterno";
            this.gbControlInterno.Size = new System.Drawing.Size(250, 155);
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
            "Aprobada",
            "Aplicada",
            "Cobrada",
            "Anulada",
            "Contabilizada"});
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
            // txtIDNotaDebito
            // 
            this.txtIDNotaDebito.Location = new System.Drawing.Point(120, 25);
            this.txtIDNotaDebito.Name = "txtIDNotaDebito";
            this.txtIDNotaDebito.ReadOnly = true;
            this.txtIDNotaDebito.Size = new System.Drawing.Size(120, 20);
            this.txtIDNotaDebito.TabIndex = 1;
            // 
            // lblIDNotaDebito
            // 
            this.lblIDNotaDebito.AutoSize = true;
            this.lblIDNotaDebito.Location = new System.Drawing.Point(16, 28);
            this.lblIDNotaDebito.Name = "lblIDNotaDebito";
            this.lblIDNotaDebito.Size = new System.Drawing.Size(21, 13);
            this.lblIDNotaDebito.TabIndex = 0;
            this.lblIDNotaDebito.Text = "ID:";
            // 
            // pnlDetalle
            // 
            this.pnlDetalle.Controls.Add(this.dgvDetalleRegistro);
            this.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetalle.Location = new System.Drawing.Point(0, 180);
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
            this.colIDConcepto,
            this.colConcepto,
            this.colDescripcion,
            this.colCantidad,
            this.colUnidad,
            this.colPrecioUnitario,
            this.colCostoUnitario,
            this.colMargen,
            this.colTipoMovimiento,
            this.colAfectaStock});
            this.dgvDetalleRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalleRegistro.Location = new System.Drawing.Point(0, 0);
            this.dgvDetalleRegistro.Name = "dgvDetalleRegistro";
            this.dgvDetalleRegistro.ReadOnly = true;
            this.dgvDetalleRegistro.Size = new System.Drawing.Size(984, 301);
            this.dgvDetalleRegistro.TabIndex = 0;
            // 
            // colIDConcepto
            // 
            this.colIDConcepto.HeaderText = "ID Concepto";
            this.colIDConcepto.Name = "colIDConcepto";
            this.colIDConcepto.ReadOnly = true;
            this.colIDConcepto.Visible = false;
            // 
            // colConcepto
            // 
            this.colConcepto.HeaderText = "Concepto";
            this.colConcepto.Name = "colConcepto";
            this.colConcepto.ReadOnly = true;
            this.colConcepto.Width = 150;
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
            // colTipoMovimiento
            // 
            this.colTipoMovimiento.HeaderText = "Tipo Movimiento";
            this.colTipoMovimiento.Name = "colTipoMovimiento";
            this.colTipoMovimiento.ReadOnly = true;
            this.colTipoMovimiento.Width = 120;
            // 
            // colAfectaStock
            // 
            this.colAfectaStock.HeaderText = "Afecta Stock";
            this.colAfectaStock.Name = "colAfectaStock";
            this.colAfectaStock.ReadOnly = true;
            this.colAfectaStock.Width = 90;
            // 
            // pnlAuditoria
            // 
            this.pnlAuditoria.Controls.Add(this.gbAuditoria);
            this.pnlAuditoria.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAuditoria.Location = new System.Drawing.Point(0, 481);
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
            this.pnlResumen.Location = new System.Drawing.Point(0, 541);
            this.pnlResumen.Name = "pnlResumen";
            this.pnlResumen.Size = new System.Drawing.Size(984, 70);
            this.pnlResumen.TabIndex = 3;
            // 
            // gbResumen
            // 
            this.gbResumen.Controls.Add(this.txtTotalDebito);
            this.gbResumen.Controls.Add(this.lblTotalDebito);
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
            // txtTotalDebito
            // 
            this.txtTotalDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDebito.Location = new System.Drawing.Point(470, 20);
            this.txtTotalDebito.Name = "txtTotalDebito";
            this.txtTotalDebito.ReadOnly = true;
            this.txtTotalDebito.Size = new System.Drawing.Size(90, 21);
            this.txtTotalDebito.TabIndex = 7;
            this.txtTotalDebito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalDebito
            // 
            this.lblTotalDebito.AutoSize = true;
            this.lblTotalDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDebito.Location = new System.Drawing.Point(460, 23);
            this.lblTotalDebito.Name = "lblTotalDebito";
            this.lblTotalDebito.Size = new System.Drawing.Size(11, 15);
            this.lblTotalDebito.TabIndex = 6;
            this.lblTotalDebito.Text = ".";
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
            this.pnlBotones.Controls.Add(this.btnVerMovimientos);
            this.pnlBotones.Controls.Add(this.btnAplicarCobro);
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Controls.Add(this.btnConfirmar);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotones.Location = new System.Drawing.Point(0, 611);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(984, 50);
            this.pnlBotones.TabIndex = 4;
            // 
            // btnAuditoriaCompleta
            // 
            this.btnAuditoriaCompleta.Location = new System.Drawing.Point(32, 15);
            this.btnAuditoriaCompleta.Name = "btnAuditoriaCompleta";
            this.btnAuditoriaCompleta.Size = new System.Drawing.Size(100, 23);
            this.btnAuditoriaCompleta.TabIndex = 4;
            this.btnAuditoriaCompleta.Text = "Auditoría Completa";
            this.btnAuditoriaCompleta.UseVisualStyleBackColor = true;
            // 
            // btnVerMovimientos
            // 
            this.btnVerMovimientos.Location = new System.Drawing.Point(138, 15);
            this.btnVerMovimientos.Name = "btnVerMovimientos";
            this.btnVerMovimientos.Size = new System.Drawing.Size(120, 23);
            this.btnVerMovimientos.TabIndex = 3;
            this.btnVerMovimientos.Text = "Ver Movimientos";
            this.btnVerMovimientos.UseVisualStyleBackColor = true;
            // 
            // btnAplicarCobro
            // 
            this.btnAplicarCobro.BackColor = System.Drawing.Color.LightCoral;
            this.btnAplicarCobro.Location = new System.Drawing.Point(264, 15);
            this.btnAplicarCobro.Name = "btnAplicarCobro";
            this.btnAplicarCobro.Size = new System.Drawing.Size(120, 23);
            this.btnAplicarCobro.TabIndex = 2;
            this.btnAplicarCobro.Text = "Aplicar a Cobro";
            this.btnAplicarCobro.UseVisualStyleBackColor = false;
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
            // frmRegistroNotaDebito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.pnlDetalle);
            this.Controls.Add(this.pnlAuditoria);
            this.Controls.Add(this.pnlResumen);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlCabecera);
            this.Name = "frmRegistroNotaDebito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro - Nota de Débito ";
            this.pnlCabecera.ResumeLayout(false);
            this.gbComprobanteOrigen.ResumeLayout(false);
            this.gbComprobanteOrigen.PerformLayout();
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
        private System.Windows.Forms.TextBox txtIDNotaDebito;
        private System.Windows.Forms.Label lblIDNotaDebito;
        private System.Windows.Forms.GroupBox gbDatosSistema;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.ComboBox cmbMotivo;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox txtCanalVenta;
        private System.Windows.Forms.Label lblCanalVenta;
        private System.Windows.Forms.GroupBox gbDatosCliente;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.Label lblIDCliente;
        private System.Windows.Forms.TextBox txtCategoriaCliente;
        private System.Windows.Forms.Label lblCategoriaCliente;
        private System.Windows.Forms.TextBox txtSaldoCliente;
        private System.Windows.Forms.Label lblSaldoCliente;
        private System.Windows.Forms.GroupBox gbComprobanteOrigen;
        private System.Windows.Forms.TextBox txtIDFacturaOrigen;
        private System.Windows.Forms.Label lblIDFacturaOrigen;
        private System.Windows.Forms.TextBox txtNumeroFacturaOrigen;
        private System.Windows.Forms.Label lblNumeroFacturaOrigen;
        private System.Windows.Forms.TextBox txtFechaFacturaOrigen;
        private System.Windows.Forms.Label lblFechaFacturaOrigen;
        private System.Windows.Forms.Panel pnlDetalle;
        private System.Windows.Forms.DataGridView dgvDetalleRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDConcepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConcepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCostoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMargen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAfectaStock;
        private System.Windows.Forms.Panel pnlAuditoria;
        private System.Windows.Forms.GroupBox gbAuditoria;
        private System.Windows.Forms.TextBox txtUsuarioModificacion;
        private System.Windows.Forms.Label lblUsuarioModificacion;
        private System.Windows.Forms.TextBox txtFechaHoraModificacion;
        private System.Windows.Forms.Label lblFechaHoraModificacion;
        private System.Windows.Forms.Panel pnlResumen;
        private System.Windows.Forms.GroupBox gbResumen;
        private System.Windows.Forms.TextBox txtTotalDebito;
        private System.Windows.Forms.Label lblTotalDebito;
        private System.Windows.Forms.TextBox txtMargenTotal;
        private System.Windows.Forms.Label lblMargenTotal;
        private System.Windows.Forms.TextBox txtCostoTotal;
        private System.Windows.Forms.Label lblCostoTotal;
        private System.Windows.Forms.TextBox txtCantidadItems;
        private System.Windows.Forms.Label lblCantidadItems;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnAuditoriaCompleta;
        private System.Windows.Forms.Button btnVerMovimientos;
        private System.Windows.Forms.Button btnAplicarCobro;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
    }
}