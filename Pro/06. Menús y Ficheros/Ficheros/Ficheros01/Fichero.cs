using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq.Expressions;
using System.Diagnostics.Contracts;
using System.ComponentModel;
using System.Drawing;

namespace Ejercicio
{
    internal class Fichero
    {
        public const string Fichero01 = "..\\..\\..\\Fichero01.txt";
        public const string Fichero02 = "..\\..\\..\\Fichero02.txt";

        public static bool ComprobarFichero()
        {
            bool valor = true;
            if (!File.Exists(Fichero01))
                valor = false;
            return (valor);
        }

        public static string[] GuardarContenidoFichero()
        {
            string[] lineasFichero = new string[0];
            StreamReader leer = null;
            try
            {
                leer = new StreamReader(Fichero01);
                while (!leer.EndOfStream)
                {
                    Array.Resize(ref lineasFichero, lineasFichero.Length + 1);
                    lineasFichero[lineasFichero.Length - 1] = leer.ReadLine();

                }
                leer.Close();
            }
            catch (Exception ex)
            {
                //ha dado error
                Console.WriteLine(ex.Message);
                Array.Resize(ref lineasFichero, 0);
            }
            return (lineasFichero);
        }

        public static int[] ComprobarContenidoFichero(string[] lineasFichero)
        {
            int[] numerosComprobados = new int[lineasFichero.Length * 2];
            int nEntero;
            bool salir = false;
            bool error = false;
            int i = 0;
            //guardar todo en array de numeros enteros
            //mejor usar un while
            while (!salir)
            {
                string[] lineasSeparadas = new string[0];
                lineasSeparadas = lineasFichero[i].Split(';');
                if (lineasSeparadas.Length.Equals(2))
                {
                    if (!(Int32.TryParse(lineasSeparadas[0], out numerosComprobados[i * 2])))
                    {
                        salir = true;
                        error = true;   
                    }
                    else if (!(Int32.TryParse(lineasSeparadas[1], out numerosComprobados[(i * 2) + 1])))
                    {
                        salir = true;
                        error = true;
                    }
                    i++;
                }
                else
                {
                    salir = true;
                    error = true;
                }
                if (i == lineasSeparadas.Length+1)
                {
                    salir = true;
                }
            }
            if (error)
                numerosComprobados = null;

            return (numerosComprobados);
            
        }

        public static void EscribirFichero(int [] datosVerificados)
        {
            
            StreamWriter write = new StreamWriter(Fichero02);
            if (!File.Exists(Fichero02))
            {
                File.Create(Fichero02).Dispose();
            }
            try
            {
                for (int i = 0; i < datosVerificados.Length / 2 ; i++)
                {
                    write.WriteLine($"{datosVerificados[i * 2]} + {datosVerificados[(i * 2) + 1]} = {datosVerificados[i * 2] + datosVerificados[(i * 2) + 1]} ");
                }
                write.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void LeerFichero()
        {
            try
            {
                StreamReader read = new StreamReader(Fichero02);
                Console.Clear();
                Console.WriteLine("Contenido del fichero es:");
                while (!read.EndOfStream)
                    Console.WriteLine(read.ReadLine());
                read.Close();
                Console.WriteLine("Pulsa una tecla para salir del programa");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
