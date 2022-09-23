using Delivery.Models;
using System.ComponentModel.DataAnnotations;

namespace Delivery.DTOs
{
    public class PedidoDTO
    {
        [Required]
       
        public string Numero { get; set; } = null!;
        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaHoraCreacion { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaHoraEntrega { get; set; }
        [Required]
        public string Calle { get; set; } = null!;
        [Required]
        public int Persona { get; set; }
        [Required]
        public int Factura { get; set; }
        [Required]
        public int Localidad { get; set; }
        [Required]
        public string NombreCliente { get; set; } = null!;
        [Required]
        public int TelefonoCliente { get; set; }
        public int Detalle { get; set; }

        public virtual FacturaDTO FacturaNavigation { get; set; } = null!;
        public virtual DetallePedidoDTO IdPedidoNavigation { get; set; } = null!;
        public virtual LocalidadDTO LocalidadNavigation { get; set; } = null!;
        public virtual PersonaDTO PersonaNavigation { get; set; } = null!;
    }
}
