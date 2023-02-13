
using System;

namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            //pedimos el nombre del fichero de origen
            Console.WriteLine("Dime el nombre del fichero de origen");
            string origenFile = Console.ReadLine();
            string validation01 = string.Concat("..\\..\\..\\" + origenFile + ".txt");
            //validamos que exista, el programa solo seguirá en caso de que exista
            bool keep = Functions.ValidateFile(validation01);
            if (keep)
            {
                //ahora creamos el fichero de destino
                Console.WriteLine("Ahora dime el nombre del fichero de destino y lo creamos");
                string newFile = Console.ReadLine();
                string validation02 = string.Concat("..\\..\\..\\" + newFile + ".txt");
                keep = Functions.CreateFile(validation02);
                if (keep)
                {
                    //si llegamos hasta aquí, el archivo de origen existe y se ha creado correctamente el de destino 
                    //llamamos a la función que va a poner el contenido del origen en el destino
                    Functions.WriteFile(validation01, validation02);
                }

            }


        }
    }
}


