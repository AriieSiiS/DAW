using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AUT02_04.Models
{
    public class Review
    {
        public int Id { get; set; }

        [Display(Name = "Título")]
        [Required(ErrorMessage = "El campo Título es obligatorio.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El campo Título debe tener entre 3 y 30 letras.")]
        public string? Title { get; set; }

        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "El campo Descripción es obligatorio.")]
        [StringLength(500, MinimumLength = 5, ErrorMessage = "El campo Descripción debe tener al menos 5 letras.")]
        public string? Description { get; set; }

        [Display(Name = "Puntuación")]
        [Required(ErrorMessage = "El campo Puntuación es obligatorio.")]
        [Range(1, 5, ErrorMessage = "El campo Puntuación debe estar entre 1 y 5.")]
        public int? Value { get; set; }

        //clave foránea para enlazar con los artistas
        public int ArtistId { get; set; }

        public Artist? Artist { get; set; }

    }
}
