using System;

namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            //comprobamos que los dos ficheros de texto existen
            bool exist = Functions.CheckFile();
            
            if (exist)
            {
                //creamos el tercer fichero
                Functions.CreateFile();
                //rellenamos el fichero que hemos creado
                Functions.FillFile();
            }
                


        }
    }
}


