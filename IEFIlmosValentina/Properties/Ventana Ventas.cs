using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEFIlmosValentina.Properties
{
    public partial class frmListadodeVentas : Form
    {
        public string[,] matrizVentas = new string[10, 10];
        int indiceFila, indiceColumna;

        public frmListadodeVentas()
        {
            InitializeComponent();
        }

        private void frmListadodeVentas_Load(object sender, EventArgs e)
        {
            indiceColumna = 0;
            indiceFila = 0;

            while (indiceFila < matrizVentas.GetLength(0))
            {
                dgvCargadeVentas.Rows.Add(matrizVentas[indiceFila, 0],
                    matrizVentas[indiceFila, 1],
                    matrizVentas[indiceFila, 2],
                    matrizVentas[indiceFila, 3],
                    matrizVentas[indiceFila, 4],
                    matrizVentas[indiceFila, 5],
                    matrizVentas[indiceFila, 6],
                    matrizVentas[indiceFila, 7],
                    matrizVentas[indiceFila, 8],
                    matrizVentas[indiceFila, 9]);


                indiceFila++;

            }
        }
    }
}
