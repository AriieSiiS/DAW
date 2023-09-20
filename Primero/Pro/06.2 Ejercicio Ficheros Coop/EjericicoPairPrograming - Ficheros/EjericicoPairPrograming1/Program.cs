using System.Security.Cryptography.X509Certificates;
using EjericicioPairPrograming;

namespace EjercicioPairPrograming   
{
    //Comparar 2 txt
    //Contar lineas iguales
    //Lineas diferentes en otro txt

    class Program
    {
        private static void Main(string[] args)
        {
            const string ruta1 = "..\\..\\..\\1.txt";
            const string ruta2 = "..\\..\\..\\2.txt";
            const string ruta3 = "..\\..\\..\\diferencias.txt";
            List<string> lineasRuta1 = new List<string>();
            List<string> lineasRuta2 = new List<string>();
            int size;


            if (!File.Exists(ruta1) || !File.Exists(ruta2))
            {
                Console.WriteLine("Alguno de los archivos no existe");
            }
            else
            {                
                Utils.LeerLineas(ruta1, lineasRuta1);
                Utils.LeerLineas(ruta2, lineasRuta2);

                size = Utils.IgualarTamañoLineas(lineasRuta1, lineasRuta2);

                Utils.EscribirLineas(ruta3,lineasRuta1, lineasRuta2, size);
            }           
        }
    }
}


