namespace Vista.frmGI.NotaCredito
{
    partial class frmRegistroNotaCredito
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
            this.gbDatosCliente = new System.Windows.Forms.GroupBox();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.lblIDCliente = new System.Windows.Forms.Label();
            this.txtCategoriaCliente = new System.Windows.Forms.TextBox();
            this.lblCategoriaCliente = new System.Windows.Forms.Label();
            this.txtSaldoCliente = new System.Windows.Forms.TextBox();
            this.lblSaldoCliente = new System.Windows.Forms.Label();
            this.gbComprobanteOrigen = new System.Windows.Forms.GroupBox();
            this.txtIDFacturaOrigen = new System.Windows.Forms.TextBox();
            this.lblIDFacturaOrigen = new System.Windows.Forms.Label();
            this.txtNumeroFacturaOrigen = new System.Windows.Forms.TextBox();
            this.lblNumeroFacturaOrigen = new System.Windows.Forms.Label();
            this.txtFechaFacturaOrigen = new System.Windows.Forms.TextBox();
            this.lblFechaFacturaOrigen = new System.Windows.Forms.Label();
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
            this.colTipoMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAfectaStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlResumen = new System.Windows.Forms.Panel();
            this.gbResumen = new System.Windows.Forms.GroupBox();
            this.txtTotalCredito = new System.Windows.Forms.TextBox();
            this.lblTotalCredito = new System.Windows.Forms.Label();
            this.txtMargenTotal = new System.Windows.Forms.TextBox();
            this.lblMargenTotal = new System.Windows.Forms.Label();
            this.txtCostoTotal = new System.Windows.Forms.TextBox();
            this.lblCostoTotal = new System.Windows.Forms.Label();
            this.txtCantidadItems = new System.Windows.Forms.TextBox();
            this.lblCantidadItems = new System.Windows.Forms.Label();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnVerMovimientos = new System.Windows.Forms.Button();
            this.btnAjustarStock = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gbDatosCliente.SuspendLayout();
            this.gbComprobanteOrigen.SuspendLayout();
            this.pnlDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleRegistro)).BeginInit();
            this.pnlResumen.SuspendLayout();
            this.gbResumen.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatosCliente
            // 
            this.gbDatosCliente.Controls.Add(this.txtIDCliente);
            this.gbDatosCliente.Controls.Add(this.lblIDCliente);
            this.gbDatosCliente.Controls.Add(this.txtCategoriaCliente);
            this.gbDatosCliente.Controls.Add(this.lblCategoriaCliente);
            this.gbDatosCliente.Controls.Add(this.txtSaldoCliente);
            this.gbDatosCliente.Controls.Add(this.lblSaldoCliente);
            this.gbDatosCliente.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosCliente.Location = new System.Drawing.Point(21, 105);
            this.gbDatosCliente.Name = "gbDatosCliente";
            this.gbDatosCliente.Size = new System.Drawing.Size(450, 180);
            this.gbDatosCliente.TabIndex = 3;
            this.gbDatosCliente.TabStop = false;
            this.gbDatosCliente.Text = "DATOS DEL CLIENTE (SISTEMA)";
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCliente.Location = new System.Drawing.Point(140, 40);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.ReadOnly = true;
            this.txtIDCliente.Size = new System.Drawing.Size(280, 26);
            this.txtIDCliente.TabIndex = 5;
            // 
            // lblIDCliente
            // 
            this.lblIDCliente.AutoSize = true;
            this.lblIDCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCliente.Location = new System.Drawing.Point(20, 43);
            this.lblIDCliente.Name = "lblIDCliente";
            this.lblIDCliente.Size = new System.Drawing.Size(108, 19);
            this.lblIDCliente.TabIndex = 4;
            this.lblIDCliente.Text = "ID Cliente:";
            // 
            // txtCategoriaCliente
            // 
            this.txtCategoriaCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoriaCliente.Location = new System.Drawing.Point(140, 80);
            this.txtCategoriaCliente.Name = "txtCategoriaCliente";
            this.txtCategoriaCliente.ReadOnly = true;
            this.txtCategoriaCliente.Size = new System.Drawing.Size(280, 26);
            this.txtCategoriaCliente.TabIndex = 3;
            // 
            // lblCategoriaCliente
            // 
            this.lblCategoriaCliente.AutoSize = true;
            this.lblCategoriaCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaCliente.Location = new System.Drawing.Point(20, 83);
            this.lblCategoriaCliente.Name = "lblCategoriaCliente";
            this.lblCategoriaCliente.Size = new System.Drawing.Size(99, 19);
            this.lblCategoriaCliente.TabIndex = 2;
            this.lblCategoriaCliente.Text = "Categoría:";
            // 
            // txtSaldoCliente
            // 
            this.txtSaldoCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoCliente.Location = new System.Drawing.Point(140, 120);
            this.txtSaldoCliente.Name = "txtSaldoCliente";
            this.txtSaldoCliente.ReadOnly = true;
            this.txtSaldoCliente.Size = new System.Drawing.Size(200, 26);
            this.txtSaldoCliente.TabIndex = 1;
            this.txtSaldoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSaldoCliente
            // 
            this.lblSaldoCliente.AutoSize = true;
            this.lblSaldoCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoCliente.Location = new System.Drawing.Point(20, 123);
            this.lblSaldoCliente.Name = "lblSaldoCliente";
            this.lblSaldoCliente.Size = new System.Drawing.Size(63, 19);
            this.lblSaldoCliente.TabIndex = 0;
            this.lblSaldoCliente.Text = "Saldo:";
            // 
            // gbComprobanteOrigen
            // 
            this.gbComprobanteOrigen.Controls.Add(this.txtIDFacturaOrigen);
            this.gbComprobanteOrigen.Controls.Add(this.lblIDFacturaOrigen);
            this.gbComprobanteOrigen.Controls.Add(this.txtNumeroFacturaOrigen);
            this.gbComprobanteOrigen.Controls.Add(this.lblNumeroFacturaOrigen);
            this.gbComprobanteOrigen.Controls.Add(this.txtFechaFacturaOrigen);
            this.gbComprobanteOrigen.Controls.Add(this.lblFechaFacturaOrigen);
            this.gbComprobanteOrigen.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbComprobanteOrigen.Location = new System.Drawing.Point(501, 105);
            this.gbComprobanteOrigen.Name = "gbComprobanteOrigen";
            this.gbComprobanteOrigen.Size = new System.Drawing.Size(450, 180);
            this.gbComprobanteOrigen.TabIndex = 4;
            this.gbComprobanteOrigen.TabStop = false;
            this.gbComprobanteOrigen.Text = "COMPROBANTE ORIGEN";
            // 
            // txtIDFacturaOrigen
            // 
            this.txtIDFacturaOrigen.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDFacturaOrigen.Location = new System.Drawing.Point(140, 40);
            this.txtIDFacturaOrigen.Name = "txtIDFacturaOrigen";
            this.txtIDFacturaOrigen.ReadOnly = true;
            this.txtIDFacturaOrigen.Size = new System.Drawing.Size(120, 26);
            this.txtIDFacturaOrigen.TabIndex = 5;
            // 
            // lblIDFacturaOrigen
            // 
            this.lblIDFacturaOrigen.AutoSize = true;
            this.lblIDFacturaOrigen.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDFacturaOrigen.Location = new System.Drawing.Point(20, 43);
            this.lblIDFacturaOrigen.Name = "lblIDFacturaOrigen";
            this.lblIDFacturaOrigen.Size = new System.Drawing.Size(36, 19);
            this.lblIDFacturaOrigen.TabIndex = 4;
            this.lblIDFacturaOrigen.Text = "ID:";
            // 
            // txtNumeroFacturaOrigen
            // 
            this.txtNumeroFacturaOrigen.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroFacturaOrigen.Location = new System.Drawing.Point(140, 120);
            this.txtNumeroFacturaOrigen.Name = "txtNumeroFacturaOrigen";
            this.txtNumeroFacturaOrigen.ReadOnly = true;
            this.txtNumeroFacturaOrigen.Size = new System.Drawing.Size(280, 26);
            this.txtNumeroFacturaOrigen.TabIndex = 3;
            this.txtNumeroFacturaOrigen.Text = "FAC-00000001";
            // 
            // lblNumeroFacturaOrigen
            // 
            this.lblNumeroFacturaOrigen.AutoSize = true;
            this.lblNumeroFacturaOrigen.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroFacturaOrigen.Location = new System.Drawing.Point(20, 123);
            this.lblNumeroFacturaOrigen.Name = "lblNumeroFacturaOrigen";
            this.lblNumeroFacturaOrigen.Size = new System.Drawing.Size(72, 19);
            this.lblNumeroFacturaOrigen.TabIndex = 2;
            this.lblNumeroFacturaOrigen.Text = "Número:";
            // 
            // txtFechaFacturaOrigen
            // 
            this.txtFechaFacturaOrigen.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaFacturaOrigen.Location = new System.Drawing.Point(140, 80);
            this.txtFechaFacturaOrigen.Name = "txtFechaFacturaOrigen";
            this.txtFechaFacturaOrigen.ReadOnly = true;
            this.txtFechaFacturaOrigen.Size = new System.Drawing.Size(200, 26);
            this.txtFechaFacturaOrigen.TabIndex = 1;
            // 
            // lblFechaFacturaOrigen
            // 
            this.lblFechaFacturaOrigen.AutoSize = true;
            this.lblFechaFacturaOrigen.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFacturaOrigen.Location = new System.Drawing.Point(20, 83);
            this.lblFechaFacturaOrigen.Name = "lblFechaFacturaOrigen";
            this.lblFechaFacturaOrigen.Size = new System.Drawing.Size(63, 19);
            this.lblFechaFacturaOrigen.TabIndex = 0;
            this.lblFechaFacturaOrigen.Text = "Fecha:";
            // 
            // pnlDetalle
            // 
            this.pnlDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDetalle.Controls.Add(this.dgvDetalleRegistro);
            this.pnlDetalle.Location = new System.Drawing.Point(21, 305);
            this.pnlDetalle.Name = "pnlDetalle";
            this.pnlDetalle.Size = new System.Drawing.Size(930, 0);
            this.pnlDetalle.TabIndex = 5;
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
            this.colTipoMovimiento,
            this.colAfectaStock});
            this.dgvDetalleRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalleRegistro.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetalleRegistro.Location = new System.Drawing.Point(0, 0);
            this.dgvDetalleRegistro.Name = "dgvDetalleRegistro";
            this.dgvDetalleRegistro.ReadOnly = true;
            this.dgvDetalleRegistro.Size = new System.Drawing.Size(930, 0);
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
            this.colMargen.Width = 90;
            // 
            // colTipoMovimiento
            // 
            this.colTipoMovimiento.HeaderText = "TIPO MOVIMIENTO";
            this.colTipoMovimiento.Name = "colTipoMovimiento";
            this.colTipoMovimiento.ReadOnly = true;
            this.colTipoMovimiento.Width = 150;
            // 
            // colAfectaStock
            // 
            this.colAfectaStock.HeaderText = "AFECTA STOCK";
            this.colAfectaStock.Name = "colAfectaStock";
            this.colAfectaStock.ReadOnly = true;
            this.colAfectaStock.Width = 120;
            // 
            // pnlResumen
            // 
            this.pnlResumen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlResumen.Controls.Add(this.gbResumen);
            this.pnlResumen.Location = new System.Drawing.Point(21, 301);
            this.pnlResumen.Name = "pnlResumen";
            this.pnlResumen.Size = new System.Drawing.Size(884, 80);
            this.pnlResumen.TabIndex = 6;
            // 
            // gbResumen
            // 
            this.gbResumen.Controls.Add(this.txtTotalCredito);
            this.gbResumen.Controls.Add(this.lblTotalCredito);
            this.gbResumen.Controls.Add(this.txtMargenTotal);
            this.gbResumen.Controls.Add(this.lblMargenTotal);
            this.gbResumen.Controls.Add(this.txtCostoTotal);
            this.gbResumen.Controls.Add(this.lblCostoTotal);
            this.gbResumen.Controls.Add(this.txtCantidadItems);
            this.gbResumen.Controls.Add(this.lblCantidadItems);
            this.gbResumen.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResumen.Location = new System.Drawing.Point(0, 10);
            this.gbResumen.Name = "gbResumen";
            this.gbResumen.Size = new System.Drawing.Size(858, 60);
            this.gbResumen.TabIndex = 0;
            this.gbResumen.TabStop = false;
            this.gbResumen.Text = "RESUMEN INTERNO";
            // 
            // txtTotalCredito
            // 
            this.txtTotalCredito.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCredito.Location = new System.Drawing.Point(610, 24);
            this.txtTotalCredito.Name = "txtTotalCredito";
            this.txtTotalCredito.ReadOnly = true;
            this.txtTotalCredito.Size = new System.Drawing.Size(120, 30);
            this.txtTotalCredito.TabIndex = 7;
            this.txtTotalCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalCredito
            // 
            this.lblTotalCredito.AutoSize = true;
            this.lblTotalCredito.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCredito.Location = new System.Drawing.Point(540, 29);
            this.lblTotalCredito.Name = "lblTotalCredito";
            this.lblTotalCredito.Size = new System.Drawing.Size(63, 19);
            this.lblTotalCredito.TabIndex = 6;
            this.lblTotalCredito.Text = "Total:";
            // 
            // txtMargenTotal
            // 
            this.txtMargenTotal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMargenTotal.Location = new System.Drawing.Point(450, 29);
            this.txtMargenTotal.Name = "txtMargenTotal";
            this.txtMargenTotal.ReadOnly = true;
            this.txtMargenTotal.Size = new System.Drawing.Size(80, 26);
            this.txtMargenTotal.TabIndex = 5;
            this.txtMargenTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMargenTotal
            // 
            this.lblMargenTotal.AutoSize = true;
            this.lblMargenTotal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMargenTotal.Location = new System.Drawing.Point(380, 32);
            this.lblMargenTotal.Name = "lblMargenTotal";
            this.lblMargenTotal.Size = new System.Drawing.Size(72, 19);
            this.lblMargenTotal.TabIndex = 4;
            this.lblMargenTotal.Text = "Margen:";
            // 
            // txtCostoTotal
            // 
            this.txtCostoTotal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoTotal.Location = new System.Drawing.Point(290, 29);
            this.txtCostoTotal.Name = "txtCostoTotal";
            this.txtCostoTotal.ReadOnly = true;
            this.txtCostoTotal.Size = new System.Drawing.Size(80, 26);
            this.txtCostoTotal.TabIndex = 3;
            this.txtCostoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCostoTotal
            // 
            this.lblCostoTotal.AutoSize = true;
            this.lblCostoTotal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoTotal.Location = new System.Drawing.Point(230, 32);
            this.lblCostoTotal.Name = "lblCostoTotal";
            this.lblCostoTotal.Size = new System.Drawing.Size(63, 19);
            this.lblCostoTotal.TabIndex = 2;
            this.lblCostoTotal.Text = "Costo:";
            // 
            // txtCantidadItems
            // 
            this.txtCantidadItems.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadItems.Location = new System.Drawing.Point(190, 29);
            this.txtCantidadItems.Name = "txtCantidadItems";
            this.txtCantidadItems.ReadOnly = true;
            this.txtCantidadItems.Size = new System.Drawing.Size(30, 26);
            this.txtCantidadItems.TabIndex = 1;
            this.txtCantidadItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCantidadItems
            // 
            this.lblCantidadItems.AutoSize = true;
            this.lblCantidadItems.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadItems.Location = new System.Drawing.Point(150, 32);
            this.lblCantidadItems.Name = "lblCantidadItems";
            this.lblCantidadItems.Size = new System.Drawing.Size(63, 19);
            this.lblCantidadItems.TabIndex = 0;
            this.lblCantidadItems.Text = "Items:";
            
            // 
            // pnlBotones
            // 
            this.pnlBotones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBotones.Controls.Add(this.btnVerMovimientos);
            this.pnlBotones.Controls.Add(this.btnAjustarStock);
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Controls.Add(this.btnConfirmar);
            this.pnlBotones.Location = new System.Drawing.Point(21, 401);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(930, 60);
            this.pnlBotones.TabIndex = 8;
            // 
            // btnVerMovimientos
            // 
            this.btnVerMovimientos.BackColor = System.Drawing.Color.LightYellow;
            this.btnVerMovimientos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerMovimientos.Location = new System.Drawing.Point(50, 15);
            this.btnVerMovimientos.Name = "btnVerMovimientos";
            this.btnVerMovimientos.Size = new System.Drawing.Size(180, 35);
            this.btnVerMovimientos.TabIndex = 3;
            this.btnVerMovimientos.Text = "VER MOVIMIENTOS";
            this.btnVerMovimientos.UseVisualStyleBackColor = false;
            // 
            // btnAjustarStock
            // 
            this.btnAjustarStock.BackColor = System.Drawing.Color.LightGreen;
            this.btnAjustarStock.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjustarStock.Location = new System.Drawing.Point(270, 15);
            this.btnAjustarStock.Name = "btnAjustarStock";
            this.btnAjustarStock.Size = new System.Drawing.Size(150, 35);
            this.btnAjustarStock.TabIndex = 2;
            this.btnAjustarStock.Text = "AJUSTAR STOCK";
            this.btnAjustarStock.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancelar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(830, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 35);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "CERRAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.LightGreen;
            this.btnConfirmar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(730, 15);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(90, 35);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.RoyalBlue;
            this.label2.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(108, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(797, 49);
            this.label2.TabIndex = 13;
            this.label2.Text = "Registro de Nota de Credito";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmRegistroNotaCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 687);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlResumen);
            this.Controls.Add(this.pnlDetalle);
            this.Controls.Add(this.gbComprobanteOrigen);
            this.Controls.Add(this.gbDatosCliente);
            this.MinimumSize = new System.Drawing.Size(1000, 726);
            this.Name = "frmRegistroNotaCredito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro - Nota de Crédito";
            this.gbDatosCliente.ResumeLayout(false);
            this.gbDatosCliente.PerformLayout();
            this.gbComprobanteOrigen.ResumeLayout(false);
            this.gbComprobanteOrigen.PerformLayout();
            this.pnlDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleRegistro)).EndInit();
            this.pnlResumen.ResumeLayout(false);
            this.gbResumen.ResumeLayout(false);
            this.gbResumen.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCostoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMargen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAfectaStock;
        private System.Windows.Forms.Panel pnlResumen;
        private System.Windows.Forms.GroupBox gbResumen;
        private System.Windows.Forms.TextBox txtTotalCredito;
        private System.Windows.Forms.Label lblTotalCredito;
        private System.Windows.Forms.TextBox txtMargenTotal;
        private System.Windows.Forms.Label lblMargenTotal;
        private System.Windows.Forms.TextBox txtCostoTotal;
        private System.Windows.Forms.Label lblCostoTotal;
        private System.Windows.Forms.TextBox txtCantidadItems;
        private System.Windows.Forms.Label lblCantidadItems;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnVerMovimientos;
        private System.Windows.Forms.Button btnAjustarStock;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label2;
    }
}