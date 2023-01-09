namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            //determina cuantas mayusculas y cuantas minisculas
            string frase = "";
            string fraseauxiliar = "";
            int contadorminus = 0;
            int contadormayus = 0;
            int letra = 0;
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

            frase = frase.Replace(" ", "");

            while (letra < frase.Length)
            {
                fraseauxiliar = frase.ToLower();
                if (frase[letra] == fraseauxiliar[letra])
                    contadorminus++;
                letra++;
            }

            letra = 0;

            while (letra < frase.Length)
            {
                fraseauxiliar = frase.ToUpper();
                if (frase[letra] == fraseauxiliar[letra])
                    contadormayus++;
                letra++;
            }
            Console.WriteLine("\t La frase contiene {0} minisculas", contadorminus);
            Console.WriteLine("\t La frase contiene {0} mayusculas", contadormayus);
        }
    }
}