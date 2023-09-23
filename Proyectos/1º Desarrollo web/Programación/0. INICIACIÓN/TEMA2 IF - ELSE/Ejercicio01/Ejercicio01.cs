using System;

namespace Ejercicio01
{
    class ComparaciónDeNúmeros
    {
        static void Main(String[] args)
        {
            int num1;
            Console.WriteLine("Dime un número");
            num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 == 10)
            {
                Console.WriteLine("El numero es igual que diez");
            }
            else 
            {
                if (num1 > 10)
                {
                    Console.WriteLine("El número es mayor que diez");
                }
                else
                {
                    Console.WriteLine("El número es menor que diez");
                }
            }
        }
    }
}