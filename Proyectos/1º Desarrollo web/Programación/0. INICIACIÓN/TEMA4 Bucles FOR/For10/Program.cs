using System;

namespace Ejercicio
{
    class Ejercicio
    {
        static void Main(String[] args)
        {
            int num1;
            int num2;
            int suma = 0;
            Console.WriteLine("Dime dos numeros enteros");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 < num2)
            {
                for (int i = num1; i <= num2; i++)
                {
                    suma = suma + i;
                    Console.WriteLine("\t{0}", suma);
                }
            }
            else
            {
                for (int i = num1; i >= num2; i--)
                {
                    suma = suma + i;
                    Console.WriteLine("\t{0}", suma);
                }
            }
        }
    }
}

