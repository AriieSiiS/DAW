using System;

namespace Ejercicio02
{
    class RestaConCondicional
    {
        static void Main(String[] args)
        {
            int num1, num2;
            string entrada1, entrada2;
            Console.WriteLine("Dime dos números");
            entrada1 = Console.ReadLine();
            entrada2 = Console.ReadLine();
            if (Int32.TryParse(entrada1, out num1) && (Int32.TryParse(entrada2, out num2)))
            {
                if (num1 - num2 >= 0)
                {
                    Console.WriteLine("La resta da {0}", num1 - num2);
                }
                else
                {
                    Console.WriteLine("La resta da {0}", num2 - num1);
                }
            }
            else
            {
                Console.WriteLine("Los valores {0} o {1} no son válidos.", entrada1, entrada2);
            }

        }
    }
}

