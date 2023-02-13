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
                string[] lineasFichero = Fichero.GuardarContenidoFichero();
                if (lineasFichero.Length > 0)
                {
                    int[] datosVerificados = Fichero.ComprobarContenidoFichero(lineasFichero);
                    if (datosVerificados != null)
                    {
                        Fichero.EscribirFichero(datosVerificados);
                        Console.WriteLine("El fichero ha sido creado correctamente, pulse una tecla para mostrar su contenido");
                        Console.ReadKey();
                        Fichero.LeerFichero();
                    }
                    else
                        Console.WriteLine("El contenido del fichero es incorrecto");
                }
                else
                    Console.WriteLine("El fichero estaba vacío");
            }
            else
                Console.WriteLine("El fichero no existe");
        }
    }
}

