﻿using System;
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


namespace TP03SIMULACION
{
    public partial class FormGraficoExponencial : Form
    {
        double[] numeros;
        Series Series2 = new Series();
        private double lambda;

        public FormGraficoExponencial(double[] numeros , double lambda)
        {
            InitializeComponent();
            this.numeros = numeros;
            this.lambda = lambda;
            chDistribucion.Series.Add(Series2);

        }

        private void FormGraficoExponencial_Load(object sender, EventArgs e)
        {

        }




        private void btnGenerar_Click(object sender, EventArgs e)
        {
            dgvExponencialF.Rows.Clear();
            dgvChi.Rows.Clear();

            double[,] intervalos = calcularIntervalos();
            double[] frecuenciaObservada = calcularFrecuenciaObservada(intervalos);


            for (int i = 0; i < frecuenciaObservada.Length; i++)
            {
                float marcaClase = (float)(intervalos[i, 0] + intervalos[i, 1]) / 2;
                float probabilidad = Math.Abs(calcularProbabilidad(marcaClase, intervalos[i, 0], intervalos[i, 1]));

                dgvExponencialF.Rows.Add(Math.Truncate(10000 * intervalos[i, 0]) / 10000, Math.Truncate(10000 * intervalos[i, 1]) / 10000, marcaClase, frecuenciaObservada[i], probabilidad, calcularFrecuenciaEsperada(probabilidad, numeros.Length));
            }
            generarGrafico(intervalos , frecuenciaObservada);
            string[,] intervalosChi = chiCuadrado();
            lblCalculadoRes.Text = getAcumulado().ToString();
            lblCalculadoRes.Visible = true;
            lblTablaRes.Text = tablaChiCuadrado().ToString();
            lblTablaRes.Visible = true;
            conclusion();




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





        public float calcularProbabilidad(double mc, double desde, double hasta)
        {
            float probabilidad = (float)((lambda * Math.Exp(-lambda * mc)) * (hasta - desde));

            return probabilidad;
        }

        public float calcularFrecuenciaEsperada(float prob, int n)
        {
            return prob * n;
        }


        public void generarGrafico(double[,] intervalos, double[] frecuencia)
        {
            chDistribucion.Series["Series1"].Points.Clear();
            chDistribucion.Series["Series2"].Points.Clear();
            chDistribucion.Series["Series1"].LegendText = "Frecuencia observada";
            chDistribucion.Series["Series2"].LegendText = "Frecuencia esperada";

            Dictionary<string, double> dic = new Dictionary<string, double>();
            Dictionary<string, float> dic2 = new Dictionary<string, float>();

            for (int i = 0; i < frecuencia.Length; i++)
            {
                float marcaClase = (float)(intervalos[i, 0] + intervalos[i, 1]) / 2;
                dic.Add(intervalos[i, 0] + " - " + intervalos[i, 1], frecuencia[i]);
                dic2.Add(intervalos[i, 0] + " - " + intervalos[i, 1], calcularFrecuenciaEsperada(calcularProbabilidad(marcaClase, intervalos[i, 0], intervalos[i, 1]), numeros.Length));
            }

            foreach (KeyValuePair<string, double> d in dic)
            {
                chDistribucion.Series["Series1"].Points.AddXY(d.Key, d.Value);
            }

            foreach (KeyValuePair<string, float> d in dic2)
            {
                chDistribucion.Series["Series2"].Points.AddXY(d.Key, d.Value);
            }

        }

        public string[,] chiCuadrado()
        {
            float cAcum = 0;
            String[,] intervalos = new String[dgvExponencialF.Rows.Count, 4];
            int j = 0;
            for (int i = 0; i < dgvExponencialF.Rows.Count; i++)
            {
                string desde = dgvExponencialF.Rows[i].Cells["desde"].Value.ToString();
                string hasta = dgvExponencialF.Rows[i].Cells["hasta"].Value.ToString();
                float sumaEsperada = (float)Convert.ToDouble(dgvExponencialF.Rows[i].Cells["frecuenciaEsperada"].Value);
                int sumaObservada = Convert.ToInt32(dgvExponencialF.Rows[i].Cells["frecuenciaObservada"].Value);

                while (sumaEsperada < 5 || verificarProximos(i))
                {
                    if (i == dgvExponencialF.Rows.Count - 1)
                        break;
                    i++;
                    sumaEsperada += (float)Convert.ToDouble(dgvExponencialF.Rows[i].Cells["frecuenciaEsperada"].Value);
                    sumaObservada += Convert.ToInt32(dgvExponencialF.Rows[i].Cells["frecuenciaObservada"].Value);
                    hasta = dgvExponencialF.Rows[i].Cells["hasta"].Value.ToString();

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
            for (int j = i + 1; j < dgvExponencialF.Rows.Count; j++)
            {
                suma += Convert.ToInt32(dgvExponencialF.Rows[j].Cells["frecuenciaEsperada"].Value);
                if (suma >= 5)
                    break;
            }
            return suma < 5;
        }

        public float getAcumulado()
        {
            return (float)Convert.ToDouble(dgvChi.Rows[dgvChi.Rows.Count - 1].Cells["cAcumulativo"].Value);
        }


        public float tablaChiCuadrado()
        {
            int gradosLibertad = dgvChi.Rows.Count - 1 - 2;
            if (gradosLibertad < 1) gradosLibertad = 1;
            return (float)Math.Round(ChiSquared.InvCDF(gradosLibertad, 0.95), 4);
        }

        

        public void conclusion()
        {
            string txt;
            if (getAcumulado() < tablaChiCuadrado())
                txt = "Conclusión: La hipótesis se acepta, los datos se aproximan a una distribución exponencial negativa.";
            else
                txt = "Conclusión: La hipótesis no se acepta, los datos no se aproximan a una distribución exponencial negativa.";

            lblConclusion.Text = txt;
            lblConclusion.Visible = true;
        }



    }
}
