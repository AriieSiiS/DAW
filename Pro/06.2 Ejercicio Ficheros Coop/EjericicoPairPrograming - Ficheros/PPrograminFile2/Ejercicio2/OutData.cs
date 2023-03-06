using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PProgramingFile
{
    internal class OutData
    {
        public static int OutIntRango()
        {
            int num;
            Console.WriteLine("Dime un numero entero Y positivo");
            while (!(int.TryParse(Console.ReadLine(), out num))  || !(num > 0))
                Console.WriteLine("El valor no se encuentra dentro de los parámetros requeridos");
            return num;
        }
        public static string OutString()
        {
            string nombre;
            Console.WriteLine($"dime el nombre del fichero");
            while (((nombre = Console.ReadLine()) == "" && nombre == " "))
                Console.WriteLine("el nombre no puede estar vacio");
            return nombre;
        }
    }
}
