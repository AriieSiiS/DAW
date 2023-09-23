using System;

namespace Ejercicio
{
    class Ejercicio
    {
        static void Main(String[] args)
        {
            for (int i = 0; i < 10 ; i++)
            {
                Console.WriteLine("");
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(" {0} ", j+(i*10));
                }
            }
        }
    }
}


