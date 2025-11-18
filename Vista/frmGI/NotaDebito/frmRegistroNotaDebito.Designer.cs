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
            this.gbControlInterno = new System.Windows.Forms.GroupBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtUsuarioCreacion = new System.Windows.Forms.TextBox();
            this.lblUsuarioCreacion = new System.Windows.Forms.Label();
            this.txtFechaHoraCreacion = new System.Windows.Forms.TextBox();
            this.lblFechaHoraCreacion = new System.Windows.Forms.Label();
            this.txtIDNotaDebito = new System.Windows.Forms.TextBox();
            this.lblIDNotaDebito = new System.Windows.Forms.Label();
            this.gbDatosProducto = new System.Windows.Forms.GroupBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
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
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnVerMovimientos = new System.Windows.Forms.Button();
            this.btnAplicarCobro = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbControlInterno.SuspendLayout();
            this.gbDatosProducto.SuspendLayout();
            this.gbDatosCliente.SuspendLayout();
            this.gbComprobanteOrigen.SuspendLayout();
            this.pnlDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleRegistro)).BeginInit();
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
            this.gbControlInterno.Controls.Add(this.txtIDNotaDebito);
            this.gbControlInterno.Controls.Add(this.lblIDNotaDebito);
            this.gbControlInterno.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbControlInterno.Location = new System.Drawing.Point(20, 80);
            this.gbControlInterno.Name = "gbControlInterno";
            this.gbControlInterno.Size = new System.Drawing.Size(450, 200);
            this.gbControlInterno.TabIndex = 1;
            this.gbControlInterno.TabStop = false;
            this.gbControlInterno.Text = "CONTROL INTERNO";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Pendiente",
            "Aprobada",
            "Aplicada",
            "Cobrada",
            "Anulada",
            "Contabilizada"});
            this.cmbEstado.Location = new System.Drawing.Point(140, 140);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(280, 27);
            this.cmbEstado.TabIndex = 7;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(20, 143);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(72, 19);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Estado:";
            // 
            // txtUsuarioCreacion
            // 
            this.txtUsuarioCreacion.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioCreacion.Location = new System.Drawing.Point(140, 105);
            this.txtUsuarioCreacion.Name = "txtUsuarioCreacion";
            this.txtUsuarioCreacion.ReadOnly = true;
            this.txtUsuarioCreacion.Size = new System.Drawing.Size(280, 26);
            this.txtUsuarioCreacion.TabIndex = 5;
            // 
            // lblUsuarioCreacion
            // 
            this.lblUsuarioCreacion.AutoSize = true;
            this.lblUsuarioCreacion.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioCreacion.Location = new System.Drawing.Point(20, 108);
            this.lblUsuarioCreacion.Name = "lblUsuarioCreacion";
            this.lblUsuarioCreacion.Size = new System.Drawing.Size(126, 19);
            this.lblUsuarioCreacion.TabIndex = 4;
            this.lblUsuarioCreacion.Text = "Usuario Crea:";
            // 
            // txtFechaHoraCreacion
            // 
            this.txtFechaHoraCreacion.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaHoraCreacion.Location = new System.Drawing.Point(140, 70);
            this.txtFechaHoraCreacion.Name = "txtFechaHoraCreacion";
            this.txtFechaHoraCreacion.ReadOnly = true;
            this.txtFechaHoraCreacion.Size = new System.Drawing.Size(280, 26);
            this.txtFechaHoraCreacion.TabIndex = 3;
            // 
            // lblFechaHoraCreacion
            // 
            this.lblFechaHoraCreacion.AutoSize = true;
            this.lblFechaHoraCreacion.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHoraCreacion.Location = new System.Drawing.Point(20, 73);
            this.lblFechaHoraCreacion.Name = "lblFechaHoraCreacion";
            this.lblFechaHoraCreacion.Size = new System.Drawing.Size(108, 19);
            this.lblFechaHoraCreacion.TabIndex = 2;
            this.lblFechaHoraCreacion.Text = "Fecha Crea:";
            // 
            // txtIDNotaDebito
            // 
            this.txtIDNotaDebito.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDNotaDebito.Location = new System.Drawing.Point(140, 35);
            this.txtIDNotaDebito.Name = "txtIDNotaDebito";
            this.txtIDNotaDebito.ReadOnly = true;
            this.txtIDNotaDebito.Size = new System.Drawing.Size(200, 26);
            this.txtIDNotaDebito.TabIndex = 1;
            // 
            // lblIDNotaDebito
            // 
            this.lblIDNotaDebito.AutoSize = true;
            this.lblIDNotaDebito.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDNotaDebito.Location = new System.Drawing.Point(20, 38);
            this.lblIDNotaDebito.Name = "lblIDNotaDebito";
            this.lblIDNotaDebito.Size = new System.Drawing.Size(36, 19);
            this.lblIDNotaDebito.TabIndex = 0;
            this.lblIDNotaDebito.Text = "ID:";
            // 
            // gbDatosProducto
            // 
            this.gbDatosProducto.Controls.Add(this.txtCategoria);
            this.gbDatosProducto.Controls.Add(this.lblCategoria);
            this.gbDatosProducto.Controls.Add(this.txtMarca);
            this.gbDatosProducto.Controls.Add(this.lblMarca);
            this.gbDatosProducto.Controls.Add(this.txtProveedor);
            this.gbDatosProducto.Controls.Add(this.lblProveedor);
            this.gbDatosProducto.Controls.Add(this.txtProducto);
            this.gbDatosProducto.Controls.Add(this.lblProducto);
            this.gbDatosProducto.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosProducto.Location = new System.Drawing.Point(500, 80);
            this.gbDatosProducto.Name = "gbDatosProducto";
            this.gbDatosProducto.Size = new System.Drawing.Size(450, 200);
            this.gbDatosProducto.TabIndex = 2;
            this.gbDatosProducto.TabStop = false;
            this.gbDatosProducto.Text = "DATOS DEL PRODUCTO";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(140, 140);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.Size = new System.Drawing.Size(280, 26);
            this.txtCategoria.TabIndex = 7;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(20, 143);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(99, 19);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Categoría:";
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(140, 105);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.ReadOnly = true;
            this.txtMarca.Size = new System.Drawing.Size(280, 26);
            this.txtMarca.TabIndex = 5;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(20, 108);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(63, 19);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca:";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.Location = new System.Drawing.Point(140, 70);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.ReadOnly = true;
            this.txtProveedor.Size = new System.Drawing.Size(280, 26);
            this.txtProveedor.TabIndex = 3;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(20, 73);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(99, 19);
            this.lblProveedor.TabIndex = 2;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // txtProducto
            // 
            this.txtProducto.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(140, 35);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(280, 26);
            this.txtProducto.TabIndex = 1;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(20, 38);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(90, 19);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Producto:";
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
            this.gbDatosCliente.Location = new System.Drawing.Point(20, 300);
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
            this.gbComprobanteOrigen.Location = new System.Drawing.Point(500, 300);
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
            this.pnlDetalle.Location = new System.Drawing.Point(20, 500);
            this.pnlDetalle.Name = "pnlDetalle";
            this.pnlDetalle.Size = new System.Drawing.Size(930, 138);
            this.pnlDetalle.TabIndex = 5;
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
            this.dgvDetalleRegistro.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetalleRegistro.Location = new System.Drawing.Point(0, 0);
            this.dgvDetalleRegistro.Name = "dgvDetalleRegistro";
            this.dgvDetalleRegistro.ReadOnly = true;
            this.dgvDetalleRegistro.Size = new System.Drawing.Size(930, 138);
            this.dgvDetalleRegistro.TabIndex = 0;
            // 
            // colIDConcepto
            // 
            this.colIDConcepto.HeaderText = "ID CONCEPTO";
            this.colIDConcepto.Name = "colIDConcepto";
            this.colIDConcepto.ReadOnly = true;
            this.colIDConcepto.Visible = false;
            // 
            // colConcepto
            // 
            this.colConcepto.HeaderText = "CONCEPTO";
            this.colConcepto.Name = "colConcepto";
            this.colConcepto.ReadOnly = true;
            this.colConcepto.Width = 150;
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
            // pnlBotones
            // 
            this.pnlBotones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBotones.Controls.Add(this.btnVerMovimientos);
            this.pnlBotones.Controls.Add(this.btnAplicarCobro);
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Controls.Add(this.btnConfirmar);
            this.pnlBotones.Location = new System.Drawing.Point(20, 658);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(930, 60);
            this.pnlBotones.TabIndex = 6;
            // 
            // btnVerMovimientos
            // 
            this.btnVerMovimientos.BackColor = System.Drawing.Color.LightYellow;
            this.btnVerMovimientos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerMovimientos.Location = new System.Drawing.Point(20, 15);
            this.btnVerMovimientos.Name = "btnVerMovimientos";
            this.btnVerMovimientos.Size = new System.Drawing.Size(180, 35);
            this.btnVerMovimientos.TabIndex = 3;
            this.btnVerMovimientos.Text = "VER MOVIMIENTOS";
            this.btnVerMovimientos.UseVisualStyleBackColor = false;
            // 
            // btnAplicarCobro
            // 
            this.btnAplicarCobro.BackColor = System.Drawing.Color.LightCoral;
            this.btnAplicarCobro.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicarCobro.Location = new System.Drawing.Point(210, 15);
            this.btnAplicarCobro.Name = "btnAplicarCobro";
            this.btnAplicarCobro.Size = new System.Drawing.Size(150, 35);
            this.btnAplicarCobro.TabIndex = 2;
            this.btnAplicarCobro.Text = "APLICAR COBRO";
            this.btnAplicarCobro.UseVisualStyleBackColor = false;
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(872, 49);
            this.label1.TabIndex = 13;
            this.label1.Text = "Registro Nota Debit";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmRegistroNotaDebito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlDetalle);
            this.Controls.Add(this.gbComprobanteOrigen);
            this.Controls.Add(this.gbDatosCliente);
            this.Controls.Add(this.gbDatosProducto);
            this.Controls.Add(this.gbControlInterno);
            this.MinimumSize = new System.Drawing.Size(1000, 726);
            this.Name = "frmRegistroNotaDebito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro - Nota de Débito";
            this.gbControlInterno.ResumeLayout(false);
            this.gbControlInterno.PerformLayout();
            this.gbDatosProducto.ResumeLayout(false);
            this.gbDatosProducto.PerformLayout();
            this.gbDatosCliente.ResumeLayout(false);
            this.gbDatosCliente.PerformLayout();
            this.gbComprobanteOrigen.ResumeLayout(false);
            this.gbComprobanteOrigen.PerformLayout();
            this.pnlDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleRegistro)).EndInit();
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
        private System.Windows.Forms.TextBox txtIDNotaDebito;
        private System.Windows.Forms.Label lblIDNotaDebito;
        private System.Windows.Forms.GroupBox gbDatosProducto;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblProducto;
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
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnVerMovimientos;
        private System.Windows.Forms.Button btnAplicarCobro;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label1;
    }
}