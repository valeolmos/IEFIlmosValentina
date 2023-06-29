using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEFIlmosValentina
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCargaDeVentas_Click(object sender, EventArgs e)
        {
            frmCargaDeVentas frmCargaDeVentas = new frmCargaDeVentas();
            frmCargaDeVentas.ShowDialog();
        }

        private void cmdCargaDeProducto_Click(object sender, EventArgs e)
        {
            frmCargaDeProductos frmCargaDeProductos = new frmCargaDeProductos();
            frmCargaDeProductos.ShowDialog();
        }

        private void cmdListados_Click(object sender, EventArgs e)
        {
            frmListados frmListados = new frmListados(); 
            frmListados.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
