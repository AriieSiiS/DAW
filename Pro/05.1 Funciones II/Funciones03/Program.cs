using System;

namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            int tamaño = 10;
            int[] Aleatorio = Funciones.ArrayAleatorio(tamaño);
            for (int i = 0; i < Aleatorio.Length; i++)
            {
                Console.WriteLine("\t {0}", Aleatorio[i]);
            }
        }
    }
}


