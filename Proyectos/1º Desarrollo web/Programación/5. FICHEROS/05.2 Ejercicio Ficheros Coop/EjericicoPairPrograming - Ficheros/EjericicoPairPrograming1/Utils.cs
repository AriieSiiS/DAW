using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjericicioPairPrograming
{
    public class Utils
    {
        public static void LeerLineas(string ruta, List<string> lista)
        {
            try
            {
                foreach (string line in File.ReadLines(ruta))
                {
                    lista.Add(line);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            
        }



        public static void EscribirLineas(string ruta3, List<string> lineasRuta1, List<string> lineasRuta2, int size)
        {
            int contadorLineasVacias = 0;

            
            try
            {
                StreamWriter sw = new StreamWriter(ruta3);

                for (int i = 0; i < size; i++)
                {

                    if ((lineasRuta1[i] == lineasRuta2[i]))
                    {
                        contadorLineasVacias++;
                    }
                    else
                    {
                        sw.WriteLine($"{i + 1};{lineasRuta1[i]};{lineasRuta2[i]}");
                    }
                }

                sw.Close();
                Console.WriteLine($"Lineas iguales: {contadorLineasVacias}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }            
        }


        public static int IgualarTamañoLineas(List<string> lineasRuta1, List<string> lineasRuta2)
        {
            int size = 0, diferencia = 0;

            if (lineasRuta1.Count < lineasRuta2.Count)
            {
                size = lineasRuta2.Count;
                diferencia = lineasRuta2.Count - lineasRuta1.Count;

                if (diferencia != 0)
                {
                    for (int i = 0; i <= diferencia; i++)
                    {
                        lineasRuta1.Add("");
                    }
                }
            }
            else
            {
                size = lineasRuta1.Count;
                diferencia = lineasRuta1.Count - lineasRuta2.Count;

                if (diferencia != 0)
                {
                    for (int i = 0; i <= diferencia; i++)
                    {
                        lineasRuta2.Add("");
                    }
                }
            }

            return size;
        }
    }
}
