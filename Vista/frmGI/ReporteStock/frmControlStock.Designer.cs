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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMinimo = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvStockMinimo = new System.Windows.Forms.DataGridView();
            this.tabReposicion = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvPuntoReposicion = new System.Windows.Forms.DataGridView();
            this.tabPorVencer = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvPorVencer = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvVencidos = new System.Windows.Forms.DataGridView();
            this.lblCountVencidos = new System.Windows.Forms.Label();
            this.lblCountPorVencer = new System.Windows.Forms.Label();
            this.lblCantReposicion = new System.Windows.Forms.Label();
            this.lblCantStockMinimo = new System.Windows.Forms.Label();
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
            this.tabControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl.Controls.Add(this.tabMinimo);
            this.tabControl.Controls.Add(this.tabReposicion);
            this.tabControl.Controls.Add(this.tabPorVencer);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.tabControl.Location = new System.Drawing.Point(70, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(798, 440);
            this.tabControl.TabIndex = 69;
            // 
            // tabMinimo
            // 
            this.tabMinimo.Controls.Add(this.button7);
            this.tabMinimo.Controls.Add(this.button1);
            this.tabMinimo.Controls.Add(this.dgvStockMinimo);
            this.tabMinimo.Controls.Add(this.lblCantStockMinimo);
            this.tabMinimo.Location = new System.Drawing.Point(4, 33);
            this.tabMinimo.Name = "tabMinimo";
            this.tabMinimo.Padding = new System.Windows.Forms.Padding(3);
            this.tabMinimo.Size = new System.Drawing.Size(790, 403);
            this.tabMinimo.TabIndex = 7;
            this.tabMinimo.Text = "MINIMO";
            this.tabMinimo.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(414, 329);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(152, 34);
            this.button7.TabIndex = 57;
            this.button7.Text = "Refrescar";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(605, 324);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.button1.Size = new System.Drawing.Size(135, 45);
            this.button1.TabIndex = 54;
            this.button1.Text = "CERRAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dgvStockMinimo
            // 
            this.dgvStockMinimo.AllowUserToAddRows = false;
            this.dgvStockMinimo.AllowUserToDeleteRows = false;
            this.dgvStockMinimo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvStockMinimo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStockMinimo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStockMinimo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvStockMinimo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle37.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle37.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStockMinimo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.dgvStockMinimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockMinimo.EnableHeadersVisualStyles = false;
            this.dgvStockMinimo.GridColor = System.Drawing.Color.White;
            this.dgvStockMinimo.Location = new System.Drawing.Point(48, 42);
            this.dgvStockMinimo.Name = "dgvStockMinimo";
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockMinimo.RowHeadersDefaultCellStyle = dataGridViewCellStyle38;
            this.dgvStockMinimo.RowHeadersVisible = false;
            this.dgvStockMinimo.RowHeadersWidth = 51;
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.Color.White;
            this.dgvStockMinimo.RowsDefaultCellStyle = dataGridViewCellStyle39;
            this.dgvStockMinimo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStockMinimo.Size = new System.Drawing.Size(692, 247);
            this.dgvStockMinimo.TabIndex = 53;
            // 
            // tabReposicion
            // 
            this.tabReposicion.Controls.Add(this.button6);
            this.tabReposicion.Controls.Add(this.button2);
            this.tabReposicion.Controls.Add(this.dgvPuntoReposicion);
            this.tabReposicion.Controls.Add(this.lblCantReposicion);
            this.tabReposicion.Location = new System.Drawing.Point(4, 33);
            this.tabReposicion.Name = "tabReposicion";
            this.tabReposicion.Padding = new System.Windows.Forms.Padding(3);
            this.tabReposicion.Size = new System.Drawing.Size(790, 403);
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
            // 
            // dgvPuntoReposicion
            // 
            this.dgvPuntoReposicion.AllowUserToAddRows = false;
            this.dgvPuntoReposicion.AllowUserToDeleteRows = false;
            this.dgvPuntoReposicion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPuntoReposicion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPuntoReposicion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPuntoReposicion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvPuntoReposicion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle40.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle40.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPuntoReposicion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle40;
            this.dgvPuntoReposicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuntoReposicion.EnableHeadersVisualStyles = false;
            this.dgvPuntoReposicion.GridColor = System.Drawing.Color.White;
            this.dgvPuntoReposicion.Location = new System.Drawing.Point(45, 32);
            this.dgvPuntoReposicion.Name = "dgvPuntoReposicion";
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPuntoReposicion.RowHeadersDefaultCellStyle = dataGridViewCellStyle41;
            this.dgvPuntoReposicion.RowHeadersVisible = false;
            this.dgvPuntoReposicion.RowHeadersWidth = 51;
            dataGridViewCellStyle42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle42.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPuntoReposicion.RowsDefaultCellStyle = dataGridViewCellStyle42;
            this.dgvPuntoReposicion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPuntoReposicion.Size = new System.Drawing.Size(692, 247);
            this.dgvPuntoReposicion.TabIndex = 53;
            // 
            // tabPorVencer
            // 
            this.tabPorVencer.Controls.Add(this.button5);
            this.tabPorVencer.Controls.Add(this.button3);
            this.tabPorVencer.Controls.Add(this.dgvPorVencer);
            this.tabPorVencer.Controls.Add(this.lblCountPorVencer);
            this.tabPorVencer.Location = new System.Drawing.Point(4, 33);
            this.tabPorVencer.Name = "tabPorVencer";
            this.tabPorVencer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPorVencer.Size = new System.Drawing.Size(790, 403);
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
            // 
            // dgvPorVencer
            // 
            this.dgvPorVencer.AllowUserToAddRows = false;
            this.dgvPorVencer.AllowUserToDeleteRows = false;
            this.dgvPorVencer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPorVencer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPorVencer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPorVencer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvPorVencer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle43.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle43.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle43.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPorVencer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle43;
            this.dgvPorVencer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPorVencer.EnableHeadersVisualStyles = false;
            this.dgvPorVencer.GridColor = System.Drawing.Color.White;
            this.dgvPorVencer.Location = new System.Drawing.Point(43, 40);
            this.dgvPorVencer.Name = "dgvPorVencer";
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPorVencer.RowHeadersDefaultCellStyle = dataGridViewCellStyle44;
            this.dgvPorVencer.RowHeadersVisible = false;
            this.dgvPorVencer.RowHeadersWidth = 51;
            dataGridViewCellStyle45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle45.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle45.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle45.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle45.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPorVencer.RowsDefaultCellStyle = dataGridViewCellStyle45;
            this.dgvPorVencer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPorVencer.Size = new System.Drawing.Size(692, 247);
            this.dgvPorVencer.TabIndex = 53;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnRefrescar);
            this.tabPage5.Controls.Add(this.button4);
            this.tabPage5.Controls.Add(this.dgvVencidos);
            this.tabPage5.Controls.Add(this.lblCountVencidos);
            this.tabPage5.Location = new System.Drawing.Point(4, 33);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(790, 403);
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
            // 
            // dgvVencidos
            // 
            this.dgvVencidos.AllowUserToAddRows = false;
            this.dgvVencidos.AllowUserToDeleteRows = false;
            this.dgvVencidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvVencidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVencidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVencidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvVencidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle46.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle46.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle46.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle46.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle46.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle46.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVencidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle46;
            this.dgvVencidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVencidos.EnableHeadersVisualStyles = false;
            this.dgvVencidos.GridColor = System.Drawing.Color.White;
            this.dgvVencidos.Location = new System.Drawing.Point(47, 34);
            this.dgvVencidos.Name = "dgvVencidos";
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVencidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle47;
            this.dgvVencidos.RowHeadersVisible = false;
            this.dgvVencidos.RowHeadersWidth = 51;
            dataGridViewCellStyle48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle48.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle48.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle48.SelectionForeColor = System.Drawing.Color.White;
            this.dgvVencidos.RowsDefaultCellStyle = dataGridViewCellStyle48;
            this.dgvVencidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVencidos.Size = new System.Drawing.Size(692, 247);
            this.dgvVencidos.TabIndex = 53;
            // 
            // lblCountVencidos
            // 
            this.lblCountVencidos.AutoSize = true;
            this.lblCountVencidos.Location = new System.Drawing.Point(60, 326);
            this.lblCountVencidos.Name = "lblCountVencidos";
            this.lblCountVencidos.Size = new System.Drawing.Size(82, 24);
            this.lblCountVencidos.TabIndex = 55;
            this.lblCountVencidos.Text = "label1";
            // 
            // lblCountPorVencer
            // 
            this.lblCountPorVencer.AutoSize = true;
            this.lblCountPorVencer.Location = new System.Drawing.Point(65, 323);
            this.lblCountPorVencer.Name = "lblCountPorVencer";
            this.lblCountPorVencer.Size = new System.Drawing.Size(82, 24);
            this.lblCountPorVencer.TabIndex = 55;
            this.lblCountPorVencer.Text = "label1";
            // 
            // lblCantReposicion
            // 
            this.lblCantReposicion.AutoSize = true;
            this.lblCantReposicion.Location = new System.Drawing.Point(103, 320);
            this.lblCantReposicion.Name = "lblCantReposicion";
            this.lblCantReposicion.Size = new System.Drawing.Size(82, 24);
            this.lblCantReposicion.TabIndex = 55;
            this.lblCantReposicion.Text = "label1";
            // 
            // lblCantStockMinimo
            // 
            this.lblCantStockMinimo.AutoSize = true;
            this.lblCantStockMinimo.Location = new System.Drawing.Point(85, 324);
            this.lblCantStockMinimo.Name = "lblCantStockMinimo";
            this.lblCantStockMinimo.Size = new System.Drawing.Size(82, 24);
            this.lblCantStockMinimo.TabIndex = 55;
            this.lblCantStockMinimo.Text = "label1";
            // 
            // frmControlStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 510);
            this.Controls.Add(this.tabControl);
            this.Name = "frmControlStock";
            this.Text = "frmControlStock";
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