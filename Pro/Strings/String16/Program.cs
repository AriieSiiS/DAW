namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            //mostrar si es palindromo o no
            string frase = "";
            string alreves = ""; 
            bool novalido = false;
            do
            {
                Console.WriteLine("Introduce tu frase");
                frase = Console.ReadLine();
                if (frase != "")
                    novalido = true;
                else
                    Console.WriteLine("La cadena debe tener texto, vuelve a probar");
            } while (!novalido);
             
            for (int i = frase.Length - 1; i >= 0; i--)
                alreves += frase[i];
            if (alreves == frase)
                Console.WriteLine("La cadena es palindroma");
            else
                Console.WriteLine("La cadena no es palindroma");

        }
    }
}


