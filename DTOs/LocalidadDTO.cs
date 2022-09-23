using Delivery.Models;
using System.ComponentModel.DataAnnotations;

namespace Delivery.DTOs
{
    public class LocalidadDTO
    {
        public LocalidadDTO()
        {
            Clientes = new HashSet<ClienteDTO>();
            Pedidos = new HashSet<PedidoDTO>();
        }
        [Required]
        public string Calle { get; set; } = null!;
        [Required]
        public string Barrio { get; set; } = null!;
        [Required]
        public string Zona { get; set; } = null!;

        public virtual ICollection<ClienteDTO> Clientes { get; set; }
        public virtual ICollection<PedidoDTO> Pedidos { get; set; }
    }
}
