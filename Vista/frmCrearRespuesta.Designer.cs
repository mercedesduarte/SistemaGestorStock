namespace Vista
{
    partial class frmCrearRespuesta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrearRespuesta));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPreguntas = new System.Windows.Forms.ComboBox();
            this.lblPreguntaLista = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnCrearRespuesta = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.cmbPreguntas);
            this.groupBox1.Controls.Add(this.lblPreguntaLista);
            this.groupBox1.Controls.Add(this.btnCerrar);
            this.groupBox1.Controls.Add(this.btnCrearRespuesta);
            this.groupBox1.Controls.Add(this.lblUsuario);
            this.groupBox1.Controls.Add(this.txtRespuesta);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-11, 99);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(823, 354);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INGRESE LA RESPUESTA";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbPreguntas
            // 
            this.cmbPreguntas.Items.AddRange(new object[] {
            "DNI",
            "CUIL"});
            this.cmbPreguntas.Location = new System.Drawing.Point(272, 83);
            this.cmbPreguntas.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPreguntas.Name = "cmbPreguntas";
            this.cmbPreguntas.Size = new System.Drawing.Size(299, 39);
            this.cmbPreguntas.TabIndex = 18;
            // 
            // lblPreguntaLista
            // 
            this.lblPreguntaLista.AutoSize = true;
            this.lblPreguntaLista.Location = new System.Drawing.Point(272, 86);
            this.lblPreguntaLista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreguntaLista.Name = "lblPreguntaLista";
            this.lblPreguntaLista.Size = new System.Drawing.Size(29, 32);
            this.lblPreguntaLista.TabIndex = 15;
            this.lblPreguntaLista.Text = " ";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.Location = new System.Drawing.Point(504, 235);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.btnCerrar.Size = new System.Drawing.Size(188, 55);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // btnCrearRespuesta
            // 
            this.btnCrearRespuesta.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCrearRespuesta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearRespuesta.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCrearRespuesta.Image = ((System.Drawing.Image)(resources.GetObject("btnCrearRespuesta.Image")));
            this.btnCrearRespuesta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrearRespuesta.Location = new System.Drawing.Point(120, 235);
            this.btnCrearRespuesta.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearRespuesta.Name = "btnCrearRespuesta";
            this.btnCrearRespuesta.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.btnCrearRespuesta.Size = new System.Drawing.Size(312, 55);
            this.btnCrearRespuesta.TabIndex = 13;
            this.btnCrearRespuesta.Text = "CREAR RESPUESTA";
            this.btnCrearRespuesta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearRespuesta.UseVisualStyleBackColor = false;
            this.btnCrearRespuesta.Click += new System.EventHandler(this.btnCrearRespuesta_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(115, 86);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(149, 32);
            this.lblUsuario.TabIndex = 11;
            this.lblUsuario.Text = "PREGUNTA:";
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(120, 132);
            this.txtRespuesta.Margin = new System.Windows.Forms.Padding(4);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(571, 38);
            this.txtRespuesta.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-11, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(823, 66);
            this.label1.TabIndex = 4;
            this.label1.Text = "CREAR  RESPUESTAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCrearRespuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmCrearRespuesta";
            this.Text = "frmCrearRespuesta";
            this.Load += new System.EventHandler(this.frmCrearRespuesta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnCrearRespuesta;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPreguntaLista;
        private System.Windows.Forms.ComboBox cmbPreguntas;
    }
}