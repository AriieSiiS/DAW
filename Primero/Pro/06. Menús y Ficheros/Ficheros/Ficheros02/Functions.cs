using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class Functions
    {
        public const string Fichero01 = "..\\..\\..\\Fichero01.txt";
        public static void ReadMenuOptions()
        {
            Console.Clear();
            Console.WriteLine("\nMenú de opciones:");
            Console.WriteLine("1. Crear el fichero");
            Console.WriteLine("2. Introducir valores numéricos en el fichero");
            Console.WriteLine("3. Calcular máximo de los valores almacenados en el fichero");
            Console.WriteLine("4. Calcular mínimo de los valores almacenados en el fichero");
            Console.WriteLine("5. Calcular media de los valores almacenados en el fichero");
            Console.WriteLine("6. Salir");
            Console.Write("\nSelecciona una opción: ");
        }
        public static void CreateFile()
        {
            int opcion;
            bool continuar = true;
            Console.Clear();
            if (File.Exists(Fichero01))
            {
                Console.WriteLine("El fichero ya existe.");
                Console.Write("\nEscriba 1 para sobreescribirlo y 2 para volver al menú: ");
                do
                {
                    int.TryParse(Console.ReadLine(), out opcion);

                    switch (opcion)
                    {
                        case 1:
                            File.Create(Fichero01).Dispose();
                            Console.WriteLine("Archivo sobreescrito con éxito. Presione una tecla para continuar");
                            Console.ReadKey();
                            continuar = false;
                            break;
                        case 2:
                            continuar = false;
                            break;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                } while (continuar);
            }
            else
            {
                File.Create(Fichero01).Dispose();
            }
        }
        public static void EnterNumbers()
        {
            Console.Clear();
            Console.WriteLine("Introduce valores numericos. Pulse el 0 para salir al menú.");
            Console.Write("\nIntroduce el primer número: ");
            int num = 1;
            int count = 0;
            int[] numbers = new int[0];
            while (num != 0)
            {
                
                while (!(Int32.TryParse(Console.ReadLine(), out num)))
                    Console.WriteLine("Introduce un número válido.");
                if (num != 0)
                {
                    Array.Resize(ref numbers, numbers.Length + 1);
                    numbers[count] = num;
                    count++;
                    Console.Clear();
                    Console.Write("\nIntroduce el siguiente número o pulse 0 para salir: ");
                }
            }
            StreamWriter write = new StreamWriter(Fichero01, true);
            try
            {
                foreach (int number in numbers)
                {
                    write.WriteLine(number);
                }
                write.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static int[] ReadFile()
        {
            int[] numbers = new int[0];
            try
            {
                StreamReader reader = new StreamReader(Fichero01);

                int count = 0;
                int num;

                while (!reader.EndOfStream)
                {
                    Array.Resize(ref numbers, numbers.Length + 1);
                    if (int.TryParse(reader.ReadLine(), out num))
                    {
                        numbers[count] = num;
                        count++;
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            return numbers;
        }


        public static void CalcMaxNumbers(int[] numbers)
        {
            Console.Clear();
            int max = numbers.Max();
            Console.WriteLine($"El máximo de los valores del fichero es {max}");
            Console.ReadKey();
        }
        public static void CalcMinNumbers(int[] numbers)
        {
            Console.Clear();
            int min = numbers.Min();
            Console.WriteLine($"El mínimo de los valores del fichero es {min}");
            Console.ReadKey();
        }
        public static void CalcAvgNumbers(int[] numbers)
        {
            Console.Clear();
            double avg = numbers.Average();
            avg = Math.Round(avg,2);
            Console.WriteLine($"La media de los valores del fichero es {avg}");
            Console.ReadKey();
        }

    }
}