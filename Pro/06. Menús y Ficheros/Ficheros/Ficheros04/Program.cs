using System;

namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            //comprobamos que los dos ficheros de texto existan
            Functions.CheckFile();
            //creamos el tercer fichero
            Functions.CreateFile(); 
            //rellenamos el fichero que hemos creado
            Functions.FillFile();
        }
    }
}


