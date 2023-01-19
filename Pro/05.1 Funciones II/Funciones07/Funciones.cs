using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class Funciones
    {
        public static string PedirString()
        {
            string frase = "";
            while (frase == "")
            {
                Console.WriteLine("Dime una frase");
                frase = Console.ReadLine();
                if (frase == "")
                    Console.WriteLine("La frase introducida no es válida");
            }
            return frase;
        }

        public static char PedirChar()
        {
            Console.WriteLine("Dime una letra");
            char letra;
            while (!(Char.TryParse(Console.ReadLine(), out letra) && char.IsLetter(letra)))
                Console.WriteLine("La letra introducida no es correcta");
            return letra;
        }
        public static (int[],int)  CantidadVeces()
        {
            string frase = Funciones.PedirString(); 
            char letra = Funciones.PedirChar();
            int contador = 0;
            int[] posición = new int[contador+1];

            for (int i = 0; i < frase.Length; i++)
            {
                if (letra == frase[i])
                {
                    posición[contador] = i;
                    contador++;
                    Array.Resize(ref posición, posición.Length + contador);
                }
            }
            return (posición, contador);
        }
    }
}
