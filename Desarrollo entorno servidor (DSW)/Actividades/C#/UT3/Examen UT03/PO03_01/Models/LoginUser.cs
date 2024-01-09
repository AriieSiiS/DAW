using System.ComponentModel.DataAnnotations;

namespace PO03_01.Models
{
    public class LoginUser 
    {
        [Required(ErrorMessage = "El campo Email es obligatorio.")]
        [EmailAddress(ErrorMessage = "Por favor, introduce un correo electrónico válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo Contraseña es obligatorio.")]
        public string Password { get; set; }
    }
}
