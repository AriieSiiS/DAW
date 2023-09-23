using System;
using System.Globalization;

namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            //preguntamos el numero de productos
            int nproductos = 0;
            Console.WriteLine("Dime el número de productos que vas a comprar");
            while (!(Int32.TryParse(Console.ReadLine(),out nproductos)) || nproductos < 0)
                Console.WriteLine("Tienes que introducir un número válido");

            //establecemos el tamaño de los vectores y declaramos las variables
            string[] nombreproductov = new string[nproductos];
            decimal[] precioproductov = new decimal[nproductos];
            decimal[] precioproductovfinal = new decimal[nproductos];
            string nombreproducto;
            decimal precioproducto;
            int productosregalados;

            //preguntamos el nombre y precio de cada producto
            for (int i = 0; i < nproductos; i++)
            {
                nombreproducto = "";
                Console.WriteLine("Dime el nombre del producto");
                while (nombreproducto == "")
                {
                    nombreproducto = Console.ReadLine();
                    if (nombreproducto == "")
                        Console.WriteLine("El nombre no puede estar vacio");
                }
                nombreproductov[i] = nombreproducto;
                Console.WriteLine("Dime el precio del producto");
                while (!(decimal.TryParse(Console.ReadLine(), out precioproducto)) || precioproducto < 0)
                    Console.WriteLine("Tienes que introducir un número válido");
                precioproductov[i] = precioproducto;
                precioproductovfinal[i] = precioproducto;
            }

            //calculamos el numero de productos que hay que regalar
            productosregalados = nproductos / 3;
            //creamos un vector donde guardaremos las posiciones 
            int[] indicesregalados = new int[productosregalados];
            for (int i = 0; i < indicesregalados.Length; i++)
            {
                indicesregalados[i] = -1;
            }

            for (int i = 0; i < productosregalados; i++)
            {
                decimal minimo = decimal.MaxValue;
                int indiceminimo = -1;
                for (int j = 0; j < nproductos; j++)
                {
                    bool regalado = false;
                    for (int x = 0; x < indicesregalados.Length; x++)
                    {
                        if (indicesregalados[x] == j)
                            regalado = true;
                    }
                    if (precioproductov[j] < minimo && !regalado) 
                    {
                        minimo = precioproductov[j];
                        indiceminimo = j;
                    }
                }
                indicesregalados[i] = indiceminimo;
                precioproductovfinal[indiceminimo] = 0;
            }
            
            for (int i = 0; i < nproductos; i++)
            {
                Console.WriteLine("\nProducto: {0}", nombreproductov[i]);
                Console.WriteLine("Precio Inicial: {0}", precioproductov[i]);
                Console.WriteLine("Precio Final: {0}",precioproductovfinal[i]);
                Console.WriteLine("");
            }













        }
    }
}


