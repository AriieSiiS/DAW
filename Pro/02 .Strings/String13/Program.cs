namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            //elimina los espacios a la izquierda
            string frase = "";
            string noespacios = "";
            char espacio = (char)32;
            int contador = 0;
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


            while (frase[contador] == espacio)
                contador++;

            while (contador < frase.Length)
            {
                noespacios += frase[contador];
                contador++;
            }
            Console.WriteLine(noespacios);

        }
    }
}


