using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class Functions
    {
        /*public const string File01 = "..\\..\\..\\Fichero01.txt";
        public const string File02 = "..\\..\\..\\Fichero02.txt";*/
        public static bool ValidateFile(string validation01)
        {
            bool keep = false;
            try
            {
                if ((!File.Exists(validation01)))
                    Console.WriteLine("El archivo de origen no existe");
                else
                    keep = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return keep;
        }
        public static bool CreateFile(string validation02)
        {
            bool keep = false;
            try
            {

                StreamWriter sw = File.CreateText(validation02);
                sw.Close();
                keep = true;    
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return keep;
        }

        public static void WriteFile(string validation01, string validation02)
        {
            string line;
            //leemos el archivo de origen
            StreamReader reader = new StreamReader(validation01);
            //escribimos el archivo de destino
            StreamWriter writer = new StreamWriter(validation02, true);
            try
            {
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    line = line.ToUpper();
                    writer.WriteLine(line);
                }
                writer.Close();
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
