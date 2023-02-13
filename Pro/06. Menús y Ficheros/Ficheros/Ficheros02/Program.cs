using System;

namespace Ejercicio
{
    internal class Ejercicio
    {
        public const string Fichero01 = "..\\..\\..\\Fichero01.txt";
        static void Main(String[] args)
        {
            int[] numbers = null;
            if (File.Exists(Fichero01))
            {
                numbers = Functions.ReadFile();
                if (numbers.Length == 0 )
                {
                    numbers = null;
                }
            }
            bool continuar = true;
            do
            {
                Functions.ReadMenuOptions();
                int opcion;

                if (Int32.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Functions.CreateFile();
                            numbers = Functions.ReadFile();
                            if (numbers.Length == 0)
                            {
                                numbers = null;
                            }
                            break;
                        case 2:
                            Functions.EnterNumbers();
                            numbers = Functions.ReadFile();
                            break;
                        case 3:
                            if (numbers == null)
                            {
                                Console.WriteLine("Por favor ingrese números primero");
                                Console.ReadKey();
                            }
                            else
                                Functions.CalcMaxNumbers(numbers);
                            break;
                        case 4:
                            if (numbers == null)
                            {
                                Console.WriteLine("Por favor ingrese números primero");
                                Console.ReadKey();
                            }
                            else
                                Functions.CalcMinNumbers(numbers);
                            break;
                        case 5:
                            if (numbers == null)
                            {
                                Console.WriteLine("Por favor ingrese números primero");
                                Console.ReadKey();
                            }
                                
                            else
                                Functions.CalcAvgNumbers(numbers);
                            break;

                        case 6:
                            continuar = false;
                            break;
                        default:
                            Console.WriteLine("Opción inválida, por favor selecciona una opción válida");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opción inválida, por favor selecciona una opción válida");
                }
            } while (continuar);
        }
    }
}


