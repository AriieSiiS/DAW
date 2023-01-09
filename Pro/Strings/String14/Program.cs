namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            //elimina los espacios a la derecha
            string frase = "";
            string noespacios = "";
            char espacio = (char)32;
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


            /*while (contador < frase.Length)
            {
                noespacios += frase[contador];
                contador++;
            }*/

            Console.WriteLine(noespacios + "prueba");
        }
    }
}


