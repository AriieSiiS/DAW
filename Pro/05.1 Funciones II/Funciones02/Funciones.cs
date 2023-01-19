using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class Funciones
    {
        public static int PosicionMenorValor(int[] vector)
        {
            
            int posicion = vector[0];
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] < posicion)
                    posicion = i;
            }
            if (posicion == vector[0])
                posicion = 0;
            return posicion;
        }
    }
}
