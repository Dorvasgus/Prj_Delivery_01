namespace Delivery.DTOs
{
    public class ClienteDTO
    {
        public int IdCliente { get; set; }
        public string Nit { get; set; } = null!;
        public string RazonSocial { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int Localidad { get; set; }

    }
}
