using System;

namespace Ejercicio
{
    class Ejercicio
    {
        static void Main(String[] args)
        {
            //variables
            string frase;
            string vocales = "aeiou";
            int contador = 0;
            //pedimos la frase
            Console.WriteLine("Escribe una frase");
            frase = Console.ReadLine();
            frase = frase.ToLower();

            //usamos Contains para contar el número de vocales
            /*for (int i = 0; i < frase.Length; i++)
            {
                if (vocales.Contains(frase[i]))
                {
                    contador++;
                }
            }*/

            foreach (char vocal in vocales)
            {
                if (frase.Contains(vocal))
                    Console.WriteLine("Contiene la {0}",vocal);
            }

            //escribimos el resultado
            //Console.WriteLine("La frase contiene {0} vocales.",contador);

        }
    }
}

