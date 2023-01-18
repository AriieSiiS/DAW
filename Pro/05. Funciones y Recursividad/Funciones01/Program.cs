using System;

namespace Funciones01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal celcius;
            Console.WriteLine("Dime una temperatura en grados Celcius");
            while (!(Decimal.TryParse(Console.ReadLine(), out celcius) || celcius > 0))
                Console.WriteLine("El número introducido no es válido");
            Console.Clear();
            Console.WriteLine("La temperatura en Fahrenheit sería: \n \t {0}ºF", Funciones.Fahrenheit(celcius));
            Console.WriteLine("La temperatura en Kelvin sería: \n \t {0}ºK", Funciones.Kelvin(celcius));
            Console.WriteLine();
        }
    }
    class Funciones
    {
        public static decimal Fahrenheit(decimal celcius)
        {
            return (celcius * 1.8m) + 32;
            //Console.WriteLine("La temperatura en Fahrenheit sería: \n \t {0}ºF", celcius * 1.8 + 32);
        }
        public static decimal Kelvin(decimal celcius)
        {
            return (celcius + 273.15m);
            //Console.WriteLine("La temperatura en Kelvin sería: \n \t {0}ºK", celcius + 273.15);
        }
    }
}

