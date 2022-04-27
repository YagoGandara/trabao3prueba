using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;


namespace TP03SIMULACION
{
    public partial class FormExponencial : Form
    {
        private double lambda;
        private double media;
        double[] numeros;
        Random random = new Random();


        public FormExponencial( double lambda , double media  )
        {
            
            this.lambda = lambda;
            this.media = media;
            InitializeComponent();
        }



        private void txtGenerar_Click(object sender, EventArgs e)
        {
            dgvExpo.Rows.Clear();
            numeros = new double[Convert.ToInt32(txtN.Text)];


            for (int i = 0; i < Convert.ToInt32(txtN.Text); i++)
            {
                numeros[i] = Math.Round(getRandomVar(), 4);
                dgvExpo.Rows.Add(i, Math.Round(getRandomVar(), 4));
            }
        }

        private void FormExponencial_Load(object sender, EventArgs e)
        {

        }

        public double getRandomVar()
        {

            double x1 = -(1 / lambda) * Log(1.0 - random.NextDouble());
            return x1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGraficoExponencial graficoExponencial = new FormGraficoExponencial(numeros , lambda);
            graficoExponencial.Show();
        }
    }
}
