using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class Funciones
    {
        public static int NCifras(int num)
        {
            string longitud = Convert.ToString(num);
            int tamaño = longitud.Length;
            return tamaño;
        }
    }
}
