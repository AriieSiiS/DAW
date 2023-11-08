using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AUT02_05.Models
{
    public class Frases
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "English")]
        [Required(ErrorMessage = "El campo  es obligatorio.")]
        [StringLength(90, MinimumLength = 3, ErrorMessage = "El campo Título debe tener entre 3 y 90 letras.")]
        public string? Eng { get; set; }
        
        [Display(Name = "Spanish")]
        [Required(ErrorMessage = "El campo  es obligatorio.")]
        [StringLength(90, MinimumLength = 3, ErrorMessage = "El campo Título debe tener entre 3 y 90 letras.")]
        public string? Esp { get; set; }

        //clave foránea para enlazar con el diccionario
        public int EspengId { get; set; }

        public Espeng? Espeng { get; set; }

        //clave foránea para enlazar con el usuario que ha escrito el comentario
        public string? UserId { get; set; }



    }
}
