using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Proyecto_Razor.Models;

namespace Proyecto_Razor.Pages
{
    [IgnoreAntiforgeryToken(Order = 1001)]
    public class Ejercicio5Model : PageModel
    {
        public readonly MisDatos Datos;
        [ActivatorUtilitiesConstructor]
        public Ejercicio5Model(MisDatos datos)
        {
            Datos = datos;
        }
        public void OnGet()
        {
        }
    }
}
