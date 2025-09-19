namespace Vista.frmGI.Categorias
{
    partial class frmModificarCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarCategoria));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblProgreso = new System.Windows.Forms.Label();
            this.btnModifcar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
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
            this.groupBox1.Controls.Add(this.chkActivo);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblProgreso);
            this.groupBox1.Controls.Add(this.btnModifcar);
            this.groupBox1.Controls.Add(this.btnCerrar);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 385);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COMPLETA PARA MODIFICAR LA CATEGORIA";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(30, 135);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(286, 24);
            this.lblDescripcion.TabIndex = 24;
            this.lblDescripcion.Text = "DESCRIPCION: (opcional)";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(34, 162);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(418, 70);
            this.txtDescripcion.TabIndex = 23;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(34, 255);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(101, 28);
            this.chkActivo.TabIndex = 22;
            this.chkActivo.Text = "Activo";
            this.chkActivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(30, 56);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(94, 24);
            this.lblNombre.TabIndex = 21;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // lblProgreso
            // 
            this.lblProgreso.AutoSize = true;
            this.lblProgreso.Location = new System.Drawing.Point(37, 173);
            this.lblProgreso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProgreso.Name = "lblProgreso";
            this.lblProgreso.Size = new System.Drawing.Size(22, 24);
            this.lblProgreso.TabIndex = 16;
            this.lblProgreso.Text = " ";
            // 
            // btnModifcar
            // 
            this.btnModifcar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnModifcar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifcar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnModifcar.Image = ((System.Drawing.Image)(resources.GetObject("btnModifcar.Image")));
            this.btnModifcar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModifcar.Location = new System.Drawing.Point(34, 305);
            this.btnModifcar.Name = "btnModifcar";
            this.btnModifcar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnModifcar.Size = new System.Drawing.Size(146, 45);
            this.btnModifcar.TabIndex = 14;
            this.btnModifcar.Text = "GUARDAR";
            this.btnModifcar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifcar.UseVisualStyleBackColor = false;
            this.btnModifcar.Click += new System.EventHandler(this.btnModifcar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.DarkRed;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.Location = new System.Drawing.Point(317, 305);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnCerrar.Size = new System.Drawing.Size(135, 45);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(34, 83);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(418, 32);
            this.txtNombre.TabIndex = 9;
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
            this.label1.Size = new System.Drawing.Size(490, 54);
            this.label1.TabIndex = 13;
            this.label1.Text = "MODIFICAR CATEGORIA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmModificarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 490);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmModificarCategoria";
            this.Text = "frmModificarCategoria";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblProgreso;
        private System.Windows.Forms.Button btnModifcar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
    }
}