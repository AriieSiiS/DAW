using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace AUT03_02.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "El campo Título debe tener entre 5 y 15 letras.")]
        public string Name { get; set; }

        public int GenreId { get; set; }
        [ForeignKey(nameof(GenreId))]
        public Genre? Genre { get; set; }
    }
}
