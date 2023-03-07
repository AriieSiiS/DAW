using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    internal class Games
    {
        //atributos
        public string name { get; set; }
        public double price { get; set; }
        public string genre { get; set; }

        //contructor
        public Games()
        {

        }

        
        public Games(string name, double price, string genre)
        {
            this.name = name;
            this.price = price;
            this.genre = genre;
        }

        //metodos

        public static void AddGame()
        {
            
            Console.WriteLine("Dime el nombre del juego");
            string name = Console.ReadLine();
            Console.WriteLine("Dime el precio del juego");
            double price;
            while (!(Double.TryParse(Console.ReadLine(), out price)))
                Console.WriteLine("Pon un valor válido");

            Console.WriteLine("Dime el genero del juego");
            string genre = Console.ReadLine();
            Games game1 = new Games(name, price, genre);
        }

        public static void SeeGames()
        {
            foreach (var game in Games)
            {

            }
        }

        //funciones

        

        public static void ReadMenuOptions()
        {
            Console.Clear();
            Console.WriteLine("\nMenú de opciones:");
            Console.WriteLine("1. Introducir juego nuevo");
            Console.WriteLine("2. Ver juegos introducidos");
            Console.WriteLine("3. Salir");
            Console.Write("\nSelecciona una opción: ");
        }
    }
}
