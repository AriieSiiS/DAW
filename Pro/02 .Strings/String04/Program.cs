namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            //introducir la cadena del ejercicio anterior y guardarla en una variable

            string frase = "";
            Console.WriteLine("Escribe una frase");
            frase = Console.ReadLine();
            while (!(frase.Length > 0))
            {
                Console.WriteLine("Tienes que introducir una frase valida");
                frase = Console.ReadLine();
            }
            string alreves = "";
            for (int i = frase.Length - 1; i >= 0; i--)
            {
                alreves += frase[i];
            }
            Console.WriteLine(alreves);
        }
    }
}


