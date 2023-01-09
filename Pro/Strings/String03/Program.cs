namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            //darle la vuelta a una cadena
            string frase = "";
            Console.WriteLine("Escribe una frase");
            frase = Console.ReadLine();
            while (!(frase.Length > 0))
            {
                Console.WriteLine("Tienes que introducir una frase valida");
                frase = Console.ReadLine();
            }
            for (int i = frase.Length - 1; i >= 0; i--)
                Console.WriteLine("\t{0}", frase[i]);
        }
    }
}


