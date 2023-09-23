using System;

namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            int[] lista = new int[10];
            int[] listaordenada = new int[10];
            int[] listaordenada2 = new int[10];
            int num1 = 0;
            Console.WriteLine("Escribe diez numeros");
            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine("Escribe el siguiente numero");
                while (!(Int32.TryParse(Console.ReadLine(), out num1)))
                    Console.WriteLine("El número introducido no es válido");
                lista[i] = num1;
                listaordenada[i] = num1;
            }
            int contadormax = lista.Length-1;
            int bucle1 = 0;
            int maximo = listaordenada[0];
            
            for (int j = 0; j < listaordenada.Length; j++)
            {
                for (int i = 0; i < lista.Length; i++)
                {
                    if (listaordenada[i] > maximo)
                    {
                        maximo = listaordenada[i];
                        bucle1 = i;
                    }
                    else
                    {
                        if (maximo == listaordenada[0])
                        {
                            bucle1 = 0;
                        }
                    }
                }
                listaordenada[bucle1] = 0;
                listaordenada2[contadormax] = maximo;
                contadormax--;
                maximo = listaordenada[0];
            }

            for (int i = 0; i < listaordenada2.Length; i++)
            {
                Console.WriteLine("\n{0}",listaordenada2[i]);
            }
        }
    }
}


