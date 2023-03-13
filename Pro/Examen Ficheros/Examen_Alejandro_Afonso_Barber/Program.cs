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
                //lista en la que estará todo el contenido del archivo y usaremos en las diferentes funciones
                List<string> textFile = new List<string>();

                //funcion que lee el archivo y rellena la lista
                Functions.ReadFile(textFile);

                //creamos una lista para cada dato que necesitamos
                List<string> municipio = new List<string>();
                List<int> añoMin = new List<int>();
                List<int> valorMin = new List<int>();
                List<int> añoMax = new List<int>();
                List<int> valorMax = new List<int>();
                List<double> media = new List<double>();

                //funcion que rellena las listas de cada dato
                string errors = Functions.FillList(textFile,municipio, añoMin, valorMin, añoMax, valorMax, media);

                if (errors == "")
                {
                    //escribimos el archivo final
                    Functions.WriteFile(municipio, añoMin, valorMin, añoMax, valorMax, media);

                    //pedimos al usuario un dato número decimal
                    double nDecimal = Functions.AskDecimalNumber(media);

                    if (nDecimal > 0)
                    {
                        //mostramos por pantalla los datos
                        Functions.ShowData(nDecimal, municipio, media);
                    }
                }
                else
                    Console.WriteLine(errors);


            }
        }
    }
}

