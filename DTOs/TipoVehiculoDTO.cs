using Delivery.Models;
using System.ComponentModel.DataAnnotations;

namespace Delivery.DTOs
{
    public class TipoVehiculoDTO
    {
        public TipoVehiculoDTO()
        {
            Vehiculos = new HashSet<VehiculoDTO>();

        }
        [Required]
        public int IdTipoVehi { get; set; }
        [Required]

        public string Nombre { get; set; } = null!;

        public virtual ICollection<VehiculoDTO> Vehiculos { get; set; }
    }
}
