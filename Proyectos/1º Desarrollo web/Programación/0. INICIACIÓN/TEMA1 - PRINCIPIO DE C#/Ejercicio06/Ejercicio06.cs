using System;

namespace Ejercicio06
{
    class DeSegundosToHoras 
    {
        static void Main(String[] args)
        {
            int segundos;
            int minutos;
            int horas;
            Console.WriteLine("Dime un número de segundos");
            segundos = Convert.ToInt32(Console.ReadLine());
            horas = (segundos / 3600);
            minutos = (segundos % 3600) / 60;
            segundos = segundos % 60;
            Console.WriteLine("Serían " + horas + " horas y " + minutos + " minutos y " + segundos + " segundos.");
        }
    }
}
