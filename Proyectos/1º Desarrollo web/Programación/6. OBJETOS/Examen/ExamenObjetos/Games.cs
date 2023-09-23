using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenObjetos
{
    class Games
    {
        /// <summary> Nombre de cada producto </summary>
        private string ProductName { get; set; }

        /// <summary> Precio de cada producto </summary>
        private decimal ProductPrice { get; set; }

        /// <summary> Estado del producto </summary>
        private bool Alquilado { get; set; }

        /// <summary> Historial de pedidos </summary>
        private List<string> Record { get; set; }

        //Constructores
        public Games() { }

        public Games(string name, decimal price, bool alquilado)
        {
            this.ProductName = name;
            this.ProductPrice = price;
            this.Alquilado = alquilado;
            this.Record = new List<string>();
         
        }

        //Metodos



        //Método ToString
        public override string ToString()
        {
            string cadena = "";
            cadena += $"Nombre: {ProductName}  Precio: {ProductPrice}";

            return cadena;
        }

        //Getters y Setters 
        public void SetName(string name) { this.ProductName = name; }
        public string GetName() { return this.ProductName; }

        public void SetPrice(decimal price) { this.ProductPrice = price; }
        public decimal GetPrice() { return this.ProductPrice; }

        public void SetBool(bool alquilado) { this.Alquilado = alquilado; }
        public bool GetBool () { return this.Alquilado; }

    }
}

