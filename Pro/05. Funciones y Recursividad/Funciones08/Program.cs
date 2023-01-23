using System;

namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Dime una frase");
            string frase = Console.ReadLine();
            Console.WriteLine("Dime una letra");
            char letra;
            while (!(Char.TryParse(Console.ReadLine(), out letra)))
                Console.WriteLine("La letra introducida no es válida");
            Console.WriteLine(Funciones.ContadorLetra(frase,letra);

            
        }
    }
}
