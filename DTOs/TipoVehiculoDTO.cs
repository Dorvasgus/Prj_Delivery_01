using Delivery.Models;

namespace Delivery.DTOs
{
    public class TipoVehiculoDTO
    {
        public TipoVehiculoDTO()
        {
            Vehiculos = new HashSet<VehiculoDTO>();
        }
        public int IdTipoVehi { get; set; }

        public string Nombre { get; set; } = null!;

        public virtual ICollection<VehiculoDTO> Vehiculos { get; set; }
    }
}
