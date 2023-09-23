using System;

namespace Ejercicio01
{
    class SumadeNumeros
    {
        static void Main(String[] args)
        {
            int numero1;
            int numero2;
            Console.Write("Introduce el primer número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La suma es: {0}", numero1 + numero2);
        }
    }
}

