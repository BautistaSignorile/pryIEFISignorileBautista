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
    public partial class frmPaginaPrincipal : Form
    {
        public frmPaginaPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Productos = new frmProductos();
            Productos.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Ventas = new frmVentas();
            Ventas.Show();

        }
    }
}
