namespace Ejercicio
{
    class Ejercicio
    {
        static void Main(String[] args)
        {
            int num1;
            int suma = 0;
            Console.WriteLine("Dime un número menor que 100");
            while (!int.TryParse(Console.ReadLine(), out num1) || (num1 > 99))
                Console.WriteLine("El número introducido no es correcto");
            do
            {
                if (!(num1 % 2 == 0))
                {
                    Console.WriteLine("\t{0}", num1);
                    suma += num1;
                }
                num1++;
            }
            while (num1 <= 99);
            Console.WriteLine("La suma es {0}", suma);
        }

    }
}


