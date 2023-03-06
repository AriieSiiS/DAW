using System;

namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            string nombre = "";
            string[] nombres = new string[0];
            int[] copiasPagadas = new int[0];
            int contador = 0;

            //Pedimos los nombres
            while (nombre != "FIN")
            {
                Console.WriteLine("Dime el nombre del alumno o escribe FIN para salir");
                nombre = CSInscripcion.PedirNombres();
                if (nombre != "FIN")
                {
                    if (nombres.Contains(nombre))
                    {
                        Console.WriteLine("El nombre no puede estar repetido, intentalo de nuevo");
                    }
                    else
                    {
                        Array.Resize(ref nombres, nombres.Length + 1);
                        nombres[contador] = nombre;
                        //Pedimos las fotocopias
                        int fotocopias = CSInscripcion.Fotocopias();
                        Array.Resize(ref copiasPagadas, copiasPagadas.Length + 1);
                        copiasPagadas[contador] = fotocopias;
                        contador++;
                    }
                }
            }
            int opcion = 1;
            do
            {
                CSTienda.OpcionesMenú();
                opcion = CSTienda.LeerOpcion();

                Console.Write("\n");
                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("Gracias por usar la aplicación, pulsa una tecla para salir.");
                        Console.ReadKey();
                        break;
                    case 1: CSTienda.RealizarVenta(nombres, copiasPagadas); break;
                    case 2: CSTienda.MostrarDatos(nombres, copiasPagadas);  break;
                    default: Console.WriteLine("Introduce una opción válida"); Console.ReadKey(); break; 
                }
            } while (opcion != 0);

        }
    }
}


