using System;
using System.Diagnostics;

namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            //variables
            string primeracadena;
            string comparación;
            bool resultado;

            //pedimos la primera cadena
            Console.WriteLine("Dime una frase");
            primeracadena = Console.ReadLine();

            //pedimos la cadena de comparación
            Console.WriteLine("Dime una segunda frase o palabra a ver si está en la primera");
            comparación = Console.ReadLine();

            //ponemos el resultado
            resultado = primeracadena.Contains(comparación);
            if (resultado == true)
                Console.WriteLine("\nEstá");
            else
                Console.WriteLine("\nNo está");



        }
    }
}

