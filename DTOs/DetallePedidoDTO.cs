using Delivery.Models;

namespace Delivery.DTOs
{
    public class DetallePedidoDTO
    {
        public int Cantidad { get; set; }
        public int SubTotal { get; set; }
        public int TipoProducto { get; set; }
        public string Detalles { get; set; } = null!;

        public virtual ProductoDTO TipoProductoNavigation { get; set; } = null!;
        public virtual PedidoDTO Pedido { get; set; }=null!;
    }
}
