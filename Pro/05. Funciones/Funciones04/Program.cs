using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dime una frase");
            string frase = Console.ReadLine();
            Console.WriteLine("Ahora dime una letra");
            char letra = Console.ReadLine()[0];
            Cantidad(frase,letra);
        }
        private static void Cantidad(string frase, char letra)
        {
            int contador = 0;
            foreach (char letra1 in frase)
            {
                if (letra1 == letra) 
                    contador++;
            }
            Console.WriteLine("El total de veces que aparece la letra {0} en la frase es {1}",letra,contador);
        }
    }
}
