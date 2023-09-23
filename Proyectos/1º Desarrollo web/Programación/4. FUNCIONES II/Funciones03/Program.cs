namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            const int Tamaño = 10;
            int[] Aleatorio = Funciones.ArrayAleatorio(Tamaño);
            for (int i = 0; i < Aleatorio.Length; i++)
            {
                Console.WriteLine("\t {0}", Aleatorio[i]);
            }
        }
    }
}


