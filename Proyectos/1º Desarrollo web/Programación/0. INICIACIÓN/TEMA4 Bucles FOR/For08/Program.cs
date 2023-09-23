using System;

namespace Ejercicio
{
    class Ejercicio
    {
        static void Main(String[] args)
        {
            int num;
            Console.WriteLine("Dime un numero entero");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = num; i >= 1; i--)
            {
                if (num % i == 0) 
                {
                    Console.WriteLine("\t{0}",i);
                }
            }
        }
    }
}
