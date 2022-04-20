using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TP03SIMULACION.EstrategiaIntervalos;

namespace TP03SIMULACION.DistrUniforme
{
    public partial class FormGraficoUniforme : Form
    {
        private DataGridView numeros;
        private IEstrategiaIntervalos estrategia;
        private int cantIntervalos;
        private double[] num;
        private double numA;
        private double numB;
        private int n;
        Series Series2 = new Series();
        Series Series3 = new Series();



        public FormGraficoUniforme(DataGridView numeros , double[] num, double numA, double numB )
        {

            InitializeComponent();
            this.numeros = numeros;
            this.numA = numA;
            this.numB = numB;
            this.num = num;
            
            

        }

        private void FormGraficoUniforme_Load(object sender, EventArgs e)
        {

        }

        private void cx8_CheckedChanged(object sender, EventArgs e)
        {

        }





        private void cx10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cx15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cx20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        { }

        public float calcularProbabilidad(double mc , double desde , double hasta)
        {
            float prob = (float)((hasta - desde) / (numB - numA));
            return (float)Math.Round(prob, 4);

        }
        


        public float calcularFrecuenciaEsperada(float prob, int n)
        {
            return prob * n;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

        }

        private void chrtUniforme_Click(object sender, EventArgs e)
        {

        }

        private void chrtChi_Click(object sender, EventArgs e)
        {

        }



        private  double[] frecuenciaObservadaCalculada(double [,] intervalos)
        {
            double[] frecuencia = new double[cantIntervalos];

            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < cantIntervalos; j++)
                {
                    if (num[i] >= intervalos[j, 0] && num[i] < intervalos[j,1])
                    {
                        frecuencia[j] += 1;
                        break;
                    }

                }

            }
            return frecuencia;

        }

        private  double[,] calcularIntervalos()
        {
            double max = num[0];
            double min = num[0];

            int n = num.Length;
            int cantIntervalos = Convert.ToInt32(txtCantIntervalos.Text);

            for(int i = 1; i < n; i++)
            {
                if (num[i] > max) max = num[i];
                if (num[i] < min) min = num[i];

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

        private void txtCantIntervalos_TextChanged(object sender, EventArgs e)
        {

        }

        private void dvgFrecuencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

/*/        public void generarGrafico(double[,] intervalos, double [] frecuencia)
        {
            chrtUniforme.Series["Series1"].Points.Clear();
            chrtUniforme.Series["Series2"].Points.Clear();
            chrtUniforme.Series["Series1"].LegendText = "Frecuencia Observada";
            chrtUniforme.Series["Series2"].LegendText = "Frecuencia Esperada";

            Dictionary<string, double> dic = new Dictionary<string, double>();
            Dictionary<string, float> dic2 = new Dictionary<string, float>();

            for (int i = 0; i < frecuencia.Length; i++)
            {
                float marcaClase = (float)(intervalos[i, 0] + intervalos[i, 1]) / 2;
                dic.Add(intervalos[i, 0] + " - " + intervalos[i, 1], frecuencia[i]);
                dic2.Add(intervalos[i, 0] + " - " + intervalos[i, 1], calcularFrecuenciaEsperada(calcularProbabilidad(marcaClase, intervalos[i, 0], intervalos[i, 1]), num.Length));
            }

            foreach (KeyValuePair<string, double> d in dic)
            {
                chrtUniforme.Series["Series1"].Points.AddXY(d.Key, d.Value);
            }

            foreach (KeyValuePair<string, float> d in dic2)
            {
                chrtUniforme.Series["Series2"].Points.AddXY(d.Key, d.Value);
            }

        }
/*/
        private void dgvFrecuencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Generar2_Click(object sender, EventArgs e)
        {
            dgvFrecuencia.Rows.Clear();
            dvgChi.Rows.Clear();


            double[,] intervalos = calcularIntervalos();
            double[] frecuenciaObservada = frecuenciaObservadaCalculada(intervalos);

            for (int i = 0; i < frecuenciaObservada.Length; i++)
            {
                float marcaClase = (float)(intervalos[i, 0] + intervalos[i, 1]) / 2;
                float probabilidad = Math.Abs(calcularProbabilidad(marcaClase, intervalos[i, 0], intervalos[i, 1]));

                dgvFrecuencia.Rows.Add(Math.Truncate(10000 * intervalos[i, 0]) / 10000, Math.Truncate(10000 * intervalos[i, 1]) / 10000, marcaClase, frecuenciaObservada[i], probabilidad, calcularFrecuenciaEsperada(probabilidad, num.Length));

            }
            //generarGrafico(intervalos, frecuenciaObservada);
        }
    }
    
}
