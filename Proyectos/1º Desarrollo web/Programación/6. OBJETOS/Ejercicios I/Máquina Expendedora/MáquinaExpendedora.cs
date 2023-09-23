using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Máquina_Expendedora
{
    class MáquinaExpendedora
    {
        /// <summary> Lista de productos</summary>
        private List<Producto> productos { get; set; }

        /// <summary> Maximo de productos distintos </summary>
        private const int maxProductos = 20;

        /// <summary> Saldo del producto </summary>
        private decimal saldo { get; set; } 


        //Constructores
        public MáquinaExpendedora(List<Producto> productos) { this.productos = productos; }

        public MáquinaExpendedora(decimal saldo) 
        {
            this.productos = new List<Producto>();
            this.saldo = saldo;
        }

        //Métodos
        public static decimal PedirSaldo()
        {
            decimal saldo = 0;
            Console.WriteLine("Introduce tu saldo");
            while (!Decimal.TryParse(Console.ReadLine(), out saldo) || saldo < 0)
                Console.WriteLine("Introduce un saldo válido.");
            return saldo;
        }
        public static int GetMaxProductos()
        {
            return maxProductos;
        }
        public void ExtraerProducto(string nombre, decimal saldo)
        {
            bool nombreExists = false;  
            foreach (Producto producto in productos)
            {
                if (producto.GetNombre() == nombre)
                {
                    nombreExists = true;
                    int cantidad = producto.GetCantidad();

                    if (cantidad > 0)
                    {
                        decimal precio = producto.GetPrecio();
                        if (saldo >= precio)
                        {

                            saldo -= precio;
                            producto.SetCantidad(cantidad - 1); Console.WriteLine("Producto extraído: " + producto.GetNombre() + ": Se te devolverá " + saldo + " euros.");
                        }
                        else
                            Console.WriteLine("No hay saldo suficiente");
                    }
                    else
                        Console.WriteLine("No hay stock disponible para el producto: " + producto.GetNombre());
                }
            }
            if (!nombreExists) 
                Console.WriteLine("El nombre introducido no existe.");
        }

        public void QuitarProducto(string nombre)
        {
            bool nombreExists = false;
            foreach (Producto producto in productos)
            {
                if (producto.GetNombre() == nombre)
                {
                    nombreExists = true;
                    productos.Remove(producto);
                    break;
                }
            }
            if (!nombreExists)
                Console.WriteLine("El nombre introducido no existe.");
        }
        public void RellenarMaquina()
        {
            foreach(Producto producto in productos)
            {
                producto.SetCantidad(10);
            }
        }

        //Getters y Setters 
        public void SetProductos(List<Producto> productos) { this.productos = productos; }
        public List<Producto> GetProductos() { return productos; }

        public void SetSaldo(decimal saldo) { this.saldo = saldo; }
        public decimal GetSaldo() {  return saldo; }
        
    }
}



