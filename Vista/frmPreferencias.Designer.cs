namespace Vista
{
    partial class frmPreferencias
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxPoliticas = new System.Windows.Forms.GroupBox();
            this.chkDatosPersonales = new System.Windows.Forms.CheckBox();
            this.chkEvitarRepetir = new System.Windows.Forms.CheckBox();
            this.chkCaracterEspecial = new System.Windows.Forms.CheckBox();
            this.chkNumerosLetras = new System.Windows.Forms.CheckBox();
            this.chkMayusMinus = new System.Windows.Forms.CheckBox();
            this.cmbPreguntas = new System.Windows.Forms.ComboBox();
            this.lblPreguntas = new System.Windows.Forms.Label();
            this.nudMinCaracteres = new System.Windows.Forms.NumericUpDown();
            this.lblMinCaracteres = new System.Windows.Forms.Label();
            this.groupBoxAutenticacion = new System.Windows.Forms.GroupBox();
            this.chkAutenticacionDoble = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBoxPoliticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinCaracteres)).BeginInit();
            this.groupBoxAutenticacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.label1.Size = new System.Drawing.Size(336, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuración de Políticas de Seguridad";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxPoliticas
            // 
            this.groupBoxPoliticas.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxPoliticas.Controls.Add(this.chkDatosPersonales);
            this.groupBoxPoliticas.Controls.Add(this.chkEvitarRepetir);
            this.groupBoxPoliticas.Controls.Add(this.chkCaracterEspecial);
            this.groupBoxPoliticas.Controls.Add(this.chkNumerosLetras);
            this.groupBoxPoliticas.Controls.Add(this.chkMayusMinus);
            this.groupBoxPoliticas.Controls.Add(this.cmbPreguntas);
            this.groupBoxPoliticas.Controls.Add(this.lblPreguntas);
            this.groupBoxPoliticas.Controls.Add(this.nudMinCaracteres);
            this.groupBoxPoliticas.Controls.Add(this.lblMinCaracteres);
            this.groupBoxPoliticas.Location = new System.Drawing.Point(20, 60);
            this.groupBoxPoliticas.Name = "groupBoxPoliticas";
            this.groupBoxPoliticas.Size = new System.Drawing.Size(600, 340);
            this.groupBoxPoliticas.TabIndex = 1;
            this.groupBoxPoliticas.TabStop = false;
            this.groupBoxPoliticas.Text = "Políticas de Contraseña";
            // 
            // chkDatosPersonales
            // 
            this.chkDatosPersonales.AutoSize = true;
            this.chkDatosPersonales.Location = new System.Drawing.Point(98, 294);
            this.chkDatosPersonales.Name = "chkDatosPersonales";
            this.chkDatosPersonales.Size = new System.Drawing.Size(286, 21);
            this.chkDatosPersonales.TabIndex = 8;
            this.chkDatosPersonales.Text = "No permitir datos personales en contraseña";
            this.chkDatosPersonales.UseVisualStyleBackColor = true;
            // 
            // chkEvitarRepetir
            // 
            this.chkEvitarRepetir.AutoSize = true;
            this.chkEvitarRepetir.Location = new System.Drawing.Point(98, 252);
            this.chkEvitarRepetir.Name = "chkEvitarRepetir";
            this.chkEvitarRepetir.Size = new System.Drawing.Size(275, 21);
            this.chkEvitarRepetir.TabIndex = 7;
            this.chkEvitarRepetir.Text = "No permitir repetir contraseñas anteriores";
            this.chkEvitarRepetir.UseVisualStyleBackColor = true;
            // 
            // chkCaracterEspecial
            // 
            this.chkCaracterEspecial.AutoSize = true;
            this.chkCaracterEspecial.Location = new System.Drawing.Point(98, 212);
            this.chkCaracterEspecial.Name = "chkCaracterEspecial";
            this.chkCaracterEspecial.Size = new System.Drawing.Size(248, 21);
            this.chkCaracterEspecial.TabIndex = 6;
            this.chkCaracterEspecial.Text = "Obligar al menos un carácter especial";
            this.chkCaracterEspecial.UseVisualStyleBackColor = true;
            // 
            // chkNumerosLetras
            // 
            this.chkNumerosLetras.AutoSize = true;
            this.chkNumerosLetras.Location = new System.Drawing.Point(98, 175);
            this.chkNumerosLetras.Name = "chkNumerosLetras";
            this.chkNumerosLetras.Size = new System.Drawing.Size(256, 21);
            this.chkNumerosLetras.TabIndex = 5;
            this.chkNumerosLetras.Text = "Obligar que contenga números y letras";
            this.chkNumerosLetras.UseVisualStyleBackColor = true;
            // 
            // chkMayusMinus
            // 
            this.chkMayusMinus.AutoSize = true;
            this.chkMayusMinus.Location = new System.Drawing.Point(98, 126);
            this.chkMayusMinus.Name = "chkMayusMinus";
            this.chkMayusMinus.Size = new System.Drawing.Size(315, 21);
            this.chkMayusMinus.TabIndex = 4;
            this.chkMayusMinus.Text = "Obligar combinación de mayúsculas y minúsculas";
            this.chkMayusMinus.UseVisualStyleBackColor = true;
            // 
            // cmbPreguntas
            // 
            this.cmbPreguntas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPreguntas.FormattingEnabled = true;
            this.cmbPreguntas.Items.AddRange(new object[] {
            "2",
            "3",
            "5"});
            this.cmbPreguntas.Location = new System.Drawing.Point(300, 70);
            this.cmbPreguntas.Name = "cmbPreguntas";
            this.cmbPreguntas.Size = new System.Drawing.Size(60, 25);
            this.cmbPreguntas.TabIndex = 3;
            // 
            // lblPreguntas
            // 
            this.lblPreguntas.AutoSize = true;
            this.lblPreguntas.Location = new System.Drawing.Point(20, 70);
            this.lblPreguntas.Name = "lblPreguntas";
            this.lblPreguntas.Size = new System.Drawing.Size(227, 17);
            this.lblPreguntas.TabIndex = 2;
            this.lblPreguntas.Text = "Cantidad de preguntas de seguridad:";
            // 
            // nudMinCaracteres
            // 
            this.nudMinCaracteres.Location = new System.Drawing.Point(300, 30);
            this.nudMinCaracteres.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudMinCaracteres.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudMinCaracteres.Name = "nudMinCaracteres";
            this.nudMinCaracteres.Size = new System.Drawing.Size(60, 25);
            this.nudMinCaracteres.TabIndex = 1;
            this.nudMinCaracteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMinCaracteres.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // lblMinCaracteres
            // 
            this.lblMinCaracteres.AutoSize = true;
            this.lblMinCaracteres.Location = new System.Drawing.Point(20, 30);
            this.lblMinCaracteres.Name = "lblMinCaracteres";
            this.lblMinCaracteres.Size = new System.Drawing.Size(238, 17);
            this.lblMinCaracteres.TabIndex = 0;
            this.lblMinCaracteres.Text = "Mínimo de caracteres en la contraseña:";
            // 
            // groupBoxAutenticacion
            // 
            this.groupBoxAutenticacion.Controls.Add(this.chkAutenticacionDoble);
            this.groupBoxAutenticacion.Location = new System.Drawing.Point(20, 410);
            this.groupBoxAutenticacion.Name = "groupBoxAutenticacion";
            this.groupBoxAutenticacion.Size = new System.Drawing.Size(600, 100);
            this.groupBoxAutenticacion.TabIndex = 2;
            this.groupBoxAutenticacion.TabStop = false;
            this.groupBoxAutenticacion.Text = "Autenticación";
            // 
            // chkAutenticacionDoble
            // 
            this.chkAutenticacionDoble.AutoSize = true;
            this.chkAutenticacionDoble.Location = new System.Drawing.Point(62, 45);
            this.chkAutenticacionDoble.Name = "chkAutenticacionDoble";
            this.chkAutenticacionDoble.Size = new System.Drawing.Size(340, 21);
            this.chkAutenticacionDoble.TabIndex = 9;
            this.chkAutenticacionDoble.Text = "Requerir autenticación en dos pasos (2FA) por correo";
            this.chkAutenticacionDoble.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(265, 530);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 40);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(379, 530);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 40);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // frmPreferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(660, 600);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBoxAutenticacion);
            this.Controls.Add(this.groupBoxPoliticas);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPreferencias";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración de Seguridad";
            this.groupBoxPoliticas.ResumeLayout(false);
            this.groupBoxPoliticas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinCaracteres)).EndInit();
            this.groupBoxAutenticacion.ResumeLayout(false);
            this.groupBoxAutenticacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxPoliticas;
        private System.Windows.Forms.CheckBox chkDatosPersonales;
        private System.Windows.Forms.CheckBox chkEvitarRepetir;
        private System.Windows.Forms.CheckBox chkCaracterEspecial;
        private System.Windows.Forms.CheckBox chkNumerosLetras;
        private System.Windows.Forms.CheckBox chkMayusMinus;
        private System.Windows.Forms.ComboBox cmbPreguntas;
        private System.Windows.Forms.NumericUpDown nudMinCaracteres;
        private System.Windows.Forms.Label lblPreguntas;
        private System.Windows.Forms.Label lblMinCaracteres;
        private System.Windows.Forms.GroupBox groupBoxAutenticacion;
        private System.Windows.Forms.CheckBox chkAutenticacionDoble;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
    }
}