namespace Vista.frmGI.Productos
{
    partial class frmInsertarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsertarProducto));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStockMaximo = new System.Windows.Forms.Label();
            this.nudStockMaximo = new System.Windows.Forms.NumericUpDown();
            this.lblStockIdeal = new System.Windows.Forms.Label();
            this.nudStockIdeal = new System.Windows.Forms.NumericUpDown();
            this.lblStockMinimo = new System.Windows.Forms.Label();
            this.nudStockMinimo = new System.Windows.Forms.NumericUpDown();
            this.lblStockActual = new System.Windows.Forms.Label();
            this.nudStockActual = new System.Windows.Forms.NumericUpDown();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.nudPrecioVenta = new System.Windows.Forms.NumericUpDown();
            this.lblPrecioCompra = new System.Windows.Forms.Label();
            this.nudPrecioCompra = new System.Windows.Forms.NumericUpDown();
            this.lblDiasAviso = new System.Windows.Forms.Label();
            this.nudDiasAviso = new System.Windows.Forms.NumericUpDown();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.lblTipoStock = new System.Windows.Forms.Label();
            this.cmbTipoStock = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblLote = new System.Windows.Forms.Label();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnInsertarCategoria = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMaximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockIdeal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMinimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiasAviso)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1075, 49);
            this.label1.TabIndex = 11;
            this.label1.Text = "INSERTAR PRODUCTO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.lblStockMaximo);
            this.groupBox1.Controls.Add(this.nudStockMaximo);
            this.groupBox1.Controls.Add(this.lblStockIdeal);
            this.groupBox1.Controls.Add(this.nudStockIdeal);
            this.groupBox1.Controls.Add(this.lblStockMinimo);
            this.groupBox1.Controls.Add(this.nudStockMinimo);
            this.groupBox1.Controls.Add(this.lblStockActual);
            this.groupBox1.Controls.Add(this.nudStockActual);
            this.groupBox1.Controls.Add(this.lblPrecioVenta);
            this.groupBox1.Controls.Add(this.nudPrecioVenta);
            this.groupBox1.Controls.Add(this.lblPrecioCompra);
            this.groupBox1.Controls.Add(this.nudPrecioCompra);
            this.groupBox1.Controls.Add(this.lblDiasAviso);
            this.groupBox1.Controls.Add(this.nudDiasAviso);
            this.groupBox1.Controls.Add(this.lblFechaVencimiento);
            this.groupBox1.Controls.Add(this.dtpFechaVencimiento);
            this.groupBox1.Controls.Add(this.lblTipoStock);
            this.groupBox1.Controls.Add(this.cmbTipoStock);
            this.groupBox1.Controls.Add(this.lblMarca);
            this.groupBox1.Controls.Add(this.cmbMarca);
            this.groupBox1.Controls.Add(this.lblCategoria);
            this.groupBox1.Controls.Add(this.cmbCategoria);
            this.groupBox1.Controls.Add(this.lblLote);
            this.groupBox1.Controls.Add(this.txtLote);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.btnCerrar);
            this.groupBox1.Controls.Add(this.btnInsertarCategoria);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1075, 446);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INGRESE LOS DATOS DEL PRODUCTO";
            // 
            // lblStockMaximo
            // 
            this.lblStockMaximo.AutoSize = true;
            this.lblStockMaximo.Location = new System.Drawing.Point(437, 277);
            this.lblStockMaximo.Name = "lblStockMaximo";
            this.lblStockMaximo.Size = new System.Drawing.Size(166, 24);
            this.lblStockMaximo.TabIndex = 43;
            this.lblStockMaximo.Text = "STOCK MAXIMO:";
            // 
            // nudStockMaximo
            // 
            this.nudStockMaximo.Location = new System.Drawing.Point(441, 304);
            this.nudStockMaximo.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudStockMaximo.Name = "nudStockMaximo";
            this.nudStockMaximo.Size = new System.Drawing.Size(190, 32);
            this.nudStockMaximo.TabIndex = 42;
            this.nudStockMaximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblStockIdeal
            // 
            this.lblStockIdeal.AutoSize = true;
            this.lblStockIdeal.Location = new System.Drawing.Point(241, 277);
            this.lblStockIdeal.Name = "lblStockIdeal";
            this.lblStockIdeal.Size = new System.Drawing.Size(154, 24);
            this.lblStockIdeal.TabIndex = 41;
            this.lblStockIdeal.Text = "STOCK IDEAL:";
            // 
            // nudStockIdeal
            // 
            this.nudStockIdeal.Location = new System.Drawing.Point(245, 304);
            this.nudStockIdeal.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudStockIdeal.Name = "nudStockIdeal";
            this.nudStockIdeal.Size = new System.Drawing.Size(190, 32);
            this.nudStockIdeal.TabIndex = 40;
            this.nudStockIdeal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblStockMinimo
            // 
            this.lblStockMinimo.AutoSize = true;
            this.lblStockMinimo.Location = new System.Drawing.Point(45, 277);
            this.lblStockMinimo.Name = "lblStockMinimo";
            this.lblStockMinimo.Size = new System.Drawing.Size(166, 24);
            this.lblStockMinimo.TabIndex = 39;
            this.lblStockMinimo.Text = "STOCK MINIMO:";
            // 
            // nudStockMinimo
            // 
            this.nudStockMinimo.Location = new System.Drawing.Point(49, 304);
            this.nudStockMinimo.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudStockMinimo.Name = "nudStockMinimo";
            this.nudStockMinimo.Size = new System.Drawing.Size(190, 32);
            this.nudStockMinimo.TabIndex = 38;
            this.nudStockMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblStockActual
            // 
            this.lblStockActual.AutoSize = true;
            this.lblStockActual.Location = new System.Drawing.Point(829, 205);
            this.lblStockActual.Name = "lblStockActual";
            this.lblStockActual.Size = new System.Drawing.Size(166, 24);
            this.lblStockActual.TabIndex = 37;
            this.lblStockActual.Text = "STOCK ACTUAL:";
            // 
            // nudStockActual
            // 
            this.nudStockActual.Location = new System.Drawing.Point(833, 232);
            this.nudStockActual.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudStockActual.Name = "nudStockActual";
            this.nudStockActual.Size = new System.Drawing.Size(190, 32);
            this.nudStockActual.TabIndex = 36;
            this.nudStockActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Location = new System.Drawing.Point(633, 205);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(166, 24);
            this.lblPrecioVenta.TabIndex = 35;
            this.lblPrecioVenta.Text = "PRECIO VENTA:";
            // 
            // nudPrecioVenta
            // 
            this.nudPrecioVenta.Location = new System.Drawing.Point(637, 232);
            this.nudPrecioVenta.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudPrecioVenta.Name = "nudPrecioVenta";
            this.nudPrecioVenta.Size = new System.Drawing.Size(190, 32);
            this.nudPrecioVenta.TabIndex = 34;
            this.nudPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.AutoSize = true;
            this.lblPrecioCompra.Location = new System.Drawing.Point(437, 205);
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(178, 24);
            this.lblPrecioCompra.TabIndex = 33;
            this.lblPrecioCompra.Text = "PRECIO COMPRA:";
            // 
            // nudPrecioCompra
            // 
            this.nudPrecioCompra.Location = new System.Drawing.Point(441, 232);
            this.nudPrecioCompra.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudPrecioCompra.Name = "nudPrecioCompra";
            this.nudPrecioCompra.Size = new System.Drawing.Size(190, 32);
            this.nudPrecioCompra.TabIndex = 32;
            this.nudPrecioCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDiasAviso
            // 
            this.lblDiasAviso.AutoSize = true;
            this.lblDiasAviso.Location = new System.Drawing.Point(829, 125);
            this.lblDiasAviso.Name = "lblDiasAviso";
            this.lblDiasAviso.Size = new System.Drawing.Size(142, 24);
            this.lblDiasAviso.TabIndex = 31;
            this.lblDiasAviso.Text = "DIAS AVISO:";
            // 
            // nudDiasAviso
            // 
            this.nudDiasAviso.Location = new System.Drawing.Point(833, 152);
            this.nudDiasAviso.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudDiasAviso.Name = "nudDiasAviso";
            this.nudDiasAviso.Size = new System.Drawing.Size(190, 32);
            this.nudDiasAviso.TabIndex = 30;
            this.nudDiasAviso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudDiasAviso.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(633, 125);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(178, 24);
            this.lblFechaVencimiento.TabIndex = 29;
            this.lblFechaVencimiento.Text = "F VENCIMIENTO:";
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(637, 152);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(190, 32);
            this.dtpFechaVencimiento.TabIndex = 27;
            // 
            // lblTipoStock
            // 
            this.lblTipoStock.AutoSize = true;
            this.lblTipoStock.Location = new System.Drawing.Point(437, 125);
            this.lblTipoStock.Name = "lblTipoStock";
            this.lblTipoStock.Size = new System.Drawing.Size(142, 24);
            this.lblTipoStock.TabIndex = 26;
            this.lblTipoStock.Text = "TIPO STOCK:";
            // 
            // cmbTipoStock
            // 
            this.cmbTipoStock.FormattingEnabled = true;
            this.cmbTipoStock.Location = new System.Drawing.Point(441, 152);
            this.cmbTipoStock.Name = "cmbTipoStock";
            this.cmbTipoStock.Size = new System.Drawing.Size(190, 32);
            this.cmbTipoStock.TabIndex = 25;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(829, 49);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(82, 24);
            this.lblMarca.TabIndex = 24;
            this.lblMarca.Text = "MARCA:";
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(833, 76);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(190, 32);
            this.cmbMarca.TabIndex = 23;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(633, 49);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(130, 24);
            this.lblCategoria.TabIndex = 22;
            this.lblCategoria.Text = "CATEGORIA:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(637, 76);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(190, 32);
            this.cmbCategoria.TabIndex = 21;
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.Location = new System.Drawing.Point(437, 49);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(70, 24);
            this.lblLote.TabIndex = 20;
            this.lblLote.Text = "LOTE:";
            // 
            // txtLote
            // 
            this.txtLote.Location = new System.Drawing.Point(441, 76);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(190, 32);
            this.txtLote.TabIndex = 19;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(45, 49);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(94, 24);
            this.lblCodigo.TabIndex = 18;
            this.lblCodigo.Text = "CODIGO:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(49, 76);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(190, 32);
            this.txtCodigo.TabIndex = 17;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(45, 125);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(286, 24);
            this.lblDescripcion.TabIndex = 16;
            this.lblDescripcion.Text = "DESCRIPCION: (opcional)";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(49, 152);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(386, 112);
            this.txtDescripcion.TabIndex = 15;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.Location = new System.Drawing.Point(294, 377);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnCerrar.Size = new System.Drawing.Size(141, 45);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnInsertarCategoria
            // 
            this.btnInsertarCategoria.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnInsertarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsertarCategoria.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnInsertarCategoria.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInsertarCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnInsertarCategoria.Image")));
            this.btnInsertarCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsertarCategoria.Location = new System.Drawing.Point(49, 377);
            this.btnInsertarCategoria.Name = "btnInsertarCategoria";
            this.btnInsertarCategoria.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnInsertarCategoria.Size = new System.Drawing.Size(159, 45);
            this.btnInsertarCategoria.TabIndex = 13;
            this.btnInsertarCategoria.Text = "INSERTAR";
            this.btnInsertarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertarCategoria.UseVisualStyleBackColor = false;
            this.btnInsertarCategoria.Click += new System.EventHandler(this.btnInsertarCategoria_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(241, 49);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(94, 24);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(245, 76);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(190, 32);
            this.txtNombre.TabIndex = 9;
            // 
            // frmInsertarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 546);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmInsertarProducto";
            this.Text = "frmInsertarProducto";
            this.Load += new System.EventHandler(this.frmInsertarProducto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMaximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockIdeal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMinimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiasAviso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnInsertarCategoria;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.Label lblTipoStock;
        private System.Windows.Forms.ComboBox cmbTipoStock;
        private System.Windows.Forms.NumericUpDown nudDiasAviso;
        private System.Windows.Forms.Label lblPrecioCompra;
        private System.Windows.Forms.NumericUpDown nudPrecioCompra;
        private System.Windows.Forms.Label lblDiasAviso;
        private System.Windows.Forms.Label lblStockActual;
        private System.Windows.Forms.NumericUpDown nudStockActual;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.NumericUpDown nudPrecioVenta;
        private System.Windows.Forms.Label lblStockMinimo;
        private System.Windows.Forms.NumericUpDown nudStockMinimo;
        private System.Windows.Forms.Label lblStockMaximo;
        private System.Windows.Forms.NumericUpDown nudStockMaximo;
        private System.Windows.Forms.Label lblStockIdeal;
        private System.Windows.Forms.NumericUpDown nudStockIdeal;
    }
}