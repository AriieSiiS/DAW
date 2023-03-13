using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class Functions
    {
        public const string POBLACION = "..\\..\\..\\poblacion-cifras-absolutas.csv";
        public const string POBLACIONFINAL = "..\\..\\..\\poblacion_datos_procesados.csv";
        public static bool ValidateFile()
        {
            bool keep = false;
            try
            {
                if (!(File.Exists(POBLACION)))
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
        public static void ReadFile(List<string> TextFile)
        {
            try
            {
                foreach (string line in File.ReadLines(POBLACION))
                {
                    TextFile.Add(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static string FillList(List<string> textFile, List<string> municipio, List<int> añoMin, List<int> valorMin, List<int> añoMax, List<int> valorMax, List<double> media)
        {
            string line;
            string errors = "";
            //comprobamos que los datos de la cabezera estén bien
            List<int> years = new List<int>();
            errors = Functions.CheckHeader(textFile, years);


            if (errors == "")
            {
                for (int i = 1; i < textFile.Count; i++)
                {
                    line = textFile[i];
                    string[] splitLine = line.Split(';');

                    //sacamos el nombre del municipio
                    string splitLineTrim = splitLine[1].Trim();
                    if (splitLineTrim != "")
                        municipio.Add(splitLine[1]);
                    else
                    {
                        errors = "Error. Hay un error en los datos de algún Municipio";
                        return errors;
                    }
                    //sacamos los valores que necesitamos
                    int number;
                    List<int> everyNumber = new List<int>();

                    for (int x = 2; x < splitLine.Length; x++)
                    {
                        number = Convert.ToInt32(splitLine[x]);
                        if (number <= -1)
                        {
                            errors = "Error. Hay un dato de poblacion que no es un número positivo";
                            return errors;
                        }
                        else
                            everyNumber.Add(number);
                    }
                    int min = everyNumber.Min();
                    int position = everyNumber.IndexOf(min);

                    int yearMin = years[position];
                    añoMin.Add(yearMin);
                    valorMin.Add(min);

                    int max = everyNumber.Max();
                    position = everyNumber.IndexOf(max);

                    int yearMax = years[position];
                    añoMax.Add(yearMax);
                    valorMax.Add(max);

                    double average = everyNumber.Average();
                    media.Add(average);
                }   
            }
            return errors;
        }

        public static string CheckHeader(List<string> textFile, List<int> years)
        {

            string line;
            string eachString;
            string errors = "";
            for (int i = 0; i < 1; i++)
            {
                line = textFile[0];
                string[] splitLine = line.Split(';');
                for (int x = 2; x < splitLine.Length; x++)
                {
                    eachString = splitLine[x];
                    string[] splitHeader = eachString.Split("_");
                    int year;

                    if (Int32.TryParse(splitHeader[1], out year))
                    {
                        if (year > 1999 && year < 2024)
                        {
                            years.Add(year);
                        }
                        else
                        {
                            errors = "Hay un dato no valido en la cabecera";
                            return errors;
                        }
                    }
                    else
                    {
                        errors = "Hay un dato no valido en la cabecera";
                        return errors;
                    }
                }
            }
            return errors;

        }

        public static void WriteFile(List<string> municipio, List<int> añoMin, List<int> valorMin, List<int> añoMax, List<int> valorMax, List<double> media)
        {
            StreamWriter writer = null;
            try
            {
                writer = File.CreateText(POBLACIONFINAL);
                string header = "Municipio;AñoMin;ValorMin;AñoMax;ValorMax;Media";
                writer.WriteLine(header);

                for (int i = 0; i < municipio.Count; i++)
                {
                    writer.WriteLine("{0};{1};{2};{3};{4};{5:f2}", municipio[i], añoMin[i], valorMin[i], añoMax[i], valorMax[i], media[i]);
                }
                writer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Se produjo una excepción al crear el archivo: " + ex.Message);
            }
        }

        public static double AskDecimalNumber(List<double> media)
        {
            double nDecimal = 0;
            //comprobamos que se haya creado con exito el archivo antes de preguntar los datos
            if (File.Exists(POBLACIONFINAL))
            {
                Console.WriteLine("Dime un número que esté entre la media de la población");
                double min = media.Min();
                double max = media.Max();
                Console.WriteLine("El valor mínimo sería {0:f2} y el máximo {1:f2}", min, max);
                while (!double.TryParse(Console.ReadLine(), out nDecimal) || (nDecimal < min) || (nDecimal > max))
                    Console.WriteLine("El valor introducido no es válido");
            }
            return nDecimal;

        }

        public static void ShowData(double nDecimal, List<string> municipio, List<double> media)
        {
            for (int i = 0; i < municipio.Count; i++)
            {
                if (media[i] >= nDecimal)
                {
                    Console.WriteLine("{0} ---> {1:f2}", municipio[i], media[i]);
                }
            }
        }

    }

}
