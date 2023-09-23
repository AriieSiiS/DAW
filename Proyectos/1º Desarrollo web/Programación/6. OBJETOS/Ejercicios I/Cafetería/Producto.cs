using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafetería
{
    class Producto
    {
        /// <summary> Nombre del producto </summary>
        private string Nombre { get; set; }


        /// <summary> Precio del producto </summary>
        private decimal Precio { get; set; }


        //Constructores

        public Producto() { } //usamos un constructor vacio obligatoriamente

        public Producto(string nombre,decimal precio)
        {
            this.Nombre = nombre;
            this.Precio = precio;
        }

        //Métodos

 
        //Metodo ToString
        public override string ToString()
        {
            return $"Nombre: {Nombre}, Precio: {Precio}";
        }
        //Getters y Setters 
        public void SetNombre(string nombre) { this.Nombre = nombre; }
        public string GetNombre() { return this.Nombre; }

        public void SetPrecio(decimal precio) { this.Precio = precio; }
        public decimal GetPrecio() { return this.Precio; }
    }


}

