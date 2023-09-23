using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenObjetos
{
    class Shop
    {
        /// <summary> Nombre del encargado </summary>
        private string Encargado { get; set; }

        /// <summary> Telefono de la tienda </summary>
        private int TelefonoTienda { get; set; }

        /// <summary> Lista de clientes </summary>
        private List<Clientes> ClientesTienda { get; set; }

        /// <summary> Lista de juegos de la tienda </summary>
        private List<Games> JuegosTienda { get; set; }


        //Constructores
        public Shop() { this.JuegosTienda = new List<Games>(); }



        public Shop(string name, int telefono, List<Games> juegos)
        {
            this.Encargado = name;
            this.TelefonoTienda = telefono;
            this.ClientesTienda = new List<Clientes>();
            this.JuegosTienda = juegos;
        }




        //Metodos

        public void ChangeGameStatusToFalse(int index, List<Games> juegos)
        {
            juegos.ElementAt(index).SetBool(false);
        }

        public void ChangeGameStatusToTrue(int index, List<Games> juegos)
        {
            juegos.ElementAt(index).SetBool(true);
        }
        public void JuegosNoAlquilados()
        {
            List<Games> juegosNoAlquilados = new List<Games>();
            Console.WriteLine("No Alquilados:");
            foreach (Games game in JuegosTienda)
            {
                bool alquilado = game.GetBool();
                if (!alquilado)
                {
                    juegosNoAlquilados.Add(game);
                }
            }
            int contador = 0;
            foreach (Games game in juegosNoAlquilados)
            {
                string chain = contador++ + " " + game.GetName() + " " + game.GetPrice();
                Console.WriteLine(chain);
            }
        }

        public void JuegosAlquilados()
        {
            Console.WriteLine("Alquilados:");
            List<Games> juegosAlquilados = new List<Games>();
            foreach (Games game in JuegosTienda)
            {
                bool alquilado = game.GetBool();
                if (alquilado)
                {
                    juegosAlquilados.Add(game);
                }
            }
            int contador = 0;
            foreach (Games game in juegosAlquilados)
            {
                
                string chain = contador++ + " " + game.GetName() + " " + game.GetPrice();
                Console.WriteLine(chain);
            }

        }


        public void ShowShop()
        {
            Console.Clear();
            Console.WriteLine("Encargado de la tienda: {0}", Encargado);
            Console.WriteLine("Telefono de la tienda: {0}", TelefonoTienda);
            JuegosNoAlquilados();
            JuegosAlquilados();
        }
        public static string AskName()
        {
            string name = "";
            name = Console.ReadLine();
            while (String.IsNullOrEmpty(name))
            {
                Console.WriteLine("El nombre no puede ser nulo o vacío.");
                name = Console.ReadLine();
            }
            return name;
        }
        public static int AskTelefono()
        {
            int telefono = 0;
            Console.WriteLine("Introduce el numero de telefono");
            while (!Int32.TryParse(Console.ReadLine(), out telefono) || telefono < 922000000 || telefono > 922999999)
                Console.WriteLine("El telefono tiene que ser un número valido");
            return telefono;
        }

        //Getters y Setters 
        public void SetName(string name) { this.Encargado = name; }
        public string GetName() { return this.Encargado; }

        public void SetTelefono(int telefono) { this.TelefonoTienda = telefono; }
        public decimal GetPrice() { return this.TelefonoTienda; }
        public void Add(Games juegos) { JuegosTienda.Add(juegos); }
        public List<Games> GetItems() { return JuegosTienda; }
    }
}
