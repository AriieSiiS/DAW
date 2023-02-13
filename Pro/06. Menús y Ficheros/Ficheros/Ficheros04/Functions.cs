using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class Functions
    {
        public const string File01 = "..\\..\\..\\Fichero01.txt";
        public const string File02 = "..\\..\\..\\Fichero02.txt";
        public const string File03 = "..\\..\\..\\Fichero03.txt";

        public static void CreateFile()
        {
            File.Create(File03).Dispose();
        }

        public static void CheckFile()
        {
            if (!File.Exists(File01))
            {
                Console.WriteLine("El primer fichero no existe, asegurate de que exista y vuelva a ejecutar el programa");
            }
            else if (!File.Exists(File02))
            {
                Console.WriteLine("El segundo fichero no existe, asegurate de que exista y vuelva a ejecutar el programa");
            }
        }

        public static void FillFile()
        {
            try
            {
                StreamWriter writer = new StreamWriter(File03, true);
                StreamReader reader01 = new StreamReader(File01);
                StreamReader reader02 = new StreamReader(File02);
                string file01;
                string file02;
                int counter = 0;
                int countFile01 = File.ReadLines(File01).Count();
                int countFile02 = File.ReadLines(File02).Count();

                if (countFile01 >= countFile02)
                {
                    while (!reader01.EndOfStream)
                    {
                        file01 = reader01.ReadLine();
                        writer.WriteLine(file01);
                        file02 = reader02.ReadLine();
                        writer.WriteLine(file02);
                        counter++;
                        if (counter == countFile02)
                        {
                            while (!reader01.EndOfStream)
                            {
                                file01 = reader01.ReadLine();
                                writer.WriteLine(file01);
                            }
                        }
                    }
                }
                else
                {
                    while (!reader02.EndOfStream)
                    {
                        file01 = reader01.ReadLine();
                        writer.WriteLine(file01);
                        file02 = reader02.ReadLine();
                        writer.WriteLine(file02);
                        counter++;
                        if (counter == countFile01)
                        {
                            while (!reader02.EndOfStream)
                            {
                                file02 = reader01.ReadLine();
                                writer.WriteLine(file02);
                            }
                        }
                    }
                }
                reader01.Close();
                reader02.Close();
                writer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }

}
