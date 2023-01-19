using System;

namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            //programa para buscar la posición de menor valor en un array
            int[] vector = { 3, 2, 8, 9, -13, -212 };
            int posicion = Funciones.PosicionMenorValor(vector);
            Console.WriteLine("La posición del número de menor valor es: {0}", posicion);
        }
    }
}


