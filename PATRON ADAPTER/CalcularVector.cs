using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronAdapter
{
    //creamos una nueva clase llmada calcular vector
    class CalcularVector

    {
        public double Suma(int[] Operacion)
        {
            //creamos dos variables de control para el vector

            int i = 0;
            double r = 0;
            for (i = 0; i < Operacion.Length; i++)
                r += Operacion[i];
            return r;

        }
    }
}
