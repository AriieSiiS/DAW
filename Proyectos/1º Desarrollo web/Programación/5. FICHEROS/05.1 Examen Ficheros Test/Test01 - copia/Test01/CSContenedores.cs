using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class CSContenedores
    {
        public static List<decimal> PesosContenedores(string[] destinos, decimal[] pesos)
        {
            List<decimal> SumaPesos = new List<decimal>();

            foreach (decimal peso in pesos)
                SumaPesos.Add(peso);
            decimal suma = 0;
            int contador = 0;
            for (int i = 0; i < destinos.Length; i++)
            {
                for (int j = 0; j < destinos.Length; j++)
                {
                    if (destinos[i] == destinos[j])
                    {
                        contador++;
                        if (contador > 1)
                        {
                            suma = pesos[i] + pesos[j];
                            SumaPesos.RemoveAt(i);
                            SumaPesos.Insert(i, suma);
                            SumaPesos.RemoveAt(j);
                            destinos[i] = null;
                        }
                    }
                }
                contador = 0;
            }
            return SumaPesos;
        }

        public static List<string> DestinosContenedores(string[] destinos, decimal[] pesos)
        {
            List<string> Contenedores = new List<string>();

            foreach (string cadena in destinos)
                Contenedores.Add(cadena);
            decimal suma = 0;
            int contador = 0;
            for (int i = 0; i < destinos.Length; i++)
            {
                for (int j = 0; j < destinos.Length; j++)
                {
                    if (destinos[i] == destinos[j])
                    {
                        contador++;
                        if (contador > 1)
                        {
                            suma = pesos[i] + pesos[j];
                            Contenedores.RemoveAt(i);
                            destinos[i] = null;
                        }
                    }
                }
                contador = 0;
            }
            return Contenedores;
            
        }
    }
}
