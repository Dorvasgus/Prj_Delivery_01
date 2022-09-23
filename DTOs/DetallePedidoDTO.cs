using Delivery.Models;
using System.ComponentModel.DataAnnotations;

namespace Delivery.DTOs
{
    public class DetallePedidoDTO
    {
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public int SubTotal { get; set; }
        [Required]
        public int TipoProducto { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public string Detalles { get; set; } = null!;

        public virtual ProductoDTO TipoProductoNavigation { get; set; } = null!;
        public virtual PedidoDTO Pedido { get; set; }=null!;
    }
}
