namespace Ejercicio
{
    class Ejercicio
    {
        static void Main(String[] args)
        {
            //comparar dos cadenas para ver si en la primera está el texto de la segunda
            //variables
            string frase = "";
            bool esvalido = true;
            do
            {
                Console.WriteLine("Introduce tu frase");
                frase = Console.ReadLine();
                if (frase != "")
                    esvalido = false;
                else
                    Console.WriteLine("La cadena debe texto, vuelve a probar");
            } while (!esvalido);
        }
    }
}



