
namespace Ejercicio
    {
        class Ejercicio
        {
            static void Main(String[] args)
            {
                int[] lista = new int[10];
                int num1 = 0;
                int suma = 0;
                Console.WriteLine("Escribe diez numeros");
                for (int i = 0; i < lista.Length; i++)
                {
                    Console.WriteLine("Escribe el siguiente numero");
                    while (!(Int32.TryParse(Console.ReadLine(), out num1)))
                        Console.WriteLine("El número introducido no es válido");
                    {
                        lista[i] = num1;
                        suma += num1;
                    }
                }
                Console.WriteLine("La media es {0}", suma / 10 );
            }
        }
    }

 

