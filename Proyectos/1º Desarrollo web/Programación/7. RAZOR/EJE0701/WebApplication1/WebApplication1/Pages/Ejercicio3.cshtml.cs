using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    [IgnoreAntiforgeryToken(Order = 1001)]
    public class Ejercicio3Model : PageModel
    {
        public void OnGet()
        {
        }

        public int CalcularDiasHastaHoy(DateTime fecha)
        {
            DateTime hoy = DateTime.Today;

            if (fecha >= hoy)
            {
                throw new ArgumentException("La fecha proporcionada debe ser anterior al día de hoy.");
            }
            else
            {
                TimeSpan diferencia = hoy - fecha;
                int dias = diferencia.Days;

                return dias;
            }

        }
    }
}
