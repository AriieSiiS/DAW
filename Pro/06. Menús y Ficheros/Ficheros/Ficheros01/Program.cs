using System;

namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            //comprobamos si el fichero existe
            bool valor = Fichero.ComprobarFichero();
            if (valor)
            {
                //comprobamos el contenido del fichero
                valor = Fichero.ComprobarContenidoFichero();
                if (valor)
                {

                }
                else
                    Console.WriteLine("El contenido del fichero es incorrecto");
            }
            else
                Console.WriteLine("El fichero no existe");
        }
    }
}

