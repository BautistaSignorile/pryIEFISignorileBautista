namespace pryIEFISignorileBautista
{
    partial class frmPaginaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaginaPrincipal));
            this.picVentaLogo = new System.Windows.Forms.PictureBox();
            this.lblVentaLogo = new System.Windows.Forms.Label();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picVentaLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picVentaLogo
            // 
            this.picVentaLogo.Image = ((System.Drawing.Image)(resources.GetObject("picVentaLogo.Image")));
            this.picVentaLogo.Location = new System.Drawing.Point(12, 12);
            this.picVentaLogo.Name = "picVentaLogo";
            this.picVentaLogo.Size = new System.Drawing.Size(218, 143);
            this.picVentaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVentaLogo.TabIndex = 0;
            this.picVentaLogo.TabStop = false;
            // 
            // lblVentaLogo
            // 
            this.lblVentaLogo.AutoSize = true;
            this.lblVentaLogo.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentaLogo.Location = new System.Drawing.Point(71, 158);
            this.lblVentaLogo.Name = "lblVentaLogo";
            this.lblVentaLogo.Size = new System.Drawing.Size(109, 42);
            this.lblVentaLogo.TabIndex = 1;
            this.lblVentaLogo.Text = "VENTAS";
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.Color.Goldenrod;
            this.btnRegistro.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.Location = new System.Drawing.Point(12, 232);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(83, 23);
            this.btnRegistro.TabIndex = 2;
            this.btnRegistro.Text = "REGISTRO";
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.Goldenrod;
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Location = new System.Drawing.Point(146, 232);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(75, 23);
            this.btnVentas.TabIndex = 3;
            this.btnVentas.Text = "VENTAS";
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmPaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(244, 283);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.lblVentaLogo);
            this.Controls.Add(this.picVentaLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPaginaPrincipal";
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.picVentaLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picVentaLogo;
        private System.Windows.Forms.Label lblVentaLogo;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnVentas;
    }
}

