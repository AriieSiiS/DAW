using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Máquina_Expendedora
{
    class Funciones
    {
        public static void LeerMenu()
        {
            Console.WriteLine("Menú de la Máquina Expendedora");
            Console.WriteLine("------------------------------");
            Console.WriteLine("1. Mostrar productos disponibles");
            Console.WriteLine("2. Agregar nuevo producto");
            Console.WriteLine("3. Quitar producto de la máquina");
            Console.WriteLine("4. Comprar un producto");
            Console.WriteLine("5. Rellenar máquina expendedora");
            Console.WriteLine("6. Introduce tu saldo");
            Console.WriteLine("7. Salir");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Selecciona una opción ingresando el número correspondiente:");
        }

        public static void ProductosDisponibles(List<Producto> productos)
        {
            if (productos.Count == 0)
            {
                Console.WriteLine("No hay ningún producto disponible.");
            }
            else
            {
                foreach (Producto producto in productos)
                {

                    Console.WriteLine(producto);
                }
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
