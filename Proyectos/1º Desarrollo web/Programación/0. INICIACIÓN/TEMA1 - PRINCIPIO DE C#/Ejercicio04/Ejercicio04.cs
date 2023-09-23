using System;

namespace Ejercicio04
{
    class Intercambiarvalores
    {
        static void Main(String[] args)
        {
            int A;
            int B;
            int C;
            Console.WriteLine("Dime un número");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dime otro número");
            B = Convert.ToInt32(Console.ReadLine());
            C = A;
            A = B;
            B = C;
            Console.WriteLine("Los valores intercambiados serian " + A + " y " + B);
        }
    }
}

