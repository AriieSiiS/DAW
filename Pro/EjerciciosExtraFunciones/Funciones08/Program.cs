using System;

namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            bool seguir = false;
            int comprobacion;
            //pedimos los diez números y los metemos un array

            while (seguir == false)
            {
                Console.Clear();
                Console.WriteLine("Escribe diez numeros entre el 1 y el 20 separados por espacios");
                seguir = true;
                string frasesusuario = Console.ReadLine();
                string[] numerousuario = frasesusuario.Split(' ');
                if (numerousuario.Length > 9)
                {
                    Console.WriteLine("Solo puedes introducir diez números, presiona una tecla para intentarlo de nuevo");
                    Console.ReadKey();
                    seguir = false;
                }
                else
                {
                    for (int i = 0; i < numerousuario.Length; i++)
                    {
                        comprobacion = Convert.ToInt32(numerousuario[i]);
                        if (comprobacion < 1 || comprobacion > 20)
                        {
                            Console.WriteLine("El número no puede ser menor que 1 o mayor que 20, presiona una tecla para intentarlo de nuevo");
                            
                            seguir = false;
                            i = numerousuario.Length;
                        }
                        else
                        {
                            Console.Write("{0} \t",comprobacion);
                            for (int j = 0; j < comprobacion; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                    }
                }

            }




            
        }
    }
}


