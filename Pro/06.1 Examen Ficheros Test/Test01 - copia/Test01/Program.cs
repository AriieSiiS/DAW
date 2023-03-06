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
            List<decimal> SumaPesos = CSContenedores.PesosContenedores(destinos, pesos);
            List<string> Contenedores = CSContenedores.DestinosContenedores(destinos, pesos);
            decimal contenedorestotales;
            int indexpeso = 0;
            foreach (string contenedor in Contenedores) 
            {
                Console.WriteLine($"El destino {contenedor} lleva {SumaPesos[indexpeso]} kg");
                contenedorestotales = SumaPesos[indexpeso] / 1200;
                if  (contenedorestotales > 1)
                {
                    Console.WriteLine("\n Se necesitarán {0}", Math.Round(contenedorestotales));
                }
                else
                    Console.WriteLine("Solo se necesitará un contenedor");
                Console.WriteLine("");
                indexpeso++;
                
            }
                
            
            


        }
    }
}


