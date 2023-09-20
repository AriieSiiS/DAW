namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            //visualizar palabras una debajo de otra y contar las letras de cada palabra
            char espacio = (char)32;
            string frase = "";
            bool novalido = false;
            int contador = 0;
            string palabra = "";
            do
            {
                Console.WriteLine("Introduce tu frase");
                frase = Console.ReadLine() + " ";
                if (frase != "")
                    novalido = true;
                else
                    Console.WriteLine("La cadena debe tener texto, vuelve a probar");
            } 
            while (!novalido);

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == espacio)
                {
                    for (int j = contador; j < i; j++)
                    {
                        palabra += frase[j];
                        if ((palabra.Length) + contador == i)
                        {
                            Console.WriteLine("\t {0} tiene {1} letras", palabra, palabra.Length - 1);
                            contador = palabra.Length + contador;
                            palabra = "";
                        }

                    }
                }
            }


        }
    }
}


