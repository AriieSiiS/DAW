namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            bool leido = false;
            string? cadena = "";
            string objetivo = "";
            do
            {
                Console.Write("Introduce la cadena: ");
                cadena = Console.ReadLine();
                if (cadena != "")
                {
                    leido = true;
                }
                else
                {
                    Console.WriteLine("\nCadena vacía. Prueba de nuevo");
                }
            } while (!leido);

            leido = false;

            do
            {
                Console.Write("Introduce la cadena objetivo a buscar: ");
                objetivo = Console.ReadLine();
                if (objetivo != "")
                {
                    leido = true;
                }
                else
                {
                    if (cadena.Length < objetivo.Length)
                    {
                        Console.WriteLine("\nCadena objetivo es más larga que la cadena de partida. Prueba de nuevo");
                    }
                    else
                    {
                        Console.WriteLine("\nCadena objetivo vacía. Prueba de nuevo");
                    }
                }
            } while (!leido);

            bool encontrado = false; //Se pone a true
            bool final = false;
            int contador = 0;
            while (!final)
            {
                if (contador > (cadena.Length - objetivo.Length))
                {
                    final = true;
                }
                else
                {
                    if (cadena[contador] == objetivo[0])
                    {
                        int posicion = contador;
                        int posobjetivo = 0;
                        bool recorre = true;
                        while (recorre)
                        {
                            if (cadena[posicion] == objetivo[posobjetivo])
                            {
                                posicion++;
                                posobjetivo++;
                                if (posobjetivo == objetivo.Length - 1)
                                {
                                    recorre = false;
                                    encontrado = true;
                                    final = true;
                                }
                            }
                            else
                            {
                                recorre = false;
                            }
                        }
                    }
                }
                contador++;
            }

            if (encontrado)
            {
                Console.WriteLine("\nLa cadena \"{0}\" contiene a la cadena \"{1}\".", cadena, objetivo);
            }
            else
            {
                Console.WriteLine("La cadena \"{0}\" no contiene a la cadena \"{1}\"", cadena, objetivo);
            }

            Console.WriteLine("Pulse una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}


