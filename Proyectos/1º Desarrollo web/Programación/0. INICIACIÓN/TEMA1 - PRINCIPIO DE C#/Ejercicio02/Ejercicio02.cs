using System;

namespace Ejercicio02
{
    class SumadeStrings
    {
        static void Main(String[] args)
        {
            string cadena1 = "";
            string cadena2 = "";
            Console.WriteLine("Escribe la primera cadena de texto");
            cadena1 = Console.ReadLine();
            Console.WriteLine("Escribe la segunda cadena de texto");
            cadena2 = Console.ReadLine();
            string final = String.Concat(cadena1, cadena2);
            Console.WriteLine("El string final es: {0}", final);
        }
    }
}