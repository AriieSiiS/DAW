using System;
using System.Numerics;

namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            //programa para buscar el valor mas pequeño en un array
            int[] vector = { 3, 2, 8, 9, -13, 12 };
            Funciones.MenorValor(vector);
            Console.WriteLine("El valor menor del vector es: {0}",vector[0]);
            
        }
    }
}


