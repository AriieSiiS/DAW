using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PO03_01.Models
{
    public class RegisterUser
    {
        [Required(ErrorMessage = "El campo Email es obligatorio.")]
        [EmailAddress(ErrorMessage = "Por favor, introduce un correo electrónico válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo Contraseña es obligatorio.")]
        public string Password { get; set; }

        [StringLength(100, ErrorMessage = "El campo {0} debe tener al menos {2} caracteres.", MinimumLength = 10)]
        [Required(ErrorMessage = "El campo es obligatorio.")]
        public string FullName { get; set; }

    }
}
