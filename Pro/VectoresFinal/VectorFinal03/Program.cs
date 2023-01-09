using System;

namespace Ejercicio
{
    class Ejercicio
    {
        static void Main(String[] args)
        {
            string numeros = "1234567890";
            string numerosusuario;
            bool check = false;
            string comprobnum = "";
            int contador = 0;

            //pedimos los diez numeros
            Console.WriteLine("Escribe diez números entre 1 y 20, separando cada número con un espacio");
            numerosusuario = Console.ReadLine();
            while (check == false)
            {
                check = true;
                for (int i = 0; i < numerosusuario.Length; i++)
                {
                    if (numerosusuario[i] != ' ')
                    {
                        for (int j = 0; j < numeros.Length; j++)
                        {
                            if (numerosusuario[i] != numeros[j])
                                check = false;
                            else 
                            {
                                check = true;
                                if (numerosusuario[i + 1] != ' ')
                                {
                                    comprobnum += numerosusuario[i];
                                    comprobnum += numerosusuario[i + 1];
                                    int comprobnumero = Convert.ToInt32(comprobnum);
                                    if (comprobnumero > 20 || comprobnumero < 1)
                                    {
                                        check = false;
                                    }
                                    else
                                    {
                                        Console.Write("{0}\t",comprobnumero);
                                        for (int x = 0; x < comprobnumero; x++)
                                        {
                                            Console.Write("*");
                                        }
                                        comprobnumero = 0;
                                        comprobnum = "";
                                        i += 2;
                                        Console.WriteLine();
                                    }
                                }
                                else
                                {
                                    comprobnum += numerosusuario[i];
                                    int comprobnumero = Convert.ToInt32(comprobnum);
                                    if (comprobnumero < 0)
                                    {
                                        check = false;
                                    }
                                    else
                                    {
                                        Console.Write("{0}\t", comprobnumero);
                                        for (int x = 0; x < comprobnumero; x++)
                                        {
                                            Console.Write("*");
                                        }
                                        comprobnumero = 0;
                                        comprobnum = "";
                                        Console.WriteLine();
                                    }
                                }
                            }
                        }
                    }
                    if (numerosusuario[i] == ' ')
                    {
                        contador++;
                        if (contador > 9)
                            check = false;
                    }
                }
                if (check = false || contador == 9)
                {
                    Console.WriteLine("Los números introducidos no son válidos");
                }
            }






        }
    }
}

