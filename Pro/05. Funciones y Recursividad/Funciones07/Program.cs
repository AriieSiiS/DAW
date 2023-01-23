using System;

namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            int num;
            Console.WriteLine("Dime un número entero");
            while (!(Int32.TryParse(Console.ReadLine(), out num)))
                Console.WriteLine("El número introducido no es correcto");
            Console.WriteLine(Funciones.NumPrimo(num));
        }
    }
}


