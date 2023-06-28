using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryIEFISignorileBautista
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Varid = "0";
            if (dtpFecha.Value >= DateTime.Today)
            {
                MessageBox.Show("Vamos a registrar su producto");
                string contador = Varid + 1;

                int n = dtgvRegistro.Rows.Add();
                 
                dtgvRegistro.Rows[n].Cells[0].Value = contador;
                dtgvRegistro.Rows[n].Cells[1].Value = txtNombreProducto.Text;
                dtgvRegistro.Rows[n].Cells[2].Value = dtpFecha.Text;

            }
            else
            {
                MessageBox.Show("Ingrese una fecha actual o superior");
                dtpFecha.Value = DateTime.Today;
                dtpFecha.Focus();
            }
        }
    }
}
