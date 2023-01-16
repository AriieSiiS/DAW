using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones02
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            
            Console.WriteLine("Dime una temperatura en grados Celcius");
            while (!(Int32.TryParse(Console.ReadLine(), out num) || num > 0))
                Console.WriteLine("El número introducido no es válido");
            Console.WriteLine("Escribe una F para pasar a grados Fahrenheit o una K para pasar a grados Kelvin");
            string letra = Console.ReadLine();
            if (letra == "K")
            {
                Funciones.Kelvin(num);
            }
            else if (letra == "F")
            {
                Funciones.Fahrenheit(num);
            }
            else
            {
                Console.WriteLine("Presiona una tecla para salir");
                Console.ReadKey();
            }
        }
        class Funciones
        {
            public static void Fahrenheit(int num)
            {
                Console.WriteLine("La temperatura en Fahrenheit sería: \n \t {0}ºF", num * 1.8 + 32);
            }

            public static void Kelvin(int num)
            {
                Console.WriteLine("La temperatura en Kelvin sería: \n \t {0}ºK", num + 273.15);
            }
        }

    }



}
