
namespace Ejercicio
{
    class Ejercicio
    {
        static void Main(String[] args)
        {
            decimal[] lista = new decimal[10];
            decimal num1 = 0;
            decimal suma = 0;
            decimal media;
            Console.WriteLine("Escribe diez numeros decimales");
            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine("Escribe el siguiente numero");
                while (!(Decimal.TryParse(Console.ReadLine(), out num1)))
                    Console.WriteLine("El número introducido no es válido");
                {
                    lista[i] = num1;
                    suma += num1;
                }
            }

            media = suma / lista.Length;
            Console.WriteLine("La media es {0}",media);

            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i] > media)
                {
                    Console.WriteLine("\n{0}",lista[i]);
                }
            }
        }
    }
}



