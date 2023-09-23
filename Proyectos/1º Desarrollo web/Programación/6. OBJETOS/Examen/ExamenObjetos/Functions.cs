using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenObjetos
{
    class Functions
    {
        public static int AskCodCliente()
        {
            int cod = 0;

            Console.WriteLine("Introduce el codigo de cliente");
            while (!Int32.TryParse(Console.ReadLine(), out cod) || cod < 100 || cod > 999)
                Console.WriteLine("El codigo ha de ser un número entre 100 y 999");
            return cod;
        }
        public static int AskCodJuego(List<Games> juegosNoAlquilados)
        {
            int codJuego = 0;
            Console.WriteLine("Introduce el numero del juego");
            while (!Int32.TryParse(Console.ReadLine(), out codJuego) || codJuego < juegosNoAlquilados.Count || codJuego > -1)
                Console.WriteLine("El codigo ha de ser un número entre 0 y {0}", juegosNoAlquilados.Count);
            return codJuego;
        }


        public static void ReadMenuOptions()
        {
            Console.Clear();
            Console.WriteLine("Menú principal:");
            Console.WriteLine("1. Alquilar juego");
            Console.WriteLine("2. Devolver juego");
            Console.WriteLine("3. Mostrar info tienda");
            Console.WriteLine("4. Mostrar historial");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
        }
    }
}
