using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videoclub
{
    class Juego
    {
        /// <summary> Nombre de cada producto </summary>
        private string Nombre { get; set; }

        /// <summary> Precio de cada producto </summary>
        private decimal Precio { get; set; }

        /// <summary> Codigo de los clientes </summary>
        private int CodCliente { get; set; }



        //Constructores
        public Juego() { }

        public Juego(string nombre, decimal precio, int codigo)
        {
            //validamos que el nombre no esté vacío 
            if (nombre.Length > 0) { this.Nombre = nombre; }
            else { this.Nombre = "Juego"; }
            
            //validamos que el precio no pueda ser menor o igual que 0
            if (precio > 0) { this.Precio = precio; }
            else { this.Precio = 1; }

            this.CodCliente = codigo;
        }

        //Metodos
        public static int PedirCodigo()
        {
            int cod = 0;
            Console.WriteLine("Introduce el codigo de cliente");
            while (!Int32.TryParse(Console.ReadLine(), out cod) || cod < 100 || cod > 999)
                Console.WriteLine("El codigo ha de ser un número entre 100 y 999");
            return cod;
        }

        //metodo To String
        public override string ToString()
        {
            return $"Videojuego: {Nombre}, Precio: {Precio}";
        }

        //Getters y Setters 

        public void SetNombre(string nombre) { this.Nombre = nombre; }
        public string GetName() { return this.Nombre; }

        public void SetPrecio(decimal precio) { this.Precio = precio; }
        public decimal GetPrecio() { return this.Precio; }

        public void SetCodigo (int codigo) { this.CodCliente = codigo; }
        public int GetCodigo () { return this.CodCliente; }

    }
}
