using System;

namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            //ponemos las variables
            const int Cantidad = 20;
            int[] notas = new int[Cantidad];
            int numero;
            decimal media = 0;
            int aprobados = 0;
            int suspendidos = 0;
            //llenamos el vector de números
            Console.WriteLine("Dime las 20 notas");
            for (int i = 0; i < notas.Length; i++)
            {
                while (!(int.TryParse(Console.ReadLine(), out numero)) || numero < 0 || numero > 10)
                    Console.WriteLine("Tienes que introducir un número válido");
                media += numero;
                notas[i] = numero;
                if (numero >= 5)
                    aprobados++;
                else
                    suspendidos++;
            }
            //escribimos el resultado
            Console.Write("Vector inicial: ");
            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write("{0} ", notas[i]);
            }
            Console.WriteLine("\nNúmero de aprobados: {0}", aprobados);
            Console.WriteLine("Número de suspendidos: {0}", suspendidos);
            media = media / notas.Length;
            Console.WriteLine("Media del grupo: {0:f2}", media);

        }
    }
}


