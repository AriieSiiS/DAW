using System;

namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            var (posicion, contador) = Funciones.CantidadVeces();
            Console.WriteLine("La letra introducida aparece {0} veces en las siguientes posiciones \n", contador);
           
            for (int i = 0; i < contador; i++)
            {
                Console.Write("\t {0}", posicion[i]);
            }
        }
    }
}

