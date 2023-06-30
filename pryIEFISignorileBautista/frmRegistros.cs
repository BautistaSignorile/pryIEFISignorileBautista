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
    public partial class frmRegistros : Form
    {
        frmPaginaPrincipal objetoMain = new frmPaginaPrincipal();
        int indiceFila = 0;

        public frmRegistros()
        {
            InitializeComponent();
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

                int n = dtgvRegistro.Rows.Add();
                 
                dtgvRegistro.Rows[n].Cells[0].Value = txtID.Text;
                dtgvRegistro.Rows[n].Cells[1].Value = txtNombreProducto.Text;
                dtgvRegistro.Rows[n].Cells[2].Value = dtpFecha.Text;

                objetoMain.Listado.matrizProducto[indiceFila, 0] = txtID.Text;
                objetoMain.Listado.matrizProducto[indiceFila, 1] = txtNombreProducto.Text;
                objetoMain.Listado.matrizProducto[indiceFila, 2] = dtpFecha.Text;

                indiceFila++;

            }
            else
            {
                MessageBox.Show("Ingrese una fecha actual o superior");
                dtpFecha.Value = DateTime.Today;
                dtpFecha.Focus();
            }
        }

       private void frmRegistros_Load(object sender, EventArgs e)
        {

        }

        private void dtgvRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            objetoMain.Listado.Show();
        }
    }
}
