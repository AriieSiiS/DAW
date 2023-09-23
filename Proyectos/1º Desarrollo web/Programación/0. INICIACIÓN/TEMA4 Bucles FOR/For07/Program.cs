
using System;

namespace Ejercicio
{
    class Ejercicio
    {
        static void Main(String[] args)
        {
            int num;
            int tabla;
            int multiplicacion = 1;
            Console.WriteLine("Dime un numero");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                tabla = multiplicacion++ * num;
                Console.WriteLine("\t{0}", tabla);
            }
        }
    }
}



