using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP03SIMULACION
{
    public partial class FormGraficoExponencial : Form
    {
        double[] numeros;
        private int cantIntervalos;
        private double lambda;

        public FormGraficoExponencial(double[] numeros , double lambda)
        {
            InitializeComponent();
            this.numeros = numeros;
            this.lambda = lambda;
        }

        private void FormGraficoExponencial_Load(object sender, EventArgs e)
        {

        }


        private double[,] calcularIntervalos()
        {
            double max = numeros[0];
            double min = numeros[0];
            int n = numeros.Length;
            int cantIntervalos = Convert.ToInt32(txtCantIntervalos.Text);

            for (int i = 1; i < n; i++)
            {
                if (numeros[i] > max) max = numeros[i];
                if (numeros[i] < min) min = numeros[i];
            }

            double diferencia = max - min;
            double ancho = diferencia / cantIntervalos;

            double[,] intervalos = new double[cantIntervalos, 2];

            for (int i = 0; i < cantIntervalos; i++)
            {
                intervalos[i, 0] = min + (i * ancho);
                intervalos[i, 1] = min + ((i + 1) * ancho);
            }

            return intervalos;

        }

        private double[] calcularFrecuenciaObservada(double[,] intervalos)
        {
            double[] frecuencias = new double[Convert.ToInt32(txtCantIntervalos.Text)];

            for (int i = 0; i < numeros.Length; i++)
            {
                for (int j = 0; j < Convert.ToInt32(txtCantIntervalos.Text); j++)
                {
                    if (numeros[i] >= intervalos[j, 0] && numeros[i] < intervalos[j, 1])
                    {
                        frecuencias[j] += 1;
                        break;
                    }
                }
            }
            return frecuencias;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            dgvExponencialF.Rows.Clear();
            //dgvChiCuadrado.Rows.Clear();
            //chrtDistribucion.Visible = true;

            double[,] intervalos = calcularIntervalos();
            double[] frecuenciaObservada = calcularFrecuenciaObservada(intervalos);


            for (int i = 0; i < frecuenciaObservada.Length; i++)
            {
                float marcaClase = (float)(intervalos[i, 0] + intervalos[i, 1]) / 2;
                float probabilidad = Math.Abs(calcularProbabilidad(marcaClase, intervalos[i, 0], intervalos[i, 1]));

                dgvExponencialF.Rows.Add(Math.Truncate(10000 * intervalos[i, 0]) / 10000, Math.Truncate(10000 * intervalos[i, 1]) / 10000, marcaClase, frecuenciaObservada[i], probabilidad, calcularFrecuenciaEsperada(probabilidad, numeros.Length));
            }
        }

        public float calcularProbabilidad(double mc, double desde, double hasta)
        {
            float probabilidad = (float)((lambda * Math.Exp(-lambda * mc)) * (hasta - desde));

            return probabilidad;
        }

        public float calcularFrecuenciaEsperada(float prob, int n)
        {
            return prob * n;
        }

    }
}
