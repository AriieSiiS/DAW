using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Proyecto_Razor.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Proyecto_Razor.Pages
{
    [IgnoreAntiforgeryToken(Order = 1001)]
    public class TestModel : PageModel
    {
        private readonly MisDatos _datos;

        public TestModel(MisDatos datos)
        {
            _datos = datos;
        }

        private const int PageSize = 3; // Tama�o de p�gina, en este caso, 3 elementos por p�gina
        public int CurrentPage { get; set; } // P�gina actual
        public int TotalPages { get; set; } // Total de p�ginas
        public List<Juego> JuegosValidos { get; set; }
        public DateTime FechaSeleccionada { get; set; }


        public void OnGet(DateTime fecha,int pagina = 1)
        {
            DateTime fechaSeleccionada = FechaSeleccionada;
            if (fechaSeleccionada < fecha)
            {
                FechaSeleccionada = fecha;
                fechaSeleccionada = fecha;
            }
            // Obtener los juegos v�lidos seg�n la fecha y aplicar la paginaci�n
            var juegosFiltrados = _datos.JuegosPokemon
                .Where(juegoPokemon => juegoPokemon.FechaLanzamiento < fechaSeleccionada)
                .Select(juegoPokemon => new Juego
                {
                    Nombre = juegoPokemon.Nombre,
                    Plataforma = juegoPokemon.Plataforma,
                    FechaLanzamiento = juegoPokemon.FechaLanzamiento.ToString("dd/MM/yyyy")
                });

            int totalJuegos = juegosFiltrados.Count();
            int totalPages = (int)Math.Ceiling((double)totalJuegos / PageSize);

            TotalPages = totalPages;

            JuegosValidos = juegosFiltrados
                .Skip((pagina - 1) * PageSize)
                .Take(PageSize)
                .ToList();

            CurrentPage = pagina;
        }

        public class Juego
        {
            public string Nombre { get; set; }
            public string Plataforma { get; set; }
            public string FechaLanzamiento { get; set; }
        }
    }
}





