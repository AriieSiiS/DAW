using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Videoclub
{
    class Tienda
    {

        /// <summary> Nombre del encargado </summary>
        private string Encargado { get; set; }

        /// <summary> Telefono de la tienda </summary>
        private int Telefono { get; set; }

        /// <summary> Lista de juegos de la tienda </summary>
        private List<Juego> JuegosTienda { get; set; }

        /// <summary> Historial de cada juego alquilado </summary>
        private List<Juego> Historial { get; set; }


        //Constructores
        public Tienda() 
        { 
            this.JuegosTienda = new List<Juego>(); 
            this.Historial = new List<Juego>();
        } 

        public Tienda(string encargado, int telefono, List<Juego> JuegosTienda)
        {
            this.Encargado = encargado;
            this.Telefono = telefono;
            this.JuegosTienda = JuegosTienda;
        }

        //Metodos
        public static string PedirEncargado()
        {
            Console.WriteLine("Dime el nombre del encargado.");
            string encargado = "";
            encargado = Console.ReadLine();
            while (String.IsNullOrEmpty(encargado))
            {
                Console.WriteLine("El nombre no puede ser nulo o vacío.");
                encargado = Console.ReadLine();
            }
            return encargado;
        }

        public static int PedirTelefono()
        {
            int telefono = 0;
            Console.WriteLine("Introduce el numero de telefono");
            while (!Int32.TryParse(Console.ReadLine(), out telefono) || telefono < 922000000 || telefono > 922999999)
                Console.WriteLine("El telefono tiene que ser un número valido");
            return telefono;
        }

        public static List<Juego> MostrarJuegosDisponibles(List<Juego> JuegosTienda)
        {
            List<Juego> JuegosDisponibles = new List<Juego>();
            foreach (Juego juego in  JuegosTienda)
            {
                if (juego.GetCodigo() == 0)
                {
                    Console.WriteLine(juego);
                    JuegosDisponibles.Add(juego);
                }
            }
            return JuegosDisponibles;
        }

        public static void AlquilarJuego(List<Juego> JuegosDisponibles, int codigo)
        {
            bool juegoencontrado = false;
            string nombreJuego;
            Console.WriteLine("Escribe el nombre del juego que quieres alquilar");
            nombreJuego = Console.ReadLine();
            foreach (Juego juego in JuegosDisponibles)
            {
                if (nombreJuego == juego.GetName())
                {
                    juegoencontrado = true;
                    Console.WriteLine("Juego alquilado correctamente.");
                    JuegosDisponibles.Remove(juego);
                    juego.SetCodigo(codigo);
                    return;
                }
            }
            if (!juegoencontrado)
            {
                Console.WriteLine("No había ningún juego con ese nombre.");
            }
        }

        public static void DevolverJuego(List<Juego> JuegosTienda, int codigo, List<Juego> Historial)
        {
            bool juegoAlquilado = false;
            foreach (Juego juego in JuegosTienda)
            {
                if (juego.GetCodigo() == codigo)
                {
                    Console.WriteLine("El juego que tienes alquilado es: " + juego); juegoAlquilado = true;
                    Historial.Add(new Juego(juego.GetName(), juego.GetPrecio(), juego.GetCodigo()));
                    juego.SetCodigo(0);
                    Console.WriteLine("Juego devuelto correctamente.");
                }
            }
            if (!juegoAlquilado)
                Console.WriteLine("No hay ningún juego alquilado para este usuario.");
        }

        public static void MostrarHistorial(List<Juego> Historial)
        {
            foreach (Juego juego in Historial)
            {
                Console.WriteLine(juego);
                Console.Write(juego.GetCodigo());
                Console.WriteLine("");
            }
        }

        //ToString 
        public override string ToString()
        {
            string cadena = "";
            cadena += $"Encargado de la tienda: {Encargado}\n";
            cadena += $"Telefono de la tienda: {Telefono}\n";
            cadena += $"Juegos Disponibles:\n";
            this.JuegosTienda.FindAll(juego => juego.GetCodigo().Equals(0)).ForEach(juego => cadena += $"{juego}\n");
            cadena += $"Juegos no disponibles:\n";
            this.JuegosTienda.FindAll(juego => !juego.GetCodigo().Equals(0)).ForEach(juego => cadena += $"{juego}\n");
            return cadena + "\n";
        }

        //Getters y Setters 
        public void SetEncargado(string encargado) { this.Encargado = encargado; }
        public string GetEncargado() { return this.Encargado; }

        public void SetTelefono(int telefono) { this.Telefono = telefono; }
        public int GetTelefono() { return this.Telefono; }

        public void SetJuegosTienda(List<Juego> JuegosTienda) { this.JuegosTienda = JuegosTienda; }
        public List<Juego> GetJuegosTienda() { return this.JuegosTienda; }

        public void SetHistorial(List<Juego> Historial) { this.Historial = Historial; }
        public List<Juego> GetHistorial() { return this.Historial; }  

    }
}
