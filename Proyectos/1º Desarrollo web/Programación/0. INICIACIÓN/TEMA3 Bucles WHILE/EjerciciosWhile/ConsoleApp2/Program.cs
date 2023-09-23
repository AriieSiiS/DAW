namespace Ejercicio
{
    class Ejercicio
    {
        static void Main(String[] args)
        {
            int num1;
            int suma = 0;
            Console.WriteLine("Dime un número");

            do
            {
                while (!int.TryParse(Console.ReadLine(), out num1))
                    Console.WriteLine("El número introducido no es correcto");
                suma += num1;
            }
            while (suma < 50);
            Console.WriteLine("La suma de todos esos números es {0}", suma);



        }
    }
}


