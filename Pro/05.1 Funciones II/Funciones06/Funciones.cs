using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class Funciones
    {
        public static int ArrayAleatorio()
        {

            Random Random = new Random();
            int[] Aleatorio = new int[Random.Next(0, 100)];
            int media = 0;
            for (int i = 0; i < Aleatorio.Length; i++)
            {
                Aleatorio[i] = Random.Next(0, 100);
                media += Aleatorio[i];
            }
            media /= Aleatorio.Length;
            return media;
        }
    }
}
