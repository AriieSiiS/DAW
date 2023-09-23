using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            for (int i = frase.Length-1; i >= 0; i--)
            {
                Console.WriteLine("|" + frase[i] + "|");
                
            } 
        }

        public static string AñadirLetra(string frase)
        {
            char letra = Funciones.ComprobarLetra();
            frase += letra;
            return frase;
        }

        public static char ComprobarLetra()
        {
            char letra;
            Console.WriteLine("Escribe una letra");
            while (!(Char.TryParse(Console.ReadLine(), out letra)) || (char.IsLetter(letra) == false))
                Console.WriteLine("La letra introducida no es válida");
            return letra;
        }
        public static string QuitarLetra(string frase)
        {
            frase = frase.Remove(frase.Length-1);
            return frase;
        }
        

    }
}





