using System;

namespace Ejercicio
{
    class Ejercicio
    {
        static void Main(String[] args)
        {
            int[] lista = new int[10];
            int num1 = 0;
            int num2 = 0;
            Console.WriteLine("Escribe diez numeros diferentes entre si");
            for (int i = 0; i < lista.Length; i++)
            {
                bool valido = false;
                do
                {
                    valido = false;
                    Console.WriteLine("Escribe el siguiente numero");
                    while (!(Int32.TryParse(Console.ReadLine(), out num1)))
                        Console.WriteLine("El número introducido no es válido");
                    for (int j = 0; j < i; j++)
                    {
                        if (lista[j] == num1)
                        {
                            Console.WriteLine("El numero está repetido");
                            valido = true;
                        }
                    }
                } while (valido);
                lista[i] = num1;
            }
            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine("\n{0}",lista[i]);
            }
        }
    }
}
