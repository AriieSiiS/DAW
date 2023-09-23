using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class Funciones
    {
        public static int SolicitarCasas()
        {
            int NCasas;
            Console.WriteLine("Dime el número de casas");
            while (!(Int32.TryParse(Console.ReadLine(), out NCasas)) || (NCasas > 30) || (NCasas < 1))
                Console.WriteLine("Tienes que introducir un número valido");
            Console.Clear();
            return NCasas;
        }
        public static (string[],double[]) SolicitarDatos(int NCasas)
        {
            string[] Casas = new string[NCasas];
            double[] Costo = new double[NCasas];

            for (int i = 0; i < NCasas; i++)
            {
                string NombreCasa = "";
                double PrecioCasa;

                Console.WriteLine("Dime el nombre de la casa {0}.", i+1);
                while (NombreCasa == "")
                {
                    NombreCasa = Console.ReadLine();
                    if (NombreCasa == "")
                        Console.WriteLine("El nombre no puede estar vacío");
                    else
                    {
                        Casas[i] = NombreCasa;

                        for (int j = 0; j < i; j++)
                        {
                            if (NombreCasa == Casas[j])
                            {
                                Console.WriteLine("El nombre no puede estar repetido");
                                NombreCasa = "";
                            }
                        }
                    }   
                }
                Console.WriteLine("Dime el precio de la casa {0}.", i + 1);
                while (!(Double.TryParse(Console.ReadLine(), out PrecioCasa)) || (PrecioCasa < 0))
                    Console.WriteLine("El precio tiene que ser mayor que 0");
                Costo[i] = PrecioCasa;
                Console.Clear();
            }
            return (Casas,Costo);
        }

        public static (int,int) SolicitarLimite()
        {
            int LimiteInferior;
            int LimiteSuperior;
            Console.WriteLine("Dime un límite de precio inferior");
            while (!(Int32.TryParse(Console.ReadLine(), out LimiteInferior)) || (LimiteInferior < 0))
                Console.WriteLine("Tienes que introducir un número valido");
            Console.WriteLine("Dime un límite de precio superior");
            while (!(Int32.TryParse(Console.ReadLine(), out LimiteSuperior)) || (LimiteSuperior < LimiteInferior))
                Console.WriteLine("Tienes que introducir un número valido");
            return (LimiteInferior, LimiteSuperior);
        }


        public static string[] ListadoLimitado(string[] Casas, Double[] Costo)
        {
            int[] Posicionesdecasas = new int[0];
            int contador = 0;
            var (LimiteInferior, LimiteSuperior) = Funciones.SolicitarLimite();

            for (int i = 0; i < Costo.Length; i++)
            {
                if (Costo[i] >= LimiteInferior && Costo[i] <= LimiteSuperior)
                {

                    Array.Resize(ref Posicionesdecasas, Posicionesdecasas.Length + 1);
                    Posicionesdecasas[contador] = i;
                    contador++;

                }
            }
            contador = 0;
            string[] Casasenrango = new string[Posicionesdecasas.Length];

            for (int i = 0; i < Posicionesdecasas.Length; i++)
            {
                contador = Posicionesdecasas[i];
                Casasenrango[i] = Casas[contador];

            }
            Console.Clear();
            return Casasenrango;
        }

        public static int CasasMenorPrecio(string[] Casas, Double[] Costo)
        {
            int NCasas = 0;
            bool Sigue = true;
            int contador = -1;
            double Precio;

            while (Sigue)
            {
                Console.Write("Dime el nombre de una de las casas,");
                Console.Write(" se mostrará una lista de las casas que tengan menor precio");
                Console.WriteLine();
                string NombreCasa = Console.ReadLine();

                while (contador < Casas.Length-1 && (Sigue))
                {
                    contador++;
                    if (NombreCasa == Casas[contador])
                    {
                        Sigue = false;
                    }
                }
                if (Sigue)
                {
                    Console.WriteLine("El nombre introducido no es válido, presiona una tecla para intentarlo de nuevo");
                    Console.ReadKey();
                    Console.Clear();
                    contador = -1;
                }
            }
            Precio = Costo[contador];

            for (int i = 0; i < Costo.Length; i++)
            {
                if (Costo[i] < Precio)
                {
                    NCasas++;
                }
            }

            return NCasas;

        }
    }
}
