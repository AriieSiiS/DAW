

using System;

namespace Ejercicio
{
    class Ejercicio
    {
        static void Main(String[] args)
        {
            int suma = 0;
            int pares = 0;
            int multiplos = 0;
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
                suma = suma + i;
                if (i % 2 == 0)
                {
                    pares = pares + i;
                }
                else if (i % 3 == 0)
                {
                    multiplos = multiplos + i;
                }

            }
            Console.WriteLine("La suma de esos números es {0}", suma);
            Console.WriteLine("La suma de los números pares es {0}", pares);
            Console.WriteLine("La suma de los multiplos de tres es {0}", multiplos);
        }
    
    }
}



