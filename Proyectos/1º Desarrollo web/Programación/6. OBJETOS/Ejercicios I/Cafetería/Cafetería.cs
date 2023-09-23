using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Cafetería
{
    class Cafetería
    {
        /// <summary> Lista de productos</summary>
        private List<Producto> productos { get; set; }

        /// <summary> maximo de pedidos que se pueden realizar a la vez </summary>

        private const int MaxPedidos = 5;

        /// <summary> Cola de pedidos </summary>
        private Queue<Pedido> colaPedidos { get; set; }

        private List<Pedido> historialPedidos { get; set; }

        //Constructores
        public Cafetería(List<Producto> productos, Queue<Pedido> colaPedidos, List<Pedido> historialPedidos) 
        { 
            this.productos = productos; 
            this.colaPedidos = colaPedidos; 
            this.historialPedidos = historialPedidos;
        }
        public Cafetería()
        {
            this.productos = new List<Producto>();
            this.colaPedidos = new Queue<Pedido>();
            this.historialPedidos = new List<Pedido>();
        }

        //Metodos

        public static List<Producto>  SeleccionarProductos (List<Producto> productos)
        {
            bool salir = false;
            string nombreProducto = "";

            //lista donde irán los productos que haya seleccionado el usuario en este pedido
            List<Producto> productosSeleccionados = new List<Producto>();

            while (!salir)
            {
                Console.WriteLine("Escribe el nombre del producto que quieras hasta que pulses 0.");
                Funciones.ProductosDisponibles(productos);
                nombreProducto = Console.ReadLine();    
                if (nombreProducto != "0")
                {
                    bool productoEncontrado = false;
                    foreach (Producto producto in productos)
                    {
                        if (producto.GetNombre() == nombreProducto)
                        {
                            productoEncontrado = true;
                            productosSeleccionados.Add(producto);
                            Console.Clear();
                        }
                    }
                    if (!productoEncontrado)
                        Console.WriteLine("No hay ningún producto con ese nombre");
                }
                else
                    salir = true;
            }
            return productosSeleccionados;
        }

        public static void RealizarPedido(List<Producto> productosSeleccionados, Cafetería cafeteria)
        {
            if (productosSeleccionados.Count == 0)
            {
                Console.WriteLine("No has seleccionado ningún producto. El pedido no puede ser realizado.");
            }
            else
            {
                if (cafeteria.GetCola().Count < MaxPedidos)
                {
                    Pedido nuevoPedido = new Pedido(productosSeleccionados, 0);
                    cafeteria.GetCola().Enqueue(nuevoPedido);
                    Console.WriteLine("¡Pedido realizado con éxito!");
                }
                else
                {
                    Console.WriteLine("Supera el máximo de pedidos, espere a que haya un hueco disponible.");
                }
            }
        }
        public void EnviarPedido(List<Pedido> historialPedidos)
        {
            if (colaPedidos.Count == 0)
            {
                Console.WriteLine("No hay pedidos en espera para ser enviados.");
            }
            else
            {
                Pedido pedido = colaPedidos.Dequeue();
                historialPedidos.Add(pedido);
                Console.WriteLine("Pedido enviado: " + pedido);
            }
        }
        public static void VerHistorial (List<Pedido> historialPedidos)
        {
            foreach (Pedido pedido in historialPedidos)
            {
                Console.WriteLine(pedido);
            }
        }

        //Getters y Setters 
        public void SetProductos(List<Producto> productos) { this.productos = productos; }
        public List<Producto> GetProductos() { return productos; }

        public void SetCola(Queue<Pedido> colaPedidos) { this.colaPedidos =  colaPedidos; }
        public Queue<Pedido> GetCola() { return colaPedidos; }

        public void SetHistorial (List<Pedido> historialPedidos) { this.historialPedidos = historialPedidos; }
        public List<Pedido> GetHistorial() {  return historialPedidos; }

    }
}
