using System;

namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            //variables
            int nProductos;
            

            //pedimos el numero de productos que determinará el tamaño del vector
            Console.WriteLine("Dime el número de productos que vas a comprar");
            while (!(Int32.TryParse(Console.ReadLine(), out nProductos)) || nProductos < 0)
                Console.WriteLine("Tienes que introducir un número válido");

            //pedimos el nombre y precio de los productos
            for (int i = 0; i < nProductos; i++)
            {
                Console.WriteLine("Dime el precio del producto");

                Console.WriteLine("Dime el nombre del producto");

            }
            



        }
    }
}

