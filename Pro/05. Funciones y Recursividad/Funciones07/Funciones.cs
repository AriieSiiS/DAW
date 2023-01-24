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
            if (contador - 1 == 1)
                return (true);
            else
            {
                if (num % (contador-1) == 0)
                {
                    
                    return (false);
                }
                return (NumPrimo(num, (contador-1)));
            }


        }
    }
}
