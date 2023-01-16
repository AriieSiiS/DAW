namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            //decir si el numero es capicua o no
            string frase = "";
            string capicua = "";
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
                capicua += frase[i];
            if (capicua == frase)
                Console.WriteLine("La cadena es capicua");
            else
                Console.WriteLine("La cadena no es capicua");

        }
    }
}


