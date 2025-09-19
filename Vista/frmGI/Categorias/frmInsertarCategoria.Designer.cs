namespace Vista.frmGI.Categorias
{
    partial class frmInsertarCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsertarCategoria));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnInsertarCategoria = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.btnCerrar);
            this.groupBox1.Controls.Add(this.btnInsertarCategoria);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 308);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INGRESE LOS DATOS DE LA CATEGORIA";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(31, 125);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(286, 24);
            this.lblDescripcion.TabIndex = 16;
            this.lblDescripcion.Text = "DESCRIPCION: (opcional)";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(35, 152);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(360, 73);
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
            this.btnCerrar.Location = new System.Drawing.Point(254, 243);
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
            this.btnInsertarCategoria.Location = new System.Drawing.Point(35, 243);
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
            this.lblNombre.Location = new System.Drawing.Point(31, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(94, 24);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(35, 77);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(360, 32);
            this.txtNombre.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 54);
            this.label1.TabIndex = 9;
            this.label1.Text = "INSERTAR CATEGORIA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmInsertarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 402);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmInsertarCategoria";
            this.Text = "frmInsertarCategoria";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnInsertarCategoria;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
    }
}