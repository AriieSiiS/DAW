using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PO03_01.Models
{
    public class AppUser : IdentityUser
    {

        [DisplayName("Nombre Completo")]
        [StringLength(100, ErrorMessage = "El campo {0} debe tener al menos {2} caracteres.", MinimumLength = 10)]
        [Required(ErrorMessage = "El campo es obligatorio.")]
        public string FullName { get; set; }

        [Required]
        public bool isActive { get; set; }


    }
}
