using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Model
{
    public class Videogame
    {

        public int Id { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "El campo Título debe tener entre 5 y 15 letras.")]
        public string? Title { get; set; }

        [Required]
        [StringLength(12, MinimumLength = 2, ErrorMessage = "El campo Título debe tener entre 2 y 12 letras.")]
        public string? Genre { get; set; }
    }
}