using System;

namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            //Solicitamos el número de casas
            int NCasas = Funciones.SolicitarCasas();
            //Solicitamos los datos de las casas(nombre y costo)
            var (Casas, Costo) = Funciones.SolicitarDatos(NCasas);
            //Creamos la lista de casas dentro de los limites que le pedimos al usuario, y la guardamos en una variable
            string[] Casasenrango = Funciones.ListadoLimitado(Casas, Costo);
            //Solicitamos el nombre de una casa y guardamos en una variable las que tengan menor precio
            int MenorPrecio = Funciones.CasasMenorPrecio(Casas, Costo);
            //Mostramos el resultado por pantalla
            Console.WriteLine("Las casas que entran en ese rango de precios son:");
            for (int i = 0; i < Casasenrango.Length; i++)
            {
                Console.WriteLine("\t{0}", Casasenrango[i]);
            }
            Console.WriteLine("\nEl número de casas con menor precio que la casa elegida son: \t{0}", MenorPrecio);
        }
    }
}


