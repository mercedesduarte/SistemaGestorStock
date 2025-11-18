namespace Vista.frmGI.Presupuesto
{
    partial class frmEmisionPresupuesto
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
            this.gbDatosPresupuesto = new System.Windows.Forms.GroupBox();
            this.nudDiasValidez = new System.Windows.Forms.NumericUpDown();
            this.lblDiasValidez = new System.Windows.Forms.Label();
            this.txtNumeroPresupuesto = new System.Windows.Forms.TextBox();
            this.lblNumeroPresupuesto = new System.Windows.Forms.Label();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.dtpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.lblFechaEmision = new System.Windows.Forms.Label();
            this.gbDatosCliente = new System.Windows.Forms.GroupBox();
            this.txtCondicionVenta = new System.Windows.Forms.TextBox();
            this.lblCondicionVenta = new System.Windows.Forms.Label();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.lblTelefonoCliente = new System.Windows.Forms.Label();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.lblEmailCliente = new System.Windows.Forms.Label();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.lblDireccionCliente = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.gbDatosProducto = new System.Windows.Forms.GroupBox();
            this.txtStockActual = new System.Windows.Forms.TextBox();
            this.lblStockActual = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.pnlDetalle = new System.Windows.Forms.Panel();
            this.dgvDetallePresupuesto = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTotales = new System.Windows.Forms.Panel();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnConvertirPedido = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDatosPresupuesto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiasValidez)).BeginInit();
            this.gbDatosCliente.SuspendLayout();
            this.gbDatosProducto.SuspendLayout();
            this.pnlDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePresupuesto)).BeginInit();
            this.pnlTotales.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatosPresupuesto
            // 
            this.gbDatosPresupuesto.Controls.Add(this.nudDiasValidez);
            this.gbDatosPresupuesto.Controls.Add(this.lblDiasValidez);
            this.gbDatosPresupuesto.Controls.Add(this.txtNumeroPresupuesto);
            this.gbDatosPresupuesto.Controls.Add(this.lblNumeroPresupuesto);
            this.gbDatosPresupuesto.Controls.Add(this.dtpFechaVencimiento);
            this.gbDatosPresupuesto.Controls.Add(this.lblFechaVencimiento);
            this.gbDatosPresupuesto.Controls.Add(this.dtpFechaEmision);
            this.gbDatosPresupuesto.Controls.Add(this.lblFechaEmision);
            this.gbDatosPresupuesto.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosPresupuesto.Location = new System.Drawing.Point(20, 80);
            this.gbDatosPresupuesto.Name = "gbDatosPresupuesto";
            this.gbDatosPresupuesto.Size = new System.Drawing.Size(450, 180);
            this.gbDatosPresupuesto.TabIndex = 1;
            this.gbDatosPresupuesto.TabStop = false;
            this.gbDatosPresupuesto.Text = "DATOS DEL PRESUPUESTO";
            // 
            // nudDiasValidez
            // 
            this.nudDiasValidez.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDiasValidez.Location = new System.Drawing.Point(140, 120);
            this.nudDiasValidez.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nudDiasValidez.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDiasValidez.Name = "nudDiasValidez";
            this.nudDiasValidez.Size = new System.Drawing.Size(60, 26);
            this.nudDiasValidez.TabIndex = 7;
            this.nudDiasValidez.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // lblDiasValidez
            // 
            this.lblDiasValidez.AutoSize = true;
            this.lblDiasValidez.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasValidez.Location = new System.Drawing.Point(20, 123);
            this.lblDiasValidez.Name = "lblDiasValidez";
            this.lblDiasValidez.Size = new System.Drawing.Size(126, 19);
            this.lblDiasValidez.TabIndex = 6;
            this.lblDiasValidez.Text = "Días Validez:";
            // 
            // txtNumeroPresupuesto
            // 
            this.txtNumeroPresupuesto.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroPresupuesto.Location = new System.Drawing.Point(140, 40);
            this.txtNumeroPresupuesto.Name = "txtNumeroPresupuesto";
            this.txtNumeroPresupuesto.ReadOnly = true;
            this.txtNumeroPresupuesto.Size = new System.Drawing.Size(200, 26);
            this.txtNumeroPresupuesto.TabIndex = 5;
            this.txtNumeroPresupuesto.Text = "PRE-00000001";
            // 
            // lblNumeroPresupuesto
            // 
            this.lblNumeroPresupuesto.AutoSize = true;
            this.lblNumeroPresupuesto.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroPresupuesto.Location = new System.Drawing.Point(20, 43);
            this.lblNumeroPresupuesto.Name = "lblNumeroPresupuesto";
            this.lblNumeroPresupuesto.Size = new System.Drawing.Size(72, 19);
            this.lblNumeroPresupuesto.TabIndex = 4;
            this.lblNumeroPresupuesto.Text = "Número:";
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(140, 120);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(200, 26);
            this.dtpFechaVencimiento.TabIndex = 3;
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVencimiento.Location = new System.Drawing.Point(20, 123);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(108, 19);
            this.lblFechaVencimiento.TabIndex = 2;
            this.lblFechaVencimiento.Text = "Vencimiento:";
            // 
            // dtpFechaEmision
            // 
            this.dtpFechaEmision.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEmision.Location = new System.Drawing.Point(140, 80);
            this.dtpFechaEmision.Name = "dtpFechaEmision";
            this.dtpFechaEmision.Size = new System.Drawing.Size(200, 26);
            this.dtpFechaEmision.TabIndex = 1;
            // 
            // lblFechaEmision
            // 
            this.lblFechaEmision.AutoSize = true;
            this.lblFechaEmision.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEmision.Location = new System.Drawing.Point(20, 83);
            this.lblFechaEmision.Name = "lblFechaEmision";
            this.lblFechaEmision.Size = new System.Drawing.Size(126, 19);
            this.lblFechaEmision.TabIndex = 0;
            this.lblFechaEmision.Text = "Fecha Emisión:";
            // 
            // gbDatosCliente
            // 
            this.gbDatosCliente.Controls.Add(this.txtCondicionVenta);
            this.gbDatosCliente.Controls.Add(this.lblCondicionVenta);
            this.gbDatosCliente.Controls.Add(this.txtTelefonoCliente);
            this.gbDatosCliente.Controls.Add(this.lblTelefonoCliente);
            this.gbDatosCliente.Controls.Add(this.txtEmailCliente);
            this.gbDatosCliente.Controls.Add(this.lblEmailCliente);
            this.gbDatosCliente.Controls.Add(this.txtDireccionCliente);
            this.gbDatosCliente.Controls.Add(this.lblDireccionCliente);
            this.gbDatosCliente.Controls.Add(this.txtNombreCliente);
            this.gbDatosCliente.Controls.Add(this.lblNombreCliente);
            this.gbDatosCliente.Controls.Add(this.btnBuscarCliente);
            this.gbDatosCliente.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosCliente.Location = new System.Drawing.Point(500, 80);
            this.gbDatosCliente.Name = "gbDatosCliente";
            this.gbDatosCliente.Size = new System.Drawing.Size(450, 180);
            this.gbDatosCliente.TabIndex = 2;
            this.gbDatosCliente.TabStop = false;
            this.gbDatosCliente.Text = "DATOS DEL CLIENTE";
            // 
            // txtCondicionVenta
            // 
            this.txtCondicionVenta.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCondicionVenta.Location = new System.Drawing.Point(140, 120);
            this.txtCondicionVenta.Name = "txtCondicionVenta";
            this.txtCondicionVenta.Size = new System.Drawing.Size(200, 26);
            this.txtCondicionVenta.TabIndex = 10;
            this.txtCondicionVenta.Text = "Contado";
            // 
            // lblCondicionVenta
            // 
            this.lblCondicionVenta.AutoSize = true;
            this.lblCondicionVenta.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondicionVenta.Location = new System.Drawing.Point(20, 123);
            this.lblCondicionVenta.Name = "lblCondicionVenta";
            this.lblCondicionVenta.Size = new System.Drawing.Size(117, 19);
            this.lblCondicionVenta.TabIndex = 9;
            this.lblCondicionVenta.Text = "Cond. Venta:";
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoCliente.Location = new System.Drawing.Point(140, 90);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.ReadOnly = true;
            this.txtTelefonoCliente.Size = new System.Drawing.Size(200, 26);
            this.txtTelefonoCliente.TabIndex = 8;
            // 
            // lblTelefonoCliente
            // 
            this.lblTelefonoCliente.AutoSize = true;
            this.lblTelefonoCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoCliente.Location = new System.Drawing.Point(20, 93);
            this.lblTelefonoCliente.Name = "lblTelefonoCliente";
            this.lblTelefonoCliente.Size = new System.Drawing.Size(90, 19);
            this.lblTelefonoCliente.TabIndex = 7;
            this.lblTelefonoCliente.Text = "Teléfono:";
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailCliente.Location = new System.Drawing.Point(140, 60);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.ReadOnly = true;
            this.txtEmailCliente.Size = new System.Drawing.Size(290, 26);
            this.txtEmailCliente.TabIndex = 6;
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailCliente.Location = new System.Drawing.Point(20, 63);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(63, 19);
            this.lblEmailCliente.TabIndex = 5;
            this.lblEmailCliente.Text = "Email:";
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionCliente.Location = new System.Drawing.Point(140, 30);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.ReadOnly = true;
            this.txtDireccionCliente.Size = new System.Drawing.Size(290, 26);
            this.txtDireccionCliente.TabIndex = 4;
            // 
            // lblDireccionCliente
            // 
            this.lblDireccionCliente.AutoSize = true;
            this.lblDireccionCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionCliente.Location = new System.Drawing.Point(20, 33);
            this.lblDireccionCliente.Name = "lblDireccionCliente";
            this.lblDireccionCliente.Size = new System.Drawing.Size(99, 19);
            this.lblDireccionCliente.TabIndex = 3;
            this.lblDireccionCliente.Text = "Dirección:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(140, 30);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(200, 26);
            this.txtNombreCliente.TabIndex = 2;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(20, 33);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(117, 19);
            this.lblNombreCliente.TabIndex = 1;
            this.lblNombreCliente.Text = "Nombre/Razón:";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.LightBlue;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Location = new System.Drawing.Point(350, 28);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(80, 27);
            this.btnBuscarCliente.TabIndex = 0;
            this.btnBuscarCliente.Text = "BUSCAR";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // gbDatosProducto
            // 
            this.gbDatosProducto.Controls.Add(this.txtStockActual);
            this.gbDatosProducto.Controls.Add(this.lblStockActual);
            this.gbDatosProducto.Controls.Add(this.txtCategoria);
            this.gbDatosProducto.Controls.Add(this.lblCategoria);
            this.gbDatosProducto.Controls.Add(this.txtMarca);
            this.gbDatosProducto.Controls.Add(this.lblMarca);
            this.gbDatosProducto.Controls.Add(this.txtProducto);
            this.gbDatosProducto.Controls.Add(this.lblProducto);
            this.gbDatosProducto.Controls.Add(this.btnBuscarProducto);
            this.gbDatosProducto.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosProducto.Location = new System.Drawing.Point(20, 280);
            this.gbDatosProducto.Name = "gbDatosProducto";
            this.gbDatosProducto.Size = new System.Drawing.Size(450, 180);
            this.gbDatosProducto.TabIndex = 3;
            this.gbDatosProducto.TabStop = false;
            this.gbDatosProducto.Text = "DATOS DEL PRODUCTO";
            // 
            // txtStockActual
            // 
            this.txtStockActual.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockActual.Location = new System.Drawing.Point(140, 120);
            this.txtStockActual.Name = "txtStockActual";
            this.txtStockActual.ReadOnly = true;
            this.txtStockActual.Size = new System.Drawing.Size(100, 26);
            this.txtStockActual.TabIndex = 8;
            // 
            // lblStockActual
            // 
            this.lblStockActual.AutoSize = true;
            this.lblStockActual.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockActual.Location = new System.Drawing.Point(20, 123);
            this.lblStockActual.Name = "lblStockActual";
            this.lblStockActual.Size = new System.Drawing.Size(117, 19);
            this.lblStockActual.TabIndex = 7;
            this.lblStockActual.Text = "Stock Actual:";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(140, 90);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.Size = new System.Drawing.Size(280, 26);
            this.txtCategoria.TabIndex = 6;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(20, 93);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(99, 19);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoría:";
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(140, 60);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.ReadOnly = true;
            this.txtMarca.Size = new System.Drawing.Size(280, 26);
            this.txtMarca.TabIndex = 4;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(20, 63);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(63, 19);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca:";
            // 
            // txtProducto
            // 
            this.txtProducto.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(140, 30);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(200, 26);
            this.txtProducto.TabIndex = 2;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(20, 33);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(90, 19);
            this.lblProducto.TabIndex = 1;
            this.lblProducto.Text = "Producto:";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.LightBlue;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.Location = new System.Drawing.Point(350, 28);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(80, 27);
            this.btnBuscarProducto.TabIndex = 0;
            this.btnBuscarProducto.Text = "BUSCAR";
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            // 
            // pnlDetalle
            // 
            this.pnlDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDetalle.Controls.Add(this.dgvDetallePresupuesto);
            this.pnlDetalle.Location = new System.Drawing.Point(500, 280);
            this.pnlDetalle.Name = "pnlDetalle";
            this.pnlDetalle.Size = new System.Drawing.Size(450, 238);
            this.pnlDetalle.TabIndex = 4;
            // 
            // dgvDetallePresupuesto
            // 
            this.dgvDetallePresupuesto.AllowUserToAddRows = false;
            this.dgvDetallePresupuesto.AllowUserToDeleteRows = false;
            this.dgvDetallePresupuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallePresupuesto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colDescripcion,
            this.colCantidad,
            this.colUnidadMedida,
            this.colPrecioUnitario,
            this.colDescuento,
            this.colSubtotal});
            this.dgvDetallePresupuesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetallePresupuesto.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetallePresupuesto.Location = new System.Drawing.Point(0, 0);
            this.dgvDetallePresupuesto.Name = "dgvDetallePresupuesto";
            this.dgvDetallePresupuesto.ReadOnly = true;
            this.dgvDetallePresupuesto.Size = new System.Drawing.Size(450, 238);
            this.dgvDetallePresupuesto.TabIndex = 0;
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
            // colUnidadMedida
            // 
            this.colUnidadMedida.HeaderText = "UNIDAD";
            this.colUnidadMedida.Name = "colUnidadMedida";
            this.colUnidadMedida.ReadOnly = true;
            this.colUnidadMedida.Width = 70;
            // 
            // colPrecioUnitario
            // 
            this.colPrecioUnitario.HeaderText = "PRECIO UNIT.";
            this.colPrecioUnitario.Name = "colPrecioUnitario";
            this.colPrecioUnitario.ReadOnly = true;
            this.colPrecioUnitario.Width = 120;
            // 
            // colDescuento
            // 
            this.colDescuento.HeaderText = "DESCUENTO";
            this.colDescuento.Name = "colDescuento";
            this.colDescuento.ReadOnly = true;
            // 
            // colSubtotal
            // 
            this.colSubtotal.HeaderText = "SUBTOTAL";
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.ReadOnly = true;
            this.colSubtotal.Width = 120;
            // 
            // pnlTotales
            // 
            this.pnlTotales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTotales.Controls.Add(this.txtObservaciones);
            this.pnlTotales.Controls.Add(this.lblObservaciones);
            this.pnlTotales.Controls.Add(this.txtTotal);
            this.pnlTotales.Controls.Add(this.lblTotal);
            this.pnlTotales.Location = new System.Drawing.Point(20, 538);
            this.pnlTotales.Name = "pnlTotales";
            this.pnlTotales.Size = new System.Drawing.Size(930, 100);
            this.pnlTotales.TabIndex = 5;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(140, 15);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(400, 70);
            this.txtObservaciones.TabIndex = 7;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.Location = new System.Drawing.Point(20, 18);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(135, 19);
            this.lblObservaciones.TabIndex = 6;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(800, 35);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(120, 30);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(720, 38);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(70, 22);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "TOTAL:";
            // 
            // pnlBotones
            // 
            this.pnlBotones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBotones.Controls.Add(this.btnAgregarProducto);
            this.pnlBotones.Controls.Add(this.btnConvertirPedido);
            this.pnlBotones.Controls.Add(this.btnImprimir);
            this.pnlBotones.Controls.Add(this.btnGuardar);
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Location = new System.Drawing.Point(20, 658);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(930, 60);
            this.pnlBotones.TabIndex = 6;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.LightBlue;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.Location = new System.Drawing.Point(20, 15);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(180, 35);
            this.btnAgregarProducto.TabIndex = 0;
            this.btnAgregarProducto.Text = "AGREGAR PRODUCTO";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            // 
            // btnConvertirPedido
            // 
            this.btnConvertirPedido.BackColor = System.Drawing.Color.LightGreen;
            this.btnConvertirPedido.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertirPedido.Location = new System.Drawing.Point(220, 15);
            this.btnConvertirPedido.Name = "btnConvertirPedido";
            this.btnConvertirPedido.Size = new System.Drawing.Size(180, 35);
            this.btnConvertirPedido.TabIndex = 3;
            this.btnConvertirPedido.Text = "CONVERTIR A PEDIDO";
            this.btnConvertirPedido.UseVisualStyleBackColor = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.LightYellow;
            this.btnImprimir.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(630, 15);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(90, 35);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightGreen;
            this.btnGuardar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(730, 15);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 35);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancelar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(830, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 35);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "CANCELAR";
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
            this.label1.TabIndex = 14;
            this.label1.Text = "Emisión Presupuesto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmEmisionPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlTotales);
            this.Controls.Add(this.pnlDetalle);
            this.Controls.Add(this.gbDatosProducto);
            this.Controls.Add(this.gbDatosCliente);
            this.Controls.Add(this.gbDatosPresupuesto);
            this.MinimumSize = new System.Drawing.Size(1000, 726);
            this.Name = "frmEmisionPresupuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Presupuesto de Venta";
            this.gbDatosPresupuesto.ResumeLayout(false);
            this.gbDatosPresupuesto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiasValidez)).EndInit();
            this.gbDatosCliente.ResumeLayout(false);
            this.gbDatosCliente.PerformLayout();
            this.gbDatosProducto.ResumeLayout(false);
            this.gbDatosProducto.PerformLayout();
            this.pnlDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePresupuesto)).EndInit();
            this.pnlTotales.ResumeLayout(false);
            this.pnlTotales.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbDatosPresupuesto;
        private System.Windows.Forms.NumericUpDown nudDiasValidez;
        private System.Windows.Forms.Label lblDiasValidez;
        private System.Windows.Forms.TextBox txtNumeroPresupuesto;
        private System.Windows.Forms.Label lblNumeroPresupuesto;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaEmision;
        private System.Windows.Forms.Label lblFechaEmision;
        private System.Windows.Forms.GroupBox gbDatosCliente;
        private System.Windows.Forms.TextBox txtCondicionVenta;
        private System.Windows.Forms.Label lblCondicionVenta;
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.Label lblTelefonoCliente;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.Label lblEmailCliente;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.Label lblDireccionCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.GroupBox gbDatosProducto;
        private System.Windows.Forms.TextBox txtStockActual;
        private System.Windows.Forms.Label lblStockActual;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Panel pnlDetalle;
        private System.Windows.Forms.DataGridView dgvDetallePresupuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.Panel pnlTotales;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnConvertirPedido;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
    }
}