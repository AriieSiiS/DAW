using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq.Expressions;
using System.Collections;
using System.ComponentModel;


namespace Ejercicio
{
    internal class Functions
    {
        public const string CSV = "..\\..\\..\\edades.csv";
        public const string log = "..\\..\\..\\errores.log";
        public const string AvPopulation = "..\\..\\..\\media_poblacion.csv";


        public static bool ValidateFile()
        {
            bool keep = false;
            try
            {
                if (!(File.Exists(CSV)))
                    Console.WriteLine("El archivo de origen no existe");
                else
                    keep = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return keep;
        }

        public static bool CreateLog()
        {
            StreamWriter writer = null;
            bool keep = true;
            try
            {
                writer = File.CreateText(log);
                writer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Se produjo una excepción al crear el archivo de errores: " + ex.Message);
            }
            return keep;
        }

        public static void ReadFile(List<string> TextFile)
        {
            try
            {
                foreach (string line in File.ReadLines(CSV))
                {
                    TextFile.Add(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public static bool TransformToDouble(List<string> textFile,List<double> averagePopulation,List<string> namePlaces)
        {
            bool errors = false;
            string line;
            string[] lineSplit = new string[0];
            double average;
            double result;
            string errorType = "";
  
            //cada iteracion de este bucle corresponde a una linea del fichero
            for (int i = 1; i < textFile.Count; i++)
            {
                line = textFile[i];
                lineSplit = line.Split(';');
                //le restamos dos al tamaño porque en este array no queremos guardar ni el primer dato ni el nombre de la provincia
                double[] doubleList = new double[lineSplit.Length-2];
                //dejamos vacia la primera posición porque no nos interesa ese dato y guardamos la segunda posición en una lista de strings
                lineSplit[0] = "";
                namePlaces.Add(lineSplit[1]);
                //por cada interacion de este bucle, se genera un array de doubles que corresponden a una de las lineas del fichero
                for (int x = 2; x < lineSplit.Length; x++)
                {
                    if (lineSplit.Length <= 20)
                    {
                        try
                        {
                            //comprobamos que el numero se pueda convertir y que sea mayor que 0
                            if (Double.TryParse(lineSplit[x], out result) && result >= 0)
                            {
                                doubleList[x - 2] = result;
                            }
                            else
                            {
                                // manejar el caso de que la conversión no se haya realizado correctamente o el número sea negativo
                                errorType = "invalid_format";
                                Functions.WriteErrors(i, errorType);
                                errors = true;
                                return errors;
                            }
                        }
                        catch (Exception ex)
                        {
                            // manejar cualquier otra excepción que pueda ocurrir
                            Console.WriteLine($"Se produjo una excepción: {ex.Message}");
                        }
                    }
                    else
                    {
                        errorType = "missing_data";
                        Functions.WriteErrors(i, errorType);
                        errors = true;
                        return errors;
                    }
                }
                //Si llegamos hasta aquí, sacamos la media y la guardamos en una lista 
                average = doubleList.Average();
                averagePopulation.Add(average);
            }
            return errors;
        }

        public static void WriteNewFile(List<double> averagePopulation, List<string> namePlaces)
        {
            StreamWriter writer = null;
            string fields = "Municipios; Media";
            try
            {
                writer = new StreamWriter(AvPopulation);
                writer.WriteLine(fields);
                for (int i = 0; i < averagePopulation.Count; i++)
                {
                    writer.WriteLine("{0}: {1:00}",namePlaces[i], averagePopulation[i]);
                }
                writer.Close(); 
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void WriteErrors(int i, string errorType)
        {
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(log);

                switch (errorType)
                {
                    case "invalid_format": writer.WriteLine("Linea {0}: Hay un valor que no es válido.", i + 1); 
                        break;
                    case "missing_data": writer.WriteLine("Linea {0}: Los datos no están en todos los años.", i + 1); 
                        break;
                    default: Console.WriteLine("Easter egg");
                        break;
                }
                writer.Close();
            }
            catch (Exception e)
            { Console.WriteLine(e); }
        }

    }
}
