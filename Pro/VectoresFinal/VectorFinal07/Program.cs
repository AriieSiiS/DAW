using System;

namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            // declaramos las variables
            int tamañovector;
            int[] vectorinicial;
            int limitesuperior;
            int limiteinferior;
            int nuevovalor;
            int posvector;
            Random random = new Random();

            //pedimos el tamaño del vector y lo establecemos
            Console.WriteLine("Dime cuantos elementos quieres que tenga el vector");
            while (!(int.TryParse(Console.ReadLine(), out tamañovector)) || tamañovector < 0)
                Console.WriteLine("Tienes que introducir un número válido");
            vectorinicial = new int[tamañovector];
            //pedimos el limite superior e inferior
            Console.WriteLine("Dime el limite inferior");
            while (!(Int32.TryParse(Console.ReadLine(), out limiteinferior)))
                Console.WriteLine("El número introducido no es válido");
            Console.WriteLine("Dime el limite superior");
            while (!(Int32.TryParse(Console.ReadLine(), out limitesuperior)) || limitesuperior <= limiteinferior)
                Console.WriteLine("El número introducido no es válido");
            //rellenamos el vector
            for (int i = 0; i < vectorinicial.Length; i++)
            {
                vectorinicial[i] = random.Next(limiteinferior,limitesuperior);
            }
            //pedimos un valor nuevo y una posición que entre en los limites del vector
            Console.WriteLine("Dime un número que entre dentro de los límites");
            while (!(Int32.TryParse(Console.ReadLine(), out nuevovalor)) || nuevovalor <= limiteinferior || nuevovalor >= limitesuperior)
                Console.WriteLine("El número introducido no es válido");

            Console.WriteLine("Dime una posición del vector");
            while (!(Int32.TryParse(Console.ReadLine(), out posvector)) || posvector >= tamañovector)
                Console.WriteLine("El número introducido no es válido");

            int[] vectorinicialcopia = new int[vectorinicial.Length+1];   
            for (int i = 0; i < vectorinicial.Length; i++)
            {
                if (i != posvector)
                    vectorinicialcopia[i] = vectorinicial[i];
            }
            vectorinicialcopia[posvector] = nuevovalor;
            Console.WriteLine();
            Console.WriteLine("Vector inicial:");
            for (int i = 0; i < vectorinicial.Length; i++)
            {
                Console.Write("\t{0}", vectorinicial[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Vector final:");
            for (int i = 0; i < vectorinicialcopia.Length; i++)
            {
                Console.Write("\t{0}", vectorinicialcopia[i]);
            }
        }
    }
}


