namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            //Quitar espacios a la izquierda y a la derecha
            string noespacios = "";
            char espacio = (char)32;
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

            int contador = frase.Length;
            while (frase[contador - 1] == espacio)
                contador--;
            for (int i = 0; i < contador; i++)
                noespacios += frase[i];

            frase = noespacios;
            contador = 0;
            noespacios = "";

            while (frase[contador] == espacio)
                contador++;
            while (contador < frase.Length)
            {
                noespacios += frase[contador];
                contador++;
            }
            frase = noespacios;
            Console.WriteLine(frase + " prueba");



        }
    }
}


