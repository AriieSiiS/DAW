using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class Ejercicio
    {
        public const string FilePokemon = "..\\..\\..\\pokemon.csv";
        static void Main(String[] args)
        {
            //primera función que devuelve el pokemon con mas ataque

            //pedimos la generación y la validamos
            int generation;
            Console.WriteLine("Dime una de las 6 generaciones.");
            while (!(Int32.TryParse(Console.ReadLine(), out generation) && generation >= 1 && generation < 7))
                Console.WriteLine("Tienes que poner un valor entre 1 y 6");

            //llamamos a la función que nos devolverá un string con el nombre del pokemon 
            string pokemonName = Functions.strongestPokemon(FilePokemon, generation);
            Console.WriteLine(pokemonName);

            //llamamos a la segunda función que creará un fichero con la información de los pokemon de dos tipos
            Functions.filterPokemon(FilePokemon);

        }
    }
}


