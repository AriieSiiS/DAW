namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            int repeticion = 0;
            char letra;
            Console.WriteLine("Escribe una letra");
            while (!(Char.TryParse(Console.ReadLine(), out letra)))
                Console.WriteLine("Tienes que introducir una letra valida");
            Console.WriteLine("Dime cuantas veces quieres que se repita la letra");
            while (!(Int32.TryParse(Console.ReadLine(), out repeticion)) || (repeticion < 1))
                Console.WriteLine("Tienes que introducir un número valido");
            for (int i = 0; i <= repeticion; i++)
            {
                Console.WriteLine(letra);
            }


        }
    }
}


