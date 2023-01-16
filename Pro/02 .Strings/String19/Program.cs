namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            int contador = 0;
            char caracter;
            string frase = "";
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
            Console.WriteLine("Escribe una letra");
            while (!(Char.TryParse(Console.ReadLine(), out caracter)))
                Console.WriteLine("Tienes que introducir una letra valida");
            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == caracter)
                    contador++;
            }
            Console.WriteLine(contador);
        }
    }
}


