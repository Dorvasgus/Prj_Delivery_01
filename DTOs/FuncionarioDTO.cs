using Delivery.Models;
using System.ComponentModel.DataAnnotations;

namespace Delivery.DTOs
{
    public class FuncionarioDTO
    {
        public FuncionarioDTO()
        {
            Personas = new HashSet<PersonaDTO>();
        }
        [Required]
        public string UserName { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
        [Required]
        [Url]
        public string Correo { get; set; } = null!;
        [Required]
        public string Rol { get; set; } = null!;
        [Required]
        public int Vehiculo { get; set; }

        public virtual VehiculoDTO VehiculoNavigation { get; set; } = null!;
        public virtual ICollection<PersonaDTO> Personas { get; set; }
    }
}
