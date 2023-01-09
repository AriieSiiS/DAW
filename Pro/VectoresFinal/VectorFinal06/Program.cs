using System;

namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            //variables
            int[] lista = new int[20];
            int[] listacopia = new int[20];
            int[] listaordenada = new int[20];
            int num = 0;
            int contador = 0;
            int minimo = 0;
            int contadorordenado = 0;
            int listaX = 0;

            //solicitamos los números al usuario
            Console.WriteLine("Escribe veinte números enteros positivos");
            for (int i = 0; i < lista.Length; i++)
            {
                while (!(Int32.TryParse(Console.ReadLine(), out num)))
                    Console.WriteLine("El número introducido no es válido");
                lista[i] = num;
                listacopia[i] = num;
                contador++;
                minimo = lista[0];
                for (int j = 0; j < contador; j++)
                {
                    for (int x = 0; x < contador; x++)
                    {
                        if (lista[x] <= minimo)
                        {
                            minimo = lista[x];
                            listaordenada[contadorordenado] = lista[x];
                            listaX = x;
                        }
                    }
                    contadorordenado++;
                    lista[listaX] = int.MaxValue;
                    minimo = lista[listaX];
                }
                contadorordenado = 0;

                for (int j = 0; j < contador; j++)
                {
                    lista[j] = listacopia[j];
                }
                //escribimos los elementos ingresados hasta ahora
                for (int j = 0; j < contador; j++)
                {
                    Console.WriteLine("\t{0}", listaordenada[j]);
                }

            }
        }
    }
}


