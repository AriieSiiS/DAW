using System;
using System.Collections.Immutable;

namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            //preguntamos el número de productos que quiere comprar
            int numeroproductos;
            Console.WriteLine("Dime el número de productos que quieres comprar");
            while (!(Int32.TryParse(Console.ReadLine(), out numeroproductos)) || numeroproductos < 0)
                Console.WriteLine("Tienes que introducir un número válido");

            //declaramos e inicializamos las variables
            string[] nombreproducto = new string[numeroproductos];
            decimal[] precioproducto = new decimal[numeroproductos];
            decimal[] preciofinal = new decimal[numeroproductos];

            //pedimos el nombre y precio de cada producto
            for (int i = 0; i < numeroproductos; i++)
            {
                Console.WriteLine("Dime el nombre del producto");
                while (nombreproducto[i] == null)
                {
                    nombreproducto[i] = Console.ReadLine();
                    if (nombreproducto[i] == null)
                        Console.WriteLine("El nombre no puede estar vacio");
                }
                Console.WriteLine("Dime el precio del producto");
                while (!(decimal.TryParse(Console.ReadLine(), out precioproducto[i])) || precioproducto[i] < 0)
                    Console.WriteLine("Tienes que introducir un número válido");
                preciofinal[i] = precioproducto[i];
            }

            //calculamos el numero de productos a regalar 
            int productosregalados = numeroproductos / 3;
            Array.Sort(preciofinal);
            for (int i = 0; i < productosregalados; i++)
            {
                for (int j = 0; j < numeroproductos; j++)
                {
                    if (preciofinal[i] == precioproducto[j])
                    {
                        preciofinal[j] = 0;
                    }
                }
            }

            //escribimos el resultado 
            for (int i = 0; i < numeroproductos; i++)
            {
                Console.WriteLine("\nProducto: {0}", nombreproducto[i]);
                Console.WriteLine("Precio Inicial: {0}", precioproducto[i]);
                if (preciofinal[i] == 0)
                    Console.WriteLine("Precio Final: {0}", preciofinal[i]);
                else
                    Console.WriteLine("Precio Final: {0}", precioproducto[i]);
                Console.WriteLine("");
            }
        }
    }
}


