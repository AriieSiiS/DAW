using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class Functions
    {
        public const string Turismo = "..\\..\\..\\Turismo.csv";

        public static bool ValidateFile()
        {
            bool keep = false;
            try
            {
                if (!(File.Exists(Turismo)))
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
                foreach (string line in File.ReadLines(Turismo))
                {
                    TextFile.Add(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        
        public static List<string> MenuCountryNames(List<string> dataFile)
        {
            //lista que contiene los nombres de los paises
            List<string> countryNames = new List<string>();

            string line;
            bool keepGoing = true;
            int counter = 1;

            //rellenamos la lista de nombres de paises 
            while (keepGoing)
            {
                line = dataFile[counter];
                string[] splitLine = line.Split(';');
                counter++;
                if (splitLine[2] == "TOTAL")
                    keepGoing = false;  
                else
                    countryNames.Add(splitLine[2]);
            }
            counter = 1;

            for (int i = 0; i < countryNames.Count; i++)
            {
                Console.WriteLine("\t{0}: {1}",counter, countryNames[i]);
                counter++;
            }
            Console.WriteLine("\tSelecciona el 0 para salir.");
            Console.Write("\nElige una opción: ");

            return countryNames;
        }

        public static string AskForCountry(List<string> countryNames)
        {
            string countryName = "";
            int option;
            while (!(Int32.TryParse(Console.ReadLine(), out option)) || (option > countryNames.Count) || (option < 1))
                Console.WriteLine("Introduce un número válido");

            countryName = countryNames[option-1];
            Console.WriteLine("Hola");
            return countryName;
        }


        public static int MenuYearOptions(List<string> dataFile)
        {
            Console.Clear();
            //sacamos el primer año
            string line;
            line = dataFile[1];
            string[] splitLine = line.Split(';');
            int min = Convert.ToInt32(splitLine[0]);

            //sacamos el ultimo año
            line = dataFile[dataFile.Count - 1];
            splitLine = line.Split(';');
            int max = Convert.ToInt32(splitLine[0]);
            int contador = 1;

            //escribimos la lista de años
            for (int i = min; i <= max; i++)
            {
                Console.WriteLine("\t{0}",i);
                contador++;
            }
            Console.WriteLine("");
            Console.Write("\n Elige el año a seleccionar:");

            int yearOption = Functions.AskForYear(max, min);
            return yearOption;
        }

        public static int AskForYear(int max, int min)
        {
            int yearOption;

            while (!(Int32.TryParse(Console.ReadLine(), out yearOption)) || (yearOption > max) || (yearOption < min))
                Console.WriteLine("Introduce un número válido");
            return yearOption;
        }



        public static void ShowInformation(List<string> dataFile, string countryOption, int yearOption)
        {
            Console.Clear();
            //array con los meses para mostrarlos por consola
            string[] months = new string[] 
            {
                "Enero",
                "Febrero",
                "Marzo",
                "Abril",
                "Mayo",
                "Junio",
                "Julio",
                "Agosto",
                "Sept",
                "Octubre",
                "Noviembre",
                "Diciembre"
            };
            int monthcounter = 0;
            string line;
            int counter = 1;
            int suma;
            Console.WriteLine("Pais: {0}", countryOption);
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("Año: {0}", yearOption);
            Console.WriteLine("----------------------------------------------------------------------------");
            while (monthcounter < 12)
            {
                line = dataFile[counter];
                string[] splitLine = line.Split(";");
                counter++;

                //primero buscamos el año que coincida 
                if (Convert.ToInt32(splitLine[0]) == yearOption)
                {
                    //una vez tenemos el año, buscamos el pais que coincida 
                    if (splitLine[2] == countryOption)
                    {
                        suma = Convert.ToInt32(splitLine[6]) + Convert.ToInt32(splitLine[7]);
                        Console.WriteLine("Mes: {0} \t\t 4 estrellas:\t {1} \t 5 estrellas: {2} \t SUMA: {3}", months[monthcounter], splitLine[6], splitLine[7], suma);
                        Console.WriteLine("----------------------------------------------------------------------------");
                        monthcounter++;
                    }
                }
            }
            Console.WriteLine("Pulsa una tecla para finalizar el programa");
            Console.ReadKey();  
        }
    }
}
