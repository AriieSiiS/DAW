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

                //funcion que muestra el menú de paises
                List<string> countryNames = Functions.MenuCountryNames(textFile);

                //le pasamos la lista de paises para que nos devuelva el nombre del pais elegido
                string countryOption = Functions.AskForCountry(countryNames);

                //funcion que muestra el menú de años y nos pide un año válido que guardaremos en una variable
                int yearOption = Functions.MenuYearOptions(textFile);

                //le pasamos la lista con los datos de todo el documento, el pais elegido y el año elegido
                Functions.ShowInformation(textFile, countryOption, yearOption);
            }
        }
    }
}


