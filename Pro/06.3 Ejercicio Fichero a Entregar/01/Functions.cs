using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq.Expressions;
using System.Collections;


namespace Ejercicio
{
    internal class Functions
    {
        public const string CSV = "..\\..\\..\\edades.csv";

        List<string> lineasRuta2 = new List<string>();
        public static bool ValidateFile()
        {
            bool keep = false;
            try
            {
                if (!(File.Exists(CSV)))
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

        public static void ReadFile(List<string> TextFile)
        {
            try
            {
                foreach (string line in File.ReadLines(CSV))
                {
                    TextFile.Add(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public static void TransformToDouble(List<string> TextFile)
        {
            string line;
            string[] lineSplit = new string[0];

            for (int i = 1; i < TextFile.Count; i++)
            {
                line = TextFile[i];
                lineSplit = line.Split(';');

            }
        }
    }
}
