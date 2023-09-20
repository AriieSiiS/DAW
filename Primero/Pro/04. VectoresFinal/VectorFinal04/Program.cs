using System;

namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            //ponemos las variables
            int[] num = new int[10];
            int[] numfinal = new int[10];
            int numero;
            int buscador;
            //llenamos el vector de números
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Dime un número entero de una cifra");
                while (!(int.TryParse(Console.ReadLine(), out numero)) || numero < 0 || numero > 9)
                    Console.WriteLine("Tienes que introducir un número válido");
                num[i] = numero;
            }
            //pedimos el numero de referencia
            Console.WriteLine("Ahora dime otro número entero de una cifra");
            while (!(int.TryParse(Console.ReadLine(), out buscador)) || buscador < 0 || buscador > 9)
                Console.WriteLine("Tienes que introducir un número válido");
            Console.WriteLine(buscador);
            //creamos el vector nuevo
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > buscador)
                {
                    numfinal[i] += num[i];
                }
                else
                    numfinal[i] = 0;
            }
            //escribimos el vector resultante
            for (int i = 0; i < numfinal.Length; i++)
            {
                Console.Write("{0}\t", numfinal[i]);
            }
            
        



        }
    }
}


