using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Máquina_Expendedora
{
    class Producto
    {
        /// <summary> Nombre del producto </summary>
        private string Nombre { get; set; }

        /// <summary> Cantidad del producto </summary>
        private int Cantidad { get; set; }

        /// <summary> Maximo de elementos del mismo producto </summary>
        private const int maxElementosPorLinea = 10;

        /// <summary> Precio del producto </summary>
        private decimal Precio { get; set; }


        //Constructores

        public Producto() { } //usamos un constructor vacio obligatoriamente

        public Producto(string nombre, int cantidad, decimal precio)
        {
            this.Nombre = nombre;
            this.Cantidad = cantidad;
            this.Precio = precio;
        }

        //Métodos
        public static string PedirNombre()
        {
            string nombre = "";
            Console.WriteLine("Dime el nombre del producto");
            nombre = Console.ReadLine();
            while (String.IsNullOrEmpty(nombre))
            {
                Console.WriteLine("El nombre no puede ser nulo o vacío.");
                nombre = Console.ReadLine();
            }
            return nombre;
        }
        public static int PedirCantidad()
        {
            int cantidad = 0;
            Console.WriteLine("Introduce la cantidad del producto");
            while (!Int32.TryParse(Console.ReadLine(), out cantidad) || cantidad > maxElementosPorLinea)
                Console.WriteLine("Introduce un número de productos valido. El máximo es {0}", maxElementosPorLinea);
            return cantidad;
        }
        public static decimal PedirPrecio()
        {
            decimal precio = 0;
            Console.WriteLine("Introduce el precio del  producto");
            while (!Decimal.TryParse(Console.ReadLine(), out precio) || precio < 0)
                Console.WriteLine("Introduce un número de productos valido.");
            return precio;
        }
 
        //Metodo ToString
        public override string ToString()
        {
            return $"Nombre: {Nombre}, Cantidad: {Cantidad}, Precio: {Precio}";
        }
        //Getters y Setters 
        public void SetNombre(string nombre) { this.Nombre = nombre; }
        public string GetNombre() { return this.Nombre; }

        public void SetCantidad(int cantidad) { this.Cantidad = cantidad; }
        public int GetCantidad() {  return this.Cantidad; }

        public void SetPrecio(decimal precio) { this.Precio = precio; }
        public decimal GetPrecio() { return this.Precio; }
    }


}

