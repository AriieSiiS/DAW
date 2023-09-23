
using System;

namespace Ejercicio_2
{
    class Ejercicio
    {
        static void Main(String[] args)
        {
            int invitados;
            int tarta;
            int pisos = 12;
            // podemos cambiar el valor, en este caso 12, para variar el número de comensales por tarta

            Console.WriteLine("Dime el número de invitados");
            if (Int32.TryParse(Console.ReadLine(), out invitados))
            {
                if (invitados >= 1)
                {
                    tarta = invitados / pisos;
                    if (invitados < pisos)
                    {
                        Console.WriteLine("El número de pisos que debe tener la tarta es 1 y la gente podría repetir.");
                    }
                    else
                    {
                        if (invitados%12==0)
                        {
                            Console.WriteLine("El número de pisos que debe tener la tarta es {0} pisos.", tarta);
                        }
                        else
                            Console.WriteLine("El número de pisos que debe tener la tarta es {0} pisos.", tarta+1);
                    }
                }
                else
                {
                    Console.WriteLine("El número de invitados tiene que ser mínimo 1");
                }
            }
            else
            {
                Console.WriteLine("El número de invitados tiene que ser un número entero");
            }
                
        }
    }
}




