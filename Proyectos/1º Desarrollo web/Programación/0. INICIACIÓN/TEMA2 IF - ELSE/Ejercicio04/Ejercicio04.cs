using System;

namespace Ejercicio04
{
    class PositivoONegativo
    {
        static void Main(String[] args)
        {
            float num1;
            Console.WriteLine("Dime un número");
            if (float.TryParse(Console.ReadLine(), out num1))
            {
               if (num1 > 0)
                {
                    Console.WriteLine("El número es positivo");
                }
               else
                {
                    if (num1 == 0)
                    {
                        Console.WriteLine("El número es igual a 0");
                    }    
                    else
                    {
                        Console.WriteLine("El número es negativo");
                    }
                }
            }
            else
            {
                Console.WriteLine("El valor {0} no es válidos.", num1);
            }
        }
    }
}
