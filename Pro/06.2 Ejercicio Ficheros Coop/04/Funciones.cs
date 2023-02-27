using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class Funciones
    {
        public const string Notas = "..\\..\\..\\Notas.txt";
        public const string Salida = "..\\..\\..\\salida.txt";

        public static bool Existe()
        {
            bool valor;
            if (File.Exists(Notas))
            {
                valor = true;
            }
            else
            {
                valor = false;
                Console.WriteLine("El fichero no existe, compruebalo e intentalo de nuevo");
            }
            return valor;
        }


    }
}
