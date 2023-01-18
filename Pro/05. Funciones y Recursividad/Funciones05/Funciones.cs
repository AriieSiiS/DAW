using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones05
{
     class Funciones
    {

        public static string PedirFrase()
        {
            Console.WriteLine("Escribe una frase");
            string frase = "";
            while (frase == "")
            {
                frase = Console.ReadLine();
                if (frase == "")
                    Console.WriteLine("La frase no puede estar vacía");
            }
            return frase;
        }

        public static void VerFrase(string frase)
        {
            Console.WriteLine("La frase es {0}", frase);
        }

        public static string AñadirLetra(string frase)
        {
            Console.WriteLine("Escribe una letra");
            char letra;
            Char.TryParse(Console.ReadLine(), out letra);
            frase += letra;
            return frase;
        }
        public static string QuitarLetra(string frase)
        {
            frase = frase.Remove(frase.Length-1);
            return frase;
        }
        

    }
}





