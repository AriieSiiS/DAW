namespace Ejercicio
{
    class Ejercicio
    {
        static void Main(String[] args)
        {
            char[] lista = new char[100];
            Random random = new Random();
            int letra=65;
            int contador = 0;
            int contadortotal = 0;
            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = (char)random.Next(65, 91);

                //Console.WriteLine((char)random.Next(65,90));
            }
            for (letra = 65; letra < 91; letra++)
            {
                contadortotal = 0;
                for (int j = 0; j < lista.Length; j++)
                {
                    if (lista[j] == (char)letra)
                    {
                        contadortotal++;
                        Console.WriteLine("La letra {0} aparece {1} veces", lista[j], contadortotal);
                    }
                }
            }
        }
    }
}


