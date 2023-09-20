using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class CSMercancias
    {
        public static string ComprobarDestinos()
        {
            string Destino = "";
            while (Destino == "")
            {
                Destino = Console.ReadLine();
                if (Destino == "")
                    Console.WriteLine("El destino no puede estar vacío, intentalo de nuevo.");
            }
            return Destino;
        }

        public static decimal ComprobarPesos()
        {
            Console.WriteLine("Ahora dime el peso de la mercancía");
            decimal peso;
            while (!(Decimal.TryParse(Console.ReadLine(), out peso)) || (peso > 1200) || (peso < 0))
            {
                Console.WriteLine("El peso introducido no es correcto, intentalo de nuevo.");
            }
            return peso;
       
        }

        public static void MostrarDatos(string[] destinos, decimal[] pesos)
        {
            Console.Clear();
            for (int i = 0; i < destinos.Length; i++)
            {
                Console.WriteLine("El destino {0} lleva {1}kg de peso.", destinos[i], pesos[i]);
            }
            Console.WriteLine("\tPulsa una tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
