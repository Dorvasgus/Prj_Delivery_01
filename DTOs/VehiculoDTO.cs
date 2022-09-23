using Delivery.Models;
using System.ComponentModel.DataAnnotations;

namespace Delivery.DTOs
{
    public class VehiculoDTO
    {
        public VehiculoDTO()
        {
            Funcionarios = new HashSet<FuncionarioDTO>();
        }
        [Required]
        public string Patente { get; set; } = null!;
        [Required]
        public string Modelo { get; set; } = null!;
        [Required]
        public int TipoVehiculo { get; set; }
        [Required]
        public string Licencia { get; set; } = null!;

        public virtual TipoVehiculoDTO TipoVehiculoNavigation { get; set; } = null!;
        public virtual ICollection<FuncionarioDTO> Funcionarios { get; set; }
    }
}
