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
    public partial class FormNMuller : Form
    {
        private double desvEstandar;
        private double media;
        private double[] numeros;
        private Random random = new Random();
        private bool bandera;


        public FormNMuller( double desvEstandar , double media , bool bandera)
        {


            InitializeComponent();
            this.desvEstandar = desvEstandar;
            this.media = media;
            this.bandera = bandera;


        }

        private void btnGenerarAleatorios_Click(object sender, EventArgs e)
        {

            dgvNormalMullerAleatorio.Rows.Clear();
            numeros = new double[Convert.ToInt32(txtN.Text)];
            for (int i = 0; i < Convert.ToInt32(txtN.Text); i++)
            {
                numeros[i] = Math.Round(getRandomVar(), 4);
                dgvNormalMullerAleatorio.Rows.Add(i, Math.Round(getRandomVar(), 4));
            }
        }

        public double getRandomVar()
        {
            if (bandera)
            {
                double[] vector = new double[2];
                double RND1 = random.NextDouble();
                double RND2 = random.NextDouble();
                double x = Sqrt(-2 * Log(RND1)) * Cos(2 * PI * RND2);
                double y = Sqrt(-2 * Log(RND1)) * Sin(2 * PI * RND2);
                vector[0] = x * desvEstandar + media;
                vector[1] = y * desvEstandar + media;
                return vector[0];
            }
            else
            {
                    double ac = 0.0;
                    for (int i = 0; i < 12; i++)
                    {
                        ac += random.NextDouble();
                    }
                    ac -= 6.0;

                    double x = ac * desvEstandar + media;
                    return x;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            FormGraficoJiCuadradoNORMALMULLER formGraficoJi = new FormGraficoJiCuadradoNORMALMULLER(numeros , desvEstandar , media , bandera);
            formGraficoJi.Show();
        }

        private void FormNMuller_Load(object sender, EventArgs e)
        {

        }
    }
}
