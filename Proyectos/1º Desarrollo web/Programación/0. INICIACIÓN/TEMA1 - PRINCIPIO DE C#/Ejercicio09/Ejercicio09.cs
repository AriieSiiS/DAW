using System;

namespace Ejercicio09
{
    class PrecioyPorcentaje
    {
        static void Main(String[] args)
        {
            double precio;
            double porcentaje;
            double preciofinal;
            Console.WriteLine("Dime el precio de la prenda");
            precio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dime el porcentaje de descuento");
            porcentaje = Convert.ToDouble(Console.ReadLine());
            porcentaje = precio * porcentaje / 100;
            preciofinal = precio - porcentaje;
            Console.WriteLine("El precio inicial era " + precio + " y con el descuento sería " + preciofinal);
        }
    }
}

