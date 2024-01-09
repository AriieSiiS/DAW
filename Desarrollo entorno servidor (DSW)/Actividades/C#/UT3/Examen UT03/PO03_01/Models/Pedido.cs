using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PO03_01.Models
{
    public class Pedido
    {
        public int Id { get; set; }

        [Range(1, 10, ErrorMessage = "El campo  debe estar entre 1 y 10.")]
        public int Amount { get; set; }

        [DisplayName("Dirección")]
        [Required(ErrorMessage = "El campo es obligatorio.")]
        [StringLength(100, ErrorMessage = "El campo {0} debe tener al menos {2} caracteres.", MinimumLength = 5)]
        public string Address { get; set; }

        public int AlbumId { get; set; }

        public Album? Album { get; set; }

        //id del usuario
        public string? ComercialId { get; set; }
    }
}
