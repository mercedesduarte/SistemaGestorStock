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
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDatosProducto = new System.Windows.Forms.GroupBox();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblStockActual = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
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
            this.pnlDatosFactura = new System.Windows.Forms.Panel();
            this.lblFactura = new System.Windows.Forms.Label();
            this.txtNroFactura = new System.Windows.Forms.TextBox();
            this.lblNroFactura = new System.Windows.Forms.Label();
            this.dtpFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFactura = new System.Windows.Forms.Label();
            this.txtNroPedido = new System.Windows.Forms.TextBox();
            this.lblNroPedido = new System.Windows.Forms.Label();
            this.dtpFechaVto = new System.Windows.Forms.DateTimePicker();
            this.lblFechaVto = new System.Windows.Forms.Label();
            this.lblLineaSeparacion = new System.Windows.Forms.Label();
            this.pnlBotones.SuspendLayout();
            this.gbDatosProducto.SuspendLayout();
            this.gbDatosCliente.SuspendLayout();
            this.pnlDatosFactura.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotones
            // 
            this.pnlBotones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBotones.Controls.Add(this.btnConfirmar);
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Location = new System.Drawing.Point(23, 558);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(980, 60);
            this.pnlBotones.TabIndex = 7;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.LightGreen;
            this.btnConfirmar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(780, 15);
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
            this.btnCancelar.Location = new System.Drawing.Point(880, 15);
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
            this.label1.Location = new System.Drawing.Point(150, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(784, 49);
            this.label1.TabIndex = 15;
            this.label1.Text = "REGISTRO DE FACTURA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // gbDatosProducto
            // 
            this.gbDatosProducto.Controls.Add(this.txtPrecioUnitario);
            this.gbDatosProducto.Controls.Add(this.label3);
            this.gbDatosProducto.Controls.Add(this.txtCantidad);
            this.gbDatosProducto.Controls.Add(this.lblStockActual);
            this.gbDatosProducto.Controls.Add(this.txtCategoria);
            this.gbDatosProducto.Controls.Add(this.lblCategoria);
            this.gbDatosProducto.Controls.Add(this.txtMarca);
            this.gbDatosProducto.Controls.Add(this.lblMarca);
            this.gbDatosProducto.Controls.Add(this.txtProducto);
            this.gbDatosProducto.Controls.Add(this.lblProducto);
            this.gbDatosProducto.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosProducto.Location = new System.Drawing.Point(520, 250);
            this.gbDatosProducto.Name = "gbDatosProducto";
            this.gbDatosProducto.Size = new System.Drawing.Size(480, 255);
            this.gbDatosProducto.TabIndex = 17;
            this.gbDatosProducto.TabStop = false;
            this.gbDatosProducto.Text = "DATOS DEL PRODUCTO";
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioUnitario.Location = new System.Drawing.Point(160, 170);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.ReadOnly = true;
            this.txtPrecioUnitario.Size = new System.Drawing.Size(100, 26);
            this.txtPrecioUnitario.TabIndex = 10;
            this.txtPrecioUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Precio Unit.:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(160, 134);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(100, 26);
            this.txtCantidad.TabIndex = 8;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblStockActual
            // 
            this.lblStockActual.AutoSize = true;
            this.lblStockActual.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockActual.Location = new System.Drawing.Point(20, 137);
            this.lblStockActual.Name = "lblStockActual";
            this.lblStockActual.Size = new System.Drawing.Size(81, 19);
            this.lblStockActual.TabIndex = 7;
            this.lblStockActual.Text = "Cantidad";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(160, 102);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.Size = new System.Drawing.Size(300, 26);
            this.txtCategoria.TabIndex = 6;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(20, 105);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(99, 19);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoría:";
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(160, 72);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.ReadOnly = true;
            this.txtMarca.Size = new System.Drawing.Size(300, 26);
            this.txtMarca.TabIndex = 4;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(20, 75);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(63, 19);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca:";
            // 
            // txtProducto
            // 
            this.txtProducto.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(160, 42);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(300, 26);
            this.txtProducto.TabIndex = 2;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(20, 45);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(90, 19);
            this.lblProducto.TabIndex = 1;
            this.lblProducto.Text = "Producto:";
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
            this.gbDatosCliente.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosCliente.Location = new System.Drawing.Point(20, 250);
            this.gbDatosCliente.Name = "gbDatosCliente";
            this.gbDatosCliente.Size = new System.Drawing.Size(480, 270);
            this.gbDatosCliente.TabIndex = 16;
            this.gbDatosCliente.TabStop = false;
            this.gbDatosCliente.Text = "DATOS DEL CLIENTE";
            // 
            // txtCondicionVenta
            // 
            this.txtCondicionVenta.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCondicionVenta.Location = new System.Drawing.Point(160, 181);
            this.txtCondicionVenta.Name = "txtCondicionVenta";
            this.txtCondicionVenta.Size = new System.Drawing.Size(200, 26);
            this.txtCondicionVenta.TabIndex = 10;
            this.txtCondicionVenta.Text = "Contado";
            // 
            // lblCondicionVenta
            // 
            this.lblCondicionVenta.AutoSize = true;
            this.lblCondicionVenta.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondicionVenta.Location = new System.Drawing.Point(20, 184);
            this.lblCondicionVenta.Name = "lblCondicionVenta";
            this.lblCondicionVenta.Size = new System.Drawing.Size(117, 19);
            this.lblCondicionVenta.TabIndex = 9;
            this.lblCondicionVenta.Text = "Cond. Venta:";
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoCliente.Location = new System.Drawing.Point(160, 151);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.ReadOnly = true;
            this.txtTelefonoCliente.Size = new System.Drawing.Size(200, 26);
            this.txtTelefonoCliente.TabIndex = 8;
            // 
            // lblTelefonoCliente
            // 
            this.lblTelefonoCliente.AutoSize = true;
            this.lblTelefonoCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoCliente.Location = new System.Drawing.Point(20, 154);
            this.lblTelefonoCliente.Name = "lblTelefonoCliente";
            this.lblTelefonoCliente.Size = new System.Drawing.Size(90, 19);
            this.lblTelefonoCliente.TabIndex = 7;
            this.lblTelefonoCliente.Text = "Teléfono:";
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailCliente.Location = new System.Drawing.Point(160, 121);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.ReadOnly = true;
            this.txtEmailCliente.Size = new System.Drawing.Size(300, 26);
            this.txtEmailCliente.TabIndex = 6;
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailCliente.Location = new System.Drawing.Point(20, 124);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(63, 19);
            this.lblEmailCliente.TabIndex = 5;
            this.lblEmailCliente.Text = "Email:";
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionCliente.Location = new System.Drawing.Point(160, 89);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.ReadOnly = true;
            this.txtDireccionCliente.Size = new System.Drawing.Size(300, 26);
            this.txtDireccionCliente.TabIndex = 4;
            // 
            // lblDireccionCliente
            // 
            this.lblDireccionCliente.AutoSize = true;
            this.lblDireccionCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionCliente.Location = new System.Drawing.Point(20, 92);
            this.lblDireccionCliente.Name = "lblDireccionCliente";
            this.lblDireccionCliente.Size = new System.Drawing.Size(99, 19);
            this.lblDireccionCliente.TabIndex = 3;
            this.lblDireccionCliente.Text = "Dirección:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(160, 55);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(300, 26);
            this.txtNombreCliente.TabIndex = 2;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(8, 61);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(126, 19);
            this.lblNombreCliente.TabIndex = 1;
            this.lblNombreCliente.Text = "Nombre/Razón:";
            // 
            // pnlDatosFactura
            // 
            this.pnlDatosFactura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDatosFactura.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlDatosFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDatosFactura.Controls.Add(this.lblFactura);
            this.pnlDatosFactura.Controls.Add(this.txtNroFactura);
            this.pnlDatosFactura.Controls.Add(this.lblNroFactura);
            this.pnlDatosFactura.Controls.Add(this.dtpFechaFactura);
            this.pnlDatosFactura.Controls.Add(this.lblFechaFactura);
            this.pnlDatosFactura.Controls.Add(this.txtNroPedido);
            this.pnlDatosFactura.Controls.Add(this.lblNroPedido);
            this.pnlDatosFactura.Controls.Add(this.dtpFechaVto);
            this.pnlDatosFactura.Controls.Add(this.lblFechaVto);
            this.pnlDatosFactura.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDatosFactura.Location = new System.Drawing.Point(20, 90);
            this.pnlDatosFactura.Name = "pnlDatosFactura";
            this.pnlDatosFactura.Size = new System.Drawing.Size(980, 140);
            this.pnlDatosFactura.TabIndex = 18;
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactura.ForeColor = System.Drawing.Color.DarkRed;
            this.lblFactura.Location = new System.Drawing.Point(20, 15);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(103, 28);
            this.lblFactura.TabIndex = 8;
            this.lblFactura.Text = "FACTURA";
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroFactura.Location = new System.Drawing.Point(170, 50);
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.Size = new System.Drawing.Size(150, 30);
            this.txtNroFactura.TabIndex = 7;
            this.txtNroFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNroFactura
            // 
            this.lblNroFactura.AutoSize = true;
            this.lblNroFactura.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroFactura.Location = new System.Drawing.Point(20, 57);
            this.lblNroFactura.Name = "lblNroFactura";
            this.lblNroFactura.Size = new System.Drawing.Size(108, 19);
            this.lblNroFactura.TabIndex = 6;
            this.lblNroFactura.Text = "Nº FACTURA:";
            // 
            // dtpFechaFactura
            // 
            this.dtpFechaFactura.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaFactura.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFactura.Location = new System.Drawing.Point(170, 90);
            this.dtpFechaFactura.Name = "dtpFechaFactura";
            this.dtpFechaFactura.Size = new System.Drawing.Size(150, 26);
            this.dtpFechaFactura.TabIndex = 5;
            // 
            // lblFechaFactura
            // 
            this.lblFechaFactura.AutoSize = true;
            this.lblFechaFactura.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFactura.Location = new System.Drawing.Point(20, 96);
            this.lblFechaFactura.Name = "lblFechaFactura";
            this.lblFechaFactura.Size = new System.Drawing.Size(135, 19);
            this.lblFechaFactura.TabIndex = 4;
            this.lblFechaFactura.Text = "FECHA EMISIÓN:";
            // 
            // txtNroPedido
            // 
            this.txtNroPedido.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroPedido.Location = new System.Drawing.Point(520, 50);
            this.txtNroPedido.Name = "txtNroPedido";
            this.txtNroPedido.Size = new System.Drawing.Size(150, 26);
            this.txtNroPedido.TabIndex = 3;
            this.txtNroPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNroPedido
            // 
            this.lblNroPedido.AutoSize = true;
            this.lblNroPedido.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroPedido.Location = new System.Drawing.Point(370, 53);
            this.lblNroPedido.Name = "lblNroPedido";
            this.lblNroPedido.Size = new System.Drawing.Size(99, 19);
            this.lblNroPedido.TabIndex = 2;
            this.lblNroPedido.Text = "Nº PEDIDO:";
            // 
            // dtpFechaVto
            // 
            this.dtpFechaVto.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaVto.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVto.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaVto.Location = new System.Drawing.Point(520, 90);
            this.dtpFechaVto.Name = "dtpFechaVto";
            this.dtpFechaVto.Size = new System.Drawing.Size(150, 26);
            this.dtpFechaVto.TabIndex = 1;
            // 
            // lblFechaVto
            // 
            this.lblFechaVto.AutoSize = true;
            this.lblFechaVto.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVto.Location = new System.Drawing.Point(370, 96);
            this.lblFechaVto.Name = "lblFechaVto";
            this.lblFechaVto.Size = new System.Drawing.Size(108, 19);
            this.lblFechaVto.TabIndex = 0;
            this.lblFechaVto.Text = "FECHA VTO.:";
            // 
            // lblLineaSeparacion
            // 
            this.lblLineaSeparacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLineaSeparacion.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblLineaSeparacion.Location = new System.Drawing.Point(20, 240);
            this.lblLineaSeparacion.Name = "lblLineaSeparacion";
            this.lblLineaSeparacion.Size = new System.Drawing.Size(980, 3);
            this.lblLineaSeparacion.TabIndex = 19;
            // 
            // frmRegistroPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 749);
            this.Controls.Add(this.lblLineaSeparacion);
            this.Controls.Add(this.pnlDatosFactura);
            this.Controls.Add(this.gbDatosProducto);
            this.Controls.Add(this.gbDatosCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlBotones);
            this.MinimumSize = new System.Drawing.Size(1040, 726);
            this.Name = "frmRegistroPresupuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Factura";
            this.pnlBotones.ResumeLayout(false);
            this.gbDatosProducto.ResumeLayout(false);
            this.gbDatosProducto.PerformLayout();
            this.gbDatosCliente.ResumeLayout(false);
            this.gbDatosCliente.PerformLayout();
            this.pnlDatosFactura.ResumeLayout(false);
            this.pnlDatosFactura.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDatosProducto;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblStockActual;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblProducto;
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
        private System.Windows.Forms.Panel pnlDatosFactura;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.TextBox txtNroFactura;
        private System.Windows.Forms.Label lblNroFactura;
        private System.Windows.Forms.DateTimePicker dtpFechaFactura;
        private System.Windows.Forms.Label lblFechaFactura;
        private System.Windows.Forms.TextBox txtNroPedido;
        private System.Windows.Forms.Label lblNroPedido;
        private System.Windows.Forms.DateTimePicker dtpFechaVto;
        private System.Windows.Forms.Label lblFechaVto;
        private System.Windows.Forms.Label lblLineaSeparacion;
    }
}