using System;

namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            //variables
            int tamañovector = 5;
            int[] vectornum = new int[tamañovector];
            int buscador;
            //pedimos el vector de 20 numeros enteros positivos
            Console.WriteLine("Dime 20 números enteros positivos");
            for (int i = 0; i < vectornum.Length; i++)
            {
                while (!(int.TryParse(Console.ReadLine(), out vectornum[i])) || vectornum[i] < 0)
                    Console.WriteLine("Tienes que introducir un número válido");
            }
            //pedimos el numero de referencia
            Console.WriteLine("Dime un numero de referencia");
            while (!(int.TryParse(Console.ReadLine(), out buscador)) || buscador < 0)
                Console.WriteLine("Tienes que introducir un número válido");
            Console.Clear();
            //creamos un vector nuevo y escribimos el resultado
            int[] vectornuevo = new int[tamañovector];
            Console.WriteLine("El vector original es: \n"); 
            for (int i = 0; i < vectornum.Length; i++)
            {
                if (vectornum[i] == buscador)
                    vectornuevo[i] = -1;
                else
                    vectornuevo[i] = 0;
                Console.Write("\t {0}", vectornum[i]);
            }
            Console.WriteLine("\nEl vector copia es: \n");
            for (int i = 0; i < vectornum.Length; i++)
            {
                Console.Write("\t {0}", vectornuevo[i]);
            }
        }
    }
}


