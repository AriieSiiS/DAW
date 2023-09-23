using System;

namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            int num;
            Console.WriteLine("Dime un número entero");
            while (!(Int32.TryParse(Console.ReadLine(), out num)))
                Console.WriteLine("El número introducido no es correcto");
            int contador = num;
            bool primo = Funciones.NumPrimo(num, contador);

            if (primo == true)
                Console.WriteLine("El número es primo");
            else
                Console.WriteLine("El número no es primo");
                   
        }
    }
}


