using System;

namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            int[] lista = new int[15];
            int[] segundo = new int[15];
            int sumavectorfinal = 0;
            int restavectorfinal = 0;
            int num1 = 0;
            int referencia = 0;

            //vector inicial
            Console.WriteLine("Dime 15 números");
            for (int i = 0; i < lista.Length; i++)
            {
                while (!(Int32.TryParse(Console.ReadLine(), out num1)) || (num1 < -10) || (num1 > 10))
                    Console.WriteLine("El número introducido no es válido");
                lista[i] = num1;
                
            }
            //valor de referencia
            Console.WriteLine("Dime un numero de referencia");
            while (!(Int32.TryParse(Console.ReadLine(), out referencia)) || (referencia < -10) || (referencia > 10))
                Console.WriteLine("El número introducido no es válido");

            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i] < referencia)
                {
                    segundo[i] = lista[i];
                   sumavectorfinal += lista[i];
                }
                else
                    restavectorfinal += lista[i];
            }

            Console.WriteLine("La suma del vector final es {0}",sumavectorfinal);
            Console.WriteLine("La suma de valores que no están en el vector final es {0}",restavectorfinal);

        }
    }
}


