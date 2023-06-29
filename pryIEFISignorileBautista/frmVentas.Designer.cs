namespace pryIEFISignorileBautista
{
    partial class frmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.mrcCargarVentas = new System.Windows.Forms.GroupBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblFechaDeVenta = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.mrcRegistroVentas = new System.Windows.Forms.GroupBox();
            this.dtgvCargarVentas = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListado = new System.Windows.Forms.Button();
            this.mrcCargarVentas.SuspendLayout();
            this.mrcRegistroVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCargarVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcCargarVentas
            // 
            this.mrcCargarVentas.Controls.Add(this.txtID);
            this.mrcCargarVentas.Controls.Add(this.lblID);
            this.mrcCargarVentas.Controls.Add(this.btnCargar);
            this.mrcCargarVentas.Controls.Add(this.dtpFecha);
            this.mrcCargarVentas.Controls.Add(this.txtCantidad);
            this.mrcCargarVentas.Controls.Add(this.txtProduto);
            this.mrcCargarVentas.Controls.Add(this.lblCantidad);
            this.mrcCargarVentas.Controls.Add(this.lblFechaDeVenta);
            this.mrcCargarVentas.Controls.Add(this.lblProducto);
            this.mrcCargarVentas.Location = new System.Drawing.Point(12, 12);
            this.mrcCargarVentas.Name = "mrcCargarVentas";
            this.mrcCargarVentas.Size = new System.Drawing.Size(253, 201);
            this.mrcCargarVentas.TabIndex = 0;
            this.mrcCargarVentas.TabStop = false;
            this.mrcCargarVentas.Text = "Cargar Venta";
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCargar.Location = new System.Drawing.Point(82, 172);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "CARGAR";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(14, 109);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(222, 20);
            this.dtpFecha.TabIndex = 5;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(15, 148);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(222, 20);
            this.txtCantidad.TabIndex = 4;
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(15, 70);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(222, 20);
            this.txtProduto.TabIndex = 3;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(13, 132);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblFechaDeVenta
            // 
            this.lblFechaDeVenta.AutoSize = true;
            this.lblFechaDeVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDeVenta.Location = new System.Drawing.Point(12, 93);
            this.lblFechaDeVenta.Name = "lblFechaDeVenta";
            this.lblFechaDeVenta.Size = new System.Drawing.Size(86, 13);
            this.lblFechaDeVenta.TabIndex = 1;
            this.lblFechaDeVenta.Text = "Fecha de Venta:";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(13, 54);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(53, 13);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Producto:";
            this.lblProducto.Click += new System.EventHandler(this.label1_Click);
            // 
            // mrcRegistroVentas
            // 
            this.mrcRegistroVentas.Controls.Add(this.btnListado);
            this.mrcRegistroVentas.Controls.Add(this.dtgvCargarVentas);
            this.mrcRegistroVentas.Location = new System.Drawing.Point(271, 12);
            this.mrcRegistroVentas.Name = "mrcRegistroVentas";
            this.mrcRegistroVentas.Size = new System.Drawing.Size(447, 232);
            this.mrcRegistroVentas.TabIndex = 6;
            this.mrcRegistroVentas.TabStop = false;
            this.mrcRegistroVentas.Text = "Registro Venta";
            // 
            // dtgvCargarVentas
            // 
            this.dtgvCargarVentas.AllowUserToAddRows = false;
            this.dtgvCargarVentas.AllowUserToDeleteRows = false;
            this.dtgvCargarVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCargarVentas.BackgroundColor = System.Drawing.Color.DarkGoldenrod;
            this.dtgvCargarVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCargarVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Producto,
            this.Cantidad,
            this.Fecha});
            this.dtgvCargarVentas.Location = new System.Drawing.Point(6, 16);
            this.dtgvCargarVentas.Name = "dtgvCargarVentas";
            this.dtgvCargarVentas.ReadOnly = true;
            this.dtgvCargarVentas.RowHeadersVisible = false;
            this.dtgvCargarVentas.Size = new System.Drawing.Size(435, 179);
            this.dtgvCargarVentas.TabIndex = 0;
            this.dtgvCargarVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCargarVentas_CellContentClick);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Goldenrod;
            this.btnVolver.Location = new System.Drawing.Point(94, 219);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(15, 32);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(222, 20);
            this.txtID.TabIndex = 7;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(13, 16);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "ID:";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // btnListado
            // 
            this.btnListado.BackColor = System.Drawing.Color.Goldenrod;
            this.btnListado.Location = new System.Drawing.Point(179, 201);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(75, 23);
            this.btnListado.TabIndex = 8;
            this.btnListado.Text = "LISTADO";
            this.btnListado.UseVisualStyleBackColor = false;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(732, 256);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.mrcRegistroVentas);
            this.Controls.Add(this.mrcCargarVentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVentas";
            this.Text = "Ventas";
            this.mrcCargarVentas.ResumeLayout(false);
            this.mrcCargarVentas.PerformLayout();
            this.mrcRegistroVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCargarVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcCargarVentas;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblFechaDeVenta;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.GroupBox mrcRegistroVentas;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dtgvCargarVentas;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.Button btnListado;
    }
}