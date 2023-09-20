using System;
using System.Runtime.CompilerServices;

namespace Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            List<Games> list = new List<Games>();

            Games game1 = new Games();
            do
            {
                Games.ReadMenuOptions();
                Console.Write("\n");
                int option;

                if (Int32.TryParse(Console.ReadLine(), out option))
                {
                    switch (option)
                    {
                        case 1: Games.AddGame(); break;
                        case 2: noerror = Fichero.EliminarLineaFichero(); break;
                        case 3: Console.Clear(); keepGoing = false; break;
                    }
                }
                else
                    Console.WriteLine("Dime una opción válida");
            } while (keepGoing);
        }

    }
}
