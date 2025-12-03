namespace Vista.frmGI.ReporteStock
{
    partial class frmControlStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControlStock));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMinimo = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvStockMinimo = new System.Windows.Forms.DataGridView();
            this.lblCantStockMinimo = new System.Windows.Forms.Label();
            this.tabReposicion = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvPuntoReposicion = new System.Windows.Forms.DataGridView();
            this.lblCantReposicion = new System.Windows.Forms.Label();
            this.tabPorVencer = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvPorVencer = new System.Windows.Forms.DataGridView();
            this.lblCountPorVencer = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvVencidos = new System.Windows.Forms.DataGridView();
            this.lblCountVencidos = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabMinimo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockMinimo)).BeginInit();
            this.tabReposicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntoReposicion)).BeginInit();
            this.tabPorVencer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPorVencer)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVencidos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.tabControl.Controls.Add(this.tabMinimo);
            this.tabControl.Controls.Add(this.tabReposicion);
            this.tabControl.Controls.Add(this.tabPorVencer);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1000, 600);
            this.tabControl.TabIndex = 69;
            // 
            // tabMinimo
            // 
            this.tabMinimo.Controls.Add(this.button7);
            this.tabMinimo.Controls.Add(this.button1);
            this.tabMinimo.Controls.Add(this.dgvStockMinimo);
            this.tabMinimo.Controls.Add(this.lblCantStockMinimo);
            this.tabMinimo.Location = new System.Drawing.Point(4, 28);
            this.tabMinimo.Name = "tabMinimo";
            this.tabMinimo.Padding = new System.Windows.Forms.Padding(3);
            this.tabMinimo.Size = new System.Drawing.Size(992, 568);
            this.tabMinimo.TabIndex = 7;
            this.tabMinimo.Text = "MINIMO";
            this.tabMinimo.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(356, 496);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(152, 34);
            this.button7.TabIndex = 57;
            this.button7.Text = "Refrescar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btnRefrescarMinimo_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(547, 491);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.button1.Size = new System.Drawing.Size(135, 45);
            this.button1.TabIndex = 54;
            this.button1.Text = "CERRAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvStockMinimo
            // 
            this.dgvStockMinimo.AllowUserToAddRows = false;
            this.dgvStockMinimo.AllowUserToDeleteRows = false;
            this.dgvStockMinimo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStockMinimo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStockMinimo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStockMinimo.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStockMinimo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStockMinimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockMinimo.EnableHeadersVisualStyles = false;
            this.dgvStockMinimo.GridColor = System.Drawing.Color.White;
            this.dgvStockMinimo.Location = new System.Drawing.Point(69, 15);
            this.dgvStockMinimo.Name = "dgvStockMinimo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockMinimo.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStockMinimo.RowHeadersVisible = false;
            this.dgvStockMinimo.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvStockMinimo.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStockMinimo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStockMinimo.Size = new System.Drawing.Size(1232, 470);
            this.dgvStockMinimo.TabIndex = 53;
            // 
            // lblCantStockMinimo
            // 
            this.lblCantStockMinimo.AutoSize = true;
            this.lblCantStockMinimo.Location = new System.Drawing.Point(6, 309);
            this.lblCantStockMinimo.Name = "lblCantStockMinimo";
            this.lblCantStockMinimo.Size = new System.Drawing.Size(63, 19);
            this.lblCantStockMinimo.TabIndex = 55;
            this.lblCantStockMinimo.Text = "label1";
            // 
            // tabReposicion
            // 
            this.tabReposicion.Controls.Add(this.button6);
            this.tabReposicion.Controls.Add(this.button2);
            this.tabReposicion.Controls.Add(this.dgvPuntoReposicion);
            this.tabReposicion.Controls.Add(this.lblCantReposicion);
            this.tabReposicion.Location = new System.Drawing.Point(4, 28);
            this.tabReposicion.Name = "tabReposicion";
            this.tabReposicion.Padding = new System.Windows.Forms.Padding(3);
            this.tabReposicion.Size = new System.Drawing.Size(192, 68);
            this.tabReposicion.TabIndex = 8;
            this.tabReposicion.Text = "REPOSICION";
            this.tabReposicion.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(411, 331);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(152, 34);
            this.button6.TabIndex = 57;
            this.button6.Text = "Refrescar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnRefrescarReposicion_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(602, 326);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.button2.Size = new System.Drawing.Size(135, 45);
            this.button2.TabIndex = 54;
            this.button2.Text = "CERRAR";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvPuntoReposicion
            // 
            this.dgvPuntoReposicion.AllowUserToAddRows = false;
            this.dgvPuntoReposicion.AllowUserToDeleteRows = false;
            this.dgvPuntoReposicion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPuntoReposicion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPuntoReposicion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPuntoReposicion.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPuntoReposicion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPuntoReposicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuntoReposicion.EnableHeadersVisualStyles = false;
            this.dgvPuntoReposicion.GridColor = System.Drawing.Color.White;
            this.dgvPuntoReposicion.Location = new System.Drawing.Point(45, 32);
            this.dgvPuntoReposicion.Name = "dgvPuntoReposicion";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPuntoReposicion.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPuntoReposicion.RowHeadersVisible = false;
            this.dgvPuntoReposicion.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Consolas", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPuntoReposicion.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPuntoReposicion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPuntoReposicion.Size = new System.Drawing.Size(692, 247);
            this.dgvPuntoReposicion.TabIndex = 53;
            // 
            // lblCantReposicion
            // 
            this.lblCantReposicion.AutoSize = true;
            this.lblCantReposicion.Location = new System.Drawing.Point(20, 320);
            this.lblCantReposicion.Name = "lblCantReposicion";
            this.lblCantReposicion.Size = new System.Drawing.Size(63, 19);
            this.lblCantReposicion.TabIndex = 55;
            this.lblCantReposicion.Text = "label1";
            // 
            // tabPorVencer
            // 
            this.tabPorVencer.Controls.Add(this.button5);
            this.tabPorVencer.Controls.Add(this.button3);
            this.tabPorVencer.Controls.Add(this.dgvPorVencer);
            this.tabPorVencer.Controls.Add(this.lblCountPorVencer);
            this.tabPorVencer.Location = new System.Drawing.Point(4, 28);
            this.tabPorVencer.Name = "tabPorVencer";
            this.tabPorVencer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPorVencer.Size = new System.Drawing.Size(192, 68);
            this.tabPorVencer.TabIndex = 9;
            this.tabPorVencer.Text = "POR VENCER";
            this.tabPorVencer.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(422, 328);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(152, 34);
            this.button5.TabIndex = 57;
            this.button5.Text = "Refrescar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnRefrescarPorVencer_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(600, 323);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.button3.Size = new System.Drawing.Size(135, 45);
            this.button3.TabIndex = 54;
            this.button3.Text = "CERRAR";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvPorVencer
            // 
            this.dgvPorVencer.AllowUserToAddRows = false;
            this.dgvPorVencer.AllowUserToDeleteRows = false;
            this.dgvPorVencer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPorVencer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPorVencer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPorVencer.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPorVencer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPorVencer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPorVencer.EnableHeadersVisualStyles = false;
            this.dgvPorVencer.GridColor = System.Drawing.Color.White;
            this.dgvPorVencer.Location = new System.Drawing.Point(43, 40);
            this.dgvPorVencer.Name = "dgvPorVencer";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPorVencer.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPorVencer.RowHeadersVisible = false;
            this.dgvPorVencer.RowHeadersWidth = 51;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Consolas", 10F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPorVencer.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPorVencer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPorVencer.Size = new System.Drawing.Size(692, 247);
            this.dgvPorVencer.TabIndex = 53;
            // 
            // lblCountPorVencer
            // 
            this.lblCountPorVencer.AutoSize = true;
            this.lblCountPorVencer.Location = new System.Drawing.Point(20, 320);
            this.lblCountPorVencer.Name = "lblCountPorVencer";
            this.lblCountPorVencer.Size = new System.Drawing.Size(63, 19);
            this.lblCountPorVencer.TabIndex = 55;
            this.lblCountPorVencer.Text = "label1";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnRefrescar);
            this.tabPage5.Controls.Add(this.button4);
            this.tabPage5.Controls.Add(this.dgvVencidos);
            this.tabPage5.Controls.Add(this.lblCountVencidos);
            this.tabPage5.Location = new System.Drawing.Point(4, 28);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(192, 68);
            this.tabPage5.TabIndex = 10;
            this.tabPage5.Text = "VENCIDOS";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(384, 316);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(152, 34);
            this.btnRefrescar.TabIndex = 56;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescarVencidos_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkRed;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(604, 316);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.button4.Size = new System.Drawing.Size(135, 45);
            this.button4.TabIndex = 54;
            this.button4.Text = "CERRAR";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvVencidos
            // 
            this.dgvVencidos.AllowUserToAddRows = false;
            this.dgvVencidos.AllowUserToDeleteRows = false;
            this.dgvVencidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVencidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVencidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVencidos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVencidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvVencidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVencidos.EnableHeadersVisualStyles = false;
            this.dgvVencidos.GridColor = System.Drawing.Color.White;
            this.dgvVencidos.Location = new System.Drawing.Point(47, 34);
            this.dgvVencidos.Name = "dgvVencidos";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVencidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvVencidos.RowHeadersVisible = false;
            this.dgvVencidos.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Consolas", 10F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvVencidos.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvVencidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVencidos.Size = new System.Drawing.Size(692, 247);
            this.dgvVencidos.TabIndex = 53;
            // 
            // lblCountVencidos
            // 
            this.lblCountVencidos.AutoSize = true;
            this.lblCountVencidos.Location = new System.Drawing.Point(20, 320);
            this.lblCountVencidos.Name = "lblCountVencidos";
            this.lblCountVencidos.Size = new System.Drawing.Size(63, 19);
            this.lblCountVencidos.TabIndex = 55;
            this.lblCountVencidos.Text = "label1";
            // 
            // frmControlStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.tabControl);
            this.Name = "frmControlStock";
            this.Text = "Control de Stock";
            this.Load += new System.EventHandler(this.frmControlStock_Load);
            this.tabControl.ResumeLayout(false);
            this.tabMinimo.ResumeLayout(false);
            this.tabMinimo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockMinimo)).EndInit();
            this.tabReposicion.ResumeLayout(false);
            this.tabReposicion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntoReposicion)).EndInit();
            this.tabPorVencer.ResumeLayout(false);
            this.tabPorVencer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPorVencer)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVencidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMinimo;
        internal System.Windows.Forms.DataGridView dgvStockMinimo;
        private System.Windows.Forms.TabPage tabReposicion;
        internal System.Windows.Forms.DataGridView dgvPuntoReposicion;
        private System.Windows.Forms.TabPage tabPorVencer;
        internal System.Windows.Forms.DataGridView dgvPorVencer;
        private System.Windows.Forms.TabPage tabPage5;
        internal System.Windows.Forms.DataGridView dgvVencidos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Label lblCantStockMinimo;
        private System.Windows.Forms.Label lblCantReposicion;
        private System.Windows.Forms.Label lblCountPorVencer;
        private System.Windows.Forms.Label lblCountVencidos;

    }
}