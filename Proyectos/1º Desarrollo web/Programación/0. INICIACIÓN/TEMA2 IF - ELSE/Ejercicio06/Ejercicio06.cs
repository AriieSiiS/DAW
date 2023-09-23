using System;

namespace Ejercicio06
{
    class NotasDeAlumnos
    {
        static void Main(String[] args)
        {
            float nota;
            string entrada1;
            Console.WriteLine("Dime tu nota");
            entrada1 = Console.ReadLine();
            
            if (float.TryParse(entrada1, out nota))
            {
                if (!((nota > 10) || (nota < 0)))
                {
                    if (nota < 4.99)
                    {
                        Console.WriteLine("{0} es un suspenso", nota);
                    }
                    else
                    {
                        if ((nota >= 5) && (nota < 6))
                        {
                            Console.WriteLine("{0} es un aprobado", nota);
                        }
                        else
                        {
                            if ((nota >= 6) && (nota < 7))
                            {
                                Console.WriteLine("{0} es un bien", nota);
                            }
                            else
                                Console.WriteLine("{0} es un notable o sobresaliente", nota);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("El valor {0} es mayor que diez o menor que 0, y no es valido.", entrada1);
                }
            }
            else
            {
                Console.WriteLine("El valor {0} no es válido.", entrada1);
            }
        }
    }
}
