using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    [IgnoreAntiforgeryToken(Order = 1001)]
    public class Ejercicio2ResueltoModel : PageModel
    {
        public void OnGet()
        {
        }

        public int ContarPalabras(string frase, string palabra)
        {
            int contador = 0;
            if (!string.IsNullOrEmpty(frase) && !string.IsNullOrEmpty(palabra))
            {
                string[] palabras = frase.Split(' '); // Dividimos el texto en palabras separandolas por el espacio
                foreach (string p in palabras)
                {
                    if (string.Equals(p, palabra, StringComparison.OrdinalIgnoreCase)) // Comparación sin distinguir mayúsculas y minúsculas
                    {
                        contador++;
                    }
                }
            }
            return contador;
        }
    }
}
