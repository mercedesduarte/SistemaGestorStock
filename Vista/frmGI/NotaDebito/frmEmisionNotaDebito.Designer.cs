namespace Vista.frmGI.NotaDebito
{
    partial class frmEmisionNotaDebito
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
            this.gbDatosFiscales = new System.Windows.Forms.GroupBox();
            this.txtCondicionIva = new System.Windows.Forms.TextBox();
            this.lblCondicionIva = new System.Windows.Forms.Label();
            this.txtCuitCliente = new System.Windows.Forms.TextBox();
            this.lblCuitCliente = new System.Windows.Forms.Label();
            this.gbDatosCliente = new System.Windows.Forms.GroupBox();
            this.txtComprobanteOrigen = new System.Windows.Forms.TextBox();
            this.lblComprobanteOrigen = new System.Windows.Forms.Label();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.lblDireccionCliente = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnBuscarComprobante = new System.Windows.Forms.Button();
            this.gbDatosNotaDebito = new System.Windows.Forms.GroupBox();
            this.cmbMotivo = new System.Windows.Forms.ComboBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.txtNumeroNotaDebito = new System.Windows.Forms.TextBox();
            this.lblNumeroNotaDebito = new System.Windows.Forms.Label();
            this.dtpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.lblFechaEmision = new System.Windows.Forms.Label();
            this.pnlDetalle = new System.Windows.Forms.Panel();
            this.dgvDetalleNotaDebito = new System.Windows.Forms.DataGridView();
            this.colConcepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAgregarConcepto = new System.Windows.Forms.Button();
            this.pnlCabecera.SuspendLayout();
            this.gbDatosFiscales.SuspendLayout();
            this.gbDatosCliente.SuspendLayout();
            this.gbDatosNotaDebito.SuspendLayout();
            this.pnlDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleNotaDebito)).BeginInit();
            this.pnlTotales.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.Controls.Add(this.gbDatosFiscales);
            this.pnlCabecera.Controls.Add(this.gbDatosCliente);
            this.pnlCabecera.Controls.Add(this.gbDatosNotaDebito);
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(984, 200);
            this.pnlCabecera.TabIndex = 0;
            // 
            // gbDatosFiscales
            // 
            this.gbDatosFiscales.Controls.Add(this.txtCondicionIva);
            this.gbDatosFiscales.Controls.Add(this.lblCondicionIva);
            this.gbDatosFiscales.Controls.Add(this.txtCuitCliente);
            this.gbDatosFiscales.Controls.Add(this.lblCuitCliente);
            this.gbDatosFiscales.Location = new System.Drawing.Point(724, 12);
            this.gbDatosFiscales.Name = "gbDatosFiscales";
            this.gbDatosFiscales.Size = new System.Drawing.Size(248, 175);
            this.gbDatosFiscales.TabIndex = 2;
            this.gbDatosFiscales.TabStop = false;
            this.gbDatosFiscales.Text = "Datos Fiscales";
            // 
            // txtCondicionIva
            // 
            this.txtCondicionIva.Location = new System.Drawing.Point(120, 50);
            this.txtCondicionIva.Name = "txtCondicionIva";
            this.txtCondicionIva.ReadOnly = true;
            this.txtCondicionIva.Size = new System.Drawing.Size(100, 20);
            this.txtCondicionIva.TabIndex = 3;
            this.txtCondicionIva.Text = "Responsable Inscripto";
            // 
            // lblCondicionIva
            // 
            this.lblCondicionIva.AutoSize = true;
            this.lblCondicionIva.Location = new System.Drawing.Point(16, 53);
            this.lblCondicionIva.Name = "lblCondicionIva";
            this.lblCondicionIva.Size = new System.Drawing.Size(77, 13);
            this.lblCondicionIva.TabIndex = 2;
            this.lblCondicionIva.Text = "Condición IVA:";
            // 
            // txtCuitCliente
            // 
            this.txtCuitCliente.Location = new System.Drawing.Point(120, 25);
            this.txtCuitCliente.Name = "txtCuitCliente";
            this.txtCuitCliente.ReadOnly = true;
            this.txtCuitCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCuitCliente.TabIndex = 1;
            // 
            // lblCuitCliente
            // 
            this.lblCuitCliente.AutoSize = true;
            this.lblCuitCliente.Location = new System.Drawing.Point(16, 28);
            this.lblCuitCliente.Name = "lblCuitCliente";
            this.lblCuitCliente.Size = new System.Drawing.Size(35, 13);
            this.lblCuitCliente.TabIndex = 0;
            this.lblCuitCliente.Text = "CUIT:";
            // 
            // gbDatosCliente
            // 
            this.gbDatosCliente.Controls.Add(this.txtComprobanteOrigen);
            this.gbDatosCliente.Controls.Add(this.lblComprobanteOrigen);
            this.gbDatosCliente.Controls.Add(this.txtDireccionCliente);
            this.gbDatosCliente.Controls.Add(this.lblDireccionCliente);
            this.gbDatosCliente.Controls.Add(this.txtNombreCliente);
            this.gbDatosCliente.Controls.Add(this.lblNombreCliente);
            this.gbDatosCliente.Controls.Add(this.btnBuscarCliente);
            this.gbDatosCliente.Controls.Add(this.btnBuscarComprobante);
            this.gbDatosCliente.Location = new System.Drawing.Point(318, 12);
            this.gbDatosCliente.Name = "gbDatosCliente";
            this.gbDatosCliente.Size = new System.Drawing.Size(400, 175);
            this.gbDatosCliente.TabIndex = 1;
            this.gbDatosCliente.TabStop = false;
            this.gbDatosCliente.Text = "Datos del Cliente";
            // 
            // txtComprobanteOrigen
            // 
            this.txtComprobanteOrigen.Location = new System.Drawing.Point(120, 75);
            this.txtComprobanteOrigen.Name = "txtComprobanteOrigen";
            this.txtComprobanteOrigen.ReadOnly = true;
            this.txtComprobanteOrigen.Size = new System.Drawing.Size(200, 20);
            this.txtComprobanteOrigen.TabIndex = 7;
            this.txtComprobanteOrigen.Text = "FAC-00000001";
            // 
            // lblComprobanteOrigen
            // 
            this.lblComprobanteOrigen.AutoSize = true;
            this.lblComprobanteOrigen.Location = new System.Drawing.Point(16, 78);
            this.lblComprobanteOrigen.Name = "lblComprobanteOrigen";
            this.lblComprobanteOrigen.Size = new System.Drawing.Size(89, 13);
            this.lblComprobanteOrigen.TabIndex = 6;
            this.lblComprobanteOrigen.Text = "Comp. de Origen:";
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Location = new System.Drawing.Point(120, 50);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.ReadOnly = true;
            this.txtDireccionCliente.Size = new System.Drawing.Size(200, 20);
            this.txtDireccionCliente.TabIndex = 4;
            // 
            // lblDireccionCliente
            // 
            this.lblDireccionCliente.AutoSize = true;
            this.lblDireccionCliente.Location = new System.Drawing.Point(16, 53);
            this.lblDireccionCliente.Name = "lblDireccionCliente";
            this.lblDireccionCliente.Size = new System.Drawing.Size(55, 13);
            this.lblDireccionCliente.TabIndex = 3;
            this.lblDireccionCliente.Text = "Dirección:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(120, 25);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(200, 20);
            this.txtNombreCliente.TabIndex = 2;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(16, 28);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(89, 13);
            this.lblNombreCliente.TabIndex = 1;
            this.lblNombreCliente.Text = "Nombre/Apellido:";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(326, 22);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(60, 25);
            this.btnBuscarCliente.TabIndex = 0;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // btnBuscarComprobante
            // 
            this.btnBuscarComprobante.Location = new System.Drawing.Point(326, 72);
            this.btnBuscarComprobante.Name = "btnBuscarComprobante";
            this.btnBuscarComprobante.Size = new System.Drawing.Size(60, 25);
            this.btnBuscarComprobante.TabIndex = 8;
            this.btnBuscarComprobante.Text = "Buscar";
            this.btnBuscarComprobante.UseVisualStyleBackColor = true;
            // 
            // gbDatosNotaDebito
            // 
            this.gbDatosNotaDebito.Controls.Add(this.cmbMotivo);
            this.gbDatosNotaDebito.Controls.Add(this.lblMotivo);
            this.gbDatosNotaDebito.Controls.Add(this.txtNumeroNotaDebito);
            this.gbDatosNotaDebito.Controls.Add(this.lblNumeroNotaDebito);
            this.gbDatosNotaDebito.Controls.Add(this.dtpFechaEmision);
            this.gbDatosNotaDebito.Controls.Add(this.lblFechaEmision);
            this.gbDatosNotaDebito.Location = new System.Drawing.Point(12, 12);
            this.gbDatosNotaDebito.Name = "gbDatosNotaDebito";
            this.gbDatosNotaDebito.Size = new System.Drawing.Size(300, 175);
            this.gbDatosNotaDebito.TabIndex = 0;
            this.gbDatosNotaDebito.TabStop = false;
            this.gbDatosNotaDebito.Text = "Datos de la Nota de Débito";
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
            this.cmbMotivo.Location = new System.Drawing.Point(120, 75);
            this.cmbMotivo.Name = "cmbMotivo";
            this.cmbMotivo.Size = new System.Drawing.Size(160, 21);
            this.cmbMotivo.TabIndex = 5;
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(16, 78);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(42, 13);
            this.lblMotivo.TabIndex = 4;
            this.lblMotivo.Text = "Motivo:";
            // 
            // txtNumeroNotaDebito
            // 
            this.txtNumeroNotaDebito.Location = new System.Drawing.Point(120, 25);
            this.txtNumeroNotaDebito.Name = "txtNumeroNotaDebito";
            this.txtNumeroNotaDebito.ReadOnly = true;
            this.txtNumeroNotaDebito.Size = new System.Drawing.Size(120, 20);
            this.txtNumeroNotaDebito.TabIndex = 3;
            this.txtNumeroNotaDebito.Text = "ND-00000001";
            // 
            // lblNumeroNotaDebito
            // 
            this.lblNumeroNotaDebito.AutoSize = true;
            this.lblNumeroNotaDebito.Location = new System.Drawing.Point(16, 28);
            this.lblNumeroNotaDebito.Name = "lblNumeroNotaDebito";
            this.lblNumeroNotaDebito.Size = new System.Drawing.Size(47, 13);
            this.lblNumeroNotaDebito.TabIndex = 2;
            this.lblNumeroNotaDebito.Text = "Número:";
            // 
            // dtpFechaEmision
            // 
            this.dtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEmision.Location = new System.Drawing.Point(120, 50);
            this.dtpFechaEmision.Name = "dtpFechaEmision";
            this.dtpFechaEmision.Size = new System.Drawing.Size(120, 20);
            this.dtpFechaEmision.TabIndex = 1;
            // 
            // lblFechaEmision
            // 
            this.lblFechaEmision.AutoSize = true;
            this.lblFechaEmision.Location = new System.Drawing.Point(16, 53);
            this.lblFechaEmision.Name = "lblFechaEmision";
            this.lblFechaEmision.Size = new System.Drawing.Size(79, 13);
            this.lblFechaEmision.TabIndex = 0;
            this.lblFechaEmision.Text = "Fecha Emisión:";
            // 
            // pnlDetalle
            // 
            this.pnlDetalle.Controls.Add(this.dgvDetalleNotaDebito);
            this.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetalle.Location = new System.Drawing.Point(0, 200);
            this.pnlDetalle.Name = "pnlDetalle";
            this.pnlDetalle.Size = new System.Drawing.Size(984, 351);
            this.pnlDetalle.TabIndex = 1;
            // 
            // dgvDetalleNotaDebito
            // 
            this.dgvDetalleNotaDebito.AllowUserToAddRows = false;
            this.dgvDetalleNotaDebito.AllowUserToDeleteRows = false;
            this.dgvDetalleNotaDebito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleNotaDebito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colConcepto,
            this.colDescripcion,
            this.colCantidad,
            this.colUnidadMedida,
            this.colPrecioUnitario,
            this.colSubtotal});
            this.dgvDetalleNotaDebito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalleNotaDebito.Location = new System.Drawing.Point(0, 0);
            this.dgvDetalleNotaDebito.Name = "dgvDetalleNotaDebito";
            this.dgvDetalleNotaDebito.ReadOnly = true;
            this.dgvDetalleNotaDebito.Size = new System.Drawing.Size(984, 351);
            this.dgvDetalleNotaDebito.TabIndex = 0;
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
            this.colDescripcion.Width = 250;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 80;
            // 
            // colUnidadMedida
            // 
            this.colUnidadMedida.HeaderText = "Unidad";
            this.colUnidadMedida.Name = "colUnidadMedida";
            this.colUnidadMedida.ReadOnly = true;
            this.colUnidadMedida.Width = 70;
            // 
            // colPrecioUnitario
            // 
            this.colPrecioUnitario.HeaderText = "Precio Unitario";
            this.colPrecioUnitario.Name = "colPrecioUnitario";
            this.colPrecioUnitario.ReadOnly = true;
            this.colPrecioUnitario.Width = 120;
            // 
            // colSubtotal
            // 
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.ReadOnly = true;
            this.colSubtotal.Width = 120;
            // 
            // pnlTotales
            // 
            this.pnlTotales.Controls.Add(this.txtObservaciones);
            this.pnlTotales.Controls.Add(this.lblObservaciones);
            this.pnlTotales.Controls.Add(this.txtTotal);
            this.pnlTotales.Controls.Add(this.lblTotal);
            this.pnlTotales.Controls.Add(this.txtIva);
            this.pnlTotales.Controls.Add(this.lblIva);
            this.pnlTotales.Controls.Add(this.txtSubtotal);
            this.pnlTotales.Controls.Add(this.lblSubtotal);
            this.pnlTotales.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTotales.Location = new System.Drawing.Point(0, 551);
            this.pnlTotales.Name = "pnlTotales";
            this.pnlTotales.Size = new System.Drawing.Size(984, 80);
            this.pnlTotales.TabIndex = 2;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(120, 15);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(400, 50);
            this.txtObservaciones.TabIndex = 7;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(32, 18);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(81, 13);
            this.lblObservaciones.TabIndex = 6;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(800, 45);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(150, 26);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(740, 48);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 20);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            // 
            // txtIva
            // 
            this.txtIva.Location = new System.Drawing.Point(800, 25);
            this.txtIva.Name = "txtIva";
            this.txtIva.ReadOnly = true;
            this.txtIva.Size = new System.Drawing.Size(150, 20);
            this.txtIva.TabIndex = 3;
            this.txtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Location = new System.Drawing.Point(765, 28);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(27, 13);
            this.lblIva.TabIndex = 2;
            this.lblIva.Text = "IVA:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(800, 5);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(150, 20);
            this.txtSubtotal.TabIndex = 1;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(745, 8);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Controls.Add(this.btnImprimir);
            this.pnlBotones.Controls.Add(this.btnGuardar);
            this.pnlBotones.Controls.Add(this.btnAgregarConcepto);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotones.Location = new System.Drawing.Point(0, 631);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(984, 50);
            this.pnlBotones.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(885, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(804, 15);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(723, 15);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnAgregarConcepto
            // 
            this.btnAgregarConcepto.Location = new System.Drawing.Point(32, 15);
            this.btnAgregarConcepto.Name = "btnAgregarConcepto";
            this.btnAgregarConcepto.Size = new System.Drawing.Size(120, 23);
            this.btnAgregarConcepto.TabIndex = 0;
            this.btnAgregarConcepto.Text = "Agregar Concepto";
            this.btnAgregarConcepto.UseVisualStyleBackColor = true;
            // 
            // frmEmisionNotaDebito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 681);
            this.Controls.Add(this.pnlDetalle);
            this.Controls.Add(this.pnlTotales);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlCabecera);
            this.Name = "frmEmisionNotaDebito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emisión - Nota de Débito ";
            this.pnlCabecera.ResumeLayout(false);
            this.gbDatosFiscales.ResumeLayout(false);
            this.gbDatosFiscales.PerformLayout();
            this.gbDatosCliente.ResumeLayout(false);
            this.gbDatosCliente.PerformLayout();
            this.gbDatosNotaDebito.ResumeLayout(false);
            this.gbDatosNotaDebito.PerformLayout();
            this.pnlDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleNotaDebito)).EndInit();
            this.pnlTotales.ResumeLayout(false);
            this.pnlTotales.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.GroupBox gbDatosNotaDebito;
        private System.Windows.Forms.ComboBox cmbMotivo;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox txtNumeroNotaDebito;
        private System.Windows.Forms.Label lblNumeroNotaDebito;
        private System.Windows.Forms.DateTimePicker dtpFechaEmision;
        private System.Windows.Forms.Label lblFechaEmision;
        private System.Windows.Forms.GroupBox gbDatosCliente;
        private System.Windows.Forms.TextBox txtComprobanteOrigen;
        private System.Windows.Forms.Label lblComprobanteOrigen;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.Label lblDireccionCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnBuscarComprobante;
        private System.Windows.Forms.GroupBox gbDatosFiscales;
        private System.Windows.Forms.TextBox txtCondicionIva;
        private System.Windows.Forms.Label lblCondicionIva;
        private System.Windows.Forms.TextBox txtCuitCliente;
        private System.Windows.Forms.Label lblCuitCliente;
        private System.Windows.Forms.Panel pnlDetalle;
        private System.Windows.Forms.DataGridView dgvDetalleNotaDebito;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConcepto;
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
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAgregarConcepto;
    }
}