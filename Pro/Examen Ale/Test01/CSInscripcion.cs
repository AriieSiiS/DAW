using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class CSInscripcion
    {
        public static string PedirNombres()
        {
            string nombre = "";
            while (nombre == "")
            {
                nombre = Console.ReadLine();
                if (nombre == "")
                    Console.WriteLine("El nombre no puede estar vacío, intentalo de nuevo.");
            }
            return nombre;
        }
        public static int Fotocopias()
        {
            int fotocopias = 0;
            Console.WriteLine("Dime el número de fotocopias que vas a comprar. (Mínimo 10)");
            while (!(Int32.TryParse(Console.ReadLine(), out fotocopias)) || (fotocopias < 10))
                Console.WriteLine("El número de fotocopias no es valido, intentalo de nuevo.");
            return fotocopias;
        }
       
        
    }
}
