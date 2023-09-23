using System;
using System.Diagnostics;
using System.Xml.Linq;

namespace ExamenObjetos
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {

            //creamos los juegos
            List<Games> JuegosTienda = new List<Games>();
            List<Games> juegosNoAlquilados = new List<Games>();
            List<Games> juegosAlquilados = new List<Games>();
            JuegosTienda.Add(new Games("Zelda", 35, false));
            JuegosTienda.Add(new Games("Mario", 45,false));
            JuegosTienda.Add(new Games("Sonic", 25, false));
            JuegosTienda.Add(new Games("Pokemon", 10, false));


            //llenamos la lista de posibles clientes
            Clientes.LlenarListaClientes();

            //mensajes de inicio de la tienda
            Console.WriteLine("Vamos a abrir una tienda nueva, necesito tu nombre de encargado y el número de telefono de la tienda");
            Console.WriteLine("Dime primero tu nombre de encargado");
            //nombre del encargado
            string name = Shop.AskName();
            Console.WriteLine("Ahora dime el número de telefono de la tienda");
            //telefono tienda
            int numero = Shop.AskTelefono();

            Shop tienda = new Shop(name, numero, JuegosTienda);
            tienda.JuegosNoAlquilados();
            tienda.JuegosAlquilados();
            int cod;
            int option = 0;
            do
            {
                Functions.ReadMenuOptions();
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    //alquilar
                    case 1:
                        cod = Functions.AskCodCliente();
                        Console.WriteLine("Juegos disponibles");
                        tienda.JuegosNoAlquilados();
                        Console.WriteLine("Selecciona uno");
                        int codJuego = Functions.AskCodJuego(juegosNoAlquilados);
                        tienda.ChangeGameStatusToFalse(codJuego, JuegosTienda);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    //devolver
                    case 2:
                        cod = Functions.AskCodCliente();
                        Console.WriteLine("Juegos a devolver");
                        tienda.JuegosAlquilados();


                        Console.ReadKey();
                        Console.Clear();
                        break;
                    //info tienda
                    case 3:
                        tienda.ShowShop();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    //historial juegos
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
            } while (option != 5);
        }
    }
}

