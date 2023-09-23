using System;

namespace Ejercicio01
{
    class Ejercicio_A_Entregar
    {
        static void Main(String[] args)
        {
            double precio = 34.2;
            int entrada;
            double descuento = 0;
            double precioFinal;
            Console.WriteLine("Dime el número de entradas");
            if (Int32.TryParse(Console.ReadLine(), out entrada))
            {
                precioFinal = Convert.ToDouble((entrada) * precio);
                if ((entrada <= 4) && (entrada >= 1))
                {
                    if (entrada == 1)
                    {
                        Console.WriteLine("El precio de la entrada será {0} euros.", precio);
                    }
                    else
                    {
                        if (entrada == 2)
                        {
                            descuento = precioFinal * 5 / 100;
                            Console.WriteLine("El precio de la entrada será {0} euros.", precioFinal - descuento);
                        }
                        else
                        {
                            if (entrada == 3)
                            {
                                descuento = precioFinal * 10 / 100;
                                Console.WriteLine("El precio de la entrada será {0} euros.", precioFinal - descuento);
                            }
                            else
                            {
                                descuento = precioFinal * 20 / 100;
                                Console.WriteLine("El precio de la entrada será {0:f2} euros.", precioFinal - descuento);
                            }
                        }
                    }
                }
                else
                    Console.WriteLine("No se pueden adquirir más de cuatro entradas o menos de una entrada");
            }
            else
                Console.WriteLine("El número de entradas tiene que ser un número entero");
        }
    }
}
