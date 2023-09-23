using System;

namespace Ejercicio03
{
    class Multiplicación
    {
        static void Main(String[] args)
        {
            double numero1;
            double numero2;
            Console.Write("Introduce el primer número: ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduce el segundo número: ");
            numero2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("La multiplicación es: {0}", numero1 * numero2);
        }
    }
}
