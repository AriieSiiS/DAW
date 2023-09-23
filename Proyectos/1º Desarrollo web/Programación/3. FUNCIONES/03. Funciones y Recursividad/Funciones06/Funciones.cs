using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class Funciones
    {
        public static int MostrarNum(int num)
        {
            if (num == 100)
                return (100);
            else
                Console.WriteLine(num);
                return (MostrarNum(num + 1));
        }
    }
}
