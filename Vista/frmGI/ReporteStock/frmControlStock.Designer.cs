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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabVencidos = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.lblCantStockMinimo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvStockMinimo = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.lblCantReposicion = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvPuntoReposicion = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.lblCountPorVencer = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvPorVencer = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.lblCountVencidos = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvVencidos = new System.Windows.Forms.DataGridView();
            this.tabVencidos.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockMinimo)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntoReposicion)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPorVencer)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVencidos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabVencidos
            // 
            this.tabVencidos.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.tabVencidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabVencidos.Controls.Add(this.tabPage2);
            this.tabVencidos.Controls.Add(this.tabPage3);
            this.tabVencidos.Controls.Add(this.tabPage4);
            this.tabVencidos.Controls.Add(this.tabPage5);
            this.tabVencidos.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.tabVencidos.Location = new System.Drawing.Point(70, 12);
            this.tabVencidos.Name = "tabVencidos";
            this.tabVencidos.SelectedIndex = 0;
            this.tabVencidos.Size = new System.Drawing.Size(798, 440);
            this.tabVencidos.TabIndex = 69;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.lblCantStockMinimo);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dgvStockMinimo);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 403);
            this.tabPage2.TabIndex = 7;
            this.tabPage2.Text = "MINIMO";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // lblCantStockMinimo
            // 
            this.lblCantStockMinimo.AutoSize = true;
            this.lblCantStockMinimo.Location = new System.Drawing.Point(85, 324);
            this.lblCantStockMinimo.Name = "lblCantStockMinimo";
            this.lblCantStockMinimo.Size = new System.Drawing.Size(82, 24);
            this.lblCantStockMinimo.TabIndex = 55;
            this.lblCantStockMinimo.Text = "label1";
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStockMinimo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvStockMinimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockMinimo.EnableHeadersVisualStyles = false;
            this.dgvStockMinimo.GridColor = System.Drawing.Color.White;
            this.dgvStockMinimo.Location = new System.Drawing.Point(48, 42);
            this.dgvStockMinimo.Name = "dgvStockMinimo";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockMinimo.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvStockMinimo.RowHeadersVisible = false;
            this.dgvStockMinimo.RowHeadersWidth = 51;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.dgvStockMinimo.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvStockMinimo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStockMinimo.Size = new System.Drawing.Size(692, 247);
            this.dgvStockMinimo.TabIndex = 53;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.lblCantReposicion);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.dgvPuntoReposicion);
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(790, 403);
            this.tabPage3.TabIndex = 8;
            this.tabPage3.Text = "REPOSICION";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // lblCantReposicion
            // 
            this.lblCantReposicion.AutoSize = true;
            this.lblCantReposicion.Location = new System.Drawing.Point(103, 320);
            this.lblCantReposicion.Name = "lblCantReposicion";
            this.lblCantReposicion.Size = new System.Drawing.Size(82, 24);
            this.lblCantReposicion.TabIndex = 55;
            this.lblCantReposicion.Text = "label1";
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPuntoReposicion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvPuntoReposicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuntoReposicion.EnableHeadersVisualStyles = false;
            this.dgvPuntoReposicion.GridColor = System.Drawing.Color.White;
            this.dgvPuntoReposicion.Location = new System.Drawing.Point(45, 32);
            this.dgvPuntoReposicion.Name = "dgvPuntoReposicion";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPuntoReposicion.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvPuntoReposicion.RowHeadersVisible = false;
            this.dgvPuntoReposicion.RowHeadersWidth = 51;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPuntoReposicion.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvPuntoReposicion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPuntoReposicion.Size = new System.Drawing.Size(692, 247);
            this.dgvPuntoReposicion.TabIndex = 53;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button5);
            this.tabPage4.Controls.Add(this.lblCountPorVencer);
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.dgvPorVencer);
            this.tabPage4.Location = new System.Drawing.Point(4, 33);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(790, 403);
            this.tabPage4.TabIndex = 9;
            this.tabPage4.Text = "POR VENCER";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            // lblCountPorVencer
            // 
            this.lblCountPorVencer.AutoSize = true;
            this.lblCountPorVencer.Location = new System.Drawing.Point(65, 323);
            this.lblCountPorVencer.Name = "lblCountPorVencer";
            this.lblCountPorVencer.Size = new System.Drawing.Size(82, 24);
            this.lblCountPorVencer.TabIndex = 55;
            this.lblCountPorVencer.Text = "label1";
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
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPorVencer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvPorVencer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPorVencer.EnableHeadersVisualStyles = false;
            this.dgvPorVencer.GridColor = System.Drawing.Color.White;
            this.dgvPorVencer.Location = new System.Drawing.Point(43, 40);
            this.dgvPorVencer.Name = "dgvPorVencer";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPorVencer.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvPorVencer.RowHeadersVisible = false;
            this.dgvPorVencer.RowHeadersWidth = 51;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPorVencer.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvPorVencer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPorVencer.Size = new System.Drawing.Size(692, 247);
            this.dgvPorVencer.TabIndex = 53;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnRefrescar);
            this.tabPage5.Controls.Add(this.lblCountVencidos);
            this.tabPage5.Controls.Add(this.button4);
            this.tabPage5.Controls.Add(this.dgvVencidos);
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
            // lblCountVencidos
            // 
            this.lblCountVencidos.AutoSize = true;
            this.lblCountVencidos.Location = new System.Drawing.Point(60, 326);
            this.lblCountVencidos.Name = "lblCountVencidos";
            this.lblCountVencidos.Size = new System.Drawing.Size(82, 24);
            this.lblCountVencidos.TabIndex = 55;
            this.lblCountVencidos.Text = "label1";
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
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVencidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvVencidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVencidos.EnableHeadersVisualStyles = false;
            this.dgvVencidos.GridColor = System.Drawing.Color.White;
            this.dgvVencidos.Location = new System.Drawing.Point(47, 34);
            this.dgvVencidos.Name = "dgvVencidos";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVencidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvVencidos.RowHeadersVisible = false;
            this.dgvVencidos.RowHeadersWidth = 51;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White;
            this.dgvVencidos.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvVencidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVencidos.Size = new System.Drawing.Size(692, 247);
            this.dgvVencidos.TabIndex = 53;
            // 
            // frmControlStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 510);
            this.Controls.Add(this.tabVencidos);
            this.Name = "frmControlStock";
            this.Text = "frmControlStock";
            this.tabVencidos.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockMinimo)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntoReposicion)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPorVencer)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVencidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabVencidos;
        private System.Windows.Forms.TabPage tabPage2;
        internal System.Windows.Forms.DataGridView dgvStockMinimo;
        private System.Windows.Forms.TabPage tabPage3;
        internal System.Windows.Forms.DataGridView dgvPuntoReposicion;
        private System.Windows.Forms.TabPage tabPage4;
        internal System.Windows.Forms.DataGridView dgvPorVencer;
        private System.Windows.Forms.TabPage tabPage5;
        internal System.Windows.Forms.DataGridView dgvVencidos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label lblCantStockMinimo;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lblCantReposicion;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblCountPorVencer;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Label lblCountVencidos;
    }
}