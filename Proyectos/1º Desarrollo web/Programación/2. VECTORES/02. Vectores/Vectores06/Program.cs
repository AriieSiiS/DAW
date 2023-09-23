
namespace Ejercicio
{
    class Ejercicio
    {
        static void Main(String[] args)
        {
            decimal[] notas = new decimal[10];
            string[] nombres = new string[10];
            decimal notas1 = 0;
            decimal media = 0;
            Console.WriteLine("Escribe los nombres y notas de los alumnos");

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("Escribe el siguiente nombre");
                nombres[i] = Console.ReadLine();
                Console.WriteLine("Escribe la nota");
                while (!(Decimal.TryParse(Console.ReadLine(), out notas1)))
                    Console.WriteLine("El número introducido no es válido");
                notas[i] = notas1;
                media += notas1;
            }
            media = media / notas.Length;
            Console.WriteLine("\nLa media es {0,2}", media);

            for (int i = 0; i < nombres.Length; i++)
            {
                if (notas[i] < media)
                {
                    Console.WriteLine("El alumno {0} tiene una nota menor que la media", nombres[i]);
                    
                }
            }
        }
    }
}



