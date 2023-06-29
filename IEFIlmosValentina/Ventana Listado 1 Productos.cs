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
    public partial class frmVentanaC : Form
    {
        public string[,] matrizProductos = new string[10, 10];
        int indiceinicial, indiceColumna;
        public frmVentanaC()
        {
            InitializeComponent();
        }

        private void frmVentanaC_Load(object sender, EventArgs e)
        {
            indiceColumna = 0;
            indiceinicial = 0;

            while (indiceinicial < matrizProductos.GetLength(0))
            {
                dgvCargadeProductos.Rows.Add(matrizProductos[indiceinicial, 0],
                    matrizProductos[indiceinicial, 1],
                    matrizProductos[indiceinicial, 2],
                    matrizProductos[indiceinicial, 3],
                    matrizProductos[indiceinicial, 4],
                    matrizProductos[indiceinicial, 5],
                    matrizProductos[indiceinicial, 6],
                    matrizProductos[indiceinicial, 7],
                    matrizProductos[indiceinicial, 8],
                    matrizProductos[indiceinicial, 9]);


                indiceinicial++;
            }
        }
    }
    
}
