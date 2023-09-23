using System;

namespace Ejercicio10
{
    class CentenasDeUnNumero
    {
        static void Main(String[] args)
        {
            int num1;
            Console.WriteLine("Dime un numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            num1 = num1 / 100;
            num1 = num1 % 10;
            Console.WriteLine("Las centenas serían " + num1);
        }
    }
}




