namespace Ejercicio
{
    class Ejercicio
    {
        static void Main(String[] args)
        {
            int total = 1;
            int x = 1;
            int num1;
            int mayor = 1;
            int menor = 1;
            do
            {
                Console.WriteLine("Dime los números");
                while (!int.TryParse(Console.ReadLine(), out num1))
                    Console.WriteLine("El número introducido no es correcto");
                if (x == 1)
                {
                    mayor = num1;
                    menor = num1;
                }
                else
                {
                    if (num1 > mayor)
                        mayor = num1;
                    else
                    {
                        if (num1 < menor)
                            menor = num1;
                    }
                }
                x++;
                total++;
            }
            while (total <= 5);
            Console.WriteLine("El mayor es {0}", mayor);
            Console.WriteLine("El menor es {0}", menor);
        }
    }
}



