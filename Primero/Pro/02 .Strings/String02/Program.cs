namespace Ejercicio
{
    class Ejercicio
    {
        static void Main(String[] args)
        {
            //Pedir una frase y una letra y encontrar cuantas veces sale esa letra en la frase 
            //variables
            int contador = 0;
            char letra;
            string frase;
            Console.WriteLine("Escribe una frase");
            frase = Console.ReadLine();
            while (!(frase.Length > 0))
            {
                Console.WriteLine("Tienes que introducir una frase valida");
                frase = Console.ReadLine();
            }
            Console.WriteLine("Escribe una letra");
            while (!(Char.TryParse(Console.ReadLine(), out letra)))
                Console.WriteLine("Tienes que introducir una letra valida");
            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == letra)
                {
                    contador++;
                }
            }
            Console.WriteLine("\t La letra {0} sale {1} veces", letra, contador);
        }
    }
}


