using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Máquina_Expendedora
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            string nombre;
            int cantidad;
            decimal precio;
            decimal saldo = 0;

            //instancia de la lista de objetos
            List<Producto> productos = new List<Producto>();
            //instancia de la máquina expendedora 
            MáquinaExpendedora maquina = new MáquinaExpendedora(productos);

            Producto producto1 = new Producto("Coca-Cola", 5, 2.5m);
            Producto producto2 = new Producto("Chocolate Snickers", 3, 1.8m);
            Producto producto3 = new Producto("Galletas Oreo", 8, 2.0m);

            productos.Add(producto1);
            productos.Add(producto2);
            productos.Add(producto3);

            while (!salir)
            {
                Funciones.LeerMenu();
                int opcion;
                while (!Int32.TryParse(Console.ReadLine(), out opcion))
                    Console.WriteLine("Escribe un número válido");
                int maxProducts = MáquinaExpendedora.GetMaxProductos();

                switch (opcion)
                {
                    case 1:
                        Funciones.ProductosDisponibles(productos);
                        Funciones.MostrarMensajeContinuar();
                        break;
                    case 2:
                        if (productos.Count >= maxProducts)
                        {
                            Console.WriteLine("Se ha alcanzado el máximo de productos permitidos en la máquina expendedora.");
                        }
                        else 
                        {
                            nombre = Producto.PedirNombre(); cantidad = Producto.PedirCantidad(); precio = Producto.PedirPrecio();
                            Producto producto = new Producto(nombre, cantidad, precio); productos.Add(producto);
                            Console.WriteLine("Producto añadido correctamente, presione una tecla para continuar"); Funciones.MostrarMensajeContinuar();
                        }
                        break;
                    case 3:
                        nombre = Producto.PedirNombre(); maquina.QuitarProducto(nombre);
                        Console.WriteLine("Producto eliminado correctamente, presione una tecla para continuar"); Funciones.MostrarMensajeContinuar();
                        break;
                    case 4:
                        Console.WriteLine("Dime el nombre del producto que quieras comprar. Esta es la lista de productos y su stock:");
                        Funciones.ProductosDisponibles(productos);
                        if (productos.Count == 0)
                        {
                            Funciones.MostrarMensajeContinuar();
                        }
                        else
                        {
                            nombre = Producto.PedirNombre();
                            maquina.ExtraerProducto(nombre, saldo);
                            Funciones.MostrarMensajeContinuar();
                        }
                        break;
                    case 5:
                        maquina.RellenarMaquina();
                        Console.WriteLine("Máquina rellenada con éxito."); Funciones.MostrarMensajeContinuar();
                        break;
                    case 6:
                        saldo = MáquinaExpendedora.PedirSaldo();
                        Funciones.MostrarMensajeContinuar();
                        break;
                    case 7:
                        salir = true;
                        Console.WriteLine("Saliendo de la aplicación...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, ingresa un número válido."); Funciones.MostrarMensajeContinuar();
                        break;
                }
            }
        }
    }
}