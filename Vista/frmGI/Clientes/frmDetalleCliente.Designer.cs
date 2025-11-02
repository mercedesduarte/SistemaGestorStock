namespace Vista.frmGI.Clientes
{
    partial class frmDetalleCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleCliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.nudLimiteCredito = new System.Windows.Forms.NumericUpDown();
            this.nudDescuento = new System.Windows.Forms.NumericUpDown();
            this.lblLimiteCredito = new System.Windows.Forms.Label();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.cmbFormaPago = new System.Windows.Forms.ComboBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.btnGuardarGeneral = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.TabControl1.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimiteCredito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuento)).BeginInit();
            this.tabTelefonos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonos)).BeginInit();
            this.tabDirecciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirecciones)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TabControl1.Controls.Add(this.tabGeneral);
            this.TabControl1.Controls.Add(this.tabTelefonos);
            this.TabControl1.Controls.Add(this.tabDirecciones);
            this.TabControl1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.TabControl1.Location = new System.Drawing.Point(12, 86);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(798, 487);
            this.TabControl1.TabIndex = 22;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.nudLimiteCredito);
            this.tabGeneral.Controls.Add(this.nudDescuento);
            this.tabGeneral.Controls.Add(this.lblLimiteCredito);
            this.tabGeneral.Controls.Add(this.chkActivo);
            this.tabGeneral.Controls.Add(this.lblDescuento);
            this.tabGeneral.Controls.Add(this.lblEmail);
            this.tabGeneral.Controls.Add(this.txtEmail);
            this.tabGeneral.Controls.Add(this.lblFormaPago);
            this.tabGeneral.Controls.Add(this.cmbFormaPago);
            this.tabGeneral.Controls.Add(this.lblCodigo);
            this.tabGeneral.Controls.Add(this.txtCodigo);
            this.tabGeneral.Controls.Add(this.lblNombre);
            this.tabGeneral.Controls.Add(this.txtRazonSocial);
            this.tabGeneral.Controls.Add(this.btnGuardarGeneral);
            this.tabGeneral.Controls.Add(this.btnCerrar);
            this.tabGeneral.Location = new System.Drawing.Point(4, 33);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(790, 450);
            this.tabGeneral.TabIndex = 3;
            this.tabGeneral.Text = "GENERAL";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // nudLimiteCredito
            // 
            this.nudLimiteCredito.Location = new System.Drawing.Point(99, 240);
            this.nudLimiteCredito.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nudLimiteCredito.Name = "nudLimiteCredito";
            this.nudLimiteCredito.Size = new System.Drawing.Size(386, 32);
            this.nudLimiteCredito.TabIndex = 80;
            this.nudLimiteCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudDescuento
            // 
            this.nudDescuento.Location = new System.Drawing.Point(491, 88);
            this.nudDescuento.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nudDescuento.Name = "nudDescuento";
            this.nudDescuento.Size = new System.Drawing.Size(190, 32);
            this.nudDescuento.TabIndex = 79;
            this.nudDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLimiteCredito
            // 
            this.lblLimiteCredito.AutoSize = true;
            this.lblLimiteCredito.Location = new System.Drawing.Point(95, 213);
            this.lblLimiteCredito.Name = "lblLimiteCredito";
            this.lblLimiteCredito.Size = new System.Drawing.Size(226, 24);
            this.lblLimiteCredito.TabIndex = 78;
            this.lblLimiteCredito.Text = "LIMITE DE CREDITO:";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(544, 244);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(101, 28);
            this.chkActivo.TabIndex = 77;
            this.chkActivo.Text = "ACTIVO";
            this.chkActivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(487, 60);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(130, 24);
            this.lblDescuento.TabIndex = 76;
            this.lblDescuento.Text = "DESCUENTO:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(95, 136);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEmail.Size = new System.Drawing.Size(238, 24);
            this.lblEmail.TabIndex = 75;
            this.lblEmail.Text = "CORREO ELECTRONICO:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(99, 163);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(386, 32);
            this.txtEmail.TabIndex = 74;
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Location = new System.Drawing.Point(487, 136);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(142, 24);
            this.lblFormaPago.TabIndex = 73;
            this.lblFormaPago.Text = "FORMA PAGO:";
            // 
            // cmbFormaPago
            // 
            this.cmbFormaPago.FormattingEnabled = true;
            this.cmbFormaPago.Location = new System.Drawing.Point(491, 163);
            this.cmbFormaPago.Name = "cmbFormaPago";
            this.cmbFormaPago.Size = new System.Drawing.Size(190, 32);
            this.cmbFormaPago.TabIndex = 72;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(95, 60);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(58, 24);
            this.lblCodigo.TabIndex = 71;
            this.lblCodigo.Text = "DNI:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(99, 87);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(190, 32);
            this.txtCodigo.TabIndex = 70;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(291, 60);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(94, 24);
            this.lblNombre.TabIndex = 69;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(295, 87);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(190, 32);
            this.txtRazonSocial.TabIndex = 68;
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTelefonos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefonos.EnableHeadersVisualStyles = false;
            this.dgvTelefonos.GridColor = System.Drawing.Color.White;
            this.dgvTelefonos.Location = new System.Drawing.Point(25, 37);
            this.dgvTelefonos.Name = "dgvTelefonos";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTelefonos.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvTelefonos.RowHeadersVisible = false;
            this.dgvTelefonos.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTelefonos.RowsDefaultCellStyle = dataGridViewCellStyle12;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDirecciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDirecciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDirecciones.EnableHeadersVisualStyles = false;
            this.dgvDirecciones.GridColor = System.Drawing.Color.White;
            this.dgvDirecciones.Location = new System.Drawing.Point(25, 37);
            this.dgvDirecciones.Name = "dgvDirecciones";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDirecciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDirecciones.RowHeadersVisible = false;
            this.dgvDirecciones.RowHeadersWidth = 51;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDirecciones.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDirecciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDirecciones.Size = new System.Drawing.Size(735, 270);
            this.dgvDirecciones.TabIndex = 20;
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
            this.label1.TabIndex = 23;
            this.label1.Text = "DETALLES DEL CLIENTE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDetalleCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 585);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TabControl1);
            this.Name = "frmDetalleCliente";
            this.Text = "frmDetalleCliente";
            this.Load += new System.EventHandler(this.frmDetalleCliente_Load);
            this.TabControl1.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimiteCredito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuento)).EndInit();
            this.tabTelefonos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonos)).EndInit();
            this.tabDirecciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirecciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.Button btnGuardarGeneral;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TabPage tabTelefonos;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnModificarTelefono;
        private System.Windows.Forms.Button btnAgregarTelefono;
        internal System.Windows.Forms.DataGridView dgvTelefonos;
        private System.Windows.Forms.TabPage tabDirecciones;
        private System.Windows.Forms.Button btnModificarDireccion;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnAgregarDireccion;
        internal System.Windows.Forms.DataGridView dgvDirecciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudLimiteCredito;
        private System.Windows.Forms.NumericUpDown nudDescuento;
        private System.Windows.Forms.Label lblLimiteCredito;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.ComboBox cmbFormaPago;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtRazonSocial;
    }
}