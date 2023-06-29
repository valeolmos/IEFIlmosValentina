using IEFIlmosValentina.Properties;
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
    public partial class frmCargaDeVentas : Form
    {
        frmListadodeVentas ventanaConsultaVentas = new frmListadodeVentas();

        readonly int indiceConsultas = 0;
        int indiceFilaConsultas;

        public frmCargaDeVentas()
        {
            InitializeComponent();
        }

        private void frmCargaDeVentas_Load(object sender, EventArgs e)
        {
            if (txtIDV.Text != "")
            {
                if (txtProductoV.Text != "")
                {
                    if (nudCantidadV.Value >= 1)
                    {
                        if (dtpFechaV.Value >= DateTime.Today)
                        {
                            MessageBox.Show("Productos Cargados correctamente", "Producto Cargado!!", MessageBoxButtons.OK, MessageBoxIcon.None);


                            ventanaConsultaVentas.matrizVentas[indiceFilaConsultas, 0] = txtIDV.Text;
                            ventanaConsultaVentas.matrizVentas[indiceFilaConsultas, 1] = txtProductoV.Text;
                            ventanaConsultaVentas.matrizVentas[indiceFilaConsultas, 2] = nudCantidadV.Value.ToString();
                            ventanaConsultaVentas.matrizVentas[indiceFilaConsultas, 3] = dtpFechaV.Value.ToString();

                            indiceFilaConsultas++;

                            if (indiceFilaConsultas == ventanaConsultaVentas.matrizVentas.GetLength(0))
                            {
                                cmdGuardar.Enabled = false;
                            }


                        }
                        else
                        {
                            MessageBox.Show("La Fecha tiene que ser de hoy o posterior", "Determine una fecha valida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cantidad invalida", "Determine un valor cierto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Producto inexistente", "NOMBRE INCORRECTO", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("ID inexistente", "ERROR EN EL ID", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void cmdConsulta_Click(object sender, EventArgs e)
        {
            frmVentanaC frmVentanaC = new frmVentanaC();
            frmVentanaC.ShowDialog();
        }
    }
}
