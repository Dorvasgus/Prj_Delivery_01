using Delivery.Models;
using System.ComponentModel.DataAnnotations;

namespace Delivery.DTOs
{
    public class FacturaDTO
    {
        public FacturaDTO()
        {
            Pedidos = new HashSet<PedidoDTO>();
        }
        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaHoraEmision { get; set; }
        [Required]
        [StringLength(maximumLength: 300)]
        public string Detalle { get; set; } = null!;
        [Required]
        public string EstadodelPedido { get; set; } = null!;
        [Required]
        public string Nit { get; set; } = null!;

        public virtual ICollection<PedidoDTO> Pedidos { get; set; }
    }
}
