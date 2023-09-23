using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PProgramingFile
{
    public class Function
    {
        public static void SacarLinea(string ruta, List<string> lista)
        {
            try
            {
                foreach (string line in File.ReadLines(ruta))
                {
                    lista.Add(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("no se puede leer");
            }

        }
        public static void Mostrar(List<string> lista, int numLine)
        {
            try
            {
                int diferencia;
                if (!(numLine < lista.Count))
                {
                    foreach (string line in lista)
                    {
                        Console.WriteLine(line);
                    }
                }
                else
                {
                    diferencia = lista.Count - numLine;
                    for (int i = diferencia ; i < lista.Count; i++)
                    {
                        Console.WriteLine(lista[i]);
                    }

                }
            }catch(Exception e)
            {
                Console.WriteLine("no se puede leer el fichero");
            }
           
        }
    }
}
