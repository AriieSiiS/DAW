using System;

namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            //funcion que comprueba si el archivo existe
            bool keepGoing = Functions.ValidateFile();
            if (keepGoing)
            {
                //llamamos a una función para que cree el log con los posibles errores de formato
                keepGoing = Functions.CreateLog();
                if (keepGoing)
                {
                    //lista en la que estará todo el contenido del archivo y usaremos en las diferentes funciones
                    List<string> textFile = new List<string>();

                    //listas en la que estarán los nombres de cada provincia
                    List<string> namePlaces = new List<string>();

                    //lista en la que estará la media de poblacion de cada provincia
                    List<double> averagePopulation = new List<double>();

                    //funcion que lee el archivo y rellena la lista
                    Functions.ReadFile(textFile);

                    //funcion que transforma el contenido de cada linea y lo transforma a double además de pillar posibles errores
                    bool errors = Functions.TransformToDouble(textFile, averagePopulation, namePlaces);
                    if (errors)
                    {
                        Console.WriteLine("Ha habido un error en la ejecución, consulte el log para más información.");
                    }
                    else
                    {
                        //función que escribe el nuevo fichero con la media de población de cada provincia
                        Functions.WriteNewFile(averagePopulation, namePlaces);
                    }
                }
            }
        }
    }
}

