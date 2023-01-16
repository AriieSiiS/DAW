namespace Ejercicio
{
    class Ejercicio
    {
        static void Main(String[] args)
        {
            int[] lista = new int[100];
            int num1 = 0;
            int j = 0;
            int suma = 0;
            int contador = 0;
            bool valido = true;
            Console.WriteLine("Escribe numeros, pulsa 0 para salir");
            Console.WriteLine("Escribe hasta 100 numeros o escribe 0 para salir");
            for (int i = 0; i < lista.Length; i++)
            {
                do
                {
                    valido = true;

                    {
                        Console.WriteLine("Escribe el siguiente número");
                        while (!(Int32.TryParse(Console.ReadLine(), out num1)))
                            Console.WriteLine("El número introducido no es válido");

                        if (num1 == 0)
                        {
                            valido = false;
                            i = 100;
                        }
                        else
                        {
                            lista[i] = num1;
                            suma += num1;
                            contador++;
                            //valido = true;
                        }
                    }
                } while (valido == true);
            }
            Console.WriteLine("La suma de todos los numeros es {0} y se han introducido {1} valores", suma, contador);



        }
    }
}

