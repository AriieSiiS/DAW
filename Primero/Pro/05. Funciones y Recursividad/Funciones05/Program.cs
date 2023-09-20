
using System;

namespace Funciones05
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            string frase = Funciones.PedirFrase();
            int menu = 0;   
            while (frase.Length > 0) 
            {
                Console.WriteLine("Escribe 1 para visualizar la frase");
                Console.WriteLine("Escribe 2 para añadir una letra");
                Console.WriteLine("Escribe 3 para quitar una letra");
                Console.WriteLine("Para salir tienes que quitar todas las letras");
                while (!(Int32.TryParse(Console.ReadLine(), out menu)) || menu > 3 || menu < 0)
                    Console.WriteLine("Intentalo de nuevo, el número no es valido");

                switch (menu)
                {
                    case 1:
                        Console.Clear();
                        Funciones.VerFrase(frase);
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.Clear();
                        string frasenueva = Funciones.AñadirLetra(frase);
                        frase = frasenueva;
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.Clear();
                        if (frase.Length != 1)
                        {
                            string quitarfrase = Funciones.QuitarLetra(frase);
                            frase = quitarfrase;
                            Funciones.QuitarLetra(frase);
                            Console.WriteLine();
                        }
                        else
                            frase = "";
                        break;
                }
            }

        }
    }
}


