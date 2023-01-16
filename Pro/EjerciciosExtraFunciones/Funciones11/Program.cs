using System;

namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            decimal[] num = new decimal[10];

            //pedimos 10 numeros decimales y los guardamos en el vector
            Console.WriteLine("Dime diez números");
            for (int i = 0; i < num.Length; i++)
            {
                while (!(Decimal.TryParse(Console.ReadLine(), out num[i])))
                    Console.WriteLine("Tienes que introducir un número válido");
            }
            //sacamos la media
            decimal media = Queryable.Average(num.AsQueryable());
            //escribimos el vector nuevo con los números que estén por encima de la media
            Console.Clear();
            Console.WriteLine("La media es {0} y los números que están por encima son: \n", media);
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > media)
                {
                    Console.WriteLine("\t" + num[i]);
                }
            }


        }
    }
}


