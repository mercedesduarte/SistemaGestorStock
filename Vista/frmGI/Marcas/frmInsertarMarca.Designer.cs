namespace Vista.frmGI.Marcas
{
    partial class frmInsertarMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsertarMarca));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnInsertarMarca = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(427, 54);
            this.label1.TabIndex = 6;
            this.label1.Text = "INSERTAR MARCA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnCerrar);
            this.groupBox1.Controls.Add(this.btnInsertarMarca);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 250);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INGRESE LOS DATOS DE LA MARCA";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.Location = new System.Drawing.Point(247, 171);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnCerrar.Size = new System.Drawing.Size(141, 45);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnInsertarMarca
            // 
            this.btnInsertarMarca.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnInsertarMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsertarMarca.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnInsertarMarca.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInsertarMarca.Image = ((System.Drawing.Image)(resources.GetObject("btnInsertarMarca.Image")));
            this.btnInsertarMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsertarMarca.Location = new System.Drawing.Point(28, 171);
            this.btnInsertarMarca.Name = "btnInsertarMarca";
            this.btnInsertarMarca.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnInsertarMarca.Size = new System.Drawing.Size(159, 45);
            this.btnInsertarMarca.TabIndex = 13;
            this.btnInsertarMarca.Text = "INSERTAR";
            this.btnInsertarMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertarMarca.UseVisualStyleBackColor = false;
            this.btnInsertarMarca.Click += new System.EventHandler(this.btnInsertarMarca_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(24, 59);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(94, 24);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(28, 86);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(360, 32);
            this.txtNombre.TabIndex = 9;
            // 
            // frmInsertarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 349);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmInsertarMarca";
            this.Text = "frmInsertarMarca";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnInsertarMarca;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
    }
}