using System;
using System.Collections.Generic;

namespace Cafetería
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            //instancia del historial de pedidos
            List<Pedido> historialPedidos = new List<Pedido>();

            //instancia de la lista de objetos
            List<Producto> productos = new List<Producto>();

            //instancia de Cafetería 
            Cafetería cafeteria = new Cafetería();

            Producto producto1 = new Producto("Café", 1.50M);
            Producto producto2 = new Producto("Bocadillo", 3.00M);
            Producto producto3 = new Producto("Refresco", 2.00M);
            Producto producto4 = new Producto("Ensalada", 4.50M);
            Producto producto5 = new Producto("Tarta", 2.50M);

            productos.Add(producto1);
            productos.Add(producto2);
            productos.Add(producto3);
            productos.Add(producto4);
            productos.Add(producto5);

            while (!salir)
            {
                Funciones.LeerMenú();
                int opcion;
                while (!Int32.TryParse(Console.ReadLine(), out opcion))
                    Console.WriteLine("Escribe un número válido");

                switch (opcion)
                {
                    case 1:
                        List<Producto> productosSeleccionados = Cafetería.SeleccionarProductos(productos);
                        Cafetería.RealizarPedido(productosSeleccionados, cafeteria);
                        Funciones.MostrarMensajeContinuar();
                        break;
                    case 2:
                        //servir pedido
                        cafeteria.EnviarPedido(historialPedidos);
                        Funciones.MostrarMensajeContinuar();
                        break;
                    case 3:
                        //ver historial
                        Cafetería.VerHistorial(historialPedidos);
                        Funciones.MostrarMensajeContinuar();
                        break;
                    case 4:
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