using System;

namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            //declaramos las variables 
            string DNInumeros = "1234567890";
            string DNIletras = "TRWAGMYFPDXBNJZSQVHLCKE";
            string DNIn = "";
            bool check = false;
            string NumDNI = "";

            //pedimos los números y la letra del DNI
            Console.WriteLine("Introduce tu DNI");
            while  (check == false)
            {
                check = true;
                DNIn = Console.ReadLine();
                int contadorNumero = 0;
                int contadorLetra = 0;

                if (DNIn.Length == 9)
                {
                    for (int i = 0; i < DNIn.Length-1; i++)
                    {
                        NumDNI += DNIn[i];
                        for (int j = 0; j < DNInumeros.Length; j++)
                        {
                            if (DNIn[i] == DNInumeros[j])
                                contadorNumero++;
                        }
                    }
                    //sacamos el resto de dividir los numeros del DNI entre 23
                    int IntNumDNI = Convert.ToInt32(NumDNI);
                    int resto = IntNumDNI % 23;

                    if (contadorNumero == DNIn.Length-1)
                    {
                        for (int j = 0; j < DNIletras.Length; j++)
                        {
                            if (DNIn[DNIn.Length-1] == DNIletras[j])
                            {
                                contadorLetra++;
                                if (DNIletras[resto] == DNIn[DNIn.Length - 1])
                                    Console.WriteLine("El DNI introducido es correcto");
                                else
                                    Console.WriteLine("El DNI introducido no es válido");
                            }
                        }
                        if (contadorLetra !=1)
                        {
                            check = false;
                            Console.WriteLine("El DNI introducido no es correcto, prueba de nuevo");
                        }
                    }
                    else
                    {
                        check = false;
                        Console.WriteLine("El DNI introducido no es correcto, prueba de nuevo");
                    }
                }
                else
                {
                    check = false;
                    Console.WriteLine("El DNI introducido no es correcto, prueba de nuevo");
                }
            }
        }
    }
}


