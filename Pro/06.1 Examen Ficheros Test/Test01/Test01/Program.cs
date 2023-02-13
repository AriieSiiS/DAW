using System;

namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            //primera parte
            string[] destinos = new string[0];
            decimal[] pesos = new decimal[0];
            string destino = "";
            int contador = 0;
            while (destino != "0")
            {
                Console.WriteLine("Dime el nombre del destino o escribe 0 para salir");
                destino = CSMercancias.ComprobarDestinos();
                if (destino != "0")
                {
                    Array.Resize(ref destinos, destinos.Length+1);
                    Array.Resize(ref pesos, pesos.Length + 1);
                    destinos[contador] = destino;
                    decimal peso = CSMercancias.ComprobarPesos();
                    pesos[contador] = peso;
                    contador++;
                }
            }
            CSMercancias.MostrarDatos(destinos, pesos);
            //segunda parte
            List<string> destinosContenedores = CSContenedores.DestinosContenedores(destinos);
        }
    }
}


