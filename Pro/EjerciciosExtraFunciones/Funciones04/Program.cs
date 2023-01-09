using System;

namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            //variables y pedimos la frase que dividiremos
            string frase;
            Console.WriteLine("Dime una frase");
            frase = Console.ReadLine();

            //dividimos la frase y la escribimos separando la palabras y poniendo el tamaño
            string[] partes = frase.Split(' ');
            for (int i = 0; i < partes.Length; i++)
            {
                Console.WriteLine(partes[i]);
                Console.WriteLine(partes[i].Length);
            }
        }
    }
}


