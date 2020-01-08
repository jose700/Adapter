using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //este es el cliente
            int resul = 0;

            //usamos la interfaz  que el cliente conoce como una ITarget
            ITarget cal = new Ccal();

            resul = cal.Sumar(6, 7);

            //imprimimos el resultado

            Console.WriteLine("el resultado es: {0}",resul);
           
           

            //Se hace uso del adapador
            cal = new ClaseAdaptador123();

            //usamos el adaptadr para realizar la operacion
            resul = cal.Sumar(9, 10);
            Console.WriteLine("el resultado es: {0}", resul);
            Console.ReadKey();
            Console.ReadKey();

        }
    }
}
