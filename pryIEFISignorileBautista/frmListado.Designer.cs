namespace pryIEFISignorileBautista
{
    partial class frmListado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListado));
            this.dtgvListado = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDeProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListar = new System.Windows.Forms.Button();
            this.rdbProducto = new System.Windows.Forms.RadioButton();
            this.rdbVenta = new System.Windows.Forms.RadioButton();
            this.mrcFiltro = new System.Windows.Forms.GroupBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lstVenta = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListado)).BeginInit();
            this.mrcFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvListado
            // 
            this.dtgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvListado.BackgroundColor = System.Drawing.Color.DarkGoldenrod;
            this.dtgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NombreDeProducto,
            this.Fecha});
            this.dtgvListado.Location = new System.Drawing.Point(23, 131);
            this.dtgvListado.Name = "dtgvListado";
            this.dtgvListado.RowHeadersVisible = false;
            this.dtgvListado.Size = new System.Drawing.Size(642, 266);
            this.dtgvListado.TabIndex = 0;
            this.dtgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListado_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // NombreDeProducto
            // 
            this.NombreDeProducto.HeaderText = "Nombre Producto";
            this.NombreDeProducto.Name = "NombreDeProducto";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnListar.Location = new System.Drawing.Point(23, 92);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listado";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // rdbProducto
            // 
            this.rdbProducto.AutoSize = true;
            this.rdbProducto.Location = new System.Drawing.Point(152, 28);
            this.rdbProducto.Name = "rdbProducto";
            this.rdbProducto.Size = new System.Drawing.Size(68, 17);
            this.rdbProducto.TabIndex = 2;
            this.rdbProducto.Text = "Producto";
            this.rdbProducto.UseVisualStyleBackColor = true;
            // 
            // rdbVenta
            // 
            this.rdbVenta.AutoSize = true;
            this.rdbVenta.Checked = true;
            this.rdbVenta.Location = new System.Drawing.Point(226, 28);
            this.rdbVenta.Name = "rdbVenta";
            this.rdbVenta.Size = new System.Drawing.Size(53, 17);
            this.rdbVenta.TabIndex = 3;
            this.rdbVenta.TabStop = true;
            this.rdbVenta.Text = "Venta";
            this.rdbVenta.UseVisualStyleBackColor = true;
            this.rdbVenta.CheckedChanged += new System.EventHandler(this.rdbVenta_CheckedChanged);
            // 
            // mrcFiltro
            // 
            this.mrcFiltro.Controls.Add(this.lstVenta);
            this.mrcFiltro.Controls.Add(this.btnFiltrar);
            this.mrcFiltro.Controls.Add(this.rdbVenta);
            this.mrcFiltro.Controls.Add(this.rdbProducto);
            this.mrcFiltro.Location = new System.Drawing.Point(23, 15);
            this.mrcFiltro.Name = "mrcFiltro";
            this.mrcFiltro.Size = new System.Drawing.Size(642, 67);
            this.mrcFiltro.TabIndex = 4;
            this.mrcFiltro.TabStop = false;
            this.mrcFiltro.Text = "Filtro:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnFiltrar.Location = new System.Drawing.Point(499, 26);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lstVenta
            // 
            this.lstVenta.Enabled = false;
            this.lstVenta.FormattingEnabled = true;
            this.lstVenta.Location = new System.Drawing.Point(285, 27);
            this.lstVenta.Name = "lstVenta";
            this.lstVenta.Size = new System.Drawing.Size(121, 21);
            this.lstVenta.TabIndex = 5;
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(695, 409);
            this.Controls.Add(this.mrcFiltro);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dtgvListado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListado";
            this.Text = "frmListado";
            this.Load += new System.EventHandler(this.frmListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListado)).EndInit();
            this.mrcFiltro.ResumeLayout(false);
            this.mrcFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDeProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.RadioButton rdbProducto;
        private System.Windows.Forms.RadioButton rdbVenta;
        private System.Windows.Forms.DataGridView dtgvListado;
        private System.Windows.Forms.GroupBox mrcFiltro;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox lstVenta;
    }
}