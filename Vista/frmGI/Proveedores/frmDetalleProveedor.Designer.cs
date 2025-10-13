namespace Vista.frmGI.Proveedores
{
    partial class frmDetalleProveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleProveedor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.btnGuardarGeneral = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTiempoEntrega = new System.Windows.Forms.Label();
            this.nudTiempoEntrega = new System.Windows.Forms.NumericUpDown();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.cmbFormaPago = new System.Windows.Forms.ComboBox();
            this.lblCuit = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.tabTelefonos = new System.Windows.Forms.TabPage();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnModificarTelefono = new System.Windows.Forms.Button();
            this.btnAgregarTelefono = new System.Windows.Forms.Button();
            this.dgvTelefonos = new System.Windows.Forms.DataGridView();
            this.tabDirecciones = new System.Windows.Forms.TabPage();
            this.btnModificarDireccion = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnAgregarDireccion = new System.Windows.Forms.Button();
            this.dgvDirecciones = new System.Windows.Forms.DataGridView();
            this.tabProductos = new System.Windows.Forms.TabPage();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.TabControl1.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTiempoEntrega)).BeginInit();
            this.tabTelefonos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonos)).BeginInit();
            this.tabDirecciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirecciones)).BeginInit();
            this.tabProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(798, 54);
            this.label1.TabIndex = 20;
            this.label1.Text = "DETALLES DEL PROVEEDOR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TabControl1
            // 
            this.TabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TabControl1.Controls.Add(this.tabGeneral);
            this.TabControl1.Controls.Add(this.tabTelefonos);
            this.TabControl1.Controls.Add(this.tabDirecciones);
            this.TabControl1.Controls.Add(this.tabProductos);
            this.TabControl1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.TabControl1.Location = new System.Drawing.Point(12, 86);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(798, 487);
            this.TabControl1.TabIndex = 21;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.btnGuardarGeneral);
            this.tabGeneral.Controls.Add(this.btnCerrar);
            this.tabGeneral.Controls.Add(this.chkActivo);
            this.tabGeneral.Controls.Add(this.lblDescuento);
            this.tabGeneral.Controls.Add(this.txtDescuento);
            this.tabGeneral.Controls.Add(this.lblEmail);
            this.tabGeneral.Controls.Add(this.txtEmail);
            this.tabGeneral.Controls.Add(this.lblTiempoEntrega);
            this.tabGeneral.Controls.Add(this.nudTiempoEntrega);
            this.tabGeneral.Controls.Add(this.lblFormaPago);
            this.tabGeneral.Controls.Add(this.cmbFormaPago);
            this.tabGeneral.Controls.Add(this.lblCuit);
            this.tabGeneral.Controls.Add(this.txtCuit);
            this.tabGeneral.Controls.Add(this.lblCodigo);
            this.tabGeneral.Controls.Add(this.txtCodigo);
            this.tabGeneral.Controls.Add(this.lblRazonSocial);
            this.tabGeneral.Controls.Add(this.txtRazonSocial);
            this.tabGeneral.Location = new System.Drawing.Point(4, 33);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(790, 450);
            this.tabGeneral.TabIndex = 3;
            this.tabGeneral.Text = "GENERAL";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // btnGuardarGeneral
            // 
            this.btnGuardarGeneral.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGuardarGeneral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarGeneral.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGuardarGeneral.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuardarGeneral.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarGeneral.Image")));
            this.btnGuardarGeneral.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarGeneral.Location = new System.Drawing.Point(99, 330);
            this.btnGuardarGeneral.Name = "btnGuardarGeneral";
            this.btnGuardarGeneral.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnGuardarGeneral.Size = new System.Drawing.Size(245, 45);
            this.btnGuardarGeneral.TabIndex = 67;
            this.btnGuardarGeneral.Text = "GUARDAR CAMBIOS";
            this.btnGuardarGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarGeneral.UseVisualStyleBackColor = false;
            this.btnGuardarGeneral.Click += new System.EventHandler(this.btnGuardarGeneral_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.DarkRed;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.Location = new System.Drawing.Point(546, 330);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnCerrar.Size = new System.Drawing.Size(135, 45);
            this.btnCerrar.TabIndex = 66;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(544, 256);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(101, 28);
            this.chkActivo.TabIndex = 65;
            this.chkActivo.Text = "ACTIVO";
            this.chkActivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(487, 148);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(130, 24);
            this.lblDescuento.TabIndex = 64;
            this.lblDescuento.Text = "DESCUENTO:";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(491, 175);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(190, 32);
            this.txtDescuento.TabIndex = 63;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(95, 148);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEmail.Size = new System.Drawing.Size(238, 24);
            this.lblEmail.TabIndex = 62;
            this.lblEmail.Text = "CORREO ELECTRONICO:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(99, 175);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(386, 32);
            this.txtEmail.TabIndex = 61;
            // 
            // lblTiempoEntrega
            // 
            this.lblTiempoEntrega.AutoSize = true;
            this.lblTiempoEntrega.Location = new System.Drawing.Point(291, 227);
            this.lblTiempoEntrega.Name = "lblTiempoEntrega";
            this.lblTiempoEntrega.Size = new System.Drawing.Size(190, 24);
            this.lblTiempoEntrega.TabIndex = 60;
            this.lblTiempoEntrega.Text = "TIEMPO ENTREGA:";
            // 
            // nudTiempoEntrega
            // 
            this.nudTiempoEntrega.Location = new System.Drawing.Point(295, 254);
            this.nudTiempoEntrega.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudTiempoEntrega.Name = "nudTiempoEntrega";
            this.nudTiempoEntrega.Size = new System.Drawing.Size(190, 32);
            this.nudTiempoEntrega.TabIndex = 59;
            this.nudTiempoEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Location = new System.Drawing.Point(95, 227);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(142, 24);
            this.lblFormaPago.TabIndex = 58;
            this.lblFormaPago.Text = "FORMA PAGO:";
            // 
            // cmbFormaPago
            // 
            this.cmbFormaPago.FormattingEnabled = true;
            this.cmbFormaPago.Location = new System.Drawing.Point(99, 254);
            this.cmbFormaPago.Name = "cmbFormaPago";
            this.cmbFormaPago.Size = new System.Drawing.Size(190, 32);
            this.cmbFormaPago.TabIndex = 57;
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(487, 72);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(70, 24);
            this.lblCuit.TabIndex = 56;
            this.lblCuit.Text = "CUIT:";
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(491, 99);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(190, 32);
            this.txtCuit.TabIndex = 55;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(95, 72);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(94, 24);
            this.lblCodigo.TabIndex = 54;
            this.lblCodigo.Text = "CODIGO:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(99, 99);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(190, 32);
            this.txtCodigo.TabIndex = 53;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(291, 72);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(166, 24);
            this.lblRazonSocial.TabIndex = 52;
            this.lblRazonSocial.Text = "RAZON SOCIAL:";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(295, 99);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(190, 32);
            this.txtRazonSocial.TabIndex = 51;
            // 
            // tabTelefonos
            // 
            this.tabTelefonos.Controls.Add(this.btn2);
            this.tabTelefonos.Controls.Add(this.btnModificarTelefono);
            this.tabTelefonos.Controls.Add(this.btnAgregarTelefono);
            this.tabTelefonos.Controls.Add(this.dgvTelefonos);
            this.tabTelefonos.Location = new System.Drawing.Point(4, 33);
            this.tabTelefonos.Name = "tabTelefonos";
            this.tabTelefonos.Padding = new System.Windows.Forms.Padding(3);
            this.tabTelefonos.Size = new System.Drawing.Size(790, 450);
            this.tabTelefonos.TabIndex = 4;
            this.tabTelefonos.Text = "TELEFONOS";
            this.tabTelefonos.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.DarkRed;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.ForeColor = System.Drawing.SystemColors.Control;
            this.btn2.Image = ((System.Drawing.Image)(resources.GetObject("btn2.Image")));
            this.btn2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn2.Location = new System.Drawing.Point(625, 369);
            this.btn2.Name = "btn2";
            this.btn2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn2.Size = new System.Drawing.Size(135, 45);
            this.btn2.TabIndex = 50;
            this.btn2.Text = "CERRAR";
            this.btn2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btnModificarTelefono
            // 
            this.btnModificarTelefono.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnModificarTelefono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarTelefono.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnModificarTelefono.ForeColor = System.Drawing.SystemColors.Control;
            this.btnModificarTelefono.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarTelefono.Image")));
            this.btnModificarTelefono.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarTelefono.Location = new System.Drawing.Point(297, 369);
            this.btnModificarTelefono.Name = "btnModificarTelefono";
            this.btnModificarTelefono.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnModificarTelefono.Size = new System.Drawing.Size(171, 45);
            this.btnModificarTelefono.TabIndex = 19;
            this.btnModificarTelefono.Text = "MODIFICAR";
            this.btnModificarTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarTelefono.UseVisualStyleBackColor = false;
            this.btnModificarTelefono.Click += new System.EventHandler(this.btnModificarTelefono_Click);
            // 
            // btnAgregarTelefono
            // 
            this.btnAgregarTelefono.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregarTelefono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarTelefono.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAgregarTelefono.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregarTelefono.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarTelefono.Image")));
            this.btnAgregarTelefono.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarTelefono.Location = new System.Drawing.Point(25, 369);
            this.btnAgregarTelefono.Name = "btnAgregarTelefono";
            this.btnAgregarTelefono.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnAgregarTelefono.Size = new System.Drawing.Size(220, 45);
            this.btnAgregarTelefono.TabIndex = 17;
            this.btnAgregarTelefono.Text = "AGREGAR NUEVO";
            this.btnAgregarTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarTelefono.UseVisualStyleBackColor = false;
            this.btnAgregarTelefono.Click += new System.EventHandler(this.btnAgregarTelefono_Click);
            // 
            // dgvTelefonos
            // 
            this.dgvTelefonos.AllowUserToAddRows = false;
            this.dgvTelefonos.AllowUserToDeleteRows = false;
            this.dgvTelefonos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvTelefonos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTelefonos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTelefonos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvTelefonos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTelefonos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefonos.EnableHeadersVisualStyles = false;
            this.dgvTelefonos.GridColor = System.Drawing.Color.White;
            this.dgvTelefonos.Location = new System.Drawing.Point(25, 37);
            this.dgvTelefonos.Name = "dgvTelefonos";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTelefonos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTelefonos.RowHeadersVisible = false;
            this.dgvTelefonos.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTelefonos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTelefonos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTelefonos.Size = new System.Drawing.Size(735, 270);
            this.dgvTelefonos.TabIndex = 16;
            // 
            // tabDirecciones
            // 
            this.tabDirecciones.Controls.Add(this.btnModificarDireccion);
            this.tabDirecciones.Controls.Add(this.btn3);
            this.tabDirecciones.Controls.Add(this.btnAgregarDireccion);
            this.tabDirecciones.Controls.Add(this.dgvDirecciones);
            this.tabDirecciones.Location = new System.Drawing.Point(4, 33);
            this.tabDirecciones.Name = "tabDirecciones";
            this.tabDirecciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabDirecciones.Size = new System.Drawing.Size(790, 450);
            this.tabDirecciones.TabIndex = 5;
            this.tabDirecciones.Text = "DIRECCIONES";
            this.tabDirecciones.UseVisualStyleBackColor = true;
            // 
            // btnModificarDireccion
            // 
            this.btnModificarDireccion.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnModificarDireccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarDireccion.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnModificarDireccion.ForeColor = System.Drawing.SystemColors.Control;
            this.btnModificarDireccion.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarDireccion.Image")));
            this.btnModificarDireccion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarDireccion.Location = new System.Drawing.Point(297, 369);
            this.btnModificarDireccion.Name = "btnModificarDireccion";
            this.btnModificarDireccion.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnModificarDireccion.Size = new System.Drawing.Size(171, 45);
            this.btnModificarDireccion.TabIndex = 51;
            this.btnModificarDireccion.Text = "MODIFICAR";
            this.btnModificarDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarDireccion.UseVisualStyleBackColor = false;
            this.btnModificarDireccion.Click += new System.EventHandler(this.btnModificarDireccion_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.DarkRed;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.ForeColor = System.Drawing.SystemColors.Control;
            this.btn3.Image = ((System.Drawing.Image)(resources.GetObject("btn3.Image")));
            this.btn3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn3.Location = new System.Drawing.Point(625, 369);
            this.btn3.Name = "btn3";
            this.btn3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn3.Size = new System.Drawing.Size(135, 45);
            this.btn3.TabIndex = 50;
            this.btn3.Text = "CERRAR";
            this.btn3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnAgregarDireccion
            // 
            this.btnAgregarDireccion.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregarDireccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarDireccion.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAgregarDireccion.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregarDireccion.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarDireccion.Image")));
            this.btnAgregarDireccion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarDireccion.Location = new System.Drawing.Point(25, 369);
            this.btnAgregarDireccion.Name = "btnAgregarDireccion";
            this.btnAgregarDireccion.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnAgregarDireccion.Size = new System.Drawing.Size(220, 45);
            this.btnAgregarDireccion.TabIndex = 21;
            this.btnAgregarDireccion.Text = "AGREGAR NUEVO";
            this.btnAgregarDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarDireccion.UseVisualStyleBackColor = false;
            this.btnAgregarDireccion.Click += new System.EventHandler(this.btnAgregarDireccion_Click);
            // 
            // dgvDirecciones
            // 
            this.dgvDirecciones.AllowUserToAddRows = false;
            this.dgvDirecciones.AllowUserToDeleteRows = false;
            this.dgvDirecciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDirecciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDirecciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDirecciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvDirecciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDirecciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDirecciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDirecciones.EnableHeadersVisualStyles = false;
            this.dgvDirecciones.GridColor = System.Drawing.Color.White;
            this.dgvDirecciones.Location = new System.Drawing.Point(25, 37);
            this.dgvDirecciones.Name = "dgvDirecciones";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDirecciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDirecciones.RowHeadersVisible = false;
            this.dgvDirecciones.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDirecciones.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDirecciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDirecciones.Size = new System.Drawing.Size(735, 270);
            this.dgvDirecciones.TabIndex = 20;
            // 
            // tabProductos
            // 
            this.tabProductos.Controls.Add(this.btnModificarProducto);
            this.tabProductos.Controls.Add(this.btn4);
            this.tabProductos.Controls.Add(this.btnAgregarProducto);
            this.tabProductos.Controls.Add(this.dgvProductos);
            this.tabProductos.Location = new System.Drawing.Point(4, 33);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductos.Size = new System.Drawing.Size(790, 450);
            this.tabProductos.TabIndex = 6;
            this.tabProductos.Text = "PRODUCTOS";
            this.tabProductos.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.DarkRed;
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.ForeColor = System.Drawing.SystemColors.Control;
            this.btn4.Image = ((System.Drawing.Image)(resources.GetObject("btn4.Image")));
            this.btn4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn4.Location = new System.Drawing.Point(625, 369);
            this.btn4.Name = "btn4";
            this.btn4.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn4.Size = new System.Drawing.Size(135, 45);
            this.btn4.TabIndex = 54;
            this.btn4.Text = "CERRAR";
            this.btn4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProducto.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAgregarProducto.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProducto.Image")));
            this.btnAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProducto.Location = new System.Drawing.Point(25, 369);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnAgregarProducto.Size = new System.Drawing.Size(220, 45);
            this.btnAgregarProducto.TabIndex = 52;
            this.btnAgregarProducto.Text = "AGREGAR NUEVO";
            this.btnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.GridColor = System.Drawing.Color.White;
            this.dgvProductos.Location = new System.Drawing.Point(25, 37);
            this.dgvProductos.Name = "dgvProductos";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidth = 51;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(735, 270);
            this.dgvProductos.TabIndex = 51;
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnModificarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarProducto.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnModificarProducto.ForeColor = System.Drawing.SystemColors.Control;
            this.btnModificarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarProducto.Image")));
            this.btnModificarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarProducto.Location = new System.Drawing.Point(297, 369);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnModificarProducto.Size = new System.Drawing.Size(171, 45);
            this.btnModificarProducto.TabIndex = 55;
            this.btnModificarProducto.Text = "MODIFICAR";
            this.btnModificarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarProducto.UseVisualStyleBackColor = false;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // frmDetalleProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 585);
            this.ControlBox = false;
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.label1);
            this.Name = "frmDetalleProveedor";
            this.Text = "frmDetalleProveedor";
            this.Load += new System.EventHandler(this.frmDetalleProveedor_Load);
            this.TabControl1.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTiempoEntrega)).EndInit();
            this.tabTelefonos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonos)).EndInit();
            this.tabDirecciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirecciones)).EndInit();
            this.tabProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabTelefonos;
        private System.Windows.Forms.TabPage tabDirecciones;
        private System.Windows.Forms.TabPage tabProductos;
        internal System.Windows.Forms.DataGridView dgvTelefonos;
        private System.Windows.Forms.Button btnModificarTelefono;
        private System.Windows.Forms.Button btnAgregarTelefono;
        private System.Windows.Forms.Button btnAgregarDireccion;
        internal System.Windows.Forms.DataGridView dgvDirecciones;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnModificarDireccion;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnAgregarProducto;
        internal System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnGuardarGeneral;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTiempoEntrega;
        private System.Windows.Forms.NumericUpDown nudTiempoEntrega;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.ComboBox cmbFormaPago;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Button btnModificarProducto;
    }
}