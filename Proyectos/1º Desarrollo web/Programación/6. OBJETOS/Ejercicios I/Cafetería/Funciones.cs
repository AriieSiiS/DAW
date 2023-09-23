using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafetería
{
    class Funciones
    {
        public static void LeerMenú()
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Hacer pedido");
            Console.WriteLine("2. Recibir pedido");
            Console.WriteLine("3. Ver historial");
            Console.WriteLine("4. Salir del programa");
        }

        public static void ProductosDisponibles(List<Producto> productos)
        {
            foreach (Producto producto in productos)
            {

                Console.WriteLine(producto);
            }
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
