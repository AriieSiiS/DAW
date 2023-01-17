using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Funciones.SolicitarEntero();
            Console.WriteLine("El número {0} es entero", num);
        }
    }
    class Funciones
    {
        public static int SolicitarEntero()
        {
            int num;
            Console.WriteLine("Dime un número entero:");
            while (!(Int32.TryParse(Console.ReadLine(), out num)))
                Console.WriteLine("Intentalo de nuevo, el número no es valido");
            return num;
        }
        
    }
}
