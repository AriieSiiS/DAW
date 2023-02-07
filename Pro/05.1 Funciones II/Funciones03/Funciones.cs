namespace Ejercicio
{
    internal class Funciones
    {
        public static int[] ArrayAleatorio(int Tamaño)
        {
            int[] Aleatorio = new int[Tamaño];
            Random Random = new Random();
            for (int i = 0; i < Aleatorio.Length; i++)
            {
                Aleatorio[i] = Random.Next(0, 100);
            }
            return Aleatorio;
        }
    }
}
