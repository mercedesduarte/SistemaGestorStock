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
            this.pnlCabecera = new System.Windows.Forms.Panel();
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
            this.gbDatosPresupuesto = new System.Windows.Forms.GroupBox();
            this.nudDiasValidez = new System.Windows.Forms.NumericUpDown();
            this.lblDiasValidez = new System.Windows.Forms.Label();
            this.txtNumeroPresupuesto = new System.Windows.Forms.TextBox();
            this.lblNumeroPresupuesto = new System.Windows.Forms.Label();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.dtpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.lblFechaEmision = new System.Windows.Forms.Label();
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
            this.btnConvertirPedido = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.pnlCabecera.SuspendLayout();
            this.gbDatosCliente.SuspendLayout();
            this.gbDatosPresupuesto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiasValidez)).BeginInit();
            this.pnlDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePresupuesto)).BeginInit();
            this.pnlTotales.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.Controls.Add(this.gbDatosCliente);
            this.pnlCabecera.Controls.Add(this.gbDatosPresupuesto);
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(984, 180);
            this.pnlCabecera.TabIndex = 0;
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
            this.gbDatosCliente.Location = new System.Drawing.Point(318, 12);
            this.gbDatosCliente.Name = "gbDatosCliente";
            this.gbDatosCliente.Size = new System.Drawing.Size(654, 155);
            this.gbDatosCliente.TabIndex = 1;
            this.gbDatosCliente.TabStop = false;
            this.gbDatosCliente.Text = "Datos del Cliente";
            // 
            // txtCondicionVenta
            // 
            this.txtCondicionVenta.Location = new System.Drawing.Point(120, 125);
            this.txtCondicionVenta.Name = "txtCondicionVenta";
            this.txtCondicionVenta.Size = new System.Drawing.Size(200, 20);
            this.txtCondicionVenta.TabIndex = 10;
            this.txtCondicionVenta.Text = "Contado";
            // 
            // lblCondicionVenta
            // 
            this.lblCondicionVenta.AutoSize = true;
            this.lblCondicionVenta.Location = new System.Drawing.Point(16, 128);
            this.lblCondicionVenta.Name = "lblCondicionVenta";
            this.lblCondicionVenta.Size = new System.Drawing.Size(88, 13);
            this.lblCondicionVenta.TabIndex = 9;
            this.lblCondicionVenta.Text = "Condición Venta:";
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.Location = new System.Drawing.Point(430, 75);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.ReadOnly = true;
            this.txtTelefonoCliente.Size = new System.Drawing.Size(200, 20);
            this.txtTelefonoCliente.TabIndex = 8;
            // 
            // lblTelefonoCliente
            // 
            this.lblTelefonoCliente.AutoSize = true;
            this.lblTelefonoCliente.Location = new System.Drawing.Point(370, 78);
            this.lblTelefonoCliente.Name = "lblTelefonoCliente";
            this.lblTelefonoCliente.Size = new System.Drawing.Size(52, 13);
            this.lblTelefonoCliente.TabIndex = 7;
            this.lblTelefonoCliente.Text = "Teléfono:";
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Location = new System.Drawing.Point(430, 100);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.ReadOnly = true;
            this.txtEmailCliente.Size = new System.Drawing.Size(200, 20);
            this.txtEmailCliente.TabIndex = 6;
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.Location = new System.Drawing.Point(370, 103);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(35, 13);
            this.lblEmailCliente.TabIndex = 5;
            this.lblEmailCliente.Text = "Email:";
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Location = new System.Drawing.Point(120, 75);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.ReadOnly = true;
            this.txtDireccionCliente.Size = new System.Drawing.Size(200, 20);
            this.txtDireccionCliente.TabIndex = 4;
            // 
            // lblDireccionCliente
            // 
            this.lblDireccionCliente.AutoSize = true;
            this.lblDireccionCliente.Location = new System.Drawing.Point(16, 78);
            this.lblDireccionCliente.Name = "lblDireccionCliente";
            this.lblDireccionCliente.Size = new System.Drawing.Size(55, 13);
            this.lblDireccionCliente.TabIndex = 3;
            this.lblDireccionCliente.Text = "Dirección:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(120, 45);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(200, 20);
            this.txtNombreCliente.TabIndex = 2;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(16, 48);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(89, 13);
            this.lblNombreCliente.TabIndex = 1;
            this.lblNombreCliente.Text = "Nombre/Apellido:";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(326, 42);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(60, 25);
            this.btnBuscarCliente.TabIndex = 0;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
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
            this.gbDatosPresupuesto.Location = new System.Drawing.Point(12, 12);
            this.gbDatosPresupuesto.Name = "gbDatosPresupuesto";
            this.gbDatosPresupuesto.Size = new System.Drawing.Size(300, 155);
            this.gbDatosPresupuesto.TabIndex = 0;
            this.gbDatosPresupuesto.TabStop = false;
            this.gbDatosPresupuesto.Text = "Datos del Presupuesto";
            // 
            // nudDiasValidez
            // 
            this.nudDiasValidez.Location = new System.Drawing.Point(120, 100);
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
            this.nudDiasValidez.Size = new System.Drawing.Size(60, 20);
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
            this.lblDiasValidez.Location = new System.Drawing.Point(16, 102);
            this.lblDiasValidez.Name = "lblDiasValidez";
            this.lblDiasValidez.Size = new System.Drawing.Size(84, 13);
            this.lblDiasValidez.TabIndex = 6;
            this.lblDiasValidez.Text = "Días de validez:";
            // 
            // txtNumeroPresupuesto
            // 
            this.txtNumeroPresupuesto.Location = new System.Drawing.Point(120, 25);
            this.txtNumeroPresupuesto.Name = "txtNumeroPresupuesto";
            this.txtNumeroPresupuesto.ReadOnly = true;
            this.txtNumeroPresupuesto.Size = new System.Drawing.Size(120, 20);
            this.txtNumeroPresupuesto.TabIndex = 5;
            this.txtNumeroPresupuesto.Text = "PRE-00000001";
            // 
            // lblNumeroPresupuesto
            // 
            this.lblNumeroPresupuesto.AutoSize = true;
            this.lblNumeroPresupuesto.Location = new System.Drawing.Point(16, 28);
            this.lblNumeroPresupuesto.Name = "lblNumeroPresupuesto";
            this.lblNumeroPresupuesto.Size = new System.Drawing.Size(47, 13);
            this.lblNumeroPresupuesto.TabIndex = 4;
            this.lblNumeroPresupuesto.Text = "Número:";
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(120, 75);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(120, 20);
            this.dtpFechaVencimiento.TabIndex = 3;
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(16, 78);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(68, 13);
            this.lblFechaVencimiento.TabIndex = 2;
            this.lblFechaVencimiento.Text = "Vencimiento:";
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
            this.pnlDetalle.Controls.Add(this.dgvDetallePresupuesto);
            this.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetalle.Location = new System.Drawing.Point(0, 180);
            this.pnlDetalle.Name = "pnlDetalle";
            this.pnlDetalle.Size = new System.Drawing.Size(984, 351);
            this.pnlDetalle.TabIndex = 1;
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
            this.dgvDetallePresupuesto.Location = new System.Drawing.Point(0, 0);
            this.dgvDetallePresupuesto.Name = "dgvDetallePresupuesto";
            this.dgvDetallePresupuesto.ReadOnly = true;
            this.dgvDetallePresupuesto.Size = new System.Drawing.Size(984, 351);
            this.dgvDetallePresupuesto.TabIndex = 0;
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
            // colDescuento
            // 
            this.colDescuento.HeaderText = "Descuento";
            this.colDescuento.Name = "colDescuento";
            this.colDescuento.ReadOnly = true;
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
            this.pnlTotales.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTotales.Location = new System.Drawing.Point(0, 531);
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
            this.txtTotal.Location = new System.Drawing.Point(800, 25);
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
            this.lblTotal.Location = new System.Drawing.Point(740, 28);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 20);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnConvertirPedido);
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Controls.Add(this.btnImprimir);
            this.pnlBotones.Controls.Add(this.btnGuardar);
            this.pnlBotones.Controls.Add(this.btnAgregarProducto);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotones.Location = new System.Drawing.Point(0, 611);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(984, 50);
            this.pnlBotones.TabIndex = 3;
            // 
            // btnConvertirPedido
            // 
            this.btnConvertirPedido.Location = new System.Drawing.Point(200, 15);
            this.btnConvertirPedido.Name = "btnConvertirPedido";
            this.btnConvertirPedido.Size = new System.Drawing.Size(120, 23);
            this.btnConvertirPedido.TabIndex = 4;
            this.btnConvertirPedido.Text = "Convertir a Pedido";
            this.btnConvertirPedido.UseVisualStyleBackColor = true;
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
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(32, 15);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(120, 23);
            this.btnAgregarProducto.TabIndex = 0;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // frmEmisionPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.pnlDetalle);
            this.Controls.Add(this.pnlTotales);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlCabecera);
            this.Name = "frmEmisionPresupuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emisión - Presupuesto de Venta ";
            this.pnlCabecera.ResumeLayout(false);
            this.gbDatosCliente.ResumeLayout(false);
            this.gbDatosCliente.PerformLayout();
            this.gbDatosPresupuesto.ResumeLayout(false);
            this.gbDatosPresupuesto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiasValidez)).EndInit();
            this.pnlDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePresupuesto)).EndInit();
            this.pnlTotales.ResumeLayout(false);
            this.pnlTotales.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabecera;
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
        private System.Windows.Forms.Button btnConvertirPedido;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAgregarProducto;
    }
}