namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            //intercambia el orden de los caracteres de dos en dos
            string frase = "";
            string frasefinal = "";
            string auxiliar = "";
            bool novalido = false;
            do
            {
                Console.WriteLine("Introduce tu frase");
                frase = Console.ReadLine();
                if (!(frase.Length < 2))
                    novalido = true;
                else
                    Console.WriteLine("La cadena debe tener al menos dos caracteres, vuelve a probar");
            } while (!novalido);

            if (frase.Length % 2 == 1)
            {
                for (int i = frase.Length - 1; i < frase.Length; i++)
                    auxiliar += frase[i];
            }

            for (int j = 0; j < frase.Length - 1; j++)
            {
                string frase1 = "";
                string frase2 = "";
                frase1 += frase[j];
                frase2 += frase[j + 1];
                frasefinal += frase2 + frase1;
                j = j + 1;
            }
            frasefinal += auxiliar;

            Console.WriteLine(frasefinal);
        }
    }
}


