using System;

namespace Ejercicio05
{
    class Par_o_Impar
    {
        static void Main(String[] args)
        {
            int num1;
            string entrada1;
            Console.WriteLine("Dime un número");
            entrada1 = Console.ReadLine();
            if (Int32.TryParse(entrada1, out num1))
            {
                if (num1 % 2 == 0)
                {
                    Console.WriteLine("El número es par");
                }
                else
                {
                    Console.WriteLine("El número es impar");
                }
            }
            else
            {
                Console.WriteLine("El valor {0} no es válido.", entrada1);
            }
        }
    }
}
