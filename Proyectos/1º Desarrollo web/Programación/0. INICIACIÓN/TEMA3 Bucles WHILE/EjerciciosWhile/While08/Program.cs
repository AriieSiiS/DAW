namespace Ejercicio
{
    class Ejercicio
    {
        static void Main(String[] args)
        {
            int num1;
            int contador = 1;
            int suma = 0;
            Console.WriteLine("Dime un número");
            while (!int.TryParse(Console.ReadLine(), out num1))
                Console.WriteLine("El número introducido no es correcto");
            do
            {
                if (contador % 3 == 0)
                {
                    Console.WriteLine("\t{0}", contador);
                    suma++;
                }
                contador++;
            }
            while (contador <= num1);
            Console.WriteLine("El conteo de los multiplos de 3 sería {0}", suma);
        }
    }
}

