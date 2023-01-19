using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class Funciones
    {
        public static bool Bisiesto(int año)
        {
            bool Bisiesto = false;
            if (año % 4 == 0 && año % 100 != 0)
                Bisiesto = true;
            else if (año % 400 == 0)
                Bisiesto = true;
            return Bisiesto;
        }
    }
}
