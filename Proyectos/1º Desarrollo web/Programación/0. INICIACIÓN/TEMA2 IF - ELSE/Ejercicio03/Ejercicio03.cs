using System;

namespace Ejercicio03
{
    class DivisionDeDosNúmeros
    {
        static void Main(String[] args)
        {
            int num1, num2;
            Console.WriteLine("Dime dos números");
            if (Int32.TryParse(Console.ReadLine(), out num1) || num1 !=0)
            {
                if (Int32.TryParse(Console.ReadLine(), out num2) || num2 !=0)
                {
                    Console.WriteLine("La división sería {0} y el resto {1}.", num1 / num2, num1 % num2);
                }
                else
                    Console.WriteLine("El valor {0} no es válido.", num2);
            }
            else
                Console.WriteLine("El valor {0} no es válido.", num1);
        }
    }
}
