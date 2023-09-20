using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class Funciones
    {
        public const string Paro = "..\\..\\..\\paro.txt";
        public const string Salida = "..\\..\\..\\salida.txt";

        public static bool Existe()
        {
            bool valor;
            if (File.Exists(Paro))
            {
                valor = true;
            }
            else
            {
                valor = false;
                Console.WriteLine("El fichero no existe, compruebalo e intentalo de nuevo");
            }
            return valor;
        }

        public static List<string> GuardarLineas()
        {
            List<string> lineas = new List<string>();
            try
            {
                foreach (string line in File.ReadLines(Paro))
                {
                    lineas.Add(line);
                }
                return lineas;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return lineas;

        }
        public static List<string[]> Splitearlo(List<string> lineas)
        {
            string[] datos = new string[0];

            List<string[]> listaDatos = new List<string[]>();
                
            foreach (string line in lineas)
            {
                datos = line.Split(',');
                listaDatos.Add(datos);
            }
            return listaDatos;
        }

        public static void EscribirDatos(List<string[]> listaDatos)
        {
            try
            {
                int año = 2003;
                int contador = 6;
                string[] meses = { "enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre" };
                StreamWriter writer = new StreamWriter(Salida);
                int numero = 0;
                writer.WriteLine("AÑO;MES;MUNICIPIO;DATO");
                for (int i = 0; i < listaDatos.Count; i++)
                {
                    //años
                    contador = 6;
                    for (int x = 0; x < 11; x++)
                    {
                        //meses
                        if (x == 10)
                        {
                            for (int j = 0; j < 6; j++)
                            {
                                if (Int32.TryParse(listaDatos[i][contador], out numero))
                                {
                                    writer.WriteLine($"{año + x};{meses[j]};{listaDatos[i][5]};{numero}");
                                }
                                contador++;
                            }
                        }
                        else
                        {
                            for (int j = 0; j < 12; j++)
                            {
                                if (Int32.TryParse(listaDatos[i][contador], out numero))
                                {
                                    writer.WriteLine($"{año + x};{meses[j]};{listaDatos[i][5]};{numero}");
                                }
                                contador++;
                            }
                        }
                    }
                }
                writer.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
           
        }
    }

}
