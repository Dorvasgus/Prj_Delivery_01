using Delivery.Models;
using System.ComponentModel.DataAnnotations;

namespace Delivery.DTOs
{
    public class PersonaDTO
    {
        public PersonaDTO()
        {
            Pedidos = new HashSet<PedidoDTO>();
        }
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

        public virtual ClienteDTO IdPersonaNavigation { get; set; } = null!;
        public virtual FuncionarioDTO RolNavigation { get; set; } = null!;
        public virtual ICollection<PedidoDTO> Pedidos { get; set; }
    }
}
