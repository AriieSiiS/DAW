namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            //Dada una cadena por teclado, contar el número de vocales que tiene
            string frase = "";
            Console.WriteLine("Escribe una frase");
            frase = Console.ReadLine();
            while (!(frase.Length > 0))
            {
                Console.WriteLine("Tienes que introducir una frase valida");
                frase = Console.ReadLine();
            }
            frase = frase.ToLower();
            int contar = 0;
            for (int i = 0; i < frase.Length; i++)
            {
                if ((frase[i] == 'a') || (frase[i] == 'b') || (frase[i] == 'c') || (frase[i] == 111) || (frase[i] == 117))
                {
                    contar++;
                }
            }
            Console.WriteLine(contar);
        }
    }
}
