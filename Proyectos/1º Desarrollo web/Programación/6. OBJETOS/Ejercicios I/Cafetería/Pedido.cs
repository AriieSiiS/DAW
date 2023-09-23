using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafetería
{
    class Pedido
    {
        /// <summary> Lista de productos</summary>
        private List<Producto> productosSeleccionados { get; set; }

        /// <summary> Fecha del pedido</summary>

        private DateTime fechaPedido { get; set; }

        /// <summary> Precio del pedido</summary>
        private decimal precio { get; set; }

        //Constructores
        public Pedido(List<Producto> productosSeleccionados, decimal precio) 
        { 
            this.productosSeleccionados = productosSeleccionados; 
            fechaPedido = DateTime.Now; 
            this.precio = precio;
        }

        public Pedido()
        {
            this.productosSeleccionados = new List<Producto>();
            this.fechaPedido = DateTime.Now;
        }

        //Metodos

        //Metodo ToString
        public override string ToString()
        {
            decimal costoTotal = 0;
            foreach (Producto producto in productosSeleccionados)
            {
                costoTotal += producto.GetPrecio();
            }
            return "Pedido realizado el " + fechaPedido.ToString() + " con " + productosSeleccionados.Count + " productos. Precio total: " + costoTotal;
        }

        //Getters y Setters 
        public void SetProductos(List<Producto> productosSeleccionados) { this.productosSeleccionados = productosSeleccionados; }
        public List<Producto> GetProductos() { return productosSeleccionados; }

        public void SetfechaPedido(DateTime fechaPedido) { this.fechaPedido = fechaPedido; }
        public DateTime GetFechaPedido() {  return fechaPedido; }

        public void SetPrecio(decimal precio) {  this.precio = precio; }
        public decimal GetPrecio() {  return precio; }
    }
}

