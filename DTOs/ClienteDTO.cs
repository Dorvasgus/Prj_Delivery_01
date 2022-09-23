using Delivery.Models;
using System.ComponentModel.DataAnnotations;

namespace Delivery.DTOs
{
    public class ClienteDTO
    {
        [Required]
        public string Nit { get; set; } = null!;
        [Required]
        public string RazonSocial { get; set; } = null!;
        [Required]
        public string UserName { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
        [Required]
        public int Localidad { get; set; }

        public virtual LocalidadDTO LocalidadNavigation { get; set; } = null!;
        public virtual PersonaDTO? Persona { get; set; }
    }
}
