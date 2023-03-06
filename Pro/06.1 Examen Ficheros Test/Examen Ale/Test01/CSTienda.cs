using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class CSTienda
    {
        public static void OpcionesMenú()
        {
            Console.Clear();
            Console.WriteLine("Escribe el número de la opción que quieras realizar.");
            Console.WriteLine("0. Salir del programa.");
            Console.WriteLine("1. Realizar venta.");
            Console.WriteLine("2. Mostrar datos de venta.");
            
        }

        public static int LeerOpcion()
        {
            int opcion;
            while (!(Int32.TryParse(Console.ReadLine(), out opcion)))
                Console.WriteLine("El número no es valido, intentalo de nuevo.");
            return opcion;
        }

        public static int nVentas;
        public static List<string> ventaNombre = new List<string>();
        public static List<int> numeroCopias = new List<int>();
        public static int fotocopiascompradas;
        public static double gananciastotal;
        public static void RealizarVenta(string[] nombres, int[] copiasPagadas)
        {
            
            
            bool continua = false;
            string seleccionNombre = "";
            int contador = 0;
            int nCopias = 0;
            nVentas = 0;

            Console.WriteLine("Selecciona una de las personas con bono");
            Console.WriteLine("");
            foreach (string nombre in nombres)
                Console.WriteLine("\t {0}",nombre);
            while (!continua)
            {
                seleccionNombre = Console.ReadLine();
                if (seleccionNombre == "")
                {
                    continua = false;
                    Console.WriteLine("El nombre no puede estar vacío, intentalo de nuevo.");
                }
                    
                else if (!nombres.Contains(seleccionNombre))
                {
                    continua = false;
                    Console.WriteLine("Debes introducir un nombre que exista");
                }
                else
                {
                    continua = true;
                }
            }

            ventaNombre.Add(seleccionNombre);

            for (int i = 0; i < nombres.Length; i++)
            {
                if (nombres[i] == seleccionNombre)
                    contador = i;
            }
            
            nCopias = copiasPagadas[contador];
            numeroCopias.Add(nCopias);
            
            Console.WriteLine("Ahora dime copias deseas realizar");
            fotocopiascompradas = CSTienda.LeerOpcion();
            int index = numeroCopias.IndexOf(nCopias);
            

            if (numeroCopias[index] > fotocopiascompradas)
            {
                numeroCopias[index] -= fotocopiascompradas;
                nVentas++;
                gananciastotal = (fotocopiascompradas * 0.05);
            }
            else
            {
                Console.WriteLine("Este usuario no tiene suficientes fotocopias disponibles en su bono");
                ventaNombre.RemoveAt(ventaNombre.Count - 1);
                numeroCopias.RemoveAt(numeroCopias.Count - 1);
                Console.WriteLine("Pulsa una tecla para continuar");
                Console.ReadKey();
            }
            
        }

        

        public static void MostrarDatos(string[] nombres, int[] copiasPagadas)
        {
            Console.WriteLine("ESTADO DE LOS BONOS");
            Console.WriteLine("__________________________________________________________________________________________");
            Console.WriteLine("Nombre \t Copias Pagadas \t Copias Realizadas \t Copias Restantes \t Ventas Realizadas");
            if (nVentas >= 1)
            {
                for (int i = 0; i < ventaNombre.Count; i++)
                {
                    Console.Write(ventaNombre[i]);
                    Console.Write("\t");
                    Console.Write("\t");
                    Console.Write("\t");
                    Console.Write(copiasPagadas[i]);
                    Console.Write("\t");
                    Console.Write("\t");
                    Console.Write("\t");
                    Console.Write(fotocopiascompradas);
                    Console.Write("\t");
                    Console.Write("\t");
                    Console.Write("\t");
                    Console.Write(numeroCopias[i]);
                    Console.Write("\t");
                    Console.Write("\t");
                    Console.Write("\t");
                    Console.Write(nVentas);
                    Console.WriteLine("");
                }
            }

            Console.WriteLine("Ganancias totales {0} euros", gananciastotal);
            Console.ReadKey();
        }





    }
}
