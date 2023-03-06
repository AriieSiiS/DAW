using System.Drawing;

namespace PProgramingFile
{
    class Ejercicio2
    {
        private static void Main(string[] args)
        {
            string phat1 = "..\\..\\..\\";
            int numLine = OutData.OutIntRango();
            List<string> lines = new List<string>();
            phat1 += OutData.OutString();
            if (!File.Exists(phat1))
            {
                Console.WriteLine("El archivo a leer no existe");
            }
            else
            {

                Function.SacarLinea(phat1, lines);
                Function.Mostrar(lines, numLine);
            }
        }
    }
}
