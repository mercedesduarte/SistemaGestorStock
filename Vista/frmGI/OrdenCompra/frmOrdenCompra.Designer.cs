namespace Vista.frmGI.OrdenCompra
{
    partial class frmOrdenCompra
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.TextBox txtClienteRUC;
        private System.Windows.Forms.Label lblClienteRUC;
        private System.Windows.Forms.TextBox txtClienteNombre;
        private System.Windows.Forms.Label lblClienteNombre;
        private System.Windows.Forms.GroupBox grpProveedor;
        private System.Windows.Forms.TextBox txtProveedorDireccion;
        private System.Windows.Forms.Label lblProveedorDireccion;
        private System.Windows.Forms.TextBox txtProveedorNombre;
        private System.Windows.Forms.Label lblProveedorNombre;
        private System.Windows.Forms.GroupBox grpProductos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.Button btnGenerarOrden;
        private System.Windows.Forms.Button btnLimpiar;

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
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.txtClienteRUC = new System.Windows.Forms.TextBox();
            this.lblClienteRUC = new System.Windows.Forms.Label();
            this.txtClienteNombre = new System.Windows.Forms.TextBox();
            this.lblClienteNombre = new System.Windows.Forms.Label();
            this.grpProveedor = new System.Windows.Forms.GroupBox();
            this.txtProveedorDireccion = new System.Windows.Forms.TextBox();
            this.lblProveedorDireccion = new System.Windows.Forms.Label();
            this.txtProveedorNombre = new System.Windows.Forms.TextBox();
            this.lblProveedorNombre = new System.Windows.Forms.Label();
            this.grpProductos = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerarOrden = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpCliente.SuspendLayout();
            this.grpProveedor.SuspendLayout();
            this.grpProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCliente
            // 
            this.grpCliente.Controls.Add(this.txtClienteRUC);
            this.grpCliente.Controls.Add(this.lblClienteRUC);
            this.grpCliente.Controls.Add(this.txtClienteNombre);
            this.grpCliente.Controls.Add(this.lblClienteNombre);
            this.grpCliente.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCliente.Location = new System.Drawing.Point(20, 80);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Size = new System.Drawing.Size(450, 150);
            this.grpCliente.TabIndex = 1;
            this.grpCliente.TabStop = false;
            this.grpCliente.Text = "INFORMACIÓN DEL CLIENTE";
            // 
            // txtClienteRUC
            // 
            this.txtClienteRUC.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteRUC.Location = new System.Drawing.Point(140, 90);
            this.txtClienteRUC.Name = "txtClienteRUC";
            this.txtClienteRUC.Size = new System.Drawing.Size(200, 26);
            this.txtClienteRUC.TabIndex = 3;
            // 
            // lblClienteRUC
            // 
            this.lblClienteRUC.AutoSize = true;
            this.lblClienteRUC.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteRUC.Location = new System.Drawing.Point(20, 93);
            this.lblClienteRUC.Name = "lblClienteRUC";
            this.lblClienteRUC.Size = new System.Drawing.Size(45, 19);
            this.lblClienteRUC.TabIndex = 2;
            this.lblClienteRUC.Text = "RUC:";
            // 
            // txtClienteNombre
            // 
            this.txtClienteNombre.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteNombre.Location = new System.Drawing.Point(140, 40);
            this.txtClienteNombre.Name = "txtClienteNombre";
            this.txtClienteNombre.Size = new System.Drawing.Size(300, 26);
            this.txtClienteNombre.TabIndex = 1;
            // 
            // lblClienteNombre
            // 
            this.lblClienteNombre.AutoSize = true;
            this.lblClienteNombre.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteNombre.Location = new System.Drawing.Point(20, 43);
            this.lblClienteNombre.Name = "lblClienteNombre";
            this.lblClienteNombre.Size = new System.Drawing.Size(72, 19);
            this.lblClienteNombre.TabIndex = 0;
            this.lblClienteNombre.Text = "Nombre:";
            // 
            // grpProveedor
            // 
            this.grpProveedor.Controls.Add(this.txtProveedorDireccion);
            this.grpProveedor.Controls.Add(this.lblProveedorDireccion);
            this.grpProveedor.Controls.Add(this.txtProveedorNombre);
            this.grpProveedor.Controls.Add(this.lblProveedorNombre);
            this.grpProveedor.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProveedor.Location = new System.Drawing.Point(500, 80);
            this.grpProveedor.Name = "grpProveedor";
            this.grpProveedor.Size = new System.Drawing.Size(450, 150);
            this.grpProveedor.TabIndex = 2;
            this.grpProveedor.TabStop = false;
            this.grpProveedor.Text = "INFORMACIÓN DEL PROVEEDOR";
            // 
            // txtProveedorDireccion
            // 
            this.txtProveedorDireccion.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedorDireccion.Location = new System.Drawing.Point(140, 90);
            this.txtProveedorDireccion.Name = "txtProveedorDireccion";
            this.txtProveedorDireccion.Size = new System.Drawing.Size(300, 26);
            this.txtProveedorDireccion.TabIndex = 3;
            // 
            // lblProveedorDireccion
            // 
            this.lblProveedorDireccion.AutoSize = true;
            this.lblProveedorDireccion.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedorDireccion.Location = new System.Drawing.Point(20, 93);
            this.lblProveedorDireccion.Name = "lblProveedorDireccion";
            this.lblProveedorDireccion.Size = new System.Drawing.Size(99, 19);
            this.lblProveedorDireccion.TabIndex = 2;
            this.lblProveedorDireccion.Text = "Dirección:";
            // 
            // txtProveedorNombre
            // 
            this.txtProveedorNombre.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedorNombre.Location = new System.Drawing.Point(140, 40);
            this.txtProveedorNombre.Name = "txtProveedorNombre";
            this.txtProveedorNombre.Size = new System.Drawing.Size(300, 26);
            this.txtProveedorNombre.TabIndex = 1;
            // 
            // lblProveedorNombre
            // 
            this.lblProveedorNombre.AutoSize = true;
            this.lblProveedorNombre.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedorNombre.Location = new System.Drawing.Point(20, 43);
            this.lblProveedorNombre.Name = "lblProveedorNombre";
            this.lblProveedorNombre.Size = new System.Drawing.Size(72, 19);
            this.lblProveedorNombre.TabIndex = 0;
            this.lblProveedorNombre.Text = "Nombre:";
            // 
            // grpProductos
            // 
            this.grpProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpProductos.Controls.Add(this.lblTotal);
            this.grpProductos.Controls.Add(this.btnEliminarProducto);
            this.grpProductos.Controls.Add(this.btnAgregarProducto);
            this.grpProductos.Controls.Add(this.dgvProductos);
            this.grpProductos.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProductos.Location = new System.Drawing.Point(20, 250);
            this.grpProductos.Name = "grpProductos";
            this.grpProductos.Size = new System.Drawing.Size(930, 300);
            this.grpProductos.TabIndex = 3;
            this.grpProductos.TabStop = false;
            this.grpProductos.Text = "DETALLE DE PRODUCTOS";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTotal.Location = new System.Drawing.Point(700, 260);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(154, 24);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "TOTAL: $0.00";
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarProducto.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminarProducto.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProducto.Location = new System.Drawing.Point(240, 250);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(200, 35);
            this.btnEliminarProducto.TabIndex = 2;
            this.btnEliminarProducto.Text = "ELIMINAR PRODUCTO";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarProducto.BackColor = System.Drawing.Color.LightBlue;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.Location = new System.Drawing.Point(20, 250);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(200, 35);
            this.btnAgregarProducto.TabIndex = 1;
            this.btnAgregarProducto.Text = "AGREGAR PRODUCTO";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            // 
            // dgvProductos
            // 
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProducto,
            this.colMarca,
            this.colCategoria,
            this.colCantidad,
            this.colPrecio,
            this.colSubtotal});
            this.dgvProductos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProductos.Location = new System.Drawing.Point(20, 40);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(890, 200);
            this.dgvProductos.TabIndex = 0;
            // 
            // colProducto
            // 
            this.colProducto.HeaderText = "PRODUCTO";
            this.colProducto.Name = "colProducto";
            this.colProducto.Width = 200;
            // 
            // colMarca
            // 
            this.colMarca.HeaderText = "MARCA";
            this.colMarca.Name = "colMarca";
            this.colMarca.Width = 120;
            // 
            // colCategoria
            // 
            this.colCategoria.HeaderText = "CATEGORÍA";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.Width = 120;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "CANTIDAD";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Width = 80;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "PRECIO UNIT.";
            this.colPrecio.Name = "colPrecio";
            // 
            // colSubtotal
            // 
            this.colSubtotal.HeaderText = "SUBTOTAL";
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.ReadOnly = true;
            this.colSubtotal.Width = 120;
            // 
            // btnGenerarOrden
            // 
            this.btnGenerarOrden.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGenerarOrden.BackColor = System.Drawing.Color.LightGreen;
            this.btnGenerarOrden.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarOrden.Location = new System.Drawing.Point(350, 570);
            this.btnGenerarOrden.Name = "btnGenerarOrden";
            this.btnGenerarOrden.Size = new System.Drawing.Size(200, 40);
            this.btnGenerarOrden.TabIndex = 4;
            this.btnGenerarOrden.Text = "GENERAR ORDEN";
            this.btnGenerarOrden.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLimpiar.BackColor = System.Drawing.Color.LightYellow;
            this.btnLimpiar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(570, 570);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(200, 40);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "LIMPIAR FORMULARIO";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 49);
            this.label1.TabIndex = 13;
            this.label1.Text = "ORDEN DE COMPRA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 631);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGenerarOrden);
            this.Controls.Add(this.grpProductos);
            this.Controls.Add(this.grpProveedor);
            this.Controls.Add(this.grpCliente);
            this.MinimumSize = new System.Drawing.Size(1000, 670);
            this.Name = "frmOrdenCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema - Orden de Compra";
            this.Load += new System.EventHandler(this.frmOrdenCompra_Load);
            this.grpCliente.ResumeLayout(false);
            this.grpCliente.PerformLayout();
            this.grpProveedor.ResumeLayout(false);
            this.grpProveedor.PerformLayout();
            this.grpProductos.ResumeLayout(false);
            this.grpProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
    }
}