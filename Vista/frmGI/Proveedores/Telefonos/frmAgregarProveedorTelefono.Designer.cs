namespace Vista.frmGI.Proveedores
{
    partial class frmAgregarProveedorTelefono
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarProveedorTelefono));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblHorario = new System.Windows.Forms.Label();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmailContacto = new System.Windows.Forms.TextBox();
            this.lblSector = new System.Windows.Forms.Label();
            this.txtSector = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnAgregarTelefono = new System.Windows.Forms.Button();
            this.lblContacto = new System.Windows.Forms.Label();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(647, 54);
            this.label1.TabIndex = 21;
            this.label1.Text = "AGREGAR TELEFONO DEL PROVEEDOR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnCerrar);
            this.groupBox1.Controls.Add(this.lblHorario);
            this.groupBox1.Controls.Add(this.txtHorario);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtEmailContacto);
            this.groupBox1.Controls.Add(this.lblSector);
            this.groupBox1.Controls.Add(this.txtSector);
            this.groupBox1.Controls.Add(this.lblTelefono);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.btnAgregarTelefono);
            this.groupBox1.Controls.Add(this.lblContacto);
            this.groupBox1.Controls.Add(this.txtContacto);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 343);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INGRESE LOS DATOS DE TELEFONO";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.DarkRed;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.Location = new System.Drawing.Point(228, 255);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnCerrar.Size = new System.Drawing.Size(135, 45);
            this.btnCerrar.TabIndex = 46;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(28, 148);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(106, 24);
            this.lblHorario.TabIndex = 24;
            this.lblHorario.Text = "HORARIO:";
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(32, 175);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(190, 32);
            this.txtHorario.TabIndex = 23;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(224, 148);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(394, 24);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "CORREO ELECTRONICO DEL CONTACTO:";
            // 
            // txtEmailContacto
            // 
            this.txtEmailContacto.Location = new System.Drawing.Point(228, 175);
            this.txtEmailContacto.Name = "txtEmailContacto";
            this.txtEmailContacto.Size = new System.Drawing.Size(386, 32);
            this.txtEmailContacto.TabIndex = 21;
            // 
            // lblSector
            // 
            this.lblSector.AutoSize = true;
            this.lblSector.Location = new System.Drawing.Point(420, 53);
            this.lblSector.Name = "lblSector";
            this.lblSector.Size = new System.Drawing.Size(94, 24);
            this.lblSector.TabIndex = 20;
            this.lblSector.Text = "SECTOR:";
            // 
            // txtSector
            // 
            this.txtSector.Location = new System.Drawing.Point(424, 80);
            this.txtSector.Name = "txtSector";
            this.txtSector.Size = new System.Drawing.Size(190, 32);
            this.txtSector.TabIndex = 19;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(28, 53);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(118, 24);
            this.lblTelefono.TabIndex = 18;
            this.lblTelefono.Text = "TELEFONO:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(32, 80);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(190, 32);
            this.txtTelefono.TabIndex = 17;
            // 
            // btnAgregarTelefono
            // 
            this.btnAgregarTelefono.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregarTelefono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarTelefono.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAgregarTelefono.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregarTelefono.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarTelefono.Image")));
            this.btnAgregarTelefono.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarTelefono.Location = new System.Drawing.Point(32, 255);
            this.btnAgregarTelefono.Name = "btnAgregarTelefono";
            this.btnAgregarTelefono.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnAgregarTelefono.Size = new System.Drawing.Size(144, 45);
            this.btnAgregarTelefono.TabIndex = 13;
            this.btnAgregarTelefono.Text = "AGREGAR";
            this.btnAgregarTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarTelefono.UseVisualStyleBackColor = false;
            this.btnAgregarTelefono.Click += new System.EventHandler(this.btnAgregarTelefono_Click);
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(224, 53);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(118, 24);
            this.lblContacto.TabIndex = 11;
            this.lblContacto.Text = "CONTACTO:";
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(228, 80);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(190, 32);
            this.txtContacto.TabIndex = 9;
            // 
            // frmAgregarProveedorTelefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmAgregarProveedorTelefono";
            this.Text = "frmAgregarProveedorTelefono";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSector;
        private System.Windows.Forms.TextBox txtSector;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnAgregarTelefono;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmailContacto;
        private System.Windows.Forms.Button btnCerrar;
    }
}