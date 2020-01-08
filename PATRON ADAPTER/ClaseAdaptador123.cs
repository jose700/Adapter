using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronAdapter
{

    //esta es la nueva clase llamada ClaseAdaptador la cual ya es conocida por el cliente

    //    la ClaseAdaptador comunica al cliente con la clase adaptada
    class ClaseAdaptador123 : ITarget
    {
        CalcularVector adaptador = new CalcularVector();

        //aqui hacemos la adaptacion de la operacion

        public int Sumar(int n1, int n2)
        {
            double r = 0;

            //creamos el vector que necesita ser adaptado a la clase

            //    adaptamos los datos que se envian a la clase

            int[] Operando = { n1, n2 };

            //Se realiza la operacion adaptada

            r = adaptador.Suma(Operando);

            //adaptamos el resultado

            return (int)r;
        }
    }
}
