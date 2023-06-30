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
    public partial class frmVentas : Form
    {
        frmPaginaPrincipal  objetoMain = new frmPaginaPrincipal();
        int Fila = 0;
        public frmVentas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dtpFecha.Value >= DateTime.Today) 
            {
                MessageBox.Show("Vamos a registrar su producto");

                int n = dtgvCargarVentas.Rows.Add();

                dtgvCargarVentas.Rows[n].Cells[0].Value = txtID.Text;
                dtgvCargarVentas.Rows[n].Cells[1].Value = txtCantidad.Text;
                dtgvCargarVentas.Rows[n].Cells[2].Value = txtProduto.Text;
                dtgvCargarVentas.Rows[n].Cells[3].Value = dtpFecha.Text;

                objetoMain.Listado.matrizRegistro[Fila, 0] = txtID.Text;
                objetoMain.Listado.matrizRegistro[Fila, 1] = txtCantidad.Text;
                objetoMain.Listado.matrizRegistro[Fila, 2] = txtProduto.Text;
                objetoMain.Listado.matrizRegistro[Fila, 3] = dtpFecha.Text;

                Fila++;

            }
            else
            {
                MessageBox.Show("Ingrese una fecha actual o superior")
;                dtpFecha.Value = DateTime.Today;
                dtpFecha.Focus();
            }

        }

        private void dtgvCargarVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            objetoMain.Listado.Show();
        }
    }
}
