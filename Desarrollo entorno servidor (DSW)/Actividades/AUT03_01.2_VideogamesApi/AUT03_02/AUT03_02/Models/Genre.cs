using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AUT03_02.Models
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "El campo Título debe tener entre 5 y 15 letras.")]
        public string Name { get; set; }

        [ForeignKey(nameof(GenreId))]
        public Game Game { get; set; }
    }
}
