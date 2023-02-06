using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq.Expressions;

namespace Ejercicio
{
    internal class Fichero
    {
        public const string FicheroPrueba = "Prueba.txt";
        public static bool IniciarFichero()
        {
            bool valor = true;
            StreamWriter write = null;
            if (!File.Exists(FicheroPrueba))
            {
                try
                {
                    write = File.CreateText(FicheroPrueba);
                    write.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    valor = false;
                }
            }
            return (valor);
        }

        public static bool CrearFichero()
        {
            bool valor = true;
            StreamWriter write = null;
            try
            {
                write = File.CreateText(FicheroPrueba);
                write.Close();
                Console.Clear();
                Console.WriteLine("Fichero creado vacío.");
                Console.WriteLine("Pulas una tecla para continuar");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                valor = false;
            }
            return (valor);
        }

        public static bool MostrarFichero()
        {
            bool valor = true;
            StreamReader read = null;
            try
            {
                read = new StreamReader(FicheroPrueba);
                Console.Clear();
                Console.WriteLine("Contenido del fichero de prueba");
                while (!read.EndOfStream)
                    Console.WriteLine(read.ReadLine());
                read.Close();
                Console.WriteLine("Pulsa una tecla para continuar");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                valor = false;
            }
            return (valor);
        }
        
        public static bool EscribirFichero()
        {
            bool valor = true;
            StreamWriter write = null;
            try
            {
                write = new StreamWriter(FicheroPrueba, true);
                Console.Clear();
                Console.WriteLine("Introduzca la información a incluir en el fichero");
                string cadena = Console.ReadLine();
                write.WriteLine(cadena);
                write.Close();
                Console.WriteLine("Información introducida");
                Console.WriteLine("Pulsa una tecla para continuar");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                valor = false;
            }
            return (valor);
        }

        public static bool EliminarLineaFichero()
        {
            bool valor = true;
            string[] lineas = new string[0];
            StreamReader read = null;
            StreamWriter writer = null;
            try
            {
                read = new StreamReader(FicheroPrueba);
                Console.Clear();
                string linea = read.ReadLine();
                while (!read.EndOfStream)
                {
                    Array.Resize(ref lineas, lineas.Length + 1);
                    lineas[lineas.Length - 1] = read.ReadLine();
                }
                read.Close();
                writer = File.CreateText(FicheroPrueba);
                foreach (string line in lineas)
                {
                    writer.WriteLine(line);
                }
                writer.Close();
                if (linea != null)
                {
                    Console.WriteLine("Se ha eliminado la linea" + linea);
                }
                else
                    Console.WriteLine("No hay mas lineas por eliminar");
                Console.WriteLine("Pulsa para salir");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                valor = false;
            }
            return (valor);
        }


    }
}
