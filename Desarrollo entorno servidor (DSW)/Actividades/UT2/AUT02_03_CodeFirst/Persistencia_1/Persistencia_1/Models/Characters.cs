using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Persistencia_1.Models
{
    public class Characters
    {
        public int ID { get; set; }

        [StringLength(25, MinimumLength = 3, ErrorMessage = "El nombre tiene que tener entre 3 y 15 caracteres.")]
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [DisplayName("Nombre")]
        public string? Name { get; set; }

        [Range(1, 100, ErrorMessage = "El valor de edad debe estar entre 0 y 100.")]
        [Required(ErrorMessage = "La edad es obligatoria.")]
        [DisplayName("Edad")]
        public int Age { get; set; }

        [Range(1, 2.50, ErrorMessage = "El valor de altura debe estar entre 1.50 y 2.50")]
        [Required(ErrorMessage = "La altura es obligatoria.")]
        [DisplayName("Altura")]
        public decimal? Height { get; set; }

        [StringLength(25, MinimumLength = 3, ErrorMessage = "El equipo tiene que tener entre 5 y 20 caracteres.")]
        [Required(ErrorMessage = "El equipo es obligatorio.")]
        [DisplayName("Equipo")]
        public string? Team { get; set; }

        [StringLength(25, MinimumLength = 3, ErrorMessage = "La posición tiene que tener entre 5 y 20 caracteres.")]
        [Required(ErrorMessage = "La posición es obligatorio.")]
        [DisplayName("Posición")]
        public string? Position { get; set; }

        [Required(ErrorMessage = "Ponerlo es obligatorio.")]
        [DisplayName("¿Retirado?")]
        public bool Retired { get; set; }
    }
}
