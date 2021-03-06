using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP03SIMULACION.DistrUniforme;

namespace TP03SIMULACION
{
    public partial class Form1 : Form
    {
        private bool bandera;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUniformess_Click(object sender, EventArgs e)
        {
            FormUniforme g = new FormUniforme(Convert.ToDouble(txtA.Text), Convert.ToDouble(txtB.Text));
            g.Show();
        }

        private void txtSiguienteExpo_Click(object sender, EventArgs e)
        {
            double lambda = Convert.ToDouble(txtLambda.Text);
            double media = Convert.ToDouble(txtMedia.Text);


            FormExponencial a = new FormExponencial( lambda , media );
            a.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cxExponencial_CheckedChanged(object sender, EventArgs e)
        {
            txtLambda.Enabled = txtMedia.Enabled = true;
            txtA.Enabled = txtB.Enabled = txtDesvEstandar.Enabled = txtMediaMuller.Enabled = false;
            btnSiguienteExpo.Enabled = true;
            btnSiguienteNormalMuller.Enabled = false;
            btnUniformess.Enabled = false;

        }

        private void cxDistribuUnifor_CheckedChanged(object sender, EventArgs e)
        {
            txtLambda.Enabled = txtMedia.Enabled = false;
            txtA.Enabled = txtB.Enabled = true;
            txtDesvEstandar.Enabled = txtMediaMuller.Enabled = false;
            btnUniformess.Enabled = true;
            btnSiguienteExpo.Enabled = false;


        }

        private void cxNormalMuller_CheckedChanged(object sender, EventArgs e)
        {
            txtDesvEstandar.Enabled = txtMediaMuller.Enabled = true;
            txtA.Enabled = txtLambda.Enabled = txtB.Enabled = txtMedia.Enabled = false;
            btnUniformess.Enabled = false;
            btnSiguienteExpo.Enabled = false;
            bandera = true;
            btnSiguienteNormalMuller.Enabled = true;


        }

        private void btnSiguienteNormalMuller_Click(object sender, EventArgs e)
        {
            FormNMuller formNNMuller = new FormNMuller(Convert.ToDouble(txtDesvEstandar.Text), Convert.ToDouble(txtMediaMuller.Text) , bandera);
            formNNMuller.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtDesvEstandar.Enabled = txtMediaMuller.Enabled = true;
            txtA.Enabled = txtLambda.Enabled = txtB.Enabled = txtMedia.Enabled = false;
            btnUniformess.Enabled = false;
            btnSiguienteExpo.Enabled = false;
            bandera = false;
            btnSiguienteNormalMuller.Enabled = true;


        }
    }
}
