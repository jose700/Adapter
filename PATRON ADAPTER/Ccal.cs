﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronAdapter
{
    class Ccal: ITarget
    {

        //CREAMOS UNA FUNCION
        public int Sumar(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}
