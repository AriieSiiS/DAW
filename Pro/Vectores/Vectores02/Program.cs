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
            Console.WriteLine("Escribe diez numeros");
            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine("Escribe el siguiente numero");
                while (!(Int32.TryParse(Console.ReadLine(), out num1)))
                    Console.WriteLine("El número introducido no es válido");
                lista[i] = num1;
            }
            Console.WriteLine("Ahora dime otro numero a ver si está dentro de los 10 anteriores");
            while (!(Int32.TryParse(Console.ReadLine(), out num2)))
                Console.WriteLine("El número introducido no es válido");

            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i] == num2)
                    Console.WriteLine("El {0} está en la posición {1}", num2, i);
            }
        }
    }
}

