using System;

namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            bool seguir = false;
            int[] num = new int[1];
            int contador = 0;
            Console.WriteLine("Dime numeros entre 1 y 9. Pulsa 0 para salir");
            while (seguir == false)
            {
                while (!(int.TryParse(Console.ReadLine(), out num[contador])) || num[contador] < 0 || num[contador] > 9)
                    Console.WriteLine("Tienes que introducir un número válido");
                if (num[contador] == 0)
                {
                    seguir = true;
                    Array.Sort(num);
                    Console.WriteLine("De menor a mayor");
                    for (int i = 0; i < num.Length; i++)
                    {
                        Console.WriteLine("\t" + num[i]);
                    }
                    Array.Reverse(num);
                    Console.WriteLine("De mayor a menor");
                    for (int i = 0; i < num.Length; i++)
                    {
                        Console.WriteLine("\t" + num[i]);
                    }
                }
                else
                {
                    contador++;
                    Array.Resize(ref num, contador+1);
                }
            }
        }
    }
}


