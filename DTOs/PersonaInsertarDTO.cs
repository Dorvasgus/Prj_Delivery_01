using System.ComponentModel.DataAnnotations;

namespace Delivery.DTOs
{
    public class PersonaInsertarDTO
    {
        [Required]
        public string Nombre { get; set; } = null!;
        [Required]
        public string Apellido { get; set; } = null!;
        [Required]
        public string NumeroIdentidad { get; set; } = null!;
        [Required]
        public int Rol { get; set; }
        [Required]
        public int Telefono { get; set; }
    }
}
