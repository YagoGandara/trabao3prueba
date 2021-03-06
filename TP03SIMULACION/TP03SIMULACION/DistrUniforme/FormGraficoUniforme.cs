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
using MathNet.Numerics.Distributions;
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
        Series Series1 = new Series();
        Series Series2 = new Series();



        public FormGraficoUniforme(DataGridView numeros, double[] num, double numA, double numB)
        {

            InitializeComponent();
            this.numeros = numeros;
            this.numA = numA;
            this.numB = numB;
            this.num = num;
            chrtUniforme.Series.Add(Series1);
            chrtChi.Series.Add(Series2);



        }

        private void FormGraficoUniforme_Load(object sender, EventArgs e)
        {

        }



        public float calcularProbabilidad(double mc, double desde, double hasta)
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



        private double[] frecuenciaObservadaCalculada(double[,] intervalos)
        {
            double[] frecuencia = new double[Convert.ToInt32(txtCantIntervalos.Text)];

            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < Convert.ToInt32(txtCantIntervalos.Text); j++)
                {
                    if (num[i] >= intervalos[j, 0] && num[i] < intervalos[j, 1])
                    {
                        frecuencia[j] += 1;
                        break;
                    }

                }

            }
            return frecuencia;

        }

        private double[,] calcularIntervalos()
        {
            double max = num[0];
            double min = num[0];

            int n = num.Length;
            int cantIntervalos = Convert.ToInt32(txtCantIntervalos.Text);

            for (int i = 1; i < n; i++)
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

        public void generarGrafico(double[,] intervalos, double[] frecuencia)
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

        private void dgvFrecuencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Generar2_Click(object sender, EventArgs e)
        {
            dgvFrecuencia.Rows.Clear();
            dgvChi.Rows.Clear();


            double[,] intervalos = calcularIntervalos();
            double[] frecuenciaObservada = frecuenciaObservadaCalculada(intervalos);

            for (int i = 0; i < frecuenciaObservada.Length; i++)
            {
                float marcaClase = (float)(intervalos[i, 0] + intervalos[i, 1]) / 2;
                float probabilidad = Math.Abs(calcularProbabilidad(marcaClase, intervalos[i, 0], intervalos[i, 1]));

                dgvFrecuencia.Rows.Add(Math.Truncate(10000 * intervalos[i, 0]) / 10000, Math.Truncate(10000 * intervalos[i, 1]) / 10000, marcaClase, frecuenciaObservada[i], probabilidad, calcularFrecuenciaEsperada(probabilidad, num.Length));

            }
            generarGrafico(intervalos, frecuenciaObservada);
            String[,] intervalosChi = chiCuadrado();
           // generarGraficoChi(intervalosChi);
            // lblCalculado.Text = getAcumulado().ToString();
            //lblCalculado.Visible = true;
            //lblTabla.Text = tablaChiCuadrado().ToString();
            //conclusion();
        }

        public string[,] chiCuadrado()
        {
            float cAcum = 0;
            String[,] intervalos = new String[dgvFrecuencia.Rows.Count, 4];
            int j = 0;
            for (int i = 0; i < dgvFrecuencia.Rows.Count; i++)
            {
                string desde = dgvFrecuencia.Rows[i].Cells["desde"].Value.ToString();
                string hasta = dgvFrecuencia.Rows[i].Cells["hasta"].Value.ToString();
                float sumaEsperada = (float)Convert.ToDouble(dgvFrecuencia.Rows[i].Cells["frecuenciaEsperada"].Value);
                int sumaObservada = Convert.ToInt32(dgvFrecuencia.Rows[i].Cells["frecuenciaObservada"].Value);

                while (sumaEsperada < 5 || verificarProximos(i))
                {
                    if (i == dgvFrecuencia.Rows.Count - 1)
                        break;
                    i++;
                    sumaEsperada += (float)Convert.ToDouble(dgvFrecuencia.Rows[i].Cells["frecuenciaEsperada"].Value);
                    sumaObservada += Convert.ToInt32(dgvFrecuencia.Rows[i].Cells["frecuenciaObservada"].Value);
                    hasta = dgvFrecuencia.Rows[i].Cells["hasta"].Value.ToString();

                }
                float c = (float)Math.Pow(((float)sumaEsperada - (float)sumaObservada), 2) / sumaEsperada;
                cAcum += c;
                dgvChi.Rows.Add(desde, hasta, sumaObservada, sumaEsperada, Math.Truncate(10000 * c) / 10000, Math.Truncate(10000 * cAcum) / 10000);
                intervalos[j, 0] = desde;
                intervalos[j, 1] = hasta;
                intervalos[j, 2] = sumaObservada.ToString();
                intervalos[j, 3] = sumaEsperada.ToString();
                j++;
            }

            return intervalos;

        }

        public bool verificarProximos(int i)
        {
            int suma = 0;
            for (int j = i + 1; j < dgvFrecuencia.Rows.Count; j++)
            {
                suma += Convert.ToInt32(dgvFrecuencia.Rows[j].Cells["frecuenciaEsperada"].Value);
                if (suma >= 5)
                    break;
            }
            return suma < 5;
        }





        public float tablaChiCuadrado()
        {
            return (float)Math.Round(ChiSquared.InvCDF(dgvChi.Rows.Count - 1, 0.95), 4);
        }

        public float getAcumulado()
        {
            return (float)Convert.ToDouble(dgvChi.Rows[dgvChi.Rows.Count - 1].Cells["Css"].Value);
        }












        public void generarGraficoChi(string[,] intervalos)
        {
            chrtChi.Series["Series1"].Points.Clear();
            chrtChi.Series["Series2"].Points.Clear();
            chrtChi.Series["Series1"].LegendText = "Frecuencia observada";
            chrtChi.Series["Series2"].LegendText = "Frecuencia esperada";

            Dictionary<string, double> dic3 = new Dictionary<string, double>();
            Dictionary<string, float> dic4 = new Dictionary<string, float>();

            int i = 0;
            while (i < intervalos.GetLength(0) && !(intervalos[i, 0] == null))
            {
                dic3.Add(intervalos[i, 0] + " - " + intervalos[i, 1], Convert.ToInt32(intervalos[i, 2]));
                dic4.Add(intervalos[i, 0] + " - " + intervalos[i, 1], (float)Convert.ToDouble(intervalos[i, 3]));
                i++;
            }

            foreach (KeyValuePair<string, double> d in dic3)
            {
                chrtChi.Series["Series1"].Points.AddXY(d.Key, d.Value);
            }

            foreach (KeyValuePair<string, float> d in dic4)
            {
                chrtChi.Series["Series2"].Points.AddXY(d.Key, d.Value);
            }

        }




        


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
