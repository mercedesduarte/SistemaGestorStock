namespace Vista
{
    partial class MDIParent1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.InicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PersonasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConfiguracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblRol = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblHoras = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblFecha = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contrasenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InicioToolStripMenuItem,
            this.UsuariosToolStripMenuItem,
            this.PersonasToolStripMenuItem,
            this.ConfiguracionToolStripMenuItem,
            this.ReportesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1016, 52);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // InicioToolStripMenuItem
            // 
            this.InicioToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InicioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("InicioToolStripMenuItem.Image")));
            this.InicioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem";
            this.InicioToolStripMenuItem.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.InicioToolStripMenuItem.Size = new System.Drawing.Size(121, 48);
            this.InicioToolStripMenuItem.Text = "INICIO";
            // 
            // UsuariosToolStripMenuItem
            // 
            this.UsuariosToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("UsuariosToolStripMenuItem.Image")));
            this.UsuariosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem";
            this.UsuariosToolStripMenuItem.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.UsuariosToolStripMenuItem.Size = new System.Drawing.Size(139, 48);
            this.UsuariosToolStripMenuItem.Text = "USUARIOS";
            this.UsuariosToolStripMenuItem.Click += new System.EventHandler(this.UsuariosToolStripMenuItem_Click_1);
            // 
            // PersonasToolStripMenuItem
            // 
            this.PersonasToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("PersonasToolStripMenuItem.Image")));
            this.PersonasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PersonasToolStripMenuItem.Name = "PersonasToolStripMenuItem";
            this.PersonasToolStripMenuItem.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.PersonasToolStripMenuItem.Size = new System.Drawing.Size(139, 48);
            this.PersonasToolStripMenuItem.Text = "PERSONAS";
            this.PersonasToolStripMenuItem.Click += new System.EventHandler(this.PersonasToolStripMenuItem_Click_1);
            // 
            // ConfiguracionToolStripMenuItem
            // 
            this.ConfiguracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contrasenaToolStripMenuItem});
            this.ConfiguracionToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfiguracionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ConfiguracionToolStripMenuItem.Image")));
            this.ConfiguracionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ConfiguracionToolStripMenuItem.Name = "ConfiguracionToolStripMenuItem";
            this.ConfiguracionToolStripMenuItem.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.ConfiguracionToolStripMenuItem.Size = new System.Drawing.Size(184, 48);
            this.ConfiguracionToolStripMenuItem.Text = "CONFIGURACION";
            // 
            // ReportesToolStripMenuItem
            // 
            this.ReportesToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ReportesToolStripMenuItem.Image")));
            this.ReportesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem";
            this.ReportesToolStripMenuItem.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.ReportesToolStripMenuItem.Size = new System.Drawing.Size(139, 48);
            this.ReportesToolStripMenuItem.Text = "REPORTES";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblRol});
            this.statusStrip.Location = new System.Drawing.Point(0, 416);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1016, 37);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // lblRol
            // 
            this.lblRol.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Name = "lblRol";
            this.lblRol.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.lblRol.Size = new System.Drawing.Size(60, 32);
            this.lblRol.Text = "Rol";
            // 
            // lblHoras
            // 
            this.lblHoras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHoras.AutoSize = true;
            this.lblHoras.BackColor = System.Drawing.Color.White;
            this.lblHoras.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.Location = new System.Drawing.Point(914, 9);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(90, 22);
            this.lblHoras.TabIndex = 4;
            this.lblHoras.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.White;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(882, 31);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(122, 18);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "dia, 07/12/2003";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(812, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // contrasenaToolStripMenuItem
            // 
            this.contrasenaToolStripMenuItem.Name = "contrasenaToolStripMenuItem";
            this.contrasenaToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.contrasenaToolStripMenuItem.Text = "CONTRASEÑA";
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 453);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIParent1";
            this.Text = "MDIParent1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem UsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PersonasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConfiguracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InicioToolStripMenuItem;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ToolStripStatusLabel lblRol;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem contrasenaToolStripMenuItem;
    }
}



