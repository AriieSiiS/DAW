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
        public const string Fichero01 = "Fichero01.txt";

        public static bool ComprobarFichero()
        {
            bool valor = true;
            
            if (!File.Exists(Fichero01))
            {
                Console.WriteLine("El fichero no existe");
                valor = false;
            }
            return (valor);
        }

        public static string[] GuardarContenidoFichero()
        {
            string[] lineasFichero = new string[0];
            StreamReader leer = null;
            try
            {
                leer = new StreamReader(Fichero01);
                string lineas = leer.ReadLine();
                while (!leer.EndOfStream)
                {
                    Array.Resize(ref lineasFichero, lineasFichero.Length+1);
                    lineasFichero[lineasFichero.Length - 1] = leer.ReadLine();
                }
                leer.Close();
            }
            catch (Exception ex)
            {
                //ha dado error
                Console.WriteLine(ex.Message);
            }
            return (lineasFichero);
        }

        public static bool ComprobarContenidoFichero()
        {
            bool valor = true;
            string[] lineasFichero = Fichero.GuardarContenidoFichero();
            string[] lineasSeparadas = new string[0];
            int nEntero;
            //guardar todo en array de numeros enteros
            //mejor usar un while
            for (int i = 0; i < lineasFichero.Length; i++)
            {
                lineasSeparadas = lineasFichero[i].Split(';');
                if (int.TryParse())
                //comprobar que su tamaño sea solo de dos y que sean numeros enteros
            }
            return (valor);
            
        }
    }
}
