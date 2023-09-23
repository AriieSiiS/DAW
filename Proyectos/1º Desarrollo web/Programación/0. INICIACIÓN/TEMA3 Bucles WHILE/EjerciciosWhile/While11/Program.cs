using System;
using System.Net.Http.Headers;

namespace Ejercicio
{
    class Ejercicio
    {
        static void Main(String[] args)
        {
            int num1;
            int media = 0;
            int contadormedia = 0;
            do
            {
                Console.WriteLine("Introduce todos los números que quieras y 0 para salir");
                while (!int.TryParse(Console.ReadLine(), out num1))
                    Console.WriteLine("El número introducido no es correcto");
                if (!(num1 == 0))
                {
                    media += num1;
                    contadormedia++;
                }
            }
            while (!(num1 == 0));
            Console.WriteLine("La media es {0}", media/contadormedia);
        }
    }
}

