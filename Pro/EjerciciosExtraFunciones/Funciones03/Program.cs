using System;

namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            //declaramos las variables
            string Nombre = "Afonso, Alejandro";
            string[] partes = Nombre.Split(',');
            //mostramos el resultado
            Console.WriteLine("{0} {1}",partes[1].Trim(), partes[0]);
        }
    }
}

