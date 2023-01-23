using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class Funciones
    {
        public static bool NumPrimo(int num, int contador)
        {
            bool Primo = true;
            if (num == 1)
                return (1);
            else
            {
                if (num % contador - 1 == 0)
                    return (0);
                return (NumPrimo(num-1));
            }


        }
    }
}
