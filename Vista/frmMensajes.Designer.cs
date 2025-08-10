namespace Vista
{
    partial class frmMensajes
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
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.listMensajes = new System.Windows.Forms.ListBox();
            this.listPersonas = new System.Windows.Forms.ListBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(335, 363);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(272, 80);
            this.txtMensaje.TabIndex = 0;
            // 
            // listMensajes
            // 
            this.listMensajes.FormattingEnabled = true;
            this.listMensajes.ItemHeight = 16;
            this.listMensajes.Location = new System.Drawing.Point(335, 71);
            this.listMensajes.Name = "listMensajes";
            this.listMensajes.Size = new System.Drawing.Size(250, 212);
            this.listMensajes.TabIndex = 1;
            this.listMensajes.SelectedIndexChanged += new System.EventHandler(this.listMensajes_SelectedIndexChanged);
            // 
            // listPersonas
            // 
            this.listPersonas.FormattingEnabled = true;
            this.listPersonas.ItemHeight = 16;
            this.listPersonas.Location = new System.Drawing.Point(12, 39);
            this.listPersonas.Name = "listPersonas";
            this.listPersonas.Size = new System.Drawing.Size(193, 404);
            this.listPersonas.TabIndex = 2;
            this.listPersonas.SelectedIndexChanged += new System.EventHandler(this.listPersonas_SelectedIndexChanged);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(332, 26);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(138, 16);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "UsuarioSeleccionado";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(642, 285);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(121, 72);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click_1);
            // 
            // frmMensajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.listPersonas);
            this.Controls.Add(this.listMensajes);
            this.Controls.Add(this.txtMensaje);
            this.Name = "frmMensajes";
            this.Text = "frmMensajes";
            this.Load += new System.EventHandler(this.frmMensajes_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.ListBox listMensajes;
        private System.Windows.Forms.ListBox listPersonas;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnEnviar;
    }
}