using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videoclub
{
    class Funciones
    {
        public static void LeerMenú()
        {
            Console.WriteLine("----- MENÚ -----");
            Console.WriteLine("1. Alquilar");
            Console.WriteLine("2. Devolver");
            Console.WriteLine("3. Información de la tienda");
            Console.WriteLine("4. Historial de Juegos");
            Console.WriteLine("5. Salir");
        }

        public static void MostrarMensajeContinuar()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Presione una tecla para continuar.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
