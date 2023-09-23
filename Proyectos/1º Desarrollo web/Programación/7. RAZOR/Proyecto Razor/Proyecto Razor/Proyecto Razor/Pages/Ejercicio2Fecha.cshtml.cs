using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Proyecto_Razor.Pages
{
    public class Ejercicio2FechaModel : PageModel
    {
        [IgnoreAntiforgeryToken(Order = 1001)]
        public void OnGet()
        {
        }
    }
}
