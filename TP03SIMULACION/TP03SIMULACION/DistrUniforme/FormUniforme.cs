using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP03SIMULACION.DistrUniforme
{
    public partial class FormUniforme : Form
    {
        private double numeroA;
        private double numeroB;
        double[] numeros;
        public FormUniforme(double A, double B)
        {
            this.numeroA = A;
            this.numeroB = B;
            InitializeComponent();
        }

        private void FormUniforme_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerarUniforms_Click(object sender, EventArgs e)
        {
            dgvUniforme.Rows.Clear();
            Random random = new Random();
            //int n;
            //n = Convert.ToInt32(txtN.Text);
            numeros = new double[Convert.ToInt32(txtN.Text)];

            for (int i = 0; i < Convert.ToInt32(txtN.Text); i++)
            {
                double RND;
                RND = Math.Round(random.NextDouble(), 4);
                numeros[i] = GenerarNuevoX(RND);
                dgvUniforme.Rows.Add(i, RND, GenerarNuevoX(RND));

            }
        }

        private double GenerarNuevoX(double z)
        {

            double X = numeroA + z * (numeroB - numeroA);
            return X;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGraficoUniforme g = new FormGraficoUniforme(dgvUniforme , numeros, numeroA, numeroB);
            g.Show();
        }

        private void dgvUniforme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
