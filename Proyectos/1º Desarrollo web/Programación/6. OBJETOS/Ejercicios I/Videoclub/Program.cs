using System;

namespace Videoclub
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable para salir del while en el que está el switch case
            bool salir = false;
            //codigo del cliente
            int codigo;

            //instancia de la lista de JuegosTienda
            List<Juego> JuegosTienda = new List<Juego>();

            //instancia de la lista Historial
            List<Juego> Historial = new List<Juego>();

            //mensajes de inicio de la tienda
            Console.WriteLine("Vamos a abrir una tienda nueva, necesito tu nombre de encargado y el número de telefono de la tienda");

            //pedimos el nombre y el telefono, y hacemos una instancia de la tienda con esos valores
            string encargado = Tienda.PedirEncargado();
            int telefono = Tienda.PedirTelefono();
            Tienda tienda = new Tienda(encargado, telefono, JuegosTienda);

            //asignamos un catalogo de juegos a la tienda
            JuegosTienda.Add(new Juego("Zelda", 35, 0));
            JuegosTienda.Add(new Juego("Mario", 45, 0));
            JuegosTienda.Add(new Juego("Sonic", 25, 0));
            JuegosTienda.Add(new Juego("Pokemon", 10, 0));


            while (!salir)
            {
                Console.Clear();
                Funciones.LeerMenú();
                int opcion;
                while (!Int32.TryParse(Console.ReadLine(), out opcion))
                    Console.WriteLine("Escribe un número válido");

                switch (opcion)
                {
                    case 1:
                        //Pedimos el codigo de cliente
                        codigo = Juego.PedirCodigo();
                        //Mostramos los juegos no alquilados
                        List<Juego> JuegosDisponibles = Tienda.MostrarJuegosDisponibles(JuegosTienda);
                        //El usuario selecciona uno de los juegos escribiendo su nombre
                        Tienda.AlquilarJuego(JuegosDisponibles, codigo);
                        Funciones.MostrarMensajeContinuar();
                        break;
                    case 2:
                        //Pedimos el codigo de cliente
                        codigo = Juego.PedirCodigo();
                        //Mostramos el juego que tiene alquilado
                        Tienda.DevolverJuego(JuegosTienda, codigo, Historial);
                        Funciones.MostrarMensajeContinuar();
                        break;
                    case 3:
                        Console.WriteLine(tienda);
                        //Información de la tienda
                        Funciones.MostrarMensajeContinuar();
                        break;
                    case 4:
                        //Historial de Juegos
                        Tienda.MostrarHistorial(Historial);
                        Funciones.MostrarMensajeContinuar();
                        break;
                    case 5:
                        salir = true;
                        Console.WriteLine("Saliendo de la aplicación...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, ingresa un número válido."); Funciones.MostrarMensajeContinuar();
                        break;
                }
            }
        }
    }
}