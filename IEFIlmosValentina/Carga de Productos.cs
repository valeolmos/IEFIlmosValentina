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
    public partial class frmCargaDeProductos : Form
    {
        frmCargaDeProductos ventanaConsulta = new frmCargaDeProductos();
        readonly int indiceRegistro = 0;
        int indiceinicial;

        public frmCargaDeProductos()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmCargaDeProductos_Load(object sender, EventArgs e)
        {
            
        }

        private void cmdConsulta_Click(object sender, EventArgs e)
        {
          frmVentanaC frmVentana = new frmVentanaC();
            frmVentana.ShowDialog();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                if (txtNombre.Text != "")
                {
                    if (nudCantidad.Value >= 1)
                    {
                        if (dtpFecha.Value >= DateTime.Today)
                        {

                            MessageBox.Show("Los Productos Fueron Cargados correctamente", "Productos Cargados!!", MessageBoxButtons.OK, MessageBoxIcon.None);


                            ventanaConsulta.matrizProductos[indiceinicial, 0] = txtNombre.Text;
                            ventanaConsulta.matrizProductos[indiceinicial, 1] = txtID.Text;
                            ventanaConsulta.matrizProductos[indiceinicial, 2] = dtpFecha.Value.ToString();
                            ventanaConsulta.matrizProductos[indiceinicial, 3] = nudCantidad.Value.ToString();

                            indiceinicial++;

                            if (indiceinicial == ventanaConsulta.matrizProductos.GetLength(0))
                            {
                                cmdGuardar.Enabled = false;
                            }


                        }
                        else
                        {
                            MessageBox.Show("La Fecha tiene que ser hoy o posterior", "Determine una fecha valida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cantidad invalida", "Determine un valor cierto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Nombre inexistente", "NOMBRE INCORRECTO", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("ID inexistente", "ERROR EN EL ID", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
