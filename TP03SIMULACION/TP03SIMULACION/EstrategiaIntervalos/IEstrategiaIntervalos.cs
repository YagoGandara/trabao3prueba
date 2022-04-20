using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP03SIMULACION.EstrategiaIntervalos
{
    class IEstrategiaIntervalos
    {
        public virtual List<int> frecuenciaObservada(List<float> valoresAleatorios , float a , float b)
        {
            return null;
        }

        public virtual float[,] calcularIntervalos(float a , float b)
        {
            return null;
        }

        public virtual int cantInt()
        {
            return 0;
        }
    }
}
