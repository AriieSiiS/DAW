
using System;

namespace Ejercicio
{
    class Ejercicio
    {
        static void Main(String[] args)
        {
            int num1;
            int suma = 0;
            Console.WriteLine("Dime cinco numeros");
            for (int i = 0; i < 5; i++)
            {
                num1 = Convert.ToInt32(Console.ReadLine());
                suma = suma + num1;
            }
            Console.WriteLine("La suma de esos números es {0}", suma);
        }
    }
}

