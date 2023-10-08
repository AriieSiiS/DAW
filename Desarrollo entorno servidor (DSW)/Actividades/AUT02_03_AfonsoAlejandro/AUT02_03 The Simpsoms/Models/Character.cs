using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AUT02_03_The_Simpsoms.Models
{
    public class Character
    {
        public int ID { get; set; }

        [StringLength(15, MinimumLength =3, ErrorMessage = "El nombre tiene que tener entre 3 y 15 caracteres.")]
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [DisplayName("Nombre")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "La edad es obligatoria.")]
        [Range(0, 100, ErrorMessage = "El valor de edad debe estar entre 0 y 100.")]
        [DisplayName("Edad")]
        public int Age { get; set; }

        [StringLength(15, MinimumLength = 3, ErrorMessage = "El trabajo tiene que tener entre 5 y 20 caracteres.")]
        [Required(ErrorMessage = "Poner su trabajo es obligatorio.")]
        [DisplayName("Trabajo")]
        public string? Job { get; set; }
    }
}
