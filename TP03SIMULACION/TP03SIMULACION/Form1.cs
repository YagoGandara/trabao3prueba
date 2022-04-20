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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUniformess_Click(object sender, EventArgs e)
        {
            FormUniforme g = new FormUniforme(Convert.ToDouble(txtA.Text), Convert.ToDouble(txtB.Text));
            g.Show();
        }
    }
}
