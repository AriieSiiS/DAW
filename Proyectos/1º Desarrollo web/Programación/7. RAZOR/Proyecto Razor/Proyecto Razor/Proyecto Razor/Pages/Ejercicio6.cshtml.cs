using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Proyecto_Razor.Models;

namespace Proyecto_Razor.Pages
{
    [IgnoreAntiforgeryToken(Order = 1001)]
    public class Ejercicio6Model : PageModel
    {
        public readonly MisDatos Datos;
        [ActivatorUtilitiesConstructor]
        public Ejercicio6Model(MisDatos datos)
        {
            Datos = datos;
        }
        public void OnGet()
        {
        }

        public List<Pokemon> PokemonSeleccionado { get; set; }

        public void RellenarPoke(string poke)
        {
            PokemonSeleccionado = Datos.Pokemon
                .Where(pokemon => pokemon.Nombre == poke)
                .Select(pokemon => new Pokemon
                {
                    NumeroPokedex = pokemon.NumeroPokedex,
                    Nombre = pokemon.Nombre,
                    Peso = pokemon.Peso,
                    Altura = pokemon.Altura
                })
                .ToList();
        }
        public class Pokemon
        {
            public int NumeroPokedex { get; set; }
            public string Nombre { get; set; }
            public decimal Peso { get; set; }
            public decimal Altura { get; set; }
        }
    }
}
