
using System;

namespace Ejercicio08
{
    class PorcentajeDeUnaCantidad
    {
        static void Main(String[] args)
        {
            double num1;
            double num2;
            double porcentaje;
            Console.WriteLine("Dime una cantidad");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dime un porcentaje");
            num2 = Convert.ToDouble(Console.ReadLine());
            porcentaje = num1 * (num2 / 100);
            Console.WriteLine("El " + num2 + "% de " + num1 + " es " + porcentaje);

        }
    }
}
