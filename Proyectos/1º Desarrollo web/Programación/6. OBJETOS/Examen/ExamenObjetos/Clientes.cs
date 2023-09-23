using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenObjetos
{
    class Clientes
    {
        /// <summary> Cod Cliente </summary>
        private int CodCliente { get; set; }

        /// <summary> El cliente puede o no alquilar </summary>
        private bool Alquilar { get; set; }

        //Constructores
        public Clientes() { }

        public Clientes(int cod, bool alquilar)
        {
            this.CodCliente = cod;
            this.Alquilar = alquilar;
        }

        //Metodos
        public static void LlenarListaClientes()
        {
            List<Clientes> Clientes = new List<Clientes>();
            for (int i = 100; i < 1000; i++)
            {
                Clientes.Add(new Clientes(i, true));
            }
        }

        //Getters y Setters 
        public void SetCod(int cod) { this.CodCliente = cod; }
        public int GetCod() { return this.CodCliente; }

        public void SetBool(bool alquilar) { this.Alquilar = alquilar; }
        public bool GetBool() { return this.Alquilar; }




    }
}
