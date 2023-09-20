namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            //Dada una cadena por teclado, indicar cuáles son las vocales que contiene.
            string frase = "";
            Console.WriteLine("Escribe una frase");
            frase = Console.ReadLine();
            while (!(frase.Length > 0))
            {
                Console.WriteLine("Tienes que introducir una frase valida");
                frase = Console.ReadLine();
            }
            frase = frase.ToLower();
            for (int i = 0; i < frase.Length; i++)
            {
                if ((frase[i] == 'a') || (frase[i] == 'e') || (frase[i] == 'i') || (frase[i] == 111) || (frase[i] == 117))
                {
                    Console.WriteLine(frase[i]);
                }
            }
        }
    }
}
