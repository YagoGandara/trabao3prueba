using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP03SIMULACION.EstrategiaIntervalos
{
    class Estrategia8: IEstrategiaIntervalos
    {
        public override List<int> frecuenciaObservada(List<float> valoresAleatorios , float a , float b)
        {
            List<int> fo = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
            float d = (b - a) / 8;
            for (int i = 0; i < valoresAleatorios.Count; i++)
            {
                int posicion = (int)Math.Truncate((float)valoresAleatorios[i] / d);
                fo[posicion] = fo[posicion] + 1;
            }

            return fo;
        }

        public override float[,] calcularIntervalos(float numa , float numb)
        {
            float[,] intervalos = new float[8, 2];
            float r = numb - numa;
            float div = r / 8;
            
            float resto = div / 100000;
            for (int i = 0; i < 8; i++)
            {
                intervalos[i, 0] = (float)div * i;
                intervalos[i, 1] = (float)(div * i + resto);
            }
            return intervalos;
        }

        public override int cantInt()
        {
            return 8;
        }
    }
}
