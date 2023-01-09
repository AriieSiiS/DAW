namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            //Dado un codigo ISBN saber si se válido o no (ej: 9783161484100)
            string frase = "";
            bool novalido = false;
            bool codigo = true;
            do
            {
                Console.WriteLine("Introduce tu frase");
                frase = Console.ReadLine();
                if (frase != "" && (frase.Length == 13))
                    novalido = true;
                else
                    Console.WriteLine("La cadena debe contener 13 números, vuelve a probar");
            } while (!novalido);

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] != '0' && (frase[i] != '1' && (frase[i] != '2' && (frase[i] != '3' && (frase[i] != '4' && (frase[i] != '5' && (frase[i] != '6' && (frase[i] != '7' && (frase[i] != '8' && (frase[i] != '9'))))))))))
                {
                    codigo = false;
                }
            }
            if (codigo == false)
                Console.WriteLine("El código no es válido");
            else
                Console.WriteLine("El código es válido");
        }
    }
}