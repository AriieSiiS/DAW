using System;

namespace Ejercicio
{
    class Ejercicio
    {
        static void Main(String[] args)
        {
            int num1;
            bool primo = true;
            Console.WriteLine("Dime un número");
            while(!int.TryParse(Console.ReadLine(),out num1) || (num1 < 1))
                Console.WriteLine("El número introducido no es correcto");
            for (int i = num1-1; i > 1; i--)
            {
                if (num1 % i == 0)
                {
                    primo = false;
                }
            }
            if (primo == true)
                Console.WriteLine("El número es primo");
            else
                Console.WriteLine("El número no es primo");
        }
    }
}



