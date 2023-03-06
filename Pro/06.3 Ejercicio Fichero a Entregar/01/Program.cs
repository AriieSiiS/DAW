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
                //lista en la que estará todo el contenido del archivo
                List<string> TextFile = new List<string>();
                //funcion que lee el archivo y rellena la lista
                Functions.ReadFile(TextFile);
                //funcion que transforma el contenido de cada linea y lo transforma a double 
                Functions.TransformToDouble(TextFile);
            }
        }
    }
}

