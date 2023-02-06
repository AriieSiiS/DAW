using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class Menu
    {
        public static void VerMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Añadir Linea");
            Console.WriteLine("2. Eliminar la primera linea");
            Console.WriteLine("3. Mostrar contenido");
            Console.WriteLine("4. Borrar fichero y crearo vacio");
            Console.WriteLine("5. Salir");
        }
        
        public static int LeerOpcion()
        {
            ConsoleKeyInfo tecla;
            int valor;
            do
            {
                valor = 0;
                tecla = Console.ReadKey(true);
                switch (tecla.KeyChar)
                {
                    case '1': valor = 1; break;
                    case '2': valor = 2; break;
                    case '3': valor = 3; break;
                    case '4': valor = 4; break;
                    case '5': valor = 5; break;

                }
            } while (valor == 0);
            return (valor);
        }
        public static void Adios()
        {
            Console.Write("Pulsa una tecla para salir");
            Console.ReadKey();
        }
    }
}
