using System;

namespace Ejercicio07
{
    class CambioDeUnidades
    {
        static void Main(String[] args)
        {
            /*   double MillasMarinas;
                 double Metros;
                 Console.WriteLine("Dime la distancia en millas marinas");
                 MillasMarinas = Convert.ToDouble(Console.ReadLine());
                 Metros = (MillasMarinas * 1852);
                 Console.WriteLine("La distancia en m es " + Metros);*/
            double MillasMarinas;
            int Metros;
            Console.WriteLine("Dime la distancia en millas marinas");
            MillasMarinas = Convert.ToDouble(Console.ReadLine());
            Metros = (int)Math.Floor(MillasMarinas * (1000 / 0.54));
            Console.WriteLine("La distancia en m es " + Metros);



        }
    }
}
