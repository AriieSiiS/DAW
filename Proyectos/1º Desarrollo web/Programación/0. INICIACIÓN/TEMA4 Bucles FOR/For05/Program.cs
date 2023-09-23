
using System;

namespace Ejercicio
{
    class Ejercicio
    {
        static void Main(String[] args)
        {
            
            int suma = 0;
            Console.WriteLine("Vamos a sumar los numeros del 1 al 100");
            for (int i = 1; i <= 100; i++)
            {
                
                suma = suma + i;
            }
            Console.WriteLine("La suma de esos números es {0}", suma);
        }
    }
}



