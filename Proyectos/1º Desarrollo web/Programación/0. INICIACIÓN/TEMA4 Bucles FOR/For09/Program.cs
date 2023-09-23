using System;

namespace Ejercicio
{
    class Ejercicio
    {
        static void Main(String[] args)
        {
            int num1;
            int num2;
            Console.WriteLine("Dime dos numeros enteros");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 < num2)
            {
                for (int i = num1; i <= num2; i++)
                {
                    Console.WriteLine("\t{0}", i);
                }
            }
            else
                Console.WriteLine("No se puede contar del primer numero al segundo");
        }
    }
}

