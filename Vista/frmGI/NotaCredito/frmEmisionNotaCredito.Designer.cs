namespace Vista.frmGI.NotaCredito
{
    partial class frmEmisionNotaCredito
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
            this.gbDatosNotaCredito = new System.Windows.Forms.GroupBox();
            this.cmbMotivo = new System.Windows.Forms.ComboBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.txtNumeroNotaCredito = new System.Windows.Forms.TextBox();
            this.lblNumeroNotaCredito = new System.Windows.Forms.Label();
            this.dtpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.lblFechaEmision = new System.Windows.Forms.Label();
            this.gbDatosCliente = new System.Windows.Forms.GroupBox();
            this.btnBuscarComprobante = new System.Windows.Forms.Button();
            this.txtComprobanteOrigen = new System.Windows.Forms.TextBox();
            this.lblComprobanteOrigen = new System.Windows.Forms.Label();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.lblDireccionCliente = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.gbDatosFiscales = new System.Windows.Forms.GroupBox();
            this.txtCondicionIva = new System.Windows.Forms.TextBox();
            this.lblCondicionIva = new System.Windows.Forms.Label();
            this.txtCuitCliente = new System.Windows.Forms.TextBox();
            this.lblCuitCliente = new System.Windows.Forms.Label();
            this.pnlDetalle = new System.Windows.Forms.Panel();
            this.dgvDetalleNotaCredito = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTotales = new System.Windows.Forms.Panel();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.lblIva = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDatosNotaCredito.SuspendLayout();
            this.gbDatosCliente.SuspendLayout();
            this.gbDatosFiscales.SuspendLayout();
            this.pnlDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleNotaCredito)).BeginInit();
            this.pnlTotales.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatosNotaCredito
            // 
            this.gbDatosNotaCredito.Controls.Add(this.cmbMotivo);
            this.gbDatosNotaCredito.Controls.Add(this.lblMotivo);
            this.gbDatosNotaCredito.Controls.Add(this.txtNumeroNotaCredito);
            this.gbDatosNotaCredito.Controls.Add(this.lblNumeroNotaCredito);
            this.gbDatosNotaCredito.Controls.Add(this.dtpFechaEmision);
            this.gbDatosNotaCredito.Controls.Add(this.lblFechaEmision);
            this.gbDatosNotaCredito.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosNotaCredito.Location = new System.Drawing.Point(20, 80);
            this.gbDatosNotaCredito.Name = "gbDatosNotaCredito";
            this.gbDatosNotaCredito.Size = new System.Drawing.Size(450, 180);
            this.gbDatosNotaCredito.TabIndex = 1;
            this.gbDatosNotaCredito.TabStop = false;
            this.gbDatosNotaCredito.Text = "DATOS NOTA DE CRÉDITO";
            // 
            // cmbMotivo
            // 
            this.cmbMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotivo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMotivo.FormattingEnabled = true;
            this.cmbMotivo.Items.AddRange(new object[] {
            "Devolución de productos",
            "Descuento especial",
            "Error en facturación",
            "Ajuste de precios",
            "Bonificación",
            "Otros"});
            this.cmbMotivo.Location = new System.Drawing.Point(140, 120);
            this.cmbMotivo.Name = "cmbMotivo";
            this.cmbMotivo.Size = new System.Drawing.Size(280, 27);
            this.cmbMotivo.TabIndex = 5;
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.Location = new System.Drawing.Point(20, 123);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(72, 19);
            this.lblMotivo.TabIndex = 4;
            this.lblMotivo.Text = "Motivo:";
            // 
            // txtNumeroNotaCredito
            // 
            this.txtNumeroNotaCredito.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroNotaCredito.Location = new System.Drawing.Point(140, 40);
            this.txtNumeroNotaCredito.Name = "txtNumeroNotaCredito";
            this.txtNumeroNotaCredito.ReadOnly = true;
            this.txtNumeroNotaCredito.Size = new System.Drawing.Size(200, 26);
            this.txtNumeroNotaCredito.TabIndex = 3;
            this.txtNumeroNotaCredito.Text = "NC-00000001";
            // 
            // lblNumeroNotaCredito
            // 
            this.lblNumeroNotaCredito.AutoSize = true;
            this.lblNumeroNotaCredito.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroNotaCredito.Location = new System.Drawing.Point(20, 43);
            this.lblNumeroNotaCredito.Name = "lblNumeroNotaCredito";
            this.lblNumeroNotaCredito.Size = new System.Drawing.Size(72, 19);
            this.lblNumeroNotaCredito.TabIndex = 2;
            this.lblNumeroNotaCredito.Text = "Número:";
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
            this.lblFechaEmision.Size = new System.Drawing.Size(135, 19);
            this.lblFechaEmision.TabIndex = 0;
            this.lblFechaEmision.Text = "Fecha Emisión:";
            // 
            // gbDatosCliente
            // 
            this.gbDatosCliente.Controls.Add(this.btnBuscarComprobante);
            this.gbDatosCliente.Controls.Add(this.txtComprobanteOrigen);
            this.gbDatosCliente.Controls.Add(this.lblComprobanteOrigen);
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
            // btnBuscarComprobante
            // 
            this.btnBuscarComprobante.BackColor = System.Drawing.Color.LightBlue;
            this.btnBuscarComprobante.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarComprobante.Location = new System.Drawing.Point(350, 120);
            this.btnBuscarComprobante.Name = "btnBuscarComprobante";
            this.btnBuscarComprobante.Size = new System.Drawing.Size(80, 27);
            this.btnBuscarComprobante.TabIndex = 8;
            this.btnBuscarComprobante.Text = "BUSCAR";
            this.btnBuscarComprobante.UseVisualStyleBackColor = false;
            // 
            // txtComprobanteOrigen
            // 
            this.txtComprobanteOrigen.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComprobanteOrigen.Location = new System.Drawing.Point(140, 120);
            this.txtComprobanteOrigen.Name = "txtComprobanteOrigen";
            this.txtComprobanteOrigen.ReadOnly = true;
            this.txtComprobanteOrigen.Size = new System.Drawing.Size(200, 26);
            this.txtComprobanteOrigen.TabIndex = 7;
            this.txtComprobanteOrigen.Text = "FAC-00000001";
            // 
            // lblComprobanteOrigen
            // 
            this.lblComprobanteOrigen.AutoSize = true;
            this.lblComprobanteOrigen.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComprobanteOrigen.Location = new System.Drawing.Point(20, 123);
            this.lblComprobanteOrigen.Name = "lblComprobanteOrigen";
            this.lblComprobanteOrigen.Size = new System.Drawing.Size(126, 19);
            this.lblComprobanteOrigen.TabIndex = 6;
            this.lblComprobanteOrigen.Text = "Comp. Origen:";
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionCliente.Location = new System.Drawing.Point(140, 80);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.ReadOnly = true;
            this.txtDireccionCliente.Size = new System.Drawing.Size(290, 26);
            this.txtDireccionCliente.TabIndex = 4;
            // 
            // lblDireccionCliente
            // 
            this.lblDireccionCliente.AutoSize = true;
            this.lblDireccionCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionCliente.Location = new System.Drawing.Point(20, 83);
            this.lblDireccionCliente.Name = "lblDireccionCliente";
            this.lblDireccionCliente.Size = new System.Drawing.Size(99, 19);
            this.lblDireccionCliente.TabIndex = 3;
            this.lblDireccionCliente.Text = "Dirección:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(140, 40);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(200, 26);
            this.txtNombreCliente.TabIndex = 2;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(20, 43);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(72, 19);
            this.lblNombreCliente.TabIndex = 1;
            this.lblNombreCliente.Text = "Nombre:";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.LightBlue;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Location = new System.Drawing.Point(350, 38);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(80, 27);
            this.btnBuscarCliente.TabIndex = 0;
            this.btnBuscarCliente.Text = "BUSCAR";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // gbDatosFiscales
            // 
            this.gbDatosFiscales.Controls.Add(this.txtCondicionIva);
            this.gbDatosFiscales.Controls.Add(this.lblCondicionIva);
            this.gbDatosFiscales.Controls.Add(this.txtCuitCliente);
            this.gbDatosFiscales.Controls.Add(this.lblCuitCliente);
            this.gbDatosFiscales.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosFiscales.Location = new System.Drawing.Point(20, 280);
            this.gbDatosFiscales.Name = "gbDatosFiscales";
            this.gbDatosFiscales.Size = new System.Drawing.Size(450, 120);
            this.gbDatosFiscales.TabIndex = 3;
            this.gbDatosFiscales.TabStop = false;
            this.gbDatosFiscales.Text = "DATOS FISCALES";
            // 
            // txtCondicionIva
            // 
            this.txtCondicionIva.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCondicionIva.Location = new System.Drawing.Point(140, 70);
            this.txtCondicionIva.Name = "txtCondicionIva";
            this.txtCondicionIva.ReadOnly = true;
            this.txtCondicionIva.Size = new System.Drawing.Size(280, 26);
            this.txtCondicionIva.TabIndex = 3;
            this.txtCondicionIva.Text = "Responsable Inscripto";
            // 
            // lblCondicionIva
            // 
            this.lblCondicionIva.AutoSize = true;
            this.lblCondicionIva.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondicionIva.Location = new System.Drawing.Point(20, 73);
            this.lblCondicionIva.Name = "lblCondicionIva";
            this.lblCondicionIva.Size = new System.Drawing.Size(99, 19);
            this.lblCondicionIva.TabIndex = 2;
            this.lblCondicionIva.Text = "Cond. IVA:";
            // 
            // txtCuitCliente
            // 
            this.txtCuitCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuitCliente.Location = new System.Drawing.Point(140, 30);
            this.txtCuitCliente.Name = "txtCuitCliente";
            this.txtCuitCliente.ReadOnly = true;
            this.txtCuitCliente.Size = new System.Drawing.Size(200, 26);
            this.txtCuitCliente.TabIndex = 1;
            // 
            // lblCuitCliente
            // 
            this.lblCuitCliente.AutoSize = true;
            this.lblCuitCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuitCliente.Location = new System.Drawing.Point(20, 33);
            this.lblCuitCliente.Name = "lblCuitCliente";
            this.lblCuitCliente.Size = new System.Drawing.Size(54, 19);
            this.lblCuitCliente.TabIndex = 0;
            this.lblCuitCliente.Text = "CUIT:";
            // 
            // pnlDetalle
            // 
            this.pnlDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDetalle.Controls.Add(this.dgvDetalleNotaCredito);
            this.pnlDetalle.Location = new System.Drawing.Point(500, 280);
            this.pnlDetalle.Name = "pnlDetalle";
            this.pnlDetalle.Size = new System.Drawing.Size(450, 238);
            this.pnlDetalle.TabIndex = 4;
            // 
            // dgvDetalleNotaCredito
            // 
            this.dgvDetalleNotaCredito.AllowUserToAddRows = false;
            this.dgvDetalleNotaCredito.AllowUserToDeleteRows = false;
            this.dgvDetalleNotaCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleNotaCredito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colDescripcion,
            this.colCantidad,
            this.colUnidadMedida,
            this.colPrecioUnitario,
            this.colSubtotal});
            this.dgvDetalleNotaCredito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalleNotaCredito.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetalleNotaCredito.Location = new System.Drawing.Point(0, 0);
            this.dgvDetalleNotaCredito.Name = "dgvDetalleNotaCredito";
            this.dgvDetalleNotaCredito.ReadOnly = true;
            this.dgvDetalleNotaCredito.Size = new System.Drawing.Size(450, 238);
            this.dgvDetalleNotaCredito.TabIndex = 0;
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
            this.pnlTotales.Controls.Add(this.txtIva);
            this.pnlTotales.Controls.Add(this.lblIva);
            this.pnlTotales.Controls.Add(this.txtSubtotal);
            this.pnlTotales.Controls.Add(this.lblSubtotal);
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
            this.txtTotal.Location = new System.Drawing.Point(800, 55);
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
            this.lblTotal.Location = new System.Drawing.Point(720, 58);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(70, 22);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "TOTAL:";
            // 
            // txtIva
            // 
            this.txtIva.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIva.Location = new System.Drawing.Point(800, 30);
            this.txtIva.Name = "txtIva";
            this.txtIva.ReadOnly = true;
            this.txtIva.Size = new System.Drawing.Size(120, 26);
            this.txtIva.TabIndex = 3;
            this.txtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIva.Location = new System.Drawing.Point(750, 33);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(45, 19);
            this.lblIva.TabIndex = 2;
            this.lblIva.Text = "IVA:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(800, 5);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(120, 26);
            this.txtSubtotal.TabIndex = 1;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(710, 8);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(90, 19);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // pnlBotones
            // 
            this.pnlBotones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBotones.Controls.Add(this.btnAgregarProducto);
            this.pnlBotones.Controls.Add(this.btnGuardar);
            this.pnlBotones.Controls.Add(this.btnImprimir);
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
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightGreen;
            this.btnGuardar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(550, 15);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 35);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.LightYellow;
            this.btnImprimir.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(680, 15);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(120, 35);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancelar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(810, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 35);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(887, 49);
            this.label1.TabIndex = 13;
            this.label1.Text = "Emision de Nota de Credito";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmEmisionNotaCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlTotales);
            this.Controls.Add(this.pnlDetalle);
            this.Controls.Add(this.gbDatosFiscales);
            this.Controls.Add(this.gbDatosCliente);
            this.Controls.Add(this.gbDatosNotaCredito);
            this.MinimumSize = new System.Drawing.Size(1000, 726);
            this.Name = "frmEmisionNotaCredito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emisión - Nota de Crédito";
            this.gbDatosNotaCredito.ResumeLayout(false);
            this.gbDatosNotaCredito.PerformLayout();
            this.gbDatosCliente.ResumeLayout(false);
            this.gbDatosCliente.PerformLayout();
            this.gbDatosFiscales.ResumeLayout(false);
            this.gbDatosFiscales.PerformLayout();
            this.pnlDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleNotaCredito)).EndInit();
            this.pnlTotales.ResumeLayout(false);
            this.pnlTotales.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbDatosNotaCredito;
        private System.Windows.Forms.ComboBox cmbMotivo;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox txtNumeroNotaCredito;
        private System.Windows.Forms.Label lblNumeroNotaCredito;
        private System.Windows.Forms.DateTimePicker dtpFechaEmision;
        private System.Windows.Forms.Label lblFechaEmision;
        private System.Windows.Forms.GroupBox gbDatosCliente;
        private System.Windows.Forms.Button btnBuscarComprobante;
        private System.Windows.Forms.TextBox txtComprobanteOrigen;
        private System.Windows.Forms.Label lblComprobanteOrigen;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.Label lblDireccionCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.GroupBox gbDatosFiscales;
        private System.Windows.Forms.TextBox txtCondicionIva;
        private System.Windows.Forms.Label lblCondicionIva;
        private System.Windows.Forms.TextBox txtCuitCliente;
        private System.Windows.Forms.Label lblCuitCliente;
        private System.Windows.Forms.Panel pnlDetalle;
        private System.Windows.Forms.DataGridView dgvDetalleNotaCredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.Panel pnlTotales;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
    }
}